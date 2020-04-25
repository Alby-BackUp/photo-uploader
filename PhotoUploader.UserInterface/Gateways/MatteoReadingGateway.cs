using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Npgsql;
using NpgsqlTypes;
using PhotoUploader.UserInterface.Abstract;
using PhotoUploader.UserInterface.Model;
using PhotoUploader.UserInterface.Options;

namespace PhotoUploader.UserInterface.Gateways
{
    public class MatteoReadingGateway : IMatteoReadingGateway
    {
        private readonly ConnectionStrings _connection;

        public MatteoReadingGateway(IOptions<ConnectionStrings> connection)
        {
            _connection = connection.Value;
        }

        public async IAsyncEnumerable<Service> ReadServices()
        {
            await using var conn = new NpgsqlConnection(_connection.Matteo);

            const string sql = "select \"Id\", \"Name\" from \"Service\" order by \"Name\"";

            conn.Open();

            await using var command = new NpgsqlCommand(sql, conn);

            var dr = await command.ExecuteReaderAsync();

            while (dr.Read()) yield return new Service((Guid) dr[0], dr[1] as string);
        }

        public async IAsyncEnumerable<Image> ReadImagesPerService(Guid id)
        {
            await using var conn = new NpgsqlConnection(_connection.Matteo);

            const string sql = "select  \"Id\", \"Name\", \"Extension\", \"ServiceId\" from \"Image\" where \"ServiceId\" = @Id order by \"Name\"";

            await using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlDbType.Uuid;
            param1.Value = id;

            command.Parameters.Add(param1);

            conn.Open();
            var dr = await command.ExecuteReaderAsync();

            while (dr.Read()) yield return new Image((Guid) dr[0], dr[1] as string, dr[2] as string, (Guid) dr[3]);
        }
    }
}
