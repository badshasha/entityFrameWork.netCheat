// try to catch internal of external additional issues 

// try 
    //  applicaitno 
        System.ApplicationException 
    //  System 
        System.Ststem exception


most comman exception


// nullReferenceExepiton
// indeoutofrangeExeption
// ioException
// stackoverflowException
// outofMemoryException
// InvalidCastException
// arithmaticExeption


// ex


            try
            {
                return Ok(this._bookService.DeleteBook(id));
            }
            catch (Exception ex) {
                // return BadRequest("custom message")
                return BadRequest(ex.Message);
            }
            