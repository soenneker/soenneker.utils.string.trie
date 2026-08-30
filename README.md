[![](https://img.shields.io/nuget/v/soenneker.utils.string.trie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.string.trie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.string.trie/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.string.trie/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.string.trie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.string.trie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.string.trie/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.utils.string.trie/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.String.Trie
Common-prefix similarity for strings, normalized by the longer input length.

## Installation

```bash
dotnet add package Soenneker.Utils.String.Trie
```

## Usage

```csharp
using Soenneker.Utils.String.Trie;

string str1 = "hello";
string str2 = "hell";

double score = TrieSimilarityStringUtil.CalculateSimilarity(str1, str2);
double percentage = TrieSimilarityStringUtil.CalculateSimilarityPercentage(str1, str2);

// score == 0.8
// percentage == 80
```

The score is calculated as:

```text
common leading prefix length / length of the longer input
```

Only characters from the beginning of each string contribute. For example, `"prefix"` and `"pre"` score `0.5` because their three-character common prefix is divided by the longer length of six. Two identical strings, including two empty strings, return `1` (or `100%`).

## Comparison rules

- Comparison is case-sensitive.
- Characters are compared as UTF-16 code units.
- Whitespace and punctuation participate like any other character.
- Characters after the first mismatch do not affect the common-prefix length, though they still affect the longer-input denominator.
- Runtime is linear in the shorter input length and the method does not allocate a prefix tree.

Call the static methods directly; no dependency-injection registration is required. Both arguments must be non-null. This metric is useful for prefix-oriented identifiers, paths, or labels; it is not a general semantic string similarity measure.
