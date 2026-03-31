using APIUsuarios.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;

namespace APIUsuarios.Services
{
    public class UsuariosService
    {
        private readonly IMongoCollection<Usuario> _usuariosCollection;

        public UsuariosService(
            IOptions<UsuarioDatabaseSettings> usuarioDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                usuarioDatabaseSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                usuarioDatabaseSettings.Value.DatabaseName);

            _usuariosCollection = mongoDatabase.GetCollection<Usuario>(
                usuarioDatabaseSettings.Value.UsuarioCollectionName);
        }

        public async Task<List<Usuario>> GetAsync() =>
            await _usuariosCollection.Find(_ => true).ToListAsync();

        public async Task<Usuario?> GetAsync(string id) =>
            await _usuariosCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task<Usuario?> GetByEmailAsync(string email) =>
            await _usuariosCollection.Find(x => x.Email == email).FirstOrDefaultAsync();

        public async Task CreateAsync(Usuario newUsuario) =>
            await _usuariosCollection.InsertOneAsync(newUsuario);

        public async Task UpdateAsync(string id, Usuario updatedUsuario) =>
            await _usuariosCollection.ReplaceOneAsync(x => x.Id == id, updatedUsuario);

        public async Task RemoveAsync(string id) =>
            await _usuariosCollection.DeleteOneAsync(x => x.Id == id);
    }
}