using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A204157
{
public static readonly long[] Value={ 1L,-1L,-13L,-4L,1L,88L,78L,9L,-1L,-496L,-704L,-260L,-16L,1L,2560L,4960L,3080L,650L,25L,-1L,-12544L,-30720L,-26784L,-9856L,-1365L,-36L,1L,59392L,175616L,197120L,104160L,25872L,2548L,49L,-1L,-274432L,-950272L,-1304576L,-901120L,-327360L,-59136L,-4368L,-64L,1L,1245184L,4939776L,8017920L,6849024L,3294720L };
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
public class A204157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204157Inst : IEnumerable<long>
{
public static readonly long[] Value=A204157.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204157.Bytes);
public long this[int i]=>Value[i];

public static A204157Inst Instance=new A204157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204158
{
public static readonly long[] Value={ 1L,4L,4L,7L,2L,7L,10L,5L,5L,10L,13L,8L,3L,8L,13L,16L,11L,6L,6L,11L,16L,19L,14L,9L,4L,9L,14L,19L,22L,17L,12L,7L,7L,12L,17L,22L,25L,20L,15L,10L,5L,10L,15L,20L,25L,28L,23L,18L,13L,8L,8L,13L,18L,23L,28L,31L,26L,21L,16L,11L,6L,11L,16L,21L,26L,31L,34L,29L,24L,19L,14L,9L,9L,14L };
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
public class A204158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204158Inst : IEnumerable<long>
{
public static readonly long[] Value=A204158.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204158.Bytes);
public long this[int i]=>Value[i];

public static A204158Inst Instance=new A204158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204159
{
public static readonly long[] Value={ 1L,-1L,-14L,-3L,1L,115L,79L,6L,-1L,-800L,-895L,-255L,-10L,1L,5125L,7875L,3850L,625L,15L,-1L,-31250L,-60875L,-42075L,-12180L,-1295L,-21L,1L,184375L,434375L,387750L,162375L,31710L,2394L,28L,-1L,-1062500L,-2934375L };
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
public class A204159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204159Inst : IEnumerable<long>
{
public static readonly long[] Value=A204159.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204159.Bytes);
public long this[int i]=>Value[i];

public static A204159Inst Instance=new A204159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204160
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,13L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,19L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A204160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204160Inst : IEnumerable<long>
{
public static readonly long[] Value=A204160.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204160.Bytes);
public long this[int i]=>Value[i];

public static A204160Inst Instance=new A204160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204161
{
public static readonly long[] Value={ 1L,-1L,3L,-5L,1L,18L,-36L,12L,-1L,162L,-360L,153L,-22L,1L,1944L,-4644L,2295L,-435L,35L,-1L,29160L,-73548L,40419L,-9135L,990L,-51L,1L,524880L,-1382184L,823284L,-210924L,27720L,-1953L,70L,-1L,11022480L };
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
public class A204161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204161Inst : IEnumerable<long>
{
public static readonly long[] Value=A204161.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204161.Bytes);
public long this[int i]=>Value[i];

public static A204161Inst Instance=new A204161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204162
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A204162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204162Inst : IEnumerable<long>
{
public static readonly long[] Value=A204162.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204162.Bytes);
public long this[int i]=>Value[i];

public static A204162Inst Instance=new A204162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204163
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,1L,0L,-2L,4L,-1L,0L,-2L,7L,-6L,1L,0L,-4L,17L,-21L,9L,-1L,0L,-8L,40L,-64L,43L,-12L,1L,0L,-24L,132L,-244L,206L,-85L,16L,-1L,0L,-72L,432L,-904L,913L,-492L,142L,-20L,1L,0L,-288L,1836L,-4180L,4749L,-3025L,1118L,-234L,25L,-1L,0L };
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
public class A204163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204163Inst : IEnumerable<long>
{
public static readonly long[] Value=A204163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204163.Bytes);
public long this[int i]=>Value[i];

public static A204163Inst Instance=new A204163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204164
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L };
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
public class A204164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204164Inst : IEnumerable<long>
{
public static readonly long[] Value=A204164.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204164.Bytes);
public long this[int i]=>Value[i];

public static A204164Inst Instance=new A204164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204165
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,1L,-1L,-2L,6L,-1L,0L,4L,4L,-10L,1L,0L,0L,-15L,-4L,15L,-1L,0L,0L,0L,36L,3L,-21L,1L,0L,0L,0L,0L,-84L,4L,28L,-1L,0L,0L,0L,0L,0L,160L,-16L,-36L,1L,0L,0L,0L,0L,0L,0L,-300L,40L,45L,-1L,0L,0L,0L,0L,0L,0L,0L,500L,-75L,-55L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-825L,130L };
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
public class A204165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204165Inst : IEnumerable<long>
{
public static readonly long[] Value=A204165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204165.Bytes);
public long this[int i]=>Value[i];

public static A204165Inst Instance=new A204165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204166
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L };
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
public class A204166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204166Inst : IEnumerable<long>
{
public static readonly long[] Value=A204166.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204166.Bytes);
public long this[int i]=>Value[i];

