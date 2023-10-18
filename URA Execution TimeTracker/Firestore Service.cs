using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URA_Execution_TimeTracker
{
    public class FirestoreService
    {
        private readonly FirestoreDb _firestoreDb;
        private const string _collectionName = "Shoes";

        public FirestoreService(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task<List<LogClass>> GetAll()
        {
            var collection = _firestoreDb.Collection(_collectionName);
            var snapshot = await collection.GetSnapshotAsync();

            var logClassDodcument = snapshot.Documents.Select(s => s.ConvertTo<LogClassFireStore>()).ToList();

            return logClassDodcument.Select(ConvertDocumentToModel).ToList();
        }

        public async Task AddAsync(Shoe shoe)
        {
            var collection = _firestoreDb.Collection(_collectionName);
            var shoeDocument = ConvertModelToDocument(shoe);

            await collection.AddAsync(shoeDocument);
        }

        private static Shoe ConvertDocumentToModel(ShoeDocument shoeDocument)
        {
            return new Shoe
            {
                Id = shoeDocument.Id,
                Name = shoeDocument.Name,
                Brand = shoeDocument.Brand,
                Price = decimal.Parse(shoeDocument.Price)
            };
        }

        private static ShoeDocument ConvertModelToDocument(Shoe shoe)
        {
            return new ShoeDocument
            {
                Id = shoe.Id,
                Name = shoe.Name,
                Brand = shoe.Brand,
                Price = shoe.Price.ToString()
            };
        }
    }
}
