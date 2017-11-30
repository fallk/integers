using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A268662
{
public static readonly long[] Value={ 7L,15L,25L,39L,55L,75L,85L,127L,1947L,3313L,13165L,23473L,125413L,1282755L,1777515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268662Inst : IEnumerable<long>
{
public static readonly long[] Value=A268662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268662.Bytes);
public long this[int i]=>Value[i];

public static A268662Inst Instance=new A268662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268663
{
public static readonly long[] Value={ 127L,4687L,1777515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268663Inst : IEnumerable<long>
{
public static readonly long[] Value=A268663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268663.Bytes);
public long this[int i]=>Value[i];

public static A268663Inst Instance=new A268663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268664
{
public static readonly long[] Value={ 13L,15L,127L,5947L,26607L,1320487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268664Inst : IEnumerable<long>
{
public static readonly long[] Value=A268664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268664.Bytes);
public long this[int i]=>Value[i];

public static A268664Inst Instance=new A268664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268665
{
public static readonly long[] Value={ 6L,9L,22L,26L,44L,52L,73L,111L,122L,164L,201L,214L,254L,311L,374L,398L,465L,521L,542L,617L,684L,774L,899L,969L,1005L,1064L,1100L,1181L,1441L,1548L,1658L,1694L,1918L,1977L,2114L,2255L,2376L,2537L,2684L,2727L,3019L,3068L,3181L,3238L,3611L,3985L,4114L,4182L,4313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268665Inst : IEnumerable<long>
{
public static readonly long[] Value=A268665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268665.Bytes);
public long this[int i]=>Value[i];

public static A268665Inst Instance=new A268665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268666
{
public static readonly long[] Value={ 1L,2L,8L,64L,646L,9364L,151028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268666Inst : IEnumerable<long>
{
public static readonly long[] Value=A268666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268666.Bytes);
public long this[int i]=>Value[i];

public static A268666Inst Instance=new A268666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268667
{
public static readonly BigInteger[] Value={ 1L,1L,2L,26L,3511L,6742796L,233249911607L,175703195017370516L,BigInteger.Parse("3377940832101159287907151"),BigInteger.Parse("1899957346851645870857879683505890"),BigInteger.Parse("35246706696124014829643459097288501560957174"),BigInteger.Parse("23998872279553738609365779286317516184675391844037227392") };
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
public class A268667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268667Inst Instance=new A268667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268668
{
public static readonly long[] Value={ 1L,1L,3L,23L,465L,19834L,1532489L,193746632L,37368959742L,10437763731100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268668Inst : IEnumerable<long>
{
public static readonly long[] Value=A268668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268668.Bytes);
public long this[int i]=>Value[i];

public static A268668Inst Instance=new A268668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268669
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,7L,8L,7L,2L,11L,4L,13L,14L,1L,16L,1L,14L,19L,4L,21L,22L,13L,8L,25L,26L,7L,28L,11L,2L,31L,32L,31L,2L,35L,28L,37L,38L,11L,8L,41L,42L,25L,44L,7L,26L,47L,16L,49L,50L,1L,52L,19L,14L,55L,56L,13L,22L,59L,4L,61L,62L,21L,64L,21L,62L,67L,4L,69L,70L,61L,56L,73L,74L,13L,76L,59L,22L,79L,16L,81L,82L,49L,84L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268669Inst : IEnumerable<long>
{
public static readonly long[] Value=A268669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268669.Bytes);
public long this[int i]=>Value[i];

public static A268669Inst Instance=new A268669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268670
{
public static readonly long[] Value={ 1L,3L,1L,7L,1L,3L,5L,15L,5L,3L,13L,7L,9L,11L,1L,31L,1L,11L,29L,7L,25L,27L,9L,15L,17L,19L,5L,23L,13L,3L,21L,63L,21L,3L,61L,23L,57L,59L,13L,15L,49L,51L,17L,55L,5L,19L,53L,31L,33L,35L,1L,39L,29L,11L,37L,47L,9L,27L,45L,7L,41L,43L,25L,127L,25L,43L,125L,7L,121L,123L,41L,47L,113L,115L,9L,119L,45L,27L,117L,31L,97L,99L,33L,103L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268670Inst : IEnumerable<long>
{
public static readonly long[] Value=A268670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268670.Bytes);
public long this[int i]=>Value[i];

public static A268670Inst Instance=new A268670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268671
{
public static readonly long[] Value={ 1L,2L,1L,4L,1L,2L,3L,8L,3L,2L,7L,4L,5L,6L,1L,16L,1L,6L,15L,4L,13L,14L,5L,8L,9L,10L,3L,12L,7L,2L,11L,32L,11L,2L,31L,12L,29L,30L,7L,8L,25L,26L,9L,28L,3L,10L,27L,16L,17L,18L,1L,20L,15L,6L,19L,24L,5L,14L,23L,4L,21L,22L,13L,64L,13L,22L,63L,4L,61L,62L,21L,24L,57L,58L,5L,60L,23L,14L,59L,16L,49L,50L,17L,52L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268671Inst : IEnumerable<long>
{
public static readonly long[] Value=A268671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268671.Bytes);
public long this[int i]=>Value[i];

public static A268671Inst Instance=new A268671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268672
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,2L,2L,3L,4L,4L,3L,4L,4L,5L,6L,4L,5L,2L,2L,3L,2L,3L,4L,4L,4L,5L,6L,5L,6L,6L,4L,5L,6L,6L,3L,4L,4L,5L,6L,5L,4L,5L,6L,6L,7L,5L,5L,6L,6L,7L,8L,4L,5L,5L,4L,5L,6L,5L,5L,6L,4L,5L,6L,6L,7L,6L,6L,7L,4L,5L,6L,6L,6L,7L,8L,6L,7L,7L,6L,7L,6L,7L,8L,8L,9L,4L,4L,5L,6L,6L,4L,5L,5L,6L,7L,6L,6L,7L,8L,7L,8L,8L,4L,5L,6L,4L,4L,5L,4L,5L,6L,6L,7L,7L,6L,7L,7L,8L,9L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268672Inst : IEnumerable<long>
{
public static readonly long[] Value=A268672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268672.Bytes);
public long this[int i]=>Value[i];

public static A268672Inst Instance=new A268672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268673
{
public static readonly long[] Value={ 0L,1L,5L,29L,45L,53L,77L,85L,101L,125L,141L,149L,165L,189L,197L,221L,237L,245L,269L,277L,293L,317L,325L,349L,365L,373L,389L,413L,429L,437L,461L,469L,485L,509L,525L,533L,549L,573L,581L,605L,621L,629L,645L,669L,685L,693L,717L,725L,741L,765L,773L,797L,813L,821L,845L,853L,869L,893L,909L,917L,933L,957L,965L,989L,1005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268673Inst : IEnumerable<long>
{
public static readonly long[] Value=A268673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268673.Bytes);
public long this[int i]=>Value[i];

public static A268673Inst Instance=new A268673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268674
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,5L,1L,4L,3L,7L,2L,11L,5L,6L,1L,13L,4L,17L,3L,8L,7L,19L,2L,9L,11L,10L,5L,23L,6L,29L,1L,12L,13L,15L,4L,31L,17L,14L,3L,37L,8L,41L,7L,16L,19L,43L,2L,25L,9L,18L,11L,47L,10L,21L,5L,20L,23L,53L,6L,59L,29L,22L,1L,27L,12L,61L,13L,24L,15L,67L,4L,71L,31L,26L,17L,35L,14L,73L,3L,28L,37L,79L,8L,33L,41L,30L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268674Inst : IEnumerable<long>
{
public static readonly long[] Value=A268674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268674.Bytes);
public long this[int i]=>Value[i];

public static A268674Inst Instance=new A268674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268675
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,6L,7L,4L,21L,10L,11L,24L,13L,14L,15L,32L,17L,42L,19L,40L,9L,22L,23L,12L,55L,26L,27L,56L,29L,30L,31L,16L,69L,34L,35L,168L,37L,38L,39L,20L,41L,18L,43L,88L,93L,46L,47L,96L,91L,110L,123L,104L,53L,54L,25L,28L,117L,58L,59L,120L,61L,62L,63L,64L,65L,138L,67L,136L,33L,70L,71L,84L,73L,74L,75L,152L,77L,78L,79L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268675Inst : IEnumerable<long>
{
public static readonly long[] Value=A268675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268675.Bytes);
public long this[int i]=>Value[i];

public static A268675Inst Instance=new A268675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268676
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268676Inst : IEnumerable<long>
{
public static readonly long[] Value=A268676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268676.Bytes);
public long this[int i]=>Value[i];

public static A268676Inst Instance=new A268676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268677
{
public static readonly long[] Value={ 2L,6L,9L,10L,12L,13L,14L,17L,21L,24L,25L,28L,29L,30L,33L,35L,38L,39L,43L,44L,45L,46L,49L,51L,54L,55L,58L,61L,62L,63L,67L,68L,71L,73L,76L,77L,78L,79L,80L,84L,85L,88L,91L,94L,95L,96L,97L,99L,100L,103L,107L,110L,111L,112L,114L,115L,118L,122L,125L,126L,128L,129L,130L,133L,137L,140L,141L,143L,144L,145L,146L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268677Inst : IEnumerable<long>
{
public static readonly long[] Value=A268677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268677.Bytes);
public long this[int i]=>Value[i];

public static A268677Inst Instance=new A268677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268678
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,11L,15L,16L,18L,19L,20L,22L,23L,26L,27L,31L,32L,34L,36L,37L,40L,41L,42L,47L,48L,50L,52L,53L,56L,57L,59L,60L,64L,65L,66L,69L,70L,72L,74L,75L,81L,82L,83L,86L,87L,89L,90L,92L,93L,98L,101L,102L,104L,105L,106L,108L,109L,113L,116L,117L,119L,120L,121L,123L,124L,127L,131L,132L,134L,135L,136L,138L,139L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268678Inst : IEnumerable<long>
{
public static readonly long[] Value=A268678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268678.Bytes);
public long this[int i]=>Value[i];

public static A268678Inst Instance=new A268678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268679
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,3L,4L,1L,2L,1L,1L,2L,1L,3L,1L,4L,1L,2L,2L,1L,3L,1L,1L,5L,1L,2L,2L,1L,3L,1L,2L,1L,4L,1L,1L,3L,1L,2L,2L,1L,6L,1L,1L,3L,1L,2L,1L,2L,1L,5L,3L,1L,2L,1L,1L,2L,1L,4L,3L,1L,2L,1L,1L,2L,1L,3L,4L,1L,2L,1L,1L,2L,1L,3L,5L,1L,2L,1L,2L,1L,3L,1L,1L,6L,1L,2L,2L,1L,3L,1L,1L,4L,1L,2L,1L,3L,1L,2L,2L,1L,5L,1L,1L,3L,1L,2L,2L,1L,4L,1L,3L,1L,2L,1L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268679Inst : IEnumerable<long>
{
public static readonly long[] Value=A268679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268679.Bytes);
public long this[int i]=>Value[i];

public static A268679Inst Instance=new A268679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268680
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,6L,6L,6L,7L,7L,7L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,14L,15L,16L,16L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,24L,25L,26L,26L,27L,27L,28L,29L,29L,29L,30L,31L,31L,32L,33L,33L,33L,33L,34L,35L,36L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L,41L,41L,41L,41L,42L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268680Inst : IEnumerable<long>
{
public static readonly long[] Value=A268680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268680.Bytes);
public long this[int i]=>Value[i];

public static A268680Inst Instance=new A268680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268681
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,27L,42L,105L,175L,175L,385L,1408L,1474L,2566L,8677L,15607L,15607L,39934L,39934L,133300L,264305L,559565L,1288392L,5482695L,5493321L,5546451L,11088442L,11088442L,24211552L,88854292L,88854757L,133243378L,133243378L,133243411L,2337205436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268681Inst : IEnumerable<long>
{
public static readonly long[] Value=A268681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268681.Bytes);
public long this[int i]=>Value[i];

public static A268681Inst Instance=new A268681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268682
{
public static readonly long[] Value={ 2L,9L,2L,8L,9L,3L,2L,1L,8L,8L,1L,3L,4L,5L,2L,4L,7L,5L,5L,9L,9L,1L,5L,5L,6L,3L,7L,8L,9L,5L,1L,5L,0L,9L,6L,0L,7L,1L,5L,1L,6L,4L,0L,6L,2L,3L,1L,1L,5L,2L,5L,9L,6L,3L,4L,1L,1L,6L,6L,0L,1L,3L,1L,0L,0L,4L,6L,3L,3L,7L,6L,0L,7L,6L,8L,9L,4L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268682Inst : IEnumerable<long>
{
public static readonly long[] Value=A268682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268682.Bytes);
public long this[int i]=>Value[i];

public static A268682Inst Instance=new A268682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268683
{
public static readonly long[] Value={ 2L,0L,7L,1L,0L,6L,7L,8L,1L,1L,8L,6L,5L,4L,7L,5L,2L,4L,4L,0L,0L,8L,4L,4L,3L,6L,2L,1L,0L,4L,8L,4L,9L,0L,3L,9L,2L,8L,4L,8L,3L,5L,9L,3L,7L,6L,8L,8L,4L,7L,4L,0L,3L,6L,5L,8L,8L,3L,3L,9L,8L,6L,8L,9L,9L,5L,3L,6L,6L,2L,3L,9L,2L,3L,1L,0L,5L,3L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268683Inst : IEnumerable<long>
{
public static readonly long[] Value=A268683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268683.Bytes);
public long this[int i]=>Value[i];

public static A268683Inst Instance=new A268683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268684
{
public static readonly long[] Value={ 0L,2L,14L,44L,100L,190L,322L,504L,744L,1050L,1430L,1892L,2444L,3094L,3850L,4720L,5712L,6834L,8094L,9500L,11060L,12782L,14674L,16744L,19000L,21450L,24102L,26964L,30044L,33350L,36890L,40672L,44704L,48994L,53550L,58380L,63492L,68894L,74594L,80600L,86920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268684Inst : IEnumerable<long>
{
public static readonly long[] Value=A268684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268684.Bytes);
public long this[int i]=>Value[i];

public static A268684Inst Instance=new A268684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268685
{
public static readonly long[] Value={ 6L,126L,630L,1950L,4680L,9576L,17556L,29700L,47250L,71610L,104346L,147186L,202020L,270900L,356040L,459816L,584766L,733590L,909150L,1114470L,1352736L,1627296L,1941660L,2299500L,2704650L,3161106L,3673026L,4244730L,4880700L,5585580L,6364176L,7221456L,8162550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268685Inst : IEnumerable<long>
{
public static readonly long[] Value=A268685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268685.Bytes);
public long this[int i]=>Value[i];

public static A268685Inst Instance=new A268685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268686
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,2L,2L,2L,2L,0L,2L,3L,1L,3L,3L,1L,2L,4L,2L,4L,4L,4L,2L,3L,4L,3L,3L,5L,5L,5L,4L,5L,4L,5L,3L,5L,5L,6L,4L,4L,7L,3L,6L,7L,6L,7L,5L,4L,5L,4L,6L,8L,7L,7L,7L,7L,3L,8L,9L,8L,5L,9L,5L,7L,8L,4L,8L,8L,10L,8L,6L,6L,10L,9L,9L,6L,7L,6L,9L,9L,9L,8L,8L,12L,13L,8L,10L,12L,11L,12L,10L,11L,8L,12L,12L,12L,10L,9L,13L,8L,10L,13L,8L,9L,10L,10L,11L,12L,13L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268686Inst : IEnumerable<long>
{
public static readonly long[] Value=A268686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268686.Bytes);
public long this[int i]=>Value[i];

public static A268686Inst Instance=new A268686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268687
{
public static readonly long[] Value={ 0L,1L,2L,3L,11L,31L,191L,1023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268687Inst : IEnumerable<long>
{
public static readonly long[] Value=A268687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268687.Bytes);
public long this[int i]=>Value[i];

public static A268687Inst Instance=new A268687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268688
{
public static readonly long[] Value={ 0L,0L,1L,2L,10L,30L,190L,1022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268688Inst : IEnumerable<long>
{
public static readonly long[] Value=A268688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268688.Bytes);
public long this[int i]=>Value[i];

public static A268688Inst Instance=new A268688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268689
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,14L,94L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268689Inst : IEnumerable<long>
{
public static readonly long[] Value=A268689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268689.Bytes);
public long this[int i]=>Value[i];

public static A268689Inst Instance=new A268689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268690
{
public static readonly long[] Value={ 1L,5L,3L,2L,10L,50L,25L,13L,7L,4L,20L,100L,500L,250L,125L,63L,32L,16L,8L,40L,200L,1000L,5000L,2500L,1250L,625L,313L,157L,79L,395L,198L,99L,495L,248L,124L,62L,31L,155L,78L,39L,195L,98L,49L,245L,123L,615L,308L,154L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268690Inst : IEnumerable<long>
{
public static readonly long[] Value=A268690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268690.Bytes);
public long this[int i]=>Value[i];

public static A268690Inst Instance=new A268690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268691
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,12L,24L,48L,96L,180L,360L,720L,1440L,2820L,5640L,11280L,22560L,44760L,89520L,179040L,358080L,713760L,1427520L,2855040L,5710080L,11403060L,22806120L,45612240L,91224480L,182321460L,364642920L,729285840L,1458571680L,2916160800L,5832321600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268691Inst : IEnumerable<long>
{
public static readonly long[] Value=A268691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268691.Bytes);
public long this[int i]=>Value[i];

public static A268691Inst Instance=new A268691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268692
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,13L,19L,45L,46L,58L,141L,271L,336L,562L,601L,1128L,1635L,2718L,2920L,3933L,4351L,4729L,6556L,8349L,10851L,32641L,34039L,41050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268692Inst : IEnumerable<long>
{
public static readonly long[] Value=A268692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268692.Bytes);
public long this[int i]=>Value[i];

public static A268692Inst Instance=new A268692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268693
{
public static readonly long[] Value={ 1L,3L,5L,7L,255L,15045L,20655L,25755L,39525L,44115L,46665L,65535L,70125L,97155L,100215L,132855L,144465L,162945L,196605L,200175L,277695L,280755L,327675L,441915L,469965L,548505L,688245L,720375L,770355L,773925L,789225L,1017705L,1027395L,1110015L,1114095L,1127355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268693Inst : IEnumerable<long>
{
public static readonly long[] Value=A268693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268693.Bytes);
public long this[int i]=>Value[i];

public static A268693Inst Instance=new A268693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268694
{
public static readonly long[] Value={ 1L,3L,5L,7L,144465L,4330455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268694Inst : IEnumerable<long>
{
public static readonly long[] Value=A268694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268694.Bytes);
public long this[int i]=>Value[i];

public static A268694Inst Instance=new A268694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268695
{
public static readonly long[] Value={ 1L,3L,5L,255L,65535L,196605L,327675L,5177265L,29687355L,32046615L,81328935L,109246845L,121436355L,129955905L,139392945L,193000575L,194704485L,228258405L,252375285L,363260505L,371911125L,404678625L,435611145L,491446965L,523821255L,528670845L,535879695L,560914065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268695Inst : IEnumerable<long>
{
public static readonly long[] Value=A268695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268695.Bytes);
public long this[int i]=>Value[i];

public static A268695Inst Instance=new A268695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268696
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,0L,1L,2L,1L,3L,0L,2L,1L,3L,1L,4L,0L,2L,2L,2L,3L,1L,4L,1L,5L,0L,3L,2L,3L,2L,4L,1L,5L,1L,6L,0L,3L,3L,3L,4L,2L,4L,2L,5L,1L,6L,1L,7L,0L,4L,3L,4L,3L,5L,2L,5L,2L,6L,1L,7L,1L,8L,0L,4L,4L,4L,5L,3L,5L,3L,6L,2L,6L,2L,7L,1L,8L,1L,9L,0L,5L,4L,5L,4L,6L,3L,6L,3L,7L,2L,7L,2L,8L,1L,9L,1L,10L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268696Inst : IEnumerable<long>
{
public static readonly long[] Value=A268696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268696.Bytes);
public long this[int i]=>Value[i];

public static A268696Inst Instance=new A268696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268697
{
public static readonly long[] Value={ 30L,42L,102L,462L,2130L,2802L,3930L,5658L,6198L,6270L,6870L,7458L,7590L,8970L,9042L,9858L,10302L,11490L,11778L,13710L,13722L,13998L,14322L,17490L,17790L,18042L,19470L,20478L,22278L,22962L,23910L,25998L,29670L,30390L,31722L,32190L,32370L,32610L,32802L,32910L,33330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268697Inst : IEnumerable<long>
{
public static readonly long[] Value=A268697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268697.Bytes);
public long this[int i]=>Value[i];

public static A268697Inst Instance=new A268697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268698
{
public static readonly long[] Value={ 1L,1L,2L,4L,13L,36L,157L,554L,2800L,12530L,70772L,362188L,2370564L,13658713L,95366064L,642861687L,4774830263L,34769374156L,288999332899L,2255537559077L,19693313843687L,172690825379198L,1572921138465599L,14538979953843188L,145980379536597239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268698Inst : IEnumerable<long>
{
public static readonly long[] Value=A268698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268698.Bytes);
public long this[int i]=>Value[i];

public static A268698Inst Instance=new A268698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268699
{
public static readonly ulong[] Value={ 1L,1L,2L,6L,22L,95L,471L,2618L,16052L,107313L,775045L,6002106L,49536510L,433485429L,4004680967L,38912323570L,396393445096L,4221367056961L,46878865762185L,541660919690866L,6498811587848690L,80818650742133717L,1040037672241415947L,13829246515918840106UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268699Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A268699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268699.Bytes);
public ulong this[int i]=>Value[i];

public static A268699Inst Instance=new A268699Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268700
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,14L,46L,111L,330L,1614L,7348L,21340L,98145L,379405L,2633085L,14871033L,57284558L,278927415L,1609313975L,8289565670L,74945364815L,522977754235L,2403799401259L,14180489136597L,83964652635668L,623008803758260L,3918144764978718L,46950727351392315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268700Inst : IEnumerable<long>
{
public static readonly long[] Value=A268700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268700.Bytes);
public long this[int i]=>Value[i];

public static A268700Inst Instance=new A268700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268701
{
public static readonly long[] Value={ 1L,1L,1L,5L,7L,27L,195L,421L,1619L,8675L,105757L,274029L,1402193L,6625987L,55349787L,975068069L,3137395939L,17960895375L,101880880461L,696011551909L,7596647200175L,197122787505191L,723879298052695L,4905597865756059L,29537689035766501L,227793692735075911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268701Inst : IEnumerable<long>
{
public static readonly long[] Value=A268701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268701.Bytes);
public long this[int i]=>Value[i];

public static A268701Inst Instance=new A268701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268702
{
public static readonly ulong[] Value={ 7L,71L,911L,8111L,16111L,911111L,1171111L,71111111L,131111111L,1711111111L,31111111111L,311111111111L,5111111111111L,41111111111111L,111151111111111L,5111111111111111L,11111611111111111L,191111111111111111L,2111111111111111111L,11111111611111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268702Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A268702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268702.Bytes);
public ulong this[int i]=>Value[i];

public static A268702Inst Instance=new A268702Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268703
{
public static readonly BigInteger[] Value={ 2L,13L,233L,2333L,23333L,313333L,3233333L,31333333L,333233333L,3233333333L,23333333333L,333313333333L,3333333333383L,33133333333333L,323333333333333L,1333333333333333L,23333333333333333L,333333133333333333L,3333313333333333333L,BigInteger.Parse("33313333333333333333") };
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
public class A268703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268703Inst Instance=new A268703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268704
{
public static readonly BigInteger[] Value={ 7L,83L,733L,7333L,38333L,733333L,3733333L,83333333L,373333333L,3334333333L,38333333333L,383333333333L,3433333333333L,53333333333333L,383333333333333L,3733333333333333L,43333333333333333L,353333333333333333L,3333334333333333333L,BigInteger.Parse("33343333333333333333") };
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
public class A268704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268704Inst Instance=new A268704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268705
{
public static readonly BigInteger[] Value={ 2L,17L,277L,1777L,47777L,727777L,7477777L,77767777L,577777777L,1777777777L,67777777777L,377777777777L,7177777777777L,17777777777777L,577777777777777L,2777777777777777L,77777767777777777L,377777777777777777L,2777777777777777777L,BigInteger.Parse("71777777777777777777") };
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
public class A268705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268705Inst Instance=new A268705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268706
{
public static readonly BigInteger[] Value={ 7L,97L,977L,7877L,97777L,787777L,7877777L,77777747L,787777777L,8777777777L,79777777777L,777777779777L,7877777777777L,77777779777777L,778777777777777L,8777777777777777L,77797777777777777L,797777777777777777L,7777877777777777777L,BigInteger.Parse("97777777777777777777") };
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
public class A268706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268706Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268706.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268706.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268706Inst Instance=new A268706Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268707
{
public static readonly BigInteger[] Value={ 2L,19L,199L,1999L,49999L,199999L,2999999L,19999999L,799999999L,9199999999L,59999999999L,959999999999L,9919999999999L,59999999999999L,499999999999999L,9299999999999999L,99919999999999999L,994999999999999999L,9991999999999999999UL,BigInteger.Parse("29999999999999999999") };
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
public class A268707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268707.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268707Inst Instance=new A268707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268708
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268708Inst : IEnumerable<long>
{
public static readonly long[] Value=A268708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268708.Bytes);
public long this[int i]=>Value[i];

public static A268708Inst Instance=new A268708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268709
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,9L,15L,25L,40L,75L,134L,246L,428L,802L,1453L,2643L,4587L,8851L,16849L,32368L,60503L,117343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268709Inst : IEnumerable<long>
{
public static readonly long[] Value=A268709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268709.Bytes);
public long this[int i]=>Value[i];

public static A268709Inst Instance=new A268709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268710
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,15L,25L,41L,75L,134L,246L,428L,802L,1454L,2643L,4588L,8851L,16849L,32368L,60504L,117343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268710Inst : IEnumerable<long>
{
public static readonly long[] Value=A268710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268710.Bytes);
public long this[int i]=>Value[i];

public static A268710Inst Instance=new A268710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268711
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,11L,15L,6L,10L,9L,14L,8L,22L,23L,31L,30L,13L,21L,19L,12L,29L,17L,20L,18L,45L,47L,28L,16L,44L,63L,61L,46L,27L,62L,43L,39L,60L,26L,25L,59L,35L,42L,38L,24L,58L,41L,37L,34L,91L,40L,95L,57L,36L,90L,33L,89L,94L,127L,123L,56L,32L,88L,93L,55L,125L,126L,122L,87L,79L,92L,121L,54L,53L,51L,124L,86L,78L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268711Inst : IEnumerable<long>
{
public static readonly long[] Value=A268711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268711.Bytes);
public long this[int i]=>Value[i];

public static A268711Inst Instance=new A268711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268712
{
public static readonly long[] Value={ 1L,2L,3L,6L,4L,9L,5L,13L,11L,10L,7L,21L,18L,12L,8L,29L,23L,25L,20L,24L,19L,14L,15L,45L,40L,39L,34L,28L,22L,17L,16L,62L,56L,49L,42L,54L,48L,44L,37L,51L,47L,43L,36L,30L,26L,33L,27L,95L,87L,84L,75L,80L,74L,73L,65L,61L,53L,46L,41L,38L,32L,35L,31L,129L,120L,115L,108L,100L,93L,88L,82L,112L,105L,99L,92L,94L,86L,78L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268712Inst : IEnumerable<long>
{
public static readonly long[] Value=A268712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268712.Bytes);
public long this[int i]=>Value[i];

public static A268712Inst Instance=new A268712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268713
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,13L,14L,44L,50L,84L,134L,220L,234L,253L,254L,764L,1274L,2294L,3822L,8414L,13106L,21742L,30581L,30582L,34678L,56796L,60094L,65020L,65262L,65533L,65534L,196604L,327674L,589814L,983022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268713Inst : IEnumerable<long>
{
public static readonly long[] Value=A268713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268713.Bytes);
public long this[int i]=>Value[i];

public static A268713Inst Instance=new A268713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268714
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,3L,2L,4L,4L,2L,7L,3L,6L,3L,7L,6L,8L,5L,5L,8L,6L,4L,7L,10L,4L,10L,7L,4L,5L,5L,9L,9L,9L,9L,5L,5L,15L,6L,7L,8L,14L,8L,7L,6L,15L,14L,16L,8L,6L,13L,13L,6L,8L,16L,14L,12L,15L,18L,7L,11L,12L,11L,7L,18L,15L,12L,13L,13L,17L,17L,12L,10L,10L,12L,17L,17L,13L,13L,8L,14L,15L,16L,22L,11L,8L,11L,22L,16L,15L,14L,8L,9L,9L,16L,14L,21L,21L,9L,9L,21L,21L,14L,16L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268714Inst : IEnumerable<long>
{
public static readonly long[] Value=A268714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268714.Bytes);
public long this[int i]=>Value[i];

public static A268714Inst Instance=new A268714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268715
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,2L,3L,6L,6L,3L,4L,2L,5L,2L,4L,5L,12L,7L,7L,12L,5L,6L,4L,15L,6L,15L,4L,6L,7L,7L,13L,13L,13L,13L,7L,7L,8L,5L,4L,12L,9L,12L,4L,5L,8L,9L,24L,12L,5L,11L,11L,5L,12L,24L,9L,10L,8L,27L,4L,14L,10L,14L,4L,27L,8L,10L,11L,11L,25L,25L,10L,15L,15L,10L,25L,25L,11L,11L,12L,9L,8L,24L,29L,14L,12L,14L,29L,24L,8L,9L,12L,13L,13L,24L,9L,31L,31L,13L,13L,31L,31L,9L,24L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268715Inst : IEnumerable<long>
{
public static readonly long[] Value=A268715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268715.Bytes);
public long this[int i]=>Value[i];

public static A268715Inst Instance=new A268715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268716
{
public static readonly long[] Value={ 0L,2L,6L,4L,14L,12L,8L,10L,30L,28L,24L,26L,16L,18L,22L,20L,62L,60L,56L,58L,48L,50L,54L,52L,32L,34L,38L,36L,46L,44L,40L,42L,126L,124L,120L,122L,112L,114L,118L,116L,96L,98L,102L,100L,110L,108L,104L,106L,64L,66L,70L,68L,78L,76L,72L,74L,94L,92L,88L,90L,80L,82L,86L,84L,254L,252L,248L,250L,240L,242L,246L,244L,224L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268716Inst : IEnumerable<long>
{
public static readonly long[] Value=A268716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268716.Bytes);
public long this[int i]=>Value[i];

public static A268716Inst Instance=new A268716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268717
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,12L,4L,7L,5L,24L,8L,11L,9L,13L,15L,10L,14L,48L,16L,19L,17L,21L,23L,18L,22L,25L,27L,30L,26L,20L,28L,31L,29L,96L,32L,35L,33L,37L,39L,34L,38L,41L,43L,46L,42L,36L,44L,47L,45L,49L,51L,54L,50L,60L,52L,55L,53L,40L,56L,59L,57L,61L,63L,58L,62L,192L,64L,67L,65L,69L,71L,66L,70L,73L,75L,78L,74L,68L,76L,79L,77L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268717Inst : IEnumerable<long>
{
public static readonly long[] Value=A268717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268717.Bytes);
public long this[int i]=>Value[i];

public static A268717Inst Instance=new A268717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268718
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,8L,3L,7L,10L,12L,15L,11L,5L,13L,16L,14L,18L,20L,23L,19L,29L,21L,24L,22L,9L,25L,28L,26L,30L,32L,27L,31L,34L,36L,39L,35L,45L,37L,40L,38L,57L,41L,44L,42L,46L,48L,43L,47L,17L,49L,52L,50L,54L,56L,51L,55L,58L,60L,63L,59L,53L,61L,64L,62L,66L,68L,71L,67L,77L,69L,72L,70L,89L,73L,76L,74L,78L,80L,75L,79L,113L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268718Inst : IEnumerable<long>
{
public static readonly long[] Value=A268718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268718.Bytes);
public long this[int i]=>Value[i];

public static A268718Inst Instance=new A268718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268719
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,5L,3L,2L,7L,6L,4L,12L,15L,13L,9L,5L,4L,13L,12L,11L,10L,6L,7L,4L,5L,14L,15L,12L,7L,5L,12L,4L,10L,14L,13L,15L,8L,24L,27L,25L,29L,31L,26L,30L,17L,9L,8L,25L,24L,31L,30L,27L,26L,19L,18L,10L,11L,8L,9L,26L,27L,24L,25L,22L,23L,20L,11L,9L,24L,8L,30L,26L,25L,27L,18L,22L,21L,23L,12L,13L,14L,15L,8L,9L,10L,11L,28L,29L,30L,31L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268719Inst : IEnumerable<long>
{
public static readonly long[] Value=A268719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268719.Bytes);
public long this[int i]=>Value[i];

public static A268719Inst Instance=new A268719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268720
{
public static readonly long[] Value={ 0L,4L,13L,18L,53L,55L,63L,80L,217L,217L,205L,244L,234L,264L,305L,328L,881L,877L,841L,916L,790L,864L,977L,988L,900L,956L,1021L,1070L,1197L,1235L,1267L,1344L,3553L,3541L,3457L,3604L,3310L,3456L,3681L,3684L,3100L,3244L,3453L,3478L,3917L,3931L,3883L,4048L,3528L,3636L,3757L,3850L,4021L,4111L,4199L,4320L,4745L,4817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268720Inst : IEnumerable<long>
{
public static readonly long[] Value=A268720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268720.Bytes);
public long this[int i]=>Value[i];

public static A268720Inst Instance=new A268720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268721
{
public static readonly long[] Value={ 0L,1L,6L,13L,26L,58L,72L,107L,160L,230L,286L,440L,558L,599L,696L,851L,1032L,1298L,1510L,1826L,2122L,2353L,2624L,3294L,3884L,4335L,4870L,5001L,5242L,5722L,6048L,6699L,7424L,8226L,8990L,10166L,11226L,12069L,13048L,14384L,15664L,16885L,18134L,19071L,20094L,21276L,22360L,25150L,27788L,30091L,32582L,34343L,36262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268721Inst : IEnumerable<long>
{
public static readonly long[] Value=A268721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268721.Bytes);
public long this[int i]=>Value[i];

public static A268721Inst Instance=new A268721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268722
{
public static readonly long[] Value={ 0L,2L,13L,5L,31L,27L,10L,8L,59L,63L,54L,52L,20L,22L,49L,17L,115L,119L,126L,124L,108L,110L,121L,105L,40L,42L,37L,45L,103L,99L,34L,32L,227L,231L,238L,236L,252L,254L,233L,249L,216L,218L,213L,221L,247L,243L,210L,208L,80L,82L,93L,85L,79L,75L,90L,88L,203L,207L,198L,196L,68L,70L,193L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268722Inst : IEnumerable<long>
{
public static readonly long[] Value=A268722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268722.Bytes);
public long this[int i]=>Value[i];

public static A268722Inst Instance=new A268722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268723
{
public static readonly long[] Value={ 0L,1L,13L,6L,41L,54L,24L,21L,145L,166L,216L,253L,96L,121L,69L,86L,545L,582L,664L,749L,864L,841L,949L,1014L,384L,433L,477L,486L,793L,278L,344L,357L,2113L,2182L,2328L,2509L,2656L,2793L,2901L,2998L,3456L,3537L,3901L,3366L,3641L,3798L,4056L,3973L,1536L,1633L,1709L,1734L,1801L,1910L,1944L,2037L,3313L,3174L,1112L,1053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268723Inst : IEnumerable<long>
{
public static readonly long[] Value=A268723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268723.Bytes);
public long this[int i]=>Value[i];

public static A268723Inst Instance=new A268723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268724
{
public static readonly long[] Value={ 1L,3L,3L,2L,9L,2L,7L,6L,6L,7L,6L,21L,4L,21L,6L,4L,18L,14L,14L,18L,4L,5L,12L,12L,49L,12L,12L,5L,15L,15L,8L,42L,42L,8L,15L,15L,14L,45L,10L,28L,36L,28L,10L,45L,14L,12L,42L,30L,35L,24L,24L,35L,30L,42L,12L,13L,36L,28L,105L,30L,16L,30L,105L,28L,36L,13L,8L,39L,24L,98L,90L,20L,20L,90L,98L,24L,39L,8L,9L,24L,26L,84L,84L,60L,25L,60L,84L,84L,26L,24L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268724Inst : IEnumerable<long>
{
public static readonly long[] Value=A268724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268724.Bytes);
public long this[int i]=>Value[i];

public static A268724Inst Instance=new A268724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268725
{
public static readonly long[] Value={ 1L,2L,2L,3L,13L,3L,4L,5L,5L,4L,5L,31L,6L,31L,5L,6L,27L,9L,9L,27L,6L,7L,10L,10L,41L,10L,10L,7L,8L,8L,12L,63L,63L,12L,8L,8L,9L,59L,15L,18L,54L,18L,15L,59L,9L,10L,63L,17L,50L,20L,20L,50L,17L,63L,10L,11L,54L,18L,93L,17L,24L,17L,93L,18L,54L,11L,12L,52L,20L,83L,119L,30L,30L,119L,83L,20L,52L,12L,13L,20L,23L,126L,126L,34L,21L,34L,126L,126L,23L,20L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268725Inst : IEnumerable<long>
{
public static readonly long[] Value=A268725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268725.Bytes);
public long this[int i]=>Value[i];

public static A268725Inst Instance=new A268725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268726
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,6L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,7L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,0L,1L,2L,0L,3L,0L,0L,1L,4L,0L,0L,1L,0L,1L,2L,0L,5L,0L,0L,1L,0L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268726Inst : IEnumerable<long>
{
public static readonly long[] Value=A268726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268726.Bytes);
public long this[int i]=>Value[i];

public static A268726Inst Instance=new A268726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268727
{
public static readonly long[] Value={ 1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,7L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,8L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,1L,2L,3L,1L,4L,1L,1L,2L,5L,1L,1L,2L,1L,2L,3L,1L,6L,1L,1L,2L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268727Inst : IEnumerable<long>
{
public static readonly long[] Value=A268727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268727.Bytes);
public long this[int i]=>Value[i];

public static A268727Inst Instance=new A268727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268728
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,7L,0L,0L,0L,4L,3L,0L,1L,0L,13L,3L,0L,2L,0L,0L,14L,0L,0L,0L,0L,1L,0L,11L,1L,0L,2L,4L,0L,1L,0L,8L,1L,0L,1L,7L,7L,2L,1L,0L,25L,0L,0L,1L,0L,0L,7L,0L,0L,0L,26L,3L,0L,6L,15L,5L,4L,0L,0L,1L,0L,31L,3L,0L,0L,10L,3L,13L,4L,0L,2L,1L,0L,28L,0L,0L,6L,0L,2L,14L,0L,6L,0L,0L,1L,0L,21L,1L,0L,1L,26L,7L,11L,4L,12L,0L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268728Inst : IEnumerable<long>
{
public static readonly long[] Value=A268728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268728.Bytes);
public long this[int i]=>Value[i];

public static A268728Inst Instance=new A268728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268729
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,0L,0L,0L,7L,0L,1L,0L,3L,4L,0L,0L,2L,0L,3L,13L,0L,1L,0L,0L,0L,0L,14L,0L,1L,0L,4L,2L,0L,1L,11L,0L,1L,2L,7L,7L,1L,0L,1L,8L,0L,0L,0L,7L,0L,0L,1L,0L,0L,25L,0L,1L,0L,0L,4L,5L,15L,6L,0L,3L,26L,0L,1L,2L,0L,4L,13L,3L,10L,0L,0L,3L,31L,0L,1L,0L,0L,6L,0L,14L,2L,0L,6L,0L,0L,28L,0L,0L,0L,3L,0L,12L,4L,11L,7L,26L,1L,0L,1L,21L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268729Inst : IEnumerable<long>
{
public static readonly long[] Value=A268729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268729.Bytes);
public long this[int i]=>Value[i];

public static A268729Inst Instance=new A268729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268730
{
public static readonly BigInteger[] Value={ 10L,260L,10920L,633360L,46868640L,4218177600L,447126825600L,54549472723200L,7527827235801600L,1159285394313446400L,BigInteger.Parse("197078517033285888000"),BigInteger.Parse("36656604168191175168000"),BigInteger.Parse("7404634041974617383936000"),BigInteger.Parse("1614210221150466589698048000"),BigInteger.Parse("377725191749209181989343232000") };
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
public class A268730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268730.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268730Inst Instance=new A268730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268731
{
public static readonly long[] Value={ 1L,6L,1L,1L,1L,1L,1L,18L,1L,6L,1L,1L,16L,16L,1L,1L,1L,1L,6L,6L,1L,1L,1L,22L,1L,3L,1L,1L,1L,13L,1L,6L,6L,6L,6L,6L,6L,16L,1L,108L,1L,28L,1L,1L,1L,6L,2L,1L,1L,1L,2L,2L,6L,6L,18L,1L,18L,1L,18L,18L,53L,53L,1L,3L,3L,3L,6L,6L,6L,16L,2L,22L,2L,6L,2L,2L,6L,6L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268731Inst : IEnumerable<long>
{
public static readonly long[] Value=A268731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268731.Bytes);
public long this[int i]=>Value[i];

public static A268731Inst Instance=new A268731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268732
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,23L,27L,31L,33L,41L,43L,47L,51L,60L,62L,70L,72L,80L,84L,88L,90L,102L,106L,110L,116L,124L,126L,134L,136L,148L,152L,156L,160L,176L,178L,182L,186L,198L,200L,208L,210L,218L,226L,230L,232L,250L,254L,262L,266L,274L,276L,288L,292L,304L,308L,312L,314L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268732Inst : IEnumerable<long>
{
public static readonly long[] Value=A268732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268732.Bytes);
public long this[int i]=>Value[i];

public static A268732Inst Instance=new A268732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268733
{
public static readonly long[] Value={ 28L,78L,248L,684L,1862L,3294L,6140L,9144L,16590L,27872L,37734L,59094L,75812L,90864L,121878L,171780L,219542L,257244L,328104L,378362L,432240L,530964L,627570L,785078L,969714L,1071512L,1157004L,1271270L,1366974L,1649024L,2145924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268733Inst : IEnumerable<long>
{
public static readonly long[] Value=A268733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268733.Bytes);
public long this[int i]=>Value[i];

public static A268733Inst Instance=new A268733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268734
{
public static readonly BigInteger[] Value={ 0L,4L,80L,2876L,200204L,29134076L,9039552112L,6084192150856L,8965720251221240L,BigInteger.Parse("29122359898196696856"),BigInteger.Parse("209490003763160695865576"),BigInteger.Parse("3348908247850171650090422060"),BigInteger.Parse("119286836904111393911302107179212") };
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
public class A268734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268734Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268734.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268734.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268734Inst Instance=new A268734Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268735
{
public static readonly long[] Value={ 2L,15L,80L,396L,1788L,7831L,33170L,137868L,563486L,2275119L,9091772L,36031648L,141793168L,554669335L,2158604934L,8363066408L,32273565050L,124112115647L,475807505288L,1819019281732L,6936664653476L,26392068734023L,100206016839642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268735Inst : IEnumerable<long>
{
public static readonly long[] Value=A268735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268735.Bytes);
public long this[int i]=>Value[i];

public static A268735Inst Instance=new A268735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268736
{
public static readonly long[] Value={ 5L,48L,396L,2876L,19591L,128232L,816009L,5087814L,31228804L,189328186L,1136393919L,6764778660L,39991075367L,235019630164L,1374139675314L,7998875575940L,46380134987289L,267999333435856L,1543818690094499L,8868640131544198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268736Inst : IEnumerable<long>
{
public static readonly long[] Value=A268736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268736.Bytes);
public long this[int i]=>Value[i];

public static A268736Inst Instance=new A268736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268737
{
public static readonly long[] Value={ 10L,145L,1788L,19591L,200204L,1971414L,18847982L,176668038L,1629738420L,14851460143L,133983018272L,1198816726867L,10652116047394L,94092052069550L,826903484125628L,7234834159717064L,63053215344757166L,547626807437714177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268737Inst : IEnumerable<long>
{
public static readonly long[] Value=A268737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268737.Bytes);
public long this[int i]=>Value[i];

public static A268737Inst Instance=new A268737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268738
{
public static readonly long[] Value={ 20L,420L,7831L,128232L,1971414L,29134076L,418632185L,5894815754L,81718671716L,1119014223138L,15171181272721L,203998929406004L,2724149465085496L,36163754541884778L,477648079847735215L,6280858615510607492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268738Inst : IEnumerable<long>
{
public static readonly long[] Value=A268738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268738.Bytes);
public long this[int i]=>Value[i];

public static A268738Inst Instance=new A268738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268739
{
public static readonly BigInteger[] Value={ 38L,1183L,33170L,816009L,18847982L,418632185L,9039552112L,191307160577L,3985770068310L,82030747371058L,1671509767296774L,33781019022038039L,678004335124666334L,13528033902348727292UL,BigInteger.Parse("268553181861956273470") };
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
public class A268739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268739Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268739.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268739.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268739Inst Instance=new A268739Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268740
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,2L,5L,15L,15L,5L,10L,48L,80L,48L,10L,20L,145L,396L,396L,145L,20L,38L,420L,1788L,2876L,1788L,420L,38L,71L,1183L,7831L,19591L,19591L,7831L,1183L,71L,130L,3264L,33170L,128232L,200204L,128232L,33170L,3264L,130L,235L,8865L,137868L,816009L,1971414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268740Inst : IEnumerable<long>
{
public static readonly long[] Value=A268740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268740.Bytes);
public long this[int i]=>Value[i];

public static A268740Inst Instance=new A268740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268741
{
public static readonly long[] Value={ 4L,5L,3L,7L,-1L,15L,-17L,47L,-81L,175L,-337L,687L,-1361L,2735L,-5457L,10927L,-21841L,43695L,-87377L,174767L,-349521L,699055L,-1398097L,2796207L,-5592401L,11184815L,-22369617L,44739247L,-89478481L,178956975L,-357913937L,715827887L,-1431655761L,2863311535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268741Inst : IEnumerable<long>
{
public static readonly long[] Value=A268741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268741.Bytes);
public long this[int i]=>Value[i];

public static A268741Inst Instance=new A268741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268742
{
public static readonly long[] Value={ 0L,1L,2L,20L,30L,31L,44L,98L,120L,121L,146L,236L,270L,271L,308L,434L,480L,481L,530L,692L,750L,751L,812L,1010L,1080L,1081L,1154L,1388L,1470L,1471L,1556L,1826L,1920L,1921L,2018L,2324L,2430L,2431L,2540L,2882L,3000L,3001L,3122L,3500L,3630L,3631L,3764L,4178L,4320L,4321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268742Inst : IEnumerable<long>
{
public static readonly long[] Value=A268742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268742.Bytes);
public long this[int i]=>Value[i];

public static A268742Inst Instance=new A268742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268743
{
public static readonly BigInteger[] Value={ 2L,11L,143L,4110L,255651L,34732937L,10319681062L,6744840113811L,9736268648482947L,BigInteger.Parse("31152408949342676906"),BigInteger.Parse("221573405414594347811555"),BigInteger.Parse("3511390061199964238627005057"),BigInteger.Parse("124222798189336185449669887550302") };
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
public class A268743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268743.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268743Inst Instance=new A268743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268744
{
public static readonly long[] Value={ 4L,11L,32L,89L,244L,659L,1760L,4657L,12228L,31899L,82752L,213641L,549236L,1406755L,3591232L,9140833L,23204612L,58765099L,148496608L,374496953L,942729588L,2369172915L,5944748064L,14895231121L,37272007108L,93149401019L,232527917312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268744Inst : IEnumerable<long>
{
public static readonly long[] Value=A268744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268744.Bytes);
public long this[int i]=>Value[i];

public static A268744Inst Instance=new A268744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268745
{
public static readonly long[] Value={ 7L,32L,143L,623L,2615L,10830L,44067L,177429L,707163L,2796840L,10986379L,42911627L,166777091L,645395334L,2488065863L,9559464281L,36618142447L,139888931680L,533099140807L,2027067051095L,7692165427919L,29135580083054L,110168752548843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268745Inst : IEnumerable<long>
{
public static readonly long[] Value=A268745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268745.Bytes);
public long this[int i]=>Value[i];

public static A268745Inst Instance=new A268745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268746
{
public static readonly long[] Value={ 13L,89L,623L,4110L,26334L,165019L,1016807L,6183665L,37209717L,221970102L,1314544140L,7737069617L,45297553803L,263980824665L,1532201345489L,8861529601362L,51088246525260L,293694819166095L,1684057081243885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268746Inst : IEnumerable<long>
{
public static readonly long[] Value=A268746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268746.Bytes);
public long this[int i]=>Value[i];

public static A268746Inst Instance=new A268746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268747
{
public static readonly long[] Value={ 23L,244L,2615L,26334L,255651L,2425799L,22577073L,207252725L,1880654551L,16909709308L,150867667407L,1337324783132L,11788337576943L,103412756868981L,903363696442081L,7862056896605875L,68198486775427551L,589834799847933624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268747Inst : IEnumerable<long>
{
public static readonly long[] Value=A268747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268747.Bytes);
public long this[int i]=>Value[i];

public static A268747Inst Instance=new A268747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268748
{
public static readonly long[] Value={ 41L,659L,10830L,165019L,2425799L,34732937L,487682438L,6746117783L,92215499119L,1248437108837L,16766958502992L,223674635599161L,2966748789292217L,39154974765661223L,514529476985579624L,6735601878829825279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268748Inst : IEnumerable<long>
{
public static readonly long[] Value=A268748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268748.Bytes);
public long this[int i]=>Value[i];

public static A268748Inst Instance=new A268748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268749
{
public static readonly BigInteger[] Value={ 72L,1760L,44067L,1016807L,22577073L,487682438L,10319681062L,215027310572L,4425392044505L,90177748184504L,1822495416470859L,36579128848735042L,729860195814419706L,14489046573912834959UL,BigInteger.Parse("286363070886993749567") };
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
public class A268749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268749.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268749Inst Instance=new A268749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268750
{
public static readonly long[] Value={ 2L,4L,4L,7L,11L,7L,13L,32L,32L,13L,23L,89L,143L,89L,23L,41L,244L,623L,623L,244L,41L,72L,659L,2615L,4110L,2615L,659L,72L,126L,1760L,10830L,26334L,26334L,10830L,1760L,126L,219L,4657L,44067L,165019L,255651L,165019L,44067L,4657L,219L,379L,12228L,177429L,1016807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268750Inst : IEnumerable<long>
{
public static readonly long[] Value=A268750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268750.Bytes);
public long this[int i]=>Value[i];

public static A268750Inst Instance=new A268750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268751
{
public static readonly BigInteger[] Value={ 0L,0L,1L,374L,16140983L,173996758190594L,BigInteger.Parse("791857392420720220446647"),BigInteger.Parse("2285085934263252199073238394141449534"),BigInteger.Parse("5841526335200139692050292842849347521755651331941759"),BigInteger.Parse("17585875137049122003330684747231440185032966840579881629527695901745706") };
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
public class A268751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268751.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268751Inst Instance=new A268751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268752
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,20L,26L,36L,66L,74L,84L,90L,94L,110L,116L,124L,126L,130L,134L,146L,150L,156L,170L,180L,204L,206L,210L,230L,236L,260L,284L,300L,306L,314L,326L,340L,350L,386L,396L,406L,420L,430L,436L,444L,466L,470L,474L,490L,556L,570L,634L,636L,644L,646L,654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268752Inst : IEnumerable<long>
{
public static readonly long[] Value=A268752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268752.Bytes);
public long this[int i]=>Value[i];

public static A268752Inst Instance=new A268752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268753
{
public static readonly long[] Value={ 53L,79L,131L,157L,313L,443L,521L,547L,599L,677L,859L,911L,937L,1093L,1171L,1223L,1249L,1301L,1327L,1483L,1613L,1847L,1873L,1951L,2003L,2029L,2081L,2237L,2341L,2393L,2549L,2731L,2861L,2887L,2939L,3121L,3251L,3329L,3407L,3433L,3511L,3719L,3797L,3823L,4057L,4421L,4447L,4603L,4733L,4759L,4889L,4967L,4993L,5227L,5279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268753Inst : IEnumerable<long>
{
public static readonly long[] Value=A268753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268753.Bytes);
public long this[int i]=>Value[i];

public static A268753Inst Instance=new A268753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268754
{
public static readonly long[] Value={ 1L,2L,1L,6L,4L,14L,1L,14L,12L,62L,8L,126L,28L,30L,1L,30L,28L,1022L,24L,126L,124L,4094L,16L,2046L,252L,1022L,56L,32766L,60L,62L,1L,62L,60L,8190L,56L,174762L,2044L,8190L,48L,2046L,252L,254L,248L,8190L,8188L,16777214L,32L,4194302L,4092L,510L,504L,134217726L,2044L,2097150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268754Inst : IEnumerable<long>
{
public static readonly long[] Value=A268754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268754.Bytes);
public long this[int i]=>Value[i];

public static A268754Inst Instance=new A268754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268755
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,2L,2L,1L,3L,0L,4L,0L,2L,5L,0L,3L,5L,3L,2L,4L,5L,4L,2L,3L,4L,3L,2L,3L,2L,2L,1L,6L,0L,7L,0L,2L,5L,8L,0L,4L,9L,0L,3L,10L,0L,3L,3L,1L,11L,0L,4L,7L,11L,4L,3L,6L,12L,0L,7L,7L,1L,8L,11L,9L,11L,2L,13L,0L,8L,6L,10L,13L,5L,14L,0L,7L,12L,13L,6L,8L,9L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268755Inst : IEnumerable<long>
{
public static readonly long[] Value=A268755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268755.Bytes);
public long this[int i]=>Value[i];

public static A268755Inst Instance=new A268755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268756
{
public static readonly long[] Value={ 1L,5L,9L,17L,21L,35L,39L,53L,61L,75L,79L,107L,111L,125L,139L,160L,164L,192L,196L,224L,238L,252L,256L,304L,312L,326L,340L,368L,372L,418L,422L,452L,466L,480L,494L,550L,554L,568L,582L,630L,634L,680L,684L,712L,740L,754L,758L,830L,838L,866L,880L,908L,912L,960L,974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268756Inst : IEnumerable<long>
{
public static readonly long[] Value=A268756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268756.Bytes);
public long this[int i]=>Value[i];

public static A268756Inst Instance=new A268756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268757
{
public static readonly long[] Value={ 16L,4104L,119824488L,74213505639000L,6123582409620312000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268757Inst : IEnumerable<long>
{
public static readonly long[] Value=A268757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268757.Bytes);
public long this[int i]=>Value[i];

public static A268757Inst Instance=new A268757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268758
{
public static readonly long[] Value={ 1L,3L,17L,163L,2753L,84731L,4879497L,535376723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268758Inst : IEnumerable<long>
{
public static readonly long[] Value=A268758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268758.Bytes);
public long this[int i]=>Value[i];

public static A268758Inst Instance=new A268758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268759
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,3L,3L,0L,0L,6L,9L,6L,0L,0L,10L,18L,18L,10L,0L,0L,15L,30L,36L,30L,15L,0L,0L,21L,45L,60L,60L,45L,21L,0L,0L,28L,63L,90L,100L,90L,63L,28L,0L,0L,36L,84L,126L,150L,150L,126L,84L,36L,0L,0L,45L,108L,168L,210L,225L,210L,168L,108L,45L,0L,0L,55L,135L,216L,280L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268759Inst : IEnumerable<long>
{
public static readonly long[] Value=A268759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268759.Bytes);
public long this[int i]=>Value[i];

public static A268759Inst Instance=new A268759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268760
{
public static readonly BigInteger[] Value={ 0L,6L,56L,1148L,32056L,1552272L,127676872L,18045771274L,4495138018796L,1955829240647962L,1511334747222697904L,BigInteger.Parse("2064152526111916503300"),BigInteger.Parse("5022957354228609008158500"),BigInteger.Parse("21748481726801956896608976098") };
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
public class A268760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268760Inst Instance=new A268760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268761
{
public static readonly long[] Value={ 2L,15L,56L,223L,762L,2607L,8500L,27411L,86622L,270955L,838224L,2573015L,7841538L,23759463L,71619436L,214933915L,642504870L,1914023267L,5684288136L,16834582623L,49732758858L,146587890015L,431177727396L,1265883329827L,3710027613934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268761Inst : IEnumerable<long>
{
public static readonly long[] Value=A268761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268761.Bytes);
public long this[int i]=>Value[i];

public static A268761Inst Instance=new A268761Inst();

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