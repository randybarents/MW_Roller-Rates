using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public int User_ID { get; set; }
        public int Rollercoaster_ID { get; set; }
    }
}
