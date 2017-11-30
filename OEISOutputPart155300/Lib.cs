using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198405
{
public static readonly BigInteger[] Value={ 2L,17L,377L,11473L,375273L,12456897L,414711897L,13814539697L,460231956937L,15333001667233L,510833776539193L,17018936996199057L,567002973887727017L,BigInteger.Parse("18890274083549781377"),BigInteger.Parse("629348476275500726297"),BigInteger.Parse("20967377362990867086193") };
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
public class A198405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198405Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198405.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198405Inst Instance=new A198405Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198406
{
public static readonly BigInteger[] Value={ 17L,6986L,5057327L,3850206168L,2970439193698L,2302126761338667L,1786986687280410199L,BigInteger.Parse("1387873766175721022708"),BigInteger.Parse("1078103379003130131290922"),BigInteger.Parse("837527575449508082133268374"),BigInteger.Parse("650650234699083836241245595580") };
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
public class A198406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198406Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198406.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198406Inst Instance=new A198406Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198407
{
public static readonly BigInteger[] Value={ 377L,5057327L,85013617830L,1506130430723528L,BigInteger.Parse("27330079651426584414") };
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
public class A198407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198407Inst Instance=new A198407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198408
{
public static readonly long[] Value={ 2L,17L,17L,377L,6986L,377L,11473L,5057327L,5057327L,11473L,375273L,3850206168L,85013617830L,3850206168L,375273L,12456897L,2970439193698L,1506130430723528L,1506130430723528L,2970439193698L,12456897L,414711897L,2302126761338667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198408Inst : IEnumerable<long>
{
public static readonly long[] Value=A198408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198408.Bytes);
public long this[int i]=>Value[i];

public static A198408Inst Instance=new A198408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198409
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,13L,15L,23L,24L,26L,30L,35L,39L,42L,45L,47L,51L,54L,62L,69L,70L,72L,83L,84L,88L,97L,98L,102L,107L,114L,115L,124L,126L,129L,136L,141L,142L,143L,156L,157L,167L,169L,172L,177L,181L,188L,191L,201L,205L,208L,214L,218L,229L,230L,237L,244L,249L,253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198409Inst : IEnumerable<long>
{
public static readonly long[] Value=A198409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198409.Bytes);
public long this[int i]=>Value[i];

public static A198409Inst Instance=new A198409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198410
{
public static readonly BigInteger[] Value={ 7L,37L,271L,2269L,19927L,177877L,1596511L,14355469L,129159847L,1162320517L,10460530351L,94143710269L,847290203767L,7625602267957L,68630391713791L,617673439330669L,5559060695695687L,50031545486420197L,450283907053258831L,4052555156505760669L,BigInteger.Parse("36472996387631139607") };
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
public class A198410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198410Inst Instance=new A198410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198411
{
public static readonly BigInteger[] Value={ 1L,3L,39L,9399L,613576119L,2635249154000645559L,BigInteger.Parse("48611766702991209068831621643639680439"),BigInteger.Parse("16541727033902313631938712144098272550515752433223071786131565516477842550199") };
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
public class A198411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198411Inst Instance=new A198411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198412
{
public static readonly BigInteger[] Value={ 0L,19L,15067L,11061667L,8068935979L,5882573095795L,4288416187929211L,3126256706670452803L,BigInteger.Parse("2279041222725643804363"),BigInteger.Parse("1661421056715018890883091"),BigInteger.Parse("1211175950687522343133931035"),BigInteger.Parse("882947268073109296732165817059"),BigInteger.Parse("643668558426698629867350806558827") };
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
public class A198412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198412Inst Instance=new A198412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198413
{
public static readonly long[] Value={ 1L,1L,3L,11L,46L,205L,962L,4668L,23268L,118374L,612305L,3210348L,17023682L,91140496L,491968036L,2674572509L,14631157562L,80480706331L,444865534251L,2469826058736L,13766223517639L,77003660186990L,432131032213098L,2432230966070833L,13726899289265314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198413Inst : IEnumerable<long>
{
public static readonly long[] Value=A198413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198413.Bytes);
public long this[int i]=>Value[i];

public static A198413Inst Instance=new A198413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198414
{
public static readonly long[] Value={ 1L,4L,0L,4L,4L,1L,4L,8L,2L,4L,0L,9L,2L,4L,3L,4L,3L,6L,4L,1L,4L,8L,3L,2L,7L,9L,4L,3L,7L,4L,5L,7L,5L,8L,6L,0L,3L,7L,2L,5L,7L,1L,6L,1L,3L,7L,0L,4L,9L,1L,1L,4L,8L,1L,0L,9L,4L,4L,8L,2L,4L,3L,5L,4L,8L,7L,7L,5L,2L,5L,2L,9L,5L,6L,1L,7L,1L,4L,4L,3L,6L,2L,1L,2L,0L,5L,1L,0L,1L,5L,2L,4L,8L,2L,0L,8L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198414Inst : IEnumerable<long>
{
public static readonly long[] Value=A198414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198414.Bytes);
public long this[int i]=>Value[i];

public static A198414Inst Instance=new A198414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198415
{
public static readonly long[] Value={ 1L,7L,2L,2L,1L,2L,5L,1L,1L,2L,0L,7L,6L,7L,2L,3L,5L,9L,9L,4L,1L,5L,1L,4L,0L,0L,7L,3L,4L,7L,1L,7L,7L,4L,0L,5L,8L,1L,9L,0L,5L,0L,8L,1L,5L,5L,9L,3L,9L,2L,2L,3L,9L,8L,9L,2L,2L,2L,0L,0L,6L,0L,9L,5L,6L,8L,1L,2L,9L,5L,0L,8L,4L,2L,3L,2L,6L,5L,7L,5L,2L,2L,9L,7L,6L,8L,7L,4L,6L,9L,2L,0L,5L,2L,4L,9L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198415Inst : IEnumerable<long>
{
public static readonly long[] Value=A198415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198415.Bytes);
public long this[int i]=>Value[i];

public static A198415Inst Instance=new A198415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198416
{
public static readonly long[] Value={ 1L,9L,3L,3L,7L,5L,3L,7L,6L,2L,8L,2L,7L,0L,2L,1L,2L,5L,3L,3L,0L,8L,4L,7L,5L,6L,6L,9L,0L,9L,0L,6L,8L,0L,0L,5L,6L,5L,3L,7L,0L,9L,4L,1L,3L,7L,5L,9L,7L,6L,2L,1L,7L,2L,1L,8L,0L,2L,5L,6L,4L,4L,8L,1L,0L,5L,4L,9L,3L,2L,9L,4L,9L,5L,8L,0L,6L,4L,0L,7L,4L,6L,8L,7L,6L,4L,8L,0L,2L,2L,7L,0L,3L,2L,1L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198416Inst : IEnumerable<long>
{
public static readonly long[] Value=A198416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198416.Bytes);
public long this[int i]=>Value[i];

public static A198416Inst Instance=new A198416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198417
{
public static readonly long[] Value={ 7L,9L,5L,5L,8L,9L,8L,7L,3L,4L,7L,3L,9L,2L,5L,1L,8L,1L,8L,0L,6L,2L,7L,3L,2L,5L,9L,0L,1L,3L,0L,3L,5L,9L,6L,1L,1L,2L,8L,1L,7L,1L,0L,6L,4L,5L,4L,6L,1L,3L,4L,7L,0L,5L,2L,9L,8L,3L,1L,3L,2L,8L,0L,2L,2L,5L,6L,5L,7L,5L,1L,8L,1L,3L,4L,1L,9L,2L,8L,4L,2L,3L,3L,9L,2L,4L,8L,3L,5L,1L,6L,8L,9L,4L,0L,1L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198417Inst : IEnumerable<long>
{
public static readonly long[] Value=A198417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198417.Bytes);
public long this[int i]=>Value[i];

public static A198417Inst Instance=new A198417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198418
{
public static readonly long[] Value={ 1L,2L,6L,3L,3L,2L,1L,4L,4L,7L,9L,4L,9L,3L,6L,9L,1L,0L,6L,6L,7L,0L,4L,7L,5L,9L,3L,4L,3L,3L,0L,0L,0L,6L,4L,8L,1L,5L,8L,0L,7L,3L,0L,2L,3L,6L,0L,5L,5L,4L,6L,4L,5L,5L,3L,1L,5L,7L,0L,4L,4L,8L,2L,1L,9L,1L,8L,3L,4L,2L,2L,1L,6L,9L,6L,0L,9L,0L,9L,8L,2L,0L,9L,4L,0L,7L,0L,9L,4L,6L,5L,9L,9L,5L,1L,8L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198418Inst : IEnumerable<long>
{
public static readonly long[] Value=A198418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198418.Bytes);
public long this[int i]=>Value[i];

public static A198418Inst Instance=new A198418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198419
{
public static readonly long[] Value={ 1L,5L,6L,1L,5L,1L,0L,9L,9L,1L,0L,7L,4L,2L,6L,9L,1L,2L,1L,8L,7L,3L,6L,8L,3L,2L,0L,7L,3L,7L,6L,9L,5L,2L,3L,2L,9L,2L,1L,5L,3L,4L,1L,6L,4L,4L,9L,4L,0L,3L,0L,7L,9L,1L,6L,9L,4L,8L,1L,2L,6L,9L,6L,6L,1L,9L,2L,4L,0L,2L,3L,0L,2L,1L,1L,8L,4L,8L,1L,0L,8L,5L,4L,8L,5L,7L,0L,4L,9L,4L,0L,4L,8L,4L,2L,0L,6L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198419Inst : IEnumerable<long>
{
public static readonly long[] Value=A198419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198419.Bytes);
public long this[int i]=>Value[i];

public static A198419Inst Instance=new A198419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198420
{
public static readonly long[] Value={ 1L,6L,1L,7L,5L,4L,5L,2L,8L,6L,0L,6L,2L,2L,5L,4L,7L,5L,3L,0L,2L,7L,4L,2L,8L,8L,1L,3L,8L,2L,0L,5L,2L,5L,2L,8L,0L,1L,7L,6L,9L,9L,4L,7L,6L,1L,9L,0L,7L,9L,5L,9L,6L,1L,2L,7L,9L,9L,7L,8L,3L,0L,3L,8L,7L,7L,1L,4L,2L,0L,4L,6L,5L,4L,8L,3L,1L,3L,4L,0L,4L,8L,9L,6L,6L,5L,4L,4L,7L,1L,8L,4L,1L,9L,1L,5L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198420Inst : IEnumerable<long>
{
public static readonly long[] Value=A198420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198420.Bytes);
public long this[int i]=>Value[i];

public static A198420Inst Instance=new A198420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198421
{
public static readonly long[] Value={ 1L,9L,5L,1L,4L,8L,7L,5L,3L,4L,0L,9L,5L,6L,6L,9L,7L,7L,6L,5L,4L,7L,0L,7L,3L,8L,5L,1L,8L,7L,7L,5L,5L,4L,9L,1L,8L,5L,1L,6L,9L,3L,7L,9L,3L,3L,0L,4L,4L,3L,5L,5L,4L,6L,7L,3L,2L,4L,7L,1L,8L,3L,4L,2L,8L,0L,3L,8L,6L,4L,2L,7L,1L,9L,2L,2L,5L,1L,5L,2L,2L,5L,7L,3L,2L,2L,0L,9L,9L,7L,9L,1L,2L,9L,5L,7L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198421Inst : IEnumerable<long>
{
public static readonly long[] Value=A198421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198421.Bytes);
public long this[int i]=>Value[i];

public static A198421Inst Instance=new A198421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198422
{
public static readonly long[] Value={ 2L,1L,5L,7L,7L,0L,1L,7L,7L,1L,4L,4L,1L,4L,3L,8L,6L,1L,1L,4L,3L,7L,6L,7L,8L,7L,1L,1L,9L,7L,1L,7L,3L,1L,5L,7L,0L,5L,5L,1L,4L,9L,1L,5L,2L,3L,0L,5L,8L,2L,4L,4L,5L,3L,4L,0L,0L,6L,8L,6L,0L,4L,9L,8L,3L,9L,0L,7L,3L,3L,8L,1L,3L,2L,2L,6L,4L,6L,0L,5L,7L,5L,2L,0L,8L,3L,9L,3L,1L,9L,3L,6L,7L,7L,5L,1L,5L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198422Inst : IEnumerable<long>
{
public static readonly long[] Value=A198422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198422.Bytes);
public long this[int i]=>Value[i];

public static A198422Inst Instance=new A198422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198423
{
public static readonly long[] Value={ 2L,2L,9L,8L,8L,5L,3L,5L,8L,2L,2L,7L,7L,4L,0L,3L,2L,9L,5L,2L,0L,6L,0L,5L,9L,1L,9L,6L,1L,5L,3L,4L,3L,3L,3L,5L,0L,8L,7L,3L,9L,3L,2L,2L,5L,2L,2L,3L,1L,3L,2L,3L,3L,0L,8L,3L,4L,5L,5L,7L,6L,0L,3L,5L,8L,5L,5L,5L,9L,6L,2L,5L,4L,0L,0L,2L,4L,3L,9L,7L,6L,8L,9L,5L,0L,6L,4L,7L,0L,4L,2L,0L,0L,8L,4L,0L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198423Inst : IEnumerable<long>
{
public static readonly long[] Value=A198423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198423.Bytes);
public long this[int i]=>Value[i];

public static A198423Inst Instance=new A198423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198424
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,3L,5L,6L,0L,7L,5L,7L,9L,3L,0L,7L,2L,4L,4L,4L,5L,2L,1L,2L,0L,8L,7L,1L,0L,2L,1L,6L,7L,4L,7L,7L,2L,9L,5L,5L,4L,8L,5L,0L,7L,7L,5L,8L,3L,8L,0L,7L,8L,1L,4L,0L,0L,7L,5L,1L,8L,7L,2L,5L,9L,5L,9L,5L,1L,7L,1L,0L,9L,0L,0L,2L,5L,4L,3L,5L,9L,1L,8L,9L,6L,5L,5L,3L,8L,8L,9L,9L,2L,1L,8L,7L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198424Inst : IEnumerable<long>
{
public static readonly long[] Value=A198424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198424.Bytes);
public long this[int i]=>Value[i];

public static A198424Inst Instance=new A198424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198425
{
public static readonly long[] Value={ 7L,3L,6L,2L,3L,2L,1L,5L,0L,5L,5L,4L,7L,4L,8L,1L,9L,9L,5L,6L,0L,8L,9L,1L,8L,9L,2L,5L,8L,9L,0L,7L,6L,8L,1L,2L,9L,9L,3L,9L,8L,0L,5L,8L,9L,5L,5L,1L,3L,2L,5L,8L,2L,5L,9L,0L,5L,4L,8L,4L,3L,5L,5L,0L,3L,2L,9L,7L,8L,8L,2L,6L,6L,0L,0L,4L,3L,1L,9L,8L,5L,8L,4L,3L,7L,3L,4L,7L,0L,0L,9L,1L,6L,4L,9L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198425Inst : IEnumerable<long>
{
public static readonly long[] Value=A198425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198425.Bytes);
public long this[int i]=>Value[i];

public static A198425Inst Instance=new A198425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198426
{
public static readonly long[] Value={ 1L,1L,6L,0L,5L,9L,1L,8L,6L,7L,1L,9L,0L,0L,5L,4L,1L,5L,7L,3L,1L,3L,3L,0L,8L,2L,5L,0L,4L,3L,3L,0L,5L,5L,3L,3L,6L,3L,1L,7L,9L,7L,1L,3L,3L,9L,1L,5L,9L,1L,0L,6L,1L,2L,8L,3L,8L,4L,9L,9L,4L,1L,2L,5L,7L,6L,1L,4L,2L,2L,3L,4L,0L,0L,1L,8L,4L,9L,8L,2L,7L,4L,7L,9L,5L,0L,6L,5L,3L,9L,1L,8L,4L,9L,1L,6L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198426Inst : IEnumerable<long>
{
public static readonly long[] Value=A198426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198426.Bytes);
public long this[int i]=>Value[i];

public static A198426Inst Instance=new A198426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198427
{
public static readonly long[] Value={ 2L,3L,1L,6L,9L,3L,4L,2L,8L,8L,6L,2L,3L,7L,3L,9L,7L,9L,1L,5L,2L,2L,7L,3L,2L,0L,4L,9L,8L,8L,7L,4L,4L,0L,9L,0L,5L,3L,7L,1L,8L,0L,2L,6L,1L,6L,1L,4L,7L,6L,2L,8L,3L,1L,6L,4L,4L,2L,7L,5L,0L,1L,7L,0L,9L,9L,7L,3L,1L,6L,6L,4L,6L,1L,7L,2L,2L,7L,3L,4L,1L,6L,1L,4L,2L,8L,7L,6L,2L,3L,6L,7L,7L,5L,8L,4L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198427Inst : IEnumerable<long>
{
public static readonly long[] Value=A198427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198427.Bytes);
public long this[int i]=>Value[i];

public static A198427Inst Instance=new A198427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198428
{
public static readonly long[] Value={ 2L,4L,8L,8L,4L,2L,5L,2L,5L,9L,6L,5L,3L,5L,6L,6L,0L,1L,7L,4L,8L,7L,4L,9L,8L,4L,9L,4L,9L,3L,6L,1L,7L,9L,7L,1L,5L,4L,5L,0L,6L,5L,3L,5L,8L,9L,9L,6L,7L,9L,0L,2L,6L,4L,9L,4L,5L,5L,8L,5L,2L,6L,5L,1L,3L,6L,4L,2L,3L,8L,9L,5L,1L,6L,0L,2L,0L,1L,2L,7L,8L,7L,7L,4L,7L,4L,2L,4L,6L,9L,1L,2L,5L,4L,5L,6L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198428Inst : IEnumerable<long>
{
public static readonly long[] Value=A198428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198428.Bytes);
public long this[int i]=>Value[i];

public static A198428Inst Instance=new A198428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198429
{
public static readonly long[] Value={ 2L,5L,9L,7L,6L,5L,9L,6L,1L,1L,1L,6L,7L,3L,4L,8L,3L,5L,2L,7L,1L,9L,8L,6L,0L,8L,4L,6L,9L,3L,1L,7L,8L,3L,6L,0L,0L,8L,5L,5L,8L,8L,8L,4L,5L,7L,5L,1L,7L,1L,7L,1L,2L,2L,1L,7L,1L,2L,5L,0L,6L,4L,6L,3L,5L,0L,1L,6L,7L,0L,4L,6L,4L,6L,9L,9L,4L,8L,4L,6L,1L,4L,5L,4L,4L,8L,9L,2L,8L,4L,8L,7L,3L,2L,4L,1L,9L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198429Inst : IEnumerable<long>
{
public static readonly long[] Value=A198429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198429.Bytes);
public long this[int i]=>Value[i];

public static A198429Inst Instance=new A198429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198430
{
public static readonly long[] Value={ 2L,6L,7L,4L,0L,9L,8L,0L,8L,7L,0L,5L,0L,6L,8L,0L,8L,5L,1L,5L,5L,3L,6L,3L,9L,3L,8L,9L,9L,9L,2L,3L,0L,5L,6L,7L,6L,6L,6L,6L,7L,1L,8L,7L,7L,3L,7L,0L,6L,6L,1L,7L,8L,6L,1L,1L,8L,9L,8L,0L,0L,4L,8L,2L,6L,7L,9L,1L,0L,9L,2L,4L,8L,8L,1L,6L,1L,5L,6L,5L,2L,8L,8L,4L,4L,1L,9L,3L,6L,8L,6L,8L,2L,5L,6L,9L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198430Inst : IEnumerable<long>
{
public static readonly long[] Value=A198430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198430.Bytes);
public long this[int i]=>Value[i];

public static A198430Inst Instance=new A198430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198431
{
public static readonly long[] Value={ 3L,0L,3L,5L,0L,4L,0L,8L,2L,2L,4L,3L,8L,0L,4L,8L,8L,4L,6L,8L,6L,7L,1L,2L,3L,0L,7L,0L,9L,6L,4L,8L,2L,3L,7L,8L,0L,6L,0L,1L,5L,8L,8L,8L,1L,0L,7L,1L,5L,5L,2L,2L,2L,8L,5L,3L,9L,0L,3L,6L,8L,9L,6L,4L,8L,2L,0L,9L,9L,4L,8L,0L,8L,1L,5L,2L,9L,5L,4L,8L,2L,9L,3L,9L,5L,3L,0L,9L,5L,9L,8L,8L,1L,8L,3L,3L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198431Inst : IEnumerable<long>
{
public static readonly long[] Value=A198431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198431.Bytes);
public long this[int i]=>Value[i];

public static A198431Inst Instance=new A198431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198432
{
public static readonly long[] Value={ 3L,0L,5L,5L,9L,6L,8L,7L,2L,7L,2L,1L,4L,7L,5L,7L,9L,0L,7L,5L,3L,9L,2L,8L,5L,6L,3L,7L,5L,4L,8L,4L,4L,3L,0L,6L,9L,8L,8L,3L,1L,3L,6L,3L,8L,9L,4L,4L,6L,8L,2L,4L,5L,3L,4L,4L,3L,9L,9L,9L,2L,5L,8L,0L,0L,2L,0L,5L,3L,0L,5L,9L,2L,0L,8L,9L,3L,3L,0L,5L,6L,7L,1L,1L,3L,5L,5L,9L,2L,5L,9L,0L,5L,6L,0L,9L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198432Inst : IEnumerable<long>
{
public static readonly long[] Value=A198432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198432.Bytes);
public long this[int i]=>Value[i];

public static A198432Inst Instance=new A198432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198433
{
public static readonly long[] Value={ 3L,0L,6L,9L,9L,5L,0L,1L,8L,6L,9L,4L,8L,3L,1L,3L,1L,4L,7L,4L,5L,5L,1L,1L,5L,7L,7L,3L,8L,8L,3L,1L,8L,1L,6L,1L,1L,2L,7L,4L,3L,7L,2L,7L,7L,8L,6L,8L,4L,8L,4L,5L,1L,0L,8L,4L,5L,3L,1L,7L,5L,0L,2L,0L,6L,7L,3L,1L,9L,3L,9L,3L,5L,5L,2L,4L,8L,2L,8L,9L,5L,7L,7L,5L,2L,0L,1L,0L,2L,3L,7L,1L,4L,6L,5L,3L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198433Inst : IEnumerable<long>
{
public static readonly long[] Value=A198433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198433.Bytes);
public long this[int i]=>Value[i];

public static A198433Inst Instance=new A198433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198434
{
public static readonly BigInteger[] Value={ 2L,10L,90L,966L,12338L,181470L,3018082L,55995486L,1146939010L,25716746430L,626755197698L,16502357651966L,466944932413442L,14133259249586174L,455715081098876418L,15596665064842012158UL,BigInteger.Parse("564724372634695925762"),BigInteger.Parse("21568978799171323200510"),BigInteger.Parse("866674159679235417061378"),BigInteger.Parse("36548294282449538711357438") };
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
public class A198434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198434Inst Instance=new A198434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198435
{
public static readonly long[] Value={ 1L,49L,49L,289L,1L,529L,961L,2401L,289L,2209L,529L,5041L,49L,1681L,1681L,6241L,9409L,49L,961L,5329L,16129L,14161L,7921L,289L,25921L,2209L,12769L,27889L,14161L,1L,39601L,2401L,5329L,10609L,25921L,49729L,58081L,529L,961L,10609L,7921L,36481L,82369L,22801L,47089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198435Inst : IEnumerable<long>
{
public static readonly long[] Value=A198435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198435.Bytes);
public long this[int i]=>Value[i];

public static A198435Inst Instance=new A198435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198436
{
public static readonly long[] Value={ 25L,169L,289L,625L,841L,1369L,1681L,3721L,2809L,4225L,4225L,7225L,5329L,7225L,7921L,10201L,12769L,9409L,11881L,15625L,21025L,21025L,22201L,18769L,32761L,24649L,29929L,38809L,34225L,28561L,48841L,34225L,37249L,42025L,52441L,66049L,70225L,42025L,48841L,54289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198436Inst : IEnumerable<long>
{
public static readonly long[] Value=A198436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198436.Bytes);
public long this[int i]=>Value[i];

public static A198436Inst Instance=new A198436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198437
{
public static readonly long[] Value={ 49L,289L,529L,961L,1681L,2209L,2401L,5041L,5329L,6241L,7921L,9409L,10609L,12769L,14161L,14161L,16129L,18769L,22801L,25921L,25921L,27889L,36481L,37249L,39601L,47089L,47089L,49729L,54289L,57121L,58081L,66049L,69169L,73441L,78961L,82369L,82369L,83521L,96721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198437Inst : IEnumerable<long>
{
public static readonly long[] Value=A198437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198437.Bytes);
public long this[int i]=>Value[i];

public static A198437Inst Instance=new A198437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198438
{
public static readonly long[] Value={ 24L,120L,240L,336L,840L,840L,720L,1320L,2520L,2016L,3696L,2184L,5280L,5544L,6240L,3960L,3360L,9360L,10920L,10296L,4896L,6864L,14280L,18480L,6840L,22440L,17160L,10920L,20064L,28560L,9240L,31824L,31920L,31416L,26520L,16320L,12144L,41496L,47880L,43680L,50160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198438Inst : IEnumerable<long>
{
public static readonly long[] Value=A198438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198438.Bytes);
public long this[int i]=>Value[i];

public static A198438Inst Instance=new A198438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198439
{
public static readonly long[] Value={ 1L,7L,7L,17L,1L,23L,31L,49L,17L,47L,23L,71L,7L,41L,41L,79L,97L,7L,31L,73L,127L,119L,89L,17L,161L,47L,113L,167L,119L,1L,199L,49L,73L,103L,161L,223L,241L,23L,31L,103L,89L,191L,287L,151L,217L,287L,137L,233L,71L,337L,79L,137L,17L,281L,359L,391L,49L,113L,119L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198439Inst : IEnumerable<long>
{
public static readonly long[] Value=A198439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198439.Bytes);
public long this[int i]=>Value[i];

public static A198439Inst Instance=new A198439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198440
{
public static readonly long[] Value={ 5L,13L,17L,25L,29L,37L,41L,61L,53L,65L,65L,85L,73L,85L,89L,101L,113L,97L,109L,125L,145L,145L,149L,137L,181L,157L,173L,197L,185L,169L,221L,185L,193L,205L,229L,257L,265L,205L,221L,233L,241L,269L,313L,265L,293L,325L,277L,317L,281L,365L,289L,305L,305L,365L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198440Inst : IEnumerable<long>
{
public static readonly long[] Value=A198440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198440.Bytes);
public long this[int i]=>Value[i];

public static A198440Inst Instance=new A198440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198441
{
public static readonly long[] Value={ 7L,17L,23L,31L,41L,47L,49L,71L,73L,79L,89L,97L,103L,113L,119L,119L,127L,137L,151L,161L,161L,167L,191L,193L,199L,217L,217L,223L,233L,239L,241L,257L,263L,271L,281L,287L,287L,289L,311L,313L,329L,329L,337L,343L,353L,359L,367L,383L,391L,391L,401L,409L,431L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198441Inst : IEnumerable<long>
{
public static readonly long[] Value=A198441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198441.Bytes);
public long this[int i]=>Value[i];

public static A198441Inst Instance=new A198441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198442
{
public static readonly long[] Value={ 0L,0L,2L,3L,6L,8L,12L,15L,20L,24L,30L,35L,42L,48L,56L,63L,72L,80L,90L,99L,110L,120L,132L,143L,156L,168L,182L,195L,210L,224L,240L,255L,272L,288L,306L,323L,342L,360L,380L,399L,420L,440L,462L,483L,506L,528L,552L,575L,600L,624L,650L,675L,702L,728L,756L,783L,812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198442Inst : IEnumerable<long>
{
public static readonly long[] Value=A198442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198442.Bytes);
public long this[int i]=>Value[i];

public static A198442Inst Instance=new A198442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198443
{
public static readonly long[] Value={ 3L,4L,11L,26L,37L,368L,1828L,2180L,7825L,8177L,8217L,71393L,72481L,75154L,118409L,175485L,203697L,206370L,1049148L,1058224L,1843945L,1846618L,8186369L,8197633L,9600802L,96020524L,169503449L,294638801L,305158594L,305192969L,657099024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198443Inst : IEnumerable<long>
{
public static readonly long[] Value=A198443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198443.Bytes);
public long this[int i]=>Value[i];

public static A198443Inst Instance=new A198443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198444
{
public static readonly long[] Value={ 1L,2L,5L,23L,27L,73L,96L,104L,396L,404L,432L,686L,723L,735L,1130L,1159L,2019L,2031L,3861L,5310L,18219L,18231L,25592L,25608L,44367L,200141L,213842L,308228L,390615L,390635L,549976L,631544L,1579129L,1657086L,2941211L,2941239L,5523608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198444Inst : IEnumerable<long>
{
public static readonly long[] Value=A198444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198444.Bytes);
public long this[int i]=>Value[i];

public static A198444Inst Instance=new A198444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198445
{
public static readonly long[] Value={ 2L,6L,56L,2537L,3788L,45531L,90298L,110302L,3120599L,3280601L,3878907L,12325663L,14055482L,14645977L,42923597L,45730778L,183164286L,185898039L,926295393L,2054642668L,44803437862L,44877249113L,104775699199L,104939539201L,414619915847L,17920089051165L,21146208937291L,52744869326263L,95361328242187L,9537353527343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198445Inst : IEnumerable<long>
{
public static readonly long[] Value=A198445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198445.Bytes);
public long this[int i]=>Value[i];

public static A198445Inst Instance=new A198445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198446
{
public static readonly long[] Value={ 3L,177L,26704L,13048509L,22496409154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198446Inst : IEnumerable<long>
{
public static readonly long[] Value=A198446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198446.Bytes);
public long this[int i]=>Value[i];

public static A198446Inst Instance=new A198446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198447
{
public static readonly long[] Value={ 3L,13L,71L,433L,2763L,17941L,117263L,768313L,5038611L,33054493L,216872663L,1422982081L,9336876123L,61264171813L,401987528351L,2637661006153L,17307148601763L,113561761317421L,745141474228583L,4889285086978513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198447Inst : IEnumerable<long>
{
public static readonly long[] Value=A198447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198447.Bytes);
public long this[int i]=>Value[i];

public static A198447Inst Instance=new A198447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198448
{
public static readonly long[] Value={ 13L,177L,1399L,14109L,146187L,1532249L,16411255L,176845253L,1916108803L,20825391089L,226732488271L,2471217945565L,26951222470875L,294040889182217L,3208725606852775L,35019790320698997L,382232607221676979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198448Inst : IEnumerable<long>
{
public static readonly long[] Value=A198448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198448.Bytes);
public long this[int i]=>Value[i];

public static A198448Inst Instance=new A198448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198449
{
public static readonly BigInteger[] Value={ 71L,1399L,26704L,421185L,7302285L,128955464L,2298267371L,41395566911L,751621555932L,13730905146849L,252013755082625L,4641945567249588L,85732037231734899L,1586580667067965067L,BigInteger.Parse("29406033308587639544") };
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
public class A198449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198449Inst Instance=new A198449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198450
{
public static readonly BigInteger[] Value={ 433L,14109L,421185L,13048509L,396482929L,12354617337L,388054368497L,12268223577717L,389802133342121L,12442366745406193L,398756914767870161L,12824613775169911957UL,BigInteger.Parse("413731612612141327185"),BigInteger.Parse("13383113394670397174673") };
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
public class A198450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198450Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198450.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198450Inst Instance=new A198450Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198451
{
public static readonly long[] Value={ 2763L,146187L,7302285L,396482929L,22496409154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198451Inst : IEnumerable<long>
{
public static readonly long[] Value=A198451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198451.Bytes);
public long this[int i]=>Value[i];

public static A198451Inst Instance=new A198451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198452
{
public static readonly long[] Value={ 3L,13L,13L,71L,177L,71L,433L,1399L,1399L,433L,2763L,14109L,26704L,14109L,2763L,17941L,146187L,421185L,421185L,146187L,17941L,117263L,1532249L,7302285L,13048509L,7302285L,1532249L,117263L,768313L,16411255L,128955464L,396482929L,396482929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198452Inst : IEnumerable<long>
{
public static readonly long[] Value=A198452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198452.Bytes);
public long this[int i]=>Value[i];

public static A198452Inst Instance=new A198452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198453
{
public static readonly long[] Value={ 2L,2L,3L,3L,5L,6L,4L,9L,10L,5L,6L,8L,5L,14L,15L,6L,9L,11L,6L,20L,21L,7L,27L,28L,8L,10L,13L,8L,35L,36L,9L,13L,16L,9L,21L,23L,9L,44L,45L,10L,26L,28L,10L,54L,55L,11L,14L,18L,11L,20L,23L,11L,65L,66L,12L,17L,21L,12L,24L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198453Inst : IEnumerable<long>
{
public static readonly long[] Value=A198453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198453.Bytes);
public long this[int i]=>Value[i];

public static A198453Inst Instance=new A198453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198454
{
public static readonly long[] Value={ 2L,3L,4L,5L,5L,6L,6L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,11L,12L,12L,12L,13L,13L,14L,14L,14L,14L,14L,15L,15L,15L,16L,17L,17L,17L,17L,18L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,23L,23L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198454Inst : IEnumerable<long>
{
public static readonly long[] Value=A198454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198454.Bytes);
public long this[int i]=>Value[i];

public static A198454Inst Instance=new A198454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198455
{
public static readonly long[] Value={ 2L,5L,9L,6L,14L,9L,20L,27L,10L,35L,13L,21L,44L,26L,54L,14L,20L,65L,17L,24L,77L,44L,90L,14L,18L,33L,51L,104L,21L,38L,119L,135L,22L,49L,75L,152L,25L,55L,84L,170L,35L,45L,189L,26L,39L,50L,68L,209L,29L,35L,75L,114L,230L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198455Inst : IEnumerable<long>
{
public static readonly long[] Value=A198455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198455.Bytes);
public long this[int i]=>Value[i];

public static A198455Inst Instance=new A198455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198456
{
public static readonly long[] Value={ 3L,6L,10L,8L,15L,11L,21L,28L,13L,36L,16L,23L,45L,28L,55L,18L,23L,66L,21L,27L,78L,46L,91L,20L,23L,36L,53L,105L,26L,41L,120L,136L,28L,52L,77L,153L,31L,58L,86L,171L,40L,49L,190L,33L,44L,54L,71L,210L,36L,41L,78L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198456Inst : IEnumerable<long>
{
public static readonly long[] Value=A198456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198456.Bytes);
public long this[int i]=>Value[i];

public static A198456Inst Instance=new A198456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198457
{
public static readonly long[] Value={ 3L,6L,7L,4L,4L,6L,5L,16L,17L,6L,10L,12L,7L,8L,11L,7L,30L,31L,8L,18L,20L,9L,14L,17L,9L,48L,49L,10L,12L,16L,10L,28L,30L,11L,70L,71L,12L,18L,22L,12L,40L,42L,13L,16L,21L,13L,30L,33L,13L,96L,97L,14L,25L,29L,14L,54L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198457Inst : IEnumerable<long>
{
public static readonly long[] Value=A198457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198457.Bytes);
public long this[int i]=>Value[i];

public static A198457Inst Instance=new A198457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198458
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,19L,19L,19L,20L,20L,21L,21L,21L,22L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,28L,28L,29L,30L,30L,30L,30L,30L,30L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198458Inst : IEnumerable<long>
{
public static readonly long[] Value=A198458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198458.Bytes);
public long this[int i]=>Value[i];

public static A198458Inst Instance=new A198458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198459
{
public static readonly long[] Value={ 6L,4L,16L,10L,8L,30L,18L,14L,48L,12L,28L,70L,18L,40L,16L,30L,96L,25L,54L,22L,40L,126L,20L,33L,70L,160L,26L,42L,88L,24L,64L,198L,52L,108L,30L,78L,240L,28L,40L,63L,130L,54L,286L,34L,48L,75L,154L,32L,64L,110L,336L,88L,180L,38L,128L,390L,28L,36L,66L,102L,208L,448L,33L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198459Inst : IEnumerable<long>
{
public static readonly long[] Value=A198459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198459.Bytes);
public long this[int i]=>Value[i];

public static A198459Inst Instance=new A198459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198460
{
public static readonly long[] Value={ 7L,6L,17L,12L,11L,31L,20L,17L,49L,16L,30L,71L,22L,42L,21L,33L,97L,29L,56L,27L,43L,127L,26L,37L,72L,161L,32L,46L,90L,31L,67L,199L,56L,110L,37L,81L,241L,36L,46L,67L,132L,59L,287L,42L,54L,79L,156L,41L,69L,113L,337L,92L,182L,47L,131L,391L,40L,46L,72L,106L,210L,449L,45L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198460Inst : IEnumerable<long>
{
public static readonly long[] Value=A198460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198460.Bytes);
public long this[int i]=>Value[i];

public static A198460Inst Instance=new A198460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198461
{
public static readonly long[] Value={ 2L,3L,4L,3L,7L,8L,4L,12L,13L,5L,18L,19L,6L,6L,9L,6L,11L,13L,6L,25L,26L,7L,15L,17L,7L,33L,34L,8L,42L,43L,9L,10L,14L,9L,15L,18L,9L,52L,53L,10L,30L,32L,10L,63L,64L,11L,36L,38L,11L,75L,76L,12L,14L,19L,12L,19L,23L,12L,27L,30L,12L,88L,89L,13L,102L,103L,14L,57L,59L,14L,117L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198461Inst : IEnumerable<long>
{
public static readonly long[] Value=A198461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198461.Bytes);
public long this[int i]=>Value[i];

public static A198461Inst Instance=new A198461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198462
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,6L,6L,7L,7L,8L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,14L,14L,15L,15L,15L,15L,15L,16L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,27L,27L,27L,27L,27L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198462Inst : IEnumerable<long>
{
public static readonly long[] Value=A198462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198462.Bytes);
public long this[int i]=>Value[i];

public static A198462Inst Instance=new A198462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198463
{
public static readonly long[] Value={ 3L,7L,12L,18L,6L,11L,25L,15L,33L,42L,10L,15L,52L,30L,63L,36L,75L,14L,19L,27L,88L,102L,75L,117L,18L,23L,42L,65L,133L,150L,30L,39L,168L,22L,27L,60L,92L,187L,102L,207L,42L,54L,228L,22L,26L,31L,81L,250L,51L,135L,273L,147L,297L,30L,35L,105L,322L,45L,66L,84L,348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198463Inst : IEnumerable<long>
{
public static readonly long[] Value=A198463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198463.Bytes);
public long this[int i]=>Value[i];

public static A198463Inst Instance=new A198463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198464
{
public static readonly long[] Value={ 4L,8L,13L,19L,9L,13L,26L,17L,34L,43L,14L,18L,53L,32L,64L,38L,76L,19L,23L,30L,89L,103L,59L,118L,24L,28L,42L,67L,134L,151L,35L,43L,169L,29L,33L,63L,94L,188L,104L,208L,47L,58L,229L,31L,34L,38L,84L,251L,56L,137L,274L,149L,298L,39L,43L,108L,323L,52L,71L,88L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198464Inst : IEnumerable<long>
{
public static readonly long[] Value=A198464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198464.Bytes);
public long this[int i]=>Value[i];

public static A198464Inst Instance=new A198464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198465
{
public static readonly long[] Value={ 3L,3L,4L,4L,6L,7L,5L,10L,11L,6L,7L,9L,6L,15L,16L,7L,10L,12L,7L,21L,22L,8L,28L,29L,9L,11L,14L,9L,36L,37L,10L,14L,17L,10L,22L,24L,10L,45L,46L,11L,27L,29L,11L,55L,56L,12L,15L,19L,12L,21L,24L,12L,66L,67L,13L,18L,22L,13L,25L,28L,13L,78L,79L,14L,45L,47L,14L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198465Inst : IEnumerable<long>
{
public static readonly long[] Value=A198465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198465.Bytes);
public long this[int i]=>Value[i];

public static A198465Inst Instance=new A198465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198466
{
public static readonly long[] Value={ 3L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,10L,11L,11L,12L,12L,12L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,17L,18L,18L,18L,18L,19L,19L,19L,19L,20L,20L,20L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198466Inst : IEnumerable<long>
{
public static readonly long[] Value=A198466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198466.Bytes);
public long this[int i]=>Value[i];

public static A198466Inst Instance=new A198466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198467
{
public static readonly long[] Value={ 3L,6L,10L,7L,15L,10L,21L,28L,11L,36L,14L,22L,45L,27L,55L,15L,21L,66L,18L,25L,78L,45L,91L,15L,19L,34L,52L,105L,22L,39L,120L,136L,23L,50L,76L,153L,26L,56L,85L,171L,36L,46L,190L,27L,40L,51L,69L,210L,30L,36L,76L,115L,231L,126L,253L,31L,91L,276L,34L,58L,99L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198467Inst : IEnumerable<long>
{
public static readonly long[] Value=A198467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198467.Bytes);
public long this[int i]=>Value[i];

public static A198467Inst Instance=new A198467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198468
{
public static readonly long[] Value={ 4L,7L,11L,9L,16L,12L,22L,29L,14L,37L,17L,24L,46L,29L,56L,19L,24L,67L,22L,28L,79L,47L,92L,21L,24L,37L,54L,106L,27L,42L,121L,137L,29L,53L,78L,154L,32L,59L,87L,172L,41L,50L,191L,34L,45L,55L,72L,211L,37L,42L,79L,117L,232L,128L,254L,39L,94L,277L,42L,63L,102L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198468Inst : IEnumerable<long>
{
public static readonly long[] Value=A198468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198468.Bytes);
public long this[int i]=>Value[i];

public static A198468Inst Instance=new A198468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198469
{
public static readonly long[] Value={ 1129L,113L,139L,139L,23L,47L,7L,7L,37L,67L,67L,37L,127L,3L,3L,5L,41L,11L,17L,5L,5L,5L,29L,71L,11L,101L,2L,2L,2L,101L,107L,2L,2L,71L,71L,191L,191L,227L,239L,281L,2L,197L,227L,107L,29L,569L,281L,821L,599L,1031L,521L,641L,659L,1229L,569L,1061L,1481L,2657L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198469Inst : IEnumerable<long>
{
public static readonly long[] Value=A198469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198469.Bytes);
public long this[int i]=>Value[i];

public static A198469Inst Instance=new A198469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198470
{
public static readonly long[] Value={ 12L,18L,24L,36L,40L,48L,54L,56L,60L,72L,80L,84L,96L,100L,108L,112L,120L,126L,132L,140L,144L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L,204L,208L,216L,224L,228L,234L,240L,252L,264L,270L,276L,280L,288L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198470Inst : IEnumerable<long>
{
public static readonly long[] Value=A198470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198470.Bytes);
public long this[int i]=>Value[i];

public static A198470Inst Instance=new A198470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198471
{
public static readonly long[] Value={ 20L,30L,42L,66L,70L,78L,88L,102L,104L,114L,138L,150L,174L,246L,258L,260L,272L,282L,294L,304L,308L,318L,330L,340L,354L,364L,366L,368L,380L,390L,402L,426L,438L,450L,460L,462L,464L,474L,476L,498L,510L,532L,534L,546L,550L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198471Inst : IEnumerable<long>
{
public static readonly long[] Value=A198471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198471.Bytes);
public long this[int i]=>Value[i];

public static A198471Inst Instance=new A198471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198472
{
public static readonly long[] Value={ 2L,2L,2L,6L,6L,4L,4L,6L,6L,8L,6L,18L,8L,18L,8L,18L,18L,10L,10L,12L,12L,14L,12L,30L,14L,30L,14L,30L,30L,16L,16L,18L,18L,20L,18L,42L,20L,42L,20L,42L,42L,54L,24L,24L,28L,54L,24L,28L,30L,54L,28L,32L,54L,28L,28L,30L,30L,32L,30L,66L,32L,66L,32L,66L,66L,78L,36L,36L,40L,78L,36L,40L,42L,78L,40L,44L,78L,40L,40L,42L,42L,44L,42L,90L,44L,90L,44L,90L,90L,52L,48L,48L,50L,50L,48L,52L,50L,54L,50L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198472Inst : IEnumerable<long>
{
public static readonly long[] Value=A198472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198472.Bytes);
public long this[int i]=>Value[i];

public static A198472Inst Instance=new A198472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198473
{
public static readonly long[] Value={ 0L,1L,4L,2L,8L,3L,12L,5L,16L,6L,20L,7L,24L,9L,28L,10L,32L,11L,36L,13L,40L,14L,44L,15L,48L,17L,52L,18L,56L,19L,60L,21L,64L,22L,68L,23L,72L,25L,76L,26L,80L,27L,84L,29L,88L,30L,92L,31L,96L,33L,100L,34L,104L,35L,108L,37L,112L,38L,116L,39L,120L,41L,124L,42L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198473Inst : IEnumerable<long>
{
public static readonly long[] Value=A198473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198473.Bytes);
public long this[int i]=>Value[i];

public static A198473Inst Instance=new A198473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198474
{
public static readonly long[] Value={ 2L,12L,76L,492L,3212L,21036L,137932L,904812L,5936396L,38950572L,255572812L,1676946156L,11003350412L,72199015212L,473737530316L,3108453529452L,20396281280012L,133831275048876L,878140974959692L,5761968373855212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198474Inst : IEnumerable<long>
{
public static readonly long[] Value=A198474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198474.Bytes);
public long this[int i]=>Value[i];

public static A198474Inst Instance=new A198474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198475
{
public static readonly BigInteger[] Value={ 12L,252L,6104L,153222L,3935188L,101884208L,2646874462L,68861880812L,1792520780552L,46671361129270L,1215282911633348L,31646146096635168L,824083171352362894L,BigInteger.Parse("21459718004443762012"),BigInteger.Parse("558827923845866912376") };
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
public class A198475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198475Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198475.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198475.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198475Inst Instance=new A198475Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198476
{
public static readonly BigInteger[] Value={ 76L,6104L,636636L,72691500L,8603604942L,1033040477928L,124663962280912L,15071363660899808L,1823268135974847902L,BigInteger.Parse("220624354578524466374"),BigInteger.Parse("26698969327372019396108"),BigInteger.Parse("3231092587816932360442484") };
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
public class A198476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198476Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198476.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198476.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198476Inst Instance=new A198476Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198477
{
public static readonly long[] Value={ 2L,12L,12L,76L,252L,76L,492L,6104L,6104L,492L,3212L,153222L,636636L,153222L,3212L,21036L,3935188L,72691500L,72691500L,3935188L,21036L,137932L,101884208L,8603604942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198477Inst : IEnumerable<long>
{
public static readonly long[] Value=A198477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198477.Bytes);
public long this[int i]=>Value[i];

public static A198477Inst Instance=new A198477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198478
{
public static readonly BigInteger[] Value={ 0L,9L,41472L,14348907L,1719926784L,115330078125L,5355700839936L,193010051319183L,5777633090469888L,150094635296999121L,3486784401000000000L,BigInteger.Parse("73994897046174912819"),BigInteger.Parse("1457274373159131021312"),BigInteger.Parse("26955214582765006137717") };
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
public class A198478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198478.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198478Inst Instance=new A198478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198479
{
public static readonly BigInteger[] Value={ 0L,10L,102400L,59049000L,10485760000L,976562500000L,60466176000000L,2824752490000000L,107374182400000000L,3486784401000000000L,BigInteger.Parse("100000000000000000000"),BigInteger.Parse("2593742460100000000000"),BigInteger.Parse("61917364224000000000000") };
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
public class A198479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198479.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198479Inst Instance=new A198479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198480
{
public static readonly long[] Value={ 1L,13L,97L,685L,4801L,33613L,235297L,1647085L,11529601L,80707213L,564950497L,3954653485L,27682574401L,193778020813L,1356446145697L,9495123019885L,66465861139201L,465261027974413L,3256827195820897L,22797790370746285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198480Inst : IEnumerable<long>
{
public static readonly long[] Value=A198480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198480.Bytes);
public long this[int i]=>Value[i];

public static A198480Inst Instance=new A198480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198481
{
public static readonly BigInteger[] Value={ 1L,1L,240L,304819200L,3440500260470784000L,BigInteger.Parse("1827912356210202139164672000000000"),BigInteger.Parse("13482302715547740229948201750717130814259200000000000") };
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
public class A198481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198481.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198481Inst Instance=new A198481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198482
{
public static readonly BigInteger[] Value={ 5L,193L,10072L,528283L,27711478L,1453628917L,76251331828L,3999827976463L,209814352850962L,11005988987858473L,577328442763429648L,BigInteger.Parse("30284250801208664707"),BigInteger.Parse("1588585939401430092718"),BigInteger.Parse("83330616412779323165533") };
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
public class A198482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198482Inst Instance=new A198482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198483
{
public static readonly BigInteger[] Value={ 193L,333308L,579476701L,1007486056500L,1751630302786777L,3045410673315147020L,BigInteger.Parse("5294796602205290417269"),BigInteger.Parse("9205612663330831095993732"),BigInteger.Parse("16005016032539421751657150321"),BigInteger.Parse("27826560552805542982631002720412") };
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
public class A198483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198483.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198483Inst Instance=new A198483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198484
{
public static readonly BigInteger[] Value={ 10072L,579476701L,33408897045776L,1926147852876420067L,BigInteger.Parse("111049673372896355573468"),BigInteger.Parse("6402431748862885892818595024"),BigInteger.Parse("369124294364655578368535852718606") };
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
public class A198484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198484Inst Instance=new A198484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198485
{
public static readonly long[] Value={ 5L,193L,193L,10072L,333308L,10072L,528283L,579476701L,579476701L,528283L,27711478L,1007486056500L,33408897045776L,1007486056500L,27711478L,1453628917L,1751630302786777L,1926147852876420067L,1926147852876420067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198485Inst : IEnumerable<long>
{
public static readonly long[] Value=A198485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198485.Bytes);
public long this[int i]=>Value[i];

public static A198485Inst Instance=new A198485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198486
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,90L,909L,9090L,90909L,909090L,9090909L,90909090L,909090909L,9090909090L,90909090909L,909090909090L,9090909090909L,90909090909090L,909090909090909L,9090909090909090L,90909090909090909L,909090909090909090L,9090909090909090909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198486Inst : IEnumerable<long>
{
public static readonly long[] Value=A198486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198486.Bytes);
public long this[int i]=>Value[i];

public static A198486Inst Instance=new A198486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198487
{
public static readonly long[] Value={ 10L,1L,12L,1113L,4L,15L,6L,117L,8L,9L,25L,0L,26L,0L,27L,35L,28L,0L,36L,0L,45L,371L,0L,0L,38L,55L,0L,39L,74L,0L,56L,0L,48L,0L,0L,57L,49L,0L,0L,0L,58L,0L,76L,0L,0L,95L,0L,0L,68L,77L,255L,0L,0L,0L,69L,0L,78L,0L,0L,0L,256L,0L,0L,791L,88L,0L,0L,0L,0L,0L,275L,0L,98L,0L,0L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198487Inst : IEnumerable<long>
{
public static readonly long[] Value=A198487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198487.Bytes);
public long this[int i]=>Value[i];

public static A198487Inst Instance=new A198487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198488
{
public static readonly long[] Value={ 3L,0L,7L,9L,9L,7L,4L,1L,1L,6L,2L,9L,0L,7L,1L,9L,2L,4L,5L,5L,0L,9L,4L,4L,7L,2L,2L,0L,6L,3L,0L,7L,5L,7L,7L,7L,9L,4L,7L,6L,5L,6L,1L,2L,8L,7L,8L,9L,9L,9L,1L,7L,8L,6L,8L,6L,6L,4L,9L,5L,1L,7L,7L,6L,0L,4L,0L,8L,2L,0L,0L,2L,8L,6L,4L,0L,0L,4L,4L,8L,8L,0L,7L,9L,2L,0L,3L,3L,2L,6L,8L,1L,8L,6L,1L,9L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198488Inst : IEnumerable<long>
{
public static readonly long[] Value=A198488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198488.Bytes);
public long this[int i]=>Value[i];

public static A198488Inst Instance=new A198488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198489
{
public static readonly long[] Value={ 3L,8L,3L,3L,5L,6L,1L,0L,0L,7L,1L,6L,8L,5L,7L,4L,4L,2L,3L,4L,0L,1L,4L,9L,4L,5L,3L,0L,5L,7L,9L,9L,0L,1L,8L,0L,4L,6L,6L,2L,9L,2L,2L,3L,5L,5L,2L,6L,1L,7L,2L,0L,8L,3L,6L,9L,0L,2L,7L,5L,3L,7L,6L,9L,7L,2L,3L,2L,0L,7L,1L,8L,8L,8L,5L,5L,0L,9L,3L,0L,8L,5L,0L,4L,1L,7L,2L,0L,8L,1L,5L,8L,8L,8L,2L,4L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198489Inst : IEnumerable<long>
{
public static readonly long[] Value=A198489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198489.Bytes);
public long this[int i]=>Value[i];

public static A198489Inst Instance=new A198489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198490
{
public static readonly long[] Value={ 3L,7L,0L,9L,8L,6L,6L,6L,1L,0L,0L,6L,7L,4L,9L,7L,1L,9L,4L,1L,9L,4L,4L,7L,5L,1L,0L,1L,4L,5L,7L,3L,2L,6L,6L,6L,7L,5L,3L,5L,9L,3L,4L,5L,0L,0L,7L,3L,8L,4L,9L,0L,0L,3L,6L,1L,7L,3L,8L,0L,4L,5L,2L,9L,5L,0L,7L,2L,9L,5L,9L,4L,0L,4L,7L,2L,4L,1L,2L,2L,8L,0L,1L,9L,6L,5L,0L,2L,9L,8L,9L,5L,7L,0L,9L,2L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198490Inst : IEnumerable<long>
{
public static readonly long[] Value=A198490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198490.Bytes);
public long this[int i]=>Value[i];

public static A198490Inst Instance=new A198490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198491
{
public static readonly long[] Value={ 3L,6L,1L,9L,0L,6L,8L,6L,3L,6L,5L,5L,6L,5L,2L,9L,7L,6L,8L,4L,8L,5L,0L,6L,2L,0L,4L,1L,7L,6L,8L,8L,5L,0L,4L,6L,3L,2L,1L,7L,7L,2L,9L,7L,7L,6L,3L,5L,8L,8L,0L,1L,2L,4L,5L,1L,8L,8L,0L,5L,1L,1L,2L,4L,6L,9L,6L,8L,5L,7L,8L,5L,6L,3L,3L,7L,9L,4L,6L,4L,8L,8L,6L,4L,0L,2L,3L,5L,5L,6L,8L,8L,7L,2L,8L,9L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198491Inst : IEnumerable<long>
{
public static readonly long[] Value=A198491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198491.Bytes);
public long this[int i]=>Value[i];

public static A198491Inst Instance=new A198491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198492
{
public static readonly long[] Value={ 3L,5L,5L,1L,3L,1L,5L,4L,5L,6L,0L,0L,1L,2L,4L,3L,7L,1L,0L,2L,4L,7L,4L,5L,6L,6L,3L,1L,9L,6L,2L,5L,4L,3L,4L,7L,6L,9L,6L,0L,3L,5L,8L,1L,4L,9L,8L,0L,6L,5L,4L,1L,4L,3L,1L,5L,7L,0L,1L,7L,3L,6L,5L,0L,4L,5L,9L,7L,3L,0L,4L,8L,6L,7L,1L,5L,3L,6L,3L,7L,9L,8L,3L,6L,7L,9L,7L,3L,3L,0L,2L,7L,5L,9L,3L,4L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198492Inst : IEnumerable<long>
{
public static readonly long[] Value=A198492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198492.Bytes);
public long this[int i]=>Value[i];

public static A198492Inst Instance=new A198492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198493
{
public static readonly long[] Value={ 4L,6L,4L,4L,3L,5L,6L,5L,7L,2L,3L,9L,4L,6L,6L,7L,6L,0L,6L,1L,6L,1L,4L,6L,8L,6L,6L,1L,1L,4L,3L,5L,3L,8L,7L,0L,6L,3L,1L,5L,4L,2L,8L,2L,3L,0L,9L,0L,5L,3L,3L,8L,4L,5L,3L,2L,9L,7L,7L,5L,5L,0L,4L,8L,7L,3L,8L,4L,4L,0L,4L,4L,1L,3L,2L,6L,4L,4L,5L,1L,3L,6L,3L,4L,6L,0L,3L,3L,1L,3L,5L,0L,0L,6L,3L,8L,3L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198493Inst : IEnumerable<long>
{
public static readonly long[] Value=A198493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198493.Bytes);
public long this[int i]=>Value[i];

public static A198493Inst Instance=new A198493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198494
{
public static readonly long[] Value={ 8L,3L,2L,6L,0L,2L,2L,2L,1L,7L,6L,6L,6L,8L,9L,5L,5L,9L,5L,4L,1L,7L,0L,6L,5L,2L,0L,5L,9L,7L,9L,3L,4L,9L,7L,4L,0L,5L,6L,7L,1L,3L,1L,2L,5L,5L,3L,8L,7L,7L,4L,9L,7L,2L,1L,8L,6L,2L,5L,4L,5L,8L,6L,8L,8L,0L,9L,3L,6L,9L,0L,1L,6L,2L,4L,5L,2L,3L,1L,7L,9L,5L,6L,9L,8L,5L,6L,0L,4L,1L,6L,5L,2L,1L,2L,4L,9L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198494Inst : IEnumerable<long>
{
public static readonly long[] Value=A198494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198494.Bytes);
public long this[int i]=>Value[i];

public static A198494Inst Instance=new A198494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198495
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,1L,7L,4L,2L,4L,1L,8L,4L,5L,0L,0L,0L,9L,5L,3L,2L,1L,0L,1L,6L,8L,7L,5L,6L,3L,7L,5L,9L,2L,9L,9L,7L,8L,5L,4L,3L,8L,7L,0L,5L,2L,7L,8L,1L,4L,4L,4L,7L,5L,9L,2L,2L,8L,4L,4L,4L,0L,5L,7L,8L,4L,0L,2L,2L,2L,4L,7L,2L,5L,6L,5L,7L,9L,2L,9L,6L,1L,1L,1L,8L,2L,5L,1L,6L,4L,3L,8L,7L,2L,8L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198495Inst : IEnumerable<long>
{
public static readonly long[] Value=A198495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198495.Bytes);
public long this[int i]=>Value[i];

public static A198495Inst Instance=new A198495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198496
{
public static readonly long[] Value={ 5L,2L,2L,4L,3L,6L,6L,0L,9L,3L,9L,9L,3L,5L,1L,4L,3L,9L,8L,1L,5L,3L,5L,6L,9L,0L,7L,8L,8L,9L,5L,7L,8L,2L,9L,5L,6L,9L,9L,0L,5L,9L,3L,8L,8L,1L,2L,9L,6L,9L,2L,5L,8L,2L,6L,5L,6L,8L,2L,2L,8L,3L,1L,2L,2L,6L,7L,5L,9L,9L,7L,2L,1L,7L,4L,6L,6L,5L,4L,4L,8L,9L,2L,9L,0L,6L,1L,4L,1L,7L,1L,8L,6L,6L,4L,9L,5L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198496Inst : IEnumerable<long>
{
public static readonly long[] Value=A198496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198496.Bytes);
public long this[int i]=>Value[i];

public static A198496Inst Instance=new A198496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198497
{
public static readonly long[] Value={ 4L,4L,9L,9L,0L,5L,8L,6L,5L,9L,7L,0L,4L,6L,5L,3L,8L,8L,5L,5L,4L,4L,2L,8L,7L,6L,4L,9L,2L,6L,2L,1L,7L,8L,7L,2L,2L,8L,8L,9L,0L,1L,8L,3L,2L,5L,7L,6L,1L,0L,0L,7L,1L,0L,1L,8L,3L,8L,8L,4L,0L,0L,8L,6L,8L,0L,4L,6L,4L,9L,5L,8L,6L,2L,3L,1L,9L,0L,3L,9L,7L,7L,1L,0L,2L,6L,1L,9L,2L,3L,4L,3L,6L,9L,6L,5L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198497Inst : IEnumerable<long>
{
public static readonly long[] Value=A198497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198497.Bytes);
public long this[int i]=>Value[i];

public static A198497Inst Instance=new A198497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198498
{
public static readonly long[] Value={ 3L,2L,1L,8L,8L,0L,8L,9L,8L,7L,4L,2L,3L,6L,4L,2L,3L,9L,8L,6L,1L,8L,3L,3L,8L,4L,5L,3L,9L,4L,4L,7L,8L,4L,5L,2L,8L,3L,6L,6L,7L,9L,7L,7L,6L,7L,5L,0L,1L,1L,4L,2L,7L,1L,4L,3L,5L,1L,9L,1L,1L,2L,9L,3L,4L,6L,9L,1L,4L,8L,7L,1L,9L,1L,5L,2L,6L,7L,9L,1L,6L,3L,3L,1L,0L,6L,2L,4L,1L,3L,2L,0L,2L,7L,3L,6L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198498Inst : IEnumerable<long>
{
public static readonly long[] Value=A198498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198498.Bytes);
public long this[int i]=>Value[i];

public static A198498Inst Instance=new A198498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198499
{
public static readonly long[] Value={ 6L,0L,6L,4L,8L,1L,0L,5L,6L,5L,4L,6L,5L,5L,1L,7L,0L,0L,0L,6L,1L,5L,0L,5L,0L,8L,5L,3L,9L,8L,3L,0L,0L,8L,0L,7L,9L,7L,4L,5L,3L,7L,1L,9L,6L,7L,5L,4L,8L,0L,5L,9L,9L,4L,0L,1L,5L,2L,2L,0L,5L,8L,8L,2L,5L,1L,8L,6L,1L,8L,3L,7L,5L,1L,8L,3L,3L,7L,5L,0L,8L,2L,0L,8L,3L,2L,3L,8L,9L,4L,7L,2L,0L,2L,8L,3L,5L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198499Inst : IEnumerable<long>
{
public static readonly long[] Value=A198499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198499.Bytes);
public long this[int i]=>Value[i];

public static A198499Inst Instance=new A198499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198500
{
public static readonly long[] Value={ 8L,4L,6L,4L,0L,5L,6L,9L,7L,8L,9L,3L,2L,0L,6L,0L,9L,9L,9L,9L,4L,7L,6L,7L,5L,2L,0L,6L,4L,2L,8L,4L,4L,6L,2L,8L,3L,1L,1L,4L,3L,3L,9L,1L,0L,4L,9L,5L,6L,8L,2L,1L,6L,0L,5L,9L,2L,3L,0L,9L,2L,0L,2L,3L,3L,9L,2L,2L,7L,2L,9L,0L,4L,7L,7L,9L,9L,0L,8L,2L,8L,3L,6L,7L,4L,6L,5L,6L,9L,3L,5L,7L,4L,0L,0L,6L,2L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198500Inst : IEnumerable<long>
{
public static readonly long[] Value=A198500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198500.Bytes);
public long this[int i]=>Value[i];

public static A198500Inst Instance=new A198500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198501
{
public static readonly long[] Value={ 3L,2L,7L,4L,0L,9L,7L,7L,4L,2L,7L,7L,0L,3L,7L,5L,9L,2L,3L,3L,5L,6L,6L,4L,0L,8L,1L,0L,6L,2L,1L,0L,8L,2L,9L,2L,0L,9L,2L,6L,4L,1L,8L,9L,7L,5L,1L,2L,9L,1L,9L,2L,7L,4L,9L,4L,5L,7L,5L,1L,6L,6L,4L,8L,7L,2L,8L,9L,7L,7L,7L,6L,1L,2L,5L,5L,3L,7L,3L,1L,1L,3L,9L,4L,7L,6L,3L,0L,1L,8L,4L,0L,5L,1L,5L,1L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198501Inst : IEnumerable<long>
{
public static readonly long[] Value=A198501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198501.Bytes);
public long this[int i]=>Value[i];

public static A198501Inst Instance=new A198501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198502
{
public static readonly long[] Value={ 6L,2L,4L,2L,0L,9L,2L,8L,7L,0L,4L,8L,3L,2L,7L,5L,5L,8L,0L,0L,5L,9L,4L,1L,4L,5L,0L,4L,3L,9L,2L,0L,0L,8L,2L,8L,5L,7L,6L,6L,9L,3L,7L,0L,8L,3L,5L,4L,9L,8L,5L,7L,4L,5L,3L,2L,6L,6L,4L,6L,6L,2L,5L,1L,6L,3L,1L,3L,3L,3L,7L,2L,1L,0L,9L,4L,2L,8L,2L,2L,0L,8L,9L,1L,4L,0L,5L,8L,5L,0L,7L,6L,3L,7L,7L,5L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198502Inst : IEnumerable<long>
{
public static readonly long[] Value=A198502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198502.Bytes);
public long this[int i]=>Value[i];

public static A198502Inst Instance=new A198502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198503
{
public static readonly long[] Value={ 2L,4L,7L,4L,5L,6L,3L,5L,6L,7L,7L,0L,3L,8L,9L,8L,7L,2L,7L,3L,0L,3L,2L,8L,7L,7L,6L,3L,3L,7L,9L,9L,3L,7L,2L,5L,2L,6L,1L,6L,4L,9L,4L,0L,2L,8L,4L,0L,2L,1L,2L,8L,3L,8L,1L,5L,0L,3L,2L,6L,6L,1L,6L,9L,5L,3L,9L,4L,2L,8L,1L,2L,1L,8L,3L,3L,6L,6L,1L,7L,2L,0L,2L,0L,5L,9L,0L,5L,1L,2L,0L,2L,2L,1L,7L,6L,2L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198503Inst : IEnumerable<long>
{
public static readonly long[] Value=A198503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198503.Bytes);
public long this[int i]=>Value[i];

public static A198503Inst Instance=new A198503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198504
{
public static readonly long[] Value={ 6L,9L,1L,6L,2L,1L,3L,6L,4L,6L,2L,5L,5L,8L,4L,5L,3L,2L,0L,0L,7L,1L,1L,6L,4L,0L,3L,1L,3L,7L,2L,6L,4L,0L,7L,3L,7L,9L,1L,5L,6L,4L,1L,1L,5L,9L,4L,9L,1L,0L,0L,0L,9L,7L,2L,7L,7L,7L,7L,6L,3L,5L,3L,5L,0L,5L,0L,2L,7L,9L,8L,7L,5L,4L,7L,0L,2L,8L,1L,8L,5L,5L,3L,9L,2L,9L,9L,5L,4L,8L,3L,1L,2L,7L,6L,6L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198504Inst : IEnumerable<long>
{
public static readonly long[] Value=A198504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198504.Bytes);
public long this[int i]=>Value[i];

public static A198504Inst Instance=new A198504Inst();

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