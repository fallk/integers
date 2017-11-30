using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244482
{
public static readonly long[] Value={ 0L,3L,3L,3L,6L,6L,9L,12L,12L,12L,12L,12L,12L,15L,18L,21L,21L,24L,27L,27L,30L,30L,33L,36L,39L,42L,45L,45L,48L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,51L,54L,54L,57L,60L,63L,66L,69L,69L,72L,75L,78L,81L,84L,84L,87L,90L,90L,93L,93L,96L,99L,102L,105L,108L,108L,111L,114L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244482Inst : IEnumerable<long>
{
public static readonly long[] Value=A244482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244482.Bytes);
public long this[int i]=>Value[i];

public static A244482Inst Instance=new A244482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244483
{
public static readonly long[] Value={ 3L,1L,0L,3L,3L,4L,2L,4L,6L,3L,2L,8L,9L,6L,7L,8L,8L,10L,10L,10L,9L,11L,10L,11L,18L,11L,9L,17L,12L,10L,18L,19L,18L,16L,17L,20L,18L,18L,20L,20L,20L,19L,19L,21L,21L,21L,29L,28L,20L,22L,29L,28L,22L,29L,36L,28L,27L,27L,28L,36L,29L,30L,38L,37L,27L,27L,38L,32L,32L,38L,37L,35L,34L,38L,40L,37L,37L,40L,38L,38L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244483Inst : IEnumerable<long>
{
public static readonly long[] Value=A244483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244483.Bytes);
public long this[int i]=>Value[i];

public static A244483Inst Instance=new A244483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244484
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,20L,52L,61L,165L,152L,482L,414L,1378L,1024L,3780L,2627L,10187L,6422L,26796L,15906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244484Inst : IEnumerable<long>
{
public static readonly long[] Value=A244484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244484.Bytes);
public long this[int i]=>Value[i];

public static A244484Inst Instance=new A244484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244485
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,70L,230L,676L,2456L,7916L,31374L,109856L,467716L,1759422L,7968204L,31922840L,152664200L,646888154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244485Inst : IEnumerable<long>
{
public static readonly long[] Value=A244485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244485.Bytes);
public long this[int i]=>Value[i];

public static A244485Inst Instance=new A244485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244486
{
public static readonly long[] Value={ 1L,2L,2L,6L,6L,14L,15L,37L,27L,88L,70L,212L,136L,494L,323L,1149L,651L,2632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244486Inst : IEnumerable<long>
{
public static readonly long[] Value=A244486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244486.Bytes);
public long this[int i]=>Value[i];

public static A244486Inst Instance=new A244486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244487
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,12L,22L,21L,28L,50L,117L,94L,262L,211L,609L,411L,1367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244487Inst : IEnumerable<long>
{
public static readonly long[] Value=A244487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244487.Bytes);
public long this[int i]=>Value[i];

public static A244487Inst Instance=new A244487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244488
{
public static readonly long[] Value={ 1L,0L,2L,4L,7L,10L,16L,22L,31L,40L,54L,66L,85L,102L,126L,150L,179L,208L,246L,282L,327L,370L,424L,476L,539L,600L,672L,744L,827L,908L,1004L,1096L,1203L,1308L,1428L,1546L,1679L,1810L,1958L,2104L,2267L,2426L,2606L,2782L,2977L,3170L,3382L,3592L,3823L,4050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244488Inst : IEnumerable<long>
{
public static readonly long[] Value=A244488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244488.Bytes);
public long this[int i]=>Value[i];

public static A244488Inst Instance=new A244488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244489
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,6L,15L,37L,31L,10L,52L,151L,160L,75L,15L,203L,674L,856L,520L,155L,21L,877L,3263L,4802L,3556L,1400L,287L,28L,4140L,17007L,28337L,24626L,11991L,3290L,490L,36L,21147L,94828L,175896L,174805L,101031L,34671L,6972L,786L,45L,115975L,562595L,1146931L,1279240L,853315L,350889L,88977L,13620L,1200L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244489Inst : IEnumerable<long>
{
public static readonly long[] Value=A244489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244489.Bytes);
public long this[int i]=>Value[i];

public static A244489Inst Instance=new A244489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244490
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,8L,18L,1L,4L,15L,52L,163L,1L,5L,24L,110L,478L,1950L,1L,6L,35L,198L,1083L,5706L,28821L,1L,7L,48L,322L,2110L,13482L,83824L,505876L,1L,8L,63L,488L,3715L,27768L,203569L,1461944L,10270569L,1L,9L,80L,702L,6078L,51894L,436656L,3618540L,29510268L,236644092L,1L,10L,99L,970L,9403L,90150L,854485L,8003950L,74058105L,676549450L,6098971555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244490Inst : IEnumerable<long>
{
public static readonly long[] Value=A244490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244490.Bytes);
public long this[int i]=>Value[i];

public static A244490Inst Instance=new A244490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244491
{
public static readonly BigInteger[] Value={ 1L,1L,3L,20L,201L,2604L,40915L,754368L,15960945L,381141008L,10139372451L,297356237760L,9530800099513L,331453265976000L,12430323314648499L,500046099516905984L,BigInteger.Parse("21478615942550889825"),BigInteger.Parse("981110493372418629888"),BigInteger.Parse("47489191763845877910595") };
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
public class A244491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244491.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244491Inst Instance=new A244491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244492
{
public static readonly long[] Value={ 1L,0L,3L,3L,0L,6L,0L,15L,0L,10L,15L,0L,45L,0L,15L,0L,105L,0L,105L,0L,21L,105L,0L,420L,0L,210L,0L,28L,0L,945L,0L,1260L,0L,378L,0L,36L,945L,0L,4725L,0L,3150L,0L,630L,0L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244492Inst : IEnumerable<long>
{
public static readonly long[] Value=A244492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244492.Bytes);
public long this[int i]=>Value[i];

public static A244492Inst Instance=new A244492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244493
{
public static readonly BigInteger[] Value={ 1L,6L,265L,126140L,855966441L,102526835994056L,BigInteger.Parse("258081861682902430193") };
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
public class A244493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244493Inst Instance=new A244493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244494
{
public static readonly BigInteger[] Value={ 2L,6L,70L,870L,36518L,1828134L,300503590L,60273667110L,39431461330982L,31648840352155686L,BigInteger.Parse("82716718794775795750"),BigInteger.Parse("265590372390118027343910"),BigInteger.Parse("2775704953984257023035176998"),BigInteger.Parse("35650312393325457366304103888934"),BigInteger.Parse("1490221075739321877604231759426844710") };
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
public class A244494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244494Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244494.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244494.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244494Inst Instance=new A244494Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244495
{
public static readonly long[] Value={ 1L,34L,451L,3380L,17531L,70466L,235014L,679722L,1757085L,4147792L,9084361L,18683314L,36421463L,67798940L,121239308L,209285436L,350158809L,569759574L,904194895L,1402934104L,2132700691L,3182223374L,4667981330L,6741092150L,9595505205L,13477677876L,18697927509L,25643668006L,34794756655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244495Inst : IEnumerable<long>
{
public static readonly long[] Value=A244495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244495.Bytes);
public long this[int i]=>Value[i];

public static A244495Inst Instance=new A244495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244496
{
public static readonly long[] Value={ 1L,2L,3L,11L,5L,6L,4L,8L,12L,13L,15L,21L,22L,24L,17L,16L,25L,19L,7L,23L,27L,9L,28L,41L,51L,31L,26L,42L,32L,43L,52L,44L,45L,35L,55L,59L,111L,53L,29L,56L,48L,46L,112L,57L,36L,33L,115L,71L,61L,121L,116L,81L,122L,123L,124L,39L,125L,91L,62L,119L,117L,126L,128L,82L,64L,47L,151L,37L,129L,152L,84L,83L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244496Inst : IEnumerable<long>
{
public static readonly long[] Value=A244496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244496.Bytes);
public long this[int i]=>Value[i];

public static A244496Inst Instance=new A244496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244497
{
public static readonly long[] Value={ 1L,11L,57L,197L,533L,1223L,2494L,4654L,8105L,13355L,21031L,31891L,46837L,66927L,93388L,127628L,171249L,226059L,294085L,377585L,479061L,601271L,747242L,920282L,1123993L,1362283L,1639379L,1959839L,2328565L,2750815L,3232216L,3778776L,4396897L,5093387L,5875473L,6750813L,7727509L,8814119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244497Inst : IEnumerable<long>
{
public static readonly long[] Value=A244497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244497.Bytes);
public long this[int i]=>Value[i];

public static A244497Inst Instance=new A244497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244498
{
public static readonly long[] Value={ 1L,36L,446L,3172L,15891L,62408L,204828L,585672L,1501269L,3521452L,7674810L,15723500L,30556903L,56739216L,101252408L,174482832L,291507177L,473741364L,751024438L,1164218484L,1768415099L,2636848984L,3865629780L,5579414360L,7938153405L,11145058236L,15455946546L,21190138876L,28743091407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244498Inst : IEnumerable<long>
{
public static readonly long[] Value=A244498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244498.Bytes);
public long this[int i]=>Value[i];

public static A244498Inst Instance=new A244498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244499
{
public static readonly long[] Value={ 4L,7L,0L,9L,3L,0L,0L,1L,6L,9L,3L,2L,7L,1L,0L,3L,3L,3L,0L,7L,4L,4L,1L,4L,3L,2L,1L,7L,7L,5L,4L,7L,0L,0L,4L,6L,3L,5L,1L,6L,6L,1L,6L,7L,8L,3L,2L,9L,0L,6L,4L,7L,1L,9L,6L,0L,9L,7L,8L,7L,0L,3L,8L,7L,1L,4L,8L,8L,1L,8L,3L,6L,1L,2L,4L,9L,5L,8L,1L,1L,6L,3L,1L,3L,8L,8L,5L,4L,8L,8L,1L,9L,2L,3L,6L,0L,7L,2L,0L,3L,0L,1L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244499Inst : IEnumerable<long>
{
public static readonly long[] Value=A244499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244499.Bytes);
public long this[int i]=>Value[i];

public static A244499Inst Instance=new A244499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244500
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,1L,6L,12L,8L,1L,10L,36L,55L,33L,9L,1L,15L,87L,248L,378L,339L,187L,63L,12L,1L,1L,21L,180L,820L,2190L,3606L,3716L,2340L,825L,125L,1L,28L,333L,2212L,9110L,24474L,43928L,53018L,42774L,22792L,7945L,1764L,196L,1L,36L,567L,5163L,30300L,121077L,339621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244500Inst : IEnumerable<long>
{
public static readonly long[] Value=A244500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244500.Bytes);
public long this[int i]=>Value[i];

public static A244500Inst Instance=new A244500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244501
{
public static readonly long[] Value={ 1L,8L,55L,248L,820L,2212L,5163L,10815L,20833L,37540L,64067L,104518L,164150L,249568L,368935L,532197L,751323L,1040560L,1416703L,1899380L,2511352L,3278828L,4231795L,5404363L,6835125L,8567532L,10650283L,13137730L,16090298L,19574920L,23665487L,28443313L,33997615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244501Inst : IEnumerable<long>
{
public static readonly long[] Value=A244501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244501.Bytes);
public long this[int i]=>Value[i];

public static A244501Inst Instance=new A244501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244502
{
public static readonly long[] Value={ 33L,378L,2190L,9110L,30300L,85563L,213293L,482085L,1006950L,1971185L,3655053L,6472533L,11017505L,18120840L,28919970L,44942618L,68206473L,101336700L,147703280L,211580280L,298329258L,414609113L,568614795L,770347395L,1031918240L,1367889723L,1795655703L,2335864415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244502Inst : IEnumerable<long>
{
public static readonly long[] Value=A244502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244502.Bytes);
public long this[int i]=>Value[i];

public static A244502Inst Instance=new A244502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244503
{
public static readonly long[] Value={ 9L,339L,3606L,24474L,121077L,475353L,1568712L,4524540L,11722134L,27828138L,61442460L,127616970L,251577939L,474068124L,858822579L,1502804622L,2549955858L,4209357693L,6778862319L,10675429650L,16473604089L,24953782251L,37162160802L,54484513344L,78736227726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244503Inst : IEnumerable<long>
{
public static readonly long[] Value=A244503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244503.Bytes);
public long this[int i]=>Value[i];

public static A244503Inst Instance=new A244503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244504
{
public static readonly long[] Value={ 3L,9L,24L,51L,102L,177L,294L,459L,690L,987L,1380L,1875L,2508L,3279L,4212L,5319L,6648L,8199L,10026L,12141L,14580L,17343L,20496L,24051L,28068L,32547L,37542L,43071L,49218L,55983L,63456L,71661L,80658L,90447L,101100L,112635L,125160L,138675L,153252L,168915L,185784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244504Inst : IEnumerable<long>
{
public static readonly long[] Value=A244504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244504.Bytes);
public long this[int i]=>Value[i];

public static A244504Inst Instance=new A244504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244505
{
public static readonly long[] Value={ 19L,139L,619L,859L,1699L,2659L,3259L,4219L,4339L,5419L,5659L,7459L,8539L,9859L,10459L,10939L,11059L,11779L,12379L,13219L,13339L,15139L,15739L,17419L,17659L,19699L,20899L,21019L,21379L,21739L,22699L,23059L,23539L,24979L,25579L,27739L,28099L,30139L,32059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244505Inst : IEnumerable<long>
{
public static readonly long[] Value=A244505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244505.Bytes);
public long this[int i]=>Value[i];

public static A244505Inst Instance=new A244505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244506
{
public static readonly long[] Value={ 1L,9L,196L,6084L,219024L,8450649L,338265664L,13840346025L,574510941225L,24093764931600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244506Inst : IEnumerable<long>
{
public static readonly long[] Value=A244506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244506.Bytes);
public long this[int i]=>Value[i];

public static A244506Inst Instance=new A244506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244507
{
public static readonly long[] Value={ 1L,3L,14L,78L,468L,2907L,18392L,117645L,757965L,4908540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244507Inst : IEnumerable<long>
{
public static readonly long[] Value=A244507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244507.Bytes);
public long this[int i]=>Value[i];

public static A244507Inst Instance=new A244507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244508
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,8L,16L,25L,46L,80L,141L,263L,473L,882L,1628L,3044L,5734L,10779L,20428L,38687L,73653L,140425L,268340L,513866L,986033L,1894409L,3646134L,7027825L,13562625L,26208248L,50698865L,98184467L,190338061L,369326690L,717271793L,1394198586L,2712112561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244508Inst : IEnumerable<long>
{
public static readonly long[] Value=A244508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244508.Bytes);
public long this[int i]=>Value[i];

public static A244508Inst Instance=new A244508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244509
{
public static readonly long[] Value={ 6L,48L,480L,2016L,13200L,26208L,78336L,123120L,267168L,682080L,892800L,1822176L,2755200L,3337488L,4773696L,7738848L,11908560L,13615200L,19845936L,25048800L,28003968L,38450880L,46879728L,62029440L,87607296L,103020000L,111447648L,129843216L,139851360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244509Inst : IEnumerable<long>
{
public static readonly long[] Value=A244509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244509.Bytes);
public long this[int i]=>Value[i];

public static A244509Inst Instance=new A244509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244510
{
public static readonly long[] Value={ 0L,10L,11L,12L,13L,20L,21L,22L,30L,31L,32L,40L,41L,50L,60L,61L,70L,80L,90L,100L,101L,102L,103L,104L,105L,110L,111L,120L,121L,122L,130L,131L,140L,141L,150L,160L,170L,171L,180L,190L,200L,201L,202L,210L,211L,212L,220L,221L,230L,231L,240L,250L,260L,261L,270L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244510Inst : IEnumerable<long>
{
public static readonly long[] Value=A244510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244510.Bytes);
public long this[int i]=>Value[i];

public static A244510Inst Instance=new A244510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244511
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,26L,27L,28L,30L,32L,33L,34L,36L,38L,40L,45L,48L,52L,60L,62L,70L,72L,76L,80L,90L,108L,120L,144L,168L,240L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244511Inst : IEnumerable<long>
{
public static readonly long[] Value=A244511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244511.Bytes);
public long this[int i]=>Value[i];

public static A244511Inst Instance=new A244511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244512
{
public static readonly long[] Value={ 288L,54L,90L,324L,252L,0L,126L,162L,216L,18L,180L,234L,342L,198L,36L,144L,72L,306L,108L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244512Inst : IEnumerable<long>
{
public static readonly long[] Value=A244512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244512.Bytes);
public long this[int i]=>Value[i];

public static A244512Inst Instance=new A244512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244513
{
public static readonly long[] Value={ -1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244513Inst : IEnumerable<long>
{
public static readonly long[] Value=A244513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244513.Bytes);
public long this[int i]=>Value[i];

public static A244513Inst Instance=new A244513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244514
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,11L,22L,33L,44L,55L,66L,77L,88L,99L,111L,222L,333L,444L,486L,555L,648L,666L,777L,864L,888L,999L,1111L,2222L,3333L,4444L,5555L,6666L,7777L,8888L,9999L,11111L,22222L,33333L,44444L,55555L,66666L,77777L,88888L,99999L,111111L,222222L,242424L,333333L,424242L,444444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244514Inst : IEnumerable<long>
{
public static readonly long[] Value=A244514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244514.Bytes);
public long this[int i]=>Value[i];

public static A244514Inst Instance=new A244514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244515
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,1L,4L,2L,6L,4L,9L,6L,16L,9L,23L,18L,34L,27L,51L,40L,75L,63L,103L,90L,152L,130L,208L,191L,286L,267L,402L,368L,546L,518L,730L,709L,998L,954L,1322L,1305L,1751L,1740L,2330L,2299L,3056L,3074L,3968L,4031L,5202L,5249L,6721L,6877L,8642L,8888L,11147L,11432L,14248L,14747L,18097L,18838L,23093L,23938L,29186L,30489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244515Inst : IEnumerable<long>
{
public static readonly long[] Value=A244515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244515.Bytes);
public long this[int i]=>Value[i];

public static A244515Inst Instance=new A244515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244516
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,2L,1L,2L,3L,3L,2L,7L,3L,5L,9L,8L,7L,16L,12L,17L,23L,23L,25L,42L,33L,43L,59L,61L,59L,95L,85L,104L,128L,137L,148L,207L,189L,233L,283L,307L,320L,430L,424L,498L,584L,634L,686L,872L,864L,1011L,1177L,1280L,1365L,1687L,1736L,1987L,2258L,2470L,2674L,3208L,3303L,3767L,4277L,4658L,5014L,5916L,6201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244516Inst : IEnumerable<long>
{
public static readonly long[] Value=A244516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244516.Bytes);
public long this[int i]=>Value[i];

public static A244516Inst Instance=new A244516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244517
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,1L,2L,1L,4L,2L,3L,3L,6L,3L,6L,4L,10L,6L,10L,7L,19L,13L,17L,16L,31L,22L,34L,28L,48L,39L,54L,49L,76L,62L,84L,79L,120L,96L,133L,124L,179L,162L,202L,193L,275L,249L,315L,300L,412L,379L,480L,467L,603L,577L,711L,696L,905L,850L,1035L,1038L,1307L,1258L,1509L,1511L,1864L,1834L,2185L,2171L,2673L,2636L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244517Inst : IEnumerable<long>
{
public static readonly long[] Value=A244517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244517.Bytes);
public long this[int i]=>Value[i];

public static A244517Inst Instance=new A244517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244518
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,2L,1L,2L,3L,3L,2L,4L,2L,6L,4L,5L,4L,7L,7L,8L,8L,10L,11L,18L,13L,19L,19L,22L,29L,32L,29L,37L,37L,53L,48L,60L,54L,68L,79L,84L,86L,104L,99L,133L,125L,149L,151L,183L,191L,219L,223L,259L,268L,335L,320L,377L,391L,448L,487L,547L,552L,640L,666L,781L,795L,908L,923L,1057L,1139L,1246L,1312L,1472L,1508L,1754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244518Inst : IEnumerable<long>
{
public static readonly long[] Value=A244518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244518.Bytes);
public long this[int i]=>Value[i];

public static A244518Inst Instance=new A244518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244519
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,35L,76L,175L,414L,1009L,2510L,6382L,16448L,42961L,113352L,301715L,808932L,2182739L,5921803L,16143975L,44199809L,121477237L,335015538L,926814691L,2571322157L,7152404733L,19942874638L,55729271645L,156051344975L,437801148097L,1230423785329L,3463777894236L,9766002585763L,27574869734583L,77965430442158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244519Inst : IEnumerable<long>
{
public static readonly long[] Value=A244519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244519.Bytes);
public long this[int i]=>Value[i];

public static A244519Inst Instance=new A244519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244520
{
public static readonly long[] Value={ 1L,3L,5L,11L,15L,21L,29L,35L,39L,41L,51L,65L,95L,105L,155L,165L,179L,191L,221L,231L,239L,281L,329L,371L,419L,431L,485L,519L,611L,641L,659L,809L,905L,935L,989L,1019L,1031L,1049L,1121L,1199L,1229L,1289L,1451L,1469L,1481L,1509L,1541L,1661L,1821L,1931L,2109L,2129L,2141L,2339L,2549L,2795L,2969L,3021L,3039L,3189L,3299L,3329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244520Inst : IEnumerable<long>
{
public static readonly long[] Value=A244520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244520.Bytes);
public long this[int i]=>Value[i];

public static A244520Inst Instance=new A244520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244521
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,22L,45L,90L,184L,370L,751L,1516L,3053L,6172L,12405L,25042L,50323L,101424L,203880L,410296L,824871L,1658338L,3333405L,6696814L,13457112L,27021758L,54278993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244521Inst : IEnumerable<long>
{
public static readonly long[] Value=A244521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244521.Bytes);
public long this[int i]=>Value[i];

public static A244521Inst Instance=new A244521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244522
{
public static readonly long[] Value={ 1L,1L,2L,0L,0L,2L,4L,10L,36L,126L,454L,1744L,6892L,28486L,120962L,531660L,2398248L,11127674L,52888998L,257570104L,1282439216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244522Inst : IEnumerable<long>
{
public static readonly long[] Value=A244522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244522.Bytes);
public long this[int i]=>Value[i];

public static A244522Inst Instance=new A244522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244523
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,2L,0L,1L,5L,0L,1L,10L,1L,0L,1L,21L,3L,0L,1L,42L,9L,0L,1L,87L,25L,0L,1L,178L,66L,2L,0L,1L,371L,170L,6L,0L,1L,773L,431L,21L,0L,1L,1630L,1076L,63L,0L,1L,3447L,2665L,185L,1L,0L,1L,7346L,6560L,512L,7L,0L,1L,15712L,16067L,1403L,26L,0L,1L,33790L,39219L,3750L,91L,0L,1L,72922L,95476L,9928L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244523Inst : IEnumerable<long>
{
public static readonly long[] Value=A244523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244523.Bytes);
public long this[int i]=>Value[i];

public static A244523Inst Instance=new A244523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244524
{
public static readonly long[] Value={ 1L,1L,4L,26L,236L,2780L,40642L,715836L,14873174L,358866952L,9934283924L,312461402424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244524Inst : IEnumerable<long>
{
public static readonly long[] Value=A244524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244524.Bytes);
public long this[int i]=>Value[i];

public static A244524Inst Instance=new A244524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244525
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244525Inst : IEnumerable<long>
{
public static readonly long[] Value=A244525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244525.Bytes);
public long this[int i]=>Value[i];

public static A244525Inst Instance=new A244525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244526
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,-2L,1L,0L,2L,0L,1L,0L,0L,0L,2L,0L,0L,-2L,2L,-2L,0L,-2L,0L,-2L,0L,0L,0L,0L,1L,0L,0L,0L,2L,-2L,0L,0L,3L,0L,2L,-2L,0L,0L,2L,0L,2L,0L,0L,-2L,0L,0L,0L,-2L,0L,-2L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-2L,0L,-2L,1L,0L,2L,0L,0L,-2L,2L,-2L,2L,0L,0L,0L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244526Inst : IEnumerable<long>
{
public static readonly long[] Value=A244526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244526.Bytes);
public long this[int i]=>Value[i];

public static A244526Inst Instance=new A244526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244527
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244527Inst : IEnumerable<long>
{
public static readonly long[] Value=A244527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244527.Bytes);
public long this[int i]=>Value[i];

public static A244527Inst Instance=new A244527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244528
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244528Inst : IEnumerable<long>
{
public static readonly long[] Value=A244528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244528.Bytes);
public long this[int i]=>Value[i];

public static A244528Inst Instance=new A244528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244529
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,23L,29L,41L,43L,47L,53L,59L,61L,67L,83L,89L,257L,263L,269L,431L,487L,523L,541L,827L,829L,853L,859L,2861L,5623L,5849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244529Inst : IEnumerable<long>
{
public static readonly long[] Value=A244529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244529.Bytes);
public long this[int i]=>Value[i];

public static A244529Inst Instance=new A244529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244530
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,4L,0L,1L,0L,11L,2L,0L,1L,0L,36L,5L,0L,0L,1L,0L,117L,11L,3L,0L,0L,1L,0L,393L,28L,7L,0L,0L,0L,1L,0L,1339L,78L,8L,4L,0L,0L,0L,1L,0L,4630L,201L,21L,9L,0L,0L,0L,0L,1L,0L,16193L,532L,55L,10L,5L,0L,0L,0L,0L,1L,0L,57201L,1441L,121L,11L,11L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244530Inst : IEnumerable<long>
{
public static readonly long[] Value=A244530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244530.Bytes);
public long this[int i]=>Value[i];

public static A244530Inst Instance=new A244530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244531
{
public static readonly long[] Value={ 1L,0L,2L,5L,11L,28L,78L,201L,532L,1441L,3895L,10569L,28926L,79493L,219226L,607189L,1687880L,4706737L,13165215L,36929595L,103860429L,292808814L,827392709L,2342964435L,6647953886L,18898472568L,53818654942L,153518738980L,438602656951L,1254943919799L,3595714927194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244531Inst : IEnumerable<long>
{
public static readonly long[] Value=A244531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244531.Bytes);
public long this[int i]=>Value[i];

public static A244531Inst Instance=new A244531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244532
{
public static readonly long[] Value={ 1L,0L,0L,3L,7L,8L,21L,55L,121L,265L,611L,1379L,3193L,7436L,17085L,39339L,91846L,214549L,500132L,1169267L,2743302L,6445797L,15167805L,35749961L,84390645L,199523566L,472429633L,1120012481L,2658525869L,6318368820L,15034189965L,35811690663L,85393261630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244532Inst : IEnumerable<long>
{
public static readonly long[] Value=A244532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244532.Bytes);
public long this[int i]=>Value[i];

public static A244532Inst Instance=new A244532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244533
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,9L,10L,11L,34L,91L,196L,330L,636L,1377L,2976L,6061L,12199L,25186L,52767L,109066L,224964L,467605L,979056L,2042847L,4244986L,8844130L,18527956L,38878929L,81460220L,170576593L,357894472L,752544917L,1583579674L,3332453026L,7016669752L,14790212086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244533Inst : IEnumerable<long>
{
public static readonly long[] Value=A244533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244533.Bytes);
public long this[int i]=>Value[i];

public static A244533Inst Instance=new A244533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244534
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,5L,11L,12L,13L,14L,50L,136L,289L,477L,703L,1255L,2611L,5489L,10902L,19712L,35455L,66651L,130014L,254737L,488041L,920461L,1741642L,3338360L,6453073L,12425997L,23780944L,45451155L,87224392L,168253246L,324863578L,625728091L,1202953325L,2314485753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244534Inst : IEnumerable<long>
{
public static readonly long[] Value=A244534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244534.Bytes);
public long this[int i]=>Value[i];

public static A244534Inst Instance=new A244534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244535
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,6L,13L,14L,15L,16L,17L,69L,190L,400L,651L,946L,1288L,2186L,4425L,9126L,17811L,31654L,51997L,85841L,149916L,276056L,518089L,960466L,1718395L,3006963L,5269873L,9392821L,17032418L,31098198L,56432687L,101350402L,180978701L,323731177L,582832779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244535Inst : IEnumerable<long>
{
public static readonly long[] Value=A244535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244535.Bytes);
public long this[int i]=>Value[i];

public static A244535Inst Instance=new A244535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244536
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,7L,15L,16L,17L,18L,19L,20L,91L,253L,529L,852L,1225L,1651L,2133L,3493L,6931L,14095L,27156L,47648L,77297L,118031L,182462L,300441L,527398L,954712L,1722370L,3015910L,5074611L,8342271L,13730760L,23036563L,39558564L,68974240L,120541276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244536Inst : IEnumerable<long>
{
public static readonly long[] Value=A244536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244536.Bytes);
public long this[int i]=>Value[i];

public static A244536Inst Instance=new A244536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244537
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,8L,17L,18L,19L,20L,21L,22L,23L,116L,325L,676L,1080L,1540L,2059L,2640L,3286L,5240L,10241L,20604L,39305L,68286L,109705L,165946L,239629L,351898L,552311L,931070L,1633871L,2879668L,4951860L,8208631L,13094200L,20436400L,31939817L,50935060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244537Inst : IEnumerable<long>
{
public static readonly long[] Value=A244537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244537.Bytes);
public long this[int i]=>Value[i];

public static A244537Inst Instance=new A244537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244538
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,9L,19L,20L,21L,22L,23L,24L,25L,26L,144L,406L,841L,1335L,1891L,2512L,3201L,3961L,4795L,7491L,14467L,28861L,54626L,94160L,150101L,225337L,323016L,446556L,629454L,949486L,1545877L,2639756L,4558225L,7716325L,12629776L,19928727L,30372551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244538Inst : IEnumerable<long>
{
public static readonly long[] Value=A244538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244538.Bytes);
public long this[int i]=>Value[i];

public static A244538Inst Instance=new A244538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244539
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,10L,21L,22L,23L,24L,25L,26L,27L,28L,29L,175L,496L,1024L,1617L,2278L,3010L,3816L,4699L,5662L,6708L,10310L,19721L,39074L,73487L,125862L,199365L,297436L,423799L,582472L,777777L,1060410L,1547051L,2443649L,4072732L,6905106L,11528110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244539Inst : IEnumerable<long>
{
public static readonly long[] Value=A244539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244539.Bytes);
public long this[int i]=>Value[i];

public static A244539Inst Instance=new A244539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244540
{
public static readonly long[] Value={ 1L,3L,3L,2L,3L,4L,2L,0L,3L,5L,4L,2L,2L,4L,0L,0L,3L,6L,5L,2L,4L,0L,2L,0L,2L,7L,4L,4L,0L,4L,0L,0L,3L,4L,6L,0L,5L,4L,2L,0L,4L,6L,0L,2L,2L,4L,0L,0L,2L,3L,7L,4L,4L,4L,4L,0L,0L,4L,4L,2L,0L,4L,0L,0L,3L,8L,4L,2L,6L,0L,0L,0L,5L,6L,4L,2L,2L,0L,0L,0L,4L,7L,6L,2L,0L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244540Inst : IEnumerable<long>
{
public static readonly long[] Value=A244540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244540.Bytes);
public long this[int i]=>Value[i];

public static A244540Inst Instance=new A244540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244541
{
public static readonly long[] Value={ 1L,2L,3L,4L,101L,202L,247L,252L,303L,348L,404L,505L,606L,707L,808L,843L,909L,1001L,2002L,3003L,4004L,5005L,6006L,7007L,8008L,9009L,10001L,10101L,10201L,10301L,10401L,10501L,10601L,10701L,10801L,10901L,11011L,12021L,13031L,14041L,15051L,15451L,16061L,17071L,18081L,19091L,20002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244541Inst : IEnumerable<long>
{
public static readonly long[] Value=A244541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244541.Bytes);
public long this[int i]=>Value[i];

public static A244541Inst Instance=new A244541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244542
{
public static readonly long[] Value={ 1L,2L,3L,4L,101L,202L,252L,303L,404L,505L,606L,707L,808L,909L,1001L,2002L,3003L,4004L,5005L,6006L,7007L,8008L,9009L,10001L,10101L,10201L,10301L,10401L,10501L,10601L,10701L,10801L,10901L,11011L,12021L,13031L,14041L,15051L,15451L,16061L,17071L,18081L,19091L,20002L,20102L,20202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244542Inst : IEnumerable<long>
{
public static readonly long[] Value=A244542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244542.Bytes);
public long this[int i]=>Value[i];

public static A244542Inst Instance=new A244542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244543
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,0L,2L,0L,3L,3L,4L,2L,2L,0L,0L,0L,3L,2L,5L,2L,4L,0L,2L,0L,2L,1L,4L,4L,0L,0L,0L,0L,3L,4L,6L,0L,5L,0L,2L,0L,4L,2L,0L,2L,2L,0L,0L,0L,2L,1L,7L,4L,4L,0L,4L,0L,0L,4L,4L,2L,0L,0L,0L,0L,3L,0L,4L,2L,6L,0L,0L,0L,5L,2L,4L,2L,2L,0L,0L,0L,4L,5L,6L,2L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244543Inst : IEnumerable<long>
{
public static readonly long[] Value=A244543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244543.Bytes);
public long this[int i]=>Value[i];

public static A244543Inst Instance=new A244543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244544
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,2L,2L,0L,3L,4L,4L,2L,2L,2L,0L,0L,3L,4L,5L,2L,4L,0L,2L,0L,2L,4L,4L,4L,0L,2L,0L,0L,3L,4L,6L,0L,5L,2L,2L,0L,4L,4L,0L,2L,2L,2L,0L,0L,2L,2L,7L,4L,4L,2L,4L,0L,0L,4L,4L,2L,0L,2L,0L,0L,3L,4L,4L,2L,6L,0L,0L,0L,5L,4L,4L,2L,2L,0L,0L,0L,4L,6L,6L,2L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244544Inst : IEnumerable<long>
{
public static readonly long[] Value=A244544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244544.Bytes);
public long this[int i]=>Value[i];

public static A244544Inst Instance=new A244544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244545
{
public static readonly long[] Value={ 243417L,1161910L,1293662L,1434861L,1446213L,1460502L,1473746L,1689722L,2284675L,2483249L,2485141L,2693347L,2695449L,2708061L,2783733L,3207751L,3237765L,3273761L,3684535L,4120955L,4154366L,4189067L,4274801L,4354265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244545Inst : IEnumerable<long>
{
public static readonly long[] Value=A244545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244545.Bytes);
public long this[int i]=>Value[i];

public static A244545Inst Instance=new A244545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244546
{
public static readonly long[] Value={ 997L,1879L,2617L,85091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244546Inst : IEnumerable<long>
{
public static readonly long[] Value=A244546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244546.Bytes);
public long this[int i]=>Value[i];

public static A244546Inst Instance=new A244546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244547
{
public static readonly long[] Value={ 1L,2L,3L,4L,247L,252L,348L,843L,15451L,25152L,25252L,25352L,25452L,36563L,36968L,44594L,51165L,51415L,52125L,52225L,52325L,52425L,63536L,92529L,1455541L,1545451L,1595451L,1954591L,2255522L,2524752L,2525252L,2534852L,2584352L,2853582L,2856582L,3159563L,3354533L,3524753L,3534353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244547Inst : IEnumerable<long>
{
public static readonly long[] Value=A244547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244547.Bytes);
public long this[int i]=>Value[i];

public static A244547Inst Instance=new A244547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244548
{
public static readonly long[] Value={ 1L,2L,3L,4L,252L,15451L,25152L,25252L,25352L,25452L,36563L,51415L,52125L,52225L,52325L,52425L,63536L,92529L,1455541L,1545451L,1954591L,2255522L,2525252L,2853582L,2856582L,3354533L,3534353L,4155514L,4453544L,4456544L,4515154L,4543454L,4546454L,5145415L,5225225L,5334335L,5415145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244548Inst : IEnumerable<long>
{
public static readonly long[] Value=A244548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244548.Bytes);
public long this[int i]=>Value[i];

public static A244548Inst Instance=new A244548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244549
{
public static readonly long[] Value={ 174308L,188299L,702703L,1045848L,1129794L,1615907L,1956746L,2485141L,3162650L,4216218L,4786277L,4800566L,5048170L,6275088L,6778764L,7075837L,7276821L,7549807L,8468524L,8554258L,8851331L,9616447L,9695442L,10039882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244549Inst : IEnumerable<long>
{
public static readonly long[] Value=A244549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244549.Bytes);
public long this[int i]=>Value[i];

public static A244549Inst Instance=new A244549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244550
{
public static readonly long[] Value={ 2L,1093L,5L,20771L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L,3L,11L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244550Inst : IEnumerable<long>
{
public static readonly long[] Value=A244550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244550.Bytes);
public long this[int i]=>Value[i];

public static A244550Inst Instance=new A244550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244551
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,100L,105L,181L,262L,267L,343L,348L,424L,429L,681L,762L,767L,843L,848L,924L,929L,1000L,10000L,100000L,1000000L,10000000L,63999991L,72999982L,81999973L,90999964L,100000000L,1000000000L,10000000000L,100000000000L,1000000000000L,10000000000000L,100000000000000L,1000000000000000L,10000000000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244551Inst : IEnumerable<long>
{
public static readonly long[] Value=A244551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244551.Bytes);
public long this[int i]=>Value[i];

public static A244551Inst Instance=new A244551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244552
{
public static readonly long[] Value={ 1L,2L,3L,4L,181L,262L,343L,424L,767L,848L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244552Inst : IEnumerable<long>
{
public static readonly long[] Value=A244552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244552.Bytes);
public long this[int i]=>Value[i];

public static A244552Inst Instance=new A244552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244553
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,2L,0L,-1L,3L,-4L,2L,2L,0L,0L,0L,-1L,2L,1L,2L,-4L,0L,2L,0L,2L,1L,-4L,4L,0L,0L,0L,0L,-1L,4L,-2L,0L,1L,0L,2L,0L,-4L,2L,0L,2L,2L,0L,0L,0L,2L,1L,-5L,4L,-4L,0L,4L,0L,0L,4L,-4L,2L,0L,0L,0L,0L,-1L,0L,4L,2L,-2L,0L,0L,0L,1L,2L,-4L,2L,2L,0L,0L,0L,-4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244553Inst : IEnumerable<long>
{
public static readonly long[] Value=A244553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244553.Bytes);
public long this[int i]=>Value[i];

public static A244553Inst Instance=new A244553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244554
{
public static readonly long[] Value={ 1L,1L,-2L,1L,4L,-2L,0L,1L,-1L,4L,-2L,-2L,4L,0L,0L,1L,2L,-1L,-2L,4L,0L,-2L,0L,-2L,5L,4L,-4L,0L,4L,0L,0L,1L,-4L,2L,0L,-1L,4L,-2L,0L,4L,2L,0L,-2L,-2L,4L,0L,0L,-2L,1L,5L,-4L,4L,4L,-4L,0L,0L,-4L,4L,-2L,0L,4L,0L,0L,1L,8L,-4L,-2L,2L,0L,0L,0L,-1L,2L,4L,-2L,-2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244554Inst : IEnumerable<long>
{
public static readonly long[] Value=A244554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244554.Bytes);
public long this[int i]=>Value[i];

public static A244554Inst Instance=new A244554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244555
{
public static readonly long[] Value={ 11L,13L,17L,19L,23L,29L,31L,37L,41L,47L,53L,61L,71L,73L,83L,89L,101L,103L,107L,127L,131L,139L,149L,151L,157L,173L,181L,191L,193L,197L,211L,223L,229L,233L,239L,241L,251L,257L,263L,271L,277L,281L,307L,311L,331L,347L,353L,359L,373L,383L,389L,401L,421L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244555Inst : IEnumerable<long>
{
public static readonly long[] Value=A244555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244555.Bytes);
public long this[int i]=>Value[i];

public static A244555Inst Instance=new A244555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244556
{
public static readonly long[] Value={ 2L,3L,5L,7L,43L,59L,67L,79L,97L,109L,113L,137L,163L,167L,179L,199L,227L,269L,283L,293L,313L,317L,337L,349L,367L,379L,397L,409L,419L,439L,463L,479L,487L,499L,523L,557L,569L,607L,617L,619L,643L,673L,677L,683L,709L,719L,727L,739L,743L,773L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244556Inst : IEnumerable<long>
{
public static readonly long[] Value=A244556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244556.Bytes);
public long this[int i]=>Value[i];

public static A244556Inst Instance=new A244556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244557
{
public static readonly long[] Value={ 4L,9L,25L,49L,11L,19L,149L,181L,49L,481L,91L,949L,161L,169L,1649L,259L,2581L,361L,3649L,491L,499L,4981L,649L,6481L,8149L,101L,109L,1049L,1081L,119L,1449L,191L,1949L,1981L,11681L,1251L,12549L,1369L,13649L,1499L,14981L,1641L,1811L,1819L,18149L,18181L,411L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244557Inst : IEnumerable<long>
{
public static readonly long[] Value=A244557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244557.Bytes);
public long this[int i]=>Value[i];

public static A244557Inst Instance=new A244557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244558
{
public static readonly long[] Value={ 1L,1L,4L,9L,25L,64L,19L,41L,916L,2525L,6481L,11616L,499L,94949L,3610L,816449L,1258149L,4256416L,161641L,36493625L,10811636L,1494911L,464362549L,163693664L,49250425L,1419819L,1813616164L,91496411L,251164481L,64940160L,19163643681L,4149649081L,925416254964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244558Inst : IEnumerable<long>
{
public static readonly long[] Value=A244558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244558.Bytes);
public long this[int i]=>Value[i];

public static A244558Inst Instance=new A244558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244559
{
public static readonly BigInteger[] Value={ 1L,4L,36L,416L,140L,4940L,250160L,160940L,936464640L,9364646400L,981811366400L,1649810013600L,3644490406400L,6449149644811400L,1904936491693664000L,BigInteger.Parse("408144496481646464000"),BigInteger.Parse("925253664491646408136000"),BigInteger.Parse("36160494994902549464000"),BigInteger.Parse("141361625100160646494000") };
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
public class A244559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244559Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244559.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244559.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244559Inst Instance=new A244559Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244560
{
public static readonly long[] Value={ 1L,-2L,1L,0L,0L,0L,0L,-2L,2L,0L,2L,-2L,0L,0L,1L,0L,0L,-2L,0L,0L,1L,0L,2L,-2L,0L,0L,0L,-2L,2L,-2L,0L,0L,2L,0L,2L,0L,0L,-2L,0L,0L,0L,0L,0L,0L,1L,-2L,2L,0L,0L,-2L,0L,0L,4L,-2L,1L,-2L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,0L,0L,-2L,0L,0L,0L,0L,2L,0L,2L,0L,2L,-2L,0L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244560Inst : IEnumerable<long>
{
public static readonly long[] Value=A244560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244560.Bytes);
public long this[int i]=>Value[i];

public static A244560Inst Instance=new A244560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244561
{
public static readonly long[] Value={ 271129L,271577L,482719L,575041L,603713L,903983L,965431L,1518781L,1624097L,1639459L,2131043L,2131099L,2541601L,2931767L,2931991L,3083723L,3098059L,3555593L,3608251L,4067003L,4573999L,6134663L,6135559L,6557843L,6676921L,6678713L,6742487L,6799831L,7400371L,7523267L,7523281L,7761437L,7765021L,7892569L,8007257L,8629967L,8840599L,8871323L,9208337L,9454129L,9454157L,9854491L,9854603L,9930469L,9937637L,10192733L,10422109L,10675607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244561Inst : IEnumerable<long>
{
public static readonly long[] Value=A244561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244561.Bytes);
public long this[int i]=>Value[i];

public static A244561Inst Instance=new A244561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244562
{
public static readonly long[] Value={ 78557L,2191531L,2510177L,2576089L,7134623L,7696009L,8184977L,10275229L,10391933L,11201161L,12151397L,12384413L,12756019L,13065289L,13085029L,15168739L,16391273L,18140153L,18156631L,19436611L,19558853L,20312899L,20778931L,21610427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244562Inst : IEnumerable<long>
{
public static readonly long[] Value=A244562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244562.Bytes);
public long this[int i]=>Value[i];

public static A244562Inst Instance=new A244562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244563
{
public static readonly long[] Value={ 1290677L,4095859L,5841947L,7158107L,8959163L,9044629L,9252323L,9933857L,10306187L,11000303L,15598231L,16010419L,16625747L,16907749L,18068693L,19428919L,20189993L,23487497L,25614893L,26471633L,28410121L,30375901L,30666137L,32552687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244563Inst : IEnumerable<long>
{
public static readonly long[] Value=A244563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244563.Bytes);
public long this[int i]=>Value[i];

public static A244563Inst Instance=new A244563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244564
{
public static readonly long[] Value={ 934909L,1259779L,6828631L,11822359L,12151397L,15285707L,17220887L,23277113L,25912463L,32971909L,34689511L,38206517L,38257411L,45181667L,46337843L,48339497L,57410477L,63676073L,67510217L,68468753L,68708387L,69169397L,70312793L,71151293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244564Inst : IEnumerable<long>
{
public static readonly long[] Value=A244564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244564.Bytes);
public long this[int i]=>Value[i];

public static A244564Inst Instance=new A244564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244565
{
public static readonly long[] Value={ 322523L,12413281L,16921847L,27862127L,29095681L,35430841L,43925747L,47635073L,50273851L,56517767L,57816799L,59929127L,60666107L,63662611L,66887071L,69265069L,77564731L,83460571L,87376127L,104697533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244565Inst : IEnumerable<long>
{
public static readonly long[] Value=A244565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244565.Bytes);
public long this[int i]=>Value[i];

public static A244565Inst Instance=new A244565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244566
{
public static readonly long[] Value={ 327739L,5455789L,8879993L,9043831L,21823667L,25763447L,29949559L,75037639L,92732027L,119863547L,119879899L,122091961L,146880319L,151060223L,152106751L,163378771L,181339441L,182384417L,182646049L,218039041L,232190537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244566Inst : IEnumerable<long>
{
public static readonly long[] Value=A244566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244566.Bytes);
public long this[int i]=>Value[i];

public static A244566Inst Instance=new A244566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244567
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,8L,9L,5L,10L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,16L,17L,9L,18L,19L,20L,21L,5L,10L,11L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,3L,6L,12L,21L,30L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244567Inst : IEnumerable<long>
{
public static readonly long[] Value=A244567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244567.Bytes);
public long this[int i]=>Value[i];

public static A244567Inst Instance=new A244567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244568
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,5L,3L,7L,1L,9L,5L,5L,3L,13L,7L,15L,1L,17L,9L,19L,20L,21L,5L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,3L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,5L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,7L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,3L,67L,68L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244568Inst : IEnumerable<long>
{
public static readonly long[] Value=A244568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244568.Bytes);
public long this[int i]=>Value[i];

public static A244568Inst Instance=new A244568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244569
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,4L,1L,2L,3L,3L,1L,2L,1L,5L,1L,2L,1L,1L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244569Inst : IEnumerable<long>
{
public static readonly long[] Value=A244569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244569.Bytes);
public long this[int i]=>Value[i];

public static A244569Inst Instance=new A244569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244570
{
public static readonly long[] Value={ 3L,7L,11L,19L,17L,37L,23L,37L,43L,47L,47L,61L,53L,73L,109L,79L,89L,71L,109L,227L,113L,97L,139L,137L,127L,149L,127L,131L,283L,137L,139L,181L,173L,151L,167L,191L,173L,193L,193L,181L,239L,199L,233L,223L,239L,251L,239L,241L,233L,313L,241L,251L,271L,277L,373L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244570Inst : IEnumerable<long>
{
public static readonly long[] Value=A244570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244570.Bytes);
public long this[int i]=>Value[i];

public static A244570Inst Instance=new A244570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244571
{
public static readonly long[] Value={ 3L,5L,7L,23L,13L,23L,19L,41L,29L,61L,37L,59L,43L,47L,71L,107L,61L,73L,71L,97L,109L,113L,89L,157L,113L,103L,107L,127L,167L,127L,131L,149L,139L,179L,163L,163L,181L,227L,173L,251L,199L,191L,223L,257L,229L,211L,223L,233L,271L,233L,239L,271L,281L,257L,443L,389L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244571Inst : IEnumerable<long>
{
public static readonly long[] Value=A244571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244571.Bytes);
public long this[int i]=>Value[i];

public static A244571Inst Instance=new A244571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244572
{
public static readonly long[] Value={ 3L,7L,11L,23L,17L,37L,23L,41L,43L,61L,47L,61L,53L,73L,109L,107L,89L,73L,109L,227L,113L,113L,139L,157L,127L,149L,127L,131L,283L,137L,139L,181L,173L,179L,167L,191L,181L,227L,193L,251L,239L,199L,233L,257L,239L,251L,239L,241L,271L,313L,241L,271L,281L,277L,443L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244572Inst : IEnumerable<long>
{
public static readonly long[] Value=A244572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244572.Bytes);
public long this[int i]=>Value[i];

public static A244572Inst Instance=new A244572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244573
{
public static readonly long[] Value={ 1L,10L,18L,26L,34L,42L,68L,76L,84L,92L,100L,279L,368L,457L,546L,635L,724L,813L,902L,1000L,1071L,1152L,1233L,1314L,1486L,1567L,1648L,1729L,1981L,2051L,2132L,2213L,2385L,2466L,2547L,2628L,2709L,2880L,2961L,3031L,3112L,3284L,3365L,3446L,3527L,3608L,3699L,3860L,3941L,4011L,4183L,4264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244573Inst : IEnumerable<long>
{
public static readonly long[] Value=A244573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244573.Bytes);
public long this[int i]=>Value[i];

public static A244573Inst Instance=new A244573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244574
{
public static readonly long[] Value={ 3321607L,3640387L,4019207L,4447704L,4472360L,4818916L,4897363L,5048347L,5067967L,5153431L,5288968L,5769988L,6562327L,7016747L,7060148L,7503391L,7546164L,8124503L,8180671L,8721735L,8819519L,8992363L,9379703L,9487991L,9778603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244574Inst : IEnumerable<long>
{
public static readonly long[] Value=A244574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244574.Bytes);
public long this[int i]=>Value[i];

public static A244574Inst Instance=new A244574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244575
{
public static readonly long[] Value={ 4447704L,4472360L,4818916L,4897363L,5067967L,5769988L,7060148L,8180671L,8721735L,8819519L,8992363L,9379703L,9487991L,9778603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244575Inst : IEnumerable<long>
{
public static readonly long[] Value=A244575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244575.Bytes);
public long this[int i]=>Value[i];

public static A244575Inst Instance=new A244575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244576
{
public static readonly long[] Value={ 0L,0L,2L,7L,23L,38L,69L,89L,133L,227L,268L,397L,483L,536L,632L,821L,1018L,1125L,1355L,1511L,1633L,1890L,2077L,2406L,2906L,3150L,3263L,3509L,3680L,3960L,5026L,5319L,5854L,6003L,6909L,7130L,7761L,8345L,8681L,9381L,9986L,10351L,11456L,11771L,12212L,12481L,14128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244576Inst : IEnumerable<long>
{
public static readonly long[] Value=A244576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244576.Bytes);
public long this[int i]=>Value[i];

public static A244576Inst Instance=new A244576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244577
{
public static readonly BigInteger[] Value={ 1L,1L,2L,14L,196L,4652L,166168L,8232296L,535974416L,44186331248L,4489336764064L,550549455440096L,80153857492836928L,13665883723351362752UL,BigInteger.Parse("2697370187692768024448"),BigInteger.Parse("610301579538939633684608"),BigInteger.Parse("156933087218604923576672512"),BigInteger.Parse("45515622704384079509089136384"),BigInteger.Parse("14789652457653705738777659937280") };
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
public class A244577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244577.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A244577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244577Inst Instance=new A244577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244578
{
public static readonly long[] Value={ 1L,2L,6L,13L,33L,50L,85L,107L,155L,255L,298L,433L,523L,578L,678L,873L,1076L,1185L,1421L,1581L,1705L,1968L,2159L,2494L,3002L,3250L,3365L,3615L,3788L,4072L,5152L,5449L,5990L,6141L,7057L,7280L,7917L,8507L,8847L,9553L,10164L,10531L,11646L,11963L,12408L,12679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244578Inst : IEnumerable<long>
{
public static readonly long[] Value=A244578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244578.Bytes);
public long this[int i]=>Value[i];

public static A244578Inst Instance=new A244578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244579
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,17L,19L,21L,23L,25L,27L,29L,31L,33L,37L,39L,41L,43L,47L,49L,51L,53L,55L,57L,59L,61L,65L,67L,69L,71L,73L,79L,81L,83L,85L,87L,89L,93L,95L,97L,101L,103L,107L,109L,111L,113L,115L,119L,121L,123L,125L,127L,129L,131L,133L,137L,139L,141L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244579Inst : IEnumerable<long>
{
public static readonly long[] Value=A244579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244579.Bytes);
public long this[int i]=>Value[i];

public static A244579Inst Instance=new A244579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244580
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,4L,3L,3L,4L,5L,4L,4L,4L,5L,6L,5L,4L,4L,5L,6L,7L,6L,5L,6L,5L,6L,7L,8L,7L,6L,6L,6L,6L,7L,8L,9L,8L,7L,6L,6L,6L,7L,8L,9L,10L,9L,8L,7L,8L,8L,7L,8L,9L,10L,11L,10L,9L,8L,8L,8L,8L,8L,9L,10L,11L,12L,11L,10L,9L,8L,9L,9L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244580Inst : IEnumerable<long>
{
public static readonly long[] Value=A244580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244580.Bytes);
public long this[int i]=>Value[i];

public static A244580Inst Instance=new A244580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244581
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,90L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244581Inst : IEnumerable<long>
{
public static readonly long[] Value=A244581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244581.Bytes);
public long this[int i]=>Value[i];

public static A244581Inst Instance=new A244581Inst();

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