

using Diia;
using Diia.Documents;
using Diia.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        Container newContainer = new Container(
            new IDocumentAction[]
            {
                new Passport(
                    new PersonInfo("Renat", "Kramarovskyi", false, new DateTime(2005, 7, 24)),
                        new DateTime(2023, 5, 17), 
                        "12378",
                        779746,
                        "face1.png"),
                    new DriverLicense(
                        new PersonInfo("Vovan4ik", "Chobik", false, new DateTime(2003, 4, 13)),
                        new DateTime(2023, 5, 17), 
                        "17878",
                        163987,
                        "face2.png"),
                    new MilitaryLicense(
                        new PersonInfo("Roman", "Kovalchuk", false, new DateTime(2010, 1, 17)),
                        new DateTime(2024, 1, 22), 
                        "17878",
                        163987)
            }
        );
        newContainer.sortDocuments();
        newContainer.leftShiftDocuments();
        newContainer.showAllDocumentsInfo();
    }
}