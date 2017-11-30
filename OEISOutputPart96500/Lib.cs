using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A117179
{
public static readonly long[] Value={ 1L,0L,1L,-3L,0L,1L,0L,-4L,0L,1L,5L,0L,-5L,0L,1L,0L,9L,0L,-6L,0L,1L,-7L,0L,14L,0L,-7L,0L,1L,0L,-16L,0L,20L,0L,-8L,0L,1L,9L,0L,-30L,0L,27L,0L,-9L,0L,1L,0L,25L,0L,-50L,0L,35L,0L,-10L,0L,1L,-11L,0L,55L,0L,-77L,0L,44L,0L,-11L,0L,1L };
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
public class A117179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117179Inst : IEnumerable<long>
{
public static readonly long[] Value=A117179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117179.Bytes);
public long this[int i]=>Value[i];

public static A117179Inst Instance=new A117179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117180
{
public static readonly long[] Value={ 4L,8L,9L,3L,16L,2L,4L,3L,25L,27L,4L,32L,4L,5L,4L,5L,3L,49L,2L,4L,2L,7L,3L,7L,64L,4L,8L,3L,4L,5L,81L,3L,8L,2L,4L,3L,2L,9L,4L,8L,4L,7L,4L,9L,3L,121L,4L,125L,2L,128L,3L,5L,8L,4L,9L,3L,4L,2L,8L,9L,3L,5L,2L,4L,3L,169L,9L,4L,7L,11L,4L,8L,4L,7L,3L,4L,2L,8L,3L,9L,13L,4L,8L,4L,7L,9L,3L,8L,2L,4L,3L,2L,243L,4L,5L,8L };
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
public class A117180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117180Inst : IEnumerable<long>
{
public static readonly long[] Value=A117180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117180.Bytes);
public long this[int i]=>Value[i];

public static A117180Inst Instance=new A117180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117181
{
public static readonly long[] Value={ 4L,8L,9L,4L,16L,9L,5L,8L,25L,27L,7L,32L,9L,8L,11L,9L,16L,49L,25L,13L,27L,8L,5L,9L,64L,17L,9L,25L,19L,16L,81L,7L,11L,9L,23L,32L,49L,11L,25L,13L,27L,16L,29L,13L,8L,121L,31L,125L,9L,128L,11L,27L,17L,7L,16L,49L,37L,25L,19L,17L,13L,32L,81L,41L,8L,169L,19L,43L,25L,16L,9L,23L,47L,27L,64L,49L };
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
public class A117181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117181Inst : IEnumerable<long>
{
public static readonly long[] Value=A117181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117181.Bytes);
public long this[int i]=>Value[i];

public static A117181Inst Instance=new A117181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117182
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,7L,1L,5L,0L,0L,3L,0L,5L,3L,7L,4L,13L,0L,23L,9L,25L,1L,2L,2L,0L,13L,1L,22L,15L,11L,0L,4L,3L,7L,19L,29L,47L,2L,21L,5L,23L,9L,25L,4L,5L,0L,27L,0L,7L,0L,8L,22L,9L,3L,7L,46L,33L,23L,11L,8L,10L,27L,79L,37L,5L,0L,10L,39L,18L,5L,5L,15L,43L,20L,61L,45L,9L,17L,14L,14L,3L,49L,19L,7L,25L,16L,16L };
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
public class A117182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117182Inst : IEnumerable<long>
{
public static readonly long[] Value=A117182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117182.Bytes);
public long this[int i]=>Value[i];

public static A117182Inst Instance=new A117182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117183
{
public static readonly long[] Value={ 2L,2L,3L,2L,2L,2L,2L,2L,5L,3L,2L,2L,2L,2L,2L,3L,2L,7L,2L,2L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,11L,2L,5L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,2L,13L,3L,2L,5L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,5L,2L,2L,2L,2L,2L,3L,2L,2L,2L };
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
public class A117183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117183Inst : IEnumerable<long>
{
public static readonly long[] Value=A117183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117183.Bytes);
public long this[int i]=>Value[i];

public static A117183Inst Instance=new A117183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117184
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,3L,4L,1L,1L,10L,4L,5L,1L,1L,10L,15L,5L,6L,1L,1L,35L,15L,21L,6L,7L,1L,1L,35L,56L,21L,28L,7L,8L,1L,1L,126L,56L,84L,28L,36L,8L,9L,1L,1L,126L,210L,84L,120L,36L,45L,9L,10L,1L,1L,462L,210L,330L,120L,165L,45L,55L,10L,11L,1L,1L };
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
public class A117184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117184Inst : IEnumerable<long>
{
public static readonly long[] Value=A117184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117184.Bytes);
public long this[int i]=>Value[i];

public static A117184Inst Instance=new A117184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117185
{
public static readonly long[] Value={ 1L,-1L,1L,-2L,-1L,1L,3L,-3L,-1L,1L,1L,4L,-4L,-1L,1L,-4L,4L,5L,-5L,-1L,1L,1L,-8L,8L,6L,-6L,-1L,1L,3L,-3L,-13L,13L,7L,-7L,-1L,1L,-2L,11L,-11L,-19L,19L,8L,-8L,-1L,1L,-1L,1L,24L,-24L,-26L,26L,9L,-9L,-1L,1L,1L,-12L,12L,43L,-43L,-34L,34L,10L,-10L,-1L,1L };
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
public class A117185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117185Inst : IEnumerable<long>
{
public static readonly long[] Value=A117185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117185.Bytes);
public long this[int i]=>Value[i];

public static A117185Inst Instance=new A117185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117186
{
public static readonly long[] Value={ 1L,2L,5L,9L,21L,38L,86L,157L,349L,642L,1410L,2610L,5682L,10572L,22860L,42717L,91869L,172298L,368906L,694054L,1480486L,2793012L,5938740L,11230834L,23813746L,45131348L,95462996L,181268292L,382594884L,727747608L,1533053976L };
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
public class A117186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117186Inst : IEnumerable<long>
{
public static readonly long[] Value=A117186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117186.Bytes);
public long this[int i]=>Value[i];

public static A117186Inst Instance=new A117186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117187
{
public static readonly long[] Value={ 1L,1L,4L,4L,15L,15L,56L,56L,210L,210L,792L,792L,3003L,3003L,11440L,11440L,43758L,43758L,167960L,167960L,646646L,646646L,2496144L,2496144L,9657700L,9657700L,37442160L,37442160L,145422675L,145422675L,565722720L };
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
public class A117187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117187Inst : IEnumerable<long>
{
public static readonly long[] Value=A117187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117187.Bytes);
public long this[int i]=>Value[i];

public static A117187Inst Instance=new A117187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117188
{
public static readonly long[] Value={ 1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L,1L,0L,1L,0L,-2L,0L };
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
public class A117188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117188Inst : IEnumerable<long>
{
public static readonly long[] Value=A117188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117188.Bytes);
public long this[int i]=>Value[i];

public static A117188Inst Instance=new A117188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117189
{
public static readonly long[] Value={ 1L,2L,5L,14L,40L,114L,324L,920L,2612L,7416L,21056L,59784L,169744L,481952L,1368400L,3885280L,11031424L,31321376L,88930368L,252498816L,716916544L,2035531648L,5779458048L,16409538688L,46591385856L,132286304768L,375598753024L,1066432564736L,3027907856384L };
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
public class A117189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117189Inst : IEnumerable<long>
{
public static readonly long[] Value=A117189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117189.Bytes);
public long this[int i]=>Value[i];

public static A117189Inst Instance=new A117189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117190
{
public static readonly long[] Value={ 1L,1L,1L,-3L,7L,3L,3L,-9L,7L,7L,19L,3L,-11L,-29L,-27L,-11L,61L,-3L,3L,-39L,-11L,-101L,9L,-23L,7L,13L,67L,-99L,-209L,-27L,-11L,-27L,-21L,-9L,193L,-23L,67L,43L,-59L,3L,-17L,109L,63L,57L,31L,-9L,-33L,33L,-33L,9L,-57L,121L,-231L,171L,31L,21L,3L,-93L,-149L,19L,7L,-39L,-83L,121L,-51L,49L,49L,49L,99L,9L,33L,-53L,39L,79L,-47L,129L,133L };
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
public class A117190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117190Inst : IEnumerable<long>
{
public static readonly long[] Value=A117190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117190.Bytes);
public long this[int i]=>Value[i];

public static A117190Inst Instance=new A117190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117191
{
public static readonly long[] Value={ 1L,5L,5L,4L,6L,8L,2L,2L,7L,5L,4L,8L,2L,1L,0L,0L,0L,8L,9L,8L,7L,0L,2L,3L,2L,0L,8L,0L,7L,8L,2L,8L,0L,4L,0L,0L,2L,0L,6L,0L,4L,4L,7L,3L,0L,6L,2L,6L,5L,6L,6L,1L,3L,7L,9L,0L,9L,8L,9L,2L,0L,2L,0L,4L,3L,3L,2L,8L,7L,7L,9L,4L,1L,5L,2L,9L,3L,2L,8L,0L,5L,3L,6L,5L,1L,1L,3L,9L,7L,6L,3L,8L,2L,3L,1L,8L,7L,4L,8L,9L,3L,6L,3L,0L,5L };
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
public class A117191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117191Inst : IEnumerable<long>
{
public static readonly long[] Value=A117191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117191.Bytes);
public long this[int i]=>Value[i];

public static A117191Inst Instance=new A117191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117192
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,2L,3L,2L,4L,6L,6L,7L,8L,12L,14L,16L,18L,24L,26L,32L,38L,46L,52L,60L,70L,83L,96L,112L,128L,148L,170L,194L,224L,256L,293L,334L,380L,432L,492L,556L,630L,712L,804L,908L,1026L,1152L,1296L,1454L,1632L,1828L,2048L,2292L,2560L,2858L,3190L,3554L,3959L,4404L };
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
public class A117192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117192Inst : IEnumerable<long>
{
public static readonly long[] Value=A117192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117192.Bytes);
public long this[int i]=>Value[i];

public static A117192Inst Instance=new A117192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117193
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,2L,4L,4L,4L,6L,8L,10L,10L,13L,16L,20L,22L,28L,32L,38L,43L,52L,62L,72L,82L,96L,110L,128L,148L,170L,196L,224L,256L,292L,334L,380L,432L,490L,557L,630L,714L,806L,908L,1022L,1152L,1294L,1456L,1632L,1830L,2049L,2290L,2560L,2860L,3188L,3554L,3958L,4404L };
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
public class A117193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117193Inst : IEnumerable<long>
{
public static readonly long[] Value=A117193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117193.Bytes);
public long this[int i]=>Value[i];

public static A117193Inst Instance=new A117193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117194
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,2L,4L,5L,6L,7L,8L,12L,13L,16L,18L,24L,26L,32L,37L,46L,52L,60L,70L,83L,96L,111L,128L,148L,170L,194L,224L,256L,293L,333L,380L,432L,492L,556L,630L,712L,804L,908L,1025L,1152L,1296L,1454L,1632L,1828L,2048L,2292L,2560L,2858L,3189L,3554L,3959L,4404L };
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
public class A117194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117194Inst : IEnumerable<long>
{
public static readonly long[] Value=A117194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117194.Bytes);
public long this[int i]=>Value[i];

public static A117194Inst Instance=new A117194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117195
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,2L,1L,1L,1L,0L,1L,1L,0L,2L,1L,2L,1L,1L,1L,0L,1L,0L,1L,1L,2L,2L,2L,1L,1L,1L,0L,1L,0L,1L,2L,2L,2L,2L,2L,1L,1L,1L,0L,1L,0L,1L,1L,3L,2L,3L,2L,2L,1L,1L,1L,0L,1L,0L,1L,2L,2L,4L,2L,3L,2L,2L,1L,1L,1L,0L,1L };
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
public class A117195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117195Inst : IEnumerable<long>
{
public static readonly long[] Value=A117195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117195.Bytes);
public long this[int i]=>Value[i];

public static A117195Inst Instance=new A117195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117196
{
public static readonly long[] Value={ 2L,11L,19L,23L,71L,863L,3989L };
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
public class A117196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117196Inst : IEnumerable<long>
{
public static readonly long[] Value=A117196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117196.Bytes);
public long this[int i]=>Value[i];

public static A117196Inst Instance=new A117196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117197
{
public static readonly long[] Value={ 0L,343L,17576L,250047L,1906624L,9938375L,40001688L,133432831L,385828352L,997002999L,2352637000L,5150827583L,10590025536L,20638466407L,38409197624L,68669157375L,118515478528L,198257271191L,322546580712L,511808023999L };
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
public class A117197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117197Inst : IEnumerable<long>
{
public static readonly long[] Value=A117197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117197.Bytes);
public long this[int i]=>Value[i];

public static A117197Inst Instance=new A117197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117198
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L };
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
public class A117198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117198Inst : IEnumerable<long>
{
public static readonly long[] Value=A117198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117198.Bytes);
public long this[int i]=>Value[i];

public static A117198Inst Instance=new A117198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117199
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L,0L,3L,0L,1L,1L,2L,0L,2L,0L,2L,1L,1L };
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
public class A117199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117199Inst : IEnumerable<long>
{
public static readonly long[] Value=A117199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117199.Bytes);
public long this[int i]=>Value[i];

public static A117199Inst Instance=new A117199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117200
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,0L,1L,1L,-1L,0L,1L,0L,0L,0L,0L,1L,2L,-1L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,-1L,1L,0L,-1L,0L,0L,0L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-3L,2L,1L,-1L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L };
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
public class A117200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117200Inst : IEnumerable<long>
{
public static readonly long[] Value=A117200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117200.Bytes);
public long this[int i]=>Value[i];

public static A117200Inst Instance=new A117200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117201
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,-1L,1L,0L,0L,1L,1L,-1L,1L,1L,0L,0L,1L,2L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,3L,1L,0L,0L,0L,1L,1L,1L,1L,1L,0L,1L,-2L,1L,0L,0L,1L,1L,2L,1L,0L,0L,0L,1L,-1L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,1L,-4L,1L,0L,0L,1L,1L,1L,1L,1L,1L };
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
public class A117201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117201Inst : IEnumerable<long>
{
public static readonly long[] Value=A117201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117201.Bytes);
public long this[int i]=>Value[i];

public static A117201Inst Instance=new A117201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117202
{
public static readonly long[] Value={ 0L,1L,4L,15L,52L,170L,534L,1631L,4880L,14373L,41810L,120406L,343884L,975325L,2749852L,7713435L,21540304L,59917826L,166094370L,458998523L,1264919720L,3477182961L,9536877614L,26102772910L,71309161752L,194468551225L,529490287924L };
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
public class A117202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117202Inst : IEnumerable<long>
{
public static readonly long[] Value=A117202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117202.Bytes);
public long this[int i]=>Value[i];

public static A117202Inst Instance=new A117202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117203
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,15L,21L,23L,29L,31L,35L,39L,43L,47L,53L,59L,61L,67L,69L,71L,77L,79L,83L,85L,87L,93L,95L,103L,107L,111L,115L,119L,123L,131L,133L,139L,141L,143L,149L,155L,157L,159L,165L,167L,173L,179L,183L,187L,191L,195L,203L,205L,211L,213L,215L,219L,221L,223L,227L };
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
public class A117203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117203Inst : IEnumerable<long>
{
public static readonly long[] Value=A117203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117203.Bytes);
public long this[int i]=>Value[i];

public static A117203Inst Instance=new A117203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117204
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,10L,11L,14L,15L,17L,19L,21L,23L,26L,29L,30L,33L,34L,35L,38L,39L,41L,42L,43L,46L,47L,51L,53L,55L,57L,59L,61L,65L,66L,69L,70L,71L,74L,77L,78L,79L,82L,83L,86L,89L,91L,93L };
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
public class A117204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117204Inst : IEnumerable<long>
{
public static readonly long[] Value=A117204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117204.Bytes);
public long this[int i]=>Value[i];

public static A117204Inst Instance=new A117204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117205
{
public static readonly long[] Value={ 1L,3L,5L,11L,13L,19L,21L,29L,33L,37L,41L,43L,51L,57L,59L,61L,65L,67L,69L,73L,77L,83L,85L,91L,93L,101L,105L,109L,113L,115L,123L,129L,131L,133L,137L,139L,141L,145L,155L,157L,163L,165L,173L,177L,181L,185L,187L,193L,201L,203L,205L,209L,211L,213L,217L,219L,221L,227L,229L };
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
public class A117205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117205Inst : IEnumerable<long>
{
public static readonly long[] Value=A117205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117205.Bytes);
public long this[int i]=>Value[i];

public static A117205Inst Instance=new A117205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117206
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,10L,11L,15L,17L,19L,21L,22L,26L,29L,30L,31L,33L,34L,35L,37L,39L,42L,43L,46L,47L,51L,53L,55L,57L,58L,62L,65L,66L,67L,69L,70L,71L,73L,78L,79L,82L,83L,87L,89L,91L,93L,94L,97L,101L,102L,103L,105L,106L,107L,109L,110L,111L,114L,115L,118L,119L,127L,129L,130L,133L };
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
public class A117206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117206Inst : IEnumerable<long>
{
public static readonly long[] Value=A117206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117206.Bytes);
public long this[int i]=>Value[i];

public static A117206Inst Instance=new A117206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117207
{
public static readonly long[] Value={ 1L,3L,1L,10L,7L,1L,35L,31L,13L,1L,126L,121L,81L,21L,1L,462L,456L,381L,181L,31L,1L,1716L,1709L,1583L,1058L,358L,43L,1L,6435L,6427L,6231L,5055L,2605L,645L,57L,1L,24310L,24301L,24013L,21661L,14605L,5785L,1081L,73L,1L,92378L,92368L,91963L,87643L,70003L,38251L,11791L };
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
public class A117207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117207Inst : IEnumerable<long>
{
public static readonly long[] Value=A117207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117207.Bytes);
public long this[int i]=>Value[i];

public static A117207Inst Instance=new A117207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117208
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,-1L,2L,-1L,1L,0L,1L,0L,1L,0L,0L,2L,-1L,2L,0L,1L,0L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,1L,0L,2L,0L,3L,0L,0L,2L,0L,3L,0L,3L,-1L,2L,0L,4L,1L,1L,3L,-3L,5L,1L,3L,0L,2L,-1L,2L,4L,2L,4L,-5L,6L,-1L,2L,7L,-2L,1L,-1L,4L,3L,5L,2L,-2L,1L,1L,8L,2L,4L,-1L,-3L,4L,9L,4L,-2L,4L,-7L,6L,7L,10L,-1L,-3L,-1L,1L,11L,4L,8L,-15L,2L,5L,7L,13L,1L,-9L,-7L,9L };
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
public class A117208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117208Inst : IEnumerable<long>
{
public static readonly long[] Value=A117208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117208.Bytes);
public long this[int i]=>Value[i];

public static A117208Inst Instance=new A117208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117209
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,1L,2L,-1L,-1L,-2L,0L,1L,3L,-1L,0L,-1L,1L,-1L,1L,-3L,1L,-1L,1L,-2L,3L,0L,6L,-1L,-1L,-6L,2L,-4L,4L,-3L,2L,-4L,6L,-5L,6L,-2L,7L,-5L,4L,-13L,5L,-3L,11L,-6L,8L,-14L,10L,-6L,9L,-14L,11L,-14L,15L,-13L,9L,-15L,24L,-13L,19L,-21L,12L,-20L,27L,-24L,21L,-26L,22L,-24L,33L,-33L,32L,-26L };
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
public class A117209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117209Inst : IEnumerable<long>
{
public static readonly long[] Value=A117209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117209.Bytes);
public long this[int i]=>Value[i];

public static A117209Inst Instance=new A117209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117210
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,0L,1L,1L,0L,-1L,-1L,2L,1L,-2L,-3L,2L,4L,2L,-5L,-4L,0L,5L,2L,1L,-5L,-1L,2L,5L,-5L,-2L,-2L,5L,-1L,3L,-6L,2L,0L,11L,-6L,-4L,-10L,12L,-1L,6L,-13L,5L,-8L,16L,-8L,9L,-13L,17L,-17L,7L,-21L,25L,-10L,22L,-29L,20L,-24L,34L,-24L,27L,-44L,35L,-32L,39L,-52L,45L,-39L,66L,-53L,47L,-76L,70L,-55L,79L,-98L,66L,-84L,115L,-89L };
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
public class A117210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117210Inst : IEnumerable<long>
{
public static readonly long[] Value=A117210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117210.Bytes);
public long this[int i]=>Value[i];

