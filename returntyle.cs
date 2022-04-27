IActionResult 
    any thing 

ActionResult<T>
    any status and T

specific 
    only T


/// cretae custom action result 


/// add new view model 

public class customActionResultVm{
    public Exception  Exception{ get ; set;}
    public object Data {get ;set;}   // if you need to specific type ( public Publisher data {get ;set;})

}


// nwe folder action result 

public class CustomActionResult: IActionResult {

    private readonly customActionResultVm _result;

    public CustomActionResult(customActionResultVm result)
    {
        _result = result;
    }

    public async Task ExecuteResultAsync(ActionContext context){
        // throw new Not impolementedException();

        var objResult = new ObjectResult(_result.Exception ?? _result.pulisher as object ){
            statusCoed = _result.Exception != null ? statusCode.Status500InternalServerError : statusCOde.status200ok        
        };

        await objectResult.ExecuteResultAsync( context );

    }

}

// hwo to create responce onbject 

var _response = new customActionResultVm(){
    publiserh = responce 
};
return new CustomActionResult(_response);