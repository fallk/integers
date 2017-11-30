using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A008613
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,3L,0L,4L,0L,4L,1L,5L,1L,6L,1L,7L,2L,8L,2L,9L,3L,10L,4L,11L,4L,13L,5L,14L,6L,15L,7L,17L,8L,18L,9L,20L,10L,22L,11L,23L,13L,25L,14L,27L,15L,29L,17L,31L,18L,33L,20L,35L,22L,37L,23L,40L,25L,42L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008613Inst : IEnumerable<long>
{
public static readonly long[] Value=A008613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008613.Bytes);
public long this[int i]=>Value[i];

public static A008613Inst Instance=new A008613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008614
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,2L,0L,2L,0L,2L,0L,3L,0L,3L,1L,3L,0L,4L,1L,4L,1L,5L,1L,5L,1L,6L,2L,6L,2L,7L,2L,7L,3L,8L,3L,9L,3L,9L,4L,10L,4L,11L,5L,11L,5L,12L,6L,13L,6L,14L,7L,14L,7L,16L,8L,16L,9L,17L,9L,18L,10L,19L,11L,20L,11L,21L,12L,22L,13L,23L,14L,24L,14L,25L,16L,26L,16L,28L,17L,28L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008614Inst : IEnumerable<long>
{
public static readonly long[] Value=A008614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008614.Bytes);
public long this[int i]=>Value[i];

public static A008614Inst Instance=new A008614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008615
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,3L,4L,3L,4L,4L,4L,4L,5L,4L,5L,5L,5L,5L,6L,5L,6L,6L,6L,6L,7L,6L,7L,7L,7L,7L,8L,7L,8L,8L,8L,8L,9L,8L,9L,9L,9L,9L,10L,9L,10L,10L,10L,10L,11L,10L,11L,11L,11L,11L,12L,11L,12L,12L,12L,12L,13L,12L,13L,13L,13L,13L,14L,13L,14L,14L,14L,14L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008615Inst : IEnumerable<long>
{
public static readonly long[] Value=A008615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008615.Bytes);
public long this[int i]=>Value[i];

public static A008615Inst Instance=new A008615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008616
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,4L,4L,4L,4L,4L,4L,5L,4L,5L,4L,5L,5L,5L,5L,5L,5L,6L,5L,6L,5L,6L,6L,6L,6L,6L,6L,7L,6L,7L,6L,7L,7L,7L,7L,7L,7L,8L,7L,8L,7L,8L,8L,8L,8L,8L,8L,9L,8L,9L,8L,9L,9L,9L,9L,9L,9L,10L,9L,10L,9L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008616Inst : IEnumerable<long>
{
public static readonly long[] Value=A008616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008616.Bytes);
public long this[int i]=>Value[i];

public static A008616Inst Instance=new A008616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008617
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,4L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,4L,5L,4L,5L,5L,5L,5L,5L,5L,5L,5L,6L,5L,6L,5L,6L,5L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008617Inst : IEnumerable<long>
{
public static readonly long[] Value=A008617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008617.Bytes);
public long this[int i]=>Value[i];

public static A008617Inst Instance=new A008617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008618
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,3L,4L,3L,4L,3L,4L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,4L,5L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008618Inst : IEnumerable<long>
{
public static readonly long[] Value=A008618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008618.Bytes);
public long this[int i]=>Value[i];

public static A008618Inst Instance=new A008618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008619
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008619Inst : IEnumerable<long>
{
public static readonly long[] Value=A008619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008619.Bytes);
public long this[int i]=>Value[i];

public static A008619Inst Instance=new A008619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008620
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,9L,9L,9L,10L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,14L,15L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008620Inst : IEnumerable<long>
{
public static readonly long[] Value=A008620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008620.Bytes);
public long this[int i]=>Value[i];

public static A008620Inst Instance=new A008620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008621
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,20L,21L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008621Inst : IEnumerable<long>
{
public static readonly long[] Value=A008621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008621.Bytes);
public long this[int i]=>Value[i];

public static A008621Inst Instance=new A008621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008638
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,41L,54L,73L,94L,123L,157L,201L,252L,318L,393L,488L,598L,732L,887L,1076L,1291L,1549L,1845L,2194L,2592L,3060L,3589L,4206L,4904L,5708L,6615L,7657L,8824L,10156L,11648L,13338L,15224L,17354L,19720L,22380L,25331L,28629L,32278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008638Inst : IEnumerable<long>
{
public static readonly long[] Value=A008638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008638.Bytes);
public long this[int i]=>Value[i];

public static A008638Inst Instance=new A008638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008639
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,55L,75L,97L,128L,164L,212L,267L,340L,423L,530L,653L,807L,984L,1204L,1455L,1761L,2112L,2534L,3015L,3590L,4242L,5013L,5888L,6912L,8070L,9418L,10936L,12690L,14663L,16928L,19466L,22367L,25608L,29292L,33401L,38047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008639Inst : IEnumerable<long>
{
public static readonly long[] Value=A008639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008639.Bytes);
public long this[int i]=>Value[i];

public static A008639Inst Instance=new A008639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008640
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,76L,99L,131L,169L,219L,278L,355L,445L,560L,695L,863L,1060L,1303L,1586L,1930L,2331L,2812L,3370L,4035L,4802L,5708L,6751L,7972L,9373L,11004L,12866L,15021L,17475L,20298L,23501L,27169L,31316L,36043L,41373L,47420L,54218L,61903L,70515L,80215L,91058L,103226L,116792L,131970L,148847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008640Inst : IEnumerable<long>
{
public static readonly long[] Value=A008640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008640.Bytes);
public long this[int i]=>Value[i];

public static A008640Inst Instance=new A008640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008641
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,77L,100L,133L,172L,224L,285L,366L,460L,582L,725L,905L,1116L,1380L,1686L,2063L,2503L,3036L,3655L,4401L,5262L,6290L,7476L,8877L,10489L,12384L,14552L,17084L,19978L,23334L,27156L,31570L,36578L,42333L,48849L,56297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008641Inst : IEnumerable<long>
{
public static readonly long[] Value=A008641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008641.Bytes);
public long this[int i]=>Value[i];

