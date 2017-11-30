using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A197205
{
public static readonly BigInteger[] Value={ 6L,496L,22210L,977946L,44049565L,1989885480L,89745742142L,4040991108566L,182261563872132L,8218346291797149L,370479419808054291L,16702609526861781522UL,BigInteger.Parse("753042675005485120165"),BigInteger.Parse("33950326193658865945236") };
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
public class A197205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197205Inst Instance=new A197205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197206
{
public static readonly BigInteger[] Value={ 9L,1601L,135560L,11746093L,1024514869L,89745742142L,7876891407951L,690021326042559L,60491817588808916L,5301646194878359081L,BigInteger.Parse("464649371771178476930"),BigInteger.Parse("40726185128716590636286"),BigInteger.Parse("3569576115816506857804441") };
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
public class A197206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197206Inst Instance=new A197206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197207
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,3L,16L,16L,3L,4L,47L,100L,47L,4L,6L,154L,588L,588L,154L,6L,9L,496L,3649L,7073L,3649L,496L,9L,13L,1601L,22210L,82408L,82408L,22210L,1601L,13L,19L,5183L,135560L,977946L,1890344L,977946L,135560L,5183L,19L,28L,16777L,827698L,11746093L,44049565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197207Inst : IEnumerable<long>
{
public static readonly long[] Value=A197207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197207.Bytes);
public long this[int i]=>Value[i];

public static A197207Inst Instance=new A197207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197208
{
public static readonly long[] Value={ 3L,12L,12L,30L,120L,30L,60L,600L,600L,60L,105L,2100L,5250L,2100L,105L,168L,5880L,29400L,29400L,5880L,168L,252L,14112L,123480L,246960L,123480L,14112L,252L,360L,30240L,423360L,1481760L,1481760L,423360L,30240L,360L,495L,59400L,1247400L,6985440L,12224520L,6985440L,1247400L,59400L,495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197208Inst : IEnumerable<long>
{
public static readonly long[] Value=A197208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197208.Bytes);
public long this[int i]=>Value[i];

public static A197208Inst Instance=new A197208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197209
{
public static readonly long[] Value={ 3L,24L,180L,1320L,9660L,70896L,522648L,3871440L,28809990L,215318400L,1615579680L,12165491520L,91905439080L,696359055840L,5290416835440L,40291036122528L,307537305284574L,2352216447006480L,18024996856976760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197209Inst : IEnumerable<long>
{
public static readonly long[] Value=A197209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197209.Bytes);
public long this[int i]=>Value[i];

public static A197209Inst Instance=new A197209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197210
{
public static readonly long[] Value={ 1L,2L,14L,221L,10210L,1130812L,322715244L,242641943340L,469481820661588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197210Inst : IEnumerable<long>
{
public static readonly long[] Value=A197210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197210.Bytes);
public long this[int i]=>Value[i];

public static A197210Inst Instance=new A197210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197211
{
public static readonly long[] Value={ 1L,2L,5L,8L,18L,37L,73L,151L,306L,621L,1266L,2572L,5231L,10641L,21637L,44006L,89497L,182008L,370158L,752797L,1530977L,3113587L,6332166L,12877865L,26190002L,53263176L,108322495L,220297841L,448024553L,911157386L,1853040797L,3768569784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197211Inst : IEnumerable<long>
{
public static readonly long[] Value=A197211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197211.Bytes);
public long this[int i]=>Value[i];

public static A197211Inst Instance=new A197211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197212
{
public static readonly long[] Value={ 1L,5L,14L,44L,149L,479L,1537L,4971L,16088L,52020L,168111L,543379L,1756623L,5678611L,18356490L,59338576L,191817551L,620069245L,2004431603L,6479507953L,20945607368L,67708621756L,218874399841L,707531760601L,2287161925185L,7393462782885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197212Inst : IEnumerable<long>
{
public static readonly long[] Value=A197212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197212.Bytes);
public long this[int i]=>Value[i];

public static A197212Inst Instance=new A197212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197213
{
public static readonly long[] Value={ 1L,8L,44L,221L,1175L,5982L,30940L,160438L,828709L,4285218L,22165292L,114628225L,592784354L,3065621155L,15854191220L,81990622115L,424018125103L,2192835511699L,11340373874625L,58647355280660L,303298041583255L,1568522750375630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197213Inst : IEnumerable<long>
{
public static readonly long[] Value=A197213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197213.Bytes);
public long this[int i]=>Value[i];

public static A197213Inst Instance=new A197213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197214
{
public static readonly long[] Value={ 1L,18L,149L,1175L,10210L,84893L,706153L,5894192L,49247065L,411367276L,3434602140L,28682410161L,239530800201L,2000290147256L,16704503683687L,139499503942475L,1164956427123627L,9728544605113135L,81243067790950141L,678460374702910366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197214Inst : IEnumerable<long>
{
public static readonly long[] Value=A197214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197214.Bytes);
public long this[int i]=>Value[i];

public static A197214Inst Instance=new A197214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197215
{
public static readonly long[] Value={ 1L,37L,479L,5982L,84893L,1130812L,15034832L,202026037L,2712108937L,36354079627L,487366238398L,6535360303819L,87635492801648L,1175117242216066L,15757048234536205L,211285700462837436L,2833150080279284040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197215Inst : IEnumerable<long>
{
public static readonly long[] Value=A197215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197215.Bytes);
public long this[int i]=>Value[i];

public static A197215Inst Instance=new A197215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197216
{
public static readonly BigInteger[] Value={ 1L,73L,1537L,30940L,706153L,15034832L,322715244L,6984694296L,150562726618L,3245505223710L,70004837612015L,1509763068769076L,32557618945328577L,702121520920633674L,15141824337674655027UL,BigInteger.Parse("326544294704293876446") };
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
public class A197216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197216.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197216Inst Instance=new A197216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197217
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,8L,14L,8L,1L,1L,18L,44L,44L,18L,1L,1L,37L,149L,221L,149L,37L,1L,1L,73L,479L,1175L,1175L,479L,73L,1L,1L,151L,1537L,5982L,10210L,5982L,1537L,151L,1L,1L,306L,4971L,30940L,84893L,84893L,30940L,4971L,306L,1L,1L,621L,16088L,160438L,706153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197217Inst : IEnumerable<long>
{
public static readonly long[] Value=A197217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197217.Bytes);
public long this[int i]=>Value[i];

public static A197217Inst Instance=new A197217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197218
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,10L,6L,28L,46L,36L,80L,198L,132L,520L,560L,600L,2206L,3570L,1908L,9348L,12960L,11760L,25704L,63480L,50692L,150000L,180960L,208008L,609084L,1130304L,604800L,3010348L,4865280L,3920400L,8374344L,17836000L,13685760L,54018520L,58269200L,69600960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197218Inst : IEnumerable<long>
{
public static readonly long[] Value=A197218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197218.Bytes);
public long this[int i]=>Value[i];

public static A197218Inst Instance=new A197218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197219
{
public static readonly long[] Value={ 2L,1L,1L,3L,3L,7L,3L,18L,7L,18L,7L,123L,7L,322L,18L,47L,47L,2207L,18L,5778L,47L,322L,123L,39603L,47L,15127L,322L,5778L,322L,710647L,47L,1860498L,2207L,15127L,2207L,103682L,322L,33385282L,5778L,103682L,2207L,228826127L,322L,599074578L,15127L,103682L,39603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197219Inst : IEnumerable<long>
{
public static readonly long[] Value=A197219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197219.Bytes);
public long this[int i]=>Value[i];

public static A197219Inst Instance=new A197219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197220
{
public static readonly long[] Value={ 3L,34L,37L,71L,108L,179L,1003L,1182L,12823L,39651L,369682L,409333L,1188348L,28929685L,4109203618L,12356540539L,16465744157L,61753773010L,263480836197L,325234609207L,2214888491439L,2540123100646L,14915503994669L,32371131089984L,79657766174637L,112028897264621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197220Inst : IEnumerable<long>
{
public static readonly long[] Value=A197220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197220.Bytes);
public long this[int i]=>Value[i];

public static A197220Inst Instance=new A197220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197221
{
public static readonly long[] Value={ 1L,11L,12L,23L,35L,58L,325L,383L,4155L,12848L,119787L,132635L,385057L,9374003L,1331493483L,4003854452L,5335347935L,20009898257L,85374940963L,105384839220L,717683976283L,823068815503L,4833028053798L,10489124923099L,25811277899996L,36300402823095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197221Inst : IEnumerable<long>
{
public static readonly long[] Value=A197221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197221.Bytes);
public long this[int i]=>Value[i];

public static A197221Inst Instance=new A197221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197222
{
public static readonly long[] Value={ 2L,5L,7L,40L,47L,275L,597L,872L,3213L,36215L,111858L,148073L,704150L,6485423L,7189573L,49622861L,56812434L,220060163L,716992923L,937053086L,4465205267L,9867463620L,14332668887L,24200132507L,86933066408L,111133198915L,420332663153L,1792463851527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197222Inst : IEnumerable<long>
{
public static readonly long[] Value=A197222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197222.Bytes);
public long this[int i]=>Value[i];

public static A197222Inst Instance=new A197222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197223
{
public static readonly long[] Value={ 1L,2L,3L,17L,20L,117L,254L,371L,1367L,15408L,47591L,62999L,299587L,2759282L,3058869L,21112496L,24171365L,93626591L,305051138L,398677729L,1899762054L,4198201837L,6097963891L,10296165728L,36986461075L,47282626803L,178834341484L,762619992739L,941454334223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197223Inst : IEnumerable<long>
{
public static readonly long[] Value=A197223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197223.Bytes);
public long this[int i]=>Value[i];

public static A197223Inst Instance=new A197223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197224
{
public static readonly long[] Value={ 0L,1L,4L,3L,2L,3L,8L,5L,5L,5L,5L,9L,8L,6L,16L,5L,8L,6L,10L,16L,4L,6L,9L,17L,20L,21L,18L,10L,13L,19L,7L,27L,9L,30L,9L,12L,20L,30L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197224Inst : IEnumerable<long>
{
public static readonly long[] Value=A197224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197224.Bytes);
public long this[int i]=>Value[i];

public static A197224Inst Instance=new A197224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197225
{
public static readonly long[] Value={ 3L,11L,17L,37L,41L,53L,73L,79L,83L,101L,107L,137L,163L,173L,227L,239L,257L,271L,317L,347L,353L,359L,449L,467L,479L,563L,587L,641L,643L,719L,733L,751L,757L,773L,797L,839L,907L,1031L,1187L,1231L,1283L,1307L,1319L,1409L,1439L,1493L,1523L,1627L,1637L,1879L,1907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197225Inst : IEnumerable<long>
{
public static readonly long[] Value=A197225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197225.Bytes);
public long this[int i]=>Value[i];

public static A197225Inst Instance=new A197225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197226
{
public static readonly long[] Value={ 1L,2L,16L,3L,5L,13L,8L,13L,41L,4L,53L,8L,81L,43L,113L,7L,256L,5L,79L,173L,32L,179L,32L,233L,239L,281L,293L,32L,107L,359L,61L,125L,27L,193L,199L,419L,151L,103L,593L,41L,641L,653L,659L,32L,719L,373L,761L,271L,409L,313L,953L,331L,1013L,1019L,137L,619L,223L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197226Inst : IEnumerable<long>
{
public static readonly long[] Value=A197226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197226.Bytes);
public long this[int i]=>Value[i];

public static A197226Inst Instance=new A197226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197227
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,19L,29L,37L,43L,47L,61L,73L,79L,89L,103L,107L,113L,137L,149L,151L,157L,163L,167L,179L,191L,193L,227L,229L,239L,241L,257L,277L,283L,293L,307L,313L,317L,337L,347L,359L,367L,383L,389L,397L,409L,419L,433L,461L,467L,509L,521L,541L,547L,557L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197227Inst : IEnumerable<long>
{
public static readonly long[] Value=A197227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197227.Bytes);
public long this[int i]=>Value[i];

public static A197227Inst Instance=new A197227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197228
{
public static readonly long[] Value={ 1L,7L,55L,2117L,249929L,98514881L,126615582841L,511052139999591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197228Inst : IEnumerable<long>
{
public static readonly long[] Value=A197228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197228.Bytes);
public long this[int i]=>Value[i];

public static A197228Inst Instance=new A197228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197229
{
public static readonly long[] Value={ 1L,7L,12L,31L,79L,186L,465L,1131L,2776L,6803L,16663L,40842L,100065L,245207L,600844L,1472287L,3607663L,8840098L,21661545L,53078827L,130062864L,318702387L,780939327L,1913591746L,4689011265L,11489821079L,28154333788L,68988586095L,169047687279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197229Inst : IEnumerable<long>
{
public static readonly long[] Value=A197229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197229.Bytes);
public long this[int i]=>Value[i];

public static A197229Inst Instance=new A197229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197230
{
public static readonly long[] Value={ 2L,12L,55L,242L,1178L,5355L,24723L,116440L,545287L,2548432L,11939565L,55931989L,261856867L,1226207807L,5742642388L,26891481148L,125926466092L,589702469437L,2761498731050L,12931647025852L,60557080572253L,283580433219551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197230Inst : IEnumerable<long>
{
public static readonly long[] Value=A197230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197230.Bytes);
public long this[int i]=>Value[i];

public static A197230Inst Instance=new A197230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197231
{
public static readonly long[] Value={ 3L,31L,242L,2117L,17759L,141210L,1207249L,10193669L,85161702L,716691651L,6018972449L,50526364522L,424443693477L,3564252187315L,29932907855790L,251391944508773L,2111203108705289L,17730374106602548L,148903966138218485L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197231Inst : IEnumerable<long>
{
public static readonly long[] Value=A197231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197231.Bytes);
public long this[int i]=>Value[i];

public static A197231Inst Instance=new A197231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197232
{
public static readonly long[] Value={ 5L,79L,1178L,17759L,249929L,3710070L,56349129L,835898389L,12424253226L,185170942121L,2756987019132L,41049283628808L,611224414499977L,9101497296825313L,135525785782060767L,2017991596365393605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197232Inst : IEnumerable<long>
{
public static readonly long[] Value=A197232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197232.Bytes);
public long this[int i]=>Value[i];

public static A197232Inst Instance=new A197232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197233
{
public static readonly BigInteger[] Value={ 8L,186L,5355L,141210L,3710070L,98514881L,2633810897L,70009757794L,1862777323325L,49566883751088L,1318485619230845L,35084791882972069L,933492052284083925L,BigInteger.Parse("24835622437581060135"),BigInteger.Parse("660793443295539766640"),BigInteger.Parse("17581467273487795187534") };
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
public class A197233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197233Inst Instance=new A197233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197234
{
public static readonly BigInteger[] Value={ 13L,465L,24723L,1207249L,56349129L,2633810897L,126615582841L,6025045947229L,285872930194581L,13601246931224843L,646768759804113503L,BigInteger.Parse("30743940022418521003"),BigInteger.Parse("1461787203230841289843"),BigInteger.Parse("69503782128520679756365") };
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
public class A197234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197234Inst Instance=new A197234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197235
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,12L,12L,3L,5L,31L,55L,31L,5L,8L,79L,242L,242L,79L,8L,13L,186L,1178L,2117L,1178L,186L,13L,21L,465L,5355L,17759L,17759L,5355L,465L,21L,34L,1131L,24723L,141210L,249929L,141210L,24723L,1131L,34L,55L,2776L,116440L,1207249L,3710070L,3710070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197235Inst : IEnumerable<long>
{
public static readonly long[] Value=A197235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197235.Bytes);
public long this[int i]=>Value[i];

public static A197235Inst Instance=new A197235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197236
{
public static readonly long[] Value={ 1L,2L,15L,231L,10649L,1209990L,352842084L,271939715540L,541622294917014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197236Inst : IEnumerable<long>
{
public static readonly long[] Value=A197236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197236.Bytes);
public long this[int i]=>Value[i];

public static A197236Inst Instance=new A197236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197237
{
public static readonly long[] Value={ 1L,5L,15L,46L,156L,507L,1637L,5338L,17401L,56648L,184384L,600287L,1954546L,6363740L,20718710L,67455328L,219621081L,715042212L,2328028685L,7579574414L,24677521267L,80344901649L,261586345777L,851670870944L,2772863697333L,9027869180467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197237Inst : IEnumerable<long>
{
public static readonly long[] Value=A197237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197237.Bytes);
public long this[int i]=>Value[i];

public static A197237Inst Instance=new A197237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197238
{
public static readonly long[] Value={ 1L,8L,46L,231L,1221L,6284L,32754L,170928L,888997L,4628482L,24105642L,125519823L,653563458L,3403159865L,17720701794L,92272812665L,480470439059L,2501848357281L,13027318240407L,67834213566454L,353217871857983L,1839232324012492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197238Inst : IEnumerable<long>
{
public static readonly long[] Value=A197238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197238.Bytes);
public long this[int i]=>Value[i];

public static A197238Inst Instance=new A197238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197239
{
public static readonly long[] Value={ 1L,18L,156L,1221L,10649L,89527L,750414L,6315333L,53202193L,448046100L,3771630940L,31755317844L,267372295449L,2251142411047L,18953791712561L,159583558349010L,1343626155668202L,11312793102525882L,95249224912654237L,801960149525766205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197239Inst : IEnumerable<long>
{
public static readonly long[] Value=A197239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197239.Bytes);
public long this[int i]=>Value[i];

public static A197239Inst Instance=new A197239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197240
{
public static readonly long[] Value={ 1L,37L,507L,6284L,89527L,1209990L,16248436L,220537819L,2991520965L,40512793371L,548735832406L,7434530776423L,100724219721520L,1364590772374292L,18486981607134199L,250455940483033208L,3393127984714324346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197240Inst : IEnumerable<long>
{
public static readonly long[] Value=A197240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197240.Bytes);
public long this[int i]=>Value[i];

public static A197240Inst Instance=new A197240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197241
{
public static readonly BigInteger[] Value={ 1L,73L,1637L,32754L,750414L,16248436L,352842084L,7724652441L,168523962450L,3676078979774L,80239901730427L,1751188373419046L,38215194111617673L,833983549405202297L,18200567290517388113UL,BigInteger.Parse("397200129894815516422") };
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
public class A197241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197241.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197241Inst Instance=new A197241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197242
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,8L,15L,8L,1L,1L,18L,46L,46L,18L,1L,1L,37L,156L,231L,156L,37L,1L,1L,73L,507L,1221L,1221L,507L,73L,1L,1L,151L,1637L,6284L,10649L,6284L,1637L,151L,1L,1L,306L,5338L,32754L,89527L,89527L,32754L,5338L,306L,1L,1L,621L,17401L,170928L,750414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197242Inst : IEnumerable<long>
{
public static readonly long[] Value=A197242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197242.Bytes);
public long this[int i]=>Value[i];

public static A197242Inst Instance=new A197242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197243
{
public static readonly long[] Value={ 1L,4L,3L,275L,5062L,405065L,48703999L,11304892092L,9455531359836L,13086658688226332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197243Inst : IEnumerable<long>
{
public static readonly long[] Value=A197243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197243.Bytes);
public long this[int i]=>Value[i];

public static A197243Inst Instance=new A197243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197244
{
public static readonly long[] Value={ 2L,4L,8L,16L,40L,80L,192L,400L,936L,1984L,4576L,9824L,22408L,48560L,109888L,239728L,539432L,1182432L,2649952L,5828544L,13024648L,28717648L,64040768L,141448528L,314965928L,696544000L,1549366240L,3429474848L,7622621832L,16883244016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197244Inst : IEnumerable<long>
{
public static readonly long[] Value=A197244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197244.Bytes);
public long this[int i]=>Value[i];

public static A197244Inst Instance=new A197244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197245
{
public static readonly long[] Value={ 1L,8L,3L,53L,110L,227L,1035L,2004L,7529L,20633L,53902L,172997L,474139L,1395792L,4009631L,11336881L,33563326L,95906965L,275694011L,796470870L,2294495057L,6647188965L,19110664400L,55033208033L,159018294491L,458707454692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197245Inst : IEnumerable<long>
{
public static readonly long[] Value=A197245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197245.Bytes);
public long this[int i]=>Value[i];

public static A197245Inst Instance=new A197245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197246
{
public static readonly long[] Value={ 1L,16L,53L,275L,780L,5713L,16773L,98870L,393913L,1869033L,8527840L,32730687L,177791439L,674100600L,3386483171L,13856198755L,66236228308L,289604893615L,1242844626331L,5912414575588L,24990706118619L,116867053171491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197246Inst : IEnumerable<long>
{
public static readonly long[] Value=A197246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197246.Bytes);
public long this[int i]=>Value[i];

public static A197246Inst Instance=new A197246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197247
{
public static readonly long[] Value={ 3L,40L,110L,780L,5062L,31276L,213912L,1244680L,8149652L,54813300L,363207297L,2334210952L,15099425049L,99496688244L,657733281792L,4291822021778L,27959094118746L,183056501656614L,1201021999376817L,7872982494463940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197247Inst : IEnumerable<long>
{
public static readonly long[] Value=A197247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197247.Bytes);
public long this[int i]=>Value[i];

public static A197247Inst Instance=new A197247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197248
{
public static readonly long[] Value={ 3L,80L,227L,5713L,31276L,405065L,3264225L,29975706L,324191969L,2687575073L,30493965518L,259733680667L,2634174755809L,25422825883256L,236887111563899L,2418154978600875L,22091513472216108L,220206294709791833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197248Inst : IEnumerable<long>
{
public static readonly long[] Value=A197248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197248.Bytes);
public long this[int i]=>Value[i];

public static A197248Inst Instance=new A197248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197249
{
public static readonly long[] Value={ 2L,192L,1035L,16773L,213912L,3264225L,48703999L,692974749L,9613268927L,144634486646L,2038308764828L,29317910548935L,416838295672468L,6110472912181664L,87970427980764925L,1247341042216025997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197249Inst : IEnumerable<long>
{
public static readonly long[] Value=A197249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197249.Bytes);
public long this[int i]=>Value[i];

public static A197249Inst Instance=new A197249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197250
{
public static readonly long[] Value={ 1L,2L,2L,1L,4L,1L,1L,8L,8L,1L,3L,16L,3L,16L,3L,3L,40L,53L,53L,40L,3L,2L,80L,110L,275L,110L,80L,2L,4L,192L,227L,780L,780L,227L,192L,4L,6L,400L,1035L,5713L,5062L,5713L,1035L,400L,6L,5L,936L,2004L,16773L,31276L,31276L,16773L,2004L,936L,5L,6L,1984L,7529L,98870L,213912L,405065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197250Inst : IEnumerable<long>
{
public static readonly long[] Value=A197250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197250.Bytes);
public long this[int i]=>Value[i];

public static A197250Inst Instance=new A197250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197251
{
public static readonly long[] Value={ 4L,0L,5L,4L,1L,2L,8L,9L,5L,5L,4L,0L,0L,0L,9L,1L,7L,9L,6L,9L,6L,0L,8L,2L,1L,7L,1L,5L,3L,1L,2L,4L,8L,1L,7L,2L,2L,7L,5L,4L,4L,8L,9L,0L,5L,2L,5L,2L,2L,8L,5L,8L,9L,2L,2L,1L,7L,0L,7L,1L,2L,8L,7L,3L,9L,0L,1L,9L,2L,8L,1L,7L,9L,3L,2L,9L,5L,7L,2L,7L,8L,2L,9L,8L,5L,1L,7L,6L,8L,9L,3L,3L,2L,2L,4L,9L,1L,8L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197251Inst : IEnumerable<long>
{
public static readonly long[] Value=A197251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197251.Bytes);
public long this[int i]=>Value[i];

public static A197251Inst Instance=new A197251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197252
{
public static readonly long[] Value={ 0L,2L,8L,0L,3L,7L,6L,3L,0L,0L,4L,5L,4L,9L,8L,0L,0L,3L,2L,3L,3L,1L,3L,5L,4L,8L,0L,4L,0L,4L,7L,2L,2L,1L,8L,2L,5L,3L,4L,4L,9L,2L,9L,2L,1L,5L,5L,4L,5L,5L,9L,3L,5L,1L,8L,6L,3L,3L,6L,0L,7L,3L,3L,8L,5L,5L,8L,9L,6L,1L,8L,6L,8L,0L,0L,5L,6L,7L,8L,4L,8L,3L,2L,1L,9L,5L,3L,7L,3L,5L,8L,9L,2L,9L,0L,1L,6L,9L,7L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197252Inst : IEnumerable<long>
{
public static readonly long[] Value=A197252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197252.Bytes);
public long this[int i]=>Value[i];

public static A197252Inst Instance=new A197252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197253
{
public static readonly long[] Value={ 2L,0L,5L,4L,8L,0L,4L,2L,1L,7L,1L,7L,7L,4L,3L,1L,8L,7L,0L,3L,5L,4L,1L,8L,4L,5L,3L,8L,4L,5L,8L,4L,8L,0L,0L,4L,4L,1L,0L,6L,7L,0L,2L,5L,7L,5L,2L,5L,4L,4L,4L,1L,2L,1L,3L,4L,8L,7L,1L,8L,9L,6L,7L,4L,2L,9L,1L,0L,3L,1L,2L,3L,5L,6L,2L,4L,4L,0L,2L,2L,3L,5L,8L,2L,1L,1L,7L,0L,4L,5L,6L,7L,9L,1L,4L,5L,3L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197253Inst : IEnumerable<long>
{
public static readonly long[] Value=A197253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197253.Bytes);
public long this[int i]=>Value[i];

public static A197253Inst Instance=new A197253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197254
{
public static readonly long[] Value={ 0L,1L,5L,7L,0L,6L,8L,4L,9L,5L,3L,1L,6L,2L,0L,0L,6L,5L,0L,5L,8L,1L,7L,7L,0L,3L,0L,2L,0L,8L,5L,2L,6L,0L,3L,6L,3L,9L,0L,0L,4L,1L,7L,7L,4L,8L,8L,0L,0L,3L,1L,2L,6L,3L,1L,0L,8L,5L,0L,9L,0L,7L,6L,7L,8L,4L,2L,7L,2L,2L,6L,1L,5L,7L,2L,8L,2L,6L,5L,4L,9L,2L,5L,7L,5L,8L,5L,7L,0L,8L,2L,0L,4L,1L,2L,7L,0L,4L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197254Inst : IEnumerable<long>
{
public static readonly long[] Value=A197254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197254.Bytes);
public long this[int i]=>Value[i];

public static A197254Inst Instance=new A197254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197255
{
public static readonly long[] Value={ 1L,3L,6L,4L,8L,5L,9L,2L,4L,6L,1L,8L,4L,1L,2L,4L,7L,5L,2L,0L,4L,3L,0L,8L,4L,0L,3L,0L,4L,1L,9L,3L,4L,9L,1L,5L,5L,2L,3L,7L,0L,3L,3L,2L,5L,9L,8L,3L,2L,2L,0L,0L,9L,1L,3L,8L,3L,4L,0L,0L,0L,0L,5L,7L,4L,2L,1L,6L,7L,9L,6L,3L,5L,0L,5L,1L,1L,0L,4L,4L,5L,0L,6L,9L,8L,4L,5L,0L,3L,6L,7L,3L,0L,6L,2L,5L,5L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197255Inst : IEnumerable<long>
{
public static readonly long[] Value=A197255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197255.Bytes);
public long this[int i]=>Value[i];

public static A197255Inst Instance=new A197255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197256
{
public static readonly long[] Value={ 0L,8L,4L,5L,3L,5L,2L,3L,0L,6L,6L,9L,1L,6L,3L,4L,4L,0L,0L,2L,2L,7L,6L,5L,2L,4L,4L,7L,8L,1L,1L,1L,9L,7L,3L,5L,1L,3L,3L,4L,3L,7L,7L,5L,2L,5L,1L,2L,2L,3L,5L,4L,8L,7L,9L,0L,6L,9L,2L,3L,1L,8L,0L,2L,1L,9L,2L,6L,0L,4L,3L,6L,8L,0L,1L,1L,6L,0L,4L,0L,8L,8L,9L,2L,9L,1L,8L,5L,8L,2L,6L,6L,3L,9L,1L,9L,3L,3L,3L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197256Inst : IEnumerable<long>
{
public static readonly long[] Value=A197256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197256.Bytes);
public long this[int i]=>Value[i];

public static A197256Inst Instance=new A197256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197257
{
public static readonly long[] Value={ 0L,5L,7L,7L,0L,1L,1L,3L,3L,6L,9L,3L,5L,6L,3L,9L,4L,1L,4L,2L,9L,6L,1L,8L,3L,7L,3L,9L,7L,8L,6L,8L,4L,3L,5L,2L,4L,2L,0L,1L,7L,7L,1L,0L,9L,8L,8L,9L,9L,1L,0L,0L,9L,5L,1L,6L,6L,9L,5L,5L,8L,9L,3L,4L,1L,2L,1L,4L,3L,4L,6L,1L,2L,1L,1L,9L,4L,7L,3L,0L,8L,8L,6L,5L,2L,4L,3L,1L,5L,7L,3L,0L,6L,4L,2L,1L,7L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197257Inst : IEnumerable<long>
{
public static readonly long[] Value=A197257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197257.Bytes);
public long this[int i]=>Value[i];

public static A197257Inst Instance=new A197257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197258
{
public static readonly long[] Value={ 0L,4L,1L,9L,6L,1L,4L,0L,5L,6L,7L,7L,5L,6L,5L,8L,5L,0L,8L,5L,6L,3L,0L,0L,3L,6L,1L,6L,5L,8L,7L,5L,4L,1L,2L,3L,6L,9L,2L,8L,2L,8L,5L,7L,1L,3L,6L,7L,0L,1L,3L,4L,1L,4L,0L,0L,9L,3L,9L,3L,3L,1L,9L,0L,6L,1L,8L,4L,6L,7L,5L,0L,3L,0L,8L,5L,6L,8L,4L,5L,1L,2L,1L,1L,7L,1L,0L,2L,9L,5L,9L,6L,4L,7L,4L,8L,9L,5L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197258Inst : IEnumerable<long>
{
public static readonly long[] Value=A197258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197258.Bytes);
public long this[int i]=>Value[i];

public static A197258Inst Instance=new A197258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197259
{
public static readonly long[] Value={ 3L,1L,9L,1L,6L,3L,6L,5L,2L,5L,3L,9L,0L,2L,1L,0L,8L,8L,3L,1L,1L,8L,1L,7L,3L,2L,2L,3L,0L,1L,5L,1L,6L,7L,1L,3L,0L,5L,9L,0L,8L,5L,5L,6L,0L,6L,7L,2L,2L,3L,0L,1L,5L,0L,2L,7L,0L,8L,6L,9L,1L,3L,1L,3L,2L,9L,5L,4L,8L,0L,5L,7L,1L,3L,6L,7L,6L,2L,4L,6L,4L,5L,7L,0L,4L,1L,5L,0L,2L,1L,1L,0L,2L,4L,0L,2L,2L,4L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197259Inst : IEnumerable<long>
{
public static readonly long[] Value=A197259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197259.Bytes);
public long this[int i]=>Value[i];

public static A197259Inst Instance=new A197259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197260
{
public static readonly long[] Value={ 8L,4L,8L,0L,6L,2L,0L,7L,8L,9L,8L,1L,4L,8L,1L,0L,0L,8L,0L,5L,2L,9L,4L,4L,3L,3L,8L,9L,9L,8L,4L,1L,8L,0L,8L,0L,0L,7L,3L,3L,6L,6L,2L,1L,3L,2L,6L,3L,1L,1L,2L,6L,4L,2L,8L,6L,0L,7L,1L,8L,1L,6L,3L,5L,7L,0L,2L,0L,0L,8L,2L,1L,2L,2L,8L,4L,7L,4L,2L,3L,4L,3L,4L,9L,1L,8L,9L,8L,0L,1L,7L,3L,1L,9L,5L,7L,2L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197260Inst : IEnumerable<long>
{
public static readonly long[] Value=A197260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197260.Bytes);
public long this[int i]=>Value[i];

public static A197260Inst Instance=new A197260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197261
{
public static readonly long[] Value={ 6L,5L,0L,2L,4L,0L,6L,1L,8L,2L,1L,7L,6L,1L,8L,1L,9L,2L,0L,9L,5L,5L,5L,5L,1L,7L,2L,7L,3L,4L,6L,7L,0L,5L,1L,4L,8L,8L,1L,6L,7L,2L,1L,1L,4L,3L,0L,9L,4L,0L,6L,0L,7L,6L,9L,4L,8L,4L,8L,6L,7L,4L,7L,8L,6L,7L,8L,6L,3L,3L,2L,9L,0L,5L,2L,3L,5L,6L,7L,7L,7L,5L,0L,5L,1L,8L,0L,1L,1L,8L,3L,8L,6L,6L,6L,8L,0L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197261Inst : IEnumerable<long>
{
public static readonly long[] Value=A197261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197261.Bytes);
public long this[int i]=>Value[i];

public static A197261Inst Instance=new A197261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197262
{
public static readonly long[] Value={ 2L,3L,2L,3L,1L,0L,4L,3L,1L,5L,9L,3L,4L,5L,8L,2L,0L,4L,7L,8L,4L,2L,9L,1L,7L,6L,3L,5L,0L,2L,3L,9L,4L,5L,0L,7L,9L,7L,2L,1L,8L,7L,9L,5L,1L,0L,5L,1L,9L,9L,5L,3L,9L,4L,3L,9L,4L,9L,8L,2L,5L,8L,9L,4L,7L,2L,2L,7L,7L,1L,1L,5L,9L,7L,1L,6L,0L,9L,3L,1L,9L,5L,2L,6L,3L,4L,0L,1L,4L,2L,0L,3L,1L,2L,3L,3L,0L,2L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197262Inst : IEnumerable<long>
{
public static readonly long[] Value=A197262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197262.Bytes);
public long this[int i]=>Value[i];

public static A197262Inst Instance=new A197262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197263
{
public static readonly long[] Value={ 1L,3L,6L,6L,5L,1L,1L,9L,2L,1L,7L,0L,5L,7L,2L,3L,9L,4L,9L,5L,6L,9L,7L,6L,0L,1L,7L,8L,8L,5L,9L,0L,5L,4L,6L,3L,2L,0L,0L,1L,1L,3L,9L,1L,7L,6L,8L,4L,9L,0L,6L,8L,5L,9L,4L,1L,9L,0L,6L,3L,5L,2L,4L,2L,8L,8L,8L,1L,0L,7L,0L,4L,0L,2L,7L,1L,2L,5L,0L,1L,5L,4L,4L,0L,3L,2L,2L,6L,1L,8L,6L,7L,9L,1L,7L,2L,3L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197263Inst : IEnumerable<long>
{
public static readonly long[] Value=A197263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197263.Bytes);
public long this[int i]=>Value[i];

public static A197263Inst Instance=new A197263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197264
{
public static readonly long[] Value={ 0L,9L,0L,9L,9L,0L,6L,1L,6L,4L,1L,2L,2L,7L,4L,9L,8L,3L,4L,6L,9L,5L,3L,8L,9L,3L,5L,3L,6L,1L,2L,8L,9L,9L,4L,3L,6L,8L,2L,4L,6L,8L,8L,8L,3L,9L,8L,8L,8L,1L,3L,3L,9L,4L,2L,5L,5L,6L,0L,0L,0L,0L,3L,8L,2L,8L,1L,1L,1L,9L,7L,5L,6L,7L,0L,0L,7L,3L,6L,3L,0L,1L,4L,5L,3L,0L,8L,1L,6L,2L,1L,4L,3L,9L,8L,0L,1L,8L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197264Inst : IEnumerable<long>
{
public static readonly long[] Value=A197264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197264.Bytes);
public long this[int i]=>Value[i];

public static A197264Inst Instance=new A197264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197265
{
public static readonly long[] Value={ 0L,6L,5L,2L,4L,6L,7L,8L,0L,1L,7L,9L,0L,3L,0L,4L,3L,3L,2L,3L,4L,3L,7L,0L,2L,1L,7L,9L,0L,8L,3L,8L,2L,0L,1L,3L,8L,9L,7L,9L,7L,7L,5L,4L,0L,8L,9L,3L,3L,2L,9L,5L,8L,2L,5L,1L,7L,2L,9L,1L,8L,2L,0L,8L,6L,8L,0L,3L,6L,7L,7L,3L,1L,1L,9L,6L,6L,5L,4L,8L,9L,7L,1L,6L,5L,8L,0L,3L,9L,5L,0L,2L,5L,3L,2L,6L,2L,9L,3L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197265Inst : IEnumerable<long>
{
public static readonly long[] Value=A197265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197265.Bytes);
public long this[int i]=>Value[i];

public static A197265Inst Instance=new A197265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197266
{
public static readonly long[] Value={ 0L,4L,9L,1L,9L,2L,7L,4L,8L,3L,1L,7L,9L,5L,6L,8L,9L,6L,8L,0L,3L,0L,4L,0L,8L,0L,3L,0L,7L,2L,9L,1L,7L,8L,9L,5L,9L,7L,0L,7L,7L,0L,4L,8L,5L,9L,6L,1L,8L,0L,0L,1L,0L,9L,6L,1L,5L,4L,9L,5L,1L,1L,3L,4L,1L,2L,4L,1L,2L,9L,4L,7L,6L,4L,9L,7L,8L,0L,8L,0L,8L,6L,2L,4L,2L,6L,1L,2L,1L,6L,2L,8L,5L,8L,0L,8L,1L,1L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197266Inst : IEnumerable<long>
{
public static readonly long[] Value=A197266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197266.Bytes);
public long this[int i]=>Value[i];

public static A197266Inst Instance=new A197266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197267
{
public static readonly long[] Value={ 6L,8L,2L,9L,8L,2L,6L,9L,9L,1L,6L,0L,0L,8L,1L,6L,8L,7L,9L,7L,7L,0L,8L,0L,8L,5L,5L,6L,2L,5L,3L,8L,7L,1L,7L,0L,7L,5L,1L,0L,3L,8L,8L,1L,6L,9L,0L,3L,2L,1L,8L,2L,3L,8L,0L,9L,1L,2L,8L,1L,5L,8L,6L,2L,4L,8L,7L,5L,0L,5L,7L,0L,1L,5L,0L,4L,3L,4L,5L,0L,0L,3L,5L,3L,9L,5L,1L,3L,2L,7L,6L,7L,9L,0L,3L,1L,2L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197267Inst : IEnumerable<long>
{
public static readonly long[] Value=A197267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197267.Bytes);
public long this[int i]=>Value[i];

public static A197267Inst Instance=new A197267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197268
{
public static readonly long[] Value={ 4L,5L,9L,9L,7L,5L,5L,3L,5L,4L,0L,5L,0L,9L,4L,0L,3L,2L,0L,6L,5L,1L,5L,0L,7L,5L,1L,6L,3L,0L,4L,7L,6L,8L,3L,2L,7L,2L,7L,0L,5L,9L,1L,6L,0L,4L,5L,9L,9L,1L,8L,0L,7L,7L,7L,9L,9L,0L,6L,9L,0L,4L,3L,4L,9L,1L,0L,3L,3L,0L,1L,7L,5L,1L,9L,6L,4L,5L,5L,8L,2L,2L,2L,9L,9L,3L,9L,0L,9L,8L,6L,4L,3L,5L,4L,0L,1L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197268Inst : IEnumerable<long>
{
public static readonly long[] Value=A197268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197268.Bytes);
public long this[int i]=>Value[i];

public static A197268Inst Instance=new A197268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197269
{
public static readonly long[] Value={ 3L,4L,2L,5L,6L,6L,4L,7L,6L,2L,7L,7L,5L,2L,2L,2L,4L,3L,6L,3L,6L,0L,3L,7L,7L,4L,5L,7L,7L,0L,8L,8L,5L,7L,1L,1L,6L,3L,4L,2L,6L,7L,2L,1L,5L,6L,2L,4L,3L,6L,3L,2L,1L,7L,7L,4L,3L,4L,4L,7L,7L,3L,3L,8L,2L,6L,7L,6L,2L,3L,6L,6L,5L,5L,6L,4L,0L,9L,8L,4L,5L,0L,0L,7L,5L,9L,4L,0L,0L,0L,4L,2L,6L,6L,0L,2L,9L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197269Inst : IEnumerable<long>
{
public static readonly long[] Value=A197269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197269.Bytes);
public long this[int i]=>Value[i];

public static A197269Inst Instance=new A197269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197270
{
public static readonly long[] Value={ 3L,0L,3L,8L,9L,0L,4L,1L,6L,4L,3L,4L,4L,2L,6L,1L,1L,6L,8L,6L,8L,0L,6L,5L,3L,3L,9L,5L,8L,6L,5L,2L,0L,4L,0L,2L,9L,4L,0L,7L,7L,8L,4L,6L,0L,7L,2L,6L,8L,8L,6L,8L,2L,0L,5L,2L,6L,4L,5L,7L,8L,4L,0L,0L,4L,7L,6L,0L,3L,5L,2L,6L,4L,5L,0L,0L,7L,5L,7L,2L,5L,9L,6L,5L,9L,4L,1L,5L,5L,4L,7L,6L,1L,0L,6L,9L,6L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197270Inst : IEnumerable<long>
{
public static readonly long[] Value=A197270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197270.Bytes);
public long this[int i]=>Value[i];

public static A197270Inst Instance=new A197270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197271
{
public static readonly BigInteger[] Value={ 5L,2L,5L,20L,100L,570L,3542L,23400L,161820L,1159400L,8544965L,64448228L,495508780L,3872033900L,30680401500L,246041115600L,1993987498284L,16310419381080L,134519771966180L,1117653277802000L,9347742311507600L,78652006531467930L,665393840873409150L,5657273782416664200L,BigInteger.Parse("48318619683648190500") };
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
public class A197271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A197271.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A197271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A197271Inst Instance=new A197271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197272
{
public static readonly long[] Value={ 3L,1L,3L,15L,95L,690L,5481L,46376L,411255L,3781635L,35791910L,346821930L,3427001253L,34425730640L,350732771160L,3617153918640L,37703805776935L,396716804816265L,4209161209968825L,44993046668984145L,484176486362971710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197272Inst : IEnumerable<long>
{
public static readonly long[] Value=A197272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197272.Bytes);
public long this[int i]=>Value[i];

public static A197272Inst Instance=new A197272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197273
{
public static readonly long[] Value={ 1L,9L,34L,627L,16890L,1276986L,209785488L,84453386767L,71088592371829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197273Inst : IEnumerable<long>
{
public static readonly long[] Value=A197273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197273.Bytes);
public long this[int i]=>Value[i];

public static A197273Inst Instance=new A197273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197274
{
public static readonly long[] Value={ 3L,9L,14L,29L,67L,134L,275L,583L,1210L,2511L,5245L,10926L,22745L,47405L,98774L,205765L,428731L,893294L,1861163L,3877815L,8079642L,16834247L,35074949L,73080470L,152266769L,317255517L,661018310L,1377265789L,2869604691L,5978971062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197274Inst : IEnumerable<long>
{
public static readonly long[] Value=A197274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197274.Bytes);
public long this[int i]=>Value[i];

public static A197274Inst Instance=new A197274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197275
{
public static readonly long[] Value={ 4L,14L,34L,92L,317L,888L,2626L,8078L,24103L,72107L,217970L,656610L,1975147L,5955136L,17950843L,54086244L,163025795L,491430743L,1481229421L,4464844849L,13458804609L,40569450638L,122290929298L,368632726282L,1111201586358L,3349591968789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197275Inst : IEnumerable<long>
{
public static readonly long[] Value=A197275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197275.Bytes);
public long this[int i]=>Value[i];

public static A197275Inst Instance=new A197275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197276
{
public static readonly long[] Value={ 5L,29L,92L,627L,2731L,11850L,57137L,276689L,1344992L,6445595L,30716245L,146763830L,705198523L,3392533967L,16288546542L,78114416927L,374644274789L,1797996141058L,8631814710395L,41433944954559L,198846557512440L,954242657026897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197276Inst : IEnumerable<long>
{
public static readonly long[] Value=A197276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197276.Bytes);
public long this[int i]=>Value[i];

public static A197276Inst Instance=new A197276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197277
{
public static readonly long[] Value={ 9L,67L,317L,2731L,16890L,114205L,886737L,6017949L,40918349L,290053910L,2074566978L,14599100959L,101671464178L,714232555115L,5052846176923L,35608078988237L,249861298059545L,1755724243450685L,12370064599008231L,87120870560445460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197277Inst : IEnumerable<long>
{
public static readonly long[] Value=A197277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197277.Bytes);
public long this[int i]=>Value[i];

public static A197277Inst Instance=new A197277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197278
{
public static readonly long[] Value={ 16L,134L,888L,11850L,114205L,1276986L,13500114L,135563958L,1464662469L,15975572837L,167590942240L,1768832921236L,19029812782209L,203511535493020L,2157669619156227L,22971322152723986L,245668877166018309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197278Inst : IEnumerable<long>
{
public static readonly long[] Value=A197278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197278.Bytes);
public long this[int i]=>Value[i];

public static A197278Inst Instance=new A197278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197279
{
public static readonly ulong[] Value={ 25L,275L,2626L,57137L,886737L,13500114L,209785488L,3332948197L,55701159000L,888511016495L,14113426224907L,227682122103328L,3670040705518361L,58842498077190676L,948189035889733725L,15294961470395061151UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197279Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A197279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197279.Bytes);
public ulong this[int i]=>Value[i];

public static A197279Inst Instance=new A197279Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197280
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,14L,14L,5L,9L,29L,34L,29L,9L,16L,67L,92L,92L,67L,16L,25L,134L,317L,627L,317L,134L,25L,39L,275L,888L,2731L,2731L,888L,275L,39L,64L,583L,2626L,11850L,16890L,11850L,2626L,583L,64L,105L,1210L,8078L,57137L,114205L,114205L,57137L,8078L,1210L,105L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197280Inst : IEnumerable<long>
{
public static readonly long[] Value=A197280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197280.Bytes);
public long this[int i]=>Value[i];

public static A197280Inst Instance=new A197280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197281
{
public static readonly long[] Value={ 2L,7L,3L,1L,7L,7L,2L,4L,4L,0L,3L,4L,0L,4L,1L,0L,3L,4L,3L,5L,1L,3L,8L,1L,8L,3L,1L,5L,4L,6L,0L,3L,4L,6L,5L,1L,8L,6L,8L,5L,3L,2L,4L,2L,4L,0L,1L,0L,9L,4L,6L,9L,6L,2L,7L,7L,0L,2L,1L,2L,7L,9L,8L,8L,8L,0L,1L,6L,2L,3L,6L,6L,0L,1L,7L,7L,8L,8L,4L,7L,1L,0L,3L,0L,4L,0L,7L,8L,8L,8L,4L,1L,5L,2L,3L,8L,2L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197281Inst : IEnumerable<long>
{
public static readonly long[] Value=A197281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197281.Bytes);
public long this[int i]=>Value[i];

public static A197281Inst Instance=new A197281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197282
{
public static readonly long[] Value={ 2L,4L,8L,2L,0L,2L,9L,3L,0L,5L,3L,6L,7L,1L,0L,5L,5L,1L,0L,9L,2L,9L,7L,9L,2L,1L,7L,3L,8L,9L,8L,0L,7L,3L,2L,1L,7L,3L,3L,4L,9L,4L,7L,5L,1L,3L,2L,5L,8L,2L,3L,9L,5L,5L,5L,9L,3L,4L,7L,5L,1L,8L,2L,3L,9L,5L,7L,8L,9L,0L,9L,7L,2L,7L,9L,5L,8L,9L,2L,3L,5L,6L,4L,4L,1L,7L,3L,6L,1L,2L,1L,1L,9L,9L,9L,7L,5L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197282Inst : IEnumerable<long>
{
public static readonly long[] Value=A197282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197282.Bytes);
public long this[int i]=>Value[i];

public static A197282Inst Instance=new A197282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197283
{
public static readonly long[] Value={ 5L,6L,9L,3L,4L,5L,9L,5L,6L,7L,0L,4L,0L,5L,4L,4L,9L,1L,2L,2L,5L,4L,7L,4L,0L,0L,3L,5L,6L,9L,6L,1L,5L,2L,8L,7L,3L,5L,1L,0L,1L,5L,8L,6L,7L,8L,9L,8L,6L,4L,7L,2L,3L,8L,0L,8L,2L,9L,2L,3L,8L,1L,8L,6L,4L,7L,2L,6L,5L,4L,0L,2L,2L,8L,9L,6L,7L,4L,2L,0L,9L,3L,8L,1L,6L,0L,3L,2L,1L,0L,6L,4L,0L,9L,3L,0L,4L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197283Inst : IEnumerable<long>
{
public static readonly long[] Value=A197283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197283.Bytes);
public long this[int i]=>Value[i];

public static A197283Inst Instance=new A197283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197284
{
public static readonly long[] Value={ 4L,8L,0L,7L,8L,7L,5L,9L,8L,2L,7L,9L,7L,1L,6L,9L,5L,2L,9L,0L,4L,8L,1L,9L,9L,1L,3L,7L,2L,7L,2L,5L,3L,5L,1L,0L,8L,1L,4L,6L,8L,1L,3L,4L,5L,3L,5L,8L,8L,3L,6L,7L,4L,7L,3L,8L,1L,4L,2L,7L,0L,6L,8L,2L,7L,7L,7L,5L,0L,5L,4L,8L,8L,6L,4L,3L,5L,7L,5L,6L,7L,3L,2L,2L,2L,7L,7L,9L,2L,1L,5L,2L,6L,5L,4L,2L,1L,9L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197284Inst : IEnumerable<long>
{
public static readonly long[] Value=A197284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197284.Bytes);
public long this[int i]=>Value[i];

public static A197284Inst Instance=new A197284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197285
{
public static readonly long[] Value={ 4L,0L,9L,7L,8L,0L,0L,0L,6L,7L,3L,3L,9L,4L,5L,9L,4L,1L,3L,9L,5L,7L,6L,8L,7L,7L,6L,3L,6L,5L,5L,0L,3L,9L,7L,1L,7L,2L,5L,8L,9L,2L,1L,1L,7L,0L,4L,0L,7L,6L,3L,9L,7L,0L,5L,4L,3L,4L,2L,1L,3L,3L,3L,7L,6L,6L,0L,2L,7L,9L,7L,5L,2L,0L,1L,4L,3L,5L,9L,1L,0L,9L,7L,9L,8L,7L,3L,5L,6L,5L,1L,8L,2L,3L,0L,8L,8L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197285Inst : IEnumerable<long>
{
public static readonly long[] Value=A197285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197285.Bytes);
public long this[int i]=>Value[i];

public static A197285Inst Instance=new A197285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197286
{
public static readonly long[] Value={ 3L,5L,5L,8L,1L,3L,9L,9L,1L,8L,4L,9L,5L,2L,3L,2L,2L,8L,6L,2L,9L,3L,4L,2L,4L,4L,3L,7L,5L,4L,0L,0L,9L,5L,5L,9L,1L,0L,2L,9L,1L,3L,9L,5L,4L,6L,4L,1L,9L,1L,6L,9L,8L,2L,2L,8L,2L,6L,2L,7L,5L,4L,9L,8L,1L,3L,2L,6L,5L,9L,1L,4L,5L,7L,3L,8L,1L,4L,4L,6L,2L,2L,0L,8L,6L,1L,9L,6L,7L,5L,0L,1L,4L,9L,2L,6L,8L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197286Inst : IEnumerable<long>
{
public static readonly long[] Value=A197286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197286.Bytes);
public long this[int i]=>Value[i];

public static A197286Inst Instance=new A197286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197287
{
public static readonly long[] Value={ 2L,8L,1L,2L,2L,6L,9L,7L,5L,6L,8L,6L,2L,0L,2L,8L,3L,5L,2L,4L,7L,0L,0L,9L,2L,3L,1L,9L,9L,3L,4L,1L,0L,9L,0L,6L,5L,4L,2L,9L,2L,4L,6L,3L,7L,1L,1L,1L,0L,3L,6L,6L,4L,1L,9L,3L,7L,3L,6L,8L,7L,0L,1L,9L,5L,0L,7L,4L,5L,9L,2L,1L,6L,3L,6L,3L,8L,1L,2L,6L,9L,8L,8L,0L,3L,1L,3L,7L,6L,6L,5L,1L,2L,7L,7L,1L,2L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197287Inst : IEnumerable<long>
{
public static readonly long[] Value=A197287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197287.Bytes);
public long this[int i]=>Value[i];

public static A197287Inst Instance=new A197287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197288
{
public static readonly long[] Value={ 2L,5L,4L,5L,9L,6L,5L,2L,2L,5L,2L,8L,1L,5L,6L,4L,7L,3L,1L,2L,9L,5L,9L,7L,0L,4L,6L,5L,7L,5L,6L,9L,7L,9L,9L,7L,2L,8L,4L,1L,2L,5L,9L,9L,9L,0L,1L,6L,4L,1L,6L,9L,9L,1L,7L,3L,3L,9L,5L,8L,9L,7L,2L,6L,5L,1L,2L,5L,7L,5L,8L,8L,4L,2L,2L,3L,5L,0L,9L,9L,6L,0L,2L,1L,0L,3L,6L,4L,1L,9L,8L,2L,9L,5L,2L,9L,7L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197288Inst : IEnumerable<long>
{
public static readonly long[] Value=A197288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197288.Bytes);
public long this[int i]=>Value[i];

public static A197288Inst Instance=new A197288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197289
{
public static readonly long[] Value={ 2L,3L,2L,6L,3L,6L,4L,7L,7L,0L,8L,0L,3L,2L,6L,3L,4L,9L,8L,1L,9L,2L,2L,6L,9L,2L,0L,1L,8L,9L,0L,3L,3L,9L,2L,9L,9L,8L,4L,8L,0L,7L,3L,7L,1L,1L,6L,1L,9L,4L,6L,7L,1L,0L,7L,7L,4L,7L,8L,1L,3L,1L,3L,8L,4L,2L,3L,3L,1L,4L,4L,6L,8L,0L,2L,5L,1L,7L,8L,8L,1L,7L,5L,1L,9L,2L,9L,6L,5L,6L,0L,1L,7L,7L,6L,2L,8L,4L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197289Inst : IEnumerable<long>
{
public static readonly long[] Value=A197289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197289.Bytes);
public long this[int i]=>Value[i];

public static A197289Inst Instance=new A197289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197290
{
public static readonly long[] Value={ 4L,8L,6L,8L,2L,4L,8L,8L,2L,0L,1L,2L,6L,5L,0L,8L,9L,5L,4L,0L,4L,4L,1L,2L,6L,4L,0L,5L,3L,3L,2L,3L,5L,9L,2L,9L,6L,2L,0L,7L,4L,8L,1L,6L,9L,6L,8L,2L,4L,7L,8L,1L,0L,8L,1L,2L,6L,1L,6L,5L,2L,1L,1L,2L,6L,6L,2L,8L,9L,5L,2L,0L,6L,1L,8L,9L,4L,0L,1L,2L,0L,5L,1L,2L,8L,9L,0L,8L,4L,5L,3L,9L,3L,2L,1L,2L,9L,0L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197290Inst : IEnumerable<long>
{
public static readonly long[] Value=A197290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197290.Bytes);
public long this[int i]=>Value[i];

public static A197290Inst Instance=new A197290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197291
{
public static readonly long[] Value={ 4L,2L,4L,0L,3L,1L,0L,3L,9L,4L,9L,0L,7L,4L,0L,5L,0L,4L,0L,2L,6L,4L,7L,2L,1L,6L,9L,4L,9L,9L,2L,0L,9L,0L,4L,0L,0L,3L,6L,6L,8L,3L,1L,0L,6L,6L,3L,1L,5L,5L,6L,3L,2L,1L,4L,3L,0L,3L,5L,9L,0L,8L,1L,7L,8L,5L,1L,0L,0L,4L,1L,0L,6L,1L,4L,2L,3L,7L,1L,1L,7L,1L,7L,4L,5L,9L,4L,9L,0L,0L,8L,6L,5L,9L,7L,8L,6L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197291Inst : IEnumerable<long>
{
public static readonly long[] Value=A197291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197291.Bytes);
public long this[int i]=>Value[i];

public static A197291Inst Instance=new A197291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197292
{
public static readonly long[] Value={ 3L,6L,9L,0L,4L,9L,5L,7L,2L,5L,9L,8L,0L,3L,0L,1L,6L,7L,6L,7L,2L,3L,5L,5L,1L,5L,3L,3L,9L,2L,8L,4L,5L,6L,8L,0L,0L,2L,3L,3L,4L,9L,2L,1L,5L,1L,3L,3L,8L,1L,0L,8L,8L,2L,2L,2L,5L,5L,1L,3L,0L,6L,9L,1L,4L,4L,5L,7L,0L,1L,1L,2L,9L,9L,2L,4L,5L,4L,2L,6L,4L,6L,7L,1L,1L,3L,9L,0L,4L,2L,8L,9L,5L,3L,9L,0L,2L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197292Inst : IEnumerable<long>
{
public static readonly long[] Value=A197292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197292.Bytes);
public long this[int i]=>Value[i];

public static A197292Inst Instance=new A197292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197293
{
public static readonly long[] Value={ 3L,2L,5L,1L,2L,0L,3L,0L,9L,1L,0L,8L,8L,0L,9L,0L,9L,6L,0L,4L,7L,7L,7L,7L,5L,8L,6L,3L,6L,7L,3L,3L,5L,2L,5L,7L,4L,4L,0L,8L,3L,6L,0L,5L,7L,1L,5L,4L,7L,0L,3L,0L,3L,8L,4L,7L,4L,2L,4L,3L,3L,7L,3L,9L,3L,3L,9L,3L,1L,6L,6L,4L,5L,2L,6L,1L,7L,8L,3L,8L,8L,7L,5L,2L,5L,9L,0L,0L,5L,9L,1L,8L,4L,9L,0L,4L,3L,3L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197293Inst : IEnumerable<long>
{
public static readonly long[] Value=A197293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197293.Bytes);
public long this[int i]=>Value[i];

public static A197293Inst Instance=new A197293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197294
{
public static readonly long[] Value={ 2L,9L,0L,1L,0L,8L,8L,4L,1L,7L,7L,1L,7L,9L,3L,8L,3L,8L,9L,6L,9L,3L,4L,0L,7L,8L,6L,1L,4L,0L,4L,6L,7L,1L,5L,8L,7L,3L,3L,0L,7L,5L,3L,0L,1L,6L,2L,3L,0L,3L,3L,9L,8L,2L,0L,4L,7L,3L,1L,3L,6L,3L,5L,2L,6L,7L,1L,3L,5L,2L,1L,0L,8L,9L,9L,3L,2L,8L,2L,6L,8L,1L,8L,0L,6L,6L,8L,0L,8L,3L,0L,8L,0L,6L,9L,5L,3L,2L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197294Inst : IEnumerable<long>
{
public static readonly long[] Value=A197294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197294.Bytes);
public long this[int i]=>Value[i];

public static A197294Inst Instance=new A197294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197295
{
public static readonly long[] Value={ 1L,6L,4L,5L,6L,3L,8L,0L,7L,2L,7L,9L,3L,5L,6L,6L,8L,7L,8L,2L,4L,4L,0L,5L,9L,7L,8L,5L,5L,1L,8L,8L,8L,5L,7L,9L,0L,0L,9L,1L,1L,9L,6L,3L,4L,1L,0L,0L,0L,7L,3L,6L,1L,0L,7L,9L,2L,9L,5L,0L,9L,5L,0L,8L,8L,4L,4L,0L,9L,3L,4L,1L,6L,0L,9L,4L,4L,5L,6L,1L,0L,1L,3L,6L,4L,0L,0L,3L,9L,6L,2L,5L,2L,7L,9L,2L,1L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197295Inst : IEnumerable<long>
{
public static readonly long[] Value=A197295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197295.Bytes);
public long this[int i]=>Value[i];

public static A197295Inst Instance=new A197295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197296
{
public static readonly long[] Value={ 1L,1L,6L,1L,5L,5L,2L,1L,5L,7L,9L,6L,7L,2L,9L,1L,0L,2L,3L,9L,2L,1L,4L,5L,8L,8L,1L,7L,5L,1L,1L,9L,7L,2L,5L,3L,9L,8L,6L,0L,9L,3L,9L,7L,5L,5L,2L,5L,9L,9L,7L,6L,9L,7L,1L,9L,7L,4L,9L,1L,2L,9L,4L,7L,3L,6L,1L,3L,8L,5L,5L,7L,9L,8L,5L,8L,0L,4L,6L,5L,9L,7L,6L,3L,1L,7L,0L,0L,7L,1L,0L,1L,5L,6L,1L,6L,5L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197296Inst : IEnumerable<long>
{
public static readonly long[] Value=A197296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197296.Bytes);
public long this[int i]=>Value[i];

public static A197296Inst Instance=new A197296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197297
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,29L,37L,41L,53L,59L,97L,127L,137L,149L,191L,223L,307L,331L,337L,347L,419L,541L,557L,809L,967L,1009L,1213L,1277L,1399L,1409L,1423L,1973L,2203L,2237L,2591L,2609L,2617L,2633L,2647L,2657L,3163L,3299L,4861L,4871L,4889L,4903L,4931L,5381L,7411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197297Inst : IEnumerable<long>
{
public static readonly long[] Value=A197297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197297.Bytes);
public long this[int i]=>Value[i];

public static A197297Inst Instance=new A197297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197298
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,43L,47L,59L,73L,97L,107L,109L,139L,179L,233L,263L,277L,283L,337L,347L,409L,419L,547L,643L,683L,809L,811L,821L,823L,863L,983L,991L,997L,1031L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197298Inst : IEnumerable<long>
{
public static readonly long[] Value=A197298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197298.Bytes);
public long this[int i]=>Value[i];

public static A197298Inst Instance=new A197298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197299
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,23L,31L,37L,41L,43L,47L,53L,59L,67L,73L,83L,89L,101L,103L,137L,163L,167L,179L,197L,211L,223L,239L,251L,277L,331L,379L,397L,431L,463L,467L,521L,577L,593L,601L,613L,617L,719L,809L,881L,919L,967L,1091L,1123L,1129L,1237L,1249L,1289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197299Inst : IEnumerable<long>
{
public static readonly long[] Value=A197299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197299.Bytes);
public long this[int i]=>Value[i];

public static A197299Inst Instance=new A197299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197300
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,47L,59L,61L,67L,71L,89L,97L,109L,137L,139L,167L,173L,191L,223L,229L,239L,241L,269L,271L,293L,311L,331L,347L,367L,401L,431L,433L,457L,503L,509L,571L,577L,661L,709L,719L,733L,739L,797L,911L,919L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197300Inst : IEnumerable<long>
{
public static readonly long[] Value=A197300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197300.Bytes);
public long this[int i]=>Value[i];

public static A197300Inst Instance=new A197300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197301
{
public static readonly long[] Value={ 1L,7L,31L,639L,27709L,2533633L,638181656L,388800452625L,561392899488562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197301Inst : IEnumerable<long>
{
public static readonly long[] Value=A197301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197301.Bytes);
public long this[int i]=>Value[i];

public static A197301Inst Instance=new A197301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197302
{
public static readonly long[] Value={ 2L,10L,31L,98L,344L,1139L,3750L,12470L,41479L,137872L,458412L,1524061L,5066480L,16842888L,55992885L,186143874L,618820898L,2057222809L,6839076870L,22735974296L,75583965757L,251272978516L,835337355004L,2777013682031L,9231964714182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197302Inst : IEnumerable<long>
{
public static readonly long[] Value=A197302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197302.Bytes);
public long this[int i]=>Value[i];

public static A197302Inst Instance=new A197302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197303
{
public static readonly long[] Value={ 3L,23L,98L,639L,3181L,15930L,85087L,450159L,2373372L,12475923L,65599353L,345356968L,1818230847L,9570445721L,50371708666L,265125975409L,1395500272249L,7345271614306L,38661877327141L,203496642084359L,1071104859201058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197303Inst : IEnumerable<long>
{
public static readonly long[] Value=A197303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197303.Bytes);
public long this[int i]=>Value[i];

public static A197303Inst Instance=new A197303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A197304
{
public static readonly long[] Value={ 5L,57L,344L,3181L,27709L,207538L,1711736L,14233577L,115744195L,943877937L,7722480242L,63119151256L,515801027829L,4215541002540L,34452043410657L,281566682942645L,2301175324848852L,18806797415174573L,153702262527792157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A197304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A197304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A197304Inst : IEnumerable<long>
{
public static readonly long[] Value=A197304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A197304.Bytes);
public long this[int i]=>Value[i];

public static A197304Inst Instance=new A197304Inst();

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