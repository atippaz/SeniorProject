using Microsoft.AspNetCore.Mvc;

namespace ExportApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExportFileController : ControllerBase
    {
        public ExportFileController()
        {

        }

        public IActionResult FilterColumn()
        {
            try
            {
                return Ok(DummyDataBase.FilterColumn.First(x => x.Key == "").Value);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        public IActionResult MenuData()
        {
            try
            {
                return Ok(DummyDataBase.MenuName);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        public IActionResult ExportFileApi()
        {
            try
            {
                FilterDataRequest[] fileterDatas = new FilterDataRequest[]
              {
                    new FilterDataRequest { column = "",value="" },
                    new FilterDataRequest { column = "",value="" },
              };
                var columns = new string[] { };
                var data = createDataFilter(fileterDatas, columns, "");
                // send to node or use csv helper 
                return Ok(data);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
        class FilterDataRequest
        {
            public string column { get; set; }
            public string value { get; set; }
        }
        List<List<string>> createDataFilter(FilterDataRequest[] fileterDatas, string[] columns, string menuName)
        {
            var datas = DummyDataBase.DataDummy.FirstOrDefault(x => x.Key == menuName);
            List<List<string>> results = new();
            foreach (var data in datas.Value)
            {
                var temps = data.AsQueryable();
                foreach (var fileterData in fileterDatas)
                {
                    temps = temps.Where(x => x.Key == fileterData.column && x.Value == fileterData.value);
                }
                foreach (var column in columns)
                {
                    var result = new List<string>();
                    foreach (var temp in temps)
                    {
                        if (temp.Key == column)
                        {
                            result.Add(temp.Value);
                        }
                    }
                    results.Add(result);
                }
            }
            return results;
        }
        public IActionResult PreviewData()
        {
            try
            {
                FilterDataRequest[] fileterDatas = new FilterDataRequest[]
                {
                    new FilterDataRequest { column = "",value="" },
                    new FilterDataRequest { column = "",value="" },
                };
                var columns = new string[] { };
                return Ok(createDataFilter(fileterDatas, columns, "").Take(5).ToList());
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        public IActionResult ColumnData()
        {

            try
            {
                return Ok(DummyDataBase.DataColumn.First(x => x.Key == "").Value);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }
    }
}
