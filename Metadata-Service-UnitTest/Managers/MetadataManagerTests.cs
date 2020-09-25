using System;
using System.Threading.Tasks;
using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using Metadata_Service.DataTransferObjects;
using Metadata_Service.Managers;
using Metadata_Service.Mappings;
using Metadata_Service.Models;
using Metadata_Service.Repositories;
using Moq;
using NUnit.Framework;

namespace Metadata_Service_UnitTest.Managers
{
    public class MetadataManagerTests
    {
        private IFixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
            _fixture.Customize(new AutoMoqCustomization());

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(typeof(MappingProfile));
            });
            _fixture.Inject(mappingConfig.CreateMapper());
        }

        [Test]
        public async Task CreateMetadataFromCmsInfo_ShouldInsertMetadata_GivenValidInput()
        {
            // Arrange
            var cmsInfoDto = _fixture.Create<CmsInfoInputDto>();

            var metadataRepo = _fixture.Freeze<Mock<IVideoRepository>>();
            metadataRepo.Setup(
                    rep => rep.InsertAsync(It.IsAny<Video>()))
                .ReturnsAsync((Video videoMetadata) => videoMetadata);

            // Sut
            var metadataManager = _fixture.Create<VideoManager>();

            // Act
            var metadataCreated = await metadataManager.InsertAsync(cmsInfoDto);

            // Assert
            metadataCreated.Should().BeEquivalentTo(cmsInfoDto, opt => opt.Excluding(x => x.ThemeId));
        }
    }
}