public static A008641Inst Instance=new A008641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008642
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,6L,9L,9L,12L,12L,16L,16L,20L,20L,25L,25L,30L,30L,36L,36L,42L,42L,49L,49L,56L,56L,64L,64L,72L,72L,81L,81L,90L,90L,100L,100L,110L,110L,121L,121L,132L,132L,144L,144L,156L,156L,169L,169L,182L,182L,196L,196L,210L,210L,225L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008642Inst : IEnumerable<long>
{
public static readonly long[] Value=A008642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008642.Bytes);
public long this[int i]=>Value[i];

public static A008642Inst Instance=new A008642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008643
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,6L,10L,10L,14L,14L,20L,20L,26L,26L,35L,35L,44L,44L,56L,56L,68L,68L,84L,84L,100L,100L,120L,120L,140L,140L,165L,165L,190L,190L,220L,220L,250L,250L,286L,286L,322L,322L,364L,364L,406L,406L,455L,455L,504L,504L,560L,560L,616L,616L,680L,680L,744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008643Inst : IEnumerable<long>
{
public static readonly long[] Value=A008643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008643.Bytes);
public long this[int i]=>Value[i];

public static A008643Inst Instance=new A008643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008644
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,6L,10L,10L,14L,14L,20L,20L,26L,26L,36L,36L,46L,46L,60L,60L,74L,74L,94L,94L,114L,114L,140L,140L,166L,166L,201L,201L,236L,236L,280L,280L,324L,324L,380L,380L,436L,436L,504L,504L,572L,572L,656L,656L,740L,740L,840L,840L,940L,940L,1060L,1060L,1180L,1180L,1320L,1320L,1460L,1460L,1625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008644Inst : IEnumerable<long>
{
public static readonly long[] Value=A008644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008644.Bytes);
public long this[int i]=>Value[i];

public static A008644Inst Instance=new A008644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008645
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,6L,6L,10L,10L,14L,14L,20L,20L,26L,26L,36L,36L,46L,46L,60L,60L,74L,74L,94L,94L,114L,114L,140L,140L,166L,166L,202L,202L,238L,238L,284L,284L,330L,330L,390L,390L,450L,450L,524L,524L,598L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008645Inst : IEnumerable<long>
{
public static readonly long[] Value=A008645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008645.Bytes);
public long this[int i]=>Value[i];

