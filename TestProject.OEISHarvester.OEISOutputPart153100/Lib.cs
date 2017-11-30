using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A182405
{
public static readonly long[] Value={ 0L,8L,10L,24L,28L,34L,46L,52L,58L,66L,78L,80L,94L,96L,126L,134L,162L,166L,180L,208L,240L,258L,270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182405Inst : IEnumerable<long>
{
public static readonly long[] Value=A182405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182405.Bytes);
public long this[int i]=>Value[i];

public static A182405Inst Instance=new A182405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182406
{
public static readonly long[] Value={ 1L,0L,2L,0L,2L,3L,0L,2L,18L,4L,0L,2L,246L,84L,5L,0L,2L,7812L,9612L,260L,6L,0L,2L,580986L,6000732L,142820L,630L,7L,0L,2L,101596896L,20442892764L,828850160L,1166910L,1302L,8L,0L,2L,41869995708L,380053267505964L,50820390410180L,38128724910L,6464682L,2408L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182406Inst : IEnumerable<long>
{
public static readonly long[] Value=A182406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182406.Bytes);
public long this[int i]=>Value[i];

public static A182406Inst Instance=new A182406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182407
{
public static readonly BigInteger[] Value={ 2L,9L,34L,982L,11284L,1048768L,48027971L,23807996588L,3430123782371L,8141109957322587L,4098570575535958632L,BigInteger.Parse("46676507893324203092812"),BigInteger.Parse("77374614378004006943995980") };
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
public class A182407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182407Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182407.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182407Inst Instance=new A182407Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182408
{
public static readonly long[] Value={ 2L,7L,34L,743L,1546L,598078L,6027057L,10163241031L,242407820869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182408Inst : IEnumerable<long>
{
public static readonly long[] Value=A182408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182408.Bytes);
public long this[int i]=>Value[i];

public static A182408Inst Instance=new A182408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182409
{
public static readonly long[] Value={ -1583L,-1567L,-1543L,-1511L,-1471L,-1423L,-1367L,-1303L,-1231L,-1151L,-1063L,-967L,-863L,-751L,-631L,-503L,-367L,-223L,-71L,89L,257L,433L,617L,809L,1009L,1217L,1433L,1657L,1889L,2129L,2377L,2633L,2897L,3169L,3449L,3737L,4033L,4337L,4649L,4969L,5297L,5633L,5977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182409Inst : IEnumerable<long>
{
public static readonly long[] Value=A182409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182409.Bytes);
public long this[int i]=>Value[i];

public static A182409Inst Instance=new A182409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182410
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,7L,7L,11L,11L,15L,17L,24L,25L,31L,34L,45L,48L,59L,64L,77L,83L,99L,109L,131L,138L,164L,175L,204L,222L,252L,274L,317L,332L,385L,403L,466L,500L,563L,592L,674L,720L,799L,854L,957L,994L,1131L,1196L,1328L,1395L,1551L,1627L,1817L,1912L,2098L,2197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182410Inst : IEnumerable<long>
{
public static readonly long[] Value=A182410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182410.Bytes);
public long this[int i]=>Value[i];

public static A182410Inst Instance=new A182410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182411
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,6L,20L,10L,12L,20L,70L,28L,28L,40L,70L,252L,84L,72L,90L,140L,252L,924L,264L,198L,220L,308L,504L,924L,3432L,858L,572L,572L,728L,1092L,1848L,3432L,12870L,2860L,1716L,1560L,1820L,2520L,3960L,6864L,12870L,48620L,9724L,5304L,4420L,4760L,6120L,8976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182411Inst : IEnumerable<long>
{
public static readonly long[] Value=A182411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182411.Bytes);
public long this[int i]=>Value[i];

public static A182411Inst Instance=new A182411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182412
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,3L,5L,17L,19L,7L,11L,48L,80L,60L,17L,21L,119L,270L,308L,177L,41L,43L,290L,823L,1256L,1087L,506L,99L,85L,677L,2321L,4447L,5147L,3601L,1411L,239L,171L,1556L,6234L,14360L,20806L,19424L,11416L,3864L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182412Inst : IEnumerable<long>
{
public static readonly long[] Value=A182412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182412.Bytes);
public long this[int i]=>Value[i];

public static A182412Inst Instance=new A182412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182413
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,2L,5L,5L,4L,4L,2L,0L,2L,3L,0L,6L,3L,3L,4L,3L,2L,4L,0L,1L,2L,3L,0L,5L,1L,3L,4L,1L,2L,6L,2L,2L,1L,6L,0L,2L,3L,1L,5L,2L,5L,3L,4L,2L,6L,5L,1L,3L,4L,6L,3L,4L,2L,1L,4L,2L,2L,3L,6L,2L,4L,4L,7L,4L,2L,8L,2L,0L,4L,4L,1L,1L,5L,2L,5L,2L,4L,10L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182413Inst : IEnumerable<long>
{
public static readonly long[] Value=A182413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182413.Bytes);
public long this[int i]=>Value[i];

public static A182413Inst Instance=new A182413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182414
{
public static readonly long[] Value={ 0L,2L,4L,4L,5L,7L,8L,11L,9L,10L,16L,13L,0L,23L,16L,23L,28L,18L,20L,23L,22L,30L,0L,29L,26L,47L,28L,42L,0L,33L,41L,0L,42L,48L,37L,45L,53L,38L,57L,46L,0L,70L,66L,52L,45L,0L,49L,81L,58L,50L,74L,86L,0L,57L,56L,94L,57L,0L,64L,80L,96L,64L,72L,97L,77L,87L,0L,104L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182414Inst : IEnumerable<long>
{
public static readonly long[] Value=A182414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182414.Bytes);
public long this[int i]=>Value[i];

public static A182414Inst Instance=new A182414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182415
{
public static readonly long[] Value={ 1L,2L,7L,13L,24L,41L,69L,114L,187L,305L,496L,805L,1305L,2114L,3423L,5541L,8968L,14513L,23485L,38002L,61491L,99497L,160992L,260493L,421489L,681986L,1103479L,1785469L,2888952L,4674425L,7563381L,12237810L,19801195L,32039009L,51840208L,83879221L,135719433L,219598658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182415Inst : IEnumerable<long>
{
public static readonly long[] Value=A182415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182415.Bytes);
public long this[int i]=>Value[i];

public static A182415Inst Instance=new A182415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182416
{
public static readonly long[] Value={ 29341L,34901461L,775368901L,1213619761L,4562359201L,9293756581L,72725349421L,672508205281L,707161856941L,779999961061L,983598759361L,1671885346141L,1800095194261L,3459443867461L,6513448976101L,8369282635561L,8740624114081L,12588478268761L,16260021568801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182416Inst : IEnumerable<long>
{
public static readonly long[] Value=A182416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182416.Bytes);
public long this[int i]=>Value[i];

public static A182416Inst Instance=new A182416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182417
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,11L,10L,9L,12L,16L,21L,17L,22L,20L,18L,23L,19L,24L,31L,25L,32L,41L,36L,46L,38L,48L,61L,51L,64L,81L,70L,88L,79L,93L,75L,90L,77L,95L,73L,92L,76L,96L,121L,104L,115L,112L,109L,119L,107L,114L,111L,117L,105L,116L,106L,113L,110L,118L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182417Inst : IEnumerable<long>
{
public static readonly long[] Value=A182417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182417.Bytes);
public long this[int i]=>Value[i];

public static A182417Inst Instance=new A182417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182418
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,10L,12L,15L,14L,13L,16L,19L,17L,20L,24L,29L,26L,31L,27L,32L,38L,33L,37L,36L,35L,39L,34L,40L,47L,41L,48L,57L,49L,58L,52L,61L,56L,50L,59L,51L,60L,55L,63L,54L,64L,75L,72L,69L,79L,67L,73L,70L,78L,68L,80L,94L,82L,96L,113L,100L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182418Inst : IEnumerable<long>
{
public static readonly long[] Value=A182418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182418.Bytes);
public long this[int i]=>Value[i];

public static A182418Inst Instance=new A182418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182419
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,14L,16L,19L,18L,17L,20L,23L,22L,21L,24L,28L,32L,37L,34L,39L,36L,33L,38L,35L,40L,46L,44L,42L,48L,55L,50L,53L,52L,51L,54L,49L,56L,64L,73L,65L,74L,68L,77L,69L,78L,72L,66L,75L,67L,76L,70L,79L,71L,80L,91L,81L,92L,88L,84L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182419Inst : IEnumerable<long>
{
public static readonly long[] Value=A182419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182419.Bytes);
public long this[int i]=>Value[i];

public static A182419Inst Instance=new A182419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182420
{
public static readonly BigInteger[] Value={ 0L,1L,6L,15L,44L,205L,1218L,8547L,68440L,615897L,6158910L,67747911L,812974980L,10568674805L,147961447354L,2219421710235L,35510747363504L,603682705179313L,10866288693227382L,206459485171319935L,4129189703426398300L,BigInteger.Parse("86712983771954363901") };
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
public class A182420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182420Inst Instance=new A182420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182421
{
public static readonly BigInteger[] Value={ 1L,2L,130L,4376L,312706L,20156252L,1622278624L,132282417920L,11716609750402L,1067553850832372L,101275413131018380L,9844149854624122160UL,BigInteger.Parse("980597565209377223200"),BigInteger.Parse("99518148302583383833280"),BigInteger.Parse("10272819477206557916630080"),BigInteger.Parse("1075608762378043981968997376") };
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
public class A182421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182421Inst Instance=new A182421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182422
{
public static readonly BigInteger[] Value={ 1L,2L,258L,13124L,1810690L,200781252L,30729140484L,4579408029576L,770670360699138L,132018919625044100L,BigInteger.Parse("23913739057463037508"),BigInteger.Parse("4433505541977804821256"),BigInteger.Parse("848185646293853978499844"),BigInteger.Parse("165563367990287610967653512"),BigInteger.Parse("32993144260428865295508700680") };
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
public class A182422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182422Inst Instance=new A182422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182423
{
public static readonly long[] Value={ 0L,2L,0L,1L,1L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,3L,0L,1L,0L,3L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,2L,0L,0L,0L,1L,0L,2L,1L,2L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182423Inst : IEnumerable<long>
{
public static readonly long[] Value=A182423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182423.Bytes);
public long this[int i]=>Value[i];

public static A182423Inst Instance=new A182423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182424
{
public static readonly long[] Value={ 1L,2L,6L,8L,11L,12L,18L,30L,32L,39L,41L,44L,50L,63L,65L,69L,72L,74L,75L,78L,86L,93L,104L,107L,110L,123L,126L,140L,149L,153L,158L,165L,177L,179L,182L,186L,188L,189L,215L,218L,222L,225L,236L,237L,239L,254L,264L,267L,272L,278L,296L,299L,302L,305L,314L,320L,327L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182424Inst : IEnumerable<long>
{
public static readonly long[] Value=A182424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182424.Bytes);
public long this[int i]=>Value[i];

public static A182424Inst Instance=new A182424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182425
{
public static readonly long[] Value={ 4L,3L,2L,1L,0L,2L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182425Inst : IEnumerable<long>
{
public static readonly long[] Value=A182425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182425.Bytes);
public long this[int i]=>Value[i];

public static A182425Inst Instance=new A182425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182426
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,3L,2L,1L,2L,1L,2L,1L,4L,3L,2L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,4L,3L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,3L,2L,1L,2L,1L,1L,2L,1L,2L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182426Inst : IEnumerable<long>
{
public static readonly long[] Value=A182426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182426.Bytes);
public long this[int i]=>Value[i];

public static A182426Inst Instance=new A182426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182427
{
public static readonly long[] Value={ 10L,15L,28L,45L,55L,91L,136L,190L,210L,231L,253L,325L,378L,406L,435L,496L,561L,595L,666L,703L,741L,820L,861L,903L,946L,990L,1081L,1128L,1176L,1225L,1378L,1431L,1540L,1596L,1711L,1770L,1830L,1891L,2080L,2145L,2211L,2278L,2346L,2415L,2485L,2556L,2701L,2926L,3160L,3321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182427Inst : IEnumerable<long>
{
public static readonly long[] Value=A182427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182427.Bytes);
public long this[int i]=>Value[i];

public static A182427Inst Instance=new A182427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182428
{
public static readonly long[] Value={ 0L,36L,68L,96L,120L,140L,156L,168L,176L,180L,180L,176L,168L,156L,140L,120L,96L,68L,36L,0L,-40L,-84L,-132L,-184L,-240L,-300L,-364L,-432L,-504L,-580L,-660L,-744L,-832L,-924L,-1020L,-1120L,-1224L,-1332L,-1444L,-1560L,-1680L,-1804L,-1932L,-2064L,-2200L,-2340L,-2484L,-2632L,-2784L,-2940L,-3100L,-3264L,-3432L,-3604L,-3780L,-3960L,-4144L,-4332L,-4524L,-4720L,-4920L,-5124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182428Inst : IEnumerable<long>
{
public static readonly long[] Value=A182428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182428.Bytes);
public long this[int i]=>Value[i];

public static A182428Inst Instance=new A182428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182429
{
public static readonly long[] Value={ 1L,1L,6L,1L,1L,5L,1L,1L,1L,1L,4L,1L,1L,1L,3L,3L,1L,1L,2L,4L,1L,1L,5L,1L,1L,1L,1L,4L,1L,1L,1L,2L,4L,1L,1L,6L,1L,1L,1L,4L,1L,1L,1L,1L,4L,1L,1L,1L,1L,5L,1L,1L,6L,1L,1L,1L,4L,1L,1L,1L,1L,4L,1L,1L,1L,6L,1L,1L,1L,1L,1L,3L,1L,1L,2L,3L,1L,1L,1L,1L,2L,2L,1L,1L,1L,2L,3L,1L,1L,1L,6L,1L,1L,5L,1L,1L,1L,1L,4L,1L,1L,1L,3L,3L,1L,1L,6L,1L,1L,1L,2L,2L,1L,1L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182429Inst : IEnumerable<long>
{
public static readonly long[] Value=A182429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182429.Bytes);
public long this[int i]=>Value[i];

public static A182429Inst Instance=new A182429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182430
{
public static readonly long[] Value={ 1L,0L,0L,1L,8L,56L,408L,3228L,28032L,267264L,2787840L,31662720L,389560320L,5166650880L,73528680960L,1118124000000L,18098712576000L,310759981056000L,5642339254272000L,108022399414272000L,2175029897822208000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182430Inst : IEnumerable<long>
{
public static readonly long[] Value=A182430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182430.Bytes);
public long this[int i]=>Value[i];

public static A182430Inst Instance=new A182430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182431
{
public static readonly long[] Value={ 0L,14L,4L,0L,14L,7L,12L,1L,14L,8L,98L,4L,2L,14L,10L,602L,35L,0L,3L,14L,11L,3540L,218L,0L,4L,4L,14L,12L,20664L,1285L,2L,21L,4L,5L,14L,13L,120470L,7504L,14L,122L,14L,8L,6L,14L,14L,702182L,43751L,84L,711L,74L,35L,12L,7L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182431Inst : IEnumerable<long>
{
public static readonly long[] Value=A182431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182431.Bytes);
public long this[int i]=>Value[i];

public static A182431Inst Instance=new A182431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182432
{
public static readonly long[] Value={ 1L,4L,28L,217L,1705L,13420L,105652L,831793L,6548689L,51557716L,405913036L,3195746569L,25160059513L,198084729532L,1559517776740L,12278057484385L,96664942098337L,761041479302308L,5991666892320124L,47172293659258681L,371386682381749321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182432Inst : IEnumerable<long>
{
public static readonly long[] Value=A182432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182432.Bytes);
public long this[int i]=>Value[i];

public static A182432Inst Instance=new A182432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182433
{
public static readonly BigInteger[] Value={ 7L,547L,29347L,1308247L,652312447L,180110691547L,65335225716547L,38733853511213647L,4368761145612023947L,BigInteger.Parse("1804216772228848838647"),BigInteger.Parse("14884872991210984993091647"),BigInteger.Parse("9816873967836575781598117447"),BigInteger.Parse("143397994078495393809327283088347") };
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
public class A182433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182433Inst Instance=new A182433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182434
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182434Inst : IEnumerable<long>
{
public static readonly long[] Value=A182434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182434.Bytes);
public long this[int i]=>Value[i];

public static A182434Inst Instance=new A182434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182435
{
public static readonly long[] Value={ 0L,1L,4L,21L,120L,697L,4060L,23661L,137904L,803761L,4684660L,27304197L,159140520L,927538921L,5406093004L,31509019101L,183648021600L,1070379110497L,6238626641380L,36361380737781L,211929657785304L,1235216565974041L,7199369738058940L,41961001862379597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182435Inst : IEnumerable<long>
{
public static readonly long[] Value=A182435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182435.Bytes);
public long this[int i]=>Value[i];

public static A182435Inst Instance=new A182435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182436
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,2L,4L,8L,11L,4L,4L,20L,25L,24L,8L,8L,28L,70L,69L,52L,16L,8L,60L,126L,213L,178L,112L,32L,16L,80L,288L,460L,599L,440L,240L,64L,16L,160L,472L,1128L,1489L,1600L,1056L,512L,128L,32L,208L,976L,2152L,3914L,4457L,4120L,2480L,1088L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182436Inst : IEnumerable<long>
{
public static readonly long[] Value=A182436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182436.Bytes);
public long this[int i]=>Value[i];

public static A182436Inst Instance=new A182436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182437
{
public static readonly BigInteger[] Value={ 0L,2L,0L,12L,40L,270L,1848L,14840L,133488L,1334970L,14684560L,176214852L,2290793128L,32071103750L,481066556280L,7697064900464L,130850103307616L,2355301859537394L,44750735331210144L,895014706624203260L,BigInteger.Parse("18795308839108268040"),BigInteger.Parse("413496794460381897342") };
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
public class A182437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182437Inst Instance=new A182437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182438
{
public static readonly long[] Value={ 1L,18L,23L,33L,34L,37L,43L,52L,58L,62L,63L,72L,73L,74L,75L,78L,79L,80L,81L,82L,88L,91L,92L,98L,99L,105L,106L,107L,108L,109L,110L,111L,112L,113L,117L,118L,119L,122L,123L,124L,128L,129L,133L,136L,137L,143L,147L,151L,152L,157L,162L,166L,167L,168L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182438Inst : IEnumerable<long>
{
public static readonly long[] Value=A182438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182438.Bytes);
public long this[int i]=>Value[i];

public static A182438Inst Instance=new A182438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182439
{
public static readonly long[] Value={ 0L,0L,4L,14L,1L,7L,110L,14L,2L,8L,672L,95L,14L,3L,10L,3948L,568L,84L,14L,4L,11L,23042L,3325L,492L,81L,14L,5L,12L,134330L,19394L,2870L,472L,74L,14L,6L,13L,782964L,113051L,16730L,2751L,424L,71L,14L,7L,14L,4563480L,658924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182439Inst : IEnumerable<long>
{
public static readonly long[] Value=A182439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182439.Bytes);
public long this[int i]=>Value[i];

public static A182439Inst Instance=new A182439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182440
{
public static readonly long[] Value={ 0L,14L,4L,0L,14L,7L,16L,1L,14L,8L,126L,40L,2L,14L,10L,770L,287L,60L,3L,14L,11L,4524L,1730L,420L,72L,4L,14L,12L,26404L,10141L,2522L,497L,88L,5L,14L,13L,153930L,59164L,14774L,2978L,602L,100L,6L,14L,14L,897206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182440Inst : IEnumerable<long>
{
public static readonly long[] Value=A182440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182440.Bytes);
public long this[int i]=>Value[i];

public static A182440Inst Instance=new A182440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182441
{
public static readonly long[] Value={ 0L,0L,4L,14L,1L,7L,114L,14L,2L,8L,700L,131L,14L,3L,10L,4116L,820L,144L,14L,4L,11L,24026L,4837L,912L,149L,14L,5L,12L,140070L,28250L,5390L,948L,158L,14L,6L,13L,816424L,164711L,31490L,5607L,1012L,163L,14L,7L,14L,4758504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182441Inst : IEnumerable<long>
{
public static readonly long[] Value=A182441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182441.Bytes);
public long this[int i]=>Value[i];

public static A182441Inst Instance=new A182441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182442
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,16L,33L,68L,140L,287L,588L,1202L,2453L,4998L,10171L,20675L,41985L,85186L,172704L,349891L,708417L,1433495L,2899190L,5860705L,11842209L,23918846L,48293161L,97472205L,196669165L,396699440L,799954518L,1612705792L,3250410162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182442Inst : IEnumerable<long>
{
public static readonly long[] Value=A182442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182442.Bytes);
public long this[int i]=>Value[i];

public static A182442Inst Instance=new A182442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182443
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,4L,0L,8L,1L,16L,3L,32L,8L,64L,20L,129L,48L,260L,110L,525L,246L,1061L,540L,2145L,1169L,4336L,2504L,8764L,5321L,17711L,11232L,35784L,23582L,72282L,49289L,145972L,102632L,294717L,213019L,594896L,440910L,1200545L,910404L,2422262L,1875859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182443Inst : IEnumerable<long>
{
public static readonly long[] Value=A182443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182443.Bytes);
public long this[int i]=>Value[i];

public static A182443Inst Instance=new A182443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182444
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,13L,13L,17L,20L,26L,34L,34L,40L,44L,52L,62L,78L,83L,101L,121L,134L,140L,154L,169L,193L,200L,225L,251L,266L,269L,279L,284L,291L,295L,298L,334L,366L,388L,394L,413L,429L,455L,488L,493L,521L,544L,585L,590L,625L,654L,655L,673L,680L,693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182444Inst : IEnumerable<long>
{
public static readonly long[] Value=A182444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182444.Bytes);
public long this[int i]=>Value[i];

public static A182444Inst Instance=new A182444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182445
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,5L,8L,6L,14L,11L,15L,15L,18L,20L,24L,29L,37L,32L,51L,45L,56L,59L,71L,61L,84L,70L,102L,91L,109L,113L,132L,121L,157L,146L,167L,173L,196L,184L,228L,217L,245L,257L,250L,292L,278L,300L,302L,320L,334L,360L,344L,398L,378L,405L,405L,425L,438L,464L,438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182445Inst : IEnumerable<long>
{
public static readonly long[] Value=A182445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182445.Bytes);
public long this[int i]=>Value[i];

public static A182445Inst Instance=new A182445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182446
{
public static readonly BigInteger[] Value={ 1L,2L,514L,39368L,10601986L,2003906252L,588906874144L,159219918144128L,51207103076632066L,16425660314368351892UL,BigInteger.Parse("5697191745563573732764"),BigInteger.Parse("2010823973962863400708688"),BigInteger.Parse("739753103704422167184400096"),BigInteger.Parse("277511604090132008416695054272"),BigInteger.Parse("106814999715696983804826836579584") };
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
public class A182446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182446Inst Instance=new A182446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182447
{
public static readonly BigInteger[] Value={ 1L,2L,1026L,118100L,62563330L,20019531252L,11393421713604L,5550455033938152L,3431955863873102850L,BigInteger.Parse("2052124795850957537060"),BigInteger.Parse("1367610300690018553312276"),BigInteger.Parse("916694195766256069610158152"),BigInteger.Parse("649630217578404016288230718276"),BigInteger.Parse("467800319852823195772146025385000") };
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
public class A182447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182447Inst Instance=new A182447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182448
{
public static readonly long[] Value={ 6L,5L,7L,9L,7L,3L,6L,2L,6L,7L,3L,9L,2L,9L,0L,5L,7L,4L,5L,8L,8L,9L,6L,6L,0L,6L,6L,6L,5L,8L,4L,1L,0L,0L,7L,5L,6L,8L,7L,5L,7L,9L,9L,6L,0L,4L,8L,2L,7L,1L,9L,3L,7L,5L,0L,9L,4L,2L,2L,3L,2L,9L,1L,7L,4L,8L,0L,0L,2L,9L,8L,8L,1L,6L,1L,2L,8L,0L,3L,4L,9L,5L,3L,3L,4L,5L,1L,5L,6L,0L,2L,4L,7L,9L,0L,3L,4L,8L,2L,1L,2L,1L,6L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182448Inst : IEnumerable<long>
{
public static readonly long[] Value=A182448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182448.Bytes);
public long this[int i]=>Value[i];

public static A182448Inst Instance=new A182448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182449
{
public static readonly BigInteger[] Value={ 1L,2L,4L,15L,72L,472L,3448L,29264L,273371L,2834368L,31998904L,392958758L,5201061456L,73955306224L,1123596636018L,18177574748625L,311951144828864L,5661773589217182L,108355864447215064L,2181104926663522206L,BigInteger.Parse("46066653269313449442"),BigInteger.Parse("1018706122380363766288") };
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
public class A182449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182449Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182449.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182449Inst Instance=new A182449Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182450
{
public static readonly long[] Value={ 0L,868588L,1078331L,4337790L,4962337L,6948906L,13539754L,30448177L,32218557L,39275297L,41670729L,52746284L,61193646L,81620584L,108499172L,118175956L,157531734L,198162240L,206181306L,208637331L,252388467L,258429278L,273526639L,305726202L,316425865L,383749862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182450Inst : IEnumerable<long>
{
public static readonly long[] Value=A182450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182450.Bytes);
public long this[int i]=>Value[i];

public static A182450Inst Instance=new A182450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182451
{
public static readonly long[] Value={ 109L,151L,191L,229L,233L,283L,311L,571L,643L,683L,727L,941L,991L,1033L,1051L,1373L,1493L,1667L,1697L,1741L,1747L,1783L,1787L,1801L,1931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182451Inst : IEnumerable<long>
{
public static readonly long[] Value=A182451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182451.Bytes);
public long this[int i]=>Value[i];

public static A182451Inst Instance=new A182451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182452
{
public static readonly long[] Value={ 1L,11L,111L,1111L,2222L,11111L,12222L,21222L,22122L,22212L,22221L,111111L,112222L,121222L,122122L,122212L,122221L,211222L,212122L,212212L,212221L,221122L,221212L,221221L,222112L,222121L,222211L,222336L,222363L,222633L,223236L,223263L,223326L,223362L,223623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182452Inst : IEnumerable<long>
{
public static readonly long[] Value=A182452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182452.Bytes);
public long this[int i]=>Value[i];

public static A182452Inst Instance=new A182452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182453
{
public static readonly long[] Value={ 1L,3L,8L,24L,75L,233L,714L,2166L,6533L,19647L,59004L,177092L,531375L,1594245L,4782878L,14348802L,43046601L,129140027L,387420336L,1162261296L,3486784211L,10460352993L,31381059378L,94143178574L,282429536205L,847288609143L,2541865828004L,7625597484636L,22876792454583L,68630377364477L,205891132094214L,617673396283482L,1853020188851345L,5559060566554995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182453Inst : IEnumerable<long>
{
public static readonly long[] Value=A182453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182453.Bytes);
public long this[int i]=>Value[i];

public static A182453Inst Instance=new A182453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182454
{
public static readonly long[] Value={ 1L,1L,2L,7L,27L,112L,492L,2243L,10513L,50353L,245353L,1212398L,6061225L,30601910L,155808915L,799096655L,4124491215L,21408066097L,111672838857L,585128521777L,3078178384457L,16252057372887L,86089680204939L,457400940705274L,2436895852070559L,13015917111573039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182454Inst : IEnumerable<long>
{
public static readonly long[] Value=A182454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182454.Bytes);
public long this[int i]=>Value[i];

public static A182454Inst Instance=new A182454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182455
{
public static readonly long[] Value={ 1L,3L,12L,10L,24L,21L,40L,36L,60L,55L,84L,78L,112L,105L,144L,136L,180L,171L,220L,210L,264L,253L,312L,300L,364L,351L,420L,406L,480L,465L,544L,528L,612L,595L,684L,666L,760L,741L,840L,820L,924L,903L,1012L,990L,1104L,1081L,1200L,1176L,1300L,1275L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182455Inst : IEnumerable<long>
{
public static readonly long[] Value=A182455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182455.Bytes);
public long this[int i]=>Value[i];

public static A182455Inst Instance=new A182455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182456
{
public static readonly long[] Value={ 1L,4L,20L,12L,35L,24L,54L,40L,77L,60L,104L,84L,135L,112L,170L,144L,209L,180L,252L,220L,299L,264L,350L,312L,405L,364L,464L,420L,527L,480L,594L,544L,665L,612L,740L,684L,819L,760L,902L,840L,989L,924L,1080L,1012L,1175L,1104L,1274L,1200L,1377L,1300L,1484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182456Inst : IEnumerable<long>
{
public static readonly long[] Value=A182456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182456.Bytes);
public long this[int i]=>Value[i];

public static A182456Inst Instance=new A182456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182457
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,2L,1L,3L,4L,4L,7L,7L,2L,2L,5L,11L,8L,4L,15L,4L,1L,5L,6L,8L,1L,9L,10L,10L,17L,26L,23L,10L,7L,5L,2L,11L,23L,32L,15L,13L,36L,18L,19L,42L,7L,25L,38L,11L,35L,43L,6L,4L,25L,48L,13L,20L,37L,0L,1L,1L,2L,3L,7L,22L,27L,10L,7L,4L,29L,48L,63L,43L,46L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182457Inst : IEnumerable<long>
{
public static readonly long[] Value=A182457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182457.Bytes);
public long this[int i]=>Value[i];

public static A182457Inst Instance=new A182457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182458
{
public static readonly long[] Value={ 1L,2L,1L,0L,1L,1L,2L,3L,7L,4L,9L,4L,1L,5L,6L,1L,7L,8L,3L,6L,19L,10L,15L,13L,4L,3L,13L,13L,2L,27L,25L,25L,18L,22L,23L,17L,32L,27L,29L,4L,37L,26L,39L,26L,3L,34L,11L,46L,27L,18L,37L,4L,45L,22L,19L,34L,31L,29L,30L,45L,31L,54L,1L,55L,56L,26L,5L,64L,49L,32L,29L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182458Inst : IEnumerable<long>
{
public static readonly long[] Value=A182458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182458.Bytes);
public long this[int i]=>Value[i];

public static A182458Inst Instance=new A182458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182459
{
public static readonly long[] Value={ 1L,2L,13L,20L,46L,157L,236L,532L,1198L,4045L,6068L,13654L,46084L,103690L,1181101L,1771652L,3986218L,102162424L,229865455L,344798183L,517197275L,775795913L,1163693870L,3927466813L,5891200220L,13255200496L,29824201117L,44736301676L,100656678772L,226477527238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182459Inst : IEnumerable<long>
{
public static readonly long[] Value=A182459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182459.Bytes);
public long this[int i]=>Value[i];

public static A182459Inst Instance=new A182459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182460
{
public static readonly BigInteger[] Value={ 1L,19L,307L,4915L,78643L,1258291L,20132659L,322122547L,5153960755L,82463372083L,1319413953331L,21110623253299L,337769972052787L,5404319552844595L,86469112845513523L,1383505805528216371L,BigInteger.Parse("22136092888451461939"),BigInteger.Parse("354177486215223391027"),BigInteger.Parse("5666839779443574256435"),BigInteger.Parse("90669436471097188102963"),BigInteger.Parse("1450710983537555009647411") };
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
public class A182460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182460Inst Instance=new A182460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182461
{
public static readonly long[] Value={ 16L,40L,88L,184L,376L,760L,1528L,3064L,6136L,12280L,24568L,49144L,98296L,196600L,393208L,786424L,1572856L,3145720L,6291448L,12582904L,25165816L,50331640L,100663288L,201326584L,402653176L,805306360L,1610612728L,3221225464L,6442450936L,12884901880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182461Inst : IEnumerable<long>
{
public static readonly long[] Value=A182461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182461.Bytes);
public long this[int i]=>Value[i];

public static A182461Inst Instance=new A182461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182462
{
public static readonly long[] Value={ 20L,50L,110L,230L,470L,950L,1910L,3830L,7670L,15350L,30710L,61430L,122870L,245750L,491510L,983030L,1966070L,3932150L,7864310L,15728630L,31457270L,62914550L,125829110L,251658230L,503316470L,1006632950L,2013265910L,4026531830L,8053063670L,16106127350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182462Inst : IEnumerable<long>
{
public static readonly long[] Value=A182462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182462.Bytes);
public long this[int i]=>Value[i];

public static A182462Inst Instance=new A182462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182463
{
public static readonly long[] Value={ 1L,2L,5L,7L,9L,11L,13L,15L,15L,19L,21L,25L,25L,24L,31L,33L,39L,35L,43L,45L,49L,40L,55L,61L,63L,55L,69L,73L,75L,65L,56L,81L,85L,60L,75L,91L,99L,103L,105L,64L,109L,111L,115L,105L,88L,129L,133L,115L,139L,141L,84L,125L,104L,151L,153L,100L,159L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182463Inst : IEnumerable<long>
{
public static readonly long[] Value=A182463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182463.Bytes);
public long this[int i]=>Value[i];

public static A182463Inst Instance=new A182463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182464
{
public static readonly long[] Value={ 24L,60L,132L,276L,564L,1140L,2292L,4596L,9204L,18420L,36852L,73716L,147444L,294900L,589812L,1179636L,2359284L,4718580L,9437172L,18874356L,37748724L,75497460L,150994932L,301989876L,603979764L,1207959540L,2415919092L,4831838196L,9663676404L,19327352820L,38654705652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182464Inst : IEnumerable<long>
{
public static readonly long[] Value=A182464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182464.Bytes);
public long this[int i]=>Value[i];

public static A182464Inst Instance=new A182464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182465
{
public static readonly long[] Value={ 28L,70L,154L,322L,658L,1330L,2674L,5362L,10738L,21490L,42994L,86002L,172018L,344050L,688114L,1376242L,2752498L,5505010L,11010034L,22020082L,44040178L,88080370L,176160754L,352321522L,704643058L,1409286130L,2818572274L,5637144562L,11274289138L,22548578290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182465Inst : IEnumerable<long>
{
public static readonly long[] Value=A182465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182465.Bytes);
public long this[int i]=>Value[i];

public static A182465Inst Instance=new A182465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182466
{
public static readonly long[] Value={ 32L,80L,176L,368L,752L,1520L,3056L,6128L,12272L,24560L,49136L,98288L,196592L,393200L,786416L,1572848L,3145712L,6291440L,12582896L,25165808L,50331632L,100663280L,201326576L,402653168L,805306352L,1610612720L,3221225456L,6442450928L,12884901872L,25769803760L,51539607536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182466Inst : IEnumerable<long>
{
public static readonly long[] Value=A182466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182466.Bytes);
public long this[int i]=>Value[i];

public static A182466Inst Instance=new A182466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182467
{
public static readonly long[] Value={ 36L,90L,198L,414L,846L,1710L,3438L,6894L,13806L,27630L,55278L,110574L,221166L,442350L,884718L,1769454L,3538926L,7077870L,14155758L,28311534L,56623086L,113246190L,226492398L,452984814L,905969646L,1811939310L,3623878638L,7247757294L,14495514606L,28991029230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182467Inst : IEnumerable<long>
{
public static readonly long[] Value=A182467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182467.Bytes);
public long this[int i]=>Value[i];

public static A182467Inst Instance=new A182467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182468
{
public static readonly long[] Value={ 3L,63L,65L,79L,83L,156L,183L,254L,258L,285L,320L,323L,325L,328L,505L,573L,579L,600L,623L,627L,723L,723L,735L,791L,994L,1020L,1023L,1025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182468Inst : IEnumerable<long>
{
public static readonly long[] Value=A182468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182468.Bytes);
public long this[int i]=>Value[i];

public static A182468Inst Instance=new A182468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182469
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,5L,1L,3L,1L,7L,1L,1L,3L,9L,1L,5L,1L,11L,1L,3L,1L,13L,1L,7L,1L,3L,5L,15L,1L,1L,17L,1L,3L,9L,1L,19L,1L,5L,1L,3L,7L,21L,1L,11L,1L,23L,1L,3L,1L,5L,25L,1L,13L,1L,3L,9L,27L,1L,7L,1L,29L,1L,3L,5L,15L,1L,31L,1L,1L,3L,11L,33L,1L,17L,1L,5L,7L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182469Inst : IEnumerable<long>
{
public static readonly long[] Value=A182469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182469.Bytes);
public long this[int i]=>Value[i];

public static A182469Inst Instance=new A182469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182470
{
public static readonly long[] Value={ 1L,7L,7L,9L,1L,8L,6L,8L,3L,2L,8L,9L,7L,6L,4L,7L,5L,1L,0L,6L,6L,3L,2L,3L,6L,7L,8L,1L,4L,7L,2L,6L,0L,2L,5L,5L,2L,8L,5L,9L,1L,5L,1L,0L,9L,7L,2L,5L,0L,7L,8L,9L,1L,0L,9L,2L,3L,9L,2L,1L,0L,8L,7L,5L,1L,8L,3L,5L,5L,1L,6L,1L,1L,4L,2L,5L,8L,0L,4L,1L,9L,8L,6L,3L,5L,4L,1L,0L,0L,3L,3L,2L,0L,5L,6L,2L,2L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182470Inst : IEnumerable<long>
{
public static readonly long[] Value=A182470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182470.Bytes);
public long this[int i]=>Value[i];

public static A182470Inst Instance=new A182470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182471
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,1L,4L,2L,2L,2L,6L,2L,7L,2L,2L,3L,9L,2L,10L,2L,3L,3L,12L,2L,3L,4L,3L,3L,15L,2L,16L,3L,4L,5L,3L,2L,19L,5L,4L,2L,21L,2L,22L,4L,2L,6L,24L,2L,4L,2L,5L,4L,27L,2L,4L,3L,6L,8L,30L,2L,31L,8L,3L,4L,5L,3L,34L,5L,7L,2L,36L,2L,37L,10L,2L,6L,5L,3L,40L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182471Inst : IEnumerable<long>
{
public static readonly long[] Value=A182471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182471.Bytes);
public long this[int i]=>Value[i];

public static A182471Inst Instance=new A182471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182472
{
public static readonly long[] Value={ 3L,0L,1L,7L,9L,13L,14L,8L,17L,10L,21L,46L,542L,23L,74L,22L,1362L,35L,32L,20L,3010L,81L,33L,34L,243L,30L,41L,29L,117L,38L,58L,56L,36L,874L,45L,449L,431L,40L,151L,42L,79L,73L,82L,84L,386L,52L,47L,106L,1622L,68L,75L,794L,129L,83L,61L,63L,64L,2620L,228L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182472Inst : IEnumerable<long>
{
public static readonly long[] Value=A182472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182472.Bytes);
public long this[int i]=>Value[i];

public static A182472Inst Instance=new A182472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182473
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,3L,8L,9L,12L,16L,22L,20L,31L,35L,34L,44L,51L,53L,62L,65L,68L,87L,86L,89L,95L,118L,108L,126L,127L,138L,142L,162L,154L,188L,160L,193L,189L,227L,204L,228L,221L,258L,238L,282L,247L,311L,272L,320L,284L,344L,318L,373L,327L,398L,334L,407L,380L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182473Inst : IEnumerable<long>
{
public static readonly long[] Value=A182473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182473.Bytes);
public long this[int i]=>Value[i];

public static A182473Inst Instance=new A182473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182474
{
public static readonly long[] Value={ 2L,5L,7L,23L,47L,167L,359L,839L,1367L,1847L,2207L,3719L,5039L,7919L,8179L,10607L,11447L,16127L,17159L,19319L,29927L,36479L,44519L,49727L,54287L,57119L,66047L,85847L,97967L,113567L,128879L,177239L,196247L,201599L,218087L,241079L,273527L,292679L,323759L,344567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182474Inst : IEnumerable<long>
{
public static readonly long[] Value=A182474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182474.Bytes);
public long this[int i]=>Value[i];

public static A182474Inst Instance=new A182474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182475
{
public static readonly long[] Value={ 19L,59L,131L,179L,971L,2819L,3491L,5051L,6899L,9419L,10211L,16139L,22811L,24659L,32051L,32771L,44531L,49739L,51539L,57131L,96731L,134699L,143651L,201611L,237179L,271451L,358811L,361211L,375779L,383171L,398171L,552059L,597539L,654491L,683939L,779699L,954539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182475Inst : IEnumerable<long>
{
public static readonly long[] Value=A182475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182475.Bytes);
public long this[int i]=>Value[i];

public static A182475Inst Instance=new A182475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182476
{
public static readonly long[] Value={ 109L,149L,269L,389L,461L,941L,1061L,1949L,2309L,2909L,3581L,3821L,10301L,10709L,11549L,11981L,16229L,18869L,19421L,22901L,24749L,26669L,30029L,32141L,44621L,52541L,57221L,72461L,76829L,94349L,96821L,109661L,128981L,134789L,167381L,201701L,214469L,253109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182476Inst : IEnumerable<long>
{
public static readonly long[] Value=A182476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182476.Bytes);
public long this[int i]=>Value[i];

public static A182476Inst Instance=new A182476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182477
{
public static readonly long[] Value={ 107L,167L,197L,233L,257L,347L,359L,401L,431L,457L,467L,557L,563L,617L,647L,653L,743L,761L,797L,863L,887L,937L,971L,1087L,1097L,1187L,1223L,1237L,1283L,1297L,1409L,1481L,1493L,1549L,1553L,1583L,1597L,1601L,1607L,1637L,1697L,1871L,1889L,1907L,1949L,2003L,2017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182477Inst : IEnumerable<long>
{
public static readonly long[] Value=A182477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182477.Bytes);
public long this[int i]=>Value[i];

public static A182477Inst Instance=new A182477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182478
{
public static readonly long[] Value={ 1L,2L,145L,40585L,6402374184741226L,121645100891988866L,121666023198802103L,121666023198802144L,2432902008177819519L,2432902008217006118L,2432902008656812499L,4872206390059820318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182478Inst : IEnumerable<long>
{
public static readonly long[] Value=A182478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182478.Bytes);
public long this[int i]=>Value[i];

public static A182478Inst Instance=new A182478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182479
{
public static readonly long[] Value={ 83L,179L,227L,347L,419L,467L,491L,563L,587L,659L,827L,971L,1019L,1091L,1259L,1427L,1499L,1667L,1811L,1907L,1979L,2027L,2243L,2267L,2339L,2531L,2579L,2699L,2819L,2843L,2939L,3347L,3539L,3659L,3779L,3851L,4019L,4091L,4259L,4451L,4523L,4547L,4691L,4787L,5099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182479Inst : IEnumerable<long>
{
public static readonly long[] Value=A182479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182479.Bytes);
public long this[int i]=>Value[i];

public static A182479Inst Instance=new A182479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182480
{
public static readonly long[] Value={ 2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L,9L,6L,8L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182480Inst : IEnumerable<long>
{
public static readonly long[] Value=A182480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182480.Bytes);
public long this[int i]=>Value[i];

public static A182480Inst Instance=new A182480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182481
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,1L,4L,2L,1L,3L,1L,4L,5L,2L,2L,1L,1L,2L,2L,7L,5L,1L,3L,1L,2L,5L,16L,2L,1L,7L,1L,1L,5L,2L,2L,9L,1L,8L,1L,5L,9L,4L,5L,1L,3L,1L,4L,3L,2L,7L,1L,20L,5L,2L,8L,14L,1L,3L,21L,43L,4L,6L,3L,5L,8L,4L,9L,2L,1L,3L,1L,14L,15L,9L,30L,1L,4L,22L,7L,20L,21L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182481Inst : IEnumerable<long>
{
public static readonly long[] Value=A182481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182481.Bytes);
public long this[int i]=>Value[i];

public static A182481Inst Instance=new A182481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182482
{
public static readonly long[] Value={ 5L,11L,17L,71L,29L,71L,41L,191L,107L,59L,197L,71L,311L,419L,179L,191L,101L,107L,227L,239L,881L,659L,137L,431L,149L,311L,809L,2687L,347L,179L,1301L,191L,197L,1019L,419L,431L,1997L,227L,1871L,239L,1229L,2267L,1031L,1319L,269L,827L,281L,1151L,881L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182482Inst : IEnumerable<long>
{
public static readonly long[] Value=A182482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182482.Bytes);
public long this[int i]=>Value[i];

public static A182482Inst Instance=new A182482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182483
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,4L,17L,9L,23L,25L,15L,8L,11L,19L,20L,45L,47L,13L,29L,14L,24L,77L,87L,95L,50L,103L,107L,22L,27L,137L,46L,143L,21L,34L,43L,175L,59L,91L,48L,41L,71L,215L,31L,44L,119L,121L,247L,62L,67L,54L,139L,283L,287L,149L,39L,313L,161L,65L,37L,169L,347L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182483Inst : IEnumerable<long>
{
public static readonly long[] Value=A182483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182483.Bytes);
public long this[int i]=>Value[i];

public static A182483Inst Instance=new A182483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182484
{
public static readonly BigInteger[] Value={ 1L,1L,4L,225L,8930250000L,9001015156742400L,BigInteger.Parse("377177413291384771899817984000000"),BigInteger.Parse("17617791710438789613561393948051882397138944") };
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
public class A182484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182484.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182484Inst Instance=new A182484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182485
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,0L,2L,0L,3L,1L,0L,2L,3L,0L,4L,3L,0L,2L,8L,0L,4L,9L,0L,3L,12L,0L,4L,16L,1L,0L,2L,22L,4L,0L,6L,20L,5L,0L,2L,31L,12L,0L,4L,35L,16L,0L,4L,34L,24L,0L,5L,44L,33L,0L,2L,51L,52L,0L,6L,53L,57L,0L,2L,62L,89L,0L,6L,65L,100L,1L,0L,4L,68L,131L,5L,0L,4L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182485Inst : IEnumerable<long>
{
public static readonly long[] Value=A182485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182485.Bytes);
public long this[int i]=>Value[i];

public static A182485Inst Instance=new A182485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182486
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-2L,-4L,-10L,-29L,-90L,-290L,-960L,-3246L,-11164L,-38934L,-137358L,-489341L,-1757882L,-6360634L,-23160528L,-84802606L,-312041692L,-1153271984L,-4279311348L,-15935808866L,-59537435012L,-223099337404L,-838282693560L,-3157706225584L,-11922241414880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182486Inst : IEnumerable<long>
{
public static readonly long[] Value=A182486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182486.Bytes);
public long this[int i]=>Value[i];

public static A182486Inst Instance=new A182486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182487
{
public static readonly long[] Value={ 3L,4L,4L,6L,4L,6L,6L,14L,10L,10L,6L,6L,8L,18L,12L,24L,16L,10L,6L,12L,30L,12L,24L,42L,30L,24L,60L,24L,30L,34L,30L,36L,46L,12L,36L,18L,34L,24L,24L,30L,36L,52L,72L,16L,22L,48L,44L,50L,34L,20L,20L,28L,44L,50L,40L,92L,60L,86L,16L,52L,48L,66L,46L,168L,50L,174L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182487Inst : IEnumerable<long>
{
public static readonly long[] Value=A182487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182487.Bytes);
public long this[int i]=>Value[i];

public static A182487Inst Instance=new A182487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182488
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,12L,30L,80L,221L,624L,1798L,5271L,15662L,47052L,142686L,436187L,1342669L,4158048L,12945758L,40497415L,127225426L,401222453L,1269712425L,4030877287L,12833659158L,40968993548L,131106215470L,420507819784L,1351562339222L,4352564765053L,14042486582525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182488Inst : IEnumerable<long>
{
public static readonly long[] Value=A182488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182488.Bytes);
public long this[int i]=>Value[i];

public static A182488Inst Instance=new A182488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182489
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,127L,1695L,35199L,1114303L,53230271L,3806172863L,404501151935L,63629782432959L,14743655706528959L,5018867716910902463L,BigInteger.Parse("2501521070328547822783"),BigInteger.Parse("1821950518454974100737215"),BigInteger.Parse("1934522846425767844573547711"),BigInteger.Parse("2989550430024658138034762353855") };
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
public class A182489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A182489.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A182489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A182489Inst Instance=new A182489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182490
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,1L,3L,1L,5L,4L,4L,10L,12L,10L,14L,26L,35L,32L,52L,76L,85L,108L,173L,208L,254L,328L,428L,563L,693L,928L,1130L,1454L,1879L,2481L,3234L,4164L,5231L,6890L,8855L,11309L,14905L,19227L,25040L,32035L,41615L,53710L,70061L,91228L,118940L,154659L,201004L,263363L,343053L,447613L,586096L,765319L,1000803L,1311065L,1716615L,2253877L,2956272L,3879379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182490Inst : IEnumerable<long>
{
public static readonly long[] Value=A182490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182490.Bytes);
public long this[int i]=>Value[i];

public static A182490Inst Instance=new A182490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182491
{
public static readonly long[] Value={ 1L,4L,8L,9L,14L,21L,16L,22L,30L,40L,25L,32L,41L,52L,65L,36L,44L,54L,66L,80L,96L,49L,58L,69L,82L,97L,114L,133L,64L,74L,86L,100L,116L,134L,154L,176L,81L,92L,105L,120L,137L,156L,177L,200L,225L,100L,112L,126L,142L,160L,180L,202L,226L,252L,280L,121L,134L,149L,166L,185L,206L,229L,254L,281L,310L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182491Inst : IEnumerable<long>
{
public static readonly long[] Value=A182491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182491.Bytes);
public long this[int i]=>Value[i];

public static A182491Inst Instance=new A182491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182492
{
public static readonly long[] Value={ 1L,-1L,0L,1L,0L,0L,0L,-1L,0L,0L,0L,2L,0L,0L,0L,-5L,0L,0L,0L,14L,0L,0L,0L,-42L,0L,0L,0L,132L,0L,0L,0L,-429L,0L,0L,0L,1430L,0L,0L,0L,-4862L,0L,0L,0L,16796L,0L,0L,0L,-58786L,0L,0L,0L,208012L,0L,0L,0L,-742900L,0L,0L,0L,2674440L,0L,0L,0L,-9694845L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182492Inst : IEnumerable<long>
{
public static readonly long[] Value=A182492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182492.Bytes);
public long this[int i]=>Value[i];

public static A182492Inst Instance=new A182492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182493
{
public static readonly long[] Value={ 10L,3L,5L,1000L,1L,2L,100L,6L,4L,50L,40L,13L,30L,7L,1010L,1003L,9L,15L,10000L,11L,12L,8L,3000L,300L,20L,110L,103L,60L,5000L,500L,1005L,1001L,1002L,1100L,90L,53L,2000L,200L,43L,16L,14L,17L,33L,80L,70L,105L,100000L,101L,102L,6000L,600L,1006L,1004L,1050L,1040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182493Inst : IEnumerable<long>
{
public static readonly long[] Value=A182493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182493.Bytes);
public long this[int i]=>Value[i];

public static A182493Inst Instance=new A182493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182494
{
public static readonly long[] Value={ 9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L,9L,1L,8L,1L,9L,0L,0L,8L,1L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182494Inst : IEnumerable<long>
{
public static readonly long[] Value=A182494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182494.Bytes);
public long this[int i]=>Value[i];

public static A182494Inst Instance=new A182494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182495
{
public static readonly long[] Value={ 4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L,5L,5L,7L,6L,7L,5L,4L,5L,6L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182495Inst : IEnumerable<long>
{
public static readonly long[] Value=A182495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182495.Bytes);
public long this[int i]=>Value[i];

public static A182495Inst Instance=new A182495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182496
{
public static readonly long[] Value={ 5L,6L,2L,0L,5L,4L,5L,1L,9L,2L,3L,8L,6L,3L,6L,7L,4L,3L,6L,5L,8L,4L,1L,7L,2L,0L,7L,1L,4L,1L,5L,9L,8L,8L,8L,6L,4L,1L,6L,2L,5L,0L,2L,8L,1L,2L,3L,9L,4L,3L,4L,5L,2L,7L,9L,1L,3L,8L,8L,6L,6L,7L,5L,4L,7L,5L,1L,9L,6L,7L,8L,1L,5L,2L,5L,1L,2L,2L,1L,7L,1L,7L,0L,5L,3L,0L,7L,1L,8L,9L,6L,1L,9L,0L,4L,8L,2L,9L,3L,4L,6L,6L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182496Inst : IEnumerable<long>
{
public static readonly long[] Value=A182496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182496.Bytes);
public long this[int i]=>Value[i];

public static A182496Inst Instance=new A182496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182497
{
public static readonly long[] Value={ 1L,9L,2L,3L,1L,5L,5L,1L,6L,8L,2L,1L,1L,8L,4L,5L,8L,9L,6L,6L,3L,1L,9L,2L,3L,7L,4L,4L,1L,9L,6L,3L,5L,9L,0L,7L,1L,2L,1L,6L,7L,8L,2L,6L,1L,3L,3L,3L,3L,7L,5L,2L,3L,8L,6L,7L,3L,2L,5L,2L,9L,1L,2L,5L,3L,9L,1L,7L,8L,8L,4L,4L,9L,1L,6L,1L,3L,7L,9L,3L,5L,9L,3L,7L,3L,9L,0L,9L,7L,1L,2L,3L,7L,8L,5L,5L,6L,6L,0L,5L,1L,1L,6L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182497Inst : IEnumerable<long>
{
public static readonly long[] Value=A182497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182497.Bytes);
public long this[int i]=>Value[i];

public static A182497Inst Instance=new A182497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182498
{
public static readonly long[] Value={ 5L,1L,9L,9L,7L,8L,8L,4L,3L,3L,7L,6L,3L,2L,6L,3L,6L,3L,9L,5L,5L,3L,1L,4L,2L,3L,8L,3L,9L,3L,3L,7L,5L,4L,5L,9L,3L,3L,8L,7L,5L,2L,9L,6L,7L,6L,2L,6L,0L,9L,6L,7L,2L,2L,7L,7L,7L,4L,1L,0L,0L,0L,5L,8L,2L,4L,7L,0L,9L,8L,4L,9L,1L,1L,0L,1L,4L,0L,1L,0L,2L,2L,5L,9L,7L,0L,6L,4L,9L,1L,6L,2L,9L,5L,4L,8L,3L,6L,9L,2L,9L,6L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182498Inst : IEnumerable<long>
{
public static readonly long[] Value=A182498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182498.Bytes);
public long this[int i]=>Value[i];

public static A182498Inst Instance=new A182498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182499
{
public static readonly long[] Value={ 8L,7L,3L,5L,6L,8L,5L,2L,6L,8L,3L,0L,2L,3L,1L,8L,6L,8L,3L,5L,3L,9L,7L,7L,4L,6L,4L,7L,6L,3L,3L,4L,2L,7L,3L,8L,8L,2L,0L,7L,2L,9L,8L,6L,6L,1L,7L,6L,1L,3L,9L,1L,4L,7L,6L,5L,2L,3L,1L,9L,8L,4L,2L,4L,3L,0L,7L,0L,5L,8L,3L,1L,0L,0L,5L,9L,6L,4L,8L,8L,4L,2L,3L,7L,4L,9L,3L,7L,1L,0L,3L,6L,1L,2L,4L,2L,2L,8L,5L,0L,6L,8L,6L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182499Inst : IEnumerable<long>
{
public static readonly long[] Value=A182499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182499.Bytes);
public long this[int i]=>Value[i];

public static A182499Inst Instance=new A182499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182500
{
public static readonly long[] Value={ 4L,8L,0L,0L,6L,0L,2L,4L,8L,0L,7L,6L,6L,7L,3L,1L,8L,3L,0L,5L,5L,7L,5L,5L,2L,2L,9L,0L,1L,8L,6L,6L,5L,7L,5L,5L,2L,5L,2L,2L,7L,8L,0L,6L,0L,3L,8L,8L,5L,3L,6L,6L,5L,6L,2L,9L,6L,7L,4L,8L,2L,1L,5L,3L,8L,8L,6L,7L,5L,1L,0L,4L,4L,2L,7L,7L,1L,9L,0L,9L,3L,2L,1L,9L,3L,7L,5L,3L,6L,2L,7L,3L,8L,9L,4L,6L,9L,5L,7L,2L,8L,3L,8L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182500Inst : IEnumerable<long>
{
public static readonly long[] Value=A182500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182500.Bytes);
public long this[int i]=>Value[i];

public static A182500Inst Instance=new A182500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182501
{
public static readonly long[] Value={ 4L,2L,0L,3L,7L,1L,5L,0L,5L,1L,1L,0L,6L,0L,5L,0L,3L,8L,3L,6L,8L,3L,9L,7L,5L,6L,5L,7L,0L,7L,5L,3L,1L,0L,7L,4L,0L,6L,9L,9L,4L,4L,4L,2L,1L,8L,3L,5L,3L,8L,7L,1L,3L,0L,4L,0L,2L,5L,3L,6L,5L,6L,0L,5L,7L,4L,3L,3L,2L,1L,2L,0L,1L,1L,5L,4L,4L,2L,2L,1L,3L,9L,4L,9L,8L,5L,6L,9L,2L,4L,2L,9L,1L,9L,8L,0L,8L,1L,1L,8L,8L,2L,3L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182501Inst : IEnumerable<long>
{
public static readonly long[] Value=A182501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182501.Bytes);
public long this[int i]=>Value[i];

public static A182501Inst Instance=new A182501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182502
{
public static readonly long[] Value={ 1L,3L,7L,2L,1L,9L,8L,2L,3L,3L,1L,4L,8L,5L,5L,7L,3L,1L,3L,1L,8L,2L,7L,8L,0L,9L,1L,7L,6L,6L,7L,2L,9L,7L,8L,4L,6L,0L,8L,2L,2L,6L,1L,2L,9L,6L,2L,2L,7L,5L,6L,6L,2L,8L,2L,3L,8L,1L,4L,7L,0L,2L,3L,1L,7L,0L,7L,9L,9L,3L,4L,4L,1L,5L,2L,9L,2L,4L,1L,7L,0L,8L,1L,0L,4L,1L,5L,5L,1L,2L,9L,8L,4L,8L,3L,2L,8L,9L,8L,8L,8L,3L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182502Inst : IEnumerable<long>
{
public static readonly long[] Value=A182502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182502.Bytes);
public long this[int i]=>Value[i];

public static A182502Inst Instance=new A182502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182503
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,15L,17L,66L,196L,233L,284L,375L,1613L,2131L,3574L,14122L,24171L,49097L,56871L,69361L,193406L,243145L,289951L,682749L,14501588L,21191773L,121635191L,810759781L,1292785381L,136110231377L,294401497761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182503Inst : IEnumerable<long>
{
public static readonly long[] Value=A182503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182503.Bytes);
public long this[int i]=>Value[i];

public static A182503Inst Instance=new A182503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A182504
{
public static readonly long[] Value={ 323L,377L,3827L,5777L,6479L,10877L,11663L,18407L,19043L,20999L,23407L,25877L,27323L,34943L,35207L,39203L,44099L,47519L,50183L,51983L,53663L,60377L,65471L,75077L,78089L,79547L,80189L,81719L,82983L,84279L,84419L,86063L,90287L,94667L,100127L,104663L,109871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A182504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A182504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A182504Inst : IEnumerable<long>
{
public static readonly long[] Value=A182504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A182504.Bytes);
public long this[int i]=>Value[i];

public static A182504Inst Instance=new A182504Inst();

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