public static A117210Inst Instance=new A117210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117211
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,1L,1L,-2L,4L,-4L,4L,-3L,2L,0L,-1L,2L,-3L,4L,-5L,5L,-4L,4L,-3L,1L,1L,-2L,3L,-5L,5L,-5L,3L,-1L,1L,3L,-4L,3L,-2L,2L,-1L,-3L,4L,-6L,4L,-4L,5L,0L,-4L,2L,-1L,4L,-2L,3L,-3L,6L,-9L,7L,-1L,1L,-4L,-8L,10L,-6L,10L,-11L,12L,-9L,-4L,7L,-7L,15L,-25L,10L,-5L,13L,1L,-6L,16L,-21L,14L,-15L,28L,-6L,-12L,-3L,1L,18L,-18L,17L,-25L,13L };
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
public class A117211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117211Inst : IEnumerable<long>
{
public static readonly long[] Value=A117211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117211.Bytes);
public long this[int i]=>Value[i];

public static A117211Inst Instance=new A117211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117212
{
public static readonly long[] Value={ 1L,-3L,-2L,1L,-4L,6L,-6L,1L,-2L,12L,-10L,-2L,-12L,18L,8L,1L,-16L,6L,-18L,-4L,12L,30L,-22L,-2L,-4L,36L,-2L,-6L,-28L,-24L,-30L,1L,20L,48L,24L,-2L,-36L,54L,24L,-4L,-40L,-36L,-42L,-10L,8L,66L,-46L,-2L,-6L,12L,32L,-12L,-52L,6L,40L,-6L,36L,84L,-58L,8L,-60L,90L,12L,1L,48L,-60L,-66L,-16L,44L,-72L,-70L,-2L,-72L,108L,8L,-18L };
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
public class A117212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117212Inst : IEnumerable<long>
{
public static readonly long[] Value=A117212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117212.Bytes);
public long this[int i]=>Value[i];

public static A117212Inst Instance=new A117212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117213
{
public static readonly long[] Value={ 1L,2L,6L,30L,6L,210L,30L,2310L,30030L,210L,30L,510510L,9699690L,210L,2310L,223092870L,30030L,6469693230L,30L,200560490130L,2310L,510510L,210L,7420738134810L,9699690L,30030L,304250263527210L,210L,13082761331670030L,223092870L };
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
public class A117213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117213Inst : IEnumerable<long>
{
public static readonly long[] Value=A117213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117213.Bytes);
public long this[int i]=>Value[i];

public static A117213Inst Instance=new A117213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117214
{
public static readonly long[] Value={ 1L,1L,2L,6L,1L,30L,3L,210L,2310L,15L,2L,30030L,510510L,10L,105L,9699690L,1155L,223092870L,1L,6469693230L,70L,15015L,6L,200560490130L,255255L,770L,7420738134810L,5L,304250263527210L,4849845L,13082761331670030L,10010L };
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
public class A117214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117214Inst : IEnumerable<long>
{
public static readonly long[] Value=A117214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117214.Bytes);
public long this[int i]=>Value[i];

public static A117214Inst Instance=new A117214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117215
{
public static readonly long[] Value={ 2L,4L,4L,8L,4L,2L,4L,16L,8L,2L,4L,2L,4L,2L,1L,32L,4L,14L,4L,2L,1L,2L,4L,20L,8L,2L,16L,2L,4L,2L,4L,64L,1L,2L,1L,18L,4L,2L,1L,2L,4L,2L,4L,2L,2L,2L,4L,2L,8L,14L,1L,2L,4L,70L,1L,2L,1L,2L,4L,2L,4L,2L,1L,128L,1L,2L,4L,2L,1L,2L,4L,10L,4L,2L,8L,2L,1L,2L,4L,4L,32L,2L,4L,2L,1L,2L,1L,2L,4L,2L,1L,2L,1L,2L,1L,32L,4L,14L };
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
public class A117215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117215Inst : IEnumerable<long>
{
public static readonly long[] Value=A117215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117215.Bytes);
public long this[int i]=>Value[i];

public static A117215Inst Instance=new A117215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117216
{
public static readonly long[] Value={ 1L,40L,272L,888L,2080L,4040L,6960L,11032L,16448L,23400L,32080L,42680L,55392L,70408L,87920L,108120L,131200L,157352L,186768L,219640L,256160L,296520L,340912L,389528L,442560L,500200L,562640L,630072L,702688L,780680L,864240L,953560L,1048832L,1150248L };
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
public class A117216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117216Inst : IEnumerable<long>
{
public static readonly long[] Value=A117216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117216.Bytes);
public long this[int i]=>Value[i];

public static A117216Inst Instance=new A117216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117217
{
public static readonly long[] Value={ 2L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,12L,12L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
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
public class A117217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117217Inst : IEnumerable<long>
{
public static readonly long[] Value=A117217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117217.Bytes);
public long this[int i]=>Value[i];

public static A117217Inst Instance=new A117217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117218
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,36L,64L,144L,225L,324L,441L,576L,729L,900L,1024L,1156L,1296L,1444L,1600L,1764L,1936L,2116L,2304L,2500L,2704L,2916L,3136L,3364L,3600L,3844L,4096L,4356L,4624L,4900L,5184L,5476L,5776L,6084L,6400L,6724L,7056L,7396L,7744L,8100L,8464L,8836L,9216L,9604L,10000L };
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
public class A117218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117218Inst : IEnumerable<long>
{
public static readonly long[] Value=A117218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117218.Bytes);
public long this[int i]=>Value[i];

public static A117218Inst Instance=new A117218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117219
{
public static readonly long[] Value={ 0L,1L,8L,64L,216L,729L,1000L,1728L,2744L,4096L,5832L,8000L,15625L,27000L,42875L,64000L,91125L,110592L,157464L,216000L,287496L,373248L,474552L,592704L,729000L,884736L,1157625L,1404928L,1685159L,2000376L,2352637L,2744000L,3176523L,3652264L };
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
public class A117219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117219Inst : IEnumerable<long>
{
public static readonly long[] Value=A117219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117219.Bytes);
public long this[int i]=>Value[i];

public static A117219Inst Instance=new A117219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117220
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,10L,12L,19L,30L,37L,61L,75L,102L,127L,217L,271L,374L,469L,588L,817L,1027L,1430L,1801L,2269L,3169L,3997L,5043L,5590L,7057L,8911L,12481L,15769L,19927L,22102L,27937L,35317L,44652L,49537L,62641L,79219L,87894L,111169L,140617L,177877L,197377L };
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
public class A117220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117220Inst : IEnumerable<long>
{
public static readonly long[] Value=A117220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117220.Bytes);
public long this[int i]=>Value[i];

public static A117220Inst Instance=new A117220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117221
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,22L,30L,77L,231L,385L,1575L,3010L,8349L,17977L,147273L,386155L,1741630L,5392783L,18004327L,118114304L,483502844L };
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
public class A117221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117221Inst : IEnumerable<long>
{
public static readonly long[] Value=A117221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117221.Bytes);
public long this[int i]=>Value[i];

public static A117221Inst Instance=new A117221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117222
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,18L,23L,53L,128L,194L,586L,947L,2070L,3667L,16762L,33036L,93402L,200626L,445869L,1517300L,3715025L,14526494L };
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
public class A117222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117222Inst : IEnumerable<long>
{
public static readonly long[] Value=A117222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117222.Bytes);
public long this[int i]=>Value[i];

public static A117222Inst Instance=new A117222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117223
{
public static readonly long[] Value={ 231L,399L,435L,465L,483L,651L,663L,741L,861L,885L,903L,915L,1113L,1173L,1209L,1281L,1311L,1335L,1353L,1443L,1479L,1533L,1581L,1599L,1653L,1743L,1833L,1947L,2163L,2211L,2235L,2247L,2265L,2301L,2337L,2379L,2409L,2485L,2667L,2685L,2715L,2829L,2877L,2915L };
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
public class A117223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117223Inst : IEnumerable<long>
{
public static readonly long[] Value=A117223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117223.Bytes);
public long this[int i]=>Value[i];

public static A117223Inst Instance=new A117223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117224
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,24L,28L,30L,37L,60L,64L,81L,87L,93L,100L,114L,118L,136L,163L,219L,222L,228L,234L,240L,252L,258L,267L,273L,276L,280L,291L,294L,300L,312L,316L,342L,343L,370L,384L,387L,433L,447L,468L,469L,477L,478L,507L,525L,534L,537L,541L,585L,591L,600L,606L,613L };
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
public class A117224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117224Inst : IEnumerable<long>
{
public static readonly long[] Value=A117224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117224.Bytes);
public long this[int i]=>Value[i];

public static A117224Inst Instance=new A117224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117225
{
public static readonly long[] Value={ 185371L,129281L,86771L,55501L,33347L,18401L,8971L,3581L,971L,97L,131L,461L,691L,641L,347L,61L,251L,1601L,5011L,11597L,22691L,39841L,64811L,99581L,146347L,207521L,285731L,383821L,504851L };
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
public class A117225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117225Inst : IEnumerable<long>
{
public static readonly long[] Value=A117225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117225.Bytes);
public long this[int i]=>Value[i];

public static A117225Inst Instance=new A117225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117226
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,23L,110L,630L,4204L,32054L,274914L,2619692L,27459344L,313990182L,3889585408L,51888955808L,741668212080L,11307669002720L,183174676857608L,3141820432768752L,56882461258572976L,1084056190235653304L,BigInteger.Parse("21692744773505849952"),BigInteger.Parse("454758269790599361968") };
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
public class A117226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117226.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117226Inst Instance=new A117226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117227
{
public static readonly long[] Value={ 12L,20L,28L,33L,41L,46L,51L,54L,62L,67L,72L,75L,83L,88L,93L,96L,101L,104L,112L,117L,122L,125L,130L,133L,138L,141L,144L };
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
public class A117227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117227Inst : IEnumerable<long>
{
public static readonly long[] Value=A117227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117227.Bytes);
public long this[int i]=>Value[i];

public static A117227Inst Instance=new A117227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117228
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,111L,2112L,4224L,13131L,21112L,21312L,31113L,42624L,211112L,234432L,1113111L,2111112L,2114112L,2118112L,21122112L,61111116L,111111111L,211121112L,211242112L,211262112L,213141312L,2111111112L,2112332112L,2114114112L,2131221312L };
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
public class A117228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117228Inst : IEnumerable<long>
{
public static readonly long[] Value=A117228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117228.Bytes);
public long this[int i]=>Value[i];

public static A117228Inst Instance=new A117228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117229
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,3L,3L,2L,2L,3L };
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
public class A117229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117229Inst : IEnumerable<long>
{
public static readonly long[] Value=A117229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117229.Bytes);
public long this[int i]=>Value[i];

public static A117229Inst Instance=new A117229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117230
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L };
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
public class A117230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117230Inst : IEnumerable<long>
{
public static readonly long[] Value=A117230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117230.Bytes);
public long this[int i]=>Value[i];

public static A117230Inst Instance=new A117230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117231
{
public static readonly long[] Value={ 3L,2L,3L,3L,6L,7L,4L,3L,1L,6L,7L,7L,7L,7L,8L,7L,6L,1L,3L,9L,9L,3L,7L,0L,0L,8L,7L,9L,5L,2L,1L,7L,0L,4L,4L,6L,6L,5L,1L,0L,4L,6L,6L,2L,5L,7L,2L,5L,4L,6L,9L,6L,6L,1L,6L,8L,1L,0L,3L,6L,4L,4L,3L,4L,3L,1L,7L,9L,0L,3L,3L,7L,2L,1L,0L,6L,7L,2L,8L,9L,4L,4L,3L,1L,9L,3L,0L,3L,7L,0L,4L,6L,4L,1L,0L,2L,4L,5L,1L,3L,8L,0L,2L,8L,0L };
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
public class A117231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117231Inst : IEnumerable<long>
{
public static readonly long[] Value=A117231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117231.Bytes);
public long this[int i]=>Value[i];

public static A117231Inst Instance=new A117231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117232
{
public static readonly long[] Value={ 9L,9L,5L,2L,6L,2L,9L,1L,9L,4L,4L,3L,3L,5L,4L,1L,6L,0L,8L,9L,0L,3L,1L,1L,8L,0L,9L,4L,2L,6L,7L,2L,1L,6L,2L,1L,0L,2L,9L,4L,6L,6L,9L,2L,2L,7L,3L,4L,1L,5L,4L,3L,4L,9L,8L,0L,3L,2L,0L,8L,8L,5L,8L,0L,7L,2L,9L,8L,6L,1L,7L,9L,6L,2L,2L,8L,3L,0L,6L,3L,2L,0L,9L,9L,1L,7L,4L,9L,8L,1L,8L,9L,7L,6L,1L,8L,8L,7L,6L,0L };
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
public class A117232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117232Inst : IEnumerable<long>
{
public static readonly long[] Value=A117232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117232.Bytes);
public long this[int i]=>Value[i];

public static A117232Inst Instance=new A117232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117233
{
public static readonly long[] Value={ 1L,2L,7L,4L,2L,2L,4L,1L,5L,2L,8L,2L,1L,2L,2L,8L,1L,8L,8L,2L,1L,2L,3L,4L,0L,6L,3L,9L,7L,2L,5L,0L,7L,8L,0L,9L,9L,4L,7L,2L };
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
public class A117233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117233Inst : IEnumerable<long>
{
public static readonly long[] Value=A117233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117233.Bytes);
public long this[int i]=>Value[i];

public static A117233Inst Instance=new A117233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117234
{
public static readonly long[] Value={ 3L,3L,0L,6L,8L,6L,8L,6L,4L,7L,4L,7L,5L,2L,3L,7L,2L,8L,0L,0L,7L,6L,1L,1L,3L,7L,7L,0L,8L,9L,8L,5L,1L,5L,6L,5L,7L,1L,6L,6L,4L,8L,2L,3L,6L,1L,4L,7L,6L,2L,8L,8L,2L,1L,7L,5L,0L,1L,2L,9L,3L,0L,8L,5L,4L,9L,6L,3L,0L,9L,1L,9L,9L,8L,3L,7L,8L,8L,8L,2L,9L,5L,0L,3L,5L,8L,2L,5L,4L,8L,8L,0L,7L,5L,2L,8L,3L,4L,9L,9L,1L,8L,6L,1L,9L };
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
public class A117234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117234Inst : IEnumerable<long>
{
public static readonly long[] Value=A117234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117234.Bytes);
public long this[int i]=>Value[i];

public static A117234Inst Instance=new A117234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117235
{
public static readonly long[] Value={ 2L,1L,4L,3L,3L,5L,2L,3L,4L,5L,9L,0L,4L,5L,9L,6L,3L,9L,4L,6L,1L,5L,2L,6L,4L,0L,0L,1L,8L,4L,7L,4L,9L,3L,9L,6L,1L,1L,3L,4L,0L,7L,2L,8L,7L,7L,8L,9L,5L,1L,6L,7L,0L,8L,0L,7L,3L,9L,3L,4L,9L,8L,5L,9L,7L,0L,9L,8L,7L,6L,7L,6L,0L,7L,4L,0L,5L,4L,5L,9L,8L,1L,6L,9L,4L,7L,9L,8L,8L,4L,7L,8L,8L,8L,3L,0L,5L,3L,3L,1L };
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
public class A117235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117235Inst : IEnumerable<long>
{
public static readonly long[] Value=A117235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117235.Bytes);
public long this[int i]=>Value[i];

public static A117235Inst Instance=new A117235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117236
{
public static readonly long[] Value={ 0L,6L,1L,9L,1L,3L,9L,5L,4L,4L,7L,3L,9L,9L,0L,9L,4L,2L,8L,4L,8L,1L,7L,5L,2L,1L,6L,4L,7L,3L,2L,1L,2L,1L,7L,6L,9L,9L,9L,6L,3L,8L,7L,7L,4L,9L,9L,8L,3L,6L,2L,0L,7L,6L,0L,6L,1L,4L,6L,7L,2L,5L,8L,8L,5L,9L,9L,3L,1L,0L,1L,0L,2L,9L,7L,5L,9L,6L,1L,5L,8L,4L,5L,9L,0L,7L,1L,0L,5L,6L,4L,5L,7L,5L,2L,0L,8L,7L,8L,6L,1L,3L,7L,1L,6L,7L };
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
public class A117236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117236Inst : IEnumerable<long>
{
public static readonly long[] Value=A117236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117236.Bytes);
public long this[int i]=>Value[i];

public static A117236Inst Instance=new A117236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117237
{
public static readonly long[] Value={ 7L,2L,5L,0L,7L,8L,3L,4L,6L,2L,6L,8L,4L,0L,1L,1L,6L,7L,4L,6L,8L,6L,8L,7L,7L,1L,9L,2L,5L,1L,1L,6L,0L,9L,6L,8L,8L,6L,9L,1L,8L,0L,5L,9L,4L,4L,7L,9L,5L,0L,8L,9L,5L,7L,8L,7L,8L,1L,6L,4L,7L,6L,9L,2L,0L,7L,7L,7L,3L,1L,8L,9L,9L,9L,4L,5L,9L,6L,2L,8L,3L,5L,7L,3L,5L,9L,2L,3L,9L,2L,7L,8L,6L,4L,7L,8L,2L,0L,2L,0L };
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
public class A117237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117237Inst : IEnumerable<long>
{
public static readonly long[] Value=A117237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117237.Bytes);
public long this[int i]=>Value[i];

public static A117237Inst Instance=new A117237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117238
{
public static readonly long[] Value={ 4L,2L,4L,0L,1L,1L,3L,8L,7L,0L,3L,3L,6L,8L,8L,3L,6L,3L,7L,9L,7L,4L,3L,3L,6L,6L,8L,5L,9L,3L,2L,5L,6L,4L,5L,1L,2L,4L,7L,7L,6L,2L,0L,9L,0L,6L,6L,4L,2L,7L,4L,7L,6L,2L,1L,9L,7L,1L,1L,2L,4L,9L,5L,9L,1L,3L,3L,1L,0L,1L,7L,6L,9L,5L,7L,5L,6L,3L,6L,9L,2L,2L,9L,7L,0L,7L,2L,4L,4L,2L,2L,9L,4L,4L,7L,7L,0L,1L,1L,2L };
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
public class A117238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117238Inst : IEnumerable<long>
{
public static readonly long[] Value=A117238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117238.Bytes);
public long this[int i]=>Value[i];

public static A117238Inst Instance=new A117238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117239
{
public static readonly long[] Value={ 7L,8L,5L,9L,3L,3L,6L,7L,4L,3L,5L,0L,3L,7L,1L,4L,5L,4L,5L,6L,5L,2L,4L,3L,9L,8L,6L,3L,2L,7L,5L,4L,5L,5L,8L,2L,9L,6L,2L,3L,9L,5L,4L,5L,9L,0L,6L,1L,8L,6L,6L,8L,1L,7L,5L,8L,1L,2L,3L,1L,8L,0L,7L,0L,9L,8L,9L,1L,0L,3L,9L,7L,1L,4L,9L,4L,1L,2L,3L,6L,5L,1L,1L,6L,7L,7L,0L,6L,3L,3L,7L,6L,5L,9L,9L,4L,4L,9L,5L,3L };
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
public class A117239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117239Inst : IEnumerable<long>
{
public static readonly long[] Value=A117239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117239.Bytes);
public long this[int i]=>Value[i];

public static A117239Inst Instance=new A117239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117240
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,3L,8L,3L,7L,5L,8L,7L,9L,7L,9L,2L,5L,1L,2L,2L,6L,1L,0L,3L,4L,0L,7L,1L,3L,3L,1L,8L,6L,2L,0L,4L,8L,3L,9L,1L,0L,0L,7L,9L,3L,0L,0L,5L,5L,9L,4L,0L,7L,2L,5L,0L,9L,5L,6L,9L,0L,3L,0L,0L,2L,2L,7L,9L,9L,1L,7L,3L,4L,3L,6L,6L,0L,6L,8L,5L,2L,7L,4L,3L,2L,7L,6L,5L,0L,0L,8L,4L,2L,8L,4L,5L,6L,4L,7L,2L,6L,9L,9L,1L,0L,1L,5L,3L,5L,3L };
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
public class A117240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117240Inst : IEnumerable<long>
{
public static readonly long[] Value=A117240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117240.Bytes);
public long this[int i]=>Value[i];

public static A117240Inst Instance=new A117240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117241
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,20L,30L,38L,50L,57L,60L,70L,76L,80L,90L,95L,100L,104L,120L,190L,200L,207L,208L,231L,240L,252L,300L,310L,360L,380L,400L,403L,414L,430L,462L,465L,480L,500L,506L,528L,570L,600L,620L,625L,629L,693L,700L,702L,714L,754L,760L,800L,805L,806L };
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
public class A117241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117241Inst : IEnumerable<long>
{
public static readonly long[] Value=A117241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117241.Bytes);
public long this[int i]=>Value[i];

public static A117241Inst Instance=new A117241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117242
{
public static readonly long[] Value={ 2L,23L,37L,47L,53L,67L,83L,89L,113L,127L,131L,157L,167L,211L,233L,251L,257L,263L,293L,307L,317L,337L,353L,359L,379L,389L,401L,409L,443L,449L,467L,479L,487L,491L,499L,503L,509L,541L,557L,563L,577L,587L,631L,647L,653L,677L,683L,701L,719L,743L,751L,761L,769L,787L,797L,839L,863L,877L,887L,911L,919L,937L,941L,947L,953L,971L,977L,983L,991L };
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
public class A117242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117242Inst : IEnumerable<long>
{
public static readonly long[] Value=A117242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117242.Bytes);
public long this[int i]=>Value[i];

public static A117242Inst Instance=new A117242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117243
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,31L,41L,59L,71L,101L,107L,109L,137L,139L,149L,179L,181L,191L,197L,199L,227L,239L,269L,281L,311L,347L,419L,431L,461L,521L,569L,571L,599L,617L,641L,659L,809L,811L,821L,827L,829L,857L,881L,1019L,1031L,1049L,1061L,1091L,1151L,1229L };
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
public class A117243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117243Inst : IEnumerable<long>
{
public static readonly long[] Value=A117243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117243.Bytes);
public long this[int i]=>Value[i];

public static A117243Inst Instance=new A117243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117244
{
public static readonly long[] Value={ 79L,97L,163L,173L,223L,277L,331L,367L,373L,383L,397L,439L,457L,547L,593L,607L,613L,673L,691L,709L,727L,733L,739L,757L,773L,853L,907L,929L,967L,997L,1013L,1069L,1087L,1103L,1123L,1129L,1171L,1181L,1213L,1223L,1237L,1249L,1307L,1373L,1423L,1433L,1447L,1493L };
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
public class A117244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117244Inst : IEnumerable<long>
{
public static readonly long[] Value=A117244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117244.Bytes);
public long this[int i]=>Value[i];

public static A117244Inst Instance=new A117244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117245
{
public static readonly long[] Value={ 1L,3L,6L,10L,15L,22L,30L,39L,50L,63L,80L,99L,122L,147L,174L,203L,234L,266L,303L,344L,387L,434L,483L,536L,595L,656L,723L,794L,867L,946L,1029L,1118L,1215L,1316L,1419L,1526L,1635L,1748L,1869L,1994L,2121L,2252L,2389L,2528L,2677L,2828L,2985L,3148L,3315L,3484L,3657L };
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
public class A117245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117245Inst : IEnumerable<long>
{
public static readonly long[] Value=A117245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117245.Bytes);
public long this[int i]=>Value[i];

public static A117245Inst Instance=new A117245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117246
{
public static readonly long[] Value={ 225L,625L,1225L,2025L,3025L,4225L,5625L,7225L,9025L,15625L,27225L,30625L,34225L,42025L,50625L,60025L,70225L,75625L,81225L,93025L,105625L,275625L,330625L,600625L,893025L,950625L,970225L,1050625L,2030625L,3330625L,4950625L,40005625L };
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
public class A117246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117246Inst : IEnumerable<long>
{
public static readonly long[] Value=A117246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117246.Bytes);
public long this[int i]=>Value[i];

public static A117246Inst Instance=new A117246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117247
{
public static readonly long[] Value={ 4L,6L,8L,12L,14L,15L,17L,18L,21L,23L,26L,27L,29L,30L,31L,34L,35L,37L,39L,41L,42L,45L,46L,47L,50L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,66L,69L,70L,71L,72L,74L,76L,77L,78L,80L,81L,83L,84L,86L,87L,88L,90L,92L,93L,94L,95L,98L,99L,100L,101L,102L,105L,106L,107L,108L,109L,111L,113L,114L };
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
public class A117247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117247Inst : IEnumerable<long>
{
public static readonly long[] Value=A117247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117247.Bytes);
public long this[int i]=>Value[i];

public static A117247Inst Instance=new A117247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117248
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,4L,4L,6L,5L,8L,6L,10L,7L,12L,8L,14L,9L,16L,10L,18L,11L,20L,12L,22L,13L,24L,14L,26L,15L,28L,16L,30L,17L,32L,18L,34L,19L,36L,20L,38L,21L,40L,22L,42L,23L,44L,24L,46L,25L,48L,26L,50L,27L,52L,28L,54L,29L,56L,30L,58L,31L,60L,32L,62L,33L,64L,34L,66L,35L,68L,36L };
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
public class A117248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117248Inst : IEnumerable<long>
{
public static readonly long[] Value=A117248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117248.Bytes);
public long this[int i]=>Value[i];

public static A117248Inst Instance=new A117248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117249
{
public static readonly long[] Value={ 5L,7L,13L,19L,37L,43L,61L,71L,89L,113L,131L,163L,181L,193L,223L,251L,281L,293L,337L,359L,373L,409L,433L,463L,521L,557L,569L,593L,601L,619L,719L,743L,787L,809L,863L,881L,929L,971L,997L,1033L,1069L,1091L,1163L,1181L,1213L,1223L,1301L,1423L,1439L,1451L,1481L,1511L,1531L,1601L,1627L,1693L,1733L,1747L,1789L,1831L,1861L,1931L };
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
public class A117249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117249Inst : IEnumerable<long>
{
public static readonly long[] Value=A117249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117249.Bytes);
public long this[int i]=>Value[i];

public static A117249Inst Instance=new A117249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117250
{
public static readonly long[] Value={ 1L,1L,1L,-1L,2L,1L,4L,-4L,4L,1L,-40L,32L,-16L,8L,1L,896L,-640L,256L,-64L,16L,1L,-43008L,28672L,-10240L,2048L,-256L,32L,1L,4325376L,-2752512L,917504L,-163840L,16384L,-1024L,64L,1L,-899678208L,553648128L,-176160768L,29360128L,-2621440L,131072L,-4096L,128L,1L };
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
public class A117250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117250Inst : IEnumerable<long>
{
public static readonly long[] Value=A117250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117250.Bytes);
public long this[int i]=>Value[i];

public static A117250Inst Instance=new A117250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117251
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,4L,-40L,896L,-43008L,4325376L,-899678208L,383862702080L,-334114095890432L,590956713604022272L,BigInteger.Parse("-2117988861556815822848"),BigInteger.Parse("15348576513041885002989568"),BigInteger.Parse("-224527747847927003472304537600"),BigInteger.Parse("6621592717332784844802427579269120") };
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
public class A117251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117251Inst Instance=new A117251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117252
{
public static readonly long[] Value={ 1L,1L,1L,-3L,3L,1L,45L,-27L,9L,1L,-2430L,1215L,-243L,27L,1L,433026L,-196830L,32805L,-2187L,81L,1L,-245525742L,105225318L,-15943230L,885735L,-19683L,243L,1L,434685788658L,-178988265918L,25569752274L,-1291401630L,23914845L,-177147L,729L,1L };
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
public class A117252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117252Inst : IEnumerable<long>
{
public static readonly long[] Value=A117252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117252.Bytes);
public long this[int i]=>Value[i];

public static A117252Inst Instance=new A117252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117253
{
public static readonly BigInteger[] Value={ 1L,1L,-3L,45L,-2430L,433026L,-245525742L,434685788658L,-2376644549487615L,BigInteger.Parse("39849199161258840705"),BigInteger.Parse("-2039314646436750180150939"),BigInteger.Parse("317469566015078743658568283029"),BigInteger.Parse("-149970083228995077874358388356635368"),BigInteger.Parse("214577598849654850870918566871719460091160") };
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
public class A117253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117253Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117253.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117253.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117253Inst Instance=new A117253Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117254
{
public static readonly long[] Value={ 1L,1L,1L,-6L,4L,1L,224L,-96L,16L,1L,-39424L,14336L,-1536L,64L,1L,30277632L,-10092544L,917504L,-24576L,256L,1L,-98180268032L,31004295168L,-2583691264L,58720256L,-393216L,1024L,1L,1321338098679808L,-402146377859072L,31748398252032L,-661424963584L,3758096384L,-6291456L,4096L,1L };
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
public class A117254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117254Inst : IEnumerable<long>
{
public static readonly long[] Value=A117254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117254.Bytes);
public long this[int i]=>Value[i];

public static A117254Inst Instance=new A117254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117255
{
public static readonly BigInteger[] Value={ 1L,1L,-6L,224L,-39424L,30277632L,-98180268032L,1321338098679808L,BigInteger.Parse("-73064711504598663168"),BigInteger.Parse("16493270769791857518968832"),BigInteger.Parse("-15132641904367108441083979235328"),BigInteger.Parse("56258298143912014448000446346897129472"),BigInteger.Parse("-845539117695226477286180063077230730209656832") };
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
public class A117255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117255Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117255.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117255.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117255Inst Instance=new A117255Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117256
{
public static readonly long[] Value={ 1L,1L,1L,-10L,5L,1L,750L,-250L,25L,1L,-328125L,93750L,-6250L,125L,1L,779296875L,-205078125L,11718750L,-156250L,625L,1L,-9741210937500L,2435302734375L,-128173828125L,1464843750L,-3906250L,3125L,1L,630569458007812500L,-152206420898437500L,7610321044921875L };
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
public class A117256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117256Inst : IEnumerable<long>
{
public static readonly long[] Value=A117256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117256.Bytes);
public long this[int i]=>Value[i];

public static A117256Inst Instance=new A117256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117257
{
public static readonly BigInteger[] Value={ 1L,1L,-10L,750L,-328125L,779296875L,-9741210937500L,630569458007812500L,BigInteger.Parse("-209368765354156494140625"),BigInteger.Parse("354400253854691982269287109375"),BigInteger.Parse("-3045627181563759222626686096191406250"),BigInteger.Parse("132489108572997338342247530817985534667968750") };
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
public class A117257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117257Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117257.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117257.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117257Inst Instance=new A117257Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117258
{
public static readonly long[] Value={ 1L,1L,1L,-2L,4L,1L,32L,-32L,16L,1L,-2560L,2048L,-512L,64L,1L,917504L,-655360L,131072L,-8192L,256L,1L,-1409286144L,939524096L,-167772160L,8388608L,-131072L,1024L,1L,9070970929152L,-5772436045824L,962072674304L,-42949672960L,536870912L,-2097152L,4096L,1L };
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
public class A117258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117258Inst : IEnumerable<long>
{
public static readonly long[] Value=A117258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117258.Bytes);
public long this[int i]=>Value[i];

public static A117258Inst Instance=new A117258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117259
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,32L,-2560L,917504L,-1409286144L,9070970929152L,-241505530017742848L,BigInteger.Parse("26378844025404658810880"),BigInteger.Parse("-11755594669932654094842855424"),BigInteger.Parse("21291459481433341027538627037495296"),BigInteger.Parse("-156279993920424129009046403691280672489472") };
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
public class A117259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117259Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117259.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117259.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117259Inst Instance=new A117259Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117260
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,8L,8L,4L,1L,64L,64L,32L,8L,1L,1024L,1024L,512L,128L,16L,1L,32768L,32768L,16384L,4096L,512L,32L,1L,2097152L,2097152L,1048576L,262144L,32768L,2048L,64L,1L,268435456L,268435456L,134217728L,33554432L,4194304L,262144L,8192L,128L,1L };
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
public class A117260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117260Inst : IEnumerable<long>
{
public static readonly long[] Value=A117260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117260.Bytes);
public long this[int i]=>Value[i];

public static A117260Inst Instance=new A117260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117261
{
public static readonly BigInteger[] Value={ 1L,2L,5L,21L,169L,2705L,86561L,5539905L,709107841L,181531607297L,92944182936065L,95174843326530561L,BigInteger.Parse("194918079132734588929"),BigInteger.Parse("798384452127680876253185"),BigInteger.Parse("6540365431829961738266091521"),BigInteger.Parse("107157347235102093119751643480065") };
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
public class A117261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117261Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117261.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117261.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117261Inst Instance=new A117261Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117262
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,27L,27L,9L,1L,729L,729L,243L,27L,1L,59049L,59049L,19683L,2187L,81L,1L,14348907L,14348907L,4782969L,531441L,19683L,243L,1L,10460353203L,10460353203L,3486784401L,387420489L,14348907L,177147L,729L,1L };
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
public class A117262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117262Inst : IEnumerable<long>
{
public static readonly long[] Value=A117262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117262.Bytes);
public long this[int i]=>Value[i];

public static A117262Inst Instance=new A117262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117263
{
public static readonly BigInteger[] Value={ 1L,2L,7L,64L,1729L,140050L,34032151L,24809438080L,54258241080961L,355988319732185122L,BigInteger.Parse("7006918097288599756327"),BigInteger.Parse("413751506726794527011353024"),BigInteger.Parse("73294838162131470076480154142529") };
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
public class A117263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117263Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117263.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117263.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117263Inst Instance=new A117263Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117264
{
public static readonly BigInteger[] Value={ 1L,1L,3L,29L,831L,69107L,16944055L,12387543565L,27116679815367L,177967005474840987L,BigInteger.Parse("3503280999913078429261"),BigInteger.Parse("206872249547698485286567247"),BigInteger.Parse("36647212198301159763279385189667") };
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
public class A117264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117264Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117264.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117264.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117264Inst Instance=new A117264Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117265
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,20L,12L,4L,1L,280L,160L,48L,8L,1L,8064L,4480L,1280L,192L,16L,1L,473088L,258048L,71680L,10240L,768L,32L,1L,56229888L,30277632L,8257536L,1146880L,81920L,3072L,64L,1L,13495173120L,7197425664L,1937768448L,264241152L,18350080L,655360L };
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
public class A117265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117265Inst : IEnumerable<long>
{
public static readonly long[] Value=A117265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117265.Bytes);
public long this[int i]=>Value[i];

public static A117265Inst Instance=new A117265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117266
{
public static readonly BigInteger[] Value={ 1L,2L,6L,37L,497L,14033L,813857L,95996993L,22913626241L,11034472530177L,10699863490757121L,BigInteger.Parse("20863301244829828097"),BigInteger.Parse("81721932792141693585409"),BigInteger.Parse("642577422892784159654154241"),BigInteger.Parse("10136733849914528413869372612609") };
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
public class A117266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117266Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117266.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117266.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117266Inst Instance=new A117266Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117267
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,5L,4L,6L,9L,14L,7L,11L,17L,26L,40L,13L,20L,31L,48L,74L,114L,24L,37L,57L,88L,136L,210L,324L,44L,68L,105L,162L,250L,386L,596L,920L,81L,125L,193L,298L,460L,710L,1096L,1692L,2612L };
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
public class A117267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117267Inst : IEnumerable<long>
{
public static readonly long[] Value=A117267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117267.Bytes);
public long this[int i]=>Value[i];

public static A117267Inst Instance=new A117267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117268
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,4L,2L,3L,5L,7L,4L,6L,9L,14L,13L,7L,11L,17L,26L,40L,24L,13L,20L,31L,48L,74L,114L,44L,24L,37L,57L,88L,136L,210L,324L,81L,44L,68L,105L,162L,250L,386L,596L,920L };
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
public class A117268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117268Inst : IEnumerable<long>
{
public static readonly long[] Value=A117268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117268.Bytes);
public long this[int i]=>Value[i];

public static A117268Inst Instance=new A117268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117269
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,1L,19L,9L,3L,1L,207L,76L,18L,4L,1L,3211L,1035L,190L,30L,5L,1L,64383L,19266L,3105L,380L,45L,6L,1L,1581259L,450681L,67431L,7245L,665L,63L,7L,1L,45948927L,12650072L,1802724L,179816L,14490L,1064L,84L,8L,1L,1541641771L,413540343L,56925324L,5408172L };
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
public class A117269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117269Inst : IEnumerable<long>
{
public static readonly long[] Value=A117269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117269.Bytes);
public long this[int i]=>Value[i];

public static A117269Inst Instance=new A117269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117270
{
public static readonly long[] Value={ 0L,1L,0L,2L,2L,0L,12L,6L,3L,0L,134L,48L,12L,4L,0L,2100L,670L,120L,20L,5L,0L,42302L,12600L,2010L,240L,30L,6L,0L,1041852L,296114L,44100L,4690L,420L,42L,7L,0L,30331814L,8334816L,1184456L,117600L,9380L,672L,56L,8L,0L,1019056260L,272986326L,37506672L,3553368L };
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
public class A117270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117270Inst : IEnumerable<long>
{
public static readonly long[] Value=A117270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117270.Bytes);
public long this[int i]=>Value[i];

public static A117270Inst Instance=new A117270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117271
{
public static readonly BigInteger[] Value={ 0L,1L,2L,12L,134L,2100L,42302L,1041852L,30331814L,1019056260L,38805685262L,1651676734092L,77703508288694L,4003868870257620L,224255353667365022L,13565588100060643932UL,BigInteger.Parse("881405810330856632774"),BigInteger.Parse("61218510507062012550180") };
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
public class A117271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A117271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A117271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A117271Inst Instance=new A117271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117272
{
public static readonly long[] Value={ 3L,5L,11L,19L,47L,61L,71L,97L,157L,179L,229L,373L,409L,691L,1231L,1373L,1987L,2213L,2557L,3119L,3989L,8443L,9311L,17191L,20707L,26261L,38281L,41381L,48611L,54541L,66889L,74257L,255709L };
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
public class A117272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117272Inst : IEnumerable<long>
{
public static readonly long[] Value=A117272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117272.Bytes);
public long this[int i]=>Value[i];

public static A117272Inst Instance=new A117272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117273
{
public static readonly long[] Value={ 16L,53L,63L,364L,437L,545L,573L,829L,963L,5449L,6475L,23797L,67458L,2475998L };
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
public class A117273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117273Inst : IEnumerable<long>
{
public static readonly long[] Value=A117273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117273.Bytes);
public long this[int i]=>Value[i];

public static A117273Inst Instance=new A117273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117274
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,1L,1L,0L,1L,3L,2L,1L,1L,1L,0L,1L,3L,3L,2L,1L,1L,1L,0L,1L,4L,3L,3L,2L,1L,1L,1L,0L,1L,6L,4L,3L,3L,2L,1L,1L,1L,0L,1L,7L,6L,4L,3L,3L,2L,1L,1L,1L,0L,1L,9L,7L,6L,4L,3L,3L,2L,1L,1L,1L,0L,1L,12L,9L,7L,6L,4L,3L,3L,2L,1L,1L,1L,0L,1L,14L,12L,9L,7L,6L,4L,3L,3L,2L,1L,1L,1L,0L };
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
public class A117274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117274Inst : IEnumerable<long>
{
public static readonly long[] Value=A117274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117274.Bytes);
public long this[int i]=>Value[i];

public static A117274Inst Instance=new A117274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117275
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,3L,3L,4L,6L,7L,9L,12L,14L,18L,23L,27L,34L,42L,50L,62L,75L,89L,108L,130L,154L,184L,220L,259L,307L,364L,426L,502L,590L,688L,806L,941L,1093L,1272L,1478L,1710L,1980L,2290L,2638L,3042L,3503L,4021L,4618L,5296L,6060L,6934L,7924L,9038L,10306L,11740L };
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
public class A117275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117275Inst : IEnumerable<long>
{
public static readonly long[] Value=A117275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117275.Bytes);
public long this[int i]=>Value[i];

public static A117275Inst Instance=new A117275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117276
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,11L,17L,26L,38L,54L,76L,105L,143L,193L,257L,339L,444L,576L,742L,950L,1208L,1528L,1923L,2407L,2999L,3721L,4597L,5657L,6937L,8476L,10322L,12532L,15168L,18306L,22034L,26450L,31672L,37835L,45091L,53619L,63625L,75341L,89037L,105023L,123647L };
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
public class A117276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117276Inst : IEnumerable<long>
{
public static readonly long[] Value=A117276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117276.Bytes);
public long this[int i]=>Value[i];

public static A117276Inst Instance=new A117276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117277
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,2L,2L,1L,3L,1L,2L,2L,2L,1L,3L,2L,2L,2L,2L,2L,3L,1L,2L,3L,2L,1L,3L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,1L,4L,2L,2L,2L,2L,3L,4L,1L,2L,3L,3L,1L,4L,2L,2L,3L,2L,2L,4L,1L,3L,3L,2L,1L,4L,4L,2L,2L,2L,2L,5L,1L,3L,3L,2L,2L,4L,2L,2L,3L,3L,2L,4L,1L,2L,4L,3L,2L,4L,2L,3L,2L,2L,3L,4L,3L,2L,3L,2L,1L,6L };
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
public class A117277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117277Inst : IEnumerable<long>
{
public static readonly long[] Value=A117277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117277.Bytes);
public long this[int i]=>Value[i];

public static A117277Inst Instance=new A117277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A117278
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,2L,1L,0L,2L,1L,1L,1L,1L,0L,2L,2L,1L,0L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,0L,2L,1L,3L,2L,1L,1L,0L,1L,3L,2L,3L,2L,1L,0L,2L,2L,3L,3L,2L,1L,1L,1L,0L,4L,3L,3L,3L,2L,1L,0L,2L,2L,4L,3L,4L,2L,1L,1L,1L,1L,3L,4L,5L,3L,3L,2L,1L,0L,2L,2L,6L,4L,4L,4L,2L,1L,1L,0L,1L,5L,3L,6L };
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
public class A117278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A117278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A117278Inst : IEnumerable<long>
{
public static readonly long[] Value=A117278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A117278.Bytes);
public long this[int i]=>Value[i];

public static A117278Inst Instance=new A117278Inst();

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