public static A204166Inst Instance=new A204166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204167
{
public static readonly long[] Value={ 1L,-1L,-2L,-3L,1L,1L,6L,6L,-1L,0L,-4L,-16L,-10L,1L,0L,0L,15L,32L,15L,-1L,0L,0L,0L,-36L,-60L,-21L,1L,0L,0L,0L,0L,84L,100L,28L,-1L,0L,0L,0L,0L,0L,-160L,-160L,-36L,1L,0L,0L,0L,0L,0L,0L,300L,240L,45L,-1L,0L,0L,0L,0L,0L,0L,0L,-500L,-350L };
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
public class A204167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204167Inst : IEnumerable<long>
{
public static readonly long[] Value=A204167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204167.Bytes);
public long this[int i]=>Value[i];

public static A204167Inst Instance=new A204167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204168
{
public static readonly long[] Value={ 2L,-1L,-1L,-6L,1L,0L,6L,12L,-1L,0L,0L,-20L,-20L,1L,0L,0L,0L,50L,30L,-1L,0L,0L,0L,0L,-105L,-42L,1L,0L,0L,0L,0L,0L,196L,56L,-1L,0L,0L,0L,0L,0L,0L,-336L,-72L,1L,0L,0L,0L,0L,0L,0L,0L,540L,90L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-825L,-110L,1L };
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
public class A204168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204168Inst : IEnumerable<long>
{
public static readonly long[] Value=A204168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204168.Bytes);
public long this[int i]=>Value[i];

public static A204168Inst Instance=new A204168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204169
{
public static readonly long[] Value={ 1L,-1L,-1L,-4L,1L,0L,6L,9L,-1L,0L,0L,-20L,-16L,1L,0L,0L,0L,50L,25L,-1L,0L,0L,0L,0L,-105L,-36L,1L,0L,0L,0L,0L,0L,196L,49L,-1L,0L,0L,0L,0L,0L,0L,-336L,-64L,1L,0L,0L,0L,0L,0L,0L,0L,540L,81L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,-825L,-100L,1L };
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
public class A204169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204169Inst : IEnumerable<long>
{
public static readonly long[] Value=A204169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204169.Bytes);
public long this[int i]=>Value[i];

public static A204169Inst Instance=new A204169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204170
{
public static readonly long[] Value={ 1L,-1L,0L,-5L,1L,0L,0L,14L,-1L,0L,0L,0L,-30L,1L,0L,0L,0L,0L,55L,-1L,0L,0L,0L,0L,0L,-91L,1L,0L,0L,0L,0L,0L,0L,140L,-1L,0L,0L,0L,0L,0L,0L,0L,-204L,1L,0L,0L,0L,0L,0L,0L,0L,0L,285L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-385L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,506L,-1L };
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
public class A204170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204170Inst : IEnumerable<long>
{
public static readonly long[] Value=A204170.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204170.Bytes);
public long this[int i]=>Value[i];

public static A204170Inst Instance=new A204170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204171
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L };
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
public class A204171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204171Inst : IEnumerable<long>
{
public static readonly long[] Value=A204171.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204171.Bytes);
public long this[int i]=>Value[i];

public static A204171Inst Instance=new A204171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204172
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-1L,1L,2L,-1L,0L,1L,-1L,-2L,1L,1L,-1L,-4L,3L,3L,-1L,0L,-1L,1L,4L,-3L,-3L,1L,-1L,1L,6L,-5L,-10L,6L,4L,-1L,0L,1L,-1L,-6L,5L,10L,-6L,-4L,1L,1L,-1L,-8L,7L,21L,-15L,-20L,10L,5L,-1L,0L,-1L,1L,8L,-7L,-21L,15L,20L,-10L,-5L,1L,-1L,1L,10L,-9L,-36L,28L,56L };
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
public class A204172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204172Inst : IEnumerable<long>
{
public static readonly long[] Value=A204172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204172.Bytes);
public long this[int i]=>Value[i];

public static A204172Inst Instance=new A204172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204173
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,2L,0L,2L,2L,0L,3L,0L,2L,0L,3L,0L,3L,0L,0L,3L,0L,4L,0L,3L,0L,3L,0L,4L,0L,4L,0L,3L,3L,0L,4L,0L,5L,0L,4L,0L,3L,0L,4L,0L,5L,0L,5L,0L,4L,0L,0L,4L,0L,5L,0L,6L,0L,5L,0L,4L,0L,4L,0L,5L,0L,6L,0L,6L,0L,5L,0L,4L,4L,0L,5L,0L,6L,0L,7L,0L,6L,0L,5L,0L,4L,0L,5L,0L,6L,0L,7L,0L,7L,0L,6L,0L,5L,0L,0L };
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
public class A204173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204173Inst : IEnumerable<long>
{
public static readonly long[] Value=A204173.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204173.Bytes);
public long this[int i]=>Value[i];

public static A204173Inst Instance=new A204173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204174
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,1L,-4L,6L,3L,-1L,0L,4L,-6L,-3L,1L,36L,-60L,-31L,33L,6L,-1L,0L,-36L,60L,31L,-33L,-6L,1L,-576L,1008L,516L,-736L,-131L,105L,10L,-1L,0L,576L,-1008L,-516L,736L,131L,-105L,-10L,1L,14400L,-25920L,-13116L,21628L,3621L,-4581L,-406L,255L };
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
public class A204174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204174Inst : IEnumerable<long>
{
public static readonly long[] Value=A204174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204174.Bytes);
public long this[int i]=>Value[i];

public static A204174Inst Instance=new A204174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204175
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L };
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
public class A204175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204175Inst : IEnumerable<long>
{
public static readonly long[] Value=A204175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204175.Bytes);
public long this[int i]=>Value[i];

public static A204175Inst Instance=new A204175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204176
{
public static readonly long[] Value={ 0L,-1L,-1L,-1L,1L,0L,1L,1L,-1L,1L,1L,-3L,-2L,1L,0L,-1L,-1L,3L,2L,-1L,-1L,-1L,5L,4L,-6L,-3L,1L,0L,1L,1L,-5L,-4L,6L,3L,-1L,1L,1L,-7L,-6L,15L,10L,-10L,-4L,1L,0L,-1L,-1L,7L,6L,-15L,-10L,10L,4L,-1L,-1L,-1L,9L,8L,-28L,-21L,35L,20L,-15L,-5L,1L,0L,1L,1L,-9L,-8L,28L,21L };
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
public class A204176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204176Inst : IEnumerable<long>
{
public static readonly long[] Value=A204176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204176.Bytes);
public long this[int i]=>Value[i];

public static A204176Inst Instance=new A204176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204177
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
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
public class A204177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204177Inst : IEnumerable<long>
{
public static readonly long[] Value=A204177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204177.Bytes);
public long this[int i]=>Value[i];

public static A204177Inst Instance=new A204177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204178
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,1L,-1L,-1L,3L,-1L,-2L,2L,3L,-4L,1L,-3L,7L,-2L,-6L,5L,-1L,-4L,14L,-15L,0L,10L,-6L,1L,-5L,23L,-39L,25L,5L,-15L,7L,-1L,-6L,34L,-77L,84L,-35L,-14L,21L,-8L,1L,-7L,47L,-132L,196L,-154L,42L,28L,-28L,9L,-1L,-8L,62L,-207L,384L,-420L,252L };
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
public class A204178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204178Inst : IEnumerable<long>
{
public static readonly long[] Value=A204178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204178.Bytes);
public long this[int i]=>Value[i];

public static A204178Inst Instance=new A204178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204179
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,0L,0L,1L,1L,0L,3L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,4L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,5L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,6L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L };
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
public class A204179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204179Inst : IEnumerable<long>
{
public static readonly long[] Value=A204179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204179.Bytes);
public long this[int i]=>Value[i];

public static A204179Inst Instance=new A204179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204180
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,1L,1L,-9L,6L,-1L,-2L,-32L,32L,-10L,1L,-34L,-132L,183L,-81L,15L,-1L,-324L,-604L,1159L,-655L,170L,-21L,1L,-2988L,-2860L,8137L,-5589L,1825L,-316L,28L,-1L,-28944L,-11864L,62852L,-51184L,19894L,-4326L,539L,-36L,1L,-300816L,-8568L };
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
public class A204180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204180Inst : IEnumerable<long>
{
public static readonly long[] Value=A204180.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204180.Bytes);
public long this[int i]=>Value[i];

