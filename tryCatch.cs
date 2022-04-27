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
            

            // mulitple 
            
            try
            {
                int i = 1;
                int o = 0;
                int result = i / o; // this thing cause error 
                return Ok(this._bookService.DeleteBook(id));
            }
            catch (ArithmeticException ex) {
                return BadRequest($"{ex.Message} and custom message");
            }
            catch (Exception ex)
            {
                // return BadRequest("custom message")
                return BadRequest(ex.Message);
            }
            
        