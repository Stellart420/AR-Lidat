﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using static UnityEngine.Debug;
using System.Runtime.CompilerServices;
using Numba.Awaiting.Engine;

/// <summary>
/// This class contains 'GetAwaiter' extensions methods for many classes.
/// </summary>
public static class Extensions
{
    public static ManualAwaiter GetAwaiter(this YieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);

    public static ManualAwaiter GetAwaiter(this CustomYieldInstruction instructuion) => ExtensionsHelper.GetAwaiterForInstuction(instructuion);

    public static ManualAwaiter GetAwaiter(this IEnumerator enumerator) => ExtensionsHelper.GetAwaiterForEnumerator(enumerator);

    public static ManualAwaiter<AssetBundleRequest> GetAwaiter(this AssetBundleRequest request) => ExtensionsHelper.GetAwaiterWithResultForInstuction(request);

    /// <summary>
    /// Just await current task and rethrow error if it happens.
    /// </summary>
    /// <param name="task">Current task.</param>
    public static async void CatchErrors(this Task task) => await task;

    /// <summary>
    /// Convert task to IEnumerator object.
    /// </summary>
    /// <param name="task">Current task.</param>
    public static IEnumerator AsEnumerator(this Task task)
    {
        while (!task.IsCompleted) yield return null;
    }

    /// <summary>
    /// Convert Task object to Coroutine object.
    /// </summary>
    /// <param name="task">Current task.</param>
    public static Coroutine AsCoroutine(this Task task) => RoutineHelper.Instance.StartCoroutine(task.AsEnumerator());
}