[assembly: System.CLSCompliant(true)]
[assembly: System.Resources.NeutralResourcesLanguage("en-US")]
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: System.Runtime.Versioning.TargetFramework(".NETFramework,Version=v4.6", FrameworkDisplayName=".NET Framework 4.6")]
namespace System.Reactive.Linq
{
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    public static class QbservableAliases
    {
        public static System.Reactive.Linq.IQbservable<TSource> Filter<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, bool>> predicate) { }
        public static System.Reactive.Linq.IQbservable<TSource> Filter<TSource>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, bool>> predicate) { }
        public static System.Reactive.Linq.IQbservable<TOther> FlatMap<TSource, TOther>(this System.Reactive.Linq.IQbservable<TSource> source, System.IObservable<TOther> other) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Threading.Tasks.Task<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.IObservable<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Threading.Tasks.Task<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TResult>>> onNext, System.Linq.Expressions.Expression<System.Func<System.Exception, System.IObservable<TResult>>> onError, System.Linq.Expressions.Expression<System.Func<System.IObservable<TResult>>> onCompleted) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.IObservable<TResult>>> onNext, System.Linq.Expressions.Expression<System.Func<System.Exception, System.IObservable<TResult>>> onError, System.Linq.Expressions.Expression<System.Func<System.IObservable<TResult>>> onCompleted) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, TCollection, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.IObservable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, TCollection, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Threading.Tasks.Task<TTaskResult>>> taskSelector, System.Linq.Expressions.Expression<System.Func<TSource, TTaskResult, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, int, TCollection, int, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.IObservable<TCollection>>> collectionSelector, System.Linq.Expressions.Expression<System.Func<TSource, int, TCollection, int, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Threading.Tasks.Task<TTaskResult>>> taskSelector, System.Linq.Expressions.Expression<System.Func<TSource, int, TTaskResult, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>>> taskSelector, System.Linq.Expressions.Expression<System.Func<TSource, TTaskResult, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>>> taskSelector, System.Linq.Expressions.Expression<System.Func<TSource, int, TTaskResult, TResult>> resultSelector) { }
        public static System.Reactive.Linq.IQbservable<TResult> Map<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, TResult>> selector) { }
        public static System.Reactive.Linq.IQbservable<TResult> Map<TSource, TResult>(this System.Reactive.Linq.IQbservable<TSource> source, System.Linq.Expressions.Expression<System.Func<TSource, int, TResult>> selector) { }
    }
}
namespace System.Reactive.Observable.Aliases
{
    public static class QueryLanguage
    {
        public static System.IObservable<TSource> Filter<TSource>(this System.IObservable<TSource> source, System.Func<TSource, bool> predicate) { }
        public static System.IObservable<TSource> Filter<TSource>(this System.IObservable<TSource> source, System.Func<TSource, int, bool> predicate) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.Tasks.Task<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.Tasks.Task<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> selector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TResult>> selector) { }
        public static System.IObservable<TOther> FlatMap<TSource, TOther>(this System.IObservable<TSource> source, System.IObservable<TOther> other) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TResult>> onNext, System.Func<System.Exception, System.IObservable<TResult>> onError, System.Func<System.IObservable<TResult>> onCompleted) { }
        public static System.IObservable<TResult> FlatMap<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TResult>> onNext, System.Func<System.Exception, System.IObservable<TResult>> onError, System.Func<System.IObservable<TResult>> onCompleted) { }
        public static System.IObservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, TCollection, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, TTaskResult, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Collections.Generic.IEnumerable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TCollection, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.IObservable<TCollection>> collectionSelector, System.Func<TSource, int, TCollection, int, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, int, TTaskResult, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, TTaskResult, TResult> resultSelector) { }
        public static System.IObservable<TResult> FlatMap<TSource, TTaskResult, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, System.Threading.CancellationToken, System.Threading.Tasks.Task<TTaskResult>> taskSelector, System.Func<TSource, int, TTaskResult, TResult> resultSelector) { }
        public static System.IObservable<TResult> Map<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, TResult> selector) { }
        public static System.IObservable<TResult> Map<TSource, TResult>(this System.IObservable<TSource> source, System.Func<TSource, int, TResult> selector) { }
    }
}