using System;
using System.Drawing;
using System.IO;
using Microsoft.Extensions.Options;
using Npgsql;

namespace PhotoUploader.UserInterface.Gateways
{
    public class MatteoWritingGateway : IMatteoWritingGateway
    {

        public MatteoWritingGateway()
        {
        }

        public void Write(string id, byte[] photo)
        {
            using var conn = new NpgsqlConnection("User ID=roalby@matteo;Password=hsad#24SSDa;Host=matteo.postgres.database.azure.com;Port=5432;Database=postgres;SSL Mode=Require");

            const string sql = "update \"Service\" set \"Image\" = @Image Where \"Id\" = @Id";

            using var command = new NpgsqlCommand(sql, conn);

            var param1 = command.CreateParameter();
            param1.ParameterName = "@Id";
            param1.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            param1.Value = new Guid(id);

            var param2 = command.CreateParameter();
            param2.ParameterName = "@Image";
            param2.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Bytea;
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
