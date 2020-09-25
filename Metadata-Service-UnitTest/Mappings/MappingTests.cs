using AutoMapper;
using Metadata_Service.Mappings;
using NUnit.Framework;

namespace Metadata_Service_UnitTest.Mappings
{
    public class MappingTests
    {
        private MapperConfiguration _mappingConfig;

        [SetUp]
        public void Setup()
        {
            _mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddMaps(typeof(MappingProfile));
            });
        }

        [Test]
        public void Mapper_ShouldBeConfiguredCorrect_WhenMapping()
        {
            _mappingConfig.AssertConfigurationIsValid();
        }
    }
}