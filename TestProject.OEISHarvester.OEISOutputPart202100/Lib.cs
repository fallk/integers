using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278417
{
public static readonly long[] Value={ 0L,2L,14L,78L,388L,1810L,8106L,35294L,150536L,632034L,2620870L,10759342L,43804812L,177105266L,711809378L,2846259390L,11330543632L,44929049794L,177540878718L,699402223118L,2747583822740L,10766828545746L,42095796462874L,164244726238366L,639620518118424L,2486558615814050L,9651161613824822L,37403957244654702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278417Inst : IEnumerable<long>
{
public static readonly long[] Value=A278417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278417.Bytes);
public long this[int i]=>Value[i];

public static A278417Inst Instance=new A278417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278418
{
public static readonly long[] Value={ 1L,2L,4L,10L,28L,31L,32L,38L,68L,134L,158L,254L,311L,337L,392L,874L,2747L,3502L,4735L,6142L,14140L,17095L,20066L,21104L,26743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278418Inst : IEnumerable<long>
{
public static readonly long[] Value=A278418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278418.Bytes);
public long this[int i]=>Value[i];

public static A278418Inst Instance=new A278418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278419
{
public static readonly long[] Value={ 1L,0L,2L,7L,2L,9L,4L,2L,6L,3L,8L,6L,0L,1L,5L,0L,7L,4L,8L,9L,7L,6L,6L,2L,4L,8L,4L,6L,8L,4L,5L,7L,4L,3L,2L,8L,9L,7L,8L,9L,5L,7L,4L,1L,7L,0L,4L,1L,4L,3L,4L,9L,5L,9L,1L,9L,0L,3L,5L,9L,9L,5L,3L,8L,6L,4L,0L,2L,0L,6L,6L,1L,6L,2L,5L,8L,1L,8L,3L,5L,0L,2L,5L,5L,0L,8L,2L,1L,6L,7L,3L,0L,7L,2L,3L,6L,2L,6L,9L,7L,5L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278419Inst : IEnumerable<long>
{
public static readonly long[] Value=A278419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278419.Bytes);
public long this[int i]=>Value[i];

public static A278419Inst Instance=new A278419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278452
{
public static readonly long[] Value={ 1L,4L,7L,11L,15L,19L,23L,28L,33L,37L,42L,48L,53L,58L,64L,69L,75L,80L,86L,92L,97L,103L,109L,115L,121L,127L,133L,139L,146L,152L,158L,165L,171L,177L,184L,190L,197L,203L,210L,216L,223L,230L,236L,243L,250L,256L,263L,270L,277L,284L,290L,297L,304L,311L,318L,325L,332L,339L,346L,353L,360L,367L,375L,382L,389L,396L,403L,410L,418L,425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278452Inst : IEnumerable<long>
{
public static readonly long[] Value=A278452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278452.Bytes);
public long this[int i]=>Value[i];

public static A278452Inst Instance=new A278452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278453
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,12L,15L,17L,19L,22L,25L,27L,30L,33L,35L,38L,41L,44L,47L,50L,53L,56L,59L,62L,65L,68L,71L,75L,78L,81L,84L,88L,91L,94L,98L,101L,104L,108L,111L,114L,118L,121L,125L,128L,132L,135L,139L,142L,146L,149L,153L,157L,160L,164L,167L,171L,175L,178L,182L,186L,189L,193L,197L,201L,204L,208L,212L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278453Inst : IEnumerable<long>
{
public static readonly long[] Value=A278453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278453.Bytes);
public long this[int i]=>Value[i];

public static A278453Inst Instance=new A278453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278454
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,43L,61L,67L,71L,83L,101L,107L,131L,139L,151L,157L,199L,211L,229L,257L,263L,269L,293L,317L,467L,523L,541L,613L,619L,643L,769L,829L,1031L,1061L,1091L,1163L,1181L,1223L,1637L,1667L,2053L,2131L,2179L,2311L,2341L,3079L,3109L,3229L,3271L,4099L,4133L,4139L,4157L,4253L,4637L,8209L,8221L,8263L,8293L,8461L,9283L,9829L,9859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278454Inst : IEnumerable<long>
{
public static readonly long[] Value=A278454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278454.Bytes);
public long this[int i]=>Value[i];

public static A278454Inst Instance=new A278454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278455
{
public static readonly BigInteger[] Value={ 3L,7L,23L,61L,317L,829L,274973L,1844867L,29363357L,275684009603L,2252075497694851L,1155173580104541827L,BigInteger.Parse("155838096186773789746819"),BigInteger.Parse("649037426474450432457432557949469"),BigInteger.Parse("348449144376078413060946030467563206480413") };
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
public class A278455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278455Inst Instance=new A278455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278456
{
public static readonly BigInteger[] Value={ 1L,2L,50L,1954L,56864L,1532496L,42238426L,1178422563L,32890293494L,917103556607L,25552076570350L,711923354658732L,19838824712825618L,552851181380560869L,15406086995815163663UL,BigInteger.Parse("429312063890812931103"),BigInteger.Parse("11963383230714027535776"),BigInteger.Parse("333377000620725693771782") };
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
public class A278456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278456Inst Instance=new A278456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278457
{
public static readonly long[] Value={ 1L,2L,2L,7L,11L,6L,30L,65L,59L,22L,143L,397L,492L,318L,90L,728L,2471L,3857L,3430L,1728L,394L,3876L,15572L,29255L,32728L,22886L,9461L,1806L,21318L,99009L,217323L,291456L,257001L,148626L,52133L,8558L,120175L,633765L,1591231L,2481597L,2622445L,1918665L,947740L,288812L,41586L,690690L,4078360L,11527318L,20467755L,25114375L,22043890L,13821764L,5964728L,1607198L,206098L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278457Inst : IEnumerable<long>
{
public static readonly long[] Value=A278457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278457.Bytes);
public long this[int i]=>Value[i];

public static A278457Inst Instance=new A278457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278458
{
public static readonly long[] Value={ 1L,2L,2L,9L,15L,8L,64L,156L,144L,52L,625L,2050L,2675L,1730L,472L,7776L,32430L,55000L,50310L,25108L,5504L,117649L,599319L,1258775L,1484245L,1052184L,428036L,78416L,2097152L,12669496L,31902416L,46103680L,42064736L,24421096L,8389552L,1320064L,43046721L,301574340L,888996066L,1524644856L,1698413409L,1269814980L,625219644L,185935104L,25637824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278458Inst : IEnumerable<long>
{
public static readonly long[] Value=A278458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278458.Bytes);
public long this[int i]=>Value[i];

public static A278458Inst Instance=new A278458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278459
{
public static readonly BigInteger[] Value={ 1L,2L,10L,66L,466L,3458L,26650L,211458L,1716642L,14193282L,119115818L,1012129602L,8690293618L,75283480834L,657206992954L,5775816653314L,51060139789122L,453749755736834L,4051091496955978L,36319665678928962L,326850292861873426L,2951487063152265858L,BigInteger.Parse("26735348244277012570") };
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
public class A278459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278459Inst Instance=new A278459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278460
{
public static readonly BigInteger[] Value={ 1L,2L,10L,66L,504L,4008L,32834L,275608L,2360480L,20556620L,181529552L,1621938126L,14637043030L,133227981608L,1221707669122L,11276264756890L,104678045392986L,976696485890714L,9154664125402120L,86159716204843096L,813905566526799242L,7714432262247963256L,BigInteger.Parse("73344196288917825312") };
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
public class A278460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278460Inst Instance=new A278460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278461
{
public static readonly BigInteger[] Value={ 1L,2L,10L,66L,490L,3898L,32482L,279882L,2473362L,22294194L,204174842L,1894462354L,17771064186L,168254374890L,1605751354066L,15431016952730L,149191682979874L,1450182228623458L,14163576408858346L,138924886089370082L,1367918804901854218L,13516246001650813338UL,BigInteger.Parse("133977227356098512834") };
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
public class A278461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278461Inst Instance=new A278461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278462
{
public static readonly BigInteger[] Value={ 1L,2L,10L,66L,504L,4148L,35794L,319384L,2922472L,27273568L,258591700L,2483951402L,24121423518L,236417231844L,2335648036770L,23234567806722L,232536604918010L,2339766365713070L,23655013692855212L,240175288588925992L,2447961627258995826L,BigInteger.Parse("25037715732340569328"),BigInteger.Parse("256899046844874628732") };
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
public class A278462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278462Inst Instance=new A278462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278463
{
public static readonly long[] Value={ 1L,2L,2L,3L,9L,4L,4L,36L,44L,12L,5L,110L,355L,250L,48L,6L,300L,2010L,3480L,1644L,240L,7L,777L,9625L,32235L,35728L,12348L,1440L,8L,1960L,42056L,242200L,498512L,390880L,104544L,10080L,9L,4860L,173754L,1605744L,5466321L,7745220L,4581036L,986256L,80640L,10L,11880L,691620L,9807840L,51506490L,117711720L,123330680L,57537360L,10265760L,725760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278463Inst : IEnumerable<long>
{
public static readonly long[] Value=A278463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278463.Bytes);
public long this[int i]=>Value[i];

public static A278463Inst Instance=new A278463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278464
{
public static readonly long[] Value={ 0L,1L,5L,17L,53L,145L,385L,957L,2333L,5493L,12741L,28941L,65049L,144225L,317229L,691457L,1497901L,3224145L,6906969L,14726701L,31282421L,66211253L,139720445L,294007373L,617154865L,1292516577L,2701451621L,5635565761L,11736442005L,24403092657L,50666528209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278464Inst : IEnumerable<long>
{
public static readonly long[] Value=A278464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278464.Bytes);
public long this[int i]=>Value[i];

public static A278464Inst Instance=new A278464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278465
{
public static readonly long[] Value={ 2L,4L,10L,12L,14L,20L,22L,24L,38L,40L,42L,44L,48L,50L,52L,54L,56L,58L,62L,64L,66L,68L,76L,80L,84L,90L,94L,98L,104L,108L,112L,142L,144L,150L,152L,154L,160L,162L,170L,172L,178L,180L,182L,184L,188L,190L,192L,194L,198L,202L,204L,206L,208L,212L,214L,216L,220L,222L,224L,226L,230L,232L,234L,240L,242L,244L,246L,250L,252L,254L,256L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278465Inst : IEnumerable<long>
{
public static readonly long[] Value=A278465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278465.Bytes);
public long this[int i]=>Value[i];

public static A278465Inst Instance=new A278465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278466
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1100L,1L,111100L,1L,11111100L,1001L,1111100000L,1111L,111111100000L,1111L,11111111100100L,1L,1111111111111100L,11001001L,111111111000000000L,11111111L,11111111111001001100UL,1L,BigInteger.Parse("1111111111111111111100"),1101011001L,BigInteger.Parse("111111111111100010000000"),1010111111L };
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
public class A278466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278466Inst Instance=new A278466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278467
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10000L,1111L,1000000L,111111L,100100000L,11111L,11110000000L,1111111L,1111000000000L,100111111111L,100000000000000L,11111111111111L,10010011000000000L,111111111L,1111111100000000000L,110010011111111111L,BigInteger.Parse("100000000000000000000") };
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
public class A278467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278467Inst Instance=new A278467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278500
{
public static readonly long[] Value={ 1L,2L,0L,2L,0L,1L,0L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,3L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278500Inst : IEnumerable<long>
{
public static readonly long[] Value=A278500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278500.Bytes);
public long this[int i]=>Value[i];

public static A278500Inst Instance=new A278500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278501
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,4L,8L,6L,2L,6L,12L,6L,4L,8L,16L,6L,2L,12L,12L,6L,12L,6L,6L,4L,24L,6L,12L,30L,8L,16L,32L,6L,2L,6L,36L,12L,12L,6L,6L,12L,24L,30L,12L,6L,6L,6L,4L,24L,48L,12L,6L,12L,12L,30L,8L,24L,24L,6L,60L,6L,16L,32L,64L,6L,2L,30L,12L,6L,36L,30L,12L,12L,72L,6L,12L,6L,6L,30L,12L,24L,48L,6L,30L,12L,60L,6L,6L,6L,24L,60L,12L,6L,4L,6L,24L,48L,96L,12L,12L,6L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278501Inst : IEnumerable<long>
{
public static readonly long[] Value=A278501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278501.Bytes);
public long this[int i]=>Value[i];

public static A278501Inst Instance=new A278501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278502
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,6L,2L,4L,6L,6L,2L,8L,12L,6L,4L,6L,12L,6L,2L,12L,30L,8L,12L,6L,6L,4L,16L,24L,12L,12L,6L,12L,30L,6L,2L,36L,30L,12L,30L,6L,8L,12L,24L,60L,24L,6L,6L,60L,4L,16L,12L,30L,24L,12L,12L,12L,6L,32L,48L,24L,36L,30L,12L,30L,60L,6L,2L,60L,30L,36L,30L,6L,12L,30L,72L,60L,60L,6L,8L,210L,12L,24L,12L,24L,60L,24L,60L,6L,6L,48L,120L,72L,30L,60L,4L,30L,16L,12L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278502Inst : IEnumerable<long>
{
public static readonly long[] Value=A278502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278502.Bytes);
public long this[int i]=>Value[i];

public static A278502Inst Instance=new A278502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278503
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,13L,9L,11L,6L,19L,15L,21L,17L,8L,27L,25L,37L,33L,23L,10L,39L,31L,51L,55L,45L,29L,12L,49L,43L,73L,85L,75L,57L,35L,14L,63L,61L,99L,121L,111L,97L,69L,41L,16L,79L,67L,127L,151L,159L,145L,115L,81L,47L,18L,91L,87L,163L,193L,211L,199L,171L,135L,93L,53L,20L,109L,103L,187L,247L,271L,267L,243L,205L,157L,105L,59L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278503Inst : IEnumerable<long>
{
public static readonly long[] Value=A278503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278503.Bytes);
public long this[int i]=>Value[i];

public static A278503Inst Instance=new A278503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278504
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,10L,4L,15L,8L,21L,9L,28L,7L,36L,12L,45L,14L,55L,11L,66L,13L,78L,20L,91L,17L,105L,16L,120L,27L,136L,23L,153L,19L,171L,35L,190L,18L,210L,22L,231L,44L,253L,30L,276L,26L,300L,54L,325L,29L,351L,24L,378L,65L,406L,25L,435L,34L,465L,77L,496L,38L,528L,37L,561L,90L,595L,47L,630L,43L,666L,104L,703L,31L,741L,33L,780L,119L,820L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278504Inst : IEnumerable<long>
{
public static readonly long[] Value=A278504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278504.Bytes);
public long this[int i]=>Value[i];

public static A278504Inst Instance=new A278504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278505
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,11L,9L,13L,8L,17L,21L,15L,19L,10L,23L,33L,37L,25L,27L,12L,29L,45L,55L,51L,31L,39L,14L,35L,57L,75L,85L,73L,43L,49L,16L,41L,69L,97L,111L,121L,99L,61L,63L,18L,47L,81L,115L,145L,159L,151L,127L,67L,79L,20L,53L,93L,135L,171L,199L,211L,193L,163L,87L,91L,22L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278505Inst : IEnumerable<long>
{
public static readonly long[] Value=A278505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278505.Bytes);
public long this[int i]=>Value[i];

public static A278505Inst Instance=new A278505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278506
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,11L,9L,16L,8L,22L,10L,29L,14L,37L,12L,46L,15L,56L,13L,67L,17L,79L,20L,92L,21L,106L,23L,121L,27L,137L,18L,154L,30L,172L,19L,191L,28L,211L,38L,232L,35L,254L,24L,277L,47L,301L,36L,326L,26L,352L,57L,379L,25L,407L,31L,436L,68L,466L,44L,497L,45L,529L,80L,562L,54L,596L,39L,631L,93L,667L,34L,704L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278506Inst : IEnumerable<long>
{
public static readonly long[] Value=A278506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278506.Bytes);
public long this[int i]=>Value[i];

public static A278506Inst Instance=new A278506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278507
{
public static readonly long[] Value={ 2L,4L,5L,6L,11L,9L,8L,17L,21L,15L,10L,23L,33L,37L,25L,12L,29L,45L,55L,51L,31L,14L,35L,57L,75L,85L,73L,43L,16L,41L,69L,97L,111L,121L,99L,61L,18L,47L,81L,115L,145L,159L,151L,127L,67L,20L,53L,93L,135L,171L,199L,211L,193L,163L,87L,22L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,24L,65L,117L,175L,231L,283L,319L,343L,339L,303L,229L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278507Inst : IEnumerable<long>
{
public static readonly long[] Value=A278507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278507.Bytes);
public long this[int i]=>Value[i];

public static A278507Inst Instance=new A278507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278508
{
public static readonly long[] Value={ 2L,5L,4L,9L,11L,6L,15L,21L,17L,8L,25L,37L,33L,23L,10L,31L,51L,55L,45L,29L,12L,43L,73L,85L,75L,57L,35L,14L,61L,99L,121L,111L,97L,69L,41L,16L,67L,127L,151L,159L,145L,115L,81L,47L,18L,87L,163L,193L,211L,199L,171L,135L,93L,53L,20L,103L,187L,247L,271L,267L,243L,205L,157L,105L,59L,22L,123L,229L,303L,339L,343L,319L,283L,231L,175L,117L,65L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278508Inst : IEnumerable<long>
{
public static readonly long[] Value=A278508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278508.Bytes);
public long this[int i]=>Value[i];

public static A278508Inst Instance=new A278508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278509
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,3L,1L,9L,1L,3L,3L,1L,3L,3L,1L,1L,9L,3L,1L,9L,3L,3L,3L,1L,1L,27L,3L,1L,3L,3L,1L,9L,1L,3L,9L,1L,3L,3L,1L,1L,9L,3L,3L,9L,3L,3L,3L,9L,1L,3L,1L,1L,27L,3L,3L,9L,1L,3L,3L,1L,3L,27L,1L,1L,9L,3L,1L,9L,3L,3L,9L,1L,1L,3L,3L,9L,3L,3L,1L,81L,1L,3L,9L,1L,3L,3L,3L,1L,9L,3L,3L,9L,3L,3L,3L,1L,9L,27L,1L,1L,3L,3L,1L,9L,1L,3L,27L,1L,3L,3L,3L,1L,9L,3L,1L,9L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278509Inst : IEnumerable<long>
{
public static readonly long[] Value=A278509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278509.Bytes);
public long this[int i]=>Value[i];

public static A278509Inst Instance=new A278509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278510
{
public static readonly long[] Value={ 0L,0L,0L,2L,0L,4L,0L,9L,8L,7L,0L,16L,0L,10L,14L,28L,0L,28L,0L,27L,20L,15L,0L,47L,24L,18L,48L,38L,0L,47L,0L,75L,30L,23L,34L,78L,0L,26L,36L,78L,0L,66L,0L,57L,80L,31L,0L,122L,48L,78L,46L,68L,0L,128L,50L,109L,52L,38L,0L,129L,0L,41L,112L,186L,60L,99L,0L,87L,62L,109L,0L,197L,0L,48L,132L,98L,70L,118L,0L,201L,208L,53L,0L,180L,76L,56L,76L,164L,0L,211L,84L,117L,82L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278510Inst : IEnumerable<long>
{
public static readonly long[] Value=A278510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278510.Bytes);
public long this[int i]=>Value[i];

public static A278510Inst Instance=new A278510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278511
{
public static readonly long[] Value={ 2L,4L,3L,6L,5L,7L,8L,11L,9L,13L,10L,17L,21L,15L,19L,12L,23L,33L,37L,25L,27L,14L,29L,45L,55L,51L,31L,39L,16L,35L,57L,75L,85L,73L,43L,49L,18L,41L,69L,97L,111L,121L,99L,61L,63L,20L,47L,81L,115L,145L,159L,151L,127L,67L,79L,22L,53L,93L,135L,171L,199L,211L,193L,163L,87L,91L,24L,59L,105L,157L,205L,243L,267L,271L,247L,187L,103L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278511Inst : IEnumerable<long>
{
public static readonly long[] Value=A278511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278511.Bytes);
public long this[int i]=>Value[i];

public static A278511Inst Instance=new A278511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278512
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,5L,7L,8L,10L,12L,9L,17L,11L,23L,15L,30L,13L,38L,16L,47L,14L,57L,18L,68L,21L,80L,22L,93L,24L,107L,28L,122L,19L,138L,31L,155L,20L,173L,29L,192L,39L,212L,36L,233L,25L,255L,48L,278L,37L,302L,27L,327L,58L,353L,26L,380L,32L,408L,69L,437L,45L,467L,46L,498L,81L,530L,55L,563L,40L,597L,94L,632L,35L,668L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278512Inst : IEnumerable<long>
{
public static readonly long[] Value=A278512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278512.Bytes);
public long this[int i]=>Value[i];

public static A278512Inst Instance=new A278512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278513
{
public static readonly long[] Value={ -1L,1L,0L,-1L,1L,0L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,-1L,0L,0L,1L,-1L,0L,-1L,0L,0L,-1L,-1L,0L,0L,-1L,0L,-1L,1L,0L,0L,1L,0L,0L,-1L,-1L,0L,0L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,-1L,1L,0L,0L,-1L,0L,1L,1L,0L,0L,-1L,0L,0L,-1L,0L,-1L,1L,-1L,0L,0L,-1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,-1L,-1L,-1L,0L,0L,0L,0L,0L,-1L,-1L,0L,1L,0L,0L,1L,0L,0L,0L,-1L,0L,-1L,-1L,0L,1L,0L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278513Inst : IEnumerable<long>
{
public static readonly long[] Value=A278513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278513.Bytes);
public long this[int i]=>Value[i];

public static A278513Inst Instance=new A278513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278514
{
public static readonly long[] Value={ 0L,-1L,0L,0L,-1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,2L,2L,1L,1L,1L,2L,1L,1L,0L,0L,0L,-1L,-2L,-2L,-2L,-3L,-3L,-4L,-3L,-3L,-3L,-2L,-2L,-2L,-3L,-4L,-4L,-4L,-3L,-3L,-3L,-2L,-2L,-2L,-3L,-2L,-2L,-3L,-2L,-2L,-2L,-3L,-3L,-2L,-1L,-1L,-1L,-2L,-2L,-2L,-3L,-3L,-4L,-3L,-4L,-4L,-4L,-5L,-5L,-5L,-4L,-4L,-3L,-2L,-2L,-1L,0L,0L,-1L,-2L,-3L,-3L,-3L,-3L,-3L,-3L,-4L,-5L,-5L,-4L,-4L,-4L,-3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278514Inst : IEnumerable<long>
{
public static readonly long[] Value=A278514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278514.Bytes);
public long this[int i]=>Value[i];

public static A278514Inst Instance=new A278514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278515
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,2L,0L,1L,0L,0L,2L,0L,0L,0L,1L,4L,0L,3L,0L,0L,2L,0L,0L,1L,0L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L,0L,0L,5L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,0L,0L,1L,7L,0L,0L,6L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,1L,0L,0L,7L,0L,6L,0L,0L,5L,0L,4L,0L,0L,3L,0L,0L,2L,0L,0L,1L,0L,0L,7L,0L,0L,6L,0L,0L,5L,0L,0L,0L,4L,0L,0L,3L,0L,2L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278515Inst : IEnumerable<long>
{
public static readonly long[] Value=A278515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278515.Bytes);
public long this[int i]=>Value[i];

public static A278515Inst Instance=new A278515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278532
{
public static readonly long[] Value={ 1L,4L,4L,6L,16L,6L,6L,36L,24L,24L,6L,6L,4L,36L,64L,24L,60L,60L,24L,6L,6L,4L,36L,144L,60L,64L,216L,24L,6L,60L,96L,60L,60L,60L,24L,6L,6L,4L,36L,144L,60L,144L,60L,60L,144L,64L,96L,216L,216L,24L,6L,60L,240L,210L,96L,360L,60L,6L,60L,96L,60L,60L,60L,24L,6L,6L,4L,36L,144L,60L,144L,60L,60L,900L,144L,360L,360L,60L,60L,144L,144L,240L,384L,96L,360L,216L,360L,216L,216L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278532Inst : IEnumerable<long>
{
public static readonly long[] Value=A278532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278532.Bytes);
public long this[int i]=>Value[i];

public static A278532Inst Instance=new A278532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278533
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,4L,2L,16L,12L,12L,6L,8L,6L,4L,2L,32L,24L,36L,12L,24L,30L,12L,6L,16L,12L,12L,6L,8L,6L,4L,2L,64L,48L,72L,24L,72L,60L,36L,12L,48L,60L,60L,30L,24L,30L,12L,6L,32L,24L,36L,12L,24L,30L,12L,6L,16L,12L,12L,6L,8L,6L,4L,2L,128L,96L,144L,48L,216L,120L,72L,24L,144L,180L,180L,60L,72L,60L,36L,12L,96L,120L,180L,60L,120L,210L,60L,30L,48L,60L,60L,30L,24L,30L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278533Inst : IEnumerable<long>
{
public static readonly long[] Value=A278533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278533.Bytes);
public long this[int i]=>Value[i];

public static A278533Inst Instance=new A278533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278534
{
public static readonly long[] Value={ 1L,2L,2L,12L,6L,12L,4L,180L,360L,6L,12L,6L,420L,180L,360L,4L,36L,420L,1260L,1800L,24L,120L,360L,1080L,48L,48L,720L,75600L,6L,12L,6L,420L,180L,360L,6L,60L,2310L,4620L,2520L,60L,420L,1260L,2520L,120L,120L,360L,83160L,5040L,720L,75600L,4L,36L,420L,1260L,1800L,60L,420L,1260L,2520L,180L,180L,900L,12600L,360L,12600L,5400L,720L,277200L,529200L,24L,120L,360L,1080L,120L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278534Inst : IEnumerable<long>
{
public static readonly long[] Value=A278534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278534.Bytes);
public long this[int i]=>Value[i];

public static A278534Inst Instance=new A278534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278535
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,6L,8L,2L,4L,6L,8L,6L,12L,12L,16L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,6L,12L,30L,24L,30L,60L,60L,48L,12L,36L,60L,72L,24L,72L,48L,64L,2L,4L,6L,8L,6L,12L,12L,16L,6L,12L,30L,24L,12L,36L,24L,32L,6L,12L,30L,24L,30L,60L,60L,48L,12L,36L,60L,72L,24L,72L,48L,64L,6L,12L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278535Inst : IEnumerable<long>
{
public static readonly long[] Value=A278535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278535.Bytes);
public long this[int i]=>Value[i];

public static A278535Inst Instance=new A278535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278536
{
public static readonly long[] Value={ 3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L,3L,1L,4L,1L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278536Inst : IEnumerable<long>
{
public static readonly long[] Value=A278536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278536.Bytes);
public long this[int i]=>Value[i];

public static A278536Inst Instance=new A278536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278537
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,1L,4L,2L,5L,3L,6L,1L,7L,2L,8L,4L,9L,1L,10L,3L,11L,5L,12L,2L,13L,1L,14L,6L,15L,2L,16L,4L,17L,7L,18L,3L,19L,1L,20L,8L,21L,2L,22L,5L,23L,9L,24L,1L,25L,3L,26L,10L,27L,4L,28L,6L,29L,11L,30L,2L,31L,1L,32L,12L,33L,2L,34L,7L,35L,13L,36L,3L,37L,5L,38L,14L,39L,1L,40L,8L,41L,15L,42L,4L,43L,2L,44L,16L,45L,1L,46L,9L,47L,17L,48L,6L,49L,3L,50L,18L,51L,2L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278537Inst : IEnumerable<long>
{
public static readonly long[] Value=A278537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278537.Bytes);
public long this[int i]=>Value[i];

public static A278537Inst Instance=new A278537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278538
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,3L,1L,3L,1L,2L,1L,4L,1L,4L,1L,2L,1L,5L,1L,3L,1L,2L,1L,5L,1L,6L,1L,2L,1L,6L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,7L,1L,3L,1L,2L,1L,8L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L,8L,1L,9L,1L,2L,1L,9L,1L,3L,1L,2L,1L,6L,1L,4L,1L,2L,1L,10L,1L,3L,1L,2L,1L,5L,1L,10L,1L,2L,1L,11L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,11L,1L,3L,1L,2L,1L,12L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278538Inst : IEnumerable<long>
{
public static readonly long[] Value=A278538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278538.Bytes);
public long this[int i]=>Value[i];

public static A278538Inst Instance=new A278538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278539
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,4L,1L,5L,2L,6L,3L,7L,1L,8L,2L,9L,4L,10L,1L,11L,3L,12L,5L,13L,2L,14L,1L,15L,6L,16L,2L,17L,4L,18L,7L,19L,3L,20L,1L,21L,8L,22L,2L,23L,5L,24L,9L,25L,1L,26L,3L,27L,10L,28L,4L,29L,6L,30L,11L,31L,2L,32L,1L,33L,12L,34L,2L,35L,7L,36L,13L,37L,3L,38L,5L,39L,14L,40L,1L,41L,8L,42L,15L,43L,4L,44L,2L,45L,16L,46L,1L,47L,9L,48L,17L,49L,6L,50L,3L,51L,18L,52L,2L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278539Inst : IEnumerable<long>
{
public static readonly long[] Value=A278539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278539.Bytes);
public long this[int i]=>Value[i];

public static A278539Inst Instance=new A278539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278540
{
public static readonly long[] Value={ 1L,2L,4L,2L,2L,8L,2L,6L,16L,6L,2L,12L,2L,6L,12L,4L,2L,32L,2L,6L,12L,6L,2L,24L,4L,6L,64L,6L,2L,24L,2L,12L,12L,6L,6L,48L,2L,6L,12L,30L,2L,24L,2L,6L,48L,6L,2L,36L,4L,12L,12L,6L,2L,128L,6L,30L,12L,6L,2L,60L,2L,6L,48L,8L,6L,24L,2L,6L,12L,30L,2L,96L,2L,6L,36L,6L,6L,24L,2L,12L,256L,6L,2L,60L,6L,6L,12L,30L,2L,96L,6L,6L,12L,6L,6L,72L,2L,12L,48L,12L,2L,24L,2L,30L,60L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278540Inst : IEnumerable<long>
{
public static readonly long[] Value=A278540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278540.Bytes);
public long this[int i]=>Value[i];

public static A278540Inst Instance=new A278540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278541
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,6L,2L,2L,16L,12L,6L,6L,2L,2L,2L,2L,32L,24L,12L,12L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,64L,48L,24L,24L,12L,12L,12L,12L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,128L,96L,48L,48L,24L,24L,24L,24L,12L,12L,12L,12L,12L,12L,12L,12L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278541Inst : IEnumerable<long>
{
public static readonly long[] Value=A278541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278541.Bytes);
public long this[int i]=>Value[i];

public static A278541Inst Instance=new A278541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278542
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,2L,6L,8L,2L,2L,2L,2L,6L,6L,12L,16L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,12L,12L,24L,32L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,12L,12L,12L,12L,24L,24L,48L,64L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278542Inst : IEnumerable<long>
{
public static readonly long[] Value=A278542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278542.Bytes);
public long this[int i]=>Value[i];

public static A278542Inst Instance=new A278542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278543
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,6L,1L,1L,6L,6L,2L,2L,6L,30L,1L,1L,30L,12L,2L,2L,24L,60L,2L,2L,60L,60L,6L,6L,30L,210L,1L,1L,210L,60L,12L,6L,120L,360L,2L,2L,720L,240L,6L,12L,360L,1260L,2L,2L,1260L,360L,12L,12L,1080L,2520L,6L,6L,1260L,1260L,30L,30L,210L,2310L,1L,1L,2310L,420L,60L,60L,7560L,7560L,6L,6L,15120L,6480L,24L,24L,2160L,37800L,2L,2L,75600L,6480L,48L,48L,12960L,90720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278543Inst : IEnumerable<long>
{
public static readonly long[] Value=A278543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278543.Bytes);
public long this[int i]=>Value[i];

public static A278543Inst Instance=new A278543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278544
{
public static readonly long[] Value={ 0L,1L,1L,5L,1L,21L,8L,31L,1L,123L,55L,459L,12L,705L,71L,247L,1L,951L,460L,14175L,119L,49275L,2825L,19305L,18L,30075L,3745L,105975L,167L,40845L,886L,2927L,1L,11091L,5585L,789075L,1554L,10546875L,175175L,4276125L,275L,14482125L,1004500L,186553125L,13573L,77371875L,264775L,1656585L,24L,2599275L,354515L,169509375L,19789L,566409375L,2055550L,48691125L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278544Inst : IEnumerable<long>
{
public static readonly long[] Value=A278544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278544.Bytes);
public long this[int i]=>Value[i];

public static A278544Inst Instance=new A278544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278545
{
public static readonly long[] Value={ 3L,5L,5L,5L,8L,5L,5L,8L,8L,5L,5L,8L,8L,8L,5L,5L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L,5L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278545Inst : IEnumerable<long>
{
public static readonly long[] Value=A278545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278545.Bytes);
public long this[int i]=>Value[i];

public static A278545Inst Instance=new A278545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278546
{
public static readonly long[] Value={ 8L,18L,28L,130L,134L,138L,148L,158L,176L,318L,530L,538L,548L,576L,644L,1300L,2170L,2202L,2212L,2228L,2230L,2248L,8706L,8938L,8948L,34970L,35082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278546Inst : IEnumerable<long>
{
public static readonly long[] Value=A278546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278546.Bytes);
public long this[int i]=>Value[i];

public static A278546Inst Instance=new A278546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278547
{
public static readonly long[] Value={ 0L,0L,4L,65L,456L,2128L,7728L,23607L,63460L,154518L,347568L,732524L,1461824L,2784600L,5095376L,9002010L,15418728L,25691420L,41763900L,66395595L,103443144L,158220680L,237956160L,352364025L,514357740L,740929410L,1054227720L,1482869934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278547Inst : IEnumerable<long>
{
public static readonly long[] Value=A278547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278547.Bytes);
public long this[int i]=>Value[i];

public static A278547Inst Instance=new A278547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278564
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,2L,3L,2L,1L,1L,2L,3L,1L,5L,1L,3L,2L,1L,1L,2L,2L,3L,2L,5L,2L,3L,2L,2L,1L,1L,2L,2L,3L,1L,4L,2L,1L,7L,1L,2L,4L,1L,3L,2L,2L,1L,1L,2L,2L,2L,3L,1L,5L,1L,2L,1L,7L,1L,2L,1L,5L,1L,3L,2L,2L,2L,1L,1L,2L,2L,2L,3L,1L,4L,2L,5L,2L,3L,1L,1L,9L,1L,1L,3L,2L,5L,2L,4L,1L,3L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,1L,4L,2L,1L,6L,2L,3L,2L,1L,9L,1L,2L,3L,2L,6L,1L,1L,2L,4L,1L,3L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278564Inst : IEnumerable<long>
{
public static readonly long[] Value=A278564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278564.Bytes);
public long this[int i]=>Value[i];

public static A278564Inst Instance=new A278564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278565
{
public static readonly BigInteger[] Value={ 0L,1L,4L,18L,236L,12760L,3162582L,5965957900L,147395915019656L,BigInteger.Parse("38431930179989653632"),BigInteger.Parse("90116582088416163834417290"),BigInteger.Parse("2118032070086776060232851050813004"),BigInteger.Parse("966490912699216393489571072350268614425420"),BigInteger.Parse("17165261065730992639912668446254005264689353839299152") };
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
public class A278565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278565Inst Instance=new A278565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278566
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,1L,1L,3L,3L,1L,2L,1L,4L,5L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278566Inst : IEnumerable<long>
{
public static readonly long[] Value=A278566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278566.Bytes);
public long this[int i]=>Value[i];

public static A278566Inst Instance=new A278566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278567
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278567Inst : IEnumerable<long>
{
public static readonly long[] Value=A278567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278567.Bytes);
public long this[int i]=>Value[i];

public static A278567Inst Instance=new A278567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278568
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,22L,26L,34L,38L,46L,50L,54L,58L,62L,74L,82L,86L,94L,98L,106L,118L,122L,134L,142L,146L,158L,162L,166L,178L,194L,202L,206L,214L,218L,226L,242L,250L,254L,262L,274L,278L,298L,302L,314L,326L,334L,338L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278568Inst : IEnumerable<long>
{
public static readonly long[] Value=A278568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278568.Bytes);
public long this[int i]=>Value[i];

public static A278568Inst Instance=new A278568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278569
{
public static readonly long[] Value={ 105L,165L,195L,231L,255L,273L,285L,315L,345L,357L,385L,399L,429L,435L,455L,465L,483L,495L,525L,555L,561L,585L,595L,609L,615L,627L,645L,651L,663L,665L,693L,705L,715L,735L,741L,759L,765L,777L,795L,805L,819L,825L,855L,861L,885L,897L,903L,915L,935L,945L,957L,969L,975L,987L,1001L,1005L,1015L,1023L,1035L,1045L,1065L,1071L,1085L,1095L,1105L,1113L,1131L,1173L,1185L,1197L,1209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278569Inst : IEnumerable<long>
{
public static readonly long[] Value=A278569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278569.Bytes);
public long this[int i]=>Value[i];

public static A278569Inst Instance=new A278569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278570
{
public static readonly long[] Value={ 2L,2L,2L,1L,2L,2L,2L,2L,2L,3L,1L,2L,1L,2L,1L,1L,2L,2L,3L,2L,2L,2L,2L,1L,1L,3L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,1L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,1L,2L,3L,2L,2L,2L,1L,2L,3L,1L,1L,1L,2L,2L,2L,1L,2L,3L,1L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278570Inst : IEnumerable<long>
{
public static readonly long[] Value=A278570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278570.Bytes);
public long this[int i]=>Value[i];

public static A278570Inst Instance=new A278570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278571
{
public static readonly long[] Value={ 1L,7L,42L,385L,436L,1530L,3180L,3625L,8208L,3767L,10116L,6699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278571Inst : IEnumerable<long>
{
public static readonly long[] Value=A278571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278571.Bytes);
public long this[int i]=>Value[i];

public static A278571Inst Instance=new A278571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278572
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,1L,3L,-1L,1L,4L,3L,2L,3L,5L,-1L,5L,1L,4L,7L,-1L,3L,5L,6L,3L,7L,9L,-1L,3L,5L,2L,7L,1L,5L,9L,-1L,3L,7L,-1L,-1L,1L,3L,9L,13L,2L,1L,9L,3L,6L,7L,13L,-1L,10L,13L,7L,2L,9L,11L,15L,-1L,-1L,4L,8L,14L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278572Inst : IEnumerable<long>
{
public static readonly long[] Value=A278572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278572.Bytes);
public long this[int i]=>Value[i];

public static A278572Inst Instance=new A278572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278573
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,3L,1L,3L,5L,1L,3L,4L,6L,-1L,1L,4L,5L,8L,3L,7L,2L,9L,3L,5L,7L,9L,-1L,5L,9L,1L,4L,7L,8L,11L,14L,-1L,3L,5L,6L,11L,12L,14L,3L,7L,9L,11L,15L,-1L,3L,5L,15L,17L,2L,7L,14L,19L,1L,21L,5L,9L,14L,18L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278573Inst : IEnumerable<long>
{
public static readonly long[] Value=A278573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278573.Bytes);
public long this[int i]=>Value[i];

public static A278573Inst Instance=new A278573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278574
{
public static readonly long[] Value={ 5L,31L,8123L,45439L,156157L,480209L,2181737L,6012899L,13626257L,60487759L,217795247L,240485257L,995151679L,4002927023L,7186211917L,10514388763L,18553663237L,34434090797L,196122821897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278574Inst : IEnumerable<long>
{
public static readonly long[] Value=A278574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278574.Bytes);
public long this[int i]=>Value[i];

public static A278574Inst Instance=new A278574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278575
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,1L,3L,1L,4L,3L,8L,5L,10L,7L,16L,11L,23L,17L,34L,25L,46L,36L,68L,52L,91L,73L,128L,103L,173L,142L,236L,194L,313L,265L,424L,357L,555L,476L,737L,634L,961L,837L,1256L,1098L,1621L,1433L,2102L,1860L,2687L,2401L,3445L,3089L,4379L,3952L,5563L,5034L,7015L,6391L,8852L,8082L,11087L,10177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278575Inst : IEnumerable<long>
{
public static readonly long[] Value=A278575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278575.Bytes);
public long this[int i]=>Value[i];

public static A278575Inst Instance=new A278575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278576
{
public static readonly BigInteger[] Value={ 1L,5L,36L,313L,3145L,35500L,441951L,5989413L,87496610L,1367284215L,22714400561L,399122562838L,7386136082045L,143434180479665L,2913717863731996L,61746352166762613L,1361745345400563725L,BigInteger.Parse("31186806216360128300"),BigInteger.Parse("740294632899931980131"),BigInteger.Parse("18182298488225724570513") };
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
public class A278576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278576Inst Instance=new A278576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278577
{
public static readonly long[] Value={ 1L,-24L,252L,-1472L,4830L,-16744L,84480L,-113643L,534612L,-577738L,987136L,-6905934L,10661420L,18643272L,-25499225L,-73279080L,128406630L,-52843168L,-196706304L,-182213314L,308120442L,-17125708L,2687348496L,-1696965207L,-1596055698L,-5189203740L,6956478662L,2699296768L,-15481826884L,9791485272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278577Inst : IEnumerable<long>
{
public static readonly long[] Value=A278577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278577.Bytes);
public long this[int i]=>Value[i];

public static A278577Inst Instance=new A278577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278578
{
public static readonly long[] Value={ 4L,1L,59L,3481L,5959L,12117361L,351581L,344322938L,995153L,35509681L,1223853461L,117428054L,58714027L,2447706922L,71019362L,1990306L,172161469L,703162L,24234722L,11918L,6962L,118L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278578Inst : IEnumerable<long>
{
public static readonly long[] Value=A278578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278578.Bytes);
public long this[int i]=>Value[i];

public static A278578Inst Instance=new A278578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278579
{
public static readonly long[] Value={ 5L,7L,10L,11L,14L,15L,17L,19L,20L,21L,22L,28L,30L,33L,34L,37L,38L,40L,42L,43L,44L,45L,51L,53L,56L,57L,60L,61L,63L,65L,66L,67L,68L,74L,76L,79L,80L,83L,84L,86L,88L,89L,90L,91L,97L,99L,102L,103L,106L,107L,109L,111L,112L,113L,114L,120L,122L,125L,126L,129L,130L,132L,134L,135L,136L,137L,143L,145L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278579Inst : IEnumerable<long>
{
public static readonly long[] Value=A278579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278579.Bytes);
public long this[int i]=>Value[i];

public static A278579Inst Instance=new A278579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278612
{
public static readonly long[] Value={ 3L,8L,22L,60L,162L,436L,1174L,3164L,8530L,22996L,61990L,167100L,450434L,1214196L,3273014L,8822812L,23782962L,64109844L,172815814L,465845884L,1255743842L,3385009204L,9124701142L,24596733916L,66303466770L,178729002068L,481785610086L,1298711297084L,3500833146178L,9436918539636L,25438353615990L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278612Inst : IEnumerable<long>
{
public static readonly long[] Value=A278612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278612.Bytes);
public long this[int i]=>Value[i];

public static A278612Inst Instance=new A278612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278613
{
public static readonly long[] Value={ 3L,8L,21L,55L,145L,381L,1001L,2633L,6921L,18193L,47833L,125745L,330569L,869057L,2284665L,6006193L,15789865L,41510241L,109127129L,286886801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278613Inst : IEnumerable<long>
{
public static readonly long[] Value=A278613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278613.Bytes);
public long this[int i]=>Value[i];

public static A278613Inst Instance=new A278613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278614
{
public static readonly long[] Value={ 3L,8L,22L,62L,176L,502L,1434L,4100L,11726L,33542L,95952L,274494L,785266L,2246484L,6426742L,18385646L,52597744L,150471910L,430470890L,1231493604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278614Inst : IEnumerable<long>
{
public static readonly long[] Value=A278614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278614.Bytes);
public long this[int i]=>Value[i];

public static A278614Inst Instance=new A278614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278615
{
public static readonly long[] Value={ 3L,8L,21L,56L,148L,394L,1044L,2776L,7364L,19568L,51936L,137960L,366256L,972736L,2582736L,6858880L,18212288L,48363680L,128423232L,341027456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278615Inst : IEnumerable<long>
{
public static readonly long[] Value=A278615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278615.Bytes);
public long this[int i]=>Value[i];

public static A278615Inst Instance=new A278615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278616
{
public static readonly long[] Value={ 3L,8L,21L,56L,148L,393L,1041L,2761L,7318L,19403L,51436L,136366L,361513L,958413L,2540831L,6735996L,17857733L,47342548L,125509476L,332737401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278616Inst : IEnumerable<long>
{
public static readonly long[] Value=A278616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278616.Bytes);
public long this[int i]=>Value[i];

public static A278616Inst Instance=new A278616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278617
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,8L,8L,9L,10L,10L,10L,11L,11L,12L,13L,13L,14L,14L,14L,15L,15L,15L,16L,17L,17L,17L,18L,18L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,29L,29L,29L,29L,29L,29L,30L,30L,31L,31L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278617Inst : IEnumerable<long>
{
public static readonly long[] Value=A278617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278617.Bytes);
public long this[int i]=>Value[i];

public static A278617Inst Instance=new A278617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278618
{
public static readonly long[] Value={ 1L,0L,5L,7L,45L,121L,533L,1800L,7157L,26239L,101640L,384583L,1483925L,5693247L,22013059L,85076183L,330014421L,1281349195L,4985766650L,19422653367L,75775163028L,295953650376L,1157212653030L,4529183513913L,17743019073381L,69565441895001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278618Inst : IEnumerable<long>
{
public static readonly long[] Value=A278618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278618.Bytes);
public long this[int i]=>Value[i];

public static A278618Inst Instance=new A278618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278619
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,6L,7L,8L,10L,12L,15L,18L,22L,26L,31L,36L,42L,49L,56L,64L,72L,82L,94L,106L,121L,139L,157L,179L,205L,231L,262L,298L,334L,376L,425L,481L,537L,601L,673L,745L,827L,921L,1027L,1133L,1254L,1393L,1550L,1707L,1886L,2091L,2322L,2553L,2815L,3113L,3447L,3781L,4157L,4582L,5063L,5600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278619Inst : IEnumerable<long>
{
public static readonly long[] Value=A278619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278619.Bytes);
public long this[int i]=>Value[i];

public static A278619Inst Instance=new A278619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278620
{
public static readonly BigInteger[] Value={ 0L,1L,99L,9702L,950698L,93158703L,9128602197L,894509856604L,87652837344996L,8589083549953005L,841642535058049495L,BigInteger.Parse("82472379352138897506"),BigInteger.Parse("8081451533974553906094"),BigInteger.Parse("791899777950154143899707"),BigInteger.Parse("77598096787581131548265193"),BigInteger.Parse("7603821585405000737586089208"),BigInteger.Parse("745096917272902491151888477192") };
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
public class A278620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278620Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278620.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278620Inst Instance=new A278620Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278621
{
public static readonly long[] Value={ 3L,46L,357L,1952L,8518L,31605L,103546L,307087L,838936L,2138608L,5137407L,11719956L,25549096L,53493458L,108027996L,211167710L,400765157L,740380790L,1334456849L,2351234708L,4056807390L,6864961455L,11409118950L,18644841765L,29994129570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278621Inst : IEnumerable<long>
{
public static readonly long[] Value=A278621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278621.Bytes);
public long this[int i]=>Value[i];

public static A278621Inst Instance=new A278621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278622
{
public static readonly long[] Value={ 16L,357L,4754L,49503L,439446L,3438414L,24103803L,153073965L,888863183L,4758719096L,23665023516L,110046094356L,481337375925L,1990600963219L,7819169497216L,29290369365213L,105007107699726L,361416768054859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278622Inst : IEnumerable<long>
{
public static readonly long[] Value=A278622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278622.Bytes);
public long this[int i]=>Value[i];

public static A278622Inst Instance=new A278622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278623
{
public static readonly long[] Value={ 51L,1952L,49503L,1069536L,21121532L,387542112L,6594175430L,103536313036L,1496475492375L,19928249063688L,245280439959902L,2802425055340520L,29863427285241827L,298206737876251916L,2802780797553511873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278623Inst : IEnumerable<long>
{
public static readonly long[] Value=A278623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278623.Bytes);
public long this[int i]=>Value[i];

public static A278623Inst Instance=new A278623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278624
{
public static readonly BigInteger[] Value={ 126L,8518L,439446L,21121532L,978005050L,43853346948L,1892563134910L,77595353266488L,2984253200734849L,106802443365088678L,3546576756421791553L,BigInteger.Parse("109349563224002187119"),BigInteger.Parse("3138905373936577741625"),BigInteger.Parse("84191222241450755762521") };
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
public class A278624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278624Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278624.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278624Inst Instance=new A278624Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278625
{
public static readonly BigInteger[] Value={ 266L,31605L,3438414L,387542112L,43853346948L,4902306226424L,540194658701142L,58237100230743229L,6049936223396297740L,BigInteger.Parse("596291979361147397590"),BigInteger.Parse("55176657492423943503531"),BigInteger.Parse("4770167181501151268299031") };
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
public class A278625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278625Inst Instance=new A278625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278626
{
public static readonly BigInteger[] Value={ 504L,103546L,24103803L,6594175430L,1892563134910L,540194658701142L,152561415660718514L,BigInteger.Parse("42854095125044269456"),BigInteger.Parse("11909803616605399424974"),BigInteger.Parse("3223604568067184016119193"),BigInteger.Parse("835430834890906525681829626") };
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
public class A278626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278626Inst Instance=new A278626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278627
{
public static readonly long[] Value={ 0L,3L,3L,16L,46L,16L,51L,357L,357L,51L,126L,1952L,4754L,1952L,126L,266L,8518L,49503L,49503L,8518L,266L,504L,31605L,439446L,1069536L,439446L,31605L,504L,882L,103546L,3438414L,21121532L,21121532L,3438414L,103546L,882L,1452L,307087L,24103803L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278627Inst : IEnumerable<long>
{
public static readonly long[] Value=A278627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278627.Bytes);
public long this[int i]=>Value[i];

public static A278627Inst Instance=new A278627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278660
{
public static readonly BigInteger[] Value={ 1L,0L,100L,11L,10100L,11L,1110000L,101111L,100110000L,101111L,11100000000L,1011111111L,1000111000000L,101110111111L,101010000000000L,1111111111L,11111001100000000L,1100001011111111L,1000011000000000000L,110110111111111111L,BigInteger.Parse("100000111110000000000") };
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
public class A278660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278660Inst Instance=new A278660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278661
{
public static readonly long[] Value={ 1L,0L,1L,12L,5L,48L,7L,244L,25L,976L,7L,4084L,113L,16244L,21L,65472L,415L,261388L,97L,1048428L,1985L,4192028L,577L,16775196L,5057L,67093020L,6357L,268419616L,23183L,1073684512L,4015L,4294962736L,68279L,17179631792L,69175L,68719306412L,321389L,274876908426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278661Inst : IEnumerable<long>
{
public static readonly long[] Value=A278661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278661.Bytes);
public long this[int i]=>Value[i];

public static A278661Inst Instance=new A278661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278662
{
public static readonly long[] Value={ 1L,0L,4L,3L,20L,3L,112L,47L,304L,47L,1792L,767L,4544L,3007L,21504L,1023L,127744L,49919L,274432L,225279L,1080320L,932863L,4268032L,3678207L,17272832L,14749695L,89702400L,4472831L,506150912L,16859135L,2063073280L,209190911L,7962951680L,874053631L,31734366208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278662Inst : IEnumerable<long>
{
public static readonly long[] Value=A278662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278662.Bytes);
public long this[int i]=>Value[i];

public static A278662Inst Instance=new A278662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278663
{
public static readonly long[] Value={ 0L,0L,3L,3L,6L,3L,14L,3L,24L,11L,54L,3L,148L,3L,318L,59L,834L,3L,2314L,3L,5952L,323L,16110L,3L,45178L,51L,122646L,2195L,341820L,3L,962634L,3L,2690844L,16115L,7596486L,363L,21568780L,3L,61171662L,122651L,174343026L,3L,498453878L,3L,1426419876L,958819L,4093181694L,3L,11770610128L,315L,33891550302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278663Inst : IEnumerable<long>
{
public static readonly long[] Value=A278663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278663.Bytes);
public long this[int i]=>Value[i];

public static A278663Inst Instance=new A278663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278664
{
public static readonly ulong[] Value={ 1L,11L,110L,1100L,11000L,110010L,1100110L,11000100L,110000100L,1100100100L,11001110100L,110001010100L,1100001010100L,11001001010100L,110011101010100L,1100010101010100L,11000010101010100L,110010010101010100L,1100111010101010100L,11000101010101010100UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278664Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278664.Bytes);
public ulong this[int i]=>Value[i];

public static A278664Inst Instance=new A278664Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278665
{
public static readonly ulong[] Value={ 1L,11L,11L,11L,11L,10011L,110011L,100011L,1000011L,10010011L,101110011L,1010100011L,10101000011L,101010010011L,1010101110011L,10101010100011L,101010101000011L,1010101010010011L,10101010101110011L,101010101010100011L,1010101010101000011L,10101010101010010011UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278665Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278665.Bytes);
public ulong this[int i]=>Value[i];

public static A278665Inst Instance=new A278665Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278666
{
public static readonly long[] Value={ 1L,3L,6L,12L,24L,50L,102L,196L,388L,804L,1652L,3156L,6228L,12884L,26452L,50516L,99668L,206164L,423252L,808276L,1594708L,3298644L,6772052L,12932436L,25515348L,52778324L,108352852L,206918996L,408245588L,844453204L,1733645652L,3310703956L,6531929428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278666Inst : IEnumerable<long>
{
public static readonly long[] Value=A278666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278666.Bytes);
public long this[int i]=>Value[i];

public static A278666Inst Instance=new A278666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278667
{
public static readonly long[] Value={ 1L,3L,3L,3L,3L,19L,51L,35L,67L,147L,371L,675L,1347L,2707L,5491L,10915L,21827L,43667L,87411L,174755L,349507L,699027L,1398131L,2796195L,5592387L,11184787L,22369651L,44739235L,89478467L,178956947L,357913971L,715827875L,1431655747L,2863311507L,5726623091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278667Inst : IEnumerable<long>
{
public static readonly long[] Value=A278667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278667.Bytes);
public long this[int i]=>Value[i];

public static A278667Inst Instance=new A278667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278668
{
public static readonly long[] Value={ 1L,3L,9L,22L,51L,107L,218L,420L,788L,1428L,2531L,4375L,7430L,12377L,20313L,32833L,52402L,82585L,128750L,198588L,303428L,459375L,689710L,1027243L,1518709L,2229375L,3251022L,4710777L,6785378L,9717677L,13841991L,19614182L,27656250L,38810312L,54216128L,75406438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278668Inst : IEnumerable<long>
{
public static readonly long[] Value=A278668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278668.Bytes);
public long this[int i]=>Value[i];

public static A278668Inst Instance=new A278668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278669
{
public static readonly long[] Value={ 0L,8L,158L,2650L,55854L,1998526L,157706284L,32788533228L,19802007716084L,36574110002226508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278669Inst : IEnumerable<long>
{
public static readonly long[] Value=A278669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278669.Bytes);
public long this[int i]=>Value[i];

public static A278669Inst Instance=new A278669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278670
{
public static readonly long[] Value={ 1L,8L,33L,99L,245L,532L,1050L,1926L,3333L,5500L,8723L,13377L,19929L,28952L,41140L,57324L,78489L,105792L,140581L,184415L,239085L,306636L,389390L,489970L,611325L,756756L,929943L,1134973L,1376369L,1659120L,1988712L,2371160L,2813041L,3321528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278670Inst : IEnumerable<long>
{
public static readonly long[] Value=A278670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278670.Bytes);
public long this[int i]=>Value[i];

public static A278670Inst Instance=new A278670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278671
{
public static readonly long[] Value={ 4L,33L,158L,579L,1801L,4999L,12727L,30218L,67651L,143936L,292799L,572247L,1078870L,1968906L,3488570L,6016844L,10124758L,16656179L,26836284L,42415243L,65856199L,100578425L,151268585L,224275350L,328105245L,474040554L,676903413L,955993903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278671Inst : IEnumerable<long>
{
public static readonly long[] Value=A278671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278671.Bytes);
public long this[int i]=>Value[i];

public static A278671Inst Instance=new A278671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278672
{
public static readonly long[] Value={ 10L,99L,579L,2650L,10584L,38848L,134265L,441349L,1384443L,4148373L,11882640L,32576006L,85619948L,216195769L,525654868L,1233512143L,2800037121L,6161774705L,13172137674L,27405600826L,55592487870L,110125213825L,213350721015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278672Inst : IEnumerable<long>
{
public static readonly long[] Value=A278672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278672.Bytes);
public long this[int i]=>Value[i];

public static A278672Inst Instance=new A278672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278673
{
public static readonly long[] Value={ 20L,245L,1801L,10584L,55854L,280616L,1378241L,6654535L,31404174L,143558071L,630909284L,2653428584L,10658877991L,40894491453L,150023824702L,527191888255L,1778244684147L,5769938709484L,18048492750432L,54537766679216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278673Inst : IEnumerable<long>
{
public static readonly long[] Value=A278673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278673.Bytes);
public long this[int i]=>Value[i];

public static A278673Inst Instance=new A278673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278674
{
public static readonly long[] Value={ 35L,532L,4999L,38848L,280616L,1998526L,14437336L,106388729L,791018703L,5827280865L,41816145745L,288815214521L,1906968251924L,12001457552556L,71956255780683L,411365841721218L,2245996961511549L,11734146676561159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278674Inst : IEnumerable<long>
{
public static readonly long[] Value=A278674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278674.Bytes);
public long this[int i]=>Value[i];

public static A278674Inst Instance=new A278674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278675
{
public static readonly long[] Value={ 56L,1050L,12727L,134265L,1378241L,14437336L,157706284L,1809189550L,21622163723L,263667893290L,3200723946503L,37898709431669L,431935945421546L,4704720632893357L,48828296440609470L,482618940316582616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278675Inst : IEnumerable<long>
{
public static readonly long[] Value=A278675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278675.Bytes);
public long this[int i]=>Value[i];

public static A278675Inst Instance=new A278675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278724
{
public static readonly BigInteger[] Value={ 56L,3492L,306070L,30942600L,3062815568L,279368748599L,23161560633508L,1747727428639023L,120668752462156921L,7668150385606788285L,BigInteger.Parse("451008119329650593967"),BigInteger.Parse("24676136165708649853590"),BigInteger.Parse("1261674436562343441025436") };
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
public class A278724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278724Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278724.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278724Inst Instance=new A278724Inst();

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