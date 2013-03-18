﻿using System.Collections.Generic;
using FubuCore.Util;
using NuGet;
using ripple.New.Model;
using ripple.New.Nuget;

namespace ripple.Testing.New
{
	public class StubFeedService : IFeedService
	{
		private readonly Cache<Dependency, IList<PackageDependency>> _packageDependencies;

		public StubFeedService()
		{
			_packageDependencies = new Cache<Dependency, IList<PackageDependency>>(x => new List<PackageDependency>());
		}

		public IRemoteNuget NugetFor(Solution solution, Dependency dependency)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<IRemoteNuget> UpdatesFor(Solution solution)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<PackageDependency> DependenciesFor(Solution solution, Dependency dependency)
		{
			return _packageDependencies[dependency];
		}

		public void AddPackageDependency(Dependency dependency, PackageDependency packageDependency)
		{
			_packageDependencies[dependency].Add(packageDependency);
		}
	}
}