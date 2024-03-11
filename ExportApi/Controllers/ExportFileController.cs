using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace ExportApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExportFileController : ControllerBase
    {
        public ExportFileController()
        {

        }
        [HttpGet]
        public IActionResult FilterColumn([FromQuery] string menuId)
        {
            try
            {
                return Ok(DummyDataBase.FilterColumn.First(x => x.Key == menuId).Value);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpGet]
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

        [HttpPost]
        public IActionResult ExportFileApi([FromBody] RequestFile request)
        {
            try
            {
                var data = createDataFilter(request.filters ?? new FilterData[] { }, request.columns ?? new string[] { }, request.menuId);
                if (request.fileType == "xlsx")
                {
                    return Ok(data);
                }
                else if (request.fileType == "csv")
                {
                    return Ok(data);
                }
                else
                {
                    throw new Exception("error file type support!!");
                }
                // send to node or use csv helper 
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpPost]
        public IActionResult PreviewData([FromBody] RequestPreview request)
        {
            try
            {
                var result = createDataFilter(request.filters ?? new FilterData[0], request.columns ?? new string[0], request.menuId);
                result.body = result.body.Take(5).ToList();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        [HttpGet]
        public IActionResult ColumnData([FromQuery] string menuId)
        {

            try
            {
                return Ok(DummyDataBase.DataColumn.First(x => x.Key == menuId).Value);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }
        }

        // helper function 
        DataFormat createDataFilter(FilterData[] fileterDatas, string[] columns, string menuName)
        {
            var datas = DummyDataBase.DataDummy.FirstOrDefault(x => x.Key == menuName);
            if (!columns.Any())
                columns = DummyDataBase.DataColumn.FirstOrDefault(x => x.Key == menuName).Value.ToArray();
            DataFormat results = new();
            results.header = columns;
            foreach (var data in datas.Value)
            {
                var temps = data.AsQueryable();
                foreach (var fileterData in fileterDatas)
                {
                    temps = temps.Where(x => x.Key == fileterData.column && x.Value == fileterData.value);
                }
                foreach (var column in results.header)
                {
                    var result = new List<string>();
                    foreach (var temp in temps)
                    {
                        if (temp.Key == column)
                        {
                            result.Add(temp.Value);
                        }
                    }
                    results.body.Add(result);
                }
            }
            return results;
        }
    }
    public class FilterData
    {
        public string column { get; set; }
        public string value { get; set; }
    }
    public class RequestFile : RequestPreview
    {
        public string fileType { get; set; }
    }
    public class RequestPreview
    {
        public FilterData[]? filters { get; set; }
        public string[]? columns { get; set; }
        public string menuId { get; set; }
    }
    public class DataFormat
    {
        public string[] header { get; set; }
        public List<List<string>> body { get; set; } = new List<List<string>>();
    }
}
