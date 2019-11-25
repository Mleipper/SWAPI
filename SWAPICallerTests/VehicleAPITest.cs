using SWApiCaller.Data;
using SWApiCaller.JSONModels;
using System;
using Xunit;

namespace SWAPICallerTests
{
    public class VehicleAPITest
    {
        private VehiclesAPI _TestAPICaller;
        public VehicleAPITest()
        {
            _TestAPICaller = new VehiclesAPI();
        }


        [Fact]
        public async System.Threading.Tasks.Task TestSaveModelAsync()
        {
            #region TestSetup
            var now = DateTime.Now;
            VehicleModel testVehicle = new VehicleModel() 
            { 
                Url = $"Test+{now}",
                Cargo_capacity= "Test"
            };


            #endregion
            await _TestAPICaller.SaveVehicle(testVehicle);
        }
    }
}
