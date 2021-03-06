/*
 * Chuck SWAPI API
 *
 * .NET CORE C# Chuck SWAPI Project API.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: don@obeyi.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using chuckswapi.Attributes;

using Microsoft.AspNetCore.Authorization;
using chuckswapi.Models;

namespace chuckswapi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class SearchApiController : ControllerBase
    { 
        /// <summary>
        /// Takes a query string and returns a collection of Chuck Norris Jokes and Star Wars People based filtered by the query string provided.
        /// </summary>
        /// <remarks>people[], jokes[]</remarks>
        /// <param name="query">The query string that will be used to search for Jokes and People</param>
        /// <response code="200">OK</response>
        /// <response code="400">Bad request. Query string is required.</response>
        /// <response code="401">Authorization information is missing or invalid.</response>
        /// <response code="404">No results where found for this this query.</response>
        /// <response code="500">An unexpected error has occured, our support team has been notified and will resolve the issue as soon as possible.</response>
        [HttpPost]
        [Route("/donPabloNow/donPabloNow/1.0.0/search")]
        [ValidateModelState]
        [SwaggerOperation("Search")]
        [SwaggerResponse(statusCode: 200, type: typeof(Result), description: "OK")]
        public virtual IActionResult Search([FromQuery][Required()]string query)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Result));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 500 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(500);

            string exampleJson = null;
            exampleJson = "{\n  \"people\" : [ {\n    \"films\" : [ \"films\", \"films\" ],\n    \"homeworld\" : \"homeworld\",\n    \"gender\" : \"gender\",\n    \"skin_color\" : \"skin_color\",\n    \"edited\" : \"edited\",\n    \"created\" : \"created\",\n    \"mass\" : 6.02745618307040320615897144307382404804229736328125,\n    \"vehicles\" : [ \"vehicles\", \"vehicles\" ],\n    \"url\" : \"url\",\n    \"hair_color\" : \"hair_color\",\n    \"birth_year\" : \"birth_year\",\n    \"eye_color\" : \"eye_color\",\n    \"species\" : [ \"species\", \"species\" ],\n    \"starships\" : [ \"starships\", \"starships\" ],\n    \"name\" : \"name\",\n    \"height\" : 0.80082819046101150206595775671303272247314453125\n  }, {\n    \"films\" : [ \"films\", \"films\" ],\n    \"homeworld\" : \"homeworld\",\n    \"gender\" : \"gender\",\n    \"skin_color\" : \"skin_color\",\n    \"edited\" : \"edited\",\n    \"created\" : \"created\",\n    \"mass\" : 6.02745618307040320615897144307382404804229736328125,\n    \"vehicles\" : [ \"vehicles\", \"vehicles\" ],\n    \"url\" : \"url\",\n    \"hair_color\" : \"hair_color\",\n    \"birth_year\" : \"birth_year\",\n    \"eye_color\" : \"eye_color\",\n    \"species\" : [ \"species\", \"species\" ],\n    \"starships\" : [ \"starships\", \"starships\" ],\n    \"name\" : \"name\",\n    \"height\" : 0.80082819046101150206595775671303272247314453125\n  } ],\n  \"jokes\" : [ {\n    \"icon_url\" : \"icon_url\",\n    \"updated_at\" : \"updated_at\",\n    \"created_at\" : \"created_at\",\n    \"categories\" : [ \"categories\", \"categories\" ],\n    \"id\" : 1.46581298050294517310021547018550336360931396484375,\n    \"value\" : \"value\",\n    \"url\" : \"url\"\n  }, {\n    \"icon_url\" : \"icon_url\",\n    \"updated_at\" : \"updated_at\",\n    \"created_at\" : \"created_at\",\n    \"categories\" : [ \"categories\", \"categories\" ],\n    \"id\" : 1.46581298050294517310021547018550336360931396484375,\n    \"value\" : \"value\",\n    \"url\" : \"url\"\n  } ]\n}";
            exampleJson = "<Result>\n</Result>";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Result>(exampleJson)
            : default(Result);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
