using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A284173
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,3L,5L,7L,9L,1L,2L,4L,7L,9L,12L,15L,0L,3L,6L,9L,12L,17L,20L,0L,4L,8L,12L,16L,22L,26L,31L,4L,9L,14L,20L,26L,31L,37L,3L,8L,14L,20L,26L,32L,38L,1L,4L,11L,18L,23L,30L,39L,46L,53L,6L,12L,20L,28L,36L,44L,56L,1L,9L,21L,28L,36L,46L,57L,68L,9L,20L,30L,39L,48L,60L,69L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284173Inst : IEnumerable<long>
{
public static readonly long[] Value=A284173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284173.Bytes);
public long this[int i]=>Value[i];

public static A284173Inst Instance=new A284173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284174
{
public static readonly long[] Value={ 24L,30L,36L,60L,84L,90L,100L,112L,120L,128L,144L,152L,162L,198L,204L,210L,216L,240L,276L,288L,300L,320L,330L,340L,352L,360L,372L,384L,390L,396L,410L,450L,456L,462L,472L,480L,492L,520L,540L,558L,564L,576L,600L,624L,630L,648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284174Inst : IEnumerable<long>
{
public static readonly long[] Value=A284174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284174.Bytes);
public long this[int i]=>Value[i];

public static A284174Inst Instance=new A284174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284175
{
public static readonly BigInteger[] Value={ 1L,0L,1L,0L,101L,0L,10101L,1000L,1001001L,1000L,101001001L,10001000L,10010001001L,10101000L,1010010101001L,100010101000L,100100010101001L,101010101000L,10100100010101001L,1000101010101000L,1001000100010101001L,1010101010101000L,BigInteger.Parse("101001010100010101001") };
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
public class A284175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284175Inst Instance=new A284175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284176
{
public static readonly BigInteger[] Value={ 1L,0L,100L,0L,10100L,0L,1010100L,10000L,100100100L,1000000L,10010010100L,100010000L,1001000100100L,10101000000L,100101010010100L,1010100010000L,10010101000100100L,101010101000000L,1001010100010010100L,10101010100010000L,BigInteger.Parse("100101010001000100100") };
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
public class A284176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284176Inst Instance=new A284176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284177
{
public static readonly long[] Value={ 1L,0L,1L,0L,5L,0L,21L,8L,73L,8L,329L,136L,1161L,168L,5289L,2216L,18601L,2728L,84137L,35496L,297129L,43688L,1353897L,567976L,4761769L,699048L,21538985L,9087656L,76064937L,11184808L,346597545L,145402536L,1219012777L,178956968L,5513980073L,2326440616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284177Inst : IEnumerable<long>
{
public static readonly long[] Value=A284177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284177.Bytes);
public long this[int i]=>Value[i];

public static A284177Inst Instance=new A284177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284178
{
public static readonly long[] Value={ 1L,0L,4L,0L,20L,0L,84L,16L,292L,64L,1172L,272L,4644L,1344L,19092L,5392L,76324L,21824L,305300L,87312L,1221156L,349504L,4885140L,1398032L,19540516L,5592384L,78162068L,22369552L,312648228L,89478464L,1250593428L,357913872L,5002373668L,1431655744L,20009494676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284178Inst : IEnumerable<long>
{
public static readonly long[] Value=A284178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284178.Bytes);
public long this[int i]=>Value[i];

public static A284178Inst Instance=new A284178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284227
{
public static readonly BigInteger[] Value={ 32L,751L,23218L,1317770L,69938626L,3945536189L,227677212684L,13395146804734L,798088158296644L,47995267845339818L,2906776115786801739L,BigInteger.Parse("177031214800487853095"),BigInteger.Parse("10830742854736642158031"),BigInteger.Parse("665123041622355811314077") };
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
public class A284227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284227.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284227Inst Instance=new A284227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284228
{
public static readonly BigInteger[] Value={ 64L,2719L,170155L,19371893L,2058141264L,232036495984L,26772321109067L,3148948157013672L,375099683101859897L,BigInteger.Parse("45101225320947864321"),BigInteger.Parse("5461569534638135452419"),BigInteger.Parse("665104722603120565892383") };
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
public class A284228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284228.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284228Inst Instance=new A284228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284229
{
public static readonly long[] Value={ 1L,10L,12L,6L,336L,24L,5952L,168L,792L,496L,666624L,270L,10924032L,6720L,7344L,120L,3757637632L,4284L,45091651584L,2160L,79488L,1820672L,11544784011264L,672L,298080L,29331456L,106200L,13440L,53620880789471232L,10080L,1501384662105194496L,6552L,7022592L,7515275264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284229Inst : IEnumerable<long>
{
public static readonly long[] Value=A284229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284229.Bytes);
public long this[int i]=>Value[i];

public static A284229Inst Instance=new A284229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284230
{
public static readonly BigInteger[] Value={ 1L,2L,5L,24L,111L,762L,5127L,45588L,400593L,4370634L,47311677L,611446464L,7857786015L,117346361778L,1745000283087L,29562853594284L,499180661754849L,9458257569095826L,178734707493557301L,3744942786114870888L,BigInteger.Parse("78294815164675006479"),BigInteger.Parse("1797384789345147560298") };
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
public class A284230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284230Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284230.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284230.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284230Inst Instance=new A284230Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284231
{
public static readonly BigInteger[] Value={ 1L,5L,21L,152L,975L,8835L,75499L,830180L,8819417L,114384573L,1450018173L,21689509992L,319180726887L,5411092531323L,90615453774771L,1717272516535812L,32234085990345105L,675335923050095253L,14040521125141683717UL,BigInteger.Parse("322252846702242056280"),BigInteger.Parse("7349647183279936080543") };
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
public class A284231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284231Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284231.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284231.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284231Inst Instance=new A284231Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284232
{
public static readonly ulong[] Value={ 1L,11L,1L,1111L,10101L,11L,1010001L,11111111L,1000101L,1100110011L,10001000001L,1111L,1000100010101L,11001100000011L,1000101010001L,1111111111111111L,10100010101000101L,11000000110011L,1010100010101000001L,11110000111100001111UL,1000000010000010101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284232Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284232.Bytes);
public ulong this[int i]=>Value[i];

public static A284232Inst Instance=new A284232Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284233
{
public static readonly long[] Value={ 0L,0L,3L,0L,5L,3L,7L,0L,12L,5L,11L,3L,13L,7L,8L,0L,17L,12L,19L,5L,10L,11L,23L,3L,30L,13L,39L,7L,29L,8L,31L,0L,14L,17L,12L,12L,37L,19L,16L,5L,41L,10L,43L,11L,17L,23L,47L,3L,56L,30L,20L,13L,53L,39L,16L,7L,22L,29L,59L,8L,61L,31L,19L,0L,18L,14L,67L,17L,26L,12L,71L,12L,73L,37L,33L,19L,18L,16L,79L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284233Inst : IEnumerable<long>
{
public static readonly long[] Value=A284233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284233.Bytes);
public long this[int i]=>Value[i];

public static A284233Inst Instance=new A284233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284234
{
public static readonly long[] Value={ 1L,3L,1L,15L,21L,3L,81L,255L,69L,819L,1089L,15L,4373L,13059L,4433L,65535L,83269L,12339L,345409L,986895L,263189L,3158019L,4210769L,255L,16842821L,50529075L,16843841L,252641295L,353702165L,50541315L,1364267345L,4294967295L,1162102085L,13693562931L,18341971265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284234Inst : IEnumerable<long>
{
public static readonly long[] Value=A284234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284234.Bytes);
public long this[int i]=>Value[i];

public static A284234Inst Instance=new A284234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284235
{
public static readonly ulong[] Value={ 1L,0L,11L,101L,1010L,10101L,101010L,1010101L,10101010L,101010101L,1010101010L,10101010101L,101010101010L,1010101010101L,10101010101010L,101010101010101L,1010101010101010L,10101010101010101L,101010101010101010L,1010101010101010101L,10101010101010101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284235Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284235.Bytes);
public ulong this[int i]=>Value[i];

public static A284235Inst Instance=new A284235Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284236
{
public static readonly ulong[] Value={ 1L,0L,110L,1010L,1010L,101010L,101010L,10101010L,10101010L,1010101010L,1010101010L,101010101010L,101010101010L,10101010101010L,10101010101010L,1010101010101010L,1010101010101010L,101010101010101010L,101010101010101010L,10101010101010101010UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284236Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284236.Bytes);
public ulong this[int i]=>Value[i];

public static A284236Inst Instance=new A284236Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284237
{
public static readonly long[] Value={ 1L,0L,3L,5L,10L,21L,42L,85L,170L,341L,682L,1365L,2730L,5461L,10922L,21845L,43690L,87381L,174762L,349525L,699050L,1398101L,2796202L,5592405L,11184810L,22369621L,44739242L,89478485L,178956970L,357913941L,715827882L,1431655765L,2863311530L,5726623061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284237Inst : IEnumerable<long>
{
public static readonly long[] Value=A284237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284237.Bytes);
public long this[int i]=>Value[i];

public static A284237Inst Instance=new A284237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284238
{
public static readonly long[] Value={ 1L,0L,6L,10L,10L,42L,42L,170L,170L,682L,682L,2730L,2730L,10922L,10922L,43690L,43690L,174762L,174762L,699050L,699050L,2796202L,2796202L,11184810L,11184810L,44739242L,44739242L,178956970L,178956970L,715827882L,715827882L,2863311530L,2863311530L,11453246122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284238Inst : IEnumerable<long>
{
public static readonly long[] Value=A284238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284238.Bytes);
public long this[int i]=>Value[i];

public static A284238Inst Instance=new A284238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284239
{
public static readonly ulong[] Value={ 1L,11L,101L,1101L,10001L,111011L,1010001L,11011011L,100000001L,1110000011L,10101000101L,110101101101L,1000100010001L,11101110111011L,101000100000001L,1101101110000011L,10000000001000101L,111000000011101101L,1010100000101010001L,11010110001101011011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284239Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284239.Bytes);
public ulong this[int i]=>Value[i];

public static A284239Inst Instance=new A284239Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284240
{
public static readonly ulong[] Value={ 1L,11L,101L,1011L,10001L,110111L,1000101L,11011011L,100000001L,1100000111L,10100010101L,101101101011L,1000100010001L,11011101110111L,100000001000101L,1100000111011011L,10100010000000001L,101101110000000111L,1000101010000010101L,11011010110001101011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284240Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A284240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284240.Bytes);
public ulong this[int i]=>Value[i];

public static A284240Inst Instance=new A284240Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284241
{
public static readonly long[] Value={ 1L,3L,5L,13L,17L,59L,81L,219L,257L,899L,1349L,3437L,4369L,15291L,20737L,56195L,65605L,229613L,344401L,877403L,1119297L,3915491L,5314901L,14395349L,16808833L,58754115L,88165093L,224623133L,286527785L,1002322927L,1360614465L,3685187299L,4302839125L,15043144177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284241Inst : IEnumerable<long>
{
public static readonly long[] Value=A284241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284241.Bytes);
public long this[int i]=>Value[i];

public static A284241Inst Instance=new A284241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284242
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,55L,69L,219L,257L,775L,1301L,2923L,4369L,14199L,16453L,49627L,82945L,187399L,283669L,896107L,1066257L,3268471L,5590085L,11265499L,17021953L,50889735L,87725077L,193326187L,311493905L,1039605623L,1091914821L,3346982363L,5728386049L,9635402759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284242Inst : IEnumerable<long>
{
public static readonly long[] Value=A284242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284242.Bytes);
public long this[int i]=>Value[i];

public static A284242Inst Instance=new A284242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284563
{
public static readonly long[] Value={ 2L,2L,2L,10L,10L,10L,50L,10L,10L,250L,250L,50L,250L,250L,50L,110L,110L,250L,6250L,1250L,1250L,31250L,6250L,550L,2750L,6250L,6250L,13750L,2750L,2750L,6050L,110L,110L,30250L,68750L,13750L,343750L,781250L,156250L,151250L,151250L,781250L,19531250L,1718750L,343750L,8593750L,756250L,6050L,30250L,756250L,1718750L,3781250L,3781250L,8593750L,18906250L,151250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284563Inst : IEnumerable<long>
{
public static readonly long[] Value=A284563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284563.Bytes);
public long this[int i]=>Value[i];

public static A284563Inst Instance=new A284563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284564
{
public static readonly long[] Value={ 1L,3L,9L,3L,9L,27L,9L,21L,63L,27L,81L,189L,63L,189L,441L,21L,63L,1323L,567L,1323L,3969L,1701L,3969L,1323L,441L,9261L,27783L,1323L,3087L,9261L,441L,273L,819L,1323L,27783L,64827L,27783L,583443L,1361367L,9261L,27783L,4084101L,1750329L,583443L,1361367L,583443L,194481L,17199L,5733L,453789L,9529569L,453789L,1361367L,28588707L,1361367L,120393L,280917L,453789L,1361367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284564Inst : IEnumerable<long>
{
public static readonly long[] Value=A284564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284564.Bytes);
public long this[int i]=>Value[i];

public static A284564Inst Instance=new A284564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284565
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,2L,2L,4L,4L,3L,4L,4L,3L,3L,3L,4L,6L,5L,5L,7L,6L,4L,5L,6L,6L,6L,5L,5L,5L,3L,3L,6L,7L,6L,8L,9L,8L,7L,7L,9L,11L,9L,8L,10L,8L,5L,6L,8L,9L,9L,9L,10L,10L,7L,6L,9L,9L,7L,7L,7L,5L,4L,4L,6L,9L,8L,9L,12L,11L,8L,10L,13L,14L,13L,12L,13L,12L,8L,8L,13L,15L,13L,15L,17L,15L,12L,11L,14L,16L,13L,11L,13L,10L,6L,7L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284565Inst : IEnumerable<long>
{
public static readonly long[] Value=A284565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284565.Bytes);
public long this[int i]=>Value[i];

public static A284565Inst Instance=new A284565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284566
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,2L,3L,3L,4L,4L,3L,4L,4L,2L,3L,5L,5L,5L,6L,6L,6L,5L,4L,6L,7L,5L,5L,6L,4L,3L,4L,5L,7L,7L,7L,9L,9L,6L,7L,10L,10L,9L,9L,9L,8L,6L,5L,8L,10L,8L,9L,11L,9L,7L,7L,8L,9L,8L,6L,7L,6L,3L,4L,7L,8L,8L,10L,11L,11L,9L,9L,13L,15L,12L,12L,14L,11L,8L,9L,12L,15L,14L,14L,17L,16L,11L,11L,15L,15L,13L,12L,12L,10L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284566Inst : IEnumerable<long>
{
public static readonly long[] Value=A284566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284566.Bytes);
public long this[int i]=>Value[i];

public static A284566Inst Instance=new A284566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284567
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,20L,140L,70L,630L,63L,693L,8316L,108108L,30888L,51480L,823680L,14002560L,777920L,14780480L,739024L,15519504L,2821728L,64899744L,43266496L,1081662400L,166409600L,4493059200L,160466400L,4653525600L,3877938000L,120216078000L,15027009750L,495891321750L,14585038875L,20419054425L,9075135300L,335780006100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284567Inst : IEnumerable<long>
{
public static readonly long[] Value=A284567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284567.Bytes);
public long this[int i]=>Value[i];

public static A284567Inst Instance=new A284567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284568
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,36L,36L,576L,576L,57600L,57600L,57600L,57600L,2822400L,25401600L,25401600L,25401600L,8230118400L,8230118400L,3292047360000L,3292047360000L,398337730560000L,398337730560000L,14340158300160000L,14340158300160000L,2423486752727040000L,2423486752727040000L,BigInteger.Parse("1900013614137999360000"),BigInteger.Parse("1900013614137999360000") };
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
public class A284568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284568Inst Instance=new A284568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284569
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,2L,3L,3L,4L,5L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,2L,2L,2L,2L,2L,2L,2L,6L,3L,3L,3L,6L,4L,4L,5L,6L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,2L,2L,3L,4L,1L,1L,1L,2L,1L,1L,2L,3L,2L,2L,2L,2L,3L,3L,4L,5L,2L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,2L,2L,2L,6L,4L,3L,3L,3L,6L,3L,3L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284569Inst : IEnumerable<long>
{
public static readonly long[] Value=A284569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284569.Bytes);
public long this[int i]=>Value[i];

public static A284569Inst Instance=new A284569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284570
{
public static readonly long[] Value={ 2L,0L,2L,-2L,6L,-6L,4L,-2L,4L,-6L,12L,-12L,6L,0L,0L,-6L,12L,-12L,12L,-6L,0L,-6L,18L,-16L,4L,-2L,8L,-12L,24L,-24L,8L,-2L,0L,0L,16L,-22L,6L,0L,12L,-18L,24L,-24L,12L,0L,-6L,-6L,24L,-22L,10L,-6L,6L,-12L,18L,-12L,12L,-12L,0L,-6L,42L,-42L,6L,6L,-2L,-4L,18L,-24L,12L,-6L,18L,-24L,32L,-32L,6L,6L,0L,-6L,18L,-24L,24L,-18L,0L,-6L,42L,-36L,0L,0L,12L,-18L,42L,-36L,6L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284570Inst : IEnumerable<long>
{
public static readonly long[] Value=A284570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284570.Bytes);
public long this[int i]=>Value[i];

public static A284570Inst Instance=new A284570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284571
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,9L,5L,12L,32L,17L,18L,10L,24L,33L,64L,65L,34L,11L,36L,20L,48L,129L,7L,66L,19L,37L,128L,130L,68L,49L,22L,72L,40L,97L,96L,258L,14L,69L,132L,38L,74L,73L,21L,256L,260L,81L,13L,29L,136L,15L,98L,521L,44L,39L,144L,80L,194L,257L,192L,516L,23L,137L,28L,138L,264L,45L,76L,148L,146L,197L,42L,512L,147L,193L,520L,162L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284571Inst : IEnumerable<long>
{
public static readonly long[] Value=A284571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284571.Bytes);
public long this[int i]=>Value[i];

public static A284571Inst Instance=new A284571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284572
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,6L,25L,5L,8L,14L,20L,10L,49L,39L,52L,7L,12L,13L,27L,22L,45L,33L,63L,15L,121L,79L,80L,65L,50L,85L,2809L,11L,16L,19L,169L,21L,28L,42L,56L,35L,529L,73L,92L,55L,68L,103L,128L,23L,32L,199L,244L,130L,100L,131L,243L,106L,132L,82L,153L,139L,172L,4619L,5620L,17L,18L,26L,289L,31L,40L,277L,340L,34L,44L,43L,841L,69L,1849L,91L,171L,58L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284572Inst : IEnumerable<long>
{
public static readonly long[] Value=A284572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284572.Bytes);
public long this[int i]=>Value[i];

public static A284572Inst Instance=new A284572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284573
{
public static readonly long[] Value={ 2L,6L,12L,30L,60L,120L,180L,210L,420L,1080L,2160L,2520L,2520L,7560L,6300L,2310L,4620L,37800L,90720L,75600L,226800L,544320L,453600L,138600L,138600L,756000L,2268000L,831600L,415800L,2079000L,485100L,30030L,60060L,2910600L,24948000L,12474000L,49896000L,272160000L,136080000L,29106000L,87318000L,1360800000L,3265920000L,1496880000L,748440000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284573Inst : IEnumerable<long>
{
public static readonly long[] Value=A284573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284573.Bytes);
public long this[int i]=>Value[i];

public static A284573Inst Instance=new A284573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284574
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,2L,2L,0L,2L,2L,2L,2L,1L,2L,2L,0L,2L,0L,0L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284574Inst : IEnumerable<long>
{
public static readonly long[] Value=A284574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284574.Bytes);
public long this[int i]=>Value[i];

public static A284574Inst Instance=new A284574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284575
{
public static readonly long[] Value={ 0L,2L,1L,0L,2L,2L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,1L,0L,2L,2L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,1L,0L,2L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,1L,1L,0L,2L,0L,2L,0L,0L,0L,0L,2L,1L,0L,2L,1L,1L,2L,2L,0L,2L,0L,2L,2L,2L,2L,2L,2L,1L,0L,2L,2L,2L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,2L,1L,0L,2L,2L,0L,0L,0L,2L,0L,2L,2L,2L,2L,2L,0L,2L,1L,0L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284575Inst : IEnumerable<long>
{
public static readonly long[] Value=A284575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284575.Bytes);
public long this[int i]=>Value[i];

public static A284575Inst Instance=new A284575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284576
{
public static readonly long[] Value={ 2L,6L,6L,30L,90L,270L,30L,210L,630L,6750L,6750L,1890L,15750L,47250L,210L,2310L,6930L,47250L,47250L,330750L,992250L,425250L,47250L,103950L,173250L,2315250L,2315250L,519750L,8489250L,25467750L,2310L,30030L,90090L,519750L,25467750L,3638250L,1910081250L,13023281250L,1447031250L,1400726250L,4202178750L,104186250L,2604656250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284576Inst : IEnumerable<long>
{
public static readonly long[] Value=A284576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284576.Bytes);
public long this[int i]=>Value[i];

public static A284576Inst Instance=new A284576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284577
{
public static readonly long[] Value={ 2L,6L,2L,30L,90L,270L,2L,210L,630L,6750L,2250L,378L,15750L,47250L,2L,2310L,6930L,6750L,630L,66150L,198450L,3402L,90L,14850L,24750L,92610L,30870L,14850L,8489250L,25467750L,2L,30030L,90090L,6750L,339570L,14850L,382016250L,372093750L,9843750L,1400726250L,4202178750L,3402L,198450L,20465156250L,7796250L,83531250L,90L,859950L,1433250L,1890L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284577Inst : IEnumerable<long>
{
public static readonly long[] Value=A284577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284577.Bytes);
public long this[int i]=>Value[i];

public static A284577Inst Instance=new A284577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284578
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,1L,15L,1L,1L,1L,3L,5L,1L,1L,105L,1L,1L,7L,75L,5L,5L,125L,525L,7L,7L,25L,75L,35L,1L,1L,1155L,1L,1L,77L,75L,245L,5L,35L,147L,1L,1L,30625L,13125L,7L,245L,245L,40425L,11L,11L,13475L,1029L,245L,245L,1715L,1617L,11L,77L,1225L,3675L,385L,1L,1L,15015L,1L,1L,1001L,75L,245L,2695L,1715L,3L,1L,7L,48125L,7203L,1L,35L,300125L,363L,1L,1L,75625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284578Inst : IEnumerable<long>
{
public static readonly long[] Value=A284578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284578.Bytes);
public long this[int i]=>Value[i];

public static A284578Inst Instance=new A284578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284739
{
public static readonly long[] Value={ 0L,0L,2L,11L,2300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284739Inst : IEnumerable<long>
{
public static readonly long[] Value=A284739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284739.Bytes);
public long this[int i]=>Value[i];

public static A284739Inst Instance=new A284739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284740
{
public static readonly long[] Value={ 1L,0L,0L,6L,5L,349L,443L,110757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284740Inst : IEnumerable<long>
{
public static readonly long[] Value=A284740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284740.Bytes);
public long this[int i]=>Value[i];

public static A284740Inst Instance=new A284740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284741
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,24L,27L,66L,76L,136L,346L,399L,978L,1228L,2227L,4005L,5916L,6394L,7438L,18934L,20020L,31866L,85438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284741Inst : IEnumerable<long>
{
public static readonly long[] Value=A284741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284741.Bytes);
public long this[int i]=>Value[i];

public static A284741Inst Instance=new A284741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284742
{
public static readonly long[] Value={ 1L,5L,7L,9L,13L,15L,25L,33L,35L,55L,63L,69L,91L,121L,129L,147L,155L,189L,195L,231L,295L,309L,341L,377L,425L,427L,559L,561L,575L,589L,791L,833L,855L,909L,923L,1035L,1159L,1241L,1325L,1415L,1561L,1661L,1665L,1729L,2047L,2057L,2059L,2331L,2511L,2625L,2743L,2869L,3025L,3059L,3303L,3605L,3871L,3925L,4089L,4215L,4255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284742Inst : IEnumerable<long>
{
public static readonly long[] Value=A284742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284742.Bytes);
public long this[int i]=>Value[i];

public static A284742Inst Instance=new A284742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284743
{
public static readonly long[] Value={ 2L,3L,6L,7L,11L,15L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284743Inst : IEnumerable<long>
{
public static readonly long[] Value=A284743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284743.Bytes);
public long this[int i]=>Value[i];

public static A284743Inst Instance=new A284743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284744
{
public static readonly long[] Value={ 902L,1000402L,4000102L,5000102L,5000702L,6000902L,7000002L,104000102L,105000102L,105000902L,106000602L,109000002L,401000002L,405000402L,405000702L,405000902L,406000602L,407000502L,500000102L,500000402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284744Inst : IEnumerable<long>
{
public static readonly long[] Value=A284744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284744.Bytes);
public long this[int i]=>Value[i];

public static A284744Inst Instance=new A284744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284745
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284745Inst : IEnumerable<long>
{
public static readonly long[] Value=A284745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284745.Bytes);
public long this[int i]=>Value[i];

public static A284745Inst Instance=new A284745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284746
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,10L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,26L,27L,29L,30L,31L,32L,34L,36L,38L,40L,41L,42L,43L,45L,47L,49L,51L,52L,53L,54L,56L,58L,60L,62L,63L,64L,65L,67L,69L,71L,73L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,88L,89L,90L,91L,93L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284746Inst : IEnumerable<long>
{
public static readonly long[] Value=A284746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284746.Bytes);
public long this[int i]=>Value[i];

public static A284746Inst Instance=new A284746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284747
{
public static readonly BigInteger[] Value={ 0L,1L,4L,54L,1794L,99990L,7955460L,848584800L,116816051520L,20167501253760L,4268024125243200L,1086711068022148800L,BigInteger.Parse("327759648421871635200"),BigInteger.Parse("115567595710587359539200"),BigInteger.Parse("47104362677165542792243200"),BigInteger.Parse("21978200228619432098036736000"),BigInteger.Parse("11639211300056830532862403584000"),BigInteger.Parse("6943663015969522875618267601920000") };
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
public class A284747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A284747.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A284747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A284747Inst Instance=new A284747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284748
{
public static readonly long[] Value={ 2L,2L,6L,8L,4L,3L,3L,3L,0L,9L,5L,0L,2L,0L,4L,8L,7L,2L,1L,3L,5L,6L,3L,2L,5L,4L,0L,1L,4L,4L,0L,5L,7L,6L,0L,4L,3L,8L,1L,2L,5L,8L,6L,6L,3L,9L,1L,6L,8L,1L,3L,9L,5L,1L,6L,8L,8L,9L,9L,3L,3L,2L,6L,4L,3L,2L,9L,0L,9L,7L,1L,5L,1L,0L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284748Inst : IEnumerable<long>
{
public static readonly long[] Value=A284748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284748.Bytes);
public long this[int i]=>Value[i];

public static A284748Inst Instance=new A284748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284749
{
public static readonly long[] Value={ 0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,0L,1L,2L,2L,0L,1L,2L,2L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284749Inst : IEnumerable<long>
{
public static readonly long[] Value=A284749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284749.Bytes);
public long this[int i]=>Value[i];

public static A284749Inst Instance=new A284749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284750
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,1L,1L,1L,1L,3L,3L,2L,2L,9L,2L,2L,9L,7L,8L,6L,6L,33L,256L,1L,1L,1L,1L,26L,5L,1L,1L,1L,1L,149L,24L,4L,159L,4L,130L,3L,3L,3L,3L,118L,16L,128L,16L,3L,3L,3L,3L,14L,16L,16L,840L,13L,89L,15L,88L,2L,2L,12L,2L,2L,78L,11L,13L,76L,597L,12L,71L,2L,2L,555L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284750Inst : IEnumerable<long>
{
public static readonly long[] Value=A284750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284750.Bytes);
public long this[int i]=>Value[i];

public static A284750Inst Instance=new A284750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284751
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284751Inst : IEnumerable<long>
{
public static readonly long[] Value=A284751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284751.Bytes);
public long this[int i]=>Value[i];

public static A284751Inst Instance=new A284751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284752
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,11L,13L,14L,15L,17L,19L,20L,21L,23L,25L,26L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,45L,47L,48L,49L,51L,53L,55L,57L,58L,59L,61L,63L,64L,65L,67L,69L,71L,73L,74L,75L,77L,79L,80L,81L,83L,85L,87L,89L,90L,91L,93L,95L,96L,97L,99L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284752Inst : IEnumerable<long>
{
public static readonly long[] Value=A284752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284752.Bytes);
public long this[int i]=>Value[i];

public static A284752Inst Instance=new A284752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284753
{
public static readonly long[] Value={ 2L,6L,8L,10L,12L,16L,18L,22L,24L,28L,30L,34L,36L,38L,40L,44L,46L,50L,52L,54L,56L,60L,62L,66L,68L,70L,72L,76L,78L,82L,84L,86L,88L,92L,94L,98L,100L,104L,106L,110L,112L,114L,116L,120L,122L,126L,128L,130L,132L,136L,138L,142L,144L,148L,150L,154L,156L,158L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284753Inst : IEnumerable<long>
{
public static readonly long[] Value=A284753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284753.Bytes);
public long this[int i]=>Value[i];

public static A284753Inst Instance=new A284753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A284754
{
public static readonly long[] Value={ 1L,59L,436L,995752L,180707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A284754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A284754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A284754Inst : IEnumerable<long>
{
public static readonly long[] Value=A284754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A284754.Bytes);
public long this[int i]=>Value[i];

public static A284754Inst Instance=new A284754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285011
{
public static readonly long[] Value={ 7L,9L,77L,79L,97L,99L,777L,779L,797L,799L,977L,979L,997L,999L,7777L,7779L,7797L,7799L,7977L,7979L,7997L,7999L,9777L,9779L,9797L,9799L,9977L,9979L,9997L,9999L,77777L,77779L,77797L,77799L,77977L,77979L,77997L,77999L,79777L,79779L,79797L,79799L,79977L,79979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285011Inst : IEnumerable<long>
{
public static readonly long[] Value=A285011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285011.Bytes);
public long this[int i]=>Value[i];

public static A285011Inst Instance=new A285011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285012
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,6L,5L,1L,1L,7L,6L,1L,1L,13L,19L,7L,1L,1L,15L,25L,10L,1L,1L,25L,64L,43L,10L,1L,1L,31L,90L,65L,15L,1L,1L,50L,208L,220L,85L,13L,1L,1L,63L,301L,350L,140L,21L,1L,1L,99L,656L,1059L,618L,154L,17L,1L,1L,127L,966L,1701L,1050L,266L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285012Inst : IEnumerable<long>
{
public static readonly long[] Value=A285012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285012.Bytes);
public long this[int i]=>Value[i];

public static A285012Inst Instance=new A285012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285013
{
public static readonly long[] Value={ 1L,2L,2L,5L,5L,13L,15L,41L,52L,144L,203L,578L,877L,2605L,4140L,12869L,21147L,69178L,115975L,398766L,678570L,2450406L,4213597L,15939952L,27644437L,109304914L,190899322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285013Inst : IEnumerable<long>
{
public static readonly long[] Value=A285013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285013.Bytes);
public long this[int i]=>Value[i];

public static A285013Inst Instance=new A285013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285014
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,3L,0L,0L,0L,3L,0L,0L,3L,0L,1L,2L,0L,0L,3L,0L,3L,0L,0L,3L,0L,0L,0L,7L,0L,0L,5L,0L,3L,2L,0L,3L,0L,3L,0L,0L,0L,3L,0L,15L,4L,0L,3L,2L,0L,0L,3L,2L,3L,0L,0L,1L,0L,0L,15L,0L,3L,0L,0L,35L,0L,3L,0L,3L,0L,0L,3L,0L,0L,0L,15L,0L,0L,0L,3L,2L,0L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285014Inst : IEnumerable<long>
{
public static readonly long[] Value=A285014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285014.Bytes);
public long this[int i]=>Value[i];

public static A285014Inst Instance=new A285014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285015
{
public static readonly long[] Value={ 3L,7L,11L,19L,23L,31L,43L,47L,53L,59L,67L,71L,79L,83L,103L,107L,127L,131L,139L,151L,163L,167L,179L,191L,199L,211L,223L,227L,239L,251L,263L,269L,271L,283L,307L,311L,331L,347L,359L,367L,379L,383L,419L,431L,439L,443L,463L,467L,479L,487L,491L,499L,503L,523L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285015Inst : IEnumerable<long>
{
public static readonly long[] Value=A285015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285015.Bytes);
public long this[int i]=>Value[i];

public static A285015Inst Instance=new A285015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285016
{
public static readonly long[] Value={ 7L,11L,19L,43L,53L,67L,163L,211L,283L,331L,523L,547L,691L,787L,907L,1051L,1123L,1171L,1279L,1531L,1723L,1867L,2011L,2083L,2251L,2347L,2371L,2467L,2707L,2731L,2803L,2971L,3187L,3307L,3547L,3643L,3907L,3931L,4051L,4243L,4363L,4603L,4651L,4723L,5107L,5227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285016Inst : IEnumerable<long>
{
public static readonly long[] Value=A285016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285016.Bytes);
public long this[int i]=>Value[i];

public static A285016Inst Instance=new A285016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285017
{
public static readonly long[] Value={ 43L,73L,157L,211L,241L,421L,463L,601L,757L,1123L,1483L,2551L,2971L,3307L,3907L,4423L,4831L,5701L,6007L,6163L,6481L,8191L,9901L,11131L,12211L,12433L,13807L,14281L,19183L,20023L,20593L,21757L,22621L,22651L,23563L,24181L,26083L,26407L,27061L,28393L,31153L,35533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285017Inst : IEnumerable<long>
{
public static readonly long[] Value=A285017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285017.Bytes);
public long this[int i]=>Value[i];

public static A285017Inst Instance=new A285017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285018
{
public static readonly BigInteger[] Value={ 1L,6L,24L,432L,10368L,6912L,248832L,1492992L,23887872L,1289945088L,15479341056L,30958682112L,2229025112064L,13374150672384L,5944066965504L,106993205379072L,10271347716390912L,20542695432781824L,2218611106740436992L,13311666640442621952UL,BigInteger.Parse("106493333123540975616") };
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
public class A285018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285018Inst Instance=new A285018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285019
{
public static readonly long[] Value={ 1L,1L,1L,5L,35L,7L,77L,143L,715L,12155L,46189L,29393L,676039L,1300075L,185725L,1077205L,33393355L,21607465L,756261275L,1472719325L,3829070245L,22427411435L,87670790155L,19058867425L,895766768975L,1755702867191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285019Inst : IEnumerable<long>
{
public static readonly long[] Value=A285019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285019.Bytes);
public long this[int i]=>Value[i];

public static A285019Inst Instance=new A285019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285020
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,63L,231L,429L,1287L,2431L,46189L,88179L,676039L,52003L,200583L,1938969L,60108039L,116680311L,90751353L,176726319L,6892326441L,13456446861L,52602474093L,20583576819L,322476036831L,15801325804719L,61989816618513L,121683714103007L,191217265019011L,375840831244263L,7391536347803839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285020Inst : IEnumerable<long>
{
public static readonly long[] Value=A285020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285020.Bytes);
public long this[int i]=>Value[i];

public static A285020Inst Instance=new A285020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285021
{
public static readonly BigInteger[] Value={ 1L,10L,200L,400L,16000L,800000L,16000000L,160000000L,2560000000L,25600000000L,2560000000000L,25600000000000L,1024000000000000L,409600000000000L,8192000000000000L,409600000000000000L,BigInteger.Parse("65536000000000000000"),BigInteger.Parse("655360000000000000000"),BigInteger.Parse("2621440000000000000000"),BigInteger.Parse("26214400000000000000000"),BigInteger.Parse("5242880000000000000000000"),BigInteger.Parse("52428800000000000000000000") };
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
public class A285021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285021Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285021.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285021Inst Instance=new A285021Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285022
{
public static readonly long[] Value={ 820L,1276L,1926L,2080L,2640L,3160L,3186L,3250L,4446L,4720L,4930L,5370L,6006L,6546L,7386L,7450L,7476L,9066L,9276L,10626L,10836L,13146L,13300L,15640L,15666L,16056L,16060L,16446L,17020L,17466L,17550L,17766L,18040L,18910L,19176L,19230L,19416L,20736L,21000L,21246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285022Inst : IEnumerable<long>
{
public static readonly long[] Value=A285022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285022.Bytes);
public long this[int i]=>Value[i];

public static A285022Inst Instance=new A285022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285023
{
public static readonly BigInteger[] Value={ 0L,2L,97L,6460L,3708321L,5075612300L,40651048407879L,1063834786036208904L,BigInteger.Parse("129443742138071637706453") };
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
public class A285023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285023Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285023.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285023Inst Instance=new A285023Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285024
{
public static readonly long[] Value={ 0L,2L,6L,26L,104L,402L,1578L,6196L,24310L,95446L,374872L,1472938L,5790024L,22768624L,89562540L,352395768L,1386874908L,5459330780L,21494802570L,84648191106L,333419873528L,1313575442496L,5176174458602L,20401118165166L,80425006887898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285024Inst : IEnumerable<long>
{
public static readonly long[] Value=A285024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285024.Bytes);
public long this[int i]=>Value[i];

public static A285024Inst Instance=new A285024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285025
{
public static readonly long[] Value={ 1L,6L,97L,442L,4892L,26226L,256732L,1544872L,14082710L,91677088L,797188437L,5483647480L,46175013577L,330178554834L,2719685483708L,19987724476418L,162187667549290L,1215451639260848L,9763451129789048L,74199887341866168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285025Inst : IEnumerable<long>
{
public static readonly long[] Value=A285025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285025.Bytes);
public long this[int i]=>Value[i];

public static A285025Inst Instance=new A285025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285026
{
public static readonly ulong[] Value={ 2L,26L,442L,6460L,96458L,1449814L,22043878L,336883696L,5171750894L,79634735346L,1229304353554L,19015329654036L,294656614022300L,4573021347213134L,71071712948803680L,1105968089007186270L,17230453143587374712UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285026Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A285026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285026.Bytes);
public ulong this[int i]=>Value[i];

public static A285026Inst Instance=new A285026Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285092
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,11L,12L,14L,17L,19L,20L,21L,23L,26L,27L,29L,30L,31L,33L,36L,38L,39L,41L,44L,45L,47L,48L,50L,53L,55L,56L,57L,59L,62L,64L,65L,67L,70L,71L,73L,74L,75L,77L,80L,81L,83L,84L,86L,89L,91L,92L,93L,95L,98L,99L,101L,102L,103L,105L,108L,110L,111L,113L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285092Inst : IEnumerable<long>
{
public static readonly long[] Value=A285092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285092.Bytes);
public long this[int i]=>Value[i];

public static A285092Inst Instance=new A285092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285093
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,2L,3L,4L,5L,6L,2L,3L,4L,5L,6L,3L,4L,5L,6L,7L,3L,4L,5L,6L,7L,4L,5L,6L,7L,8L,4L,5L,6L,7L,8L,5L,6L,7L,8L,9L,1L,2L,3L,1L,2L,3L,1L,2L,3L,4L,2L,3L,4L,2L,3L,4L,2L,3L,4L,5L,3L,4L,5L,3L,4L,5L,3L,4L,5L,6L,4L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285093Inst : IEnumerable<long>
{
public static readonly long[] Value=A285093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285093.Bytes);
public long this[int i]=>Value[i];

public static A285093Inst Instance=new A285093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285094
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,0L,2L,4L,0L,3L,0L,2L,4L,6L,0L,5L,0L,6L,0L,7L,0L,4L,8L,0L,3L,6L,9L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,2L,0L,3L,0L,2L,0L,0L,0L,0L,2L,4L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,2L,4L,0L,0L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285094Inst : IEnumerable<long>
{
public static readonly long[] Value=A285094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285094.Bytes);
public long this[int i]=>Value[i];

public static A285094Inst Instance=new A285094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285095
{
public static readonly long[] Value={ 2L,3L,5L,7L,1L,2L,4L,5L,2L,5L,4L,7L,4L,5L,8L,8L,1L,2L,4L,4L,2L,1L,2L,4L,5L,4L,4L,4L,5L,2L,5L,2L,4L,4L,4L,5L,4L,5L,4L,4L,4L,5L,7L,1L,5L,2L,2L,4L,4L,5L,4L,4L,2L,4L,5L,4L,5L,5L,4L,5L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,5L,1L,2L,2L,4L,4L,5L,2L,2L,4L,4L,5L,4L,4L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285095Inst : IEnumerable<long>
{
public static readonly long[] Value=A285095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285095.Bytes);
public long this[int i]=>Value[i];

public static A285095Inst Instance=new A285095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285096
{
public static readonly long[] Value={ 2L,13L,31L,1061L,1151L,1223L,1511L,1601L,2141L,2213L,2411L,3023L,3041L,3203L,3221L,4013L,4211L,5003L,5021L,6011L,6101L,7001L,10009L,10243L,10333L,10513L,10531L,10711L,11071L,11161L,11251L,11503L,11701L,12007L,12043L,12241L,12421L,12511L,12601L,13033L,13411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285096Inst : IEnumerable<long>
{
public static readonly long[] Value=A285096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285096.Bytes);
public long this[int i]=>Value[i];

public static A285096Inst Instance=new A285096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285097
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,1L,1L,0L,3L,2L,1L,1L,2L,1L,1L,0L,4L,3L,1L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,5L,4L,1L,3L,2L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,1L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,0L,6L,5L,1L,4L,2L,1L,1L,3L,3L,2L,1L,1L,2L,1L,1L,2L,4L,3L,1L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,1L,1L,1L,5L,4L,1L,3L,2L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,1L,4L,3L,1L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285097Inst : IEnumerable<long>
{
public static readonly long[] Value=A285097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285097.Bytes);
public long this[int i]=>Value[i];

public static A285097Inst Instance=new A285097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285098
{
public static readonly long[] Value={ 1L,3L,23L,7L,20L,29L,124L,15L,147L,30L,117L,41L,63L,138L,296L,31L,106L,165L,231L,50L,84L,139L,281L,65L,294L,89L,40616L,166L,212L,326L,40486L,63L,377L,140L,258L,201L,259L,269L,986L,90L,40589L,126L,588L,183L,253L,327L,40455L,113L,382L,344L,514L,141L,223L,40670L,41000L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285098Inst : IEnumerable<long>
{
public static readonly long[] Value=A285098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285098.Bytes);
public long this[int i]=>Value[i];

public static A285098Inst Instance=new A285098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285099
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,2L,2L,1L,0L,3L,3L,1L,3L,2L,2L,1L,0L,4L,4L,1L,4L,2L,2L,1L,4L,3L,3L,1L,3L,2L,2L,1L,0L,5L,5L,1L,5L,2L,2L,1L,5L,3L,3L,1L,3L,2L,2L,1L,5L,4L,4L,1L,4L,2L,2L,1L,4L,3L,3L,1L,3L,2L,2L,1L,0L,6L,6L,1L,6L,2L,2L,1L,6L,3L,3L,1L,3L,2L,2L,1L,6L,4L,4L,1L,4L,2L,2L,1L,4L,3L,3L,1L,3L,2L,2L,1L,6L,5L,5L,1L,5L,2L,2L,1L,5L,3L,3L,1L,3L,2L,2L,1L,5L,4L,4L,1L,4L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285099Inst : IEnumerable<long>
{
public static readonly long[] Value=A285099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285099.Bytes);
public long this[int i]=>Value[i];

public static A285099Inst Instance=new A285099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285100
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,41L,42L,43L,44L,46L,47L,49L,51L,52L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,97L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285100Inst : IEnumerable<long>
{
public static readonly long[] Value=A285100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285100.Bytes);
public long this[int i]=>Value[i];

public static A285100Inst Instance=new A285100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285101
{
public static readonly BigInteger[] Value={ 2L,6L,210L,3573570L,64845819350301990L,BigInteger.Parse("28695662573739152697846686144187168109530"),BigInteger.Parse("1038300112150956151877699324649731518883355380534272386781875587619359740733888844803014212990") };
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
public class A285101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285101.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285101Inst Instance=new A285101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285102
{
public static readonly BigInteger[] Value={ 2L,6L,210L,72930L,620310L,278995269860970L,12849025509071310L,BigInteger.Parse("492608110538467706074890"),BigInteger.Parse("1342951001046021018427857601026746070"),BigInteger.Parse("37793589449865555275592120894959094883390892772270"),BigInteger.Parse("728982633030274864467458719371654181886452163442582606072870"),BigInteger.Parse("28339554655955912942523491885490197708224606885407444005070") };
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
public class A285102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285102.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285102Inst Instance=new A285102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285103
{
public static readonly long[] Value={ 1L,2L,4L,6L,6L,12L,12L,16L,22L,28L,32L,30L,36L,52L,48L,62L,62L,68L,88L,104L,116L,108L,128L,128L,132L,168L,160L,168L,200L,204L,240L,232L,242L,284L,300L,324L,332L,348L,352L,352L,412L,440L,400L,466L,460L,516L,496L,566L,582L,580L,608L,646L,676L,736L,716L,782L,728L,816L,832L,856L,916L,924L,948L,1034L,1008L,1044L,1096L,1154L,1112L,1212L,1204L,1188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285103Inst : IEnumerable<long>
{
public static readonly long[] Value=A285103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285103.Bytes);
public long this[int i]=>Value[i];

public static A285103Inst Instance=new A285103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285104
{
public static readonly long[] Value={ 0L,0L,0L,2L,10L,20L,52L,112L,234L,484L,992L,2018L,4060L,8140L,16336L,32706L,65474L,131004L,262056L,524184L,1048460L,2097044L,4194176L,8388480L,16777084L,33554264L,67108704L,134217560L,268435256L,536870708L,1073741584L,2147483416L,4294967054L,8589934308L,17179868884L,34359738044L,68719476404L,137438953124L,274877906592L,549755813536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285104Inst : IEnumerable<long>
{
public static readonly long[] Value=A285104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285104.Bytes);
public long this[int i]=>Value[i];

public static A285104Inst Instance=new A285104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285105
{
public static readonly long[] Value={ 0L,0L,0L,1L,5L,4L,10L,13L,15L,18L,24L,37L,43L,40L,58L,59L,75L,86L,84L,87L,95L,124L,126L,149L,169L,158L,192L,211L,207L,232L,226L,265L,287L,278L,296L,307L,335L,356L,390L,429L,409L,422L,504L,481L,531L,520L,586L,563L,595L,646L,668L,681L,703L,696L,770L,759L,869L,838L,880L,915L,915L,968L,1006L,983L,1073L,1102L,1116L,1125L,1235L,1204L,1282L,1369L,1349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285105Inst : IEnumerable<long>
{
public static readonly long[] Value=A285105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285105.Bytes);
public long this[int i]=>Value[i];

public static A285105Inst Instance=new A285105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285106
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,3L,4L,5L,7L,7L,6L,7L,8L,4L,5L,6L,8L,8L,9L,10L,10L,8L,8L,8L,10L,10L,9L,10L,11L,5L,6L,7L,9L,11L,10L,14L,16L,14L,13L,14L,13L,15L,17L,14L,16L,10L,10L,10L,11L,15L,14L,15L,17L,15L,13L,11L,13L,13L,12L,13L,14L,6L,7L,8L,10L,14L,13L,15L,19L,21L,17L,18L,20L,24L,25L,22L,20L,20L,16L,17L,19L,25L,23L,25L,30L,20L,22L,20L,20L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285106Inst : IEnumerable<long>
{
public static readonly long[] Value=A285106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285106.Bytes);
public long this[int i]=>Value[i];

public static A285106Inst Instance=new A285106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285107
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,5L,1L,4L,5L,7L,6L,5L,7L,8L,1L,5L,6L,7L,5L,8L,9L,7L,4L,7L,7L,8L,7L,7L,10L,11L,1L,6L,7L,7L,8L,7L,13L,14L,11L,13L,14L,7L,9L,16L,11L,13L,4L,9L,9L,6L,11L,11L,12L,13L,11L,12L,9L,9L,8L,9L,13L,14L,1L,7L,8L,7L,11L,10L,11L,15L,20L,17L,17L,14L,19L,25L,20L,13L,17L,16L,17L,13L,20L,19L,21L,26L,9L,21L,18L,11L,21L,26L,17L,19L,4L,11L,11L,6L,17L,17L,18L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285107Inst : IEnumerable<long>
{
public static readonly long[] Value=A285107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285107.Bytes);
public long this[int i]=>Value[i];

public static A285107Inst Instance=new A285107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285172
{
public static readonly BigInteger[] Value={ 1L,126L,7008L,261648L,7826544L,205083936L,4944057984L,112834665216L,2481031718144L,53154302311936L,1117907385569280L,23198258406862848L,476700713349279744L,9725111087129763840UL,BigInteger.Parse("197341040692081557504"),BigInteger.Parse("3988586127032474271744"),BigInteger.Parse("80380982576880196780032"),BigInteger.Parse("1616460856969040046850048"),BigInteger.Parse("32457783381454315268866048") };
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
public class A285172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285172Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285172.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285172.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285172Inst Instance=new A285172Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285173
{
public static readonly long[] Value={ 3L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285173Inst : IEnumerable<long>
{
public static readonly long[] Value=A285173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285173.Bytes);
public long this[int i]=>Value[i];

public static A285173Inst Instance=new A285173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285174
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,7L,0L,7L,4L,38L,0L,52L,44L,192L,34L,445L,328L,1061L,658L,3431L,2266L,7293L,7632L,24322L,17946L,58812L,70006L,171467L,166364L,488958L,581520L,1290879L,1599416L,3972675L,4807640L,10523661L,14798098L,31868794L,41478042L,89608805L,131175180L,259840862L,371465030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285174Inst : IEnumerable<long>
{
public static readonly long[] Value=A285174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285174.Bytes);
public long this[int i]=>Value[i];

public static A285174Inst Instance=new A285174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285175
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,9L,16L,14L,20L,7L,15L,8L,12L,18L,31L,26L,27L,40L,30L,49L,38L,19L,10L,23L,53L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285175Inst : IEnumerable<long>
{
public static readonly long[] Value=A285175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285175.Bytes);
public long this[int i]=>Value[i];

public static A285175Inst Instance=new A285175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285176
{
public static readonly long[] Value={ 10L,15L,18L,20L,30L,40L,45L,50L,60L,70L,80L,90L,100L,200L,300L,400L,500L,600L,700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285176Inst : IEnumerable<long>
{
public static readonly long[] Value=A285176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285176.Bytes);
public long this[int i]=>Value[i];

public static A285176Inst Instance=new A285176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285177
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285177Inst : IEnumerable<long>
{
public static readonly long[] Value=A285177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285177.Bytes);
public long this[int i]=>Value[i];

public static A285177Inst Instance=new A285177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285178
{
public static readonly BigInteger[] Value={ 0L,7L,17972L,41685061617L,BigInteger.Parse("232152032603580176504"),BigInteger.Parse("7236273578711450275537707547657855") };
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
public class A285178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285178.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285178Inst Instance=new A285178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285179
{
public static readonly BigInteger[] Value={ 0L,56L,419250816L,BigInteger.Parse("2294248126968596791296"),BigInteger.Parse("71871209790288983974921874964480000000000"),BigInteger.Parse("70222282105561329499166350697268240329817049897201827840000000000000") };
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
public class A285179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285179Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A285179.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A285179.Bytes);
public BigInteger this[int i]=>Value[i];

public static A285179Inst Instance=new A285179Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285180
{
public static readonly long[] Value={ 1L,1L,12L,18383222420692992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285180Inst : IEnumerable<long>
{
public static readonly long[] Value=A285180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285180.Bytes);
public long this[int i]=>Value[i];

public static A285180Inst Instance=new A285180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285181
{
public static readonly long[] Value={ 1L,3L,10L,13L,35L,33L,48L,65L,94L,100L,86L,142L,144L,157L,148L,258L,399L,300L,453L,395L,319L,483L,358L,565L,720L,665L,845L,755L,893L,864L,924L,1009L,1033L,1133L,1216L,1262L,1293L,1437L,1375L,1603L,1724L,1720L,2015L,1898L,2154L,2078L,2071L,2257L,2547L,2422L,2687L,2618L,2714L,2807L,3055L,3034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285181Inst : IEnumerable<long>
{
public static readonly long[] Value=A285181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285181.Bytes);
public long this[int i]=>Value[i];

public static A285181Inst Instance=new A285181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285182
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,4L,0L,2L,0L,6L,5L,0L,0L,2L,0L,4L,6L,10L,0L,2L,0L,12L,0L,6L,0L,2L,0L,0L,11L,16L,14L,2L,0L,18L,12L,4L,0L,6L,0L,10L,5L,22L,0L,2L,0L,4L,17L,12L,0L,2L,10L,6L,18L,28L,0L,2L,0L,30L,6L,0L,25L,8L,0L,16L,23L,4L,0L,2L,0L,36L,5L,18L,21L,12L,0L,4L,0L,40L,0L,6L,34L,42L,29L,10L,0L,2L,13L,22L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285182Inst : IEnumerable<long>
{
public static readonly long[] Value=A285182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285182.Bytes);
public long this[int i]=>Value[i];

public static A285182Inst Instance=new A285182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285183
{
public static readonly long[] Value={ 0L,2L,2L,2L,1L,6L,1L,2L,2L,5L,1L,6L,1L,5L,4L,2L,1L,6L,1L,5L,4L,4L,1L,6L,1L,4L,2L,5L,1L,11L,1L,2L,3L,4L,3L,6L,1L,4L,3L,5L,1L,11L,1L,4L,4L,4L,1L,6L,1L,5L,3L,4L,1L,6L,3L,5L,3L,4L,1L,11L,1L,4L,4L,2L,3L,10L,1L,4L,3L,9L,1L,6L,1L,4L,4L,4L,3L,10L,1L,5L,2L,4L,1L,11L,3L,4L,3L,4L,1L,11L,3L,4L,3L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285183Inst : IEnumerable<long>
{
public static readonly long[] Value=A285183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285183.Bytes);
public long this[int i]=>Value[i];

public static A285183Inst Instance=new A285183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285184
{
public static readonly long[] Value={ 1L,3L,5L,11L,25L,55L,121L,267L,589L,1299L,2865L,6319L,13937L,30739L,67797L,149531L,329801L,727399L,1604329L,3538459L,7804317L,17212963L,37964385L,83733087L,184679137L,407322659L,898378405L,1981435947L,4370194553L,9638767511L,21258970969L,46888136491L,103415040493L,228089051955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285184Inst : IEnumerable<long>
{
public static readonly long[] Value=A285184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285184.Bytes);
public long this[int i]=>Value[i];

public static A285184Inst Instance=new A285184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A285185
{
public static readonly long[] Value={ 0L,2L,8L,20L,52L,128L,320L,792L,1968L,4880L,12112L,30048L,74560L,184992L,459008L,1138880L,2825792L,7011328L,17396480L,43164032L,107098368L,265731840L,659332352L,1635931648L,4059064320L,10071327232L,24988919808L,62002365440L,153839916032L,381706723328L,947088547840L,2349910710272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A285185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A285185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A285185Inst : IEnumerable<long>
{
public static readonly long[] Value=A285185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A285185.Bytes);
public long this[int i]=>Value[i];

public static A285185Inst Instance=new A285185Inst();

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