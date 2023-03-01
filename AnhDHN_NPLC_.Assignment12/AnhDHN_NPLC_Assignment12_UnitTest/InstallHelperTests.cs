using Moq;
using AnhDHN_NPLC_Assignment12.Exercise.Exercise2;
using System.Net;

namespace AnhDHN_NPLC_Assignment12.Exercise.UnitTest
{
    [TestFixture]
    public class InstallHelperTests
    {
        private Mock<IFileDownloader> _fileDownloader;
        private InstallHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _fileDownloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallHelper(_fileDownloader.Object);
        }

        /// <summary>
        /// Test that verifies that DownloadInstaller returns false when the file download fails
        /// </summary>
        [Test]
        public void DownloadInstaller_DownloadFails_ReturnFalse()
        {
            // Arrange
            _fileDownloader.Setup(fd => fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>())).Throws<WebException>();

            // Act
            var result = _installerHelper.DownloadInstaller("CustomerName", "InstallerName");

            // Assert
            Assert.That(result, Is.False);
        }

        /// <summary>
        /// Test that verifies that DownloadInstaller returns true when the file download completes successfully
        /// </summary>
        [Test]
        public void DownloadInstaller_DownloadCompletes_ReturnsTrue()
        {
            // Act
            var result = _installerHelper.DownloadInstaller("CustomerName", "InstallerName");

            // Assert
            Assert.That(result, Is.True);
        }

    }
}
