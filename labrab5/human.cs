using System;
using System.Collections.Generic;
using System.Text;

namespace labrab5
{
    abstract public class human
    {

		protected int status;
		public human(int st) { status = st; }
		int return_status() { return status; }
		public abstract string CreateStatus();
    }
}