public static A204180Inst Instance=new A204180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204181
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,0L,0L,1L,1L,0L,5L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,7L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,9L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,11L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L };
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
public class A204181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204181Inst : IEnumerable<long>
{
public static readonly long[] Value=A204181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204181.Bytes);
public long this[int i]=>Value[i];

public static A204181Inst Instance=new A204181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204182
{
public static readonly long[] Value={ 1L,-1L,2L,-4L,1L,7L,-21L,9L,-1L,34L,-146L,83L,-16L,1L,201L,-1277L,878L,-226L,25L,-1L,1266L,-13504L,10729L,-3340L,500L,-36L,1L,6063L,-167689L,149971L,-53679L,9805L,-967L,49L,-1L,-44190L,-2392326L,2368995L,-946036L,199829L };
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
public class A204182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204182Inst : IEnumerable<long>
{
public static readonly long[] Value=A204182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204182.Bytes);
public long this[int i]=>Value[i];

public static A204182Inst Instance=new A204182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204183
{
public static readonly long[] Value={ 1L,1L,1L,1L,-1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,-1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L };
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
public class A204183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204183Inst : IEnumerable<long>
{
public static readonly long[] Value=A204183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204183.Bytes);
public long this[int i]=>Value[i];

public static A204183Inst Instance=new A204183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204184
{
public static readonly long[] Value={ 1L,-1L,-2L,0L,1L,-1L,3L,1L,-1L,2L,-2L,-5L,0L,1L,1L,-5L,-2L,6L,1L,-1L,-2L,4L,9L,-4L,-8L,0L,1L,-1L,7L,3L,-15L,-3L,9L,1L,-1L,2L,-6L,-13L,12L,21L,-6L,-11L,0L,1L,1L,-9L,-4L,28L,6L,-30L,-4L,12L,1L,-1L,-2L,8L,17L,-24L,-40L,24L,38L,-8L,-14L,0L,1L,-1L,11L,5L };
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
public class A204184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204184Inst : IEnumerable<long>
{
public static readonly long[] Value=A204184.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204184.Bytes);
public long this[int i]=>Value[i];

public static A204184Inst Instance=new A204184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204185
{
public static readonly long[] Value={ 0L,0L,6L,33L,102L,243L,492L,894L,1500L,2370L,3570L,5175L,7266L,9933L,13272L,17388L,22392L,28404L,35550L,43965L,53790L,65175L,78276L,93258L,110292L,129558L,151242L,175539L,202650L,232785L,266160L,303000L,343536L,388008L,436662L,489753L,547542L,610299L,678300L,751830L,831180L,916650L,1008546L,1107183L,1212882L,1325973L,1446792L,1575684L,1713000L,1859100L,2014350L };
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
public class A204185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204185Inst : IEnumerable<long>
{
public static readonly long[] Value=A204185.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204185.Bytes);
public long this[int i]=>Value[i];

public static A204185Inst Instance=new A204185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204186
{
public static readonly long[] Value={ 0L,0L,1L,2L,10L,53L,376L,3379L,37408L,485680L,7150241L,116726073L,2085446355L };
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
public class A204186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204186Inst : IEnumerable<long>
{
public static readonly long[] Value=A204186.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204186.Bytes);
public long this[int i]=>Value[i];

public static A204186Inst Instance=new A204186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204187
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,3L,6L,0L,6L,5L,10L,0L,12L,7L,10L,0L,16L,9L,18L,0L,14L,11L,22L,0L,20L,13L,18L,0L,28L,15L,30L,0L,22L,17L,0L,0L,36L,19L,26L,0L,40L,21L,42L,0L,21L,23L,46L,0L,42L,25L,34L,0L,52L,27L,0L,0L,38L,29L,58L,0L,60L,31L,42L,0L,52L,33L,66L,0L,46L,35L,70L,0L };
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
public class A204187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204187Inst : IEnumerable<long>
{
public static readonly long[] Value=A204187.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204187.Bytes);
public long this[int i]=>Value[i];

public static A204187Inst Instance=new A204187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204188
{
public static readonly long[] Value={ 5L,5L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L,7L };
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
public class A204188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204188Inst : IEnumerable<long>
{
public static readonly long[] Value=A204188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204188.Bytes);
public long this[int i]=>Value[i];

public static A204188Inst Instance=new A204188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204189
{
public static readonly long[] Value={ 43142746595714191L,48425980631694091L,53709214667673991L,58992448703653891L,64275682739633791L,69558916775613691L,74842150811593591L,80125384847573491L,85408618883553391L,90691852919533291L,95975086955513191L,101258320991493091L,106541555027472991L,111824789063452891L,117108023099432791L,122391257135412691L,127674491171392591L,132957725207372491L,138240959243352391L,143524193279332291L,148807427315312191L,154090661351292091L,159373895387271991L,164657129423251891L,169940363459231791L,175223597495211691L };
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
public class A204189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204189Inst : IEnumerable<long>
{
public static readonly long[] Value=A204189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204189.Bytes);
public long this[int i]=>Value[i];

public static A204189Inst Instance=new A204189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204190
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,15L,54L,231L,1151L,6544L,41759L,295373L,2293276L,19387721L,177278761L,1743221942L,18342831993L,205649438307L,2447327139282L,30810764360107L,409126482916771L,5714631215634236L,83760248865355379L,1285427577602987313L,BigInteger.Parse("20613047005064025320") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204190Inst Instance=new A204190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204191
{
public static readonly BigInteger[] Value={ 1L,8L,33L,265L,3716L,85681L,3162172L,193490711L,19420814056L,3186206928387L,862553899224504L,384159816761460081L,BigInteger.Parse("280924309017824796979"),BigInteger.Parse("338777671702533919423933"),BigInteger.Parse("672692693382038110389392230") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204191Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204191.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204191Inst Instance=new A204191Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204192
{
public static readonly long[] Value={ 3L,18L,33L,86L,231L,639L,1724L,4697L,12763L,34668L,94209L,255980L,695507L,1889810L,5134844L,13952002L,37909418L,103004707L,279876923L,760461448L,2066270880L,5614322044L,15254830655L,41449324425L,112623111961L,306011389311L };
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
public class A204192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204192Inst : IEnumerable<long>
{
public static readonly long[] Value=A204192.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204192.Bytes);
public long this[int i]=>Value[i];

public static A204192Inst Instance=new A204192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204193
{
public static readonly long[] Value={ 5L,50L,86L,265L,883L,2974L,9940L,33462L,112470L,377908L,1270638L,4271547L,14358358L,48270403L,162269445L,545492694L,1833790077L,6164622703L,20723502506L,69666040146L,234195417025L,787291729779L,2646629705960L,8897142589375L };
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
public class A204193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204193Inst : IEnumerable<long>
{
public static readonly long[] Value=A204193.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204193.Bytes);
public long this[int i]=>Value[i];

public static A204193Inst Instance=new A204193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204194
{
public static readonly long[] Value={ 8L,128L,231L,883L,3716L,15780L,67169L,286470L,1221769L,5217560L,22265850L,95057632L,405842314L,1732540170L,7396709713L,31579033671L,134818081160L,575577552695L,2457313356354L,10490943349879L,44788864504224L,191216664019901L };
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
public class A204194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204194Inst : IEnumerable<long>
{
public static readonly long[] Value=A204194.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204194.Bytes);
public long this[int i]=>Value[i];

public static A204194Inst Instance=new A204194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204195
{
public static readonly long[] Value={ 13L,338L,639L,2974L,15780L,85681L,461894L,2501104L,13632039L,74052393L,402461304L,2191865388L,11921228286L,64849845095L,352971589737L,1920427592045L,10448975722238L,56861941373875L,309398162988521L,1683518039170569L };
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
public class A204195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204195Inst : IEnumerable<long>
{
public static readonly long[] Value=A204195.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204195.Bytes);
public long this[int i]=>Value[i];

public static A204195Inst Instance=new A204195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204196
{
public static readonly long[] Value={ 21L,882L,1724L,9940L,67169L,461894L,3162172L,21906411L,152100304L,1053377463L,7321279936L,50893161901L,353396805989L,2456759583794L,17078402117279L,118676436051497L,824965798194515L,5734649466128312L,39857755473341719L };
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
public class A204196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204196Inst : IEnumerable<long>
{
public static readonly long[] Value=A204196.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204196.Bytes);
public long this[int i]=>Value[i];

public static A204196Inst Instance=new A204196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204197
{
public static readonly long[] Value={ 1L,2L,2L,3L,8L,3L,5L,18L,18L,5L,8L,50L,33L,50L,8L,13L,128L,86L,86L,128L,13L,21L,338L,231L,265L,231L,338L,21L,34L,882L,639L,883L,883L,639L,882L,34L,55L,2312L,1724L,2974L,3716L,2974L,1724L,2312L,55L,89L,6050L,4697L,9940L,15780L,15780L,9940L,4697L,6050L,89L,144L,15842L };
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
public class A204197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204197Inst : IEnumerable<long>
{
public static readonly long[] Value=A204197.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204197.Bytes);
public long this[int i]=>Value[i];

public static A204197Inst Instance=new A204197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204198
{
public static readonly long[] Value={ 0L,1L,2L,4L,14L,57L,341L };
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
public class A204198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204198Inst : IEnumerable<long>
{
public static readonly long[] Value=A204198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204198.Bytes);
public long this[int i]=>Value[i];

public static A204198Inst Instance=new A204198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204199
{
public static readonly long[] Value={ 0L,0L,0L,1L,4L,24L,139L };
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
public class A204199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204199Inst : IEnumerable<long>
{
public static readonly long[] Value=A204199.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204199.Bytes);
public long this[int i]=>Value[i];

public static A204199Inst Instance=new A204199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204200
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,60L,189L,595L,1873L,5896L,18560L,58425L,183916L,578949L,1822473L,5736961L,18059374L,56849086L,178955183L,563332848L,1773314929L,5582216355L,17572253481L,55315679788L,174128175064L,548137914373L,1725482812088L };
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
public class A204200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204200Inst : IEnumerable<long>
{
public static readonly long[] Value=A204200.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204200.Bytes);
public long this[int i]=>Value[i];

public static A204200Inst Instance=new A204200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204201
{
public static readonly long[] Value={ 1L,1L,4L,1L,5L,10L,1L,6L,15L,22L,1L,7L,21L,37L,46L,1L,8L,28L,58L,83L,94L,1L,9L,36L,86L,141L,177L,190L,1L,10L,45L,122L,227L,318L,367L,382L,1L,11L,55L,167L,349L,545L,685L,749L,766L,1L,12L,66L,222L,516L,894L,1230L,1434L,1515L,1534L,1L,13L,78L,288L,738L,1410L };
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
public class A204201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204201Inst : IEnumerable<long>
{
public static readonly long[] Value=A204201.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204201.Bytes);
public long this[int i]=>Value[i];

public static A204201Inst Instance=new A204201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204202
{
public static readonly long[] Value={ 2L,2L,5L,2L,7L,11L,2L,9L,18L,23L,2L,11L,27L,41L,47L,2L,13L,38L,68L,88L,95L,2L,15L,51L,106L,156L,183L,191L,2L,17L,66L,157L,262L,339L,374L,383L,2L,19L,83L,223L,419L,601L,713L,757L,767L,2L,21L,102L,306L,642L,1020L,1314L,1470L,1524L,1535L,2L,23L,123L,408L,948L };
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
public class A204202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204202Inst : IEnumerable<long>
{
public static readonly long[] Value=A204202.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204202.Bytes);
public long this[int i]=>Value[i];

public static A204202Inst Instance=new A204202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204203
{
public static readonly long[] Value={ 1L,1L,5L,1L,6L,13L,1L,7L,19L,29L,1L,8L,26L,48L,61L,1L,9L,34L,74L,109L,125L,1L,10L,43L,108L,183L,234L,253L,1L,11L,53L,151L,291L,417L,487L,509L,1L,12L,64L,204L,442L,708L,904L,996L,1021L,1L,13L,76L,268L,646L,1150L,1612L,1900L,2017L,2045L,1L,14L,89L,344L,914L };
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
public class A204203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204203Inst : IEnumerable<long>
{
public static readonly long[] Value=A204203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204203.Bytes);
public long this[int i]=>Value[i];

public static A204203Inst Instance=new A204203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204204
{
public static readonly long[] Value={ 3L,3L,7L,3L,10L,15L,3L,13L,25L,31L,3L,16L,38L,56L,63L,3L,19L,54L,94L,119L,127L,3L,22L,73L,148L,213L,246L,255L,3L,25L,95L,221L,361L,459L,501L,511L,3L,28L,120L,316L,582L,820L,960L,1012L,1023L,3L,31L,148L,436L,898L,1402L,1780L,1972L,2035L,2047L,3L,34L,179L };
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
public class A204204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204204Inst : IEnumerable<long>
{
public static readonly long[] Value=A204204.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204204.Bytes);
public long this[int i]=>Value[i];

public static A204204Inst Instance=new A204204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204205
{
public static readonly long[] Value={ 1L,1L,6L,1L,7L,16L,1L,8L,23L,36L,1L,9L,31L,59L,76L,1L,10L,40L,90L,135L,156L,1L,11L,50L,130L,225L,291L,316L,1L,12L,61L,180L,355L,516L,607L,636L,1L,13L,73L,241L,535L,871L,1123L,1243L,1276L,1L,14L,86L,314L,776L,1406L,1994L,2366L,2519L,2556L,1L,15L,100L,400L };
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
public class A204205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204205Inst : IEnumerable<long>
{
public static readonly long[] Value=A204205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204205.Bytes);
public long this[int i]=>Value[i];

public static A204205Inst Instance=new A204205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204206
{
public static readonly long[] Value={ 3L,5L,7L,9L,12L,15L,17L,21L,27L,31L,33L,38L,48L,58L,63L,65L,71L,86L,106L,121L,127L,129L,136L,157L,192L,227L,248L,255L,257L,265L,293L,349L,419L,475L,503L,511L,513L,522L,558L,642L,768L,894L,978L,1014L,1023L,1025L,1035L,1080L,1200L,1410L,1662L,1872L };
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
public class A204206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204206Inst : IEnumerable<long>
{
public static readonly long[] Value=A204206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204206.Bytes);
public long this[int i]=>Value[i];

public static A204206Inst Instance=new A204206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204207
{
public static readonly long[] Value={ 2L,3L,5L,5L,8L,11L,9L,13L,19L,23L,17L,22L,32L,42L,47L,33L,39L,54L,74L,89L,95L,65L,72L,93L,128L,163L,184L,191L,129L,137L,165L,221L,291L,347L,375L,383L,257L,266L,302L,386L,512L,638L,722L,758L,767L,513L,523L,568L,688L,898L,1150L,1360L,1480L,1525L,1535L,1025L };
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
public class A204207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204207Inst : IEnumerable<long>
{
public static readonly long[] Value=A204207.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204207.Bytes);
public long this[int i]=>Value[i];

public static A204207Inst Instance=new A204207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204208
{
public static readonly long[] Value={ 1L,4L,16L,78L,404L,2208L,12492L,72589L,430569L,2596471L,15870357L,98102191L,612222083L,3852015239L,24408653703L,155629858911L,997744376239L,6427757480074L,41590254520410L,270163621543421L,1761179219680657L };
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
public class A204208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204208Inst : IEnumerable<long>
{
public static readonly long[] Value=A204208.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204208.Bytes);
public long this[int i]=>Value[i];

public static A204208Inst Instance=new A204208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204209
{
public static readonly long[] Value={ 1L,5L,25L,155L,1025L,7167L,51945L,387000L,2944860L,22791189L,178840639L,1419569398L,11377983292L,91957314063L,748575327757L,6132254500856L,50514620902564L,418174191239443L,3477075679541185L,29026557341147912L,243184916545458556L };
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
public class A204209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204209Inst : IEnumerable<long>
{
public static readonly long[] Value=A204209.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204209.Bytes);
public long this[int i]=>Value[i];

public static A204209Inst Instance=new A204209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204210
{
public static readonly long[] Value={ 1L,6L,36L,271L,2181L,18583L,164255L,1493142L,13868334L,131040555L,1255641305L,12172468671L,119167633383L,1176491130191L,11699794149335L,117092364762013L,1178452895921961L,11919463485729722L,121096865173987004L };
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
public class A204210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204210Inst : IEnumerable<long>
{
public static readonly long[] Value=A204210.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204210.Bytes);
public long this[int i]=>Value[i];

public static A204210Inst Instance=new A204210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204211
{
public static readonly long[] Value={ 1L,7L,49L,434L,4116L,41363L,431445L,4629851L,50775347L,566592411L,6412416619L,73428973184L,849204106870L,9904511238159L,116368090860251L,1375981128400665L,16362074062371685L,195540534817518299L,2347344805869798781L };
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
public class A204211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204211Inst : IEnumerable<long>
{
public static readonly long[] Value=A204211.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204211.Bytes);
public long this[int i]=>Value[i];

public static A204211Inst Instance=new A204211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204212
{
public static readonly long[] Value={ 1L,8L,64L,652L,7120L,82440L,991152L,12262470L,155072356L,1995610260L,26048900628L,344054761656L,4589736845308L,61750810543324L,836935922008844L,11416462124627925L,156613134014878257L,2159264087976308543L };
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
public class A204212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204212Inst : IEnumerable<long>
{
public static readonly long[] Value=A204212.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204212.Bytes);
public long this[int i]=>Value[i];

public static A204212Inst Instance=new A204212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204213
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,9L,9L,1L,5L,16L,32L,21L,1L,6L,25L,78L,120L,51L,1L,7L,36L,155L,404L,473L,127L,1L,8L,49L,271L,1025L,2208L,1925L,323L,1L,9L,64L,434L,2181L,7167L,12492L,8034L,835L,1L,10L,81L,652L,4116L,18583L,51945L,72589L,34188L,2188L,1L,11L,100L,933L,7120L,41363L };
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
public class A204213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204213Inst : IEnumerable<long>
{
public static readonly long[] Value=A204213.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204213.Bytes);
public long this[int i]=>Value[i];

public static A204213Inst Instance=new A204213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204214
{
public static readonly long[] Value={ 21L,120L,404L,1025L,2181L,4116L,7120L,11529L,17725L,26136L,37236L,51545L,69629L,92100L,119616L,152881L,192645L,239704L,294900L,359121L,433301L,518420L,615504L,725625L,849901L,989496L,1145620L,1319529L,1512525L,1725956L,1961216L,2219745L };
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
public class A204214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204214Inst : IEnumerable<long>
{
public static readonly long[] Value=A204214.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204214.Bytes);
public long this[int i]=>Value[i];

public static A204214Inst Instance=new A204214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204215
{
public static readonly long[] Value={ 51L,473L,2208L,7167L,18583L,41363L,82440L,151125L,259459L,422565L,659000L,991107L,1445367L,2052751L,2849072L,3875337L,5178099L,6809809L,8829168L,11301479L,14298999L,17901291L,22195576L,27277085L,33249411L,40224861L,48324808L,57680043L };
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
public class A204215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204215Inst : IEnumerable<long>
{
public static readonly long[] Value=A204215.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204215.Bytes);
public long this[int i]=>Value[i];

public static A204215Inst Instance=new A204215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204216
{
public static readonly long[] Value={ 127L,1925L,12492L,51945L,164255L,431445L,991152L,2057553L,3945655L,7098949L,12120428L,19806969L,31187079L,47562005L,70550208L,102135201L,144716751L,201165445L,274880620L,369851657L,490722639L,642860373L,832425776L,1066448625L };
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
public class A204216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204216Inst : IEnumerable<long>
{
public static readonly long[] Value=A204216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204216.Bytes);
public long this[int i]=>Value[i];

public static A204216Inst Instance=new A204216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204217
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,4L,3L,1L,6L,5L,3L,4L,3L,5L,11L,1L,3L,8L,3L,6L,12L,5L,3L,4L,8L,5L,12L,8L,3L,13L,3L,1L,12L,5L,15L,12L,3L,5L,12L,6L,3L,15L,3L,9L,26L,5L,3L,4L,10L,10L,12L,9L,3L,17L,18L,8L,12L,5L,3L,17L,3L,5L,28L,1L,18L,19L,3L,9L,12L,17L,3L,13L,3L,5L,27L,9L,21L,20L,3L,6L,21L,5L,3L,19L,18L,5L,12L,12L,3L };
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
public class A204217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204217Inst : IEnumerable<long>
{
public static readonly long[] Value=A204217.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204217.Bytes);
public long this[int i]=>Value[i];

public static A204217Inst Instance=new A204217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204218
{
public static readonly long[] Value={ 1L,1L,2L,7L,22L,74L,271L,1012L,3858L,15046L,59579L,238825L,967873L,3958517L,16316594L,67716000L,282719162L,1186633647L,5004102122L,21192022233L,90089538788L,384305738731L,1644544501988L,7057705570877L,30368821119351L,130993073168419L,566297366630412L,2453269044761359L };
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
public class A204218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204218Inst : IEnumerable<long>
{
public static readonly long[] Value=A204218.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204218.Bytes);
public long this[int i]=>Value[i];

public static A204218Inst Instance=new A204218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204219
{
public static readonly long[] Value={ 2L,19L,59L,79L,89L,103L,109L,137L,139L,149L,157L,179L,191L,211L,239L,241L,271L,281L,293L,311L,317L,347L,367L,379L,389L,397L,401L,419L,439L,457L,467L,499L,523L,541L,547L,557L,563L,569L,587L,593L,607L,613L,641L,647L,659L,673L,719L,733L,743L,751L,761L,769L,787L,809L,811L,829L,859L,863L,877L,887L,919L,929L,971L,977L,983L,991L,997L };
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
public class A204219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204219Inst : IEnumerable<long>
{
public static readonly long[] Value=A204219.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204219.Bytes);
public long this[int i]=>Value[i];

public static A204219Inst Instance=new A204219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204220
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,-1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A204220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204220Inst : IEnumerable<long>
{
public static readonly long[] Value=A204220.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204220.Bytes);
public long this[int i]=>Value[i];

public static A204220Inst Instance=new A204220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204221
{
public static readonly long[] Value={ 0L,1L,8L,13L,17L,24L,45L,56L,64L,77L,112L,129L,141L,160L,209L,232L,248L,273L,336L,365L,385L,416L,493L,528L,552L,589L,680L,721L,749L,792L,897L,944L,976L,1025L,1144L,1197L,1233L,1288L,1421L,1480L,1520L,1581L,1728L,1793L,1837L,1904L,2065L,2136L,2184L,2257L,2432L };
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
public class A204221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204221Inst : IEnumerable<long>
{
public static readonly long[] Value=A204221.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204221.Bytes);
public long this[int i]=>Value[i];

public static A204221Inst Instance=new A204221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204222
{
public static readonly long[] Value={ 81L,4539L,752562L,129062037L,45791699846L,13629970952083L,7163822258608797L };
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
public class A204222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204222Inst : IEnumerable<long>
{
public static readonly long[] Value=A204222.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204222.Bytes);
public long this[int i]=>Value[i];

public static A204222Inst Instance=new A204222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204223
{
public static readonly long[] Value={ 81L,450L,2500L,11100L,49284L,192474L,751689L,2707641L,9753129L,33291180L,113635600L,373782240L,1229484096L,3940246872L,12627691129L,39725765841L,124974269289L,387960161310L,1204352604900L,3702976839180L,11385401099076L };
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
public class A204223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204223Inst : IEnumerable<long>
{
public static readonly long[] Value=A204223.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204223.Bytes);
public long this[int i]=>Value[i];

public static A204223Inst Instance=new A204223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204224
{
public static readonly long[] Value={ 450L,4539L,44641L,312001L,2173565L,12097076L,67329896L,320850651L,1529688095L,6522838147L,27826525857L,109309929157L,429561634288L,1586242394564L,5859703202568L,20639200392449L,72725001826184L,246982200868842L };
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
public class A204224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204224Inst : IEnumerable<long>
{
public static readonly long[] Value=A204224.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204224.Bytes);
public long this[int i]=>Value[i];

public static A204224Inst Instance=new A204224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204225
{
public static readonly long[] Value={ 2500L,44641L,752562L,8183170L,87487117L,694547816L,5466340007L,34834605810L,220710753856L,1196535903414L,6459574647599L,30967790434185L,148001428352179L,644776741493252L,2802681689033511L,11319015179680230L,45642521943090129L };
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
public class A204225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204225Inst : IEnumerable<long>
{
public static readonly long[] Value=A204225.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204225.Bytes);
public long this[int i]=>Value[i];

public static A204225Inst Instance=new A204225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204226
{
public static readonly long[] Value={ 11100L,312001L,8183170L,129062037L,2019310610L,21958547501L,239090847020L,1998393334223L,16732354210738L,114864924928762L,789227515822757L,4651328406696920L,27416959362534398L,143142975020535966L };
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
public class A204226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204226Inst : IEnumerable<long>
{
public static readonly long[] Value=A204226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204226.Bytes);
public long this[int i]=>Value[i];

public static A204226Inst Instance=new A204226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204227
{
public static readonly long[] Value={ 49284L,2173565L,87487117L,2019310610L,45791699846L,687853333430L,10297878073062L,113754005579615L,1254605391285859L,10988697166912314L,96030748646457765L,701414832964037835L,5107498255064984418L };
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
public class A204227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204227Inst : IEnumerable<long>
{
public static readonly long[] Value=A204227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204227.Bytes);
public long this[int i]=>Value[i];

public static A204227Inst Instance=new A204227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204228
{
public static readonly BigInteger[] Value={ 192474L,12097076L,694547816L,21958547501L,687853333430L,13629970952083L,271354063234561L,3835838251329000L,54453189904564756L,595162305293032209L,6513931380725003539L,BigInteger.Parse("58108694636514434194"),BigInteger.Parse("517777689314797178275") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204228Inst Instance=new A204228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204229
{
public static readonly long[] Value={ 751689L,67329896L,5466340007L,239090847020L,10297878073062L,271354063234561L,7163822258608797L,130426974499112184L };
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
public class A204229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204229Inst : IEnumerable<long>
{
public static readonly long[] Value=A204229.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204229.Bytes);
public long this[int i]=>Value[i];

public static A204229Inst Instance=new A204229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204230
{
public static readonly long[] Value={ 81L,450L,450L,2500L,4539L,2500L,11100L,44641L,44641L,11100L,49284L,312001L,752562L,312001L,49284L,192474L,2173565L,8183170L,8183170L,2173565L,192474L,751689L,12097076L,87487117L,129062037L,87487117L,12097076L,751689L,2707641L,67329896L };
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
public class A204230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204230Inst : IEnumerable<long>
{
public static readonly long[] Value=A204230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204230.Bytes);
public long this[int i]=>Value[i];

public static A204230Inst Instance=new A204230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204231
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,12L,13L,14L,19L,23L,27L,33L,37L,41L,42L,44L,49L,59L,61L,69L,72L,76L,83L,88L,89L,111L,121L,126L,127L,134L,137L,143L,144L,146L,149L,159L,163L,170L,177L,178L,186L,189L,195L,197L,198L,204L,208L,214L,217L,220L,224L,228L,233L,234L,236L,243L,247L,248L,249L,276L,278L,288L,294L,295L,335L,338L,353L,354L,380L,382L,384L,395L,401L,402L,408L,411L,427L };
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
public class A204231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204231Inst : IEnumerable<long>
{
public static readonly long[] Value=A204231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204231.Bytes);
public long this[int i]=>Value[i];

public static A204231Inst Instance=new A204231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204232
{
public static readonly long[] Value={ 3L,5L,6L,7L,10L,11L,12L,13L,14L,17L,20L,22L,23L,24L,25L,26L,28L,29L,31L,34L,37L,40L,41L,43L,44L,46L,47L,48L,50L,52L,53L,55L,56L,58L,61L,62L,67L,68L,71L,73L,74L,77L,80L,82L,83L,86L,88L,91L,92L,94L,96L,97L,100L,101L,104L,106L,107L,110L,112L,113L,115L,116L,121L };
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
public class A204232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204232Inst : IEnumerable<long>
{
public static readonly long[] Value=A204232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204232.Bytes);
public long this[int i]=>Value[i];

public static A204232Inst Instance=new A204232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204233
{
public static readonly BigInteger[] Value={ 0L,1L,4L,49L,792L,18953L,610796L,25648641L,1359184384L,88722005809L,6994262098260L,655126226755025L,71915748374032232L,9144536677714434105L,BigInteger.Parse("1333394182537641307324"),BigInteger.Parse("221002933797466121742433") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204233Inst Instance=new A204233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204234
{
public static readonly BigInteger[] Value={ 1L,2L,25L,1018L,97617L,18239786L,5881589105L,3009156161810L,2296768410595849L,2494959953768765810L,BigInteger.Parse("3716590842220109346457"),BigInteger.Parse("7367123790912343973015562"),BigInteger.Parse("18955419073428722394855382209"),BigInteger.Parse("61999496577719659890376379418138"),BigInteger.Parse("253245883804141341597229595842097313") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204234Inst Instance=new A204234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204235
{
public static readonly BigInteger[] Value={ 1L,5L,42L,632L,14124L,449652L,19200336L,1063272704L,74068997888L,6344884818304L,655635015988864L,80447681129070080L,11565193558509497088UL,BigInteger.Parse("1925787312858332101888") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204235Inst Instance=new A204235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204236
{
public static readonly BigInteger[] Value={ 1L,11L,219L,8353L,501441L,43953387L,5289422019L,837277689897L,168675250704201L,42143281220724723L,12789052583333211963UL,BigInteger.Parse("4633606346714879986017"),BigInteger.Parse("1975686665736618600155505"),BigInteger.Parse("979311369588813584600206491") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204236Inst Instance=new A204236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204237
{
public static readonly long[] Value={ 2L,5L,5L,8L,4L,8L,11L,7L,7L,11L,14L,10L,6L,10L,14L,17L,13L,9L,9L,13L,17L,20L,16L,12L,8L,12L,16L,20L,23L,19L,15L,11L,11L,15L,19L,23L,26L,22L,18L,14L,10L,14L,18L,22L,26L,29L,25L,21L,17L,13L,13L,17L,21L,25L,29L,32L,28L,24L,20L,16L,12L,16L,20L,24L,28L,32L,35L,31L,27L,23L };
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
public class A204237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204237Inst : IEnumerable<long>
{
public static readonly long[] Value=A204237.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204237.Bytes);
public long this[int i]=>Value[i];

public static A204237Inst Instance=new A204237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204238
{
public static readonly long[] Value={ 2L,-17L,104L,-560L,2816L,-13568L,63488L,-290816L,1310720L,-5832704L,25690112L,-112197632L,486539264L,-2097152000L,8992587776L,-38386270208L,163208757248L,-691489734656L,2920577761280L,-12300786335744L,51677046505472L,-216603790671872L,905997581287424L };
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
public class A204238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204238Inst : IEnumerable<long>
{
public static readonly long[] Value=A204238.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204238.Bytes);
public long this[int i]=>Value[i];

public static A204238Inst Instance=new A204238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204239
{
public static readonly BigInteger[] Value={ 2L,33L,1112L,69908L,6960472L,1010678724L,201542214592L,52862893123648L,17646889124736128L,7306075691359891008L,BigInteger.Parse("3673978840975236778496"),BigInteger.Parse("2205779786212911066883328"),BigInteger.Parse("1558502652244224074264296960") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204239Inst Instance=new A204239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204240
{
public static readonly long[] Value={ 1L,-14L,115L,-800L,5125L,-31250L,184375L,-1062500L,6015625L,-33593750L,185546875L,-1015625000L,5517578125L,-29785156250L,159912109375L,-854492187500L,4547119140625L,-24108886718750L,127410888671875L,-671386718750000L };
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
public class A204240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204240Inst : IEnumerable<long>
{
public static readonly long[] Value=A204240.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204240.Bytes);
public long this[int i]=>Value[i];

public static A204240Inst Instance=new A204240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204241
{
public static readonly BigInteger[] Value={ 1L,18L,457L,23672L,1894385L,222366990L,35787014405L,7577453436556L,2041650829418725L,682219727134076250L,BigInteger.Parse("276875111860035807025"),BigInteger.Parse("134154122874807259146080"),BigInteger.Parse("76495123111877275062902585"),BigInteger.Parse("50706144718387731766299555750") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204241Inst Instance=new A204241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204242
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,0L,0L,1L,1L,0L,7L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,15L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,31L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,63L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,127L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L };
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
public class A204242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204242Inst : IEnumerable<long>
{
public static readonly long[] Value=A204242.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204242.Bytes);
public long this[int i]=>Value[i];

public static A204242Inst Instance=new A204242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204243
{
public static readonly BigInteger[] Value={ 1L,2L,11L,144L,4149L,251622L,31340799L,7913773980L,4024015413705L,4106387069191890L,8395359475529822355L,BigInteger.Parse("34357677843892688699400"),BigInteger.Parse("281336437060919094044274525"),BigInteger.Parse("4608419756389534634440592965950"),BigInteger.Parse("150992374805715685629827976712244775") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204243Inst Instance=new A204243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204244
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,0L,0L,1L,1L,0L,6L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,24L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,120L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,720L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,5040L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L };
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
public class A204244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204244Inst : IEnumerable<long>
{
public static readonly long[] Value=A204244.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204244.Bytes);
public long this[int i]=>Value[i];

public static A204244Inst Instance=new A204244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204245
{
public static readonly BigInteger[] Value={ 1L,1L,4L,84L,9792L,7015680L,35334144000L,1424547274752000L,BigInteger.Parse("516934658477260800000"),BigInteger.Parse("1875850653748811739955200000"),BigInteger.Parse("74877948716953984356707205120000000"),BigInteger.Parse("35866656974348638336845775173058560000000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204245Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204245.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204245Inst Instance=new A204245Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204246
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,6L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,24L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,120L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,720L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A204246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204246Inst : IEnumerable<long>
{
public static readonly long[] Value=A204246.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204246.Bytes);
public long this[int i]=>Value[i];

public static A204246Inst Instance=new A204246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204247
{
public static readonly BigInteger[] Value={ 1L,0L,-1L,-8L,-204L,-24768L,-17867520L,-90077184000L,-3632037470208000L,BigInteger.Parse("-1317998813773824000000"),BigInteger.Parse("-4782755930355924782284800000"),BigInteger.Parse("-190912318579437962454242426880000000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204247Inst Instance=new A204247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204248
{
public static readonly BigInteger[] Value={ 1L,7L,126L,4276L,234300L,18877020L,2100159600L,308417610816L,57786899446080L,13452134426136000L,3808606484711952000L,BigInteger.Parse("1288711254432792833280"),BigInteger.Parse("513583129024901529834240"),BigInteger.Parse("238093035025913233419052800"),BigInteger.Parse("127039392937347095305900800000"),BigInteger.Parse("77298350216325487808699492352000"),BigInteger.Parse("53201355385962541032225805510656000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204248Inst Instance=new A204248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204249
{
public static readonly BigInteger[] Value={ 1L,2L,17L,336L,12052L,685080L,56658660L,6428352000L,958532774976L,181800011433600L,42745508545320000L,12203347213269273600UL,BigInteger.Parse("4158410247782904833280"),BigInteger.Parse("1667267950805177583582720"),BigInteger.Parse("776990110000329481864608000"),BigInteger.Parse("416483579190482716042690560000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204249Inst Instance=new A204249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204250
{
public static readonly long[] Value={ 1L,3L,3L,5L,6L,5L,7L,9L,9L,7L,9L,12L,13L,12L,9L,11L,15L,17L,17L,15L,11L,13L,18L,21L,22L,21L,18L,13L,15L,21L,25L,27L,27L,25L,21L,15L,17L,24L,29L,32L,33L,32L,29L,24L,17L,19L,27L,33L,37L,39L,39L,37L,33L,27L,19L,21L,30L,37L,42L,45L,46L,45L,42L,37L,30L,21L,23L,33L,41L,47L };
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
public class A204250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204250Inst : IEnumerable<long>
{
public static readonly long[] Value=A204250.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204250.Bytes);
public long this[int i]=>Value[i];

public static A204250Inst Instance=new A204250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204251
{
public static readonly BigInteger[] Value={ 1L,15L,696L,70380L,13028148L,3964560012L,1842113636352L,1238025608824896L,1154488823507833920L,BigInteger.Parse("1445382306218202517440"),BigInteger.Parse("2365159362652507207703040"),BigInteger.Parse("4947087474421921107685036800"),BigInteger.Parse("12980259416603230936506795674880") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204251Inst Instance=new A204251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204252
{
public static readonly BigInteger[] Value={ 1L,5L,18L,132L,876L,8820L,85392L,1106496L,14057280L,223560000L,3513456000L,66305952000L,1241430624000L,27127003680000L,589395356928000L,14638710417408000L,362021985626112000L,10073602372700160000UL,BigInteger.Parse("279369787588448256000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204252Inst Instance=new A204252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204253
{
public static readonly long[] Value={ 3L,1L,1L,2L,2L,2L,3L,3L,3L,3L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L };
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
public class A204253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204253Inst : IEnumerable<long>
{
public static readonly long[] Value=A204253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204253.Bytes);
public long this[int i]=>Value[i];

public static A204253Inst Instance=new A204253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204254
{
public static readonly BigInteger[] Value={ 3L,7L,54L,466L,3732L,50928L,748224L,10421856L,204446592L,4232598624L,84204904320L,2154137877504L,57534363970560L,1488803964595200L,46983956781312000L,1536963329488896000L,BigInteger.Parse("48976637440702464000"),BigInteger.Parse("1838658764187353088000") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204254Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204254.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204254Inst Instance=new A204254Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204255
{
public static readonly long[] Value={ 3L,4L,4L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L };
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
public class A204255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204255Inst : IEnumerable<long>
{
public static readonly long[] Value=A204255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A204255.Bytes);
public long this[int i]=>Value[i];

public static A204255Inst Instance=new A204255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A204256
{
public static readonly BigInteger[] Value={ 3L,19L,86L,1060L,13276L,215308L,3086544L,68937280L,1552257216L,40750688448L,987692033664L,31883024335104L,1036810188322560L,37597332892066560L,1285416947916933120L,BigInteger.Parse("54309158991453634560"),BigInteger.Parse("2309262618253981040640") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A204256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A204256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A204256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A204256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A204256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A204256Inst Instance=new A204256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}