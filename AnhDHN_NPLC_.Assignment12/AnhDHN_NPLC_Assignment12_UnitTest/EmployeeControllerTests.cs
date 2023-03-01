using AnhDHN_NPLC_Assignment12.Exercise.Exercise3;
using Moq;

namespace AnhDHN_NPLC_Assignment12.Exercise.UnitTest
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        // This test verifies that the DeleteEmployee method of the controller
        // calls the DeleteEmployee method of the storage object with the correct ID
        [Test]
        public void DeleteEmployee_WhenCalled_DeleteTheEmployeeFromDb()
        {
            // Create a mock of the IEmployeeStorage interface
            var storage = new Mock<IEmployeeStorage>();

            // Create an instance of the EmployeeController class, passing in the mock object
            var controller = new EmployeeController(storage.Object);

            // Call the DeleteEmployee method of the controller with an ID of 1
            controller.DeleteEmployee(1);

            // Verify that the DeleteEmployee method of the storage object was called with an ID of 1
            storage.Verify(s => s.DeleteEmployee(1));
        }
    }
}
