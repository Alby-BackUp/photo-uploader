using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Npgsql;
using NpgsqlTypes;
using PhotoUploader.UserInterface.Abstract;
using PhotoUploader.UserInterface.Model;
using PhotoUploader.UserInterface.Options;

namespace PhotoUploader.UserInterface.Gateways
{
    public class MatteoWritingGateway : IMatteoWritingGateway
    {
        private readonly ConnectionStrings _connection;

        public MatteoWritingGateway(IOptions<ConnectionStrings> connection)
        {
            _connection = connection.Value;
        }

        public async Task Update(Image image)
        {
            await using var conn = new NpgsqlConnection(_connection.Matteo);

            // const string sql = "update \"Image\" set \"Name\" = @Name,  \"Stream\" = @Stream, \"Extension\" = @Extension  where \"Id\" = @Id";
            const string sql = "update \"Image\" set \"Name\" = @Name, \"Extension\" = @Extension  where \"Id\" = @Id";

            await using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlDbType.Uuid;
            param1.Value = image.Id;

            var param2 = command.CreateParameter();
            param2.ParameterName = "@Name";
            param2.NpgsqlDbType = NpgsqlDbType.Text;
            param2.Value = image.Name;

            var param3 = command.CreateParameter();
            param3.ParameterName = "@Stream";
            param3.NpgsqlDbType = NpgsqlDbType.Bytea;
            param3.Value = image.Stream;

            var param4 = command.CreateParameter();
            param4.ParameterName = "@Extension";
            param4.NpgsqlDbType = NpgsqlDbType.Text;
            param4.Value = image.Extension;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);

            conn.Open();
            await command.ExecuteNonQueryAsync();
        }

        public async Task Create(Image image)
        {
            await using var conn = new NpgsqlConnection(_connection.Matteo);

            const string sql =
                "insert into \"Image\" (\"Id\", \"ServiceId\", \"Name\", \"Stream\", \"Extension\") values ( @Id, @ServiceId, @Name, @Stream,  @Extension)";

            await using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlDbType.Uuid;
            param1.Value = image.Id;

            var param2 = command.CreateParameter();
            param2.ParameterName = "@ServiceId";
            param2.NpgsqlDbType = NpgsqlDbType.Uuid;
            param2.Value = image.ServiceId;

            var param3 = command.CreateParameter();
            param3.ParameterName = "@Name";
            param3.NpgsqlDbType = NpgsqlDbType.Text;
            param3.Value = image.Name;

            var param4 = command.CreateParameter();
            param4.ParameterName = "@Stream";
            param4.NpgsqlDbType = NpgsqlDbType.Bytea;
            param4.Value = image.Stream;

            var param5 = command.CreateParameter();
            param5.ParameterName = "@Extension";
            param5.NpgsqlDbType = NpgsqlDbType.Text;
            param5.Value = image.Extension;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);
            command.Parameters.Add(param3);
            command.Parameters.Add(param4);
            command.Parameters.Add(param5);

            conn.Open();
            await command.ExecuteNonQueryAsync();
        }

        public async Task Delete(Guid id)
        {
            await using var conn = new NpgsqlConnection(_connection.Matteo);

            const string sql = "delete from \"Image\" Where \"Id\" = @Id";

            await using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlDbType.Uuid;
            param1.Value = id;

            command.Parameters.Add(param1);

            conn.Open();
            await command.ExecuteNonQueryAsync();
        }
    }
}
