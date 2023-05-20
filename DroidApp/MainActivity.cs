using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Androidx.Credentials;
using Java.Lang;
using Java.Util.Concurrent;

namespace DroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            var manager = CredentialManager.Create(Application.Context);
            var req = new CreatePasswordRequest("username123", "password123");
            
            var cancellationSignal = new Android.OS.CancellationSignal();
            var executor = new Executor();
            var callback = new CredCallback();
            manager.CreateCredentialAsync(req, this, cancellationSignal, executor, callback);
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        
        class CredCallback : Java.Lang.Object, ICredentialManagerCallback
        {
            public void OnError(Object e)
            {
                // todo
            }

            public void OnResult(Object result)
            {
                // todo
            }
        }
        class Executor : Java.Lang.Object, IExecutor
        {
            public void Execute(IRunnable command)
            {
                //todo
            }
        }
    }
}