using Google.Cloud.Firestore;

namespace URA_Execution_TimeTracker
{
    [FirestoreData]
    class LogClassFireStore
    {
        [FirestoreDocumentId]
        public Guid id { get; set; }
        [FirestoreProperty]
        public string UserName { get; set; }
        [FirestoreProperty]
        public string AlgorithmName { get; set; }
    }
}
    