public static A008645Inst Instance=new A008645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008646
{
public static readonly long[] Value={ 1L,1L,3L,7L,14L,26L,42L,66L,99L,143L,201L,273L,364L,476L,612L,776L,969L,1197L,1463L,1771L,2126L,2530L,2990L,3510L,4095L,4751L,5481L,6293L,7192L,8184L,9276L,10472L,11781L,13209L,14763L,16451L,18278L,20254L,22386L,24682L,27151L,29799L,32637L,35673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008646Inst : IEnumerable<long>
{
public static readonly long[] Value=A008646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008646.Bytes);
public long this[int i]=>Value[i];

public static A008646Inst Instance=new A008646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008647
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,2L,1L,3L,2L,2L,2L,3L,2L,3L,2L,3L,3L,3L,2L,4L,3L,3L,3L,4L,3L,4L,3L,4L,4L,4L,3L,5L,4L,4L,4L,5L,4L,5L,4L,5L,5L,5L,4L,6L,5L,5L,5L,6L,5L,6L,5L,6L,6L,6L,5L,7L,6L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008647Inst : IEnumerable<long>
{
public static readonly long[] Value=A008647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008647.Bytes);
public long this[int i]=>Value[i];

public static A008647Inst Instance=new A008647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008648
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,7L,7L,7L,7L,7L,9L,9L,9L,9L,9L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,15L,15L,15L,15L,15L,18L,18L,18L,18L,18L,21L,21L,21L,21L,21L,24L,24L,24L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008648Inst : IEnumerable<long>
{
public static readonly long[] Value=A008648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008648.Bytes);
public long this[int i]=>Value[i];

public static A008648Inst Instance=new A008648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008649
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,5L,5L,5L,7L,7L,7L,9L,9L,9L,12L,12L,12L,15L,15L,15L,18L,18L,18L,22L,22L,22L,26L,26L,26L,30L,30L,30L,35L,35L,35L,40L,40L,40L,45L,45L,45L,51L,51L,51L,57L,57L,57L,63L,63L,63L,70L,70L,70L,77L,77L,77L,84L,84L,84L,92L,92L,92L,100L,100L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008649Inst : IEnumerable<long>
{
public static readonly long[] Value=A008649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008649.Bytes);
public long this[int i]=>Value[i];

public static A008649Inst Instance=new A008649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008650
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,3L,3L,5L,5L,5L,7L,7L,7L,9L,9L,9L,12L,12L,12L,15L,15L,15L,18L,18L,18L,23L,23L,23L,28L,28L,28L,33L,33L,33L,40L,40L,40L,47L,47L,47L,54L,54L,54L,63L,63L,63L,72L,72L,72L,81L,81L,81L,93L,93L,93L,105L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008650Inst : IEnumerable<long>
{
public static readonly long[] Value=A008650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008650.Bytes);
public long this[int i]=>Value[i];

public static A008650Inst Instance=new A008650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008651
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008651Inst : IEnumerable<long>
{
public static readonly long[] Value=A008651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008651.Bytes);
public long this[int i]=>Value[i];

public static A008651Inst Instance=new A008651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008652
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,6L,6L,6L,6L,8L,8L,8L,8L,10L,10L,10L,10L,12L,12L,12L,12L,15L,15L,15L,15L,18L,18L,18L,18L,21L,21L,21L,21L,24L,24L,24L,24L,28L,28L,28L,28L,32L,32L,32L,32L,36L,36L,36L,36L,40L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008652Inst : IEnumerable<long>
{
public static readonly long[] Value=A008652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008652.Bytes);
public long this[int i]=>Value[i];

public static A008652Inst Instance=new A008652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008653
{
public static readonly long[] Value={ 1L,12L,36L,12L,84L,72L,36L,96L,180L,12L,216L,144L,84L,168L,288L,72L,372L,216L,36L,240L,504L,96L,432L,288L,180L,372L,504L,12L,672L,360L,216L,384L,756L,144L,648L,576L,84L,456L,720L,168L,1080L,504L,288L,528L,1008L,72L,864L,576L,372L,684L,1116L,216L,1176L,648L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008653Inst : IEnumerable<long>
{
public static readonly long[] Value=A008653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008653.Bytes);
public long this[int i]=>Value[i];

public static A008653Inst Instance=new A008653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008670
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,5L,6L,7L,9L,11L,12L,16L,18L,20L,24L,28L,30L,36L,40L,44L,50L,56L,60L,69L,75L,81L,90L,99L,105L,117L,126L,135L,147L,159L,168L,184L,196L,208L,224L,240L,252L,272L,288L,304L,324L,344L,360L,385L,405L,425L,450L,475L,495L,525L,550L,575L,605L,635L,660L,696L,726L,756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008670Inst : IEnumerable<long>
{
public static readonly long[] Value=A008670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008670.Bytes);
public long this[int i]=>Value[i];

public static A008670Inst Instance=new A008670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008671
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,14L,16L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,28L,30L,31L,32L,33L,35L,36L,37L,39L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,57L,58L,60L,62L,63L,65L,67L,69L,70L,73L,74L,76L,78L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008671Inst : IEnumerable<long>
{
public static readonly long[] Value=A008671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008671.Bytes);
public long this[int i]=>Value[i];

public static A008671Inst Instance=new A008671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008672
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,18L,20L,22L,23L,25L,27L,29L,31L,33L,35L,37L,40L,42L,44L,47L,49L,52L,55L,57L,60L,63L,66L,69L,72L,75L,78L,82L,85L,88L,92L,95L,99L,103L,106L,110L,114L,118L,122L,126L,130L,134L,139L,143L,147L,152L,156L,161L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008672Inst : IEnumerable<long>
{
public static readonly long[] Value=A008672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008672.Bytes);
public long this[int i]=>Value[i];

public static A008672Inst Instance=new A008672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008673
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,7L,9L,10L,12L,14L,16L,19L,21L,24L,27L,30L,34L,38L,42L,46L,51L,56L,61L,67L,73L,79L,86L,93L,100L,108L,116L,125L,134L,143L,153L,163L,174L,185L,197L,209L,221L,235L,248L,262L,277L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008673Inst : IEnumerable<long>
{
public static readonly long[] Value=A008673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008673.Bytes);
public long this[int i]=>Value[i];

public static A008673Inst Instance=new A008673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008674
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,11L,14L,16L,19L,23L,26L,30L,35L,40L,45L,52L,58L,65L,74L,82L,91L,102L,113L,124L,138L,151L,165L,182L,198L,216L,236L,256L,277L,301L,325L,350L,379L,407L,437L,471L,504L,539L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008674Inst : IEnumerable<long>
{
public static readonly long[] Value=A008674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008674.Bytes);
public long this[int i]=>Value[i];

public static A008674Inst Instance=new A008674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008675
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,10L,12L,15L,17L,21L,25L,29L,34L,40L,46L,53L,62L,70L,80L,91L,103L,116L,131L,147L,164L,184L,204L,227L,252L,278L,307L,339L,372L,408L,448L,489L,534L,583L,634L,689L,749L,811L,878L,950L,1025L,1106L,1192L,1282L,1378L,1481L,1588L,1702L,1823L,1949L,2083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008675Inst : IEnumerable<long>
{
public static readonly long[] Value=A008675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008675.Bytes);
public long this[int i]=>Value[i];

public static A008675Inst Instance=new A008675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008676
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,4L,5L,5L,5L,5L,5L,5L,5L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008676Inst : IEnumerable<long>
{
public static readonly long[] Value=A008676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008676.Bytes);
public long this[int i]=>Value[i];

public static A008676Inst Instance=new A008676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008677
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,3L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,14L,13L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,20L,20L,21L,22L,22L,23L,24L,24L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008677Inst : IEnumerable<long>
{
public static readonly long[] Value=A008677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008677.Bytes);
public long this[int i]=>Value[i];

public static A008677Inst Instance=new A008677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008678
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,2L,2L,1L,3L,2L,3L,4L,3L,4L,5L,5L,5L,7L,6L,7L,9L,8L,9L,11L,11L,11L,14L,13L,14L,17L,16L,18L,20L,20L,21L,24L,24L,25L,29L,28L,30L,34L,33L,35L,39L,39L,41L,45L,45L,47L,52L,52L,54L,59L,59L,62L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008678Inst : IEnumerable<long>
{
public static readonly long[] Value=A008678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008678.Bytes);
public long this[int i]=>Value[i];

public static A008678Inst Instance=new A008678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008679
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,3L,3L,4L,3L,3L,4L,4L,3L,4L,4L,4L,4L,4L,4L,5L,4L,4L,5L,5L,4L,5L,5L,5L,5L,5L,5L,6L,5L,5L,6L,6L,5L,6L,6L,6L,6L,6L,6L,7L,6L,6L,7L,7L,6L,7L,7L,7L,7L,7L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008679Inst : IEnumerable<long>
{
public static readonly long[] Value=A008679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008679.Bytes);
public long this[int i]=>Value[i];

public static A008679Inst Instance=new A008679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008680
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,7L,8L,8L,8L,9L,10L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,22L,23L,25L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008680Inst : IEnumerable<long>
{
public static readonly long[] Value=A008680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008680.Bytes);
public long this[int i]=>Value[i];

public static A008680Inst Instance=new A008680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008681
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,1L,2L,3L,3L,3L,5L,4L,5L,7L,7L,7L,10L,9L,11L,13L,13L,14L,18L,17L,19L,22L,23L,24L,29L,28L,31L,35L,36L,38L,44L,43L,47L,52L,54L,56L,63L,63L,68L,74L,76L,79L,88L,88L,94L,101L,104L,108L,118L,119L,126L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008681Inst : IEnumerable<long>
{
public static readonly long[] Value=A008681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008681.Bytes);
public long this[int i]=>Value[i];

public static A008681Inst Instance=new A008681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008682
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,2L,1L,2L,1L,2L,2L,3L,2L,3L,2L,4L,3L,4L,3L,5L,4L,5L,4L,6L,5L,7L,5L,7L,6L,8L,7L,9L,7L,9L,8L,11L,9L,11L,9L,12L,11L,13L,11L,14L,12L,15L,13L,16L,14L,17L,15L,18L,16L,19L,17L,21L,18L,21L,19L,23L,21L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008682Inst : IEnumerable<long>
{
public static readonly long[] Value=A008682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008682.Bytes);
public long this[int i]=>Value[i];

public static A008682Inst Instance=new A008682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008683
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,-1L,1L,-1L,0L,0L,1L,-1L,0L,-1L,1L,1L,0L,-1L,0L,-1L,0L,1L,1L,-1L,0L,0L,1L,0L,0L,-1L,-1L,-1L,0L,1L,1L,1L,0L,-1L,1L,1L,0L,-1L,-1L,-1L,0L,0L,1L,-1L,0L,0L,0L,1L,0L,-1L,0L,1L,0L,1L,1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,-1L,0L,1L,-1L,-1L,0L,-1L,1L,0L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008683Inst : IEnumerable<long>
{
public static readonly long[] Value=A008683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008683.Bytes);
public long this[int i]=>Value[i];

public static A008683Inst Instance=new A008683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008684
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008684Inst : IEnumerable<long>
{
public static readonly long[] Value=A008684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008684.Bytes);
public long this[int i]=>Value[i];

public static A008684Inst Instance=new A008684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008685
{
public static readonly long[] Value={ 31L,28L,31L,30L,31L,30L,31L,31L,30L,31L,30L,31L,31L,28L,31L,30L,31L,30L,31L,31L,30L,31L,30L,31L,31L,28L,31L,30L,31L,30L,31L,31L,30L,31L,30L,31L,31L,29L,31L,30L,31L,30L,31L,31L,30L,31L,30L,31L,31L,28L,31L,30L,31L,30L,31L,31L,30L,31L,30L,31L,31L,28L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008685Inst : IEnumerable<long>
{
public static readonly long[] Value=A008685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008685.Bytes);
public long this[int i]=>Value[i];

public static A008685Inst Instance=new A008685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008686
{
public static readonly long[] Value={ 1L,8L,15L,22L,29L,5L,12L,19L,26L,5L,12L,19L,26L,2L,9L,16L,23L,30L,7L,14L,21L,28L,4L,11L,18L,25L,2L,9L,16L,23L,30L,6L,13L,20L,27L,3L,10L,17L,24L,1L,8L,15L,22L,29L,5L,12L,19L,26L,3L,10L,17L,24L,31L,7L,14L,21L,28L,4L,11L,18L,25L,4L,11L,18L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008686Inst : IEnumerable<long>
{
public static readonly long[] Value=A008686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008686.Bytes);
public long this[int i]=>Value[i];

public static A008686Inst Instance=new A008686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008687
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,2L,2L,1L,4L,3L,3L,2L,3L,2L,2L,1L,5L,4L,4L,3L,4L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,1L,6L,5L,5L,4L,5L,4L,4L,3L,5L,4L,4L,3L,4L,3L,3L,2L,5L,4L,4L,3L,4L,3L,3L,2L,4L,3L,3L,2L,3L,2L,2L,1L,7L,6L,6L,5L,6L,5L,5L,4L,6L,5L,5L,4L,5L,4L,4L,3L,6L,5L,5L,4L,5L,4L,4L,3L,5L,4L,4L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008687Inst : IEnumerable<long>
{
public static readonly long[] Value=A008687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008687.Bytes);
public long this[int i]=>Value[i];

public static A008687Inst Instance=new A008687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008688
{
public static readonly long[] Value={ 1L,1104L,170064L,17051328L,396408912L,4634713440L,34410979008L,187471449984L,814973040720L,2975426026128L,9486423324000L,27053536131648L,70485827477184L,169930457503968L,384164030001024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008688Inst : IEnumerable<long>
{
public static readonly long[] Value=A008688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008688.Bytes);
public long this[int i]=>Value[i];

public static A008688Inst Instance=new A008688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008689
{
public static readonly long[] Value={ 1L,600L,182160L,16924320L,397150800L,4632279120L,34414027200L,187479888960L,814930462800L,2975483302200L,9486481747680L,27053266687200L,70486014432960L,169930748683920L,384163827465600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008689Inst : IEnumerable<long>
{
public static readonly long[] Value=A008689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008689.Bytes);
public long this[int i]=>Value[i];

public static A008689Inst Instance=new A008689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008690
{
public static readonly long[] Value={ 1L,528L,183888L,16906176L,397256784L,4631931360L,34414462656L,187481094528L,814924380240L,2975491484496L,9486490093920L,27053228195136L,70486041140928L,169930790281056L,384163798531968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008690Inst : IEnumerable<long>
{
public static readonly long[] Value=A008690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008690.Bytes);
public long this[int i]=>Value[i];

public static A008690Inst Instance=new A008690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008691
{
public static readonly long[] Value={ 1L,432L,186192L,16881984L,397398096L,4631467680L,34415043264L,187482701952L,814916270160L,2975502394224L,9486501222240L,27053176872384L,70486076751552L,169930845743904L,384163759953792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008691Inst : IEnumerable<long>
{
public static readonly long[] Value=A008691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008691.Bytes);
public long this[int i]=>Value[i];

public static A008691Inst Instance=new A008691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008692
{
public static readonly long[] Value={ 1L,384L,187344L,16869888L,397468752L,4631235840L,34415333568L,187483505664L,814912215120L,2975507849088L,9486506786400L,27053151211008L,70486094556864L,169930873475328L,384163740664704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008692Inst : IEnumerable<long>
{
public static readonly long[] Value=A008692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008692.Bytes);
public long this[int i]=>Value[i];

public static A008692Inst Instance=new A008692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008693
{
public static readonly long[] Value={ 1L,336L,188496L,16857792L,397539408L,4631004000L,34415623872L,187484309376L,814908160080L,2975513303952L,9486512350560L,27053125549632L,70486112362176L,169930901206752L,384163721375616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008693Inst : IEnumerable<long>
{
public static readonly long[] Value=A008693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008693.Bytes);
public long this[int i]=>Value[i];

public static A008693Inst Instance=new A008693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008694
{
public static readonly long[] Value={ 1L,312L,189072L,16851744L,397574736L,4630888080L,34415769024L,187484711232L,814906132560L,2975516031384L,9486515132640L,27053112718944L,70486121264832L,169930915072464L,384163711731072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008694Inst : IEnumerable<long>
{
public static readonly long[] Value=A008694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008694.Bytes);
public long this[int i]=>Value[i];

public static A008694Inst Instance=new A008694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008695
{
public static readonly long[] Value={ 1L,288L,189648L,16845696L,397610064L,4630772160L,34415914176L,187485113088L,814904105040L,2975518758816L,9486517914720L,27053099888256L,70486130167488L,169930928938176L,384163702086528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008695Inst : IEnumerable<long>
{
public static readonly long[] Value=A008695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008695.Bytes);
public long this[int i]=>Value[i];

public static A008695Inst Instance=new A008695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008696
{
public static readonly long[] Value={ 1L,240L,190800L,16833600L,397680720L,4630540320L,34416204480L,187485916800L,814900050000L,2975524213680L,9486523478880L,27053074226880L,70486147972800L,169930956669600L,384163682797440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008696Inst : IEnumerable<long>
{
public static readonly long[] Value=A008696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008696.Bytes);
public long this[int i]=>Value[i];

public static A008696Inst Instance=new A008696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008697
{
public static readonly long[] Value={ 1L,216L,191376L,16827552L,397716048L,4630424400L,34416349632L,187486318656L,814898022480L,2975526941112L,9486526260960L,27053061396192L,70486156875456L,169930970535312L,384163673152896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008697Inst : IEnumerable<long>
{
public static readonly long[] Value=A008697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008697.Bytes);
public long this[int i]=>Value[i];

public static A008697Inst Instance=new A008697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008698
{
public static readonly long[] Value={ 1L,192L,191952L,16821504L,397751376L,4630308480L,34416494784L,187486720512L,814895994960L,2975529668544L,9486529043040L,27053048565504L,70486165778112L,169930984401024L,384163663508352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008698Inst : IEnumerable<long>
{
public static readonly long[] Value=A008698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008698.Bytes);
public long this[int i]=>Value[i];

public static A008698Inst Instance=new A008698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008699
{
public static readonly long[] Value={ 1L,168L,192528L,16815456L,397786704L,4630192560L,34416639936L,187487122368L,814893967440L,2975532395976L,9486531825120L,27053035734816L,70486174680768L,169930998266736L,384163653863808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008699Inst : IEnumerable<long>
{
public static readonly long[] Value=A008699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008699.Bytes);
public long this[int i]=>Value[i];

public static A008699Inst Instance=new A008699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008700
{
public static readonly long[] Value={ 1L,144L,193104L,16809408L,397822032L,4630076640L,34416785088L,187487524224L,814891939920L,2975535123408L,9486534607200L,27053022904128L,70486183583424L,169931012132448L,384163644219264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008700Inst : IEnumerable<long>
{
public static readonly long[] Value=A008700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008700.Bytes);
public long this[int i]=>Value[i];

public static A008700Inst Instance=new A008700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008701
{
public static readonly long[] Value={ 1L,120L,193680L,16803360L,397857360L,4629960720L,34416930240L,187487926080L,814889912400L,2975537850840L,9486537389280L,27053010073440L,70486192486080L,169931025998160L,384163634574720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008701Inst : IEnumerable<long>
{
public static readonly long[] Value=A008701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008701.Bytes);
public long this[int i]=>Value[i];

public static A008701Inst Instance=new A008701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008734
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,1L,4L,2L,6L,3L,8L,4L,10L,6L,12L,8L,15L,10L,18L,12L,21L,15L,24L,18L,28L,21L,32L,24L,36L,28L,40L,32L,45L,36L,50L,40L,55L,45L,60L,50L,66L,55L,72L,60L,78L,66L,84L,72L,91L,78L,98L,84L,105L,91L,112L,98L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008734Inst : IEnumerable<long>
{
public static readonly long[] Value=A008734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008734.Bytes);
public long this[int i]=>Value[i];

public static A008734Inst Instance=new A008734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008735
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,0L,4L,1L,5L,2L,6L,3L,8L,4L,10L,5L,12L,6L,14L,8L,16L,10L,18L,12L,21L,14L,24L,16L,27L,18L,30L,21L,33L,24L,36L,27L,40L,30L,44L,33L,48L,36L,52L,40L,56L,44L,60L,48L,65L,52L,70L,56L,75L,60L,80L,65L,85L,70L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008735Inst : IEnumerable<long>
{
public static readonly long[] Value=A008735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008735.Bytes);
public long this[int i]=>Value[i];

public static A008735Inst Instance=new A008735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008736
{
public static readonly long[] Value={ 1L,0L,2L,0L,3L,0L,4L,0L,5L,1L,6L,2L,7L,3L,8L,4L,10L,5L,12L,6L,14L,7L,16L,8L,18L,10L,20L,12L,22L,14L,24L,16L,27L,18L,30L,20L,33L,22L,36L,24L,39L,27L,42L,30L,45L,33L,48L,36L,52L,39L,56L,42L,60L,45L,64L,48L,68L,52L,72L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008736Inst : IEnumerable<long>
{
public static readonly long[] Value=A008736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008736.Bytes);
public long this[int i]=>Value[i];

public static A008736Inst Instance=new A008736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008737
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,2L,4L,6L,6L,6L,6L,6L,9L,12L,12L,12L,12L,12L,16L,20L,20L,20L,20L,20L,25L,30L,30L,30L,30L,30L,36L,42L,42L,42L,42L,42L,49L,56L,56L,56L,56L,56L,64L,72L,72L,72L,72L,72L,81L,90L,90L,90L,90L,90L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008737Inst : IEnumerable<long>
{
public static readonly long[] Value=A008737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008737.Bytes);
public long this[int i]=>Value[i];

public static A008737Inst Instance=new A008737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008738
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,5L,7L,10L,13L,16L,20L,24L,29L,34L,39L,45L,51L,58L,65L,72L,80L,88L,97L,106L,115L,125L,135L,146L,157L,168L,180L,192L,205L,218L,231L,245L,259L,274L,289L,304L,320L,336L,353L,370L,387L,405L,423L,442L,461L,480L,500L,520L,541L,562L,583L,605L,627L,650L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008738Inst : IEnumerable<long>
{
public static readonly long[] Value=A008738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008738.Bytes);
public long this[int i]=>Value[i];

public static A008738Inst Instance=new A008738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008739
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,22L,26L,30L,34L,39L,44L,49L,54L,60L,66L,72L,79L,86L,93L,100L,108L,116L,124L,133L,142L,151L,160L,170L,180L,190L,201L,212L,223L,234L,246L,258L,270L,283L,296L,309L,322L,336L,350L,364L,379L,394L,409L,424L,440L,456L,472L,489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008739Inst : IEnumerable<long>
{
public static readonly long[] Value=A008739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008739.Bytes);
public long this[int i]=>Value[i];

public static A008739Inst Instance=new A008739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008740
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,16L,19L,22L,25L,28L,32L,36L,40L,44L,49L,54L,59L,64L,69L,75L,81L,87L,93L,100L,107L,114L,121L,128L,136L,144L,152L,160L,169L,178L,187L,196L,205L,215L,225L,235L,245L,256L,267L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008740Inst : IEnumerable<long>
{
public static readonly long[] Value=A008740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008740.Bytes);
public long this[int i]=>Value[i];

public static A008740Inst Instance=new A008740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008741
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008741Inst : IEnumerable<long>
{
public static readonly long[] Value=A008741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008741.Bytes);
public long this[int i]=>Value[i];

public static A008741Inst Instance=new A008741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008742
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,4L,2L,5L,4L,7L,5L,10L,7L,12L,10L,15L,12L,19L,15L,22L,19L,26L,22L,31L,26L,35L,31L,40L,35L,46L,40L,51L,46L,57L,51L,64L,57L,70L,64L,77L,70L,85L,77L,92L,85L,100L,92L,109L,100L,117L,109L,126L,117L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008742Inst : IEnumerable<long>
{
public static readonly long[] Value=A008742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008742.Bytes);
public long this[int i]=>Value[i];

public static A008742Inst Instance=new A008742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008743
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,3L,0L,4L,1L,5L,1L,7L,2L,8L,3L,10L,4L,12L,5L,14L,7L,16L,8L,19L,10L,21L,12L,24L,14L,27L,16L,30L,19L,33L,21L,37L,24L,40L,27L,44L,30L,48L,33L,52L,37L,56L,40L,61L,44L,65L,48L,70L,52L,75L,56L,80L,61L,85L,65L,91L,70L,96L,75L,102L,80L,108L,85L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008743Inst : IEnumerable<long>
{
public static readonly long[] Value=A008743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008743.Bytes);
public long this[int i]=>Value[i];

public static A008743Inst Instance=new A008743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008744
{
public static readonly long[] Value={ 1714L,1727L,1760L,1820L,1910L,1936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008744Inst : IEnumerable<long>
{
public static readonly long[] Value=A008744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008744.Bytes);
public long this[int i]=>Value[i];

public static A008744Inst Instance=new A008744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008745
{
public static readonly long[] Value={ 1732L,1735L,1743L,1751L,1758L,1767L,1767L,1782L,1773L,1790L,1795L,1784L,1800L,1804L,1791L,1809L,1808L,1822L,1822L,1831L,1829L,1837L,1833L,1837L,1843L,1858L,1857L,1856L,1865L,1872L,1874L,1882L,1884L,1890L,1917L,1908L,1913L,1913L,1924L,1911L,1924L,1946L,1946L,1961L,1946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008745Inst : IEnumerable<long>
{
public static readonly long[] Value=A008745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008745.Bytes);
public long this[int i]=>Value[i];

public static A008745Inst Instance=new A008745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008746
{
public static readonly long[] Value={ 778L,846L,863L,921L,967L,1081L,1121L,1187L,1214L,1289L,1423L,1462L,1601L,1638L,1710L,1754L,1785L,1755L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008746Inst : IEnumerable<long>
{
public static readonly long[] Value=A008746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008746.Bytes);
public long this[int i]=>Value[i];

public static A008746Inst Instance=new A008746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008747
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,6L,9L,11L,14L,17L,21L,24L,29L,33L,38L,43L,49L,54L,61L,67L,74L,81L,89L,96L,105L,113L,122L,131L,141L,150L,161L,171L,182L,193L,205L,216L,229L,241L,254L,267L,281L,294L,309L,323L,338L,353L,369L,384L,401L,417L,434L,451L,469L,486L,505L,523L,542L,561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008747Inst : IEnumerable<long>
{
public static readonly long[] Value=A008747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008747.Bytes);
public long this[int i]=>Value[i];

public static A008747Inst Instance=new A008747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008748
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,8L,10L,13L,16L,19L,23L,27L,31L,36L,41L,46L,52L,58L,64L,71L,78L,85L,93L,101L,109L,118L,127L,136L,146L,156L,166L,177L,188L,199L,211L,223L,235L,248L,261L,274L,288L,302L,316L,331L,346L,361L,377L,393L,409L,426L,443L,460L,478L,496L,514L,533L,552L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008748Inst : IEnumerable<long>
{
public static readonly long[] Value=A008748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008748.Bytes);
public long this[int i]=>Value[i];

public static A008748Inst Instance=new A008748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008749
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,9L,12L,15L,18L,21L,26L,29L,34L,39L,44L,49L,56L,61L,68L,75L,82L,89L,98L,105L,114L,123L,132L,141L,152L,161L,172L,183L,194L,205L,218L,229L,242L,255L,268L,281L,296L,309L,324L,339L,354L,369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008749Inst : IEnumerable<long>
{
public static readonly long[] Value=A008749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008749.Bytes);
public long this[int i]=>Value[i];

public static A008749Inst Instance=new A008749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008750
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,9L,11L,14L,17L,20L,24L,28L,32L,37L,42L,47L,53L,59L,65L,72L,79L,86L,94L,102L,110L,119L,128L,137L,147L,157L,167L,178L,189L,200L,212L,224L,236L,249L,262L,275L,289L,303L,317L,332L,347L,362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008750Inst : IEnumerable<long>
{
public static readonly long[] Value=A008750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008750.Bytes);
public long this[int i]=>Value[i];

public static A008750Inst Instance=new A008750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008751
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,11L,13L,16L,19L,23L,26L,31L,35L,40L,45L,51L,56L,63L,69L,76L,83L,91L,98L,107L,115L,124L,133L,143L,152L,163L,173L,184L,195L,207L,218L,231L,243L,256L,269L,283L,296L,311L,325L,340L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008751Inst : IEnumerable<long>
{
public static readonly long[] Value=A008751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008751.Bytes);
public long this[int i]=>Value[i];

public static A008751Inst Instance=new A008751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008752
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,13L,15L,18L,22L,25L,29L,34L,38L,43L,49L,54L,60L,67L,73L,80L,88L,95L,103L,112L,120L,129L,139L,148L,158L,169L,179L,190L,202L,213L,225L,238L,250L,263L,277L,290L,304L,319L,333L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008752Inst : IEnumerable<long>
{
public static readonly long[] Value=A008752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008752.Bytes);
public long this[int i]=>Value[i];

public static A008752Inst Instance=new A008752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008753
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,15L,17L,21L,24L,28L,32L,37L,41L,47L,52L,58L,64L,71L,77L,85L,92L,100L,108L,117L,125L,135L,144L,154L,164L,175L,185L,197L,208L,220L,232L,245L,257L,271L,284L,298L,312L,327L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008753Inst : IEnumerable<long>
{
public static readonly long[] Value=A008753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008753.Bytes);
public long this[int i]=>Value[i];

public static A008753Inst Instance=new A008753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008754
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,17L,20L,23L,27L,31L,35L,40L,45L,50L,56L,62L,68L,75L,82L,89L,97L,105L,113L,122L,131L,140L,150L,160L,170L,181L,192L,203L,215L,227L,239L,252L,265L,278L,292L,306L,320L,335L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008754Inst : IEnumerable<long>
{
public static readonly long[] Value=A008754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008754.Bytes);
public long this[int i]=>Value[i];

public static A008754Inst Instance=new A008754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008755
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,20L,22L,26L,30L,34L,38L,44L,48L,54L,60L,66L,72L,80L,86L,94L,102L,110L,118L,128L,136L,146L,156L,166L,176L,188L,198L,210L,222L,234L,246L,260L,272L,286L,300L,314L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008755Inst : IEnumerable<long>
{
public static readonly long[] Value=A008755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008755.Bytes);
public long this[int i]=>Value[i];

public static A008755Inst Instance=new A008755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008756
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,22L,25L,29L,33L,37L,42L,47L,52L,58L,64L,70L,77L,84L,91L,99L,107L,115L,124L,133L,142L,152L,162L,172L,183L,194L,205L,217L,229L,241L,254L,267L,280L,294L,308L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008756Inst : IEnumerable<long>
{
public static readonly long[] Value=A008756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008756.Bytes);
public long this[int i]=>Value[i];

public static A008756Inst Instance=new A008756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008757
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,25L,28L,32L,36L,41L,45L,51L,56L,62L,68L,75L,81L,89L,96L,104L,112L,121L,129L,139L,148L,158L,168L,179L,189L,201L,212L,224L,236L,249L,261L,275L,288L,302L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008757Inst : IEnumerable<long>
{
public static readonly long[] Value=A008757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008757.Bytes);
public long this[int i]=>Value[i];

public static A008757Inst Instance=new A008757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008758
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,24L,28L,31L,35L,40L,44L,49L,55L,60L,66L,73L,79L,86L,94L,101L,109L,118L,126L,135L,145L,154L,164L,175L,185L,196L,208L,219L,231L,244L,256L,269L,283L,296L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008758Inst : IEnumerable<long>
{
public static readonly long[] Value=A008758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008758.Bytes);
public long this[int i]=>Value[i];

public static A008758Inst Instance=new A008758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008759
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,24L,27L,31L,34L,39L,43L,48L,53L,59L,64L,71L,77L,84L,91L,99L,106L,115L,123L,132L,141L,151L,160L,171L,181L,192L,203L,215L,226L,239L,251L,264L,277L,291L,304L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008759Inst : IEnumerable<long>
{
public static readonly long[] Value=A008759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008759.Bytes);
public long this[int i]=>Value[i];

public static A008759Inst Instance=new A008759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008760
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,24L,27L,30L,34L,38L,42L,47L,52L,57L,63L,69L,75L,82L,89L,96L,104L,112L,120L,129L,138L,147L,157L,167L,177L,188L,199L,210L,222L,234L,246L,259L,272L,285L,299L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008760Inst : IEnumerable<long>
{
public static readonly long[] Value=A008760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008760.Bytes);
public long this[int i]=>Value[i];

public static A008760Inst Instance=new A008760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008761
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,7L,8L,10L,12L,14L,16L,19L,21L,24L,27L,30L,33L,38L,41L,46L,51L,56L,61L,68L,73L,80L,87L,94L,101L,110L,117L,126L,135L,144L,153L,164L,173L,184L,195L,206L,217L,230L,241L,254L,267L,280L,293L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008761Inst : IEnumerable<long>
{
public static readonly long[] Value=A008761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008761.Bytes);
public long this[int i]=>Value[i];

public static A008761Inst Instance=new A008761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008762
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,15L,20L,26L,33L,41L,50L,61L,73L,86L,101L,118L,136L,156L,178L,202L,228L,256L,286L,319L,354L,391L,431L,474L,519L,567L,618L,672L,729L,789L,852L,919L,989L,1062L,1139L,1220L,1304L,1392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008762Inst : IEnumerable<long>
{
public static readonly long[] Value=A008762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008762.Bytes);
public long this[int i]=>Value[i];

public static A008762Inst Instance=new A008762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008763
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,3L,4L,7L,9L,14L,17L,24L,29L,38L,45L,57L,66L,81L,93L,111L,126L,148L,166L,192L,214L,244L,270L,305L,335L,375L,410L,455L,495L,546L,591L,648L,699L,762L,819L,889L,952L,1029L,1099L,1183L,1260L,1352L,1436L,1536L,1628L,1736L,1836L,1953L,2061L,2187L,2304L,2439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008763Inst : IEnumerable<long>
{
public static readonly long[] Value=A008763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008763.Bytes);
public long this[int i]=>Value[i];

public static A008763Inst Instance=new A008763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008764
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,8L,12L,16L,21L,27L,34L,42L,52L,62L,74L,88L,103L,119L,138L,158L,180L,204L,230L,258L,289L,321L,356L,394L,434L,476L,522L,570L,621L,675L,732L,792L,856L,922L,992L,1066L,1143L,1223L,1308L,1396L,1488L,1584L,1684L,1788L,1897L,2009L,2126L,2248L,2374L,2504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008764Inst : IEnumerable<long>
{
public static readonly long[] Value=A008764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008764.Bytes);
public long this[int i]=>Value[i];

public static A008764Inst Instance=new A008764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008765
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,7L,11L,14L,20L,24L,32L,38L,49L,57L,70L,81L,98L,111L,131L,148L,172L,192L,220L,244L,277L,305L,342L,375L,418L,455L,503L,546L,600L,648L,708L,762L,829L,889L,962L,1029L,1110L,1183L,1271L,1352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008765Inst : IEnumerable<long>
{
public static readonly long[] Value=A008765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008765.Bytes);
public long this[int i]=>Value[i];

public static A008765Inst Instance=new A008765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008846
{
public static readonly long[] Value={ 5L,13L,17L,25L,29L,37L,41L,53L,61L,65L,73L,85L,89L,97L,101L,109L,113L,125L,137L,145L,149L,157L,169L,173L,181L,185L,193L,197L,205L,221L,229L,233L,241L,257L,265L,269L,277L,281L,289L,293L,305L,313L,317L,325L,337L,349L,353L,365L,373L,377L,389L,397L,401L,409L,421L,425L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008846Inst : IEnumerable<long>
{
public static readonly long[] Value=A008846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008846.Bytes);
public long this[int i]=>Value[i];

public static A008846Inst Instance=new A008846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008847
{
public static readonly long[] Value={ 1L,9L,20L,180L,1306L,1910L,11754L,17190L,32486L,38423L,47576L,48202L,50920L,51590L,83884L,104855L,132682L,198534L,247863L,292374L,300876L,312374L,313929L,334330L,345807L,376095L,428184L,433818L,458280L,464310L,469623L,498892L,623615L,754956L,768460L,787127L,943695L,985369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008847Inst : IEnumerable<long>
{
public static readonly long[] Value=A008847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008847.Bytes);
public long this[int i]=>Value[i];

public static A008847Inst Instance=new A008847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008848
{
public static readonly long[] Value={ 1L,81L,400L,32400L,1705636L,3648100L,138156516L,295496100L,1055340196L,1476326929L,2263475776L,2323432804L,2592846400L,2661528100L,7036525456L,10994571025L,17604513124L,39415749156L,61436066769L,85482555876L,90526367376L,97577515876L,98551417041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008848Inst : IEnumerable<long>
{
public static readonly long[] Value=A008848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008848.Bytes);
public long this[int i]=>Value[i];

public static A008848Inst Instance=new A008848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008849
{
public static readonly long[] Value={ 1L,7L,751530L,4730879L,5260710L,33116153L,37200735L,187062910L,226141311L,259109835L,260405145L,370049418L,522409465L,836308083L,1105725765L,1309440370L,1343713507L,1582989177L,1609505430L,1813768845L,2590345926L,3039492538L,3656866255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008849Inst : IEnumerable<long>
{
public static readonly long[] Value=A008849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008849.Bytes);
public long this[int i]=>Value[i];

public static A008849Inst Instance=new A008849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008850
{
public static readonly long[] Value={ 1L,43098L,20746664124L,21531558370L,25933330155L,30519275171L,453393100534L,803844998180L,1233758294601L,2358796315843L,6260406046762L,7339897643091L,7540242750903L,8532869860592L,11879890160946L,17538398093508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008850Inst : IEnumerable<long>
{
public static readonly long[] Value=A008850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008850.Bytes);
public long this[int i]=>Value[i];

public static A008850Inst Instance=new A008850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008851
{
public static readonly long[] Value={ 0L,1L,5L,6L,10L,11L,15L,16L,20L,21L,25L,26L,30L,31L,35L,36L,40L,41L,45L,46L,50L,51L,55L,56L,60L,61L,65L,66L,70L,71L,75L,76L,80L,81L,85L,86L,90L,91L,95L,96L,100L,101L,105L,106L,110L,111L,115L,116L,120L,121L,125L,126L,130L,131L,135L,136L,140L,141L,145L,146L,150L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008851Inst : IEnumerable<long>
{
public static readonly long[] Value=A008851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008851.Bytes);
public long this[int i]=>Value[i];

public static A008851Inst Instance=new A008851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008852
{
public static readonly long[] Value={ 0L,1L,25L,76L,100L,101L,125L,176L,200L,201L,225L,276L,300L,301L,325L,376L,400L,401L,425L,476L,500L,501L,525L,576L,600L,601L,625L,676L,700L,701L,725L,776L,800L,801L,825L,876L,900L,901L,925L,976L,1000L,1001L,1025L,1076L,1100L,1101L,1125L,1176L,1200L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008852Inst : IEnumerable<long>
{
public static readonly long[] Value=A008852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008852.Bytes);
public long this[int i]=>Value[i];

public static A008852Inst Instance=new A008852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008853
{
public static readonly long[] Value={ 0L,1L,376L,625L,1000L,1001L,1376L,1625L,2000L,2001L,2376L,2625L,3000L,3001L,3376L,3625L,4000L,4001L,4376L,4625L,5000L,5001L,5376L,5625L,6000L,6001L,6376L,6625L,7000L,7001L,7376L,7625L,8000L,8001L,8376L,8625L,9000L,9001L,9376L,9625L,10000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008853Inst : IEnumerable<long>
{
public static readonly long[] Value=A008853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008853.Bytes);
public long this[int i]=>Value[i];

public static A008853Inst Instance=new A008853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008854
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,9L,10L,11L,14L,15L,16L,19L,20L,21L,24L,25L,26L,29L,30L,31L,34L,35L,36L,39L,40L,41L,44L,45L,46L,49L,50L,51L,54L,55L,56L,59L,60L,61L,64L,65L,66L,69L,70L,71L,74L,75L,76L,79L,80L,81L,84L,85L,86L,89L,90L,91L,94L,95L,96L,99L,100L,101L,104L,105L,106L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008854Inst : IEnumerable<long>
{
public static readonly long[] Value=A008854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008854.Bytes);
public long this[int i]=>Value[i];

public static A008854Inst Instance=new A008854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008855
{
public static readonly long[] Value={ 1L,2L,6L,1L,18L,8L,55L,2L,40L,174L,22L,168L,566L,6L,134L,676L,1868L,1L,72L,656L,2672L,6237L,30L,482L,2992L,10376L,21050L,8L,310L,2592L,13160L,39824L,71666L,2L,151L,2086L,12862L,56162L,151878L,245696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008855Inst : IEnumerable<long>
{
public static readonly long[] Value=A008855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008855.Bytes);
public long this[int i]=>Value[i];

public static A008855Inst Instance=new A008855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008856
{
public static readonly long[] Value={ 0L,1L,24L,25L,49L,51L,75L,76L,99L,100L,101L,124L,125L,149L,151L,175L,176L,199L,200L,201L,224L,225L,249L,251L,275L,276L,299L,300L,301L,324L,325L,349L,351L,375L,376L,399L,400L,401L,424L,425L,449L,451L,475L,476L,499L,500L,501L,524L,525L,549L,551L,575L,576L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008856Inst : IEnumerable<long>
{
public static readonly long[] Value=A008856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008856.Bytes);
public long this[int i]=>Value[i];

public static A008856Inst Instance=new A008856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}