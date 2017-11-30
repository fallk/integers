using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A109341
{
public static readonly long[] Value={ 0L,26L,26L,26L,24L,26L,26L,26L,16L,26L,26L,26L,24L,26L,26L,26L,0L,26L,26L,26L,24L,26L,26L,26L,16L,26L,26L,26L,24L,26L,26L,26L,0L,26L,26L,26L,24L,26L,26L,26L,16L,26L,26L,26L,24L,26L,26L,26L,0L,26L,26L,26L,24L,26L,26L,26L,16L,26L,26L,26L,24L,26L,26L,26L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109341Inst : IEnumerable<long>
{
public static readonly long[] Value=A109341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109341.Bytes);
public long this[int i]=>Value[i];

public static A109341Inst Instance=new A109341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109342
{
public static readonly long[] Value={ 1L,3L,5L,8L,89L,275L,278L,404L,96L,1538L,1253L,15858L,189168L,119552L,636315L,1047122L,3571449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109342Inst : IEnumerable<long>
{
public static readonly long[] Value=A109342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109342.Bytes);
public long this[int i]=>Value[i];

public static A109342Inst Instance=new A109342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109343
{
public static readonly long[] Value={ 0L,163L,1304L,2948L,12511L,29006L,39789L,44757L,175506L,232048L,327955L,765887L,1429888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109343Inst : IEnumerable<long>
{
public static readonly long[] Value=A109343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109343.Bytes);
public long this[int i]=>Value[i];

public static A109343Inst Instance=new A109343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109344
{
public static readonly BigInteger[] Value={ 49L,4489L,444889L,44448889L,4444488889L,444444888889L,44444448888889L,4444444488888889L,444444444888888889L,BigInteger.Parse("44444444448888888889"),BigInteger.Parse("4444444444488888888889"),BigInteger.Parse("444444444444888888888889"),BigInteger.Parse("44444444444448888888888889"),BigInteger.Parse("4444444444444488888888888889") };
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
public class A109344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109344.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109344Inst Instance=new A109344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109345
{
public static readonly BigInteger[] Value={ 1L,1L,5L,125L,15625L,9765625L,30517578125L,476837158203125L,BigInteger.Parse("37252902984619140625"),BigInteger.Parse("14551915228366851806640625"),BigInteger.Parse("28421709430404007434844970703125") };
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
public class A109345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109345.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109345Inst Instance=new A109345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109346
{
public static readonly long[] Value={ 2L,7L,13L,19L,23L,47L,167L,251L,317L,359L,389L,401L,449L,479L,491L,557L,587L,647L,701L,797L,839L,911L,941L,947L,977L,1187L,1217L,1259L,1361L,1367L,1409L,1499L,1511L,1709L,1847L,1889L,1907L,2207L,2417L,2447L,2477L,2579L,2621L,2699L,2879L,2909L,3137L,3719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109346Inst : IEnumerable<long>
{
public static readonly long[] Value=A109346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109346.Bytes);
public long this[int i]=>Value[i];

public static A109346Inst Instance=new A109346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109347
{
public static readonly BigInteger[] Value={ 2L,1L,49L,17L,1441L,19L,37969L,353L,19729L,421L,24325489L,481L,609554401L,10039L,216001L,198593L,381405156481L,12979L,9536162033329L,288961L,18306583L,6125659L,5960417405949649L,346561L,103408180634401L,152787181L,3853528045489L,179655841L,BigInteger.Parse("93132223146359169121") };
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
public class A109347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109347.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109347Inst Instance=new A109347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109348
{
public static readonly long[] Value={ 4L,5L,79L,29L,4141L,37L,205339L,1241L,127639L,341L,494287399L,2041L,24221854021L,82573L,3628081L,2885681L,58157596211761L,109117L,2849723505777919L,4871281L,8607961321L,197750389L,6842186811484434379L,5576881L,80962848274370701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109348Inst : IEnumerable<long>
{
public static readonly long[] Value=A109348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109348.Bytes);
public long this[int i]=>Value[i];

public static A109348Inst Instance=new A109348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109349
{
public static readonly ulong[] Value={ 2L,3L,109L,37L,6841L,13L,372709L,1513L,176149L,1661L,964249309L,1801L,47834153641L,75139L,3162961L,3077713L,115933787267041L,30133L,5689910849522509L,3949201L,6868494361L,168846239L,13678413205562919109UL,4654801L,97995219736887001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109349Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A109349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109349.Bytes);
public ulong this[int i]=>Value[i];

public static A109349Inst Instance=new A109349Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109350
{
public static readonly long[] Value={ 3L,4L,5L,12L,13L,24L,41L,60L,84L,113L,144L,180L,264L,265L,312L,480L,761L,1012L,1104L,1105L,1201L,1405L,1624L,1740L,1741L,1861L,2112L,2113L,3281L,4140L,4141L,5304L,5512L,5724L,5940L,6385L,6612L,7320L,7564L,7565L,8580L,8845L,9385L,9660L,9661L,9941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109350Inst : IEnumerable<long>
{
public static readonly long[] Value=A109350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109350.Bytes);
public long this[int i]=>Value[i];

public static A109350Inst Instance=new A109350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109351
{
public static readonly long[] Value={ 2L,8L,9L,89L,96L,204L,224L,296L,541L,576L,1537L,1701L,4496L,6124L,6611L,7685L,7789L,8381L,8741L,9025L,12048L,12105L,12513L,13711L,15924L,16160L,17180L,21486L,21998L,24657L,26264L,26354L,29864L,32477L,43791L,52518L,53662L,54018L,56189L,81281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109351Inst : IEnumerable<long>
{
public static readonly long[] Value=A109351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109351.Bytes);
public long this[int i]=>Value[i];

public static A109351Inst Instance=new A109351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109352
{
public static readonly long[] Value={ 5L,7L,9L,8L,10L,13L,15L,10L,14L,19L,12L,21L,16L,12L,25L,20L,16L,22L,31L,33L,18L,16L,26L,14L,39L,18L,18L,43L,22L,45L,32L,20L,34L,49L,24L,22L,15L,55L,18L,40L,24L,28L,61L,24L,63L,44L,46L,20L,26L,69L,28L,50L,73L,24L,34L,75L,20L,36L,81L,56L,30L,19L,85L,24L,34L,62L,91L,22L,64L,42L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109352Inst : IEnumerable<long>
{
public static readonly long[] Value=A109352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109352.Bytes);
public long this[int i]=>Value[i];

public static A109352Inst Instance=new A109352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109353
{
public static readonly long[] Value={ 5L,7L,5L,9L,8L,5L,7L,10L,13L,5L,15L,9L,10L,14L,19L,12L,5L,21L,16L,7L,12L,13L,8L,25L,5L,7L,20L,15L,5L,16L,9L,22L,31L,10L,33L,10L,18L,16L,19L,26L,14L,5L,39L,8L,21L,18L,18L,7L,43L,12L,22L,45L,32L,13L,10L,20L,25L,34L,49L,24L,5L,9L,14L,7L,22L,15L,15L,55L,5L,18L,40L,9L,24L,28L,31L,16L,61L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109353Inst : IEnumerable<long>
{
public static readonly long[] Value=A109353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109353.Bytes);
public long this[int i]=>Value[i];

public static A109353Inst Instance=new A109353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109354
{
public static readonly BigInteger[] Value={ 1L,1L,6L,216L,46656L,60466176L,470184984576L,21936950640377856L,BigInteger.Parse("6140942214464815497216"),BigInteger.Parse("10314424798490535546171949056"),BigInteger.Parse("103945637534048876111514866313854976") };
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
public class A109354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109354.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109354Inst Instance=new A109354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109355
{
public static readonly long[] Value={ 7L,19L,31L,37L,43L,57L,61L,103L,169L,213L,229L,243L,273L,337L,339L,349L,357L,387L,421L,441L,453L,463L,469L,483L,531L,541L,559L,577L,583L,597L,621L,631L,637L,643L,681L,687L,729L,759L,789L,819L,877L,901L,927L,931L,937L,1011L,1033L,1047L,1051L,1071L,1077L,1093L,1101L,1141L,1143L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109355Inst : IEnumerable<long>
{
public static readonly long[] Value=A109355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109355.Bytes);
public long this[int i]=>Value[i];

public static A109355Inst Instance=new A109355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109356
{
public static readonly long[] Value={ 1L,31L,59L,83L,97L,157L,193L,197L,233L,289L,347L,367L,409L,431L,439L,443L,547L,683L,701L,731L,733L,769L,781L,787L,797L,839L,877L,961L,1019L,1039L,1061L,1123L,1177L,1181L,1213L,1249L,1277L,1283L,1301L,1349L,1373L,1423L,1457L,1579L,1649L,1667L,1721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109356Inst : IEnumerable<long>
{
public static readonly long[] Value=A109356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109356.Bytes);
public long this[int i]=>Value[i];

public static A109356Inst Instance=new A109356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109357
{
public static readonly long[] Value={ 1L,21L,73L,81L,127L,157L,159L,181L,211L,213L,217L,259L,267L,271L,273L,283L,289L,301L,303L,321L,327L,337L,369L,409L,423L,457L,477L,507L,523L,537L,553L,559L,597L,603L,621L,631L,651L,691L,699L,727L,799L,807L,817L,843L,849L,867L,877L,897L,909L,919L,927L,967L,969L,981L,993L,997L,1017L,1021L,1047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109357Inst : IEnumerable<long>
{
public static readonly long[] Value=A109357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109357.Bytes);
public long this[int i]=>Value[i];

public static A109357Inst Instance=new A109357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109358
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,23L,25L,29L,31L,37L,41L,47L,55L,65L,67L,73L,77L,79L,91L,97L,101L,103L,109L,119L,143L,151L,155L,157L,161L,187L,197L,205L,209L,211L,221L,227L,233L,235L,239L,245L,253L,257L,263L,265L,275L,287L,289L,293L,299L,305L,307L,323L,331L,337L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109358Inst : IEnumerable<long>
{
public static readonly long[] Value=A109358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109358.Bytes);
public long this[int i]=>Value[i];

public static A109358Inst Instance=new A109358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109359
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,7L,7L,10L,10L,13L,11L,16L,16L,21L,17L,22L,20L,27L,23L,30L,26L,33L,27L,36L,32L,41L,33L,42L,36L,47L,39L,50L,42L,53L,43L,56L,48L,61L,49L,62L,52L,67L,55L,70L,58L,73L,59L,76L,64L,81L,65L,82L,68L,87L,71L,90L,74L,93L,75L,96L,80L,101L,81L,102L,84L,107L,87L,110L,90L,113L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109359Inst : IEnumerable<long>
{
public static readonly long[] Value=A109359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109359.Bytes);
public long this[int i]=>Value[i];

public static A109359Inst Instance=new A109359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109360
{
public static readonly long[] Value={ 0L,1L,5L,10L,8L,11L,11L,14L,10L,17L,19L,24L,16L,21L,21L,30L,24L,31L,27L,34L,26L,37L,35L,44L,32L,41L,37L,50L,40L,51L,43L,54L,42L,57L,51L,64L,48L,61L,53L,70L,56L,71L,59L,74L,58L,77L,67L,84L,64L,81L,69L,90L,72L,91L,75L,94L,74L,97L,83L,104L,80L,101L,85L,110L,88L,111L,91L,114L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109360Inst : IEnumerable<long>
{
public static readonly long[] Value=A109360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109360.Bytes);
public long this[int i]=>Value[i];

public static A109360Inst Instance=new A109360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109361
{
public static readonly long[] Value={ 1L,0L,3L,7L,21L,63L,252L,945L,4095L,0L,110565L,515970L,3611790L,21670740L,130024440L,806151528L,7255363752L,47159864388L,471598643880L,3301190507160L,26409524057280L,237685716515520L,2852228598186240L,21391714486396800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109361Inst : IEnumerable<long>
{
public static readonly long[] Value=A109361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109361.Bytes);
public long this[int i]=>Value[i];

public static A109361Inst Instance=new A109361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109362
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L,0L,3L,0L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109362Inst : IEnumerable<long>
{
public static readonly long[] Value=A109362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109362.Bytes);
public long this[int i]=>Value[i];

public static A109362Inst Instance=new A109362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109363
{
public static readonly long[] Value={ -1L,0L,5L,18L,47L,108L,233L,486L,995L,2016L,4061L,8154L,16343L,32724L,65489L,131022L,262091L,524232L,1048517L,2097090L,4194239L,8388540L,16777145L,33554358L,67108787L,134217648L,268435373L,536870826L,1073741735L,2147483556L,4294967201L,8589934494L,17179869083L,34359738264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109363Inst : IEnumerable<long>
{
public static readonly long[] Value=A109363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109363.Bytes);
public long this[int i]=>Value[i];

public static A109363Inst Instance=new A109363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109364
{
public static readonly long[] Value={ 5L,3L,5L,3L,15L,103L,39L,61L,45L,163L,159L,301L,2415L,403L,339L,331L,195L,553L,933L,24493L,1359L,85L,3999L,253L,267L,7567L,12969L,2815L,4419L,2047L,3171L,8203L,14019L,5665L,951L,5365L,5949L,6565L,7653L,77785L,3759L,5833L,1311L,4771L,18807L,7303L,25431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109364Inst : IEnumerable<long>
{
public static readonly long[] Value=A109364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109364.Bytes);
public long this[int i]=>Value[i];

public static A109364Inst Instance=new A109364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109365
{
public static readonly BigInteger[] Value={ 1L,4L,15L,95L,770L,9515L,133705L,2434740L,48800455L,1178409485L,35589088260L,1139792430095L,43489116179135L,1829785252978430L,80550797873775295L,3871887406957425075L,BigInteger.Parse("209479224856053619610"),BigInteger.Parse("12587715623517651636415") };
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
public class A109365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109365Inst Instance=new A109365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109366
{
public static readonly BigInteger[] Value={ 1L,2L,9L,55L,448L,5533L,77753L,1415862L,28378685L,685274581L,20695944714L,662817798145L,25290008485783L,1064065877641048L,46842303103453733L,2251599342111454707L,BigInteger.Parse("121817407196390147320"),BigInteger.Parse("7320071385771594519593") };
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
public class A109366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109366Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109366.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109366Inst Instance=new A109366Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109367
{
public static readonly long[] Value={ 9L,25L,49L,121L,169L,361L,529L,625L,841L,961L,1369L,1681L,2209L,3025L,4225L,4489L,5329L,5929L,6241L,8281L,9409L,10201L,10609L,11881L,14161L,20449L,22801L,24025L,24649L,25921L,34969L,38809L,42025L,43681L,44521L,48841L,51529L,54289L,55225L,57121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109367Inst : IEnumerable<long>
{
public static readonly long[] Value=A109367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109367.Bytes);
public long this[int i]=>Value[i];

public static A109367Inst Instance=new A109367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109368
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,4L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,20L,22L,24L,27L,30L,34L,37L,40L,44L,49L,54L,60L,65L,71L,78L,85L,94L,103L,112L,122L,132L,144L,158L,172L,186L,201L,218L,237L,258L,279L,302L,326L,352L,381L,412L,445L,480L,516L,556L,599L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109368Inst : IEnumerable<long>
{
public static readonly long[] Value=A109368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109368.Bytes);
public long this[int i]=>Value[i];

public static A109368Inst Instance=new A109368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109369
{
public static readonly long[] Value={ 1L,7L,13L,19L,23L,29L,31L,43L,47L,59L,61L,71L,73L,89L,91L,107L,113L,119L,149L,151L,161L,179L,181L,191L,199L,203L,211L,223L,247L,287L,289L,301L,311L,317L,329L,331L,343L,347L,349L,353L,359L,377L,391L,403L,409L,413L,427L,457L,461L,469L,479L,487L,493L,503L,521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109369Inst : IEnumerable<long>
{
public static readonly long[] Value=A109369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109369.Bytes);
public long this[int i]=>Value[i];

public static A109369Inst Instance=new A109369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109370
{
public static readonly long[] Value={ 3L,7L,9L,13L,21L,37L,39L,43L,51L,67L,69L,73L,81L,87L,93L,97L,109L,111L,123L,129L,133L,147L,153L,157L,159L,171L,189L,193L,229L,247L,259L,271L,273L,277L,279L,283L,291L,303L,307L,343L,349L,367L,369L,381L,391L,397L,409L,433L,441L,447L,453L,469L,481L,483L,501L,511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109370Inst : IEnumerable<long>
{
public static readonly long[] Value=A109370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109370.Bytes);
public long this[int i]=>Value[i];

public static A109370Inst Instance=new A109370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109371
{
public static readonly long[] Value={ 3L,17L,23L,29L,51L,53L,63L,71L,81L,87L,93L,113L,117L,119L,131L,149L,159L,161L,171L,173L,177L,197L,213L,239L,243L,251L,257L,261L,273L,279L,287L,299L,311L,317L,321L,329L,351L,353L,369L,383L,393L,399L,411L,423L,437L,443L,447L,467L,471L,483L,489L,491L,497L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109371Inst : IEnumerable<long>
{
public static readonly long[] Value=A109371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109371.Bytes);
public long this[int i]=>Value[i];

public static A109371Inst Instance=new A109371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109372
{
public static readonly long[] Value={ 1L,11L,12L,20L,33L,34L,35L,36L,52L,64L,75L,79L,84L,94L,95L,102L,104L,110L,112L,121L,138L,163L,167L,170L,174L,184L,192L,200L,217L,231L,235L,246L,250L,255L,256L,321L,336L,343L,352L,354L,365L,390L,394L,414L,415L,420L,422L,438L,440L,446L,450L,455L,462L,471L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109372Inst : IEnumerable<long>
{
public static readonly long[] Value=A109372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109372.Bytes);
public long this[int i]=>Value[i];

public static A109372Inst Instance=new A109372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109373
{
public static readonly long[] Value={ 10L,15L,22L,26L,34L,35L,39L,58L,86L,87L,94L,95L,119L,122L,123L,134L,142L,143L,146L,159L,178L,202L,203L,206L,214L,215L,218L,219L,254L,299L,302L,303L,327L,335L,362L,382L,394L,395L,446L,447L,454L,482L,502L,515L,527L,538L,543L,554L,566L,623L,634L,635L,695L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109373Inst : IEnumerable<long>
{
public static readonly long[] Value=A109373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109373.Bytes);
public long this[int i]=>Value[i];

public static A109373Inst Instance=new A109373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109374
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,3L,1L,5L,2L,1L,3L,4L,1L,8L,2L,1L,4L,1L,3L,1L,3L,1L,5L,1L,14L,2L,1L,5L,6L,1L,9L,4L,1L,20L,2L,1L,10L,1L,3L,1L,7L,1L,5L,1L,8L,1L,5L,1L,29L,2L,1L,10L,6L,1L,16L,1L,3L,1L,35L,2L,1L,12L,6L,1L,19L,1L,3L,1L,13L,1L,5L,1L,11L,8L,1L,24L,4L,1L,50L,2L,1L,25L,1L,3L,1L,53L,2L,1L,27L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109374Inst : IEnumerable<long>
{
public static readonly long[] Value=A109374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109374.Bytes);
public long this[int i]=>Value[i];

public static A109374Inst Instance=new A109374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109375
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,5L,1L,7L,1L,3L,5L,11L,1L,13L,7L,5L,1L,17L,1L,19L,5L,7L,11L,23L,1L,25L,13L,9L,7L,29L,5L,31L,1L,11L,17L,35L,3L,37L,19L,13L,5L,41L,7L,43L,11L,15L,23L,47L,1L,49L,25L,17L,13L,53L,3L,55L,7L,19L,29L,59L,1L,61L,31L,21L,1L,65L,11L,67L,17L,23L,35L,71L,1L,73L,37L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109375Inst : IEnumerable<long>
{
public static readonly long[] Value=A109375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109375.Bytes);
public long this[int i]=>Value[i];

public static A109375Inst Instance=new A109375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109376
{
public static readonly long[] Value={ 1L,11L,20L,33L,35L,36L,75L,79L,390L,1991L,9199L,91899L,699949L,5299999L,39999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109376Inst : IEnumerable<long>
{
public static readonly long[] Value=A109376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109376.Bytes);
public long this[int i]=>Value[i];

public static A109376Inst Instance=new A109376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109377
{
public static readonly long[] Value={ 2L,5L,10L,17L,29L,51L,90L,158L,277L,486L,853L,1497L,2627L,4610L,8090L,14197L,24914L,43721L,76725L,134643L,236282L,414646L,727653L,1276942L,2240877L,3932465L,6900995L,12110402L,21252274L,37295141L,65448410L,114853953L,201554637L,353703731L,620706778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109377Inst : IEnumerable<long>
{
public static readonly long[] Value=A109377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109377.Bytes);
public long this[int i]=>Value[i];

public static A109377Inst Instance=new A109377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109378
{
public static readonly long[] Value={ 4L,6L,10L,221L,1003L,22226L,100001L,2222245L,10000001L,222222223L,1000000006L,2222222227L,100000000013L,2222222222249L,10000000000015L,222222222222223L,10000000000000031L,22222222222222229L,100000000000000015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109378Inst : IEnumerable<long>
{
public static readonly long[] Value=A109378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109378.Bytes);
public long this[int i]=>Value[i];

public static A109378Inst Instance=new A109378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109379
{
public static readonly long[] Value={ 60L,168L,360L,504L,660L,1092L,2448L,2520L,3420L,4080L,5616L,6048L,6072L,7800L,7920L,9828L,12180L,14880L,20160L,20160L,25308L,25920L,29120L,32736L,34440L,39732L,51888L,58800L,62400L,74412L,95040L,102660L,113460L,126000L,150348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109379Inst : IEnumerable<long>
{
public static readonly long[] Value=A109379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109379.Bytes);
public long this[int i]=>Value[i];

public static A109379Inst Instance=new A109379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109380
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,3L,3L,5L,1L,4L,5L,7L,7L,9L,9L,10L,12L,13L,14L,12L,12L,16L,15L,17L,16L,19L,16L,21L,24L,21L,22L,22L,25L,25L,25L,27L,32L,33L,30L,34L,34L,36L,36L,37L,38L,38L,44L,42L,44L,42L,46L,47L,48L,50L,50L,47L,52L,52L,49L,54L,60L,60L,59L,56L,60L,62L,68L,70L,65L,65L,67L,70L,70L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109380Inst : IEnumerable<long>
{
public static readonly long[] Value=A109380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109380.Bytes);
public long this[int i]=>Value[i];

public static A109380Inst Instance=new A109380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109381
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,1L,2L,2L,2L,3L,4L,1L,1L,2L,3L,4L,2L,2L,3L,3L,3L,3L,4L,4L,4L,5L,5L,1L,2L,1L,2L,2L,2L,3L,3L,4L,4L,5L,2L,3L,2L,2L,3L,3L,4L,4L,5L,3L,3L,3L,4L,3L,4L,5L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,1L,1L,2L,3L,4L,2L,2L,3L,4L,5L,3L,2L,3L,4L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,2L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109381Inst : IEnumerable<long>
{
public static readonly long[] Value=A109381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109381.Bytes);
public long this[int i]=>Value[i];

public static A109381Inst Instance=new A109381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109382
{
public static readonly long[] Value={ 4L,3L,4L,5L,3L,3L,4L,5L,4L,3L,4L,4L,6L,3L,3L,2L,4L,4L,3L,7L,3L,3L,4L,5L,3L,3L,4L,5L,4L,7L,3L,3L,4L,5L,3L,3L,4L,5L,4L,7L,3L,3L,4L,5L,3L,3L,4L,5L,4L,6L,3L,3L,4L,5L,3L,3L,4L,5L,4L,6L,3L,3L,4L,5L,3L,3L,4L,5L,4L,7L,3L,3L,4L,5L,3L,3L,4L,5L,4L,8L,3L,3L,4L,5L,3L,3L,4L,5L,4L,7L,3L,3L,4L,5L,3L,3L,4L,5L,4L,7L,3L,4L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109382Inst : IEnumerable<long>
{
public static readonly long[] Value=A109382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109382.Bytes);
public long this[int i]=>Value[i];

public static A109382Inst Instance=new A109382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109383
{
public static readonly long[] Value={ 112L,120L,162L,300L,304L,378L,392L,396L,408L,520L,552L,567L,592L,612L,630L,656L,675L,680L,688L,696L,700L,750L,780L,918L,924L,944L,952L,980L,990L,1044L,1100L,1116L,1136L,1140L,1160L,1168L,1170L,1242L,1264L,1272L,1300L,1323L,1352L,1372L,1380L,1386L,1416L,1470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109383Inst : IEnumerable<long>
{
public static readonly long[] Value=A109383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109383.Bytes);
public long this[int i]=>Value[i];

public static A109383Inst Instance=new A109383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109384
{
public static readonly BigInteger[] Value={ 32L,512L,131072L,8589934592L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("680564733841876926926749214863536422912"),BigInteger.Parse("231584178474632390847141970017375815706539969331281128078915168015826259279872") };
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
public class A109384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109384Inst Instance=new A109384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109385
{
public static readonly long[] Value={ 1L,2L,6L,13L,32L,92L,218L,576L,1698L,4300L,11770L,34914L,91105L,254438L,759488L,2030618L,5746274L,17189858L,46698068L,133334440L,399479982L,1099206284L,3159208516L,9470895658L,26313455375L,76003857800L,227935595004L,638304618462L,1850933165704L,5551816202580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109385Inst : IEnumerable<long>
{
public static readonly long[] Value=A109385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109385.Bytes);
public long this[int i]=>Value[i];

public static A109385Inst Instance=new A109385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109386
{
public static readonly long[] Value={ 1L,3L,7L,7L,11L,21L,15L,15L,34L,33L,23L,49L,27L,45L,77L,31L,35L,102L,39L,77L,105L,69L,47L,105L,86L,81L,142L,105L,59L,231L,63L,63L,161L,105L,165L,238L,75L,117L,189L,165L,83L,315L,87L,161L,374L,141L,95L,217L,162L,258L,245L,189L,107L,426L,253L,225L,273L,177L,119L,539L,123L,189L,510L,127L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109386Inst : IEnumerable<long>
{
public static readonly long[] Value=A109386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109386.Bytes);
public long this[int i]=>Value[i];

public static A109386Inst Instance=new A109386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109387
{
public static readonly long[] Value={ 1L,4L,10L,52L,112L,212L,346L,406L,512L,13904L,76610L,89746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109387Inst : IEnumerable<long>
{
public static readonly long[] Value=A109387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109387.Bytes);
public long this[int i]=>Value[i];

public static A109387Inst Instance=new A109387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109388
{
public static readonly long[] Value={ 2L,4L,12L,32L,80L,240L,672L,1792L,5376L,15360L,42240L,126720L,366080L,1025024L,3075072L,8945664L,25346048L,76038144L,222265344L,635043840L,1905131520L,5588385792L,16066609152L,48199827456L,141764198400L,409541017600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109388Inst : IEnumerable<long>
{
public static readonly long[] Value=A109388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109388.Bytes);
public long this[int i]=>Value[i];

public static A109388Inst Instance=new A109388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109389
{
public static readonly long[] Value={ 1L,-1L,0L,0L,0L,-1L,1L,-1L,1L,0L,0L,-1L,2L,-2L,1L,0L,1L,-2L,3L,-3L,2L,-1L,1L,-3L,5L,-5L,3L,-1L,2L,-5L,7L,-7L,5L,-3L,3L,-7L,11L,-11L,7L,-4L,6L,-11L,15L,-15L,11L,-7L,8L,-15L,22L,-22L,15L,-10L,13L,-22L,30L,-30L,23L,-16L,18L,-30L,42L,-42L,31L,-22L,27L,-43L,56L,-56L,44L,-33L,37L,-57L,77L,-77L,59L,-45L,53L,-79L,101L,-101L,82L,-64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109389Inst : IEnumerable<long>
{
public static readonly long[] Value=A109389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109389.Bytes);
public long this[int i]=>Value[i];

public static A109389Inst Instance=new A109389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109390
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,5L,2L,1L,5L,5L,1L,1L,2L,1L,1L,1L,3L,7L,3L,3L,12L,12L,3L,1L,7L,12L,7L,1L,1L,3L,3L,1L,1L,1L,4L,9L,4L,6L,22L,22L,6L,4L,22L,36L,22L,4L,1L,9L,22L,22L,9L,1L,1L,1L,5L,11L,5L,10L,35L,35L,10L,10L,50L,80L,50L,10L,5L,35L,80L,80L,35L,5L,1L,11L,35L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109390Inst : IEnumerable<long>
{
public static readonly long[] Value=A109390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109390.Bytes);
public long this[int i]=>Value[i];

public static A109390Inst Instance=new A109390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109391
{
public static readonly BigInteger[] Value={ 0L,1L,12L,162L,2560L,46875L,979776L,23059204L,603979776L,17433922005L,550000000000L,18830570260326L,695455834963968L,27561634699895023L,1166760716683591680L,BigInteger.Parse("52547266845703125000"),BigInteger.Parse("2508757194024499019776") };
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
public class A109391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109391Inst Instance=new A109391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109392
{
public static readonly BigInteger[] Value={ 0L,1L,13L,175L,2735L,49610L,1029386L,24088590L,628068366L,18061990371L,568061990371L,19398632250697L,714854467214665L,28276489167109688L,1195037205850701368L,BigInteger.Parse("53742304051553826368"),BigInteger.Parse("2562499498076052846144") };
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
public class A109392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109392Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109392.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109392Inst Instance=new A109392Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109393
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,2L,5L,2L,1L,1L,1L,3L,3L,1L,1L,7L,12L,7L,1L,3L,12L,12L,3L,3L,7L,3L,1L,1L,1L,4L,6L,4L,1L,1L,9L,22L,22L,9L,1L,4L,22L,36L,22L,4L,6L,22L,22L,6L,4L,9L,4L,1L,1L,1L,5L,10L,10L,5L,1L,1L,11L,35L,50L,35L,11L,1L,5L,35L,80L,80L,35L,5L,10L,50L,80L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109393Inst : IEnumerable<long>
{
public static readonly long[] Value=A109393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109393.Bytes);
public long this[int i]=>Value[i];

public static A109393Inst Instance=new A109393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109394
{
public static readonly long[] Value={ 10L,12L,13L,13L,14L,15L,15L,15L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,21L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109394Inst : IEnumerable<long>
{
public static readonly long[] Value=A109394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109394.Bytes);
public long this[int i]=>Value[i];

public static A109394Inst Instance=new A109394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109395
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,2L,3L,5L,11L,3L,13L,7L,15L,2L,17L,3L,19L,5L,7L,11L,23L,3L,5L,13L,3L,7L,29L,15L,31L,2L,33L,17L,35L,3L,37L,19L,13L,5L,41L,7L,43L,11L,15L,23L,47L,3L,7L,5L,51L,13L,53L,3L,11L,7L,19L,29L,59L,15L,61L,31L,7L,2L,65L,33L,67L,17L,69L,35L,71L,3L,73L,37L,15L,19L,77L,13L,79L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109395Inst : IEnumerable<long>
{
public static readonly long[] Value=A109395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109395.Bytes);
public long this[int i]=>Value[i];

public static A109395Inst Instance=new A109395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109396
{
public static readonly long[] Value={ 12L,20L,24L,30L,40L,42L,54L,70L,102L,114L,120L,222L,270L,402L,1002L,2022L,2202L,10002L,10014L,10792L,11202L,12102L,21102L,31002L,32128L,45356L,103002L,110202L,111102L,128768L,740870L,1000002L,1000014L,1001202L,1002102L,1021002L,1111002L,1200102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109396Inst : IEnumerable<long>
{
public static readonly long[] Value=A109396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109396.Bytes);
public long this[int i]=>Value[i];

public static A109396Inst Instance=new A109396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109397
{
public static readonly long[] Value={ 0L,6L,10L,11L,102L,146L,296L,1415L,2324L,4374L,12590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109397Inst : IEnumerable<long>
{
public static readonly long[] Value=A109397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109397.Bytes);
public long this[int i]=>Value[i];

public static A109397Inst Instance=new A109397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109398
{
public static readonly BigInteger[] Value={ 1L,3L,16L,145L,1926L,33649L,726328L,18636561L,553680370L,18684924841L,705833193924L,29502690532393L,1351724235304366L,67359683340291105L,3627011494019437936L,BigInteger.Parse("209846445862386234529"),BigInteger.Parse("12982402818188717219658") };
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
public class A109398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109398Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109398.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109398Inst Instance=new A109398Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109399
{
public static readonly long[] Value={ 216L,1000L,1080L,1512L,2376L,2744L,2808L,3000L,3375L,3672L,4104L,4968L,5400L,6264L,6696L,6750L,7000L,7560L,7992L,8232L,8856L,9000L,9261L,9288L,10152L,10584L,10648L,11000L,11448L,11880L,12744L,13000L,13176L,13500L,13720L,14040L,14472L,15336L,15768L,16632L,17000L,17064L,17576L,17928L,18360L,18522L,19000L,19224L,19656L,20520L,20952L,21000L,21816L,22248L,23000L,23112L,23544L,23625L,24408L,24696L,24840L,25704L,26136L,27000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109399Inst : IEnumerable<long>
{
public static readonly long[] Value=A109399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109399.Bytes);
public long this[int i]=>Value[i];

public static A109399Inst Instance=new A109399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109400
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,3L,1L,2L,3L,2L,3L,5L,1L,2L,3L,4L,2L,3L,5L,7L,1L,2L,3L,4L,5L,2L,3L,5L,7L,11L,1L,2L,3L,4L,5L,6L,2L,3L,5L,7L,11L,13L,1L,2L,3L,4L,5L,6L,7L,2L,3L,5L,7L,11L,13L,17L,1L,2L,3L,4L,5L,6L,7L,8L,2L,3L,5L,7L,11L,13L,17L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,3L,5L,7L,11L,13L,17L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109400Inst : IEnumerable<long>
{
public static readonly long[] Value=A109400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109400.Bytes);
public long this[int i]=>Value[i];

public static A109400Inst Instance=new A109400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109401
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,6L,7L,8L,9L,9L,10L,11L,11L,12L,13L,14L,15L,15L,16L,17L,17L,18L,19L,20L,21L,22L,23L,23L,24L,25L,25L,26L,26L,27L,28L,29L,30L,31L,32L,32L,33L,34L,34L,35L,35L,36L,37L,38L,39L,40L,41L,42L,43L,43L,44L,45L,45L,46L,46L,47L,47L,48L,49L,50L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109401Inst : IEnumerable<long>
{
public static readonly long[] Value=A109401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109401.Bytes);
public long this[int i]=>Value[i];

public static A109401Inst Instance=new A109401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109402
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,11L,12L,14L,17L,19L,22L,27L,28L,30L,33L,37L,39L,42L,47L,54L,55L,57L,60L,64L,69L,71L,74L,79L,86L,97L,98L,100L,103L,107L,112L,118L,120L,123L,128L,135L,146L,159L,160L,162L,165L,169L,174L,180L,187L,189L,192L,197L,204L,215L,228L,245L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109402Inst : IEnumerable<long>
{
public static readonly long[] Value=A109402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109402.Bytes);
public long this[int i]=>Value[i];

public static A109402Inst Instance=new A109402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109403
{
public static readonly long[] Value={ 5L,12L,18L,50L,53L,56L,60L,67L,89L,92L,113L,120L,126L,131L,144L,160L,173L,184L,186L,204L,211L,216L,220L,236L,242L,248L,251L,266L,276L,288L,290L,293L,300L,304L,307L,320L,322L,328L,337L,340L,368L,374L,379L,384L,392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109403Inst : IEnumerable<long>
{
public static readonly long[] Value=A109403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109403.Bytes);
public long this[int i]=>Value[i];

public static A109403Inst Instance=new A109403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109404
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,11L,13L,22L,25L,27L,29L,37L,46L,51L,52L,76L,83L,86L,92L,104L,111L,113L,115L,123L,132L,140L,149L,190L,213L,218L,222L,233L,242L,274L,280L,281L,286L,298L,303L,307L,309L,336L,340L,346L,351L,379L,381L,395L,402L,415L,424L,444L,449L,463L,477L,478L,490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109404Inst : IEnumerable<long>
{
public static readonly long[] Value=A109404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109404.Bytes);
public long this[int i]=>Value[i];

public static A109404Inst Instance=new A109404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109405
{
public static readonly long[] Value={ 36L,736L,8736L,48736L,948736L,2948736L,32948736L,432948736L,3432948736L,53432948736L,353432948736L,5353432948736L,75353432948736L,75353432948736L,5075353432948736L,15075353432948736L,615075353432948736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109405Inst : IEnumerable<long>
{
public static readonly long[] Value=A109405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109405.Bytes);
public long this[int i]=>Value[i];

public static A109405Inst Instance=new A109405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109406
{
public static readonly long[] Value={ 3L,4L,9L,10L,11L,14L,20L,28L,29L,32L,34L,40L,43L,44L,45L,46L,50L,53L,58L,59L,61L,62L,63L,68L,69L,72L,74L,80L,83L,86L,89L,95L,99L,100L,101L,105L,107L,109L,111L,112L,115L,116L,118L,119L,121L,123L,127L,129L,130L,131L,132L,136L,137L,140L,144L,145L,150L,151L,152L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109406Inst : IEnumerable<long>
{
public static readonly long[] Value=A109406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109406.Bytes);
public long this[int i]=>Value[i];

public static A109406Inst Instance=new A109406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109407
{
public static readonly long[] Value={ 33L,51L,70L,97L,112L,139L,182L,210L,246L,289L,306L,329L,347L,363L,406L,450L,472L,506L,528L,551L,582L,601L,637L,666L,688L,705L,740L,758L,793L,852L,895L,918L,995L,1016L,1076L,1118L,1156L,1193L,1229L,1272L,1300L,1321L,1341L,1367L,1407L,1433L,1450L,1488L,1512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109407Inst : IEnumerable<long>
{
public static readonly long[] Value=A109407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109407.Bytes);
public long this[int i]=>Value[i];

public static A109407Inst Instance=new A109407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109408
{
public static readonly long[] Value={ 2197L,2744L,4096L,4913L,10648L,12167L,15625L,21952L,39304L,50653L,103823L,140608L,195112L,262144L,300763L,314432L,405224L,438976L,614125L,1191016L,1225043L,1643032L,2197000L,2406104L,2685619L,2744000L,2863288L,3112136L,4096000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109408Inst : IEnumerable<long>
{
public static readonly long[] Value=A109408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109408.Bytes);
public long this[int i]=>Value[i];

public static A109408Inst Instance=new A109408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109409
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,9L,10L,1L,0L,0L,0L,0L,9L,10L,1L,0L,0L,0L,0L,0L,9L,10L,1L,0L,0L,0L,0L,0L,135L,159L,25L,1L,0L,0L,0L,0L,0L,0L,135L,159L,25L,1L,0L,0L,0L,0L,0L,0L,0L,135L,159L,25L,1L,0L,0L,0L,0L,0L,0L,0L,2835L,3474L,684L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109409Inst : IEnumerable<long>
{
public static readonly long[] Value=A109409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109409.Bytes);
public long this[int i]=>Value[i];

public static A109409Inst Instance=new A109409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109410
{
public static readonly long[] Value={ 19L,17L,19L,17L,19L,17L,19L,19L,19L,19L,17L,19L,19L,19L,19L,17L,17L,37L,19L,19L,17L,19L,19L,17L,37L,17L,37L,17L,19L,37L,37L,17L,37L,37L,37L,37L,37L,37L,37L,19L,17L,19L,37L,37L,17L,37L,37L,37L,19L,37L,37L,37L,37L,19L,37L,37L,37L,37L,37L,37L,37L,17L,37L,37L,37L,37L,37L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109410Inst : IEnumerable<long>
{
public static readonly long[] Value=A109410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109410.Bytes);
public long this[int i]=>Value[i];

public static A109410Inst Instance=new A109410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109411
{
public static readonly long[] Value={ 3L,1L,4L,1L,1L,5L,2L,3L,1L,1L,13L,3L,1L,3L,2L,2L,2L,1L,4L,6L,2L,1L,6L,1L,2L,2L,1L,14L,4L,1L,1L,1L,3L,5L,2L,1L,2L,2L,1L,3L,1L,10L,2L,7L,5L,4L,2L,1L,2L,2L,2L,6L,1L,2L,3L,5L,2L,3L,4L,5L,6L,2L,3L,2L,2L,4L,1L,14L,1L,1L,4L,7L,5L,2L,3L,6L,1L,2L,2L,2L,1L,2L,2L,1L,4L,2L,2L,2L,3L,17L,2L,3L,1L,10L,3L,1L,3L,6L,1L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109411Inst : IEnumerable<long>
{
public static readonly long[] Value=A109411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109411.Bytes);
public long this[int i]=>Value[i];

public static A109411Inst Instance=new A109411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109412
{
public static readonly long[] Value={ 4L,9L,10L,21L,22L,39L,49L,62L,69L,74L,93L,94L,95L,106L,111L,115L,146L,159L,203L,218L,219L,247L,254L,259L,295L,309L,319L,326L,327L,346L,355L,358L,394L,395L,398L,403L,427L,445L,446L,447L,451L,454L,551L,581L,586L,611L,622L,623L,671L,674L,679L,687L,694L,695L,698L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109412Inst : IEnumerable<long>
{
public static readonly long[] Value=A109412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109412.Bytes);
public long this[int i]=>Value[i];

public static A109412Inst Instance=new A109412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109413
{
public static readonly long[] Value={ 1L,3L,6L,11L,17L,24L,35L,45L,58L,71L,87L,106L,123L,144L,164L,189L,216L,240L,269L,298L,329L,365L,396L,437L,471L,510L,551L,591L,642L,683L,730L,778L,827L,882L,932L,987L,1048L,1105L,1165L,1220L,1289L,1355L,1418L,1485L,1549L,1626L,1699L,1772L,1846L,1923L,2002L,2080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109413Inst : IEnumerable<long>
{
public static readonly long[] Value=A109413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109413.Bytes);
public long this[int i]=>Value[i];

public static A109413Inst Instance=new A109413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109414
{
public static readonly long[] Value={ 1L,4L,11L,26L,54L,90L,151L,232L,326L,456L,612L,811L,1030L,1304L,1607L,1953L,2383L,2812L,3329L,3893L,4515L,5226L,5983L,6809L,7703L,8718L,9762L,10891L,12160L,13475L,14868L,16380L,17986L,19699L,21524L,23415L,25482L,27658L,29923L,32288L,34814L,37452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109414Inst : IEnumerable<long>
{
public static readonly long[] Value=A109414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109414.Bytes);
public long this[int i]=>Value[i];

public static A109414Inst Instance=new A109414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109415
{
public static readonly long[] Value={ 1L,5L,19L,58L,152L,309L,585L,1046L,1666L,2601L,3871L,5508L,7680L,10423L,13835L,17984L,23168L,29225L,36431L,45000L,54780L,66299L,79637L,94546L,111612L,131215L,152683L,177008L,204264L,234375L,267795L,304678L,345240L,389213L,438235L,490842L,548542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109415Inst : IEnumerable<long>
{
public static readonly long[] Value=A109415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109415.Bytes);
public long this[int i]=>Value[i];

public static A109415Inst Instance=new A109415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109416
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,29L,31L,43L,47L,59L,61L,73L,89L,97L,101L,103L,107L,127L,131L,139L,151L,157L,173L,181L,193L,197L,229L,233L,239L,251L,263L,271L,283L,307L,311L,331L,337L,349L,353L,373L,389L,397L,401L,409L,421L,431L,439L,443L,463L,467L,479L,487L,491L,499L,503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109416Inst : IEnumerable<long>
{
public static readonly long[] Value=A109416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109416.Bytes);
public long this[int i]=>Value[i];

public static A109416Inst Instance=new A109416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109417
{
public static readonly long[] Value={ 2L,7L,11L,17L,29L,43L,47L,59L,73L,89L,97L,101L,107L,127L,131L,139L,151L,163L,167L,181L,193L,197L,229L,233L,251L,263L,271L,283L,307L,311L,337L,349L,353L,373L,389L,397L,401L,409L,421L,433L,443L,463L,467L,479L,487L,491L,499L,503L,523L,547L,563L,571L,587L,601L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109417Inst : IEnumerable<long>
{
public static readonly long[] Value=A109417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109417.Bytes);
public long this[int i]=>Value[i];

public static A109417Inst Instance=new A109417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109418
{
public static readonly long[] Value={ 2L,3L,19L,23L,37L,41L,53L,67L,71L,79L,83L,109L,113L,137L,149L,163L,167L,179L,191L,199L,211L,223L,227L,241L,257L,269L,277L,281L,293L,313L,317L,347L,359L,367L,379L,383L,419L,433L,449L,457L,461L,523L,547L,563L,571L,587L,599L,607L,619L,631L,653L,661L,673L,677L,701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109418Inst : IEnumerable<long>
{
public static readonly long[] Value=A109418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109418.Bytes);
public long this[int i]=>Value[i];

public static A109418Inst Instance=new A109418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109419
{
public static readonly long[] Value={ 5L,13L,31L,61L,103L,157L,173L,239L,331L,431L,439L,509L,521L,541L,557L,569L,577L,593L,643L,647L,659L,683L,691L,719L,727L,821L,829L,853L,857L,877L,1019L,1031L,1039L,1223L,1453L,1621L,1637L,1657L,1669L,1693L,1697L,1879L,1907L,1931L,1951L,1979L,2153L,2161L,2213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109419Inst : IEnumerable<long>
{
public static readonly long[] Value=A109419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109419.Bytes);
public long this[int i]=>Value[i];

public static A109419Inst Instance=new A109419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109420
{
public static readonly long[] Value={ 2L,163L,167L,433L,523L,547L,563L,571L,587L,653L,661L,673L,677L,701L,709L,823L,827L,839L,859L,863L,1013L,1021L,1033L,1447L,1451L,1627L,1663L,1667L,1889L,1901L,1913L,1933L,1949L,1973L,2179L,2203L,2207L,2239L,2243L,2251L,2267L,2437L,2441L,2473L,2477L,2521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109420Inst : IEnumerable<long>
{
public static readonly long[] Value=A109420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109420.Bytes);
public long this[int i]=>Value[i];

public static A109420Inst Instance=new A109420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109421
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,31L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109421Inst : IEnumerable<long>
{
public static readonly long[] Value=A109421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109421.Bytes);
public long this[int i]=>Value[i];

public static A109421Inst Instance=new A109421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109422
{
public static readonly long[] Value={ 4L,8L,9L,16L,25L,27L,30L,32L,36L,42L,49L,64L,66L,70L,72L,78L,81L,100L,102L,105L,108L,110L,114L,120L,121L,125L,128L,130L,138L,144L,154L,165L,168L,169L,170L,174L,180L,182L,186L,190L,195L,196L,200L,216L,222L,225L,230L,231L,238L,240L,243L,246L,252L,255L,256L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109422Inst : IEnumerable<long>
{
public static readonly long[] Value=A109422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109422.Bytes);
public long this[int i]=>Value[i];

public static A109422Inst Instance=new A109422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109423
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,8L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,29L,30L,31L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,50L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,77L,78L,79L,82L,83L,84L,85L,86L,87L,88L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109423Inst : IEnumerable<long>
{
public static readonly long[] Value=A109423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109423.Bytes);
public long this[int i]=>Value[i];

public static A109423Inst Instance=new A109423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109424
{
public static readonly long[] Value={ 4L,9L,12L,16L,25L,27L,28L,32L,36L,40L,48L,49L,52L,63L,64L,75L,76L,80L,81L,90L,100L,104L,112L,117L,121L,124L,128L,136L,144L,148L,162L,169L,171L,172L,175L,176L,180L,192L,196L,208L,225L,232L,234L,243L,244L,252L,256L,268L,272L,273L,279L,289L,292L,296L,300L,306L,316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109424Inst : IEnumerable<long>
{
public static readonly long[] Value=A109424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109424.Bytes);
public long this[int i]=>Value[i];

public static A109424Inst Instance=new A109424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109425
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,67L,68L,69L,71L,72L,73L,74L,75L,76L,77L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109425Inst : IEnumerable<long>
{
public static readonly long[] Value=A109425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109425.Bytes);
public long this[int i]=>Value[i];

public static A109425Inst Instance=new A109425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109426
{
public static readonly long[] Value={ 30L,36L,42L,66L,70L,78L,100L,102L,105L,110L,114L,120L,130L,138L,144L,154L,165L,168L,170L,174L,182L,186L,190L,195L,196L,222L,225L,230L,231L,238L,240L,246L,255L,258L,264L,266L,270L,273L,280L,282L,285L,286L,290L,310L,312L,318L,322L,324L,336L,345L,354L,357L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109426Inst : IEnumerable<long>
{
public static readonly long[] Value=A109426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109426.Bytes);
public long this[int i]=>Value[i];

public static A109426Inst Instance=new A109426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109427
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109427Inst : IEnumerable<long>
{
public static readonly long[] Value=A109427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109427.Bytes);
public long this[int i]=>Value[i];

public static A109427Inst Instance=new A109427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109428
{
public static readonly long[] Value={ 18L,36L,50L,72L,84L,98L,100L,144L,156L,162L,196L,200L,225L,228L,242L,252L,273L,288L,300L,324L,336L,338L,364L,372L,392L,399L,400L,441L,444L,468L,484L,516L,525L,532L,576L,578L,624L,648L,651L,676L,684L,700L,722L,732L,741L,756L,777L,784L,800L,804L,819L,868L,876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109428Inst : IEnumerable<long>
{
public static readonly long[] Value=A109428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109428.Bytes);
public long this[int i]=>Value[i];

public static A109428Inst Instance=new A109428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109429
{
public static readonly long[] Value={ 2L,4L,3L,16L,5L,7L,9L,256L,11L,13L,17L,19L,23L,25L,29L,65536L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,81L,83L,4294967296L,89L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109429Inst : IEnumerable<long>
{
public static readonly long[] Value=A109429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109429.Bytes);
public long this[int i]=>Value[i];

public static A109429Inst Instance=new A109429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109430
{
public static readonly long[] Value={ 0L,-1L,-5L,-4L,2L,1L,1L,-6L,0L,3L,3L,0L,-2L,1L,5L,2L,-4L,-1L,-1L,4L,-2L,-3L,-3L,-2L,0L,-1L,-5L,-4L,2L,1L,1L,-6L,0L,3L,3L,0L,-2L,1L,5L,2L,-4L,-1L,-1L,4L,-2L,-3L,-3L,-2L,0L,-1L,-5L,-4L,2L,1L,1L,-6L,0L,3L,3L,0L,-2L,1L,5L,2L,-4L,-1L,-1L,4L,-2L,-3L,-3L,-2L,0L,-1L,-5L,-4L,2L,1L,1L,-6L,0L,3L,3L,0L,-2L,1L,5L,2L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109430Inst : IEnumerable<long>
{
public static readonly long[] Value=A109430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109430.Bytes);
public long this[int i]=>Value[i];

public static A109430Inst Instance=new A109430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109431
{
public static readonly BigInteger[] Value={ 1L,1001L,100101L,1001011L,1001011001L,10010110011L,1001011001101L,1001011001101001L,100101100110100101L,1001011001101001011L,BigInteger.Parse("100101100110100101101"),BigInteger.Parse("100101100110100101101001") };
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
public class A109431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A109431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A109431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A109431Inst Instance=new A109431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109432
{
public static readonly long[] Value={ 1L,3L,9L,29L,103L,171L,417L,819L,883L,1733L,36603L,257577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109432Inst : IEnumerable<long>
{
public static readonly long[] Value=A109432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109432.Bytes);
public long this[int i]=>Value[i];

public static A109432Inst Instance=new A109432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109433
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,1L,8L,5L,2L,1L,16L,11L,5L,2L,1L,32L,24L,12L,5L,2L,1L,64L,51L,27L,12L,5L,2L,1L,128L,107L,60L,28L,12L,5L,2L,1L,256L,222L,131L,63L,28L,12L,5L,2L,1L,512L,457L,282L,140L,64L,28L,12L,5L,2L,1L,1024L,935L,601L,307L,143L,64L,28L,12L,5L,2L,1L,2048L,1904L,1270L,666L,316L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109433Inst : IEnumerable<long>
{
public static readonly long[] Value=A109433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109433.Bytes);
public long this[int i]=>Value[i];

public static A109433Inst Instance=new A109433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109434
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,4L,5L,8L,11L,12L,16L,24L,27L,28L,32L,51L,60L,63L,64L,64L,107L,131L,140L,143L,144L,128L,222L,282L,307L,316L,319L,320L,256L,457L,601L,666L,691L,700L,703L,704L,512L,935L,1270L,1432L,1498L,1523L,1532L,1535L,1536L,1024L,1904L,2665L,3057L,3224L,3290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109434Inst : IEnumerable<long>
{
public static readonly long[] Value=A109434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109434.Bytes);
public long this[int i]=>Value[i];

public static A109434Inst Instance=new A109434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109435
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,1L,8L,7L,3L,1L,16L,15L,8L,3L,1L,32L,31L,19L,8L,3L,1L,64L,63L,43L,20L,8L,3L,1L,128L,127L,94L,47L,20L,8L,3L,1L,256L,255L,201L,107L,48L,20L,8L,3L,1L,512L,511L,423L,238L,111L,48L,20L,8L,3L,1L,1024L,1023L,880L,520L,251L,112L,48L,20L,8L,3L,1L,2048L,2047L,1815L,1121L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109435Inst : IEnumerable<long>
{
public static readonly long[] Value=A109435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109435.Bytes);
public long this[int i]=>Value[i];

public static A109435Inst Instance=new A109435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109436
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,3L,4L,7L,8L,8L,15L,19L,20L,16L,31L,43L,47L,48L,32L,63L,94L,107L,111L,112L,64L,127L,201L,238L,251L,255L,256L,128L,255L,423L,520L,558L,571L,575L,576L,256L,511L,880L,1121L,1224L,1262L,1275L,1279L,1280L,512L,1023L,1815L,2391L,2656L,2760L,2798L,2811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109436Inst : IEnumerable<long>
{
public static readonly long[] Value=A109436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109436.Bytes);
public long this[int i]=>Value[i];

public static A109436Inst Instance=new A109436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109437
{
public static readonly long[] Value={ 0L,1L,3L,12L,44L,165L,615L,2296L,8568L,31977L,119339L,445380L,1662180L,6203341L,23151183L,86401392L,322454384L,1203416145L,4491210195L,16761424636L,62554488348L,233456528757L,871271626679L,3251629977960L,12135248285160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109437Inst : IEnumerable<long>
{
public static readonly long[] Value=A109437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109437.Bytes);
public long this[int i]=>Value[i];

public static A109437Inst Instance=new A109437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109438
{
public static readonly long[] Value={ 1L,5L,18L,68L,253L,945L,3526L,13160L,49113L,183293L,684058L,2552940L,9527701L,35557865L,132703758L,495257168L,1848324913L,6898042485L,25743845026L,96077337620L,358565505453L,1338184684193L,4994173231318L,18638508241080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109438Inst : IEnumerable<long>
{
public static readonly long[] Value=A109438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109438.Bytes);
public long this[int i]=>Value[i];

public static A109438Inst Instance=new A109438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109439
{
public static readonly long[] Value={ 1L,1L,3L,3L,1L,1L,3L,6L,7L,6L,3L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,3L,6L,10L,15L,18L,19L,18L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,25L,27L,27L,25L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,28L,33L,36L,37L,36L,33L,28L,21L,15L,10L,6L,3L,1L,1L,3L,6L,10L,15L,21L,28L,36L,42L,46L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109439Inst : IEnumerable<long>
{
public static readonly long[] Value=A109439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109439.Bytes);
public long this[int i]=>Value[i];

public static A109439Inst Instance=new A109439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A109440
{
public static readonly long[] Value={ 2L,6L,8L,14L,16L,18L,20L,26L,30L,42L,108L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A109440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A109440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A109440Inst : IEnumerable<long>
{
public static readonly long[] Value=A109440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A109440.Bytes);
public long this[int i]=>Value[i];

public static A109440Inst Instance=new A109440Inst();

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