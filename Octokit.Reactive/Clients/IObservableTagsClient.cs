﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Octokit.Reactive
{
    /// <summary>
    /// A client for GitHub's Git Tags API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/git/tags/">Git Tags API documentation</a> for more information.
    /// </remarks>
    public interface IObservableTagsClient
    {
        /// <summary>
        /// Gets a tag for a given repository by sha reference
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/tags/#get-a-tag
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="reference">Tha sha reference of the tag</param>
        /// <returns>A <see cref="IObservable{GitTag}"/> of <see cref="GitTag"/> representing git tag for specified repository and reference</returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<GitTag> Get(string owner, string name, string reference);

        /// <summary>
        /// Gets a tag for a given repository by sha reference
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/tags/#get-a-tag
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="reference">Tha sha reference of the tag</param>
        /// <returns>A <see cref="IObservable{GitTag}"/> of <see cref="GitTag"/> representing git tag for specified repository and reference</returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get",
             Justification = "Method makes a network request")]
        IObservable<GitTag> Get(int repositoryId, string reference);

        /// <summary>
        /// Create a tag for a given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/tags/#create-a-tag-object
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="tag">The tag to create</param>
        /// <returns>A <see cref="GitTag"/> representing created git tag for specified repository</returns>
        IObservable<GitTag> Create(string owner, string name, NewTag tag);

        /// <summary>
        /// Create a tag for a given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/git/tags/#create-a-tag-object
        /// </remarks>
        /// <param name="repositoryId">The ID of the repository</param>
        /// <param name="tag">The tag to create</param>
        /// <returns>A <see cref="GitTag"/> representing created git tag for specified repository</returns>
        IObservable<GitTag> Create(int repositoryId, NewTag tag);
    }
}
