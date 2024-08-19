using ASProject.Application.Services;
using ASProject.Domain.Dto.Report;
using ASProject.Tests.Configurations; 
using Microsoft.Extensions.Caching.Distributed;
using Moq;
using Xunit;

namespace ASProject.Tests;

public class CreateReportTest
{
    [Fact]
    public async Task GetReport_ShouldBe_NotNull()
    {
        //Arrange
        var mockReportRepository = MockRepositoriesGetter.GetMockReportRepository();
        var mockDistributedCache = new Mock<IDistributedCache>();
        var reportService = new ReportService(mockReportRepository.Object, null, null, null,
            null, null, null, mockDistributedCache.Object);
        
        //Act
        var result = await reportService.GetReportByIdAsync(1);

        //Assert
        Assert.NotNull(result);
    }

    [Fact]
    public async Task CreateReport_ShouldBe_Return_NewReport()
    {
        //Arrange
        var mockReportRepository = MockRepositoriesGetter.GetMockReportRepository();
        var mockUserRepository = MockRepositoriesGetter.GetMockUserRepository();
        var mockDistributedCache = new Mock<IDistributedCache>();
        var mapper = MapperConfiguration.GetMapperConfiguration();

        var user = MockRepositoriesGetter.GetUsers().FirstOrDefault();
        var createReportDto = new CreateReportDto("Test 1", "Test", user.Id);

        var reportService = new ReportService(mockReportRepository.Object, null, mockUserRepository.Object, null,
            mapper, null, null, mockDistributedCache.Object);
        
        //Act
        var result = await reportService.CreateReportAsync(createReportDto);
        
        //Assert
        Assert.True(result.IsSuccess);
    }
    
    [Fact]
    public async Task UpdateReport_ShouldBe_Return_NewData_For_Report()
    {
        //Arrange
        var mockReportRepository = MockRepositoriesGetter.GetMockReportRepository();
        var mapper = MapperConfiguration.GetMapperConfiguration();
        var report = MockRepositoriesGetter.GetReports().FirstOrDefault();
        var updateReportDto = new UpdateReportDto(1, "Test1", "test");
        
        var reportService = new ReportService(mockReportRepository.Object, null, null, null,
            mapper, null, null, null);
        
        //Act
        var result = await reportService.UpdateReportAsync(updateReportDto);
        
        //Assert
        Assert.True(result.IsSuccess);
    }
}