using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198857
{
public static readonly long[] Value={ 9L,79L,639L,5119L,40959L,327679L,2621439L,20971519L,167772159L,1342177279L,10737418239L,85899345919L,687194767359L,5497558138879L,43980465111039L,351843720888319L,2814749767106559L,22517998136852479L,180143985094819839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198857Inst : IEnumerable<long>
{
public static readonly long[] Value=A198857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198857.Bytes);
public long this[int i]=>Value[i];

public static A198857Inst Instance=new A198857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198858
{
public static readonly long[] Value={ 10L,87L,703L,5631L,45055L,360447L,2883583L,23068671L,184549375L,1476395007L,11811160063L,94489280511L,755914244095L,6047313952767L,48378511622143L,387028092977151L,3096224743817215L,24769797950537727L,198158383604301823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198858Inst : IEnumerable<long>
{
public static readonly long[] Value=A198858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198858.Bytes);
public long this[int i]=>Value[i];

public static A198858Inst Instance=new A198858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198859
{
public static readonly long[] Value={ 1L,17L,161L,1457L,13121L,118097L,1062881L,9565937L,86093441L,774840977L,6973568801L,62762119217L,564859072961L,5083731656657L,45753584909921L,411782264189297L,3706040377703681L,33354363399333137L,300189270593998241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198859Inst : IEnumerable<long>
{
public static readonly long[] Value=A198859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198859.Bytes);
public long this[int i]=>Value[i];

public static A198859Inst Instance=new A198859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198860
{
public static readonly BigInteger[] Value={ 1L,1L,3L,17L,144L,1634L,23312L,401274L,8096680L,187472136L,4900535832L,142766286552L,4587190461840L,161161214978880L,6146415080939520L,252902928346825104L,11167368115492742400UL,BigInteger.Parse("526752556713346955520"),BigInteger.Parse("26433830208985721222400"),BigInteger.Parse("1406218428780691953635712") };
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
public class A198860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198860Inst Instance=new A198860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198861
{
public static readonly long[] Value={ 2L,30L,1680L,7983360L,40548366802944000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198861Inst : IEnumerable<long>
{
public static readonly long[] Value=A198861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198861.Bytes);
public long this[int i]=>Value[i];

public static A198861Inst Instance=new A198861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198862
{
public static readonly long[] Value={ -1L,2L,2L,2L,3L,1L,-1L,-3L,-6L,-7L,-6L,-3L,3L,10L,16L,19L,16L,6L,-10L,-29L,-45L,-51L,-41L,-12L,33L,84L,125L,137L,104L,20L,-105L,-242L,-346L,-366L,-261L,-19L,327L,693L,954L,973L,646L,-47L,-1001L,-1974L,-2620L,-2573L,-1572L,402L,3022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198862Inst : IEnumerable<long>
{
public static readonly long[] Value=A198862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198862.Bytes);
public long this[int i]=>Value[i];

public static A198862Inst Instance=new A198862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198863
{
public static readonly long[] Value={ 3164252736L,3164326683L,3164389113L,3164391957L,3164406057L,3164416923L,3164421333L,3164454864L,3164466768L,3164482974L,3164528124L,3164547114L,3164689392L,3164695206L,3164735277L,3164770866L,3164789766L,3164863185L,3164867118L,3164907357L,3165009693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198863Inst : IEnumerable<long>
{
public static readonly long[] Value=A198863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198863.Bytes);
public long this[int i]=>Value[i];

public static A198863Inst Instance=new A198863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198864
{
public static readonly BigInteger[] Value={ 1L,2L,4L,11L,92L,8101L,65585702L,4301483913318599L,BigInteger.Parse("18502763856538658405109886092616"),BigInteger.Parse("342352270330833327273885765082712290623512199361069533040982537") };
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
public class A198864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198864Inst Instance=new A198864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198865
{
public static readonly BigInteger[] Value={ 1L,1L,4L,31L,368L,5941L,121632L,3019563L,88140544L,2958267241L,112246484480L,4751313955543L,221980968007680L,11346405913579101L,629859586327810048L,BigInteger.Parse("37736053514310470371"),BigInteger.Parse("2426956220333852131328"),BigInteger.Parse("166775317658298155269585"),BigInteger.Parse("12195158366650225121427456") };
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
public class A198865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198865Inst Instance=new A198865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198866
{
public static readonly long[] Value={ 1L,4L,0L,9L,6L,2L,4L,0L,0L,4L,0L,0L,2L,5L,9L,6L,2L,4L,9L,2L,3L,5L,5L,9L,3L,9L,7L,0L,5L,8L,9L,4L,9L,3L,5L,4L,7L,1L,2L,3L,5L,4L,8L,3L,5L,1L,0L,7L,8L,9L,0L,1L,5L,1L,5L,1L,0L,1L,6L,6L,8L,3L,0L,0L,9L,9L,1L,8L,3L,6L,0L,1L,6L,7L,3L,1L,8L,1L,4L,5L,2L,5L,1L,6L,8L,7L,4L,8L,9L,2L,1L,4L,3L,2L,5L,9L,0L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198866Inst : IEnumerable<long>
{
public static readonly long[] Value=A198866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198866.Bytes);
public long this[int i]=>Value[i];

public static A198866Inst Instance=new A198866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198867
{
public static readonly long[] Value={ 6L,3L,6L,7L,3L,2L,6L,5L,0L,8L,0L,5L,2L,8L,2L,0L,1L,0L,8L,8L,7L,9L,9L,0L,9L,0L,3L,8L,3L,8L,2L,8L,0L,0L,5L,8L,9L,9L,7L,8L,0L,5L,0L,7L,8L,8L,4L,1L,7L,9L,1L,6L,7L,3L,3L,8L,2L,8L,1L,8L,2L,6L,3L,1L,9L,5L,8L,0L,4L,4L,0L,2L,9L,0L,1L,2L,0L,2L,5L,9L,2L,6L,5L,1L,4L,5L,9L,4L,7L,3L,1L,1L,8L,0L,7L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198867Inst : IEnumerable<long>
{
public static readonly long[] Value=A198867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198867.Bytes);
public long this[int i]=>Value[i];

public static A198867Inst Instance=new A198867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198868
{
public static readonly long[] Value={ 6L,3L,0L,3L,9L,8L,6L,6L,3L,9L,9L,3L,5L,9L,9L,3L,8L,6L,4L,4L,0L,7L,0L,4L,8L,6L,1L,7L,7L,7L,0L,4L,4L,9L,9L,2L,6L,7L,8L,5L,0L,2L,5L,1L,7L,0L,1L,8L,1L,0L,1L,7L,6L,8L,6L,5L,4L,9L,2L,6L,9L,1L,3L,0L,8L,5L,9L,5L,7L,8L,9L,5L,0L,6L,9L,5L,6L,0L,2L,9L,7L,5L,2L,9L,0L,5L,7L,4L,3L,9L,9L,3L,8L,4L,7L,4L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198868Inst : IEnumerable<long>
{
public static readonly long[] Value=A198868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198868.Bytes);
public long this[int i]=>Value[i];

public static A198868Inst Instance=new A198868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198869
{
public static readonly long[] Value={ 9L,6L,4L,4L,2L,0L,4L,4L,6L,8L,5L,1L,1L,0L,3L,3L,9L,9L,2L,6L,0L,3L,5L,6L,9L,0L,9L,1L,2L,4L,7L,2L,7L,2L,0L,6L,5L,1L,4L,3L,3L,9L,5L,4L,3L,6L,0L,4L,6L,8L,2L,7L,4L,8L,9L,4L,8L,5L,5L,2L,7L,3L,1L,6L,7L,3L,1L,8L,0L,2L,3L,9L,9L,9L,0L,9L,4L,8L,1L,8L,4L,2L,2L,4L,7L,0L,3L,6L,2L,1L,2L,7L,2L,7L,3L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198869Inst : IEnumerable<long>
{
public static readonly long[] Value=A198869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198869.Bytes);
public long this[int i]=>Value[i];

public static A198869Inst Instance=new A198869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198870
{
public static readonly long[] Value={ 1L,2L,1L,6L,2L,3L,8L,8L,0L,9L,4L,6L,6L,3L,9L,3L,2L,9L,0L,5L,9L,9L,6L,2L,5L,7L,6L,7L,0L,2L,9L,3L,4L,3L,2L,9L,1L,1L,5L,4L,4L,7L,0L,4L,5L,7L,2L,0L,2L,5L,3L,0L,0L,3L,1L,9L,4L,0L,7L,1L,1L,9L,0L,7L,8L,9L,7L,3L,6L,1L,8L,0L,1L,4L,4L,6L,3L,8L,5L,6L,4L,9L,9L,0L,4L,4L,3L,4L,8L,4L,7L,0L,9L,9L,3L,6L,7L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198870Inst : IEnumerable<long>
{
public static readonly long[] Value=A198870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198870.Bytes);
public long this[int i]=>Value[i];

public static A198870Inst Instance=new A198870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198871
{
public static readonly long[] Value={ 9L,0L,0L,3L,6L,7L,2L,2L,2L,5L,8L,9L,7L,4L,7L,1L,4L,6L,0L,7L,3L,0L,7L,7L,3L,9L,3L,5L,2L,5L,3L,6L,3L,6L,5L,4L,6L,4L,0L,2L,7L,3L,0L,0L,3L,4L,4L,6L,1L,1L,0L,8L,6L,8L,0L,3L,0L,1L,1L,6L,9L,8L,2L,7L,2L,7L,2L,8L,3L,1L,3L,3L,9L,7L,0L,4L,4L,6L,7L,5L,9L,0L,9L,4L,5L,4L,8L,2L,4L,4L,3L,7L,6L,0L,3L,6L,0L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198871Inst : IEnumerable<long>
{
public static readonly long[] Value=A198871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198871.Bytes);
public long this[int i]=>Value[i];

public static A198871Inst Instance=new A198871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198872
{
public static readonly long[] Value={ 1L,1L,0L,6L,3L,3L,2L,5L,5L,5L,0L,2L,9L,9L,3L,5L,9L,1L,5L,2L,5L,4L,7L,5L,6L,0L,9L,5L,7L,2L,9L,5L,1L,6L,7L,5L,2L,6L,3L,5L,2L,8L,9L,3L,9L,5L,4L,3L,9L,2L,0L,9L,3L,7L,7L,3L,2L,6L,2L,8L,5L,3L,7L,8L,7L,8L,6L,7L,5L,0L,5L,3L,0L,5L,6L,8L,9L,7L,0L,9L,1L,5L,8L,1L,2L,2L,9L,1L,0L,0L,6L,7L,1L,1L,0L,5L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198872Inst : IEnumerable<long>
{
public static readonly long[] Value=A198872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198872.Bytes);
public long this[int i]=>Value[i];

public static A198872Inst Instance=new A198872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198873
{
public static readonly long[] Value={ 1L,2L,8L,1L,6L,3L,0L,3L,8L,6L,1L,5L,9L,9L,6L,2L,1L,1L,0L,4L,2L,9L,9L,0L,6L,6L,7L,9L,6L,2L,0L,0L,1L,9L,4L,3L,1L,6L,4L,9L,7L,2L,1L,0L,9L,0L,8L,3L,6L,3L,6L,6L,0L,0L,0L,3L,9L,9L,8L,1L,0L,6L,3L,6L,5L,4L,9L,7L,4L,9L,4L,3L,3L,8L,4L,3L,5L,8L,0L,8L,9L,7L,3L,4L,1L,6L,0L,3L,4L,0L,7L,8L,4L,1L,3L,1L,4L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198873Inst : IEnumerable<long>
{
public static readonly long[] Value=A198873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198873.Bytes);
public long this[int i]=>Value[i];

public static A198873Inst Instance=new A198873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198874
{
public static readonly long[] Value={ 1L,4L,3L,7L,5L,1L,3L,2L,6L,8L,4L,1L,3L,4L,2L,0L,3L,0L,4L,2L,5L,7L,2L,3L,4L,1L,4L,7L,0L,9L,5L,9L,2L,7L,5L,3L,7L,4L,2L,3L,8L,8L,0L,9L,3L,2L,4L,6L,4L,4L,9L,0L,6L,5L,7L,3L,7L,1L,7L,5L,5L,3L,6L,6L,9L,4L,6L,9L,7L,9L,6L,0L,1L,3L,0L,3L,4L,3L,0L,3L,7L,8L,9L,2L,6L,1L,8L,6L,7L,1L,3L,9L,6L,0L,8L,4L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198874Inst : IEnumerable<long>
{
public static readonly long[] Value=A198874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198874.Bytes);
public long this[int i]=>Value[i];

public static A198874Inst Instance=new A198874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198875
{
public static readonly long[] Value={ 5L,8L,0L,0L,3L,6L,6L,7L,8L,6L,4L,7L,0L,9L,7L,6L,9L,4L,5L,4L,8L,3L,6L,7L,9L,1L,6L,1L,9L,0L,6L,3L,7L,2L,4L,8L,2L,4L,2L,2L,3L,7L,7L,1L,9L,1L,5L,0L,0L,4L,5L,3L,3L,4L,5L,9L,2L,0L,4L,8L,4L,6L,2L,5L,5L,0L,1L,0L,1L,5L,5L,1L,5L,8L,5L,1L,4L,3L,4L,7L,6L,9L,6L,1L,2L,0L,5L,8L,8L,8L,1L,0L,9L,9L,6L,7L,7L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198875Inst : IEnumerable<long>
{
public static readonly long[] Value=A198875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198875.Bytes);
public long this[int i]=>Value[i];

public static A198875Inst Instance=new A198875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198876
{
public static readonly long[] Value={ 1L,3L,2L,1L,5L,9L,9L,6L,2L,0L,8L,7L,6L,7L,1L,8L,2L,2L,2L,1L,3L,7L,7L,3L,3L,4L,9L,2L,8L,1L,7L,5L,0L,4L,2L,4L,4L,9L,9L,2L,5L,6L,1L,5L,3L,4L,7L,3L,1L,2L,1L,4L,4L,0L,6L,8L,0L,4L,7L,9L,1L,0L,5L,5L,2L,3L,4L,6L,0L,7L,0L,3L,9L,7L,2L,0L,7L,7L,9L,1L,8L,2L,0L,7L,8L,2L,1L,2L,0L,8L,0L,8L,3L,0L,6L,4L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198876Inst : IEnumerable<long>
{
public static readonly long[] Value=A198876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198876.Bytes);
public long this[int i]=>Value[i];

public static A198876Inst Instance=new A198876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198877
{
public static readonly long[] Value={ 5L,3L,7L,2L,7L,2L,4L,7L,4L,7L,7L,2L,1L,2L,4L,6L,4L,5L,3L,7L,2L,0L,5L,1L,5L,0L,8L,5L,1L,2L,5L,3L,0L,2L,4L,2L,2L,8L,6L,3L,8L,0L,6L,0L,7L,0L,4L,1L,1L,1L,8L,7L,6L,1L,9L,3L,8L,4L,3L,2L,3L,8L,9L,5L,0L,6L,3L,1L,3L,5L,7L,8L,7L,0L,9L,3L,5L,8L,7L,1L,8L,9L,2L,4L,4L,3L,7L,8L,5L,2L,0L,1L,1L,0L,8L,0L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198877Inst : IEnumerable<long>
{
public static readonly long[] Value=A198877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198877.Bytes);
public long this[int i]=>Value[i];

public static A198877Inst Instance=new A198877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198878
{
public static readonly long[] Value={ 7L,6L,3L,7L,7L,2L,2L,7L,4L,9L,0L,1L,1L,1L,9L,0L,5L,0L,1L,1L,0L,5L,5L,9L,8L,8L,5L,9L,2L,8L,2L,8L,3L,1L,4L,5L,4L,9L,7L,3L,6L,5L,0L,3L,4L,6L,2L,0L,7L,4L,5L,4L,9L,8L,2L,2L,6L,2L,1L,7L,2L,5L,0L,8L,5L,8L,9L,6L,3L,1L,5L,6L,5L,0L,0L,5L,3L,6L,7L,6L,2L,7L,2L,0L,9L,5L,6L,3L,6L,4L,0L,1L,5L,0L,4L,5L,1L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198878Inst : IEnumerable<long>
{
public static readonly long[] Value=A198878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198878.Bytes);
public long this[int i]=>Value[i];

public static A198878Inst Instance=new A198878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198879
{
public static readonly long[] Value={ 1L,0L,9L,1L,6L,0L,2L,4L,7L,5L,2L,5L,0L,6L,5L,0L,8L,3L,1L,6L,8L,6L,9L,6L,9L,3L,0L,1L,5L,1L,2L,9L,5L,3L,4L,9L,6L,9L,6L,0L,2L,7L,0L,5L,7L,7L,3L,2L,6L,4L,9L,1L,2L,0L,0L,3L,3L,1L,3L,1L,8L,5L,0L,5L,5L,8L,6L,3L,4L,1L,8L,3L,3L,6L,8L,3L,5L,5L,0L,7L,9L,0L,7L,4L,8L,2L,5L,7L,7L,0L,5L,1L,9L,2L,6L,5L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198879Inst : IEnumerable<long>
{
public static readonly long[] Value=A198879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198879.Bytes);
public long this[int i]=>Value[i];

public static A198879Inst Instance=new A198879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198880
{
public static readonly long[] Value={ 1L,2L,2L,7L,0L,1L,7L,2L,0L,7L,3L,5L,2L,9L,2L,2L,0L,8L,9L,7L,2L,2L,1L,9L,9L,7L,0L,8L,1L,9L,5L,4L,2L,6L,9L,3L,5L,0L,5L,9L,4L,3L,6L,1L,8L,6L,6L,4L,7L,8L,5L,9L,0L,8L,7L,7L,5L,9L,0L,6L,7L,3L,2L,8L,0L,3L,4L,6L,9L,4L,7L,4L,0L,9L,0L,7L,4L,1L,8L,7L,9L,6L,7L,6L,4L,3L,2L,1L,5L,2L,1L,1L,7L,2L,0L,6L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198880Inst : IEnumerable<long>
{
public static readonly long[] Value=A198880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198880.Bytes);
public long this[int i]=>Value[i];

public static A198880Inst Instance=new A198880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198881
{
public static readonly long[] Value={ 1L,3L,5L,1L,4L,4L,2L,8L,9L,2L,9L,4L,2L,0L,7L,9L,0L,4L,9L,6L,9L,5L,5L,5L,4L,7L,8L,0L,3L,6L,6L,3L,0L,4L,9L,3L,9L,3L,8L,3L,1L,2L,2L,1L,3L,0L,4L,4L,0L,7L,7L,3L,5L,6L,5L,6L,4L,7L,3L,3L,3L,3L,7L,1L,0L,7L,8L,7L,7L,5L,6L,4L,7L,4L,0L,7L,7L,8L,2L,4L,5L,5L,0L,3L,2L,0L,2L,8L,1L,0L,3L,2L,3L,8L,7L,9L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198881Inst : IEnumerable<long>
{
public static readonly long[] Value=A198881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198881.Bytes);
public long this[int i]=>Value[i];

public static A198881Inst Instance=new A198881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198882
{
public static readonly long[] Value={ 1L,4L,6L,7L,7L,5L,1L,3L,6L,0L,2L,0L,4L,1L,4L,6L,5L,4L,1L,5L,6L,0L,5L,8L,4L,6L,1L,8L,8L,5L,6L,9L,2L,6L,3L,1L,6L,3L,3L,7L,3L,6L,3L,4L,3L,8L,9L,5L,1L,4L,7L,9L,7L,0L,8L,5L,3L,6L,6L,8L,1L,1L,7L,8L,4L,1L,7L,9L,7L,5L,6L,1L,9L,4L,5L,8L,8L,1L,3L,0L,3L,3L,1L,0L,6L,6L,0L,7L,3L,8L,6L,8L,5L,8L,2L,9L,6L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198882Inst : IEnumerable<long>
{
public static readonly long[] Value=A198882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198882.Bytes);
public long this[int i]=>Value[i];

public static A198882Inst Instance=new A198882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198883
{
public static readonly long[] Value={ 5L,0L,2L,6L,3L,0L,1L,8L,3L,5L,2L,3L,6L,8L,1L,8L,9L,7L,0L,4L,3L,8L,6L,9L,2L,1L,6L,0L,0L,9L,3L,5L,3L,8L,7L,5L,3L,1L,7L,9L,7L,6L,9L,8L,2L,3L,1L,6L,6L,8L,7L,8L,2L,3L,5L,4L,5L,9L,9L,1L,4L,4L,5L,8L,7L,2L,1L,4L,4L,5L,8L,9L,3L,0L,4L,1L,4L,0L,4L,8L,8L,4L,9L,3L,2L,8L,5L,4L,0L,0L,6L,8L,5L,9L,1L,2L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198883Inst : IEnumerable<long>
{
public static readonly long[] Value=A198883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198883.Bytes);
public long this[int i]=>Value[i];

public static A198883Inst Instance=new A198883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198884
{
public static readonly long[] Value={ 8L,7L,9L,9L,7L,0L,4L,0L,3L,2L,4L,2L,3L,9L,4L,2L,3L,8L,7L,9L,6L,3L,1L,5L,3L,4L,4L,0L,5L,3L,6L,4L,4L,3L,8L,3L,9L,3L,8L,7L,1L,8L,2L,8L,8L,5L,4L,4L,9L,7L,2L,8L,4L,9L,9L,3L,3L,2L,2L,4L,9L,1L,0L,0L,1L,9L,1L,6L,5L,6L,1L,6L,6L,9L,7L,8L,9L,9L,2L,1L,2L,1L,5L,9L,3L,5L,4L,2L,3L,9L,7L,7L,6L,9L,9L,5L,7L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198884Inst : IEnumerable<long>
{
public static readonly long[] Value=A198884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198884.Bytes);
public long this[int i]=>Value[i];

public static A198884Inst Instance=new A198884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198885
{
public static readonly long[] Value={ 1L,1L,4L,8L,6L,6L,0L,1L,3L,5L,6L,9L,8L,6L,6L,5L,9L,8L,7L,7L,2L,6L,9L,4L,2L,4L,6L,8L,0L,3L,2L,4L,4L,1L,7L,6L,7L,5L,1L,4L,3L,2L,2L,2L,4L,5L,7L,6L,3L,6L,4L,9L,4L,0L,2L,9L,5L,2L,7L,5L,3L,8L,8L,3L,3L,4L,1L,2L,7L,0L,4L,7L,7L,4L,6L,6L,8L,7L,3L,1L,1L,6L,8L,7L,6L,3L,4L,2L,6L,6L,1L,8L,1L,7L,5L,1L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198885Inst : IEnumerable<long>
{
public static readonly long[] Value=A198885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198885.Bytes);
public long this[int i]=>Value[i];

public static A198885Inst Instance=new A198885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198886
{
public static readonly long[] Value={ 1L,3L,7L,4L,6L,7L,5L,3L,4L,3L,9L,3L,4L,6L,8L,1L,8L,9L,9L,6L,3L,0L,1L,5L,6L,6L,5L,7L,3L,2L,3L,7L,5L,8L,5L,8L,9L,1L,5L,5L,0L,5L,4L,3L,6L,6L,9L,3L,5L,9L,5L,8L,9L,7L,6L,7L,6L,9L,1L,5L,6L,7L,5L,5L,3L,0L,0L,8L,7L,2L,4L,4L,1L,6L,2L,5L,1L,9L,5L,0L,2L,1L,1L,8L,2L,2L,1L,4L,1L,0L,3L,3L,4L,2L,1L,6L,8L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198886Inst : IEnumerable<long>
{
public static readonly long[] Value=A198886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198886.Bytes);
public long this[int i]=>Value[i];

public static A198886Inst Instance=new A198886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198887
{
public static readonly BigInteger[] Value={ 1L,1L,3L,28L,269L,5056L,84247L,2400448L,57253849L,2191568896L,68151324491L,3278448139264L,125802549088933L,7291045162516480L,332950230966532831L,BigInteger.Parse("22581201334925049856"),BigInteger.Parse("1196122595530554458033"),BigInteger.Parse("92934371464549349982208"),BigInteger.Parse("5602230959364892208231443") };
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
public class A198887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198887Inst Instance=new A198887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198888
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,22L,61L,172L,528L,1695L,5447L,17486L,56778L,187064L,622149L,2080325L,6990670L,23621143L,80230388L,273687898L,937072049L,3219316096L,11095261035L,38351414036L,132915860364L,461770505371L,1607875309626L,5610314558562L,19614016834508L,68696001390320L,241007011551493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198888Inst : IEnumerable<long>
{
public static readonly long[] Value=A198888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198888.Bytes);
public long this[int i]=>Value[i];

public static A198888Inst Instance=new A198888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198889
{
public static readonly long[] Value={ 2L,2L,2L,2L,6L,2L,2L,12L,6L,2L,2L,20L,24L,6L,2L,2L,30L,72L,24L,6L,2L,2L,42L,172L,120L,24L,6L,2L,2L,56L,352L,480L,120L,24L,6L,2L,2L,72L,646L,1512L,720L,120L,24L,6L,2L,2L,90L,1094L,3976L,3600L,720L,120L,24L,6L,2L,2L,110L,1742L,9144L,14184L,5040L,720L,120L,24L,6L,2L,2L,132L,2642L,18990L,45992L,30240L,5040L,720L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198889Inst : IEnumerable<long>
{
public static readonly long[] Value=A198889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198889.Bytes);
public long this[int i]=>Value[i];

public static A198889Inst Instance=new A198889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198890
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,2L,2L,3L,2L,4L,3L,4L,4L,4L,5L,4L,5L,5L,4L,6L,4L,5L,5L,4L,5L,4L,4L,4L,3L,4L,2L,3L,2L,2L,2L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,2L,3L,2L,4L,3L,5L,5L,7L,6L,8L,8L,9L,10L,12L,10L,14L,12L,14L,15L,16L,15L,18L,16L,18L,18L,20L,17L,21L,18L,20L,20L,20L,18L,21L,17L,20L,18L,18L,16L,18L,15L,16L,15L,14L,12L,14L,10L,12L,10L,9L,8L,8L,6L,7L,5L,5L,3L,4L,2L,3L,2L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198890Inst : IEnumerable<long>
{
public static readonly long[] Value=A198890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198890.Bytes);
public long this[int i]=>Value[i];

public static A198890Inst Instance=new A198890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198891
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,32L,180L,1219L,9646L,87192L,886536L,10016159L,124481258L,1687686528L,24787991800L,392081193504L,6644677619581L,120115898158288L,2307044712629472L,46917527736860976L,1007152702625923440L,BigInteger.Parse("22757886107313170356"),BigInteger.Parse("539955309450787483261"),BigInteger.Parse("13421068671117864869156") };
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
public class A198891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198891Inst Instance=new A198891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198892
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,48L,300L,2280L,20580L,211680L,2434320L,31134600L,438807600L,6744276000L,112237725600L,2011760150400L,38639999197800L,791610365145600L,17230493212732800L,397111119429024000L,9660782144094681600UL,BigInteger.Parse("247393077222459168000"),BigInteger.Parse("6651976858409613931200") };
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
public class A198892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198892Inst Instance=new A198892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198893
{
public static readonly long[] Value={ 1L,4L,66L,7128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198893Inst : IEnumerable<long>
{
public static readonly long[] Value=A198893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198893.Bytes);
public long this[int i]=>Value[i];

public static A198893Inst Instance=new A198893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198894
{
public static readonly long[] Value={ 1L,2L,11L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198894Inst : IEnumerable<long>
{
public static readonly long[] Value=A198894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198894.Bytes);
public long this[int i]=>Value[i];

public static A198894Inst Instance=new A198894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198895
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,5L,2L,1L,8L,18L,16L,5L,1L,16L,58L,88L,61L,16L,1L,32L,179L,416L,479L,272L,61L,1L,64L,543L,1824L,3111L,2880L,1385L,272L,1L,128L,1636L,7680L,18270L,24576L,19028L,7936L,1385L,1L,256L,4916L,31616L,101166L,185856L,206276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198895Inst : IEnumerable<long>
{
public static readonly long[] Value=A198895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198895.Bytes);
public long this[int i]=>Value[i];

public static A198895Inst Instance=new A198895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198896
{
public static readonly long[] Value={ 1L,2L,5L,12L,26L,54L,114L,228L,449L,878L,1690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198896Inst : IEnumerable<long>
{
public static readonly long[] Value=A198896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198896.Bytes);
public long this[int i]=>Value[i];

public static A198896Inst Instance=new A198896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198897
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,2L,2L,4L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198897Inst : IEnumerable<long>
{
public static readonly long[] Value=A198897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198897.Bytes);
public long this[int i]=>Value[i];

public static A198897Inst Instance=new A198897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198898
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,2L,3L,3L,3L,3L,3L,3L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198898Inst : IEnumerable<long>
{
public static readonly long[] Value=A198898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198898.Bytes);
public long this[int i]=>Value[i];

public static A198898Inst Instance=new A198898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198899
{
public static readonly BigInteger[] Value={ 1L,4L,1211L,6907736L,423503301834L,274342896958292170L,BigInteger.Parse("1877611081501313948217870"),BigInteger.Parse("135766460737448561825230968357842") };
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
public class A198899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198899.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198899Inst Instance=new A198899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198900
{
public static readonly long[] Value={ 1L,4L,33L,380L,4801L,62004L,804833L,10459180L,135958401L,1767426404L,22976444833L,298693487580L,3883014452801L,50479185229204L,656229400008033L,8530982176189580L,110902768218720001L,1441735986628126404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198900Inst : IEnumerable<long>
{
public static readonly long[] Value=A198900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198900.Bytes);
public long this[int i]=>Value[i];

public static A198900Inst Instance=new A198900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198901
{
public static readonly BigInteger[] Value={ 2L,33L,1211L,50384L,2125425L,89793204L,3794115705L,160319061892L,6774239755817L,286243775060868L,12095158053422201L,511077834439270724L,BigInteger.Parse("21595464215307153225"),BigInteger.Parse("912510860892666556164"),BigInteger.Parse("38557914891188891686425") };
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
public class A198901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198901Inst Instance=new A198901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198902
{
public static readonly BigInteger[] Value={ 5L,380L,50384L,6907736L,948656912L,130292546801L,17895005957823L,2457786852894234L,337564362706067534L,BigInteger.Parse("46362726246946052884"),BigInteger.Parse("6367681611531782236418"),BigInteger.Parse("874568266109492180669275") };
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
public class A198902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198902Inst Instance=new A198902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198903
{
public static readonly BigInteger[] Value={ 15L,4801L,2125425L,948656912L,423503301834L,189062985604305L,84402688527136201L,BigInteger.Parse("37679579867128064832"),BigInteger.Parse("16821155393975907014458"),BigInteger.Parse("7509406150309683843851949"),BigInteger.Parse("3352396396661126098060061297") };
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
public class A198903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198903Inst Instance=new A198903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198904
{
public static readonly BigInteger[] Value={ 51L,62004L,89793204L,130292546801L,189062985604305L,274342896958292170L,BigInteger.Parse("398089706066811447174"),BigInteger.Parse("577654521153750977585383"),BigInteger.Parse("838214957290859115489996817"),BigInteger.Parse("1216305402162613228248847610489") };
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
public class A198904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198904Inst Instance=new A198904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198905
{
public static readonly BigInteger[] Value={ 187L,804833L,3794115705L,17895005957823L,84402688527136201L,BigInteger.Parse("398089706066811447174"),BigInteger.Parse("1877611081501313948217870"),BigInteger.Parse("8855851690895754550489882369"),BigInteger.Parse("41769091588504560613470987916898") };
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
public class A198905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198905Inst Instance=new A198905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198906
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,33L,33L,5L,15L,380L,1211L,380L,15L,51L,4801L,50384L,50384L,4801L,51L,187L,62004L,2125425L,6907736L,2125425L,62004L,187L,715L,804833L,89793204L,948656912L,948656912L,89793204L,804833L,715L,2795L,10459180L,3794115705L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198906Inst : IEnumerable<long>
{
public static readonly long[] Value=A198906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198906.Bytes);
public long this[int i]=>Value[i];

public static A198906Inst Instance=new A198906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198907
{
public static readonly BigInteger[] Value={ 1L,4L,2051L,319608038L,4717456775959530L,BigInteger.Parse("2869765342757082981876352") };
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
public class A198907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198907.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198907Inst Instance=new A198907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198908
{
public static readonly BigInteger[] Value={ 1L,4L,34L,500L,10867L,313132L,10856948L,418689772L,17067989413L,715189507700L,30371156968582L,1298083132473604L,55654030558406039L,2389712969490386908L,BigInteger.Parse("102686352402421016536"),BigInteger.Parse("4414019789796312628796"),BigInteger.Parse("189771542890022982723145") };
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
public class A198908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198908.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198908Inst Instance=new A198908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198909
{
public static readonly BigInteger[] Value={ 2L,34L,2051L,269940L,54381563L,13088156547L,3352514013159L,876632051686733L,230783525290600476L,BigInteger.Parse("60892298359864756053"),BigInteger.Parse("16078352442288906898825"),BigInteger.Parse("4246466444504000973551502"),BigInteger.Parse("1121629692628918068552449185") };
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
public class A198909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198909.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198909Inst Instance=new A198909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198910
{
public static readonly BigInteger[] Value={ 5L,500L,269940L,319608038L,481871809749L,769126451071174L,1243368053336112649L,BigInteger.Parse("2015791720035206825303"),BigInteger.Parse("3270193421121063659774745"),BigInteger.Parse("5305976942994216714747844079"),BigInteger.Parse("8609380449975858170849466245738") };
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
public class A198910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198910.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198910Inst Instance=new A198910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198911
{
public static readonly BigInteger[] Value={ 15L,10867L,54381563L,481871809749L,4717456775959530L,BigInteger.Parse("46891073386615240710"),BigInteger.Parse("467181941240736711604077"),BigInteger.Parse("4656280284540702751242128730"),BigInteger.Parse("46410545076265038917843608182171"),BigInteger.Parse("462591920649454036671348839366018986") };
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
public class A198911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198911.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198911Inst Instance=new A198911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198912
{
public static readonly BigInteger[] Value={ 52L,313132L,13088156547L,769126451071174L,BigInteger.Parse("46891073386615240710"),BigInteger.Parse("2869765342757082981876352") };
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
public class A198912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198912.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198912Inst Instance=new A198912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198913
{
public static readonly BigInteger[] Value={ 203L,10856948L,3352514013159L,1243368053336112649L,BigInteger.Parse("467181941240736711604077") };
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
public class A198913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198913.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198913Inst Instance=new A198913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198914
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,5L,34L,34L,5L,15L,500L,2051L,500L,15L,52L,10867L,269940L,269940L,10867L,52L,203L,313132L,54381563L,319608038L,54381563L,313132L,203L,877L,10856948L,13088156547L,481871809749L,481871809749L,13088156547L,10856948L,877L,4139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198914Inst : IEnumerable<long>
{
public static readonly long[] Value=A198914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198914.Bytes);
public long this[int i]=>Value[i];

public static A198914Inst Instance=new A198914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198915
{
public static readonly BigInteger[] Value={ 3L,57L,261633L,18014398375264257L,BigInteger.Parse("5846006549323611672814736913013492849365380759553") };
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
public class A198915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198915Inst Instance=new A198915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198916
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,158L,1212L,10058L,88811L,826982L,8085950L,82922624L,893003234L,10129641140L,121552747370L,1550460365622L,21115793548491L,308004022741254L,4817224946243142L,80703099826887368L,1444218797390453282L,BigInteger.Parse("27501426760092853796"),BigInteger.Parse("554910390616969332656") };
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
public class A198916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198916Inst Instance=new A198916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198917
{
public static readonly long[] Value={ 8L,8L,8L,7L,4L,7L,2L,4L,2L,9L,3L,1L,7L,4L,1L,0L,3L,0L,5L,9L,6L,1L,0L,6L,1L,7L,7L,6L,5L,2L,4L,0L,1L,0L,9L,1L,6L,7L,2L,2L,9L,6L,0L,1L,7L,5L,9L,8L,3L,5L,2L,1L,0L,9L,0L,0L,7L,0L,2L,8L,6L,8L,3L,2L,0L,2L,4L,0L,1L,9L,3L,1L,2L,3L,1L,1L,9L,1L,3L,4L,2L,7L,9L,0L,7L,7L,5L,8L,1L,9L,9L,6L,6L,5L,1L,8L,0L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198917Inst : IEnumerable<long>
{
public static readonly long[] Value=A198917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198917.Bytes);
public long this[int i]=>Value[i];

public static A198917Inst Instance=new A198917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198918
{
public static readonly long[] Value={ 1L,0L,8L,5L,2L,5L,1L,0L,1L,3L,1L,3L,9L,7L,5L,8L,0L,2L,0L,5L,1L,2L,0L,9L,3L,9L,4L,8L,3L,2L,7L,6L,0L,5L,7L,9L,1L,8L,8L,9L,8L,4L,5L,7L,3L,6L,3L,5L,1L,2L,4L,7L,5L,3L,6L,8L,1L,7L,9L,2L,7L,2L,9L,9L,0L,5L,7L,1L,1L,2L,1L,4L,8L,5L,4L,4L,4L,2L,7L,8L,0L,4L,6L,9L,7L,9L,1L,9L,4L,3L,7L,8L,3L,5L,9L,0L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198918Inst : IEnumerable<long>
{
public static readonly long[] Value=A198918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198918.Bytes);
public long this[int i]=>Value[i];

public static A198918Inst Instance=new A198918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198919
{
public static readonly long[] Value={ 7L,0L,0L,1L,0L,8L,3L,9L,5L,0L,4L,1L,6L,3L,1L,4L,3L,1L,5L,3L,1L,5L,6L,1L,9L,4L,0L,3L,6L,5L,4L,1L,4L,6L,1L,3L,5L,5L,7L,2L,0L,0L,9L,9L,9L,6L,3L,3L,2L,6L,5L,3L,0L,6L,7L,0L,4L,0L,9L,6L,6L,2L,6L,2L,8L,7L,9L,6L,8L,2L,3L,8L,9L,8L,0L,7L,4L,1L,3L,5L,2L,0L,6L,5L,0L,8L,2L,9L,2L,6L,3L,6L,0L,2L,0L,1L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198919Inst : IEnumerable<long>
{
public static readonly long[] Value=A198919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198919.Bytes);
public long this[int i]=>Value[i];

public static A198919Inst Instance=new A198919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198920
{
public static readonly long[] Value={ 9L,8L,1L,1L,2L,6L,2L,8L,6L,1L,2L,9L,8L,8L,1L,3L,0L,3L,9L,4L,1L,3L,7L,9L,5L,4L,3L,1L,7L,8L,2L,7L,7L,3L,1L,0L,6L,2L,2L,6L,8L,7L,1L,6L,2L,7L,1L,7L,8L,0L,4L,4L,2L,6L,3L,3L,5L,4L,2L,8L,3L,6L,0L,4L,5L,5L,9L,0L,1L,5L,3L,7L,3L,9L,7L,2L,6L,3L,7L,3L,9L,1L,1L,0L,1L,7L,7L,4L,8L,3L,5L,6L,9L,0L,3L,7L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198920Inst : IEnumerable<long>
{
public static readonly long[] Value=A198920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198920.Bytes);
public long this[int i]=>Value[i];

public static A198920Inst Instance=new A198920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198921
{
public static readonly long[] Value={ 7L,9L,6L,1L,6L,7L,2L,6L,3L,0L,8L,3L,4L,1L,6L,0L,4L,4L,9L,9L,6L,7L,0L,6L,2L,1L,3L,3L,3L,2L,0L,5L,7L,0L,1L,3L,8L,1L,2L,9L,7L,9L,7L,9L,3L,2L,6L,4L,2L,0L,0L,9L,3L,5L,1L,5L,6L,3L,6L,4L,4L,5L,2L,9L,7L,4L,3L,1L,1L,7L,2L,2L,3L,6L,9L,0L,7L,6L,4L,0L,1L,5L,3L,9L,9L,3L,5L,9L,6L,2L,4L,3L,0L,4L,8L,0L,8L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198921Inst : IEnumerable<long>
{
public static readonly long[] Value=A198921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198921.Bytes);
public long this[int i]=>Value[i];

public static A198921Inst Instance=new A198921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198922
{
public static readonly long[] Value={ 7L,5L,8L,4L,8L,1L,2L,6L,0L,3L,1L,2L,6L,5L,2L,8L,0L,0L,6L,1L,1L,7L,4L,7L,6L,5L,6L,4L,9L,3L,5L,6L,8L,6L,3L,6L,5L,8L,2L,3L,7L,2L,7L,5L,7L,7L,0L,9L,7L,3L,2L,9L,7L,9L,6L,6L,8L,5L,5L,9L,4L,5L,1L,9L,3L,8L,1L,2L,9L,9L,4L,6L,4L,0L,8L,5L,4L,7L,4L,0L,9L,3L,4L,6L,7L,0L,0L,5L,9L,4L,5L,4L,9L,1L,1L,4L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198922Inst : IEnumerable<long>
{
public static readonly long[] Value=A198922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198922.Bytes);
public long this[int i]=>Value[i];

public static A198922Inst Instance=new A198922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198923
{
public static readonly long[] Value={ 5L,3L,3L,6L,2L,7L,2L,8L,4L,4L,2L,5L,2L,3L,2L,7L,8L,7L,5L,6L,0L,5L,6L,7L,8L,6L,5L,9L,9L,4L,0L,3L,5L,8L,8L,3L,9L,2L,4L,2L,9L,7L,4L,2L,6L,9L,6L,0L,6L,6L,7L,0L,8L,2L,5L,0L,7L,3L,1L,4L,5L,3L,3L,5L,0L,5L,3L,8L,6L,0L,3L,6L,5L,0L,7L,0L,6L,9L,5L,1L,3L,9L,4L,0L,2L,1L,9L,3L,8L,4L,8L,1L,7L,0L,0L,6L,6L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198923Inst : IEnumerable<long>
{
public static readonly long[] Value=A198923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198923.Bytes);
public long this[int i]=>Value[i];

public static A198923Inst Instance=new A198923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198924
{
public static readonly long[] Value={ 9L,3L,0L,4L,9L,0L,9L,7L,0L,4L,9L,3L,6L,2L,2L,7L,5L,6L,5L,8L,4L,6L,2L,8L,0L,6L,6L,9L,7L,0L,8L,3L,4L,7L,9L,9L,3L,6L,4L,1L,0L,7L,6L,1L,2L,0L,0L,7L,9L,8L,2L,3L,2L,4L,7L,5L,4L,8L,1L,4L,7L,9L,5L,6L,8L,2L,9L,0L,7L,5L,3L,3L,3L,4L,4L,0L,2L,8L,9L,4L,2L,2L,6L,5L,7L,9L,9L,6L,0L,1L,3L,3L,1L,5L,0L,0L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198924Inst : IEnumerable<long>
{
public static readonly long[] Value=A198924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198924.Bytes);
public long this[int i]=>Value[i];

public static A198924Inst Instance=new A198924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198925
{
public static readonly long[] Value={ 1L,0L,7L,6L,2L,0L,7L,7L,7L,8L,3L,5L,4L,6L,7L,6L,6L,6L,6L,1L,8L,6L,2L,2L,7L,8L,7L,9L,7L,0L,8L,3L,4L,9L,7L,7L,8L,3L,1L,6L,7L,0L,0L,6L,3L,7L,3L,7L,5L,7L,4L,9L,8L,2L,0L,2L,1L,6L,4L,2L,8L,3L,4L,2L,1L,8L,3L,6L,6L,1L,7L,4L,1L,7L,9L,6L,9L,6L,4L,1L,7L,2L,8L,1L,0L,4L,8L,1L,6L,0L,2L,5L,9L,9L,2L,8L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198925Inst : IEnumerable<long>
{
public static readonly long[] Value=A198925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198925.Bytes);
public long this[int i]=>Value[i];

public static A198925Inst Instance=new A198925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198926
{
public static readonly long[] Value={ 1L,2L,0L,5L,1L,9L,8L,1L,8L,1L,7L,7L,5L,4L,6L,5L,2L,5L,7L,6L,8L,6L,1L,0L,3L,9L,7L,5L,4L,9L,5L,2L,8L,2L,7L,6L,5L,0L,4L,3L,3L,1L,4L,1L,5L,9L,2L,2L,6L,4L,2L,8L,1L,2L,4L,9L,8L,7L,7L,2L,4L,5L,2L,0L,9L,9L,6L,1L,1L,6L,4L,4L,4L,5L,0L,5L,4L,7L,3L,6L,0L,3L,5L,7L,4L,7L,0L,7L,5L,5L,3L,0L,2L,7L,7L,1L,8L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198926Inst : IEnumerable<long>
{
public static readonly long[] Value=A198926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198926.Bytes);
public long this[int i]=>Value[i];

public static A198926Inst Instance=new A198926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198927
{
public static readonly long[] Value={ 5L,0L,1L,3L,0L,3L,0L,3L,9L,7L,5L,5L,1L,2L,4L,8L,7L,8L,3L,2L,2L,1L,2L,0L,7L,9L,5L,6L,8L,8L,6L,4L,7L,6L,4L,7L,1L,8L,1L,5L,9L,5L,8L,3L,7L,2L,0L,8L,9L,4L,4L,4L,7L,1L,0L,6L,1L,5L,0L,7L,4L,8L,8L,4L,3L,4L,5L,3L,7L,5L,0L,0L,9L,6L,2L,1L,3L,8L,0L,2L,2L,3L,2L,6L,9L,5L,7L,9L,3L,6L,6L,9L,0L,3L,1L,7L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198927Inst : IEnumerable<long>
{
public static readonly long[] Value=A198927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198927.Bytes);
public long this[int i]=>Value[i];

public static A198927Inst Instance=new A198927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198928
{
public static readonly long[] Value={ 8L,7L,2L,8L,0L,4L,1L,7L,8L,2L,0L,3L,9L,0L,8L,2L,7L,1L,7L,4L,8L,5L,4L,3L,3L,8L,9L,3L,2L,0L,5L,1L,4L,8L,9L,2L,1L,9L,5L,2L,4L,4L,8L,5L,3L,4L,1L,4L,2L,0L,7L,4L,5L,6L,5L,0L,7L,9L,0L,9L,4L,4L,8L,8L,9L,6L,8L,3L,7L,1L,8L,9L,4L,9L,3L,9L,0L,6L,6L,3L,0L,8L,2L,2L,0L,8L,0L,7L,0L,6L,2L,7L,8L,3L,1L,3L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198928Inst : IEnumerable<long>
{
public static readonly long[] Value=A198928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198928.Bytes);
public long this[int i]=>Value[i];

public static A198928Inst Instance=new A198928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198929
{
public static readonly long[] Value={ 1L,0L,1L,0L,4L,4L,1L,1L,7L,9L,2L,2L,4L,6L,6L,5L,0L,3L,7L,2L,5L,6L,9L,3L,1L,5L,7L,6L,9L,6L,7L,0L,3L,0L,6L,6L,3L,1L,3L,4L,4L,6L,5L,0L,7L,4L,7L,5L,7L,1L,8L,0L,0L,1L,2L,8L,9L,5L,5L,5L,2L,7L,2L,7L,0L,8L,4L,4L,5L,2L,8L,6L,9L,1L,1L,6L,7L,3L,4L,5L,3L,0L,5L,2L,5L,4L,6L,1L,0L,4L,1L,1L,5L,2L,9L,5L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198929Inst : IEnumerable<long>
{
public static readonly long[] Value=A198929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198929.Bytes);
public long this[int i]=>Value[i];

public static A198929Inst Instance=new A198929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198930
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,3L,0L,8L,4L,9L,4L,8L,2L,7L,8L,0L,7L,0L,8L,0L,8L,7L,8L,0L,0L,6L,5L,1L,5L,7L,2L,8L,7L,7L,8L,9L,8L,9L,6L,0L,2L,6L,5L,9L,4L,4L,7L,7L,7L,6L,8L,1L,5L,6L,9L,7L,7L,2L,0L,5L,3L,7L,5L,7L,1L,5L,4L,8L,1L,8L,2L,3L,7L,8L,8L,7L,6L,0L,3L,2L,9L,6L,9L,3L,2L,9L,4L,5L,5L,2L,3L,4L,1L,5L,2L,6L,4L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198930Inst : IEnumerable<long>
{
public static readonly long[] Value=A198930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198930.Bytes);
public long this[int i]=>Value[i];

public static A198930Inst Instance=new A198930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198931
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,3L,7L,2L,8L,5L,3L,9L,7L,2L,3L,6L,5L,5L,2L,7L,3L,1L,0L,1L,5L,8L,7L,7L,5L,2L,0L,5L,7L,2L,2L,0L,1L,5L,4L,5L,8L,8L,8L,2L,7L,1L,2L,2L,5L,1L,0L,8L,3L,3L,3L,5L,6L,6L,5L,6L,5L,3L,1L,9L,9L,4L,7L,9L,7L,5L,1L,7L,2L,1L,9L,0L,1L,6L,1L,7L,1L,3L,5L,2L,5L,3L,5L,1L,5L,1L,8L,7L,1L,6L,7L,1L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198931Inst : IEnumerable<long>
{
public static readonly long[] Value=A198931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198931.Bytes);
public long this[int i]=>Value[i];

public static A198931Inst Instance=new A198931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198932
{
public static readonly long[] Value={ 6L,7L,0L,8L,0L,9L,5L,0L,1L,1L,9L,2L,0L,7L,4L,3L,9L,7L,2L,6L,1L,1L,5L,6L,3L,7L,8L,3L,9L,2L,4L,7L,4L,2L,2L,6L,0L,1L,5L,6L,7L,0L,7L,0L,9L,9L,2L,3L,1L,1L,4L,7L,2L,2L,8L,9L,5L,4L,0L,4L,7L,7L,1L,7L,3L,0L,2L,1L,0L,1L,9L,9L,4L,4L,4L,0L,3L,2L,3L,8L,9L,5L,7L,8L,1L,1L,3L,7L,6L,7L,8L,7L,6L,8L,5L,9L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198932Inst : IEnumerable<long>
{
public static readonly long[] Value=A198932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198932.Bytes);
public long this[int i]=>Value[i];

public static A198932Inst Instance=new A198932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198933
{
public static readonly long[] Value={ 9L,5L,4L,6L,0L,2L,7L,1L,9L,1L,5L,4L,7L,3L,6L,2L,1L,4L,3L,9L,9L,6L,8L,0L,8L,2L,2L,6L,2L,5L,4L,8L,6L,4L,8L,0L,8L,5L,9L,8L,3L,5L,4L,0L,7L,5L,7L,1L,8L,6L,7L,0L,1L,5L,1L,2L,4L,4L,6L,7L,8L,7L,0L,5L,0L,5L,4L,0L,3L,8L,4L,8L,3L,7L,2L,8L,9L,4L,1L,7L,9L,6L,0L,9L,3L,4L,0L,5L,7L,2L,8L,9L,0L,1L,3L,1L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198933Inst : IEnumerable<long>
{
public static readonly long[] Value=A198933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198933.Bytes);
public long this[int i]=>Value[i];

public static A198933Inst Instance=new A198933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198934
{
public static readonly long[] Value={ 1L,0L,7L,0L,6L,2L,6L,5L,4L,4L,0L,2L,0L,8L,2L,7L,3L,2L,3L,0L,9L,3L,1L,1L,9L,2L,9L,2L,3L,6L,5L,1L,7L,1L,9L,8L,1L,4L,6L,0L,6L,5L,6L,1L,7L,4L,5L,2L,7L,8L,3L,7L,7L,1L,8L,4L,2L,6L,4L,1L,4L,2L,8L,0L,1L,2L,1L,4L,8L,2L,5L,9L,9L,5L,7L,1L,3L,1L,6L,1L,2L,0L,8L,2L,1L,3L,3L,6L,7L,9L,5L,6L,5L,5L,5L,1L,6L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198934Inst : IEnumerable<long>
{
public static readonly long[] Value=A198934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198934.Bytes);
public long this[int i]=>Value[i];

public static A198934Inst Instance=new A198934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198935
{
public static readonly long[] Value={ 1L,2L,7L,4L,7L,7L,4L,6L,9L,7L,2L,9L,2L,4L,4L,9L,5L,6L,0L,6L,0L,1L,9L,2L,6L,0L,6L,4L,0L,1L,0L,6L,3L,8L,0L,9L,7L,0L,8L,4L,7L,1L,2L,6L,1L,6L,5L,2L,3L,7L,3L,0L,0L,4L,2L,0L,3L,1L,6L,6L,5L,7L,2L,3L,0L,1L,3L,9L,6L,5L,5L,5L,3L,5L,4L,7L,1L,7L,7L,6L,2L,3L,7L,4L,4L,4L,0L,2L,0L,1L,6L,2L,9L,8L,1L,7L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198935Inst : IEnumerable<long>
{
public static readonly long[] Value=A198935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198935.Bytes);
public long this[int i]=>Value[i];

public static A198935Inst Instance=new A198935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198936
{
public static readonly long[] Value={ 4L,4L,8L,7L,1L,1L,7L,7L,1L,1L,5L,9L,0L,9L,8L,4L,8L,0L,9L,4L,3L,9L,4L,0L,7L,6L,3L,7L,1L,9L,7L,1L,0L,6L,0L,5L,0L,1L,7L,4L,5L,0L,0L,1L,7L,4L,3L,9L,1L,1L,4L,1L,8L,3L,0L,2L,5L,7L,4L,1L,9L,0L,2L,3L,0L,0L,4L,1L,5L,4L,6L,2L,9L,4L,7L,7L,8L,0L,1L,0L,6L,5L,1L,4L,1L,4L,0L,5L,8L,2L,6L,0L,3L,3L,8L,4L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198936Inst : IEnumerable<long>
{
public static readonly long[] Value=A198936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198936.Bytes);
public long this[int i]=>Value[i];

public static A198936Inst Instance=new A198936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198937
{
public static readonly long[] Value={ 6L,3L,6L,7L,1L,4L,1L,7L,4L,1L,0L,4L,2L,3L,6L,7L,1L,3L,8L,6L,4L,2L,0L,9L,0L,7L,1L,7L,5L,8L,4L,5L,2L,8L,7L,9L,7L,3L,2L,4L,8L,8L,3L,8L,5L,7L,7L,4L,3L,7L,3L,2L,8L,8L,6L,1L,3L,6L,7L,7L,7L,3L,5L,7L,4L,8L,1L,0L,5L,8L,0L,0L,4L,1L,7L,2L,0L,1L,7L,4L,8L,6L,5L,1L,7L,1L,9L,7L,2L,6L,5L,6L,7L,5L,6L,4L,5L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198937Inst : IEnumerable<long>
{
public static readonly long[] Value=A198937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198937.Bytes);
public long this[int i]=>Value[i];

public static A198937Inst Instance=new A198937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198938
{
public static readonly long[] Value={ 7L,8L,2L,4L,5L,9L,2L,4L,5L,5L,5L,0L,8L,7L,9L,2L,6L,8L,1L,0L,9L,7L,7L,1L,9L,5L,1L,8L,5L,3L,5L,3L,5L,5L,0L,2L,6L,1L,2L,0L,3L,7L,2L,3L,0L,1L,5L,1L,9L,8L,4L,4L,3L,3L,3L,4L,0L,4L,7L,0L,2L,6L,7L,3L,4L,0L,5L,3L,9L,2L,2L,4L,0L,9L,2L,1L,5L,3L,6L,8L,4L,5L,8L,6L,8L,6L,5L,7L,9L,7L,8L,8L,5L,8L,3L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198938Inst : IEnumerable<long>
{
public static readonly long[] Value=A198938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198938.Bytes);
public long this[int i]=>Value[i];

public static A198938Inst Instance=new A198938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198939
{
public static readonly long[] Value={ 1L,0L,1L,7L,0L,8L,5L,5L,0L,3L,3L,7L,4L,3L,8L,3L,1L,3L,0L,7L,2L,2L,0L,7L,2L,0L,1L,6L,7L,7L,1L,6L,2L,6L,0L,8L,9L,5L,6L,6L,4L,6L,1L,3L,4L,2L,9L,6L,5L,5L,5L,0L,5L,7L,5L,6L,2L,2L,6L,6L,3L,8L,0L,6L,9L,1L,6L,6L,6L,5L,9L,1L,8L,6L,4L,6L,7L,0L,0L,4L,5L,6L,7L,6L,5L,0L,5L,7L,9L,3L,4L,2L,2L,8L,1L,5L,8L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198939Inst : IEnumerable<long>
{
public static readonly long[] Value=A198939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198939.Bytes);
public long this[int i]=>Value[i];

public static A198939Inst Instance=new A198939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198940
{
public static readonly long[] Value={ 1L,1L,1L,8L,0L,1L,5L,0L,5L,0L,8L,3L,7L,0L,2L,0L,2L,5L,5L,8L,4L,4L,1L,3L,1L,2L,6L,5L,4L,8L,7L,6L,4L,2L,4L,2L,6L,6L,3L,7L,0L,5L,5L,7L,7L,4L,1L,4L,0L,7L,6L,6L,1L,6L,7L,8L,2L,5L,7L,9L,9L,4L,8L,9L,0L,5L,0L,3L,6L,2L,0L,5L,1L,4L,4L,7L,3L,6L,1L,1L,9L,7L,0L,5L,8L,9L,4L,1L,0L,3L,1L,3L,1L,8L,3L,9L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198940Inst : IEnumerable<long>
{
public static readonly long[] Value=A198940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198940.Bytes);
public long this[int i]=>Value[i];

public static A198940Inst Instance=new A198940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198941
{
public static readonly long[] Value={ 1L,2L,1L,1L,7L,9L,6L,4L,7L,4L,6L,7L,1L,9L,7L,7L,5L,7L,7L,4L,8L,1L,4L,0L,7L,2L,1L,2L,9L,1L,6L,5L,4L,8L,0L,2L,2L,5L,0L,0L,2L,8L,1L,2L,7L,0L,2L,6L,0L,6L,1L,4L,0L,2L,2L,3L,6L,4L,0L,4L,3L,2L,6L,7L,3L,4L,7L,8L,2L,4L,5L,1L,0L,0L,7L,9L,1L,2L,0L,8L,9L,9L,5L,0L,6L,2L,7L,1L,8L,9L,8L,4L,2L,2L,7L,4L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198941Inst : IEnumerable<long>
{
public static readonly long[] Value=A198941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198941.Bytes);
public long this[int i]=>Value[i];

public static A198941Inst Instance=new A198941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198942
{
public static readonly long[] Value={ 1L,2L,9L,9L,9L,9L,9L,5L,9L,7L,9L,5L,7L,0L,4L,0L,5L,3L,4L,1L,8L,4L,7L,9L,3L,2L,7L,7L,0L,5L,9L,1L,7L,9L,1L,3L,9L,9L,9L,5L,9L,1L,1L,1L,1L,6L,4L,7L,4L,6L,2L,0L,5L,3L,2L,4L,6L,1L,4L,4L,2L,4L,5L,8L,5L,4L,4L,9L,6L,1L,0L,1L,7L,0L,1L,8L,0L,1L,7L,0L,0L,3L,6L,1L,9L,0L,2L,9L,6L,6L,7L,6L,6L,7L,3L,9L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198942Inst : IEnumerable<long>
{
public static readonly long[] Value=A198942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198942.Bytes);
public long this[int i]=>Value[i];

public static A198942Inst Instance=new A198942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198943
{
public static readonly long[] Value={ 1L,9L,41L,79L,351L,1559L,3001L,13329L,59201L,113959L,506151L,2248079L,4327441L,19220409L,85367801L,164328799L,729869391L,3241728359L,6240166921L,27715816449L,123100309841L,236962014199L,1052471155671L,4674570045599L,8998316372641L,39966188099049L,177510561422921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198943Inst : IEnumerable<long>
{
public static readonly long[] Value=A198943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198943.Bytes);
public long this[int i]=>Value[i];

public static A198943Inst Instance=new A198943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198944
{
public static readonly long[] Value={ 1L,1L,2L,7L,23L,78L,291L,1126L,4436L,17910L,73773L,308188L,1303402L,5573133L,24050795L,104620985L,458324429L,2020417339L,8956142180L,39899217350L,178549985024L,802275736073L,3618237414959L,16373514195570L,74325340129430L,338356926399193L,1544406450870590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198944Inst : IEnumerable<long>
{
public static readonly long[] Value=A198944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198944.Bytes);
public long this[int i]=>Value[i];

public static A198944Inst Instance=new A198944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198945
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,114L,1213L,30838L,2121309L,276352623L,57301231426L,23565649037533L,26695112293671042L,BigInteger.Parse("64176655598885762420"),BigInteger.Parse("241858766657669843853891"),BigInteger.Parse("1532114965167989470245178816"),BigInteger.Parse("24647864257364414796375879195305"),BigInteger.Parse("1038222828395065545608332107235286628") };
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
public class A198945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198945Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198945.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198945.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198945Inst Instance=new A198945Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198946
{
public static readonly BigInteger[] Value={ 1L,2L,7L,43L,661L,45503L,14835966L,19030289368L,96523753164218L,1826134533496656481L,BigInteger.Parse("136782939777235335759015"),BigInteger.Parse("38134547664565961218637677016"),BigInteger.Parse("42464787999263932204904982967955033"),BigInteger.Parse("176203582974534986934299369142808689004350") };
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
public class A198946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198946.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198946Inst Instance=new A198946Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198947
{
public static readonly long[] Value={ 1L,7L,13L,139L,259L,2773L,5167L,55321L,103081L,1103647L,2056453L,22017619L,41025979L,439248733L,818463127L,8762957041L,16328236561L,174819892087L,325746268093L,3487634884699L,6498597125299L,69577877801893L,129646196237887L,1388069921153161L,2586425327632441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198947Inst : IEnumerable<long>
{
public static readonly long[] Value=A198947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198947.Bytes);
public long this[int i]=>Value[i];

public static A198947Inst Instance=new A198947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198948
{
public static readonly long[] Value={ 1L,-56L,-2296L,-13664L,-73976L,-175056L,-560224L,-941248L,-2367736L,-3320408L,-7177296L,-9018912L,-18050144L,-20792464L,-38591168L,-42713664L,-75768056L,-79512048L,-136136728L,-138661600L,-231248976L,-229664512L,-369775392L,-360435264L,-577727584L,-547050056L,-852491024L,-806859200L,-1243388608L,-1148624400L,-1751260224L,-1603232512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198948Inst : IEnumerable<long>
{
public static readonly long[] Value=A198948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198948.Bytes);
public long this[int i]=>Value[i];

public static A198948Inst Instance=new A198948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198949
{
public static readonly long[] Value={ 1L,23L,43L,461L,859L,9197L,17137L,183479L,341881L,3660383L,6820483L,73024181L,136067779L,1456823237L,2714535097L,29063440559L,54154634161L,579811987943L,1080378148123L,11567176318301L,21553408328299L,230763714378077L,429987788417857L,4603707111243239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198949Inst : IEnumerable<long>
{
public static readonly long[] Value=A198949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198949.Bytes);
public long this[int i]=>Value[i];

public static A198949Inst Instance=new A198949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198950
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,22L,58L,150L,392L,1097L,3139L,9069L,26903L,81299L,248305L,768521L,2407340L,7607947L,24248690L,77906841L,251995121L,820096599L,2684160567L,8830103123L,29183369411L,96865043941L,322780531149L,1079491353973L,3622338207474L,12193038599714L,41161594789286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198950Inst : IEnumerable<long>
{
public static readonly long[] Value=A198950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198950.Bytes);
public long this[int i]=>Value[i];

public static A198950Inst Instance=new A198950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198951
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,16L,39L,99L,271L,763L,2146L,6062L,17359L,50337L,147057L,431874L,1275273L,3786649L,11298031L,33846202L,101762937L,306997821L,929038518L,2819426688L,8578433304L,26163061776L,79970186791L,244938841096L,751646959402L,2310683396056L,7115199919151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198951Inst : IEnumerable<long>
{
public static readonly long[] Value=A198951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198951.Bytes);
public long this[int i]=>Value[i];

public static A198951Inst Instance=new A198951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198952
{
public static readonly BigInteger[] Value={ 1L,1L,3L,45L,3267L,991845L,1155605211L,4910640919821L,73614877173054099L,BigInteger.Parse("3802910817051064124469"),BigInteger.Parse("665332303024345700007225099"),BigInteger.Parse("388955052253927480089824057425437"),BigInteger.Parse("751710022839628223241451188902204177091") };
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
public class A198952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198952Inst Instance=new A198952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198953
{
public static readonly long[] Value={ 1L,2L,9L,56L,400L,3095L,25240L,213633L,1859006L,16527544L,149472480L,1370794835L,12718060947L,119158146283L,1125816405458L,10714275588727L,102615375322564L,988302823695146L,9565859385140272L,93000625498797314L,907782305262566776L,8892941663606408172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198953Inst : IEnumerable<long>
{
public static readonly long[] Value=A198953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198953.Bytes);
public long this[int i]=>Value[i];

public static A198953Inst Instance=new A198953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198954
{
public static readonly long[] Value={ 1L,3L,0L,5L,0L,0L,7L,0L,0L,0L,9L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,13L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,17L,0L,0L,0L,0L,0L,0L,0L,0L,19L,0L,0L,0L,0L,0L,0L,0L,0L,0L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,23L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,25L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,27L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198954Inst : IEnumerable<long>
{
public static readonly long[] Value=A198954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198954.Bytes);
public long this[int i]=>Value[i];

public static A198954Inst Instance=new A198954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198955
{
public static readonly long[] Value={ 1L,15L,54L,-76L,-243L,1188L,-1384L,-2916L,11934L,-11580L,-21870L,79704L,-71022L,-123444L,421308L,-352544L,-581013L,1885572L,-1510236L,-2388204L,7469928L,-5777672L,-8852004L,26869968L,-20218587L,-30177684L,89408826L,-65743304L,-96033357L,278737632L,-201031888L,-288281592L,822239532L,-583185916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198955Inst : IEnumerable<long>
{
public static readonly long[] Value=A198955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198955.Bytes);
public long this[int i]=>Value[i];

public static A198955Inst Instance=new A198955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198956
{
public static readonly long[] Value={ 0L,1L,9L,27L,73L,126L,243L,344L,585L,729L,1134L,1332L,1971L,2198L,3096L,3402L,4681L,4914L,6561L,6860L,9198L,9288L,11988L,12168L,15795L,15751L,19782L,19683L,25112L,24390L,30618L,29792L,37449L,35964L,44226L,43344L,53217L,50654L,61740L,59346L,73710L,68922L,83592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198956Inst : IEnumerable<long>
{
public static readonly long[] Value=A198956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198956.Bytes);
public long this[int i]=>Value[i];

public static A198956Inst Instance=new A198956Inst();

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