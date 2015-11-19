# 2.4.0

 - [#173](https://github.com/shouldly/shouldly/pull/173) - Stop crash when in release mode
 - [#165](https://github.com/shouldly/shouldly/pull/165) - Show count when .ShouldBeEmpty() fails for IEnumerable contributed by Matt Kocaj ([cottsak](https://github.com/cottsak))
 - [#164](https://github.com/shouldly/shouldly/issues/164) [#167](https://github.com/shouldly/shouldly/pull/167) - Ignore case = true breaks comparison for yield break/yield return methods
 - [#160](https://github.com/shouldly/shouldly/issues/160) - Multiple Assertions - see https://github.com/shouldly/shouldly#shouldSatisfyAllConditions
 - [#105](https://github.com/shouldly/shouldly/issues/105) - "Length cannot be less than zero" at Shouldly.ShouldlyMessage.ToString()

Commits: [8b59f323d5...b3c8952b72](https://github.com/shouldly/shouldly/compare/8b59f323d5...b3c8952b72)


# 2.3.0

 - [#155](https://github.com/shouldly/shouldly/pull/155) - Fix hardcoded datetimes in tests contributed by Ilya Murzinov ([ilya-murzinov](https://github.com/ilya-murzinov))
 - [#151](https://github.com/shouldly/shouldly/pull/151) [#149](https://github.com/shouldly/shouldly/issues/149) - ShouldBe tolerance for dates contributed by Ben Scott ([bendetat](https://github.com/bendetat))
 - [#148](https://github.com/shouldly/shouldly/pull/148) - Improving the messages for the Dictionary failure scenarios. contributed by Chaitanya Gurrapu ([chaitanyagurrapu](https://github.com/chaitanyagurrapu))
 - [#145](https://github.com/shouldly/shouldly/pull/145) [#138](https://github.com/shouldly/shouldly/issues/138) - Implementing the 'DynamicShould.HaveProperty' functionality. contributed by Chaitanya Gurrapu ([chaitanyagurrapu](https://github.com/chaitanyagurrapu))
 - [#144](https://github.com/shouldly/shouldly/pull/144) - Add ShouldBeUnique for collections contributed by Ilya Murzinov ([ilya-murzinov](https://github.com/ilya-murzinov))
 - [#143](https://github.com/shouldly/shouldly/issues/143) - Dictionary "ShouldNotContainKeyAndValue" shows slightly incorrect message
 - [#50](https://github.com/shouldly/shouldly/issues/50) - ShouldAll for IEnumerables

Commits: [b0516804c0...81cad48f85](https://github.com/shouldly/shouldly/compare/b0516804c0...81cad48f85)


# 2.2.0 (7 June 2014)

 - [#135](https://github.com/shouldly/shouldly/issues/135) - Should be on a list of strings fails +fix
 - [#126](https://github.com/shouldly/shouldly/pull/126) - Tasks now timeout after 10 seconds
 - [#136](https://github.com/shouldly/shouldly/pull/136) - Should be on a list of strings fails
 - [#132](https://github.com/shouldly/shouldly/pull/132) - ShouldBe for IEnumerable with IgnoreOrder = true fails if objects are not IComparable contributed by Asger Hallas ([asgerhallas](https://github.com/asgerhallas))
 - [#131](https://github.com/shouldly/shouldly/issues/131) - Case enum on string asserts could be renamed
 - [#109](https://github.com/shouldly/shouldly/issues/109) - Task.ShouldCompleteIn (equivalent to NUnit Timeout Attribute) contributed by Gert Jansen van Rensburg ([gertjvr](https://github.com/gertjvr))

Commits: 6c29deca2c...40cea808b7


# 2.1.1 (19 March 2014)

 - [#124](https://github.com/shouldly/shouldly/pull/124) - Swap expected and actual in Is.Equal contributed by vorou ([vorou](https://github.com/vorou))
 - Fixed boxed numeric equality issues [#121](https://github.com/shouldly/shouldly/issues/121)
 - Equality should use expected.Equals not actual.Equals [#120](https://github.com/shouldly/shouldly/issues/120)

Thanks to [vorou](https://github.com/vorou) and [Jake Ginnivan](https://github.com/jakeginnivan) for contributing to this release

Commits: 954bb795dd...43e3aff8e4


# 2.1.0 (13 March 2014)

 - IEnumerable matching failures fixes [#118](https://github.com/shouldly/shouldly/issues/118) [#100](https://github.com/shouldly/shouldly/issues/100)
 - Equality fixes [#115](https://github.com/shouldly/shouldly/pull/115)
 - Fails on comparing arrays [#111](https://github.com/shouldly/shouldly/issues/111)
 - Equality of multidimensional arrays is throwing [#107](https://github.com/shouldly/shouldly/issues/107)

This release fixes a few major breaking changes in 2.0.0

Thanks to [James Kelly](https://github.com/jmkelly) [vorou](https://github.com/vorou) and [Jake Ginnivan](https://github.com/jakeginnivan) for contributing to this release

Commits: fb2be376c2...0912db75e6


# v2.0.1 (24 February 2014)

 - Fix possible deadlock in `Should.[Not]Throw(Func<Task>)` [#101](https://github.com/shouldly/shouldly/issues/101) +Fix

Commits: b8439790d5...2d3d40afd9


# v2.0.0 (20 February 2014)

 - **breaking**: Removed ShouldBeCloseTo [#94](https://github.com/shouldly/shouldly/pull/94) [#46](https://github.com/shouldly/shouldly/issues/46)
 - **breaking**: ShouldBeGreaterThan and ShouldBeLessThan are now constrained to `IComparable<T>`
 - **breaking**: Method Grouping on Should.Throw no longer works due to async overloads
 - **breaking**: IEnumerable.ShouldBe(IEnumerable) now uses .Equals to compare
     - specify T to get Item Comparison (`new[]{"foo"}.ShouldBe<string>(new[]{"foo"})` for item comparison, or specify `ignoreOrder` to select IEnumerable overload
     - See Breaking Changes.txt for more information
 - **breaking**: `ShouldBeTypeOf<T>` renamed to `ShouldBeAssignableTo<T>` [#98](https://github.com/shouldly/shouldly/issues/98)
 - `ShouldBeOfType<T>` added for exact match of type, `ShouldBeAssignableTo<T>` allows derived classes [#98](https://github.com/shouldly/shouldly/issues/98)
 - ShouldBeTypeOf should return the object [#63](https://github.com/shouldly/shouldly/pull/63) +Enhancement
 - ShouldAllBe for IEnumerables [#60](https://github.com/shouldly/shouldly/pull/60) +Enhancement
 - ShouldBeOneOf(params) [#58](https://github.com/shouldly/shouldly/issues/58) [#72](https://github.com/shouldly/shouldly/pull/72) +Enhancement
 - Allowed ignore ordering on enumerables on .ShouldBe [#93](https://github.com/shouldly/shouldly/pull/93) [#92](https://github.com/shouldly/shouldly/issues/92) +Enhancement
 - Task/async support for Should.Throw and Should.NotThrow [#88](https://github.com/shouldly/shouldly/pull/88) [#69](https://github.com/shouldly/shouldly/issues/69) [#76](https://github.com/shouldly/shouldly/pull/76) +Enhancement
 - Added ShouldBeSubsetOf() for IEnumerables [#87](https://github.com/shouldly/shouldly/pull/87) [#71](https://github.com/shouldly/shouldly/issues/71) +Enhancement
 - ShouldBeNullOrEmpty for strings [#85](https://github.com/shouldly/shouldly/pull/85) [#70](https://github.com/shouldly/shouldly/issues/70) +Enhancement
 - ShouldBeInRange and ShouldNotBeInRange [#73](https://github.com/shouldly/shouldly/pull/73) [#53](https://github.com/shouldly/shouldly/issues/53) +Enhancement
 - Exception when attempting to calculate stacktrace, only in CI [#84](https://github.com/shouldly/shouldly/pull/84) [#49](https://github.com/shouldly/shouldly/issues/49) [#62](https://github.com/shouldly/shouldly/issues/62) +fix
 - Missing Should.BeLessThanOrEqualTo mirror of BeGreaterThanOrEqualTo [#82](https://github.com/shouldly/shouldly/issues/82) +fix
 - Should.NotThrow returns thrown exception [#68](https://github.com/shouldly/shouldly/pull/68)
 - JToken.Parse("{}").ShouldBe("hello"); Passes [#65](https://github.com/shouldly/shouldly/issues/65) [#66](https://github.com/shouldly/shouldly/pull/66) +fix
 - ChuckedAWobbly should be serializable [#64](https://github.com/shouldly/shouldly/pull/64)

**note**: When shouldly is running under .net 4.0 (this affects old versions too) a shouldly assertion inside a compiled lambda will give an incorrect error message (if you do this, let us know why). See [#80](https://github.com/shouldly/shouldly/issues/80)

Thanks to [Sam Salisbury](https://github.com/samsalisbury) [Ben Scott](https://github.com/bendetat) [James Kelly](https://github.com/jmkelly) [Ilya Murzinov](https://github.com/ilya-murzinov) [Kővágó Zoltán](https://github.com/DirtYiCE) [Jake Ginnivan](https://github.com/jakeginnivan) [Egbert Teeselink](https://github.com/eteeselink) for contributing to this release!

Commits: c855ea41eb...d16284be27


# v1.1.1.1 (16 November 2012)

 - Truncate error string "actual" output on `ShouldContain to 100 chars [#37](https://github.com/shouldly/shouldly/issues/37) [42](https://github.com/shouldly/shouldly/pull/42)
 - Remove dependency on Rhino.Mocks [#51](https://github.com/shouldly/shouldly/issues/51)

Commits: 1545f74a2e...5b07fdfd97


# v1.1.1 (09 March 2012)

 - Sign Shouldly.dll [#40](https://github.com/shouldly/shouldly/issues/40)
 - ShouldBe on two IEnumerables of different static types doesn't show differences [#39](https://github.com/shouldly/shouldly/issues/39)
 - Allow tolerance when comparing collections of doubles [#38](https://github.com/shouldly/shouldly/issues/38)
 - `Should.(Not)BeNull(obj)` [#36](https://github.com/shouldly/shouldly/issues/36)
 - custom error messages [#35](https://github.com/shouldly/shouldly/issues/35)
 - Deprecate Rhino.Mocks [#34](https://github.com/shouldly/shouldly/issues/34)
 - Split core features from rhino mocks dependent code [#30](https://github.com/shouldly/shouldly/issues/30)
 - Additional Assertions [#21](https://github.com/shouldly/shouldly/issues/21)

Commits: 729e91f570...4f67b23cda


# v1.1.0 (23 September 2011)

 - added `string.ShouldBe(string, Case)` [#33](https://github.com/shouldly/shouldly/pull/33)
 - Fixed bug with `ShouldBeTypeOf<T>` assert method [#32](https://github.com/shouldly/shouldly/pull/32)
 - Fixed bug with `ShouldBeTypeOf<T>` assert method [#31](https://github.com/shouldly/shouldly/pull/31)
 - Specs (BDDish) extension [#29](https://github.com/shouldly/shouldly/pull/29)
 - `ShouldBeEqualIgnoringCase` [#28](https://github.com/shouldly/shouldly/pull/28)
 - #20 - `Should.Throw` should return the exception itself [#27](https://github.com/shouldly/shouldly/pull/27)
 - Comparing null IEnumerables results in NullRef in Difference Highlighter [#26](https://github.com/shouldly/shouldly/issues/26)
 - `ShouldBeSameAs` and ShouldNotBeSameAs [#25](https://github.com/shouldly/shouldly/pull/25)
 - `ShouldBeSameAs` (Reference equality) [#24](https://github.com/shouldly/shouldly/issues/24)
 - `Should.Throw` barfs if no exception thrown at all [#23](https://github.com/shouldly/shouldly/issues/23)
 - InternalsVisibleTo causes issues when using NUnit for tests [#22](https://github.com/shouldly/shouldly/issues/22)
 - `Should.Throw` should return the exception itself [#20](https://github.com/shouldly/shouldly/issues/20)
 - `ShouldContain` and ShouldNotContain with `Predicate<T>` [#19](https://github.com/shouldly/shouldly/issues/19)
 - Issue 5 - Highlight differences in collections [#18](https://github.com/shouldly/shouldly/pull/18)
 - Add `ShouldNotHaveBeenCalled()` [#17](https://github.com/shouldly/shouldly/issues/17)
 - Add support for Rhino Method Options [#16](https://github.com/shouldly/shouldly/issues/16)
 - Added `NUnitAssemblyResolver.WireUp()` to resolve issue #8 [#15](https://github.com/shouldly/shouldly/pull/15)
 - `ShouldMatch(pattern, regexOptions)` [#14](https://github.com/shouldly/shouldly/issues/14)
 - `ShouldBeGreaterThanOrEqualTo` [#13](https://github.com/shouldly/shouldly/pull/13)
 - Added `ShouldBeGreaterThanOrEqualTo` [#12](https://github.com/shouldly/shouldly/pull/12)
 - Refactored solution for issue #3 [#11](https://github.com/shouldly/shouldly/pull/11)
 - Tests and code for issue #3 [#10](https://github.com/shouldly/shouldly/pull/10)
 - Add support for XUnit [#9](https://github.com/shouldly/shouldly/issues/9)
 - Add support for NUnit versions > 2.5.3 [#8](https://github.com/shouldly/shouldly/issues/8)
 - Build/Deploy Gem/Binary [#7](https://github.com/shouldly/shouldly/pull/7)
 - Gem for Nu [#6](https://github.com/shouldly/shouldly/issues/6)
 - When comparing collections should highlight different items [#5](https://github.com/shouldly/shouldly/issues/5)
 - vs2010 sln and proj files [#4](https://github.com/shouldly/shouldly/issues/4)
 - Support for tolerance on enumerations of floating point numbers. [#3](https://github.com/shouldly/shouldly/issues/3)
 - Simple additions [#2](https://github.com/shouldly/shouldly/pull/2)
 - Added startswith and endswith as well as an alias for `ShouldBeCloseTo` [#1](https://github.com/shouldly/shouldly/pull/1)
 - Add ShouldNotHaveBeenCalled() [17](https://github.com/shouldly/shouldly/issues/17)
 - Add support for Rhino Method Options [16](https://github.com/shouldly/shouldly/issues/16)

Commits: a3bb9f5598...08c4ebfa29
