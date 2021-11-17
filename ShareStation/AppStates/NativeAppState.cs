using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareStation.AppStates
{
    public interface INativeAppState
    {

        public event EventHandler OnPickFiles;

        public event EventHandler OnFilesPicked;

        public void PickFiles();

        public void NotifyFilesPicked();
    }

    public class NativeAppState : INativeAppState
    {

        public event EventHandler OnPickFiles;

        public event EventHandler OnFilesPicked;

        public virtual void PickFiles() => OnPickFiles?.Invoke(this, EventArgs.Empty);

        public virtual void NotifyFilesPicked() => OnFilesPicked?.Invoke(this, EventArgs.Empty);
    }
}
