using System;
using Microsoft.Extensions.Options;
using Npgsql;
using NpgsqlTypes;
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

        public void Write(string id, byte[] photo)
        {
            using var conn = new NpgsqlConnection(_connection.Matteo);

            const string sql = "update \"Service\" set \"Image\" = @Image Where \"Id\" = @Id";

            using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlDbType.Uuid;
            param1.Value = new Guid(id);

            var param2 = command.CreateParameter();
            param2.ParameterName = "@Image";
            param2.NpgsqlDbType = NpgsqlDbType.Bytea;
            param2.Value = photo;

            command.Parameters.Add(param1);
            command.Parameters.Add(param2);

            conn.Open();
            command.ExecuteNonQuery();
        }
    }

    public interface IMatteoWritingGateway
    {
        void Write(string id, byte[] image);
    }
}
