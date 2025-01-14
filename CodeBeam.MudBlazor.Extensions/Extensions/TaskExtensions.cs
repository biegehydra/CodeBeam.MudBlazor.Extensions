﻿using MudBlazor;

namespace MudExtensions.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        /// Task will be awaited and exceptions will be logged to console (TaskOption.Safe) or managed by the Blazor framework (TaskOption.None).
        /// </summary>
        public static async void AndForgetExt(this Task task, TaskOption option = TaskOption.None)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                if (option != TaskOption.Safe)
                    throw;

                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// ValueTask will be awaited and exceptions will be logged to console (TaskOption.Safe) or managed by the Blazor framework (TaskOption.None).
        /// </summary>
        public static async void AndForgetExt(this ValueTask task, TaskOption option = TaskOption.None)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                if (option != TaskOption.Safe)
                    throw;

                Console.WriteLine(ex);
            }
        }

        /// <summary>
        /// ValueTask(bool) will be awaited and exceptions will be logged to console (TaskOption.Safe) or managed by the Blazor framework (TaskOption.None).
        /// </summary>
        public static async void AndForgetExt(this ValueTask<bool> task, TaskOption option = TaskOption.None)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                if (option != TaskOption.Safe)
                    throw;

                Console.WriteLine(ex);
            }
        }
    }
}
