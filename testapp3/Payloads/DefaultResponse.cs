namespace testapp3.Payloads
{
    public class DefaultResponse
    {
        public long id { get;set; }
        public string message { get;set; }
        public bool status { get;set; }

        public DefaultResponse()
        {

        }

        public DefaultResponse(long id, string message, bool status)
        {
            this.id = id;
            this.message = message;
            this.status = status;
        }

        public DefaultResponse setResponse(long id, string msg, bool status)
        {
            DefaultResponse response = new DefaultResponse();   
            response.id = id;   
            response.message = msg; 
            response.status = status;
            return response;
        }
    }
}
