[![](https://img.shields.io/nuget/v/soenneker.utils.string.trie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.string.trie/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.string.trie/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.string.trie/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.string.trie.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.string.trie/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.String.Trie
### A utility library for comparing strings via trie (prefix tree) similarity

## Installation

```
dotnet add package Soenneker.Utils.String.Trie
```

## Why?
Imagine you have two strings. Trie-based matching helps you figure out how similar they are by looking at the prefixes they share. Here's why it's handy:

## Easy to Understand:
Trie-based matching is straightforward. It helps identify common prefixes between two strings, providing an intuitive measure of similarity.

## Not Bothered by Length:
Whether a string is long or short doesn't throw off trie-based matching. It cares more about the common prefixes than the total length of the strings.

## Efficient for Big Tasks:
When you're dealing with lots of strings or large texts, trie-based matching is efficient. It quickly identifies common prefixes without getting bogged down by complicated calculations, making it a practical choice for large datasets.

## Usage
```csharp
string str1 = "hello";
string str2 = "hell";

double similarity = TrieStringSimilarityUtil.CalculateSimilarityPercentage(str1, str2); // 80
```