using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A222005
{
public static readonly long[] Value={ 1L,2L,1L,6L,2L,1L,24L,12L,2L,1L,120L,157L,22L,2L,1L,720L,3853L,704L,37L,2L,1L,5040L,138715L,78376L,2470L,58L,2L,1L,40320L,6838453L,15637284L,1227685L,7328L,86L,2L,1L,362880L,438350738L,5360397488L,1252017597L,16011558L,19228L,122L,2L,1L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222005Inst : IEnumerable<long>
{
public static readonly long[] Value=A222005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222005.Bytes);
public long this[int i]=>Value[i];

public static A222005Inst Instance=new A222005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222006
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,5L,10L,12L,27L,35L,79L,104L,244L,331L,789L,1083L,2615L,3652L,8880L,12523L,30657L,43661L,107326L,153985L,379945L,548776L,1357922L,1972153L,4892140L,7139850L,17747863L,26011843L,64776658L,95296413L,237689691L,350844814L,876313458L,1297367201L,3244521203L,4816399289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222006Inst : IEnumerable<long>
{
public static readonly long[] Value=A222006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222006.Bytes);
public long this[int i]=>Value[i];

public static A222006Inst Instance=new A222006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222007
{
public static readonly long[] Value={ 2L,3L,5L,11L,41L,7L,23L,17L,19L,13L,37L,53L,73L,151L,29L,43L,31L,59L,71L,47L,79L,61L,107L,83L,103L,163L,109L,89L,101L,113L,67L,97L,137L,131L,139L,127L,229L,149L,173L,227L,179L,239L,181L,191L,193L,167L,197L,241L,277L,157L,233L,211L,397L,257L,271L,283L,251L,281L,313L,269L,347L,349L,317L,263L,379L,223L,367L,199L,353L,401L,421L,463L,293L,337L,383L,389L,331L,431L,359L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222007Inst : IEnumerable<long>
{
public static readonly long[] Value=A222007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222007.Bytes);
public long this[int i]=>Value[i];

public static A222007Inst Instance=new A222007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222008
{
public static readonly long[] Value={ 5L,17L,257L,65537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222008Inst : IEnumerable<long>
{
public static readonly long[] Value=A222008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222008.Bytes);
public long this[int i]=>Value[i];

public static A222008Inst Instance=new A222008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222009
{
public static readonly BigInteger[] Value={ 1L,2L,61L,71L,684847L,8621L,4768743913L,192769238731L,31302497L,3624013907027L,3389284413733950439L,20347152500093L,BigInteger.Parse("73535243111830065216714893617"),BigInteger.Parse("579021662547635771462791245283"),BigInteger.Parse("38283945111344558723552263341142779661"),BigInteger.Parse("60296900399609972459"),BigInteger.Parse("271233083114844569997128597"),BigInteger.Parse("1382959355737627871079165208413804169") };
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
public class A222009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222009Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222009.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222009Inst Instance=new A222009Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222010
{
public static readonly long[] Value={ 0L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222010Inst : IEnumerable<long>
{
public static readonly long[] Value=A222010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222010.Bytes);
public long this[int i]=>Value[i];

public static A222010Inst Instance=new A222010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222011
{
public static readonly long[] Value={ 1L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222011Inst : IEnumerable<long>
{
public static readonly long[] Value=A222011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222011.Bytes);
public long this[int i]=>Value[i];

public static A222011Inst Instance=new A222011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222012
{
public static readonly BigInteger[] Value={ 1L,1L,4L,22L,145L,1081L,8863L,78751L,752587L,7708483L,84532222L,992628616L,12487788067L,168344145919L,2430351826084L,37517872149790L,617842147959019L,10821864145358779L,200955801421862020L,3943205940005194330L,BigInteger.Parse("81506338541922078355"),BigInteger.Parse("1769606318933022398611") };
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
public class A222012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222012Inst Instance=new A222012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222013
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,32L,172L,1038L,6865L,49098L,376942L,3094812L,27129690L,253821716L,2534600760L,27012498668L,307083883519L,3719224056464L,47898505899624L,654343988611350L,9455986402701388L,144138413744793426L,2311030293590097634L,BigInteger.Parse("38871924229882607774") };
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
public class A222013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222013Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222013.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222013Inst Instance=new A222013Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222014
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,54L,392L,3264L,30375L,311482L,3492134L,42613740L,564395954L,8094807168L,125423821396L,2093539627292L,37521869868373L,719483654260090L,14705046942685816L,319171681858506880L,7331367124418082012L,BigInteger.Parse("177646903957002411656"),BigInteger.Parse("4527740283395695051578") };
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
public class A222014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222014Inst Instance=new A222014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222015
{
public static readonly long[] Value={ 3L,27L,188L,1363L,9838L,70994L,512456L,3698699L,26696370L,192687348L,1390767557L,10038200482L,72453134112L,522947981192L,3774503253017L,27243388115499L,196635728242591L,1419265821803368L,10243893573843252L,73937773981558032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222015Inst : IEnumerable<long>
{
public static readonly long[] Value=A222015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222015.Bytes);
public long this[int i]=>Value[i];

public static A222015Inst Instance=new A222015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222016
{
public static readonly BigInteger[] Value={ 6L,188L,3875L,86088L,1892859L,41636522L,916164266L,20156123913L,443464985963L,9756801621038L,214662580479904L,4722860659023550L,103909179716386461L,2286139384890550049L,BigInteger.Parse("50298089904801491960"),BigInteger.Parse("1106624498857041822230") };
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
public class A222016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222016Inst Instance=new A222016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222017
{
public static readonly BigInteger[] Value={ 13L,1363L,86088L,5925053L,403317044L,27460842224L,1870475750419L,127385479747138L,8675741759311142L,590866503322144180L,BigInteger.Parse("40241368935424750183"),BigInteger.Parse("2740665723881270704902"),BigInteger.Parse("186654894043998446085330") };
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
public class A222017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222017Inst Instance=new A222017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222018
{
public static readonly BigInteger[] Value={ 28L,9838L,1892859L,403317044L,84799061141L,17838051289367L,3753835631741568L,789821887272883642L,BigInteger.Parse("166189333434443018741"),BigInteger.Parse("34968169848205865653334"),BigInteger.Parse("7357721396433443050132543"),BigInteger.Parse("1548152408282663670986074421") };
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
public class A222018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222018Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222018.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222018Inst Instance=new A222018Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222019
{
public static readonly BigInteger[] Value={ 60L,70994L,41636522L,27460842224L,17838051289367L,11593944359617570L,7538777970648890706L,BigInteger.Parse("4901063986390211477492"),BigInteger.Parse("3186408336556340539334545") };
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
public class A222019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222019Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222019.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222019Inst Instance=new A222019Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222020
{
public static readonly long[] Value={ 1L,3L,3L,6L,27L,6L,13L,188L,188L,13L,28L,1363L,3875L,1363L,28L,60L,9838L,86088L,86088L,9838L,60L,129L,70994L,1892859L,5925053L,1892859L,70994L,129L,277L,512456L,41636522L,403317044L,403317044L,41636522L,512456L,277L,595L,3698699L,916164266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222020Inst : IEnumerable<long>
{
public static readonly long[] Value=A222020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222020.Bytes);
public long this[int i]=>Value[i];

public static A222020Inst Instance=new A222020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222021
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,15L,23L,36L,55L,84L,129L,198L,303L,465L,714L,1095L,1680L,2578L,3955L,6067L,9308L,14280L,21907L,33609L,51562L,79104L,121358L,186183L,285634L,438207L,672279L,1031382L,1582302L,2427501L,3724170L,5713464L,8765355L,13447438L,20630491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222021Inst : IEnumerable<long>
{
public static readonly long[] Value=A222021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222021.Bytes);
public long this[int i]=>Value[i];

public static A222021Inst Instance=new A222021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222022
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,16L,26L,41L,62L,99L,156L,242L,382L,600L,938L,1475L,2314L,3627L,5696L,8935L,14016L,22000L,34515L,54153L,84981L,133334L,209209L,328278L,515083L,808208L,1268156L,1989823L,3122203L,4899001L,7686907L,12061403L,18925330L,29695352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222022Inst : IEnumerable<long>
{
public static readonly long[] Value=A222022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222022.Bytes);
public long this[int i]=>Value[i];

public static A222022Inst Instance=new A222022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222023
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,16L,26L,42L,65L,105L,168L,265L,424L,675L,1070L,1707L,2715L,4315L,6875L,10937L,17399L,27704L,44080L,70145L,111654L,177672L,282755L,450022L,716152L,1139735L,1813879L,2886645L,4594007L,7311215L,11635384L,18517300L,29469544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222023Inst : IEnumerable<long>
{
public static readonly long[] Value=A222023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222023.Bytes);
public long this[int i]=>Value[i];

public static A222023Inst Instance=new A222023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222024
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,17L,28L,44L,70L,113L,179L,286L,458L,730L,1167L,1864L,2976L,4756L,7595L,12132L,19382L,30957L,49453L,78995L,126181L,201567L,321974L,514314L,821567L,1312346L,2096327L,3348644L,5349052L,8544512L,13648859L,21802452L,34826922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222024Inst : IEnumerable<long>
{
public static readonly long[] Value=A222024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222024.Bytes);
public long this[int i]=>Value[i];

public static A222024Inst Instance=new A222024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222025
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,17L,28L,44L,70L,113L,179L,287L,460L,733L,1176L,1880L,3006L,4815L,7698L,12321L,19719L,31544L,50485L,80775L,129248L,206835L,330942L,529569L,847399L,1355929L,2169734L,3471871L,5555487L,8889679L,14224728L,22761726L,36422190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222025Inst : IEnumerable<long>
{
public static readonly long[] Value=A222025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222025.Bytes);
public long this[int i]=>Value[i];

public static A222025Inst Instance=new A222025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222026
{
public static readonly long[] Value={ 2L,3L,4L,7L,11L,17L,28L,44L,70L,114L,181L,290L,467L,747L,1200L,1926L,3089L,4962L,7963L,12782L,20520L,32935L,52873L,84872L,136236L,218696L,351046L,563519L,904584L,1452049L,2330894L,3741610L,6006140L,9641273L,15476427L,24843256L,39879165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222026Inst : IEnumerable<long>
{
public static readonly long[] Value=A222026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222026.Bytes);
public long this[int i]=>Value[i];

public static A222026Inst Instance=new A222026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222027
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,4L,2L,3L,4L,6L,2L,3L,4L,6L,9L,2L,3L,4L,7L,10L,13L,2L,3L,4L,7L,11L,15L,19L,2L,3L,4L,7L,11L,16L,23L,28L,2L,3L,4L,7L,11L,16L,26L,36L,41L,2L,3L,4L,7L,11L,17L,26L,41L,55L,60L,2L,3L,4L,7L,11L,17L,28L,42L,62L,84L,88L,2L,3L,4L,7L,11L,17L,28L,44L,65L,99L,129L,129L,2L,3L,4L,7L,11L,17L,28L,44L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222027Inst : IEnumerable<long>
{
public static readonly long[] Value=A222027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222027.Bytes);
public long this[int i]=>Value[i];

public static A222027Inst Instance=new A222027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222028
{
public static readonly long[] Value={ 2L,4L,8L,15L,28L,41L,66L,92L,132L,175L,232L,287L,360L,475L,570L,727L,852L,1009L,1220L,1397L,1646L,1891L,2154L,2441L,2772L,3121L,3508L,3891L,4334L,4791L,5282L,5797L,6376L,6983L,7618L,8285L,8984L,9713L,10500L,11319L,12182L,13093L,14028L,15023L,16064L,17157L,18276L,19447L,20680L,21953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222028Inst : IEnumerable<long>
{
public static readonly long[] Value=A222028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222028.Bytes);
public long this[int i]=>Value[i];

public static A222028Inst Instance=new A222028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222029
{
public static readonly long[] Value={ 1L,1L,3L,1L,16L,9L,2L,125L,93L,32L,6L,1296L,1155L,480L,150L,24L,20L,16807L,17025L,7880L,3240L,864L,840L,262144L,292383L,145320L,71610L,24192L,26250L,720L,0L,0L,504L,0L,420L,4782969L,5752131L,3009888L,1692180L,653184L,773920L,46080L,5040L,0L,32256L,0L,26880L,0L,0L,2688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222029Inst : IEnumerable<long>
{
public static readonly long[] Value=A222029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222029.Bytes);
public long this[int i]=>Value[i];

public static A222029Inst Instance=new A222029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222030
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,9L,11L,12L,13L,16L,17L,19L,20L,23L,25L,29L,30L,31L,36L,37L,41L,42L,43L,47L,49L,53L,56L,59L,61L,64L,67L,71L,72L,73L,79L,81L,83L,89L,90L,97L,100L,101L,103L,107L,109L,110L,113L,121L,127L,131L,132L,137L,139L,144L,149L,151L,156L,157L,163L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222030Inst : IEnumerable<long>
{
public static readonly long[] Value=A222030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222030.Bytes);
public long this[int i]=>Value[i];

public static A222030Inst Instance=new A222030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222031
{
public static readonly long[] Value={ 1L,-23L,3592L,-419L,1L,-94L,169659L,-65838L,1092873176L,145023L,1L,-213L,1312544L,-723721L,44648582886L,9188934683L,166629520876208L,2791651635293L,1L,-475L,9032603L,-9455070L,3949512899743L,-97215753021L,9776785708507683L,-53144327916296L,-134884469547631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222031Inst : IEnumerable<long>
{
public static readonly long[] Value=A222031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222031.Bytes);
public long this[int i]=>Value[i];

public static A222031Inst Instance=new A222031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222032
{
public static readonly long[] Value={ 1L,1L,23L,1L,1L,1L,47L,1L,2209L,47L,1L,1L,71L,1L,5041L,71L,357911L,5041L,1L,1L,95L,1L,9025L,19L,857375L,361L,11875L,1L,1L,119L,1L,2023L,1L,240737L,14161L,200533921L,1685159L,4857223L,1L,1L,143L,1L,1573L,143L,2924207L,20449L,418161601L,2924207L,27217619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222032Inst : IEnumerable<long>
{
public static readonly long[] Value=A222032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222032.Bytes);
public long this[int i]=>Value[i];

public static A222032Inst Instance=new A222032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222033
{
public static readonly BigInteger[] Value={ 1L,3L,12L,64L,429L,3459L,32578L,350928L,4254819L,57339343L,850210608L,13755324192L,241123857361L,4552433489355L,92097902228022L,1987543508858416L,45576279808372215L,1106640757105043895L,BigInteger.Parse("28364428977533987380"),BigInteger.Parse("765303225207132783360"),BigInteger.Parse("21681823874743612308981") };
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
public class A222033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222033Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222033.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222033Inst Instance=new A222033Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222034
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,38L,302L,3428L,55083L,1251590L,40289986L,1841412556L,119672298150L,11071253179356L,1459246211179612L,274215745471606536L,BigInteger.Parse("73511068056751643571"),BigInteger.Parse("28128768433558172885958"),BigInteger.Parse("15371204139970896651788090"),BigInteger.Parse("12001328910786418412379456956") };
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
public class A222034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222034Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222034.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222034Inst Instance=new A222034Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222035
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,283L,6501L,234363L,12486181L,939179643L,96206801061L,13036139824123L,2281006244079141L,505073418764455803L,BigInteger.Parse("139105885712904768421"),BigInteger.Parse("46950396347414793682683"),BigInteger.Parse("19169208258193612244036901"),BigInteger.Parse("9360235493546553882893232763"),BigInteger.Parse("5411227090880585168975672572581") };
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
public class A222035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222035Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222035.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222035Inst Instance=new A222035Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222036
{
public static readonly long[] Value={ 2L,4L,7L,12L,20L,33L,53L,85L,137L,221L,355L,570L,915L,1468L,2353L,3772L,6049L,9703L,15565L,24972L,40068L,64291L,103155L,165512L,265564L,426096L,683664L,1096928L,1760005L,2823900L,4530894L,7269730L,11664136L,18714867L,30027612L,48178679L,77301700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222036Inst : IEnumerable<long>
{
public static readonly long[] Value=A222036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222036.Bytes);
public long this[int i]=>Value[i];

public static A222036Inst Instance=new A222036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222037
{
public static readonly long[] Value={ 2L,4L,8L,14L,24L,40L,66L,108L,176L,286L,464L,752L,1218L,1972L,3192L,5165L,8356L,13518L,21870L,35385L,57254L,92639L,149893L,242533L,392432L,634981L,1027441L,1662459L,2689940L,4352434L,7042388L,11394779L,18436993L,29831336L,48267423L,78097061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222037Inst : IEnumerable<long>
{
public static readonly long[] Value=A222037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222037.Bytes);
public long this[int i]=>Value[i];

public static A222037Inst Instance=new A222037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222038
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,46L,77L,127L,208L,339L,551L,894L,1448L,2344L,3794L,6141L,9940L,16089L,26041L,42145L,68204L,110371L,178602L,289006L,467648L,756702L,1224404L,1981165L,3205633L,5186867L,8392575L,13579526L,21972200L,35551845L,57524194L,93076232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222038Inst : IEnumerable<long>
{
public static readonly long[] Value=A222038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222038.Bytes);
public long this[int i]=>Value[i];

public static A222038Inst Instance=new A222038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222039
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,79L,131L,215L,351L,571L,927L,1503L,2435L,3943L,6383L,10331L,16719L,27055L,43779L,70839L,114623L,185467L,300095L,485566L,785663L,1271229L,2056891L,3328120L,5385015L,8713147L,14098187L,22811377L,36909629L,59721097L,96630848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222039Inst : IEnumerable<long>
{
public static readonly long[] Value=A222039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222039.Bytes);
public long this[int i]=>Value[i];

public static A222039Inst Instance=new A222039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222040
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,133L,219L,358L,583L,947L,1536L,2489L,4031L,6526L,10563L,17095L,27664L,44765L,72435L,117206L,189647L,306859L,496512L,803377L,1299895L,2103278L,3403179L,5506463L,8909648L,14416117L,23325771L,37741894L,61067671L,98809571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222040Inst : IEnumerable<long>
{
public static readonly long[] Value=A222040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222040.Bytes);
public long this[int i]=>Value[i];

public static A222040Inst Instance=new A222040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222041
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,222L,364L,594L,966L,1568L,2542L,4118L,6668L,10794L,17470L,28272L,45750L,74029L,119785L,193820L,313612L,507441L,821065L,1328522L,2149608L,3478157L,5627799L,9105998L,14733846L,23839900L,38573810L,62413783L,100987676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222041Inst : IEnumerable<long>
{
public static readonly long[] Value=A222041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222041.Bytes);
public long this[int i]=>Value[i];

public static A222041Inst Instance=new A222041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222042
{
public static readonly long[] Value={ 2L,4L,8L,15L,27L,47L,80L,134L,222L,365L,596L,970L,1575L,2554L,4138L,6701L,10848L,17558L,28415L,45982L,74406L,120397L,194812L,315218L,510039L,825266L,1335314L,2160589L,3495912L,5656510L,9152431L,14808950L,23961390L,38770349L,62731748L,101502106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222042Inst : IEnumerable<long>
{
public static readonly long[] Value=A222042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222042.Bytes);
public long this[int i]=>Value[i];

public static A222042Inst Instance=new A222042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222043
{
public static readonly long[] Value={ 2L,2L,4L,2L,4L,7L,2L,4L,8L,12L,2L,4L,8L,14L,20L,2L,4L,8L,15L,24L,33L,2L,4L,8L,15L,27L,40L,53L,2L,4L,8L,15L,27L,46L,66L,85L,2L,4L,8L,15L,27L,47L,77L,108L,137L,2L,4L,8L,15L,27L,47L,79L,127L,176L,221L,2L,4L,8L,15L,27L,47L,80L,131L,208L,286L,355L,2L,4L,8L,15L,27L,47L,80L,133L,215L,339L,464L,570L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222043Inst : IEnumerable<long>
{
public static readonly long[] Value=A222043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222043.Bytes);
public long this[int i]=>Value[i];

public static A222043Inst Instance=new A222043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222044
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,11L,15L,19L,28L,35L,47L,61L,80L,102L,136L,168L,218L,276L,350L,437L,556L,686L,860L,1063L,1321L,1620L,2005L,2443L,2998L,3649L,4445L,5377L,6531L,7863L,9496L,11398L,13694L,16373L,19603L,23347L,27834L,33058L,39259L,46467L,55020L,64914L,76599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222044Inst : IEnumerable<long>
{
public static readonly long[] Value=A222044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222044.Bytes);
public long this[int i]=>Value[i];

public static A222044Inst Instance=new A222044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222045
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,4L,9L,10L,19L,21L,34L,40L,62L,72L,103L,124L,173L,207L,279L,337L,445L,538L,694L,842L,1077L,1299L,1634L,1977L,2464L,2969L,3669L,4411L,5410L,6488L,7896L,9447L,11442L,13640L,16421L,19536L,23411L,27761L,33124L,39174L,46554L,54915L,65008L,76485L,90258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222045Inst : IEnumerable<long>
{
public static readonly long[] Value=A222045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222045.Bytes);
public long this[int i]=>Value[i];

public static A222045Inst Instance=new A222045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222046
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,4L,2L,5L,0L,7L,1L,7L,-1L,8L,-1L,12L,-5L,11L,-3L,13L,-8L,18L,-8L,18L,-14L,22L,-14L,28L,-21L,29L,-20L,34L,-33L,43L,-33L,49L,-44L,54L,-48L,67L,-64L,73L,-66L,85L,-87L,105L,-94L,114L,-120L,132L,-128L,156L,-159L,174L,-172L,203L,-213L,234L,-232L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222046Inst : IEnumerable<long>
{
public static readonly long[] Value=A222046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222046.Bytes);
public long this[int i]=>Value[i];

public static A222046Inst Instance=new A222046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222047
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,11L,17L,28L,41L,66L,93L,140L,195L,282L,384L,541L,722L,992L,1311L,1762L,2299L,3045L,3929L,5127L,6559L,8458L,10726L,13689L,17225L,21780L,27224L,34134L,42387L,52769L,65138L,80544L,98887L,121538L,148456L,181456L,220590L,268252L,324677L,392961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222047Inst : IEnumerable<long>
{
public static readonly long[] Value=A222047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222047.Bytes);
public long this[int i]=>Value[i];

public static A222047Inst Instance=new A222047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222048
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,9L,18L,26L,45L,62L,99L,135L,204L,274L,396L,527L,741L,973L,1333L,1736L,2331L,3007L,3970L,5079L,6615L,8393L,10796L,13605L,17320L,21673L,27339L,34001L,42540L,52597L,65324L,80332L,99127L,121274L,148745L,181131L,220956L,267852L,325114L,392476L,474178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222048Inst : IEnumerable<long>
{
public static readonly long[] Value=A222048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222048.Bytes);
public long this[int i]=>Value[i];

public static A222048Inst Instance=new A222048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222049
{
public static readonly long[] Value={ 0L,1L,1L,2L,0L,2L,-1L,2L,-4L,4L,-6L,5L,-9L,8L,-12L,14L,-19L,19L,-22L,26L,-32L,38L,-41L,48L,-56L,65L,-70L,84L,-95L,107L,-115L,133L,-153L,172L,-186L,212L,-240L,264L,-289L,325L,-366L,400L,-437L,485L,-544L,597L,-649L,714L,-799L,869L,-942L,1037L,-1148L,1246L,-1351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222049Inst : IEnumerable<long>
{
public static readonly long[] Value=A222049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222049.Bytes);
public long this[int i]=>Value[i];

public static A222049Inst Instance=new A222049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222050
{
public static readonly BigInteger[] Value={ 1L,1L,5L,30L,209L,1573L,12478L,102714L,869193L,7514445L,66083025L,589294500L,5316256278L,48431659786L,444928748618L,4117185679310L,38340948482745L,359047299072777L,3379057486089649L,31942315551724102L,303158909307122141L,2887629443604011421L,BigInteger.Parse("27595392738011189028") };
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
public class A222050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222050Inst Instance=new A222050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222051
{
public static readonly BigInteger[] Value={ 1L,6L,150L,4200L,131670L,4360356L,149885736L,5287716720L,190170736470L,6941694002100L,256393942704900L,9561265547652000L,359399657792284200L,13600394660797333200UL,BigInteger.Parse("517621830467456905200"),BigInteger.Parse("19798076590576557847200"),BigInteger.Parse("760517744810283004728150"),BigInteger.Parse("29325625363665142395552900") };
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
public class A222051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222051Inst Instance=new A222051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222052
{
public static readonly ulong[] Value={ 1L,3L,25L,210L,1881L,17303L,162214L,1540710L,14776281L,142774455L,1387743525L,13553773500L,132906406950L,1307654814222L,12902933709922L,127632756058610L,1265251299930585L,12566655467547195L,125025126985317013L,1245750306517239978L,12429515281592007781UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222052Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A222052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222052.Bytes);
public ulong this[int i]=>Value[i];

public static A222052Inst Instance=new A222052Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222053
{
public static readonly BigInteger[] Value={ 1L,1L,32L,3536L,877221L,394506859L,284110844070L,302350295364613L,449340338669205876L,BigInteger.Parse("894210483750815778132"),BigInteger.Parse("2306748823711254973903838"),BigInteger.Parse("7516588630649080782251419791"),BigInteger.Parse("30292392269310179039574629318038"),BigInteger.Parse("148358895760995636729844370111255773") };
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
public class A222053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222053Inst Instance=new A222053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222054
{
public static readonly BigInteger[] Value={ 1L,1L,128L,90621L,193322261L,933620289929L,8632521193856886L,BigInteger.Parse("136885314823146617517"),BigInteger.Parse("3443427946573913689696192"),BigInteger.Parse("129667338445150206244162849650"),BigInteger.Parse("6988095504452769015520539806767120"),BigInteger.Parse("520011535068804196524689647521015780176") };
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
public class A222054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222054Inst Instance=new A222054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222055
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,19L,79L,454L,2673L,20789L,159101L,1568786L,14804701L,177333727L,1991552627L,28122135014L,366398602529L,5965436400009L,88463085201433L,1632635041751362L,27151272591960661L,560416797991873451L,10329130452139887191UL,BigInteger.Parse("235856196146890193062") };
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
public class A222055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222055Inst Instance=new A222055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222056
{
public static readonly long[] Value={ 2L,7L,4L,9L,3L,3L,4L,6L,3L,3L,8L,6L,5L,2L,5L,5L,8L,8L,9L,1L,7L,5L,3L,8L,7L,3L,8L,7L,2L,2L,6L,7L,9L,3L,5L,6L,9L,0L,9L,8L,1L,6L,4L,6L,1L,9L,7L,5L,8L,6L,2L,3L,5L,1L,7L,8L,9L,8L,6L,0L,3L,4L,4L,7L,3L,6L,2L,4L,1L,6L,3L,1L,7L,2L,0L,3L,1L,7L,5L,7L,6L,9L,4L,1L,5L,6L,1L,2L,7L,3L,8L,3L,2L,1L,8L,7L,1L,2L,2L,4L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222056Inst : IEnumerable<long>
{
public static readonly long[] Value=A222056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222056.Bytes);
public long this[int i]=>Value[i];

public static A222056Inst Instance=new A222056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222057
{
public static readonly long[] Value={ 1L,1L,3L,1L,9L,11L,1L,21L,66L,50L,1L,45L,275L,500L,274L,1L,93L,990L,3250L,4110L,1764L,1L,189L,3311L,17500L,38360L,37044L,13068L,1L,381L,10626L,85050L,287700L,469224L,365904L,109584L,1L,765L,33275L,388500L,1904574L,4667544L,6037416L,3945024L,1026576L,1L,1533L,102630L,1705250L,11651850L,40266828L,76839840L,82188000L,46195920L,10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222057Inst : IEnumerable<long>
{
public static readonly long[] Value=A222057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222057.Bytes);
public long this[int i]=>Value[i];

public static A222057Inst Instance=new A222057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222058
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,138L,1095L,10208L,109473L,1328470L,18003675L,269580492L,4420677525L,78801184322L,1517300654415L,31386251780536L,694190761402377L,16348768018619694L,408472183061464515L,10791720442056792740UL,BigInteger.Parse("300605598797790229629"),BigInteger.Parse("8805117712245004098586"),BigInteger.Parse("270562051319419652165175"),BigInteger.Parse("8702576800277309526639504"),BigInteger.Parse("292425620801795849417200881") };
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
public class A222058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222058Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222058.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222058Inst Instance=new A222058Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222059
{
public static readonly BigInteger[] Value={ 0L,1L,5L,44L,590L,11094L,276924L,8821056L,347992560L,16608856176L,941180477760L,62356907861280L,4768658639919360L,416372600735314560L,BigInteger.Parse("41123273761815517440"),BigInteger.Parse("4557176483095745510400"),BigInteger.Parse("562635159090115071744000"),BigInteger.Parse("76906191809174747446425600"),BigInteger.Parse("11573912988161070649533849600") };
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
public class A222059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222059Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222059.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222059Inst Instance=new A222059Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222060
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,1L,9L,11L,0L,1L,21L,66L,50L,0L,1L,45L,275L,500L,274L,0L,1L,93L,990L,3250L,4110L,1764L,0L,1L,189L,3311L,17500L,38360L,37044L,13068L,0L,1L,381L,10626L,85050L,287700L,469224L,365904L,109584L,0L,1L,765L,33275L,388500L,1904574L,4667544L,6037416L,3945024L,1026576L,0L,1L,1533L,102630L,1705250L,11651850L,40266828L,76839840L,82188000L,46195920L,10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222060Inst : IEnumerable<long>
{
public static readonly long[] Value=A222060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222060.Bytes);
public long this[int i]=>Value[i];

public static A222060Inst Instance=new A222060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222061
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,5L,0L,1L,15L,26L,0L,1L,35L,156L,154L,0L,1L,75L,650L,1540L,1044L,0L,1L,155L,2340L,10010L,15660L,8028L,0L,1L,315L,7826L,53900L,146160L,168588L,69264L,0L,1L,635L,25116L,261954L,1096200L,2135448L,1939392L,663696L,0L,1L,1275L,78650L,1196580L,7256844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222061Inst : IEnumerable<long>
{
public static readonly long[] Value=A222061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222061.Bytes);
public long this[int i]=>Value[i];

public static A222061Inst Instance=new A222061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222062
{
public static readonly BigInteger[] Value={ 0L,1L,6L,42L,346L,3310L,36194L,446054L,6122442L,92668302L,1533812722L,27565147126L,534621745178L,11131104732254L,247646911102530L,5863652049020358L,147225092025474154L,3907328980930705966L,BigInteger.Parse("109297865960259305618"),BigInteger.Parse("3214017757399205062550"),BigInteger.Parse("99121172016580291190970") };
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
public class A222062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222062Inst Instance=new A222062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222063
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,7L,0L,1L,21L,47L,0L,1L,49L,282L,342L,0L,1L,105L,1175L,3420L,2754L,0L,1L,217L,4230L,22230L,41310L,24552L,0L,1L,441L,14147L,119700L,385560L,515592L,241128L,0L,1L,889L,45402L,581742L,2891700L,6530832L,6751584L,2592720L,0L,1L,1785L,142175L,2657340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222063Inst : IEnumerable<long>
{
public static readonly long[] Value=A222063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222063.Bytes);
public long this[int i]=>Value[i];

public static A222063Inst Instance=new A222063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222064
{
public static readonly BigInteger[] Value={ 0L,1L,8L,69L,674L,7455L,92540L,1276569L,19394870L,321982323L,5801055632L,112753640109L,2352074473226L,52419496769991L,1243115350746404L,31257697673933889L,830700701852539742L,BigInteger.Parse("23266435856618600859"),BigInteger.Parse("684997785857198880056"),BigInteger.Parse("21149644833172896698709") };
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
public class A222064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222064Inst Instance=new A222064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222065
{
public static readonly BigInteger[] Value={ 2L,12L,2144L,9277152L,934520913216L,2152453777211211412L,BigInteger.Parse("112252999240982874562527216"),BigInteger.Parse("131765033045251672652319572331061144"),BigInteger.Parse("3467852755777932367855581588111341658695967892") };
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
public class A222065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222065Inst Instance=new A222065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222066
{
public static readonly long[] Value={ 8L,8L,3L,8L,8L,3L,4L,7L,6L,4L,8L,3L,1L,8L,4L,4L,0L,5L,5L,0L,1L,0L,5L,5L,4L,5L,2L,6L,3L,1L,0L,6L,1L,2L,9L,9L,1L,0L,6L,0L,4L,4L,9L,2L,2L,1L,1L,0L,5L,9L,2L,5L,4L,5L,7L,3L,5L,4L,2L,4L,8L,3L,6L,2L,4L,4L,2L,0L,7L,7L,9L,9L,0L,3L,8L,8L,1L,6L,8L,9L,9L,2L,8L,1L,4L,9L,2L,2L,0L,8L,9L,5L,4L,7L,7L,5L,9L,8L,2L,9L,5L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222066Inst : IEnumerable<long>
{
public static readonly long[] Value=A222066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222066.Bytes);
public long this[int i]=>Value[i];

public static A222066Inst Instance=new A222066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222067
{
public static readonly long[] Value={ 7L,2L,1L,6L,8L,7L,8L,3L,6L,4L,8L,7L,0L,3L,2L,2L,0L,5L,6L,3L,6L,4L,3L,5L,9L,7L,5L,6L,2L,7L,4L,4L,6L,8L,1L,9L,5L,5L,9L,5L,0L,2L,1L,8L,9L,0L,8L,7L,6L,5L,8L,5L,9L,5L,0L,2L,3L,2L,5L,2L,9L,0L,8L,1L,0L,4L,9L,7L,2L,0L,9L,0L,3L,7L,8L,6L,6L,6L,6L,8L,2L,1L,1L,7L,1L,4L,4L,2L,4L,4L,4L,8L,2L,1L,8L,6L,9L,0L,6L,5L,3L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222067Inst : IEnumerable<long>
{
public static readonly long[] Value=A222067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222067.Bytes);
public long this[int i]=>Value[i];

public static A222067Inst Instance=new A222067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222068
{
public static readonly long[] Value={ 6L,1L,6L,8L,5L,0L,2L,7L,5L,0L,6L,8L,0L,8L,4L,9L,1L,3L,6L,7L,7L,1L,5L,5L,6L,8L,7L,4L,9L,2L,2L,5L,9L,4L,4L,5L,9L,5L,7L,1L,0L,6L,2L,1L,2L,9L,5L,2L,5L,4L,9L,4L,1L,4L,1L,5L,0L,8L,3L,4L,3L,3L,6L,0L,1L,3L,7L,5L,2L,8L,0L,1L,4L,0L,1L,2L,0L,0L,3L,2L,7L,6L,8L,7L,6L,1L,0L,8L,3L,7L,7L,3L,2L,4L,0L,9L,5L,1L,4L,4L,8L,9L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222068Inst : IEnumerable<long>
{
public static readonly long[] Value=A222068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222068.Bytes);
public long this[int i]=>Value[i];

public static A222068Inst Instance=new A222068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222069
{
public static readonly long[] Value={ 4L,6L,5L,2L,5L,7L,6L,1L,3L,3L,0L,9L,2L,5L,8L,6L,3L,5L,6L,1L,0L,5L,0L,4L,0L,6L,2L,4L,1L,1L,2L,9L,3L,6L,8L,5L,9L,9L,4L,6L,5L,7L,7L,5L,1L,3L,9L,6L,5L,3L,6L,1L,5L,7L,7L,4L,3L,5L,6L,6L,4L,4L,4L,5L,0L,1L,3L,2L,7L,1L,8L,4L,1L,8L,8L,8L,7L,1L,8L,1L,4L,3L,1L,1L,1L,6L,0L,0L,8L,9L,1L,5L,4L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222069Inst : IEnumerable<long>
{
public static readonly long[] Value=A222069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222069.Bytes);
public long this[int i]=>Value[i];

public static A222069Inst Instance=new A222069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222070
{
public static readonly long[] Value={ 3L,7L,2L,9L,4L,7L,5L,4L,5L,5L,8L,2L,0L,6L,4L,9L,3L,9L,5L,6L,3L,4L,7L,7L,5L,5L,8L,6L,7L,9L,9L,5L,8L,1L,0L,6L,3L,9L,3L,6L,6L,4L,7L,9L,7L,2L,6L,8L,3L,8L,7L,3L,6L,3L,1L,1L,1L,4L,0L,4L,0L,6L,5L,5L,9L,7L,2L,8L,3L,1L,7L,2L,0L,2L,9L,6L,8L,3L,2L,1L,9L,5L,2L,2L,5L,2L,6L,7L,2L,1L,6L,3L,5L,3L,4L,0L,5L,4L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222070Inst : IEnumerable<long>
{
public static readonly long[] Value=A222070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222070.Bytes);
public long this[int i]=>Value[i];

public static A222070Inst Instance=new A222070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222071
{
public static readonly long[] Value={ 2L,9L,5L,2L,9L,7L,8L,7L,3L,1L,4L,5L,7L,1L,2L,5L,7L,3L,0L,9L,9L,7L,7L,4L,4L,2L,9L,2L,1L,0L,4L,8L,9L,4L,7L,8L,1L,1L,6L,4L,3L,1L,3L,1L,9L,6L,7L,5L,0L,9L,6L,2L,6L,3L,7L,5L,3L,7L,5L,7L,5L,0L,5L,7L,5L,0L,5L,3L,7L,0L,9L,4L,4L,5L,2L,0L,5L,4L,3L,4L,3L,2L,1L,4L,9L,2L,0L,9L,6L,2L,2L,1L,5L,2L,6L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222071Inst : IEnumerable<long>
{
public static readonly long[] Value=A222071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222071.Bytes);
public long this[int i]=>Value[i];

public static A222071Inst Instance=new A222071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222072
{
public static readonly long[] Value={ 2L,5L,3L,6L,6L,9L,5L,0L,7L,9L,0L,1L,0L,4L,8L,0L,1L,3L,6L,3L,6L,5L,6L,3L,3L,6L,6L,3L,7L,6L,8L,3L,6L,2L,2L,7L,2L,1L,2L,8L,3L,2L,2L,5L,4L,3L,5L,5L,9L,5L,1L,6L,1L,8L,9L,8L,8L,1L,9L,7L,5L,5L,0L,4L,9L,4L,7L,1L,5L,7L,6L,9L,4L,1L,8L,8L,2L,0L,8L,2L,3L,4L,1L,1L,7L,7L,5L,6L,9L,5L,9L,2L,3L,8L,3L,5L,9L,1L,8L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222072Inst : IEnumerable<long>
{
public static readonly long[] Value=A222072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222072.Bytes);
public long this[int i]=>Value[i];

public static A222072Inst Instance=new A222072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222073
{
public static readonly long[] Value={ 1L,2L,2L,1L,6L,6L,9L,9L,6L,3L,9L,7L,7L,2L,9L,8L,8L,4L,0L,5L,1L,1L,8L,9L,1L,2L,9L,7L,6L,8L,3L,1L,5L,2L,4L,8L,2L,8L,4L,9L,8L,0L,7L,0L,7L,0L,9L,4L,8L,8L,2L,7L,5L,5L,0L,1L,1L,8L,3L,5L,0L,5L,7L,8L,2L,7L,9L,0L,7L,7L,9L,4L,4L,1L,9L,6L,9L,3L,1L,3L,2L,5L,9L,1L,9L,6L,1L,5L,8L,1L,4L,8L,1L,9L,5L,5L,5L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222073Inst : IEnumerable<long>
{
public static readonly long[] Value=A222073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222073.Bytes);
public long this[int i]=>Value[i];

public static A222073Inst Instance=new A222073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222074
{
public static readonly long[] Value={ 1L,5L,9L,3L,8L,5L,2L,5L,2L,4L,9L,2L,3L,3L,4L,0L,9L,0L,2L,4L,1L,0L,1L,1L,0L,9L,8L,9L,8L,0L,9L,5L,6L,0L,4L,5L,0L,4L,1L,8L,2L,3L,2L,8L,4L,7L,0L,2L,1L,2L,2L,3L,9L,0L,9L,1L,3L,2L,7L,7L,3L,1L,4L,4L,1L,9L,9L,1L,4L,0L,5L,8L,4L,0L,2L,9L,2L,3L,9L,7L,1L,0L,8L,6L,3L,4L,5L,5L,7L,3L,1L,6L,3L,2L,8L,3L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222074Inst : IEnumerable<long>
{
public static readonly long[] Value=A222074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222074.Bytes);
public long this[int i]=>Value[i];

public static A222074Inst Instance=new A222074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222075
{
public static readonly long[] Value={ 1L,8L,8L,4L,1L,0L,3L,8L,7L,9L,3L,8L,9L,9L,0L,0L,2L,4L,1L,3L,4L,8L,2L,8L,7L,0L,4L,5L,9L,6L,2L,4L,7L,0L,3L,0L,4L,4L,4L,8L,2L,1L,9L,8L,3L,8L,7L,8L,7L,5L,7L,0L,8L,8L,9L,4L,1L,0L,6L,3L,1L,6L,8L,7L,9L,1L,9L,0L,9L,9L,5L,1L,8L,6L,6L,7L,7L,5L,3L,4L,9L,3L,7L,0L,7L,5L,6L,5L,5L,6L,3L,2L,8L,0L,8L,3L,9L,5L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222075Inst : IEnumerable<long>
{
public static readonly long[] Value=A222075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222075.Bytes);
public long this[int i]=>Value[i];

public static A222075Inst Instance=new A222075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222076
{
public static readonly BigInteger[] Value={ 1L,3L,23L,320L,6397L,166467L,5338412L,203578776L,9001795829L,452924585465L,25555585227999L,1598279794889076L,109748572718377660L,8209004345714098500L,BigInteger.Parse("664396187060996529528"),BigInteger.Parse("57853075421585981420208"),BigInteger.Parse("5393119810256349152565573"),BigInteger.Parse("535908449308064099732283429"),BigInteger.Parse("56548822143306498413322880709") };
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
public class A222076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222076Inst Instance=new A222076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222077
{
public static readonly BigInteger[] Value={ 1L,4L,34L,504L,10572L,285408L,9419440L,367571200L,16562241744L,846509123520L,48401180913824L,3061687935718272L,212316590908782336L,16018267935253721088UL,BigInteger.Parse("1306322033185206970368"),BigInteger.Parse("114519518777575592865792"),BigInteger.Parse("10740222055670467832259840"),BigInteger.Parse("1073051903942317493993088000") };
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
public class A222077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222077Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222077.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222077Inst Instance=new A222077Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222078
{
public static readonly BigInteger[] Value={ 1L,5L,47L,742L,16357L,459369L,15651260L,626935936L,28872594389L,1503262704775L,87328047029511L,5600639046765690L,393092088068927860L,BigInteger.Parse("29974039720132943036"),BigInteger.Parse("2467669218502361588472"),BigInteger.Parse("218168186315818183909344"),BigInteger.Parse("20617367868151866462395205"),BigInteger.Parse("2074120178028300166990286691") };
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
public class A222078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222078Inst Instance=new A222078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222079
{
public static readonly BigInteger[] Value={ 1L,6L,62L,1040L,24076L,703800L,24786512L,1020779520L,48130232528L,2557117300640L,151180506557280L,9846055638729216L,700523098562671360L,BigInteger.Parse("54066239308284456960"),BigInteger.Parse("4499576117943522662400"),BigInteger.Parse("401709919258066014720000"),BigInteger.Parse("38299206898825369235170560"),BigInteger.Parse("3883999501445283274005895680") };
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
public class A222079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222079Inst Instance=new A222079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222080
{
public static readonly BigInteger[] Value={ 1L,2L,11L,92L,1013L,13726L,219919L,4057048L,84545129L,1961698586L,50111003987L,1396488977908L,42139540225501L,1368234341961718L,47547441824994647L,1760308790559597104L,BigInteger.Parse("69151746439874522321"),BigInteger.Parse("2872358517303945656242"),BigInteger.Parse("125758844338252841129371"),BigInteger.Parse("5787515297333376814677004") };
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
public class A222080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222080Inst Instance=new A222080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222081
{
public static readonly BigInteger[] Value={ 1L,1L,5L,41L,453L,6205L,100649L,1878277L,39534033L,924986401L,23790991061L,666732284009L,20211529694661L,658743175016461L,22964324182662569L,852450674859207605L,BigInteger.Parse("33563386167190876321"),BigInteger.Parse("1396839898167086931137"),BigInteger.Parse("61260669590285253202981"),BigInteger.Parse("2823455397312949805962921") };
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
public class A222081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222081Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222081.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222081Inst Instance=new A222081Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222082
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,40L,67L,126L,203L,354L,571L,908L,1486L,2250L,3586L,5322L,8186L,12234L,17976L,26970L,38435L,57024L,80805L,116376L,165914L,232352L,332196L,456154L,645469L,885826L,1225998L,1692686L,2290512L,3168986L,4242896L,5805526L,7782803L,10459912L,14110205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222082Inst : IEnumerable<long>
{
public static readonly long[] Value=A222082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222082.Bytes);
public long this[int i]=>Value[i];

public static A222082Inst Instance=new A222082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222083
{
public static readonly long[] Value={ 1L,3L,9L,22L,51L,114L,230L,468L,885L,1674L,3045L,5418L,9560L,16341L,27912L,46383L,76794L,125205L,201580L,322980L,508710L,800495L,1241190L,1916682L,2935492L,4456617L,6747393L,10101532L,15105042L,22378362L,33035166L,48520809L,70776711L,103072393L,148899756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222083Inst : IEnumerable<long>
{
public static readonly long[] Value=A222083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222083.Bytes);
public long this[int i]=>Value[i];

public static A222083Inst Instance=new A222083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222084
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,3L,2L,4L,3L,3L,2L,4L,2L,3L,3L,5L,2L,5L,2L,4L,3L,3L,2L,6L,3L,3L,4L,4L,2L,4L,2L,6L,3L,3L,3L,6L,2L,3L,3L,5L,2L,5L,2L,4L,4L,3L,2L,8L,3L,5L,3L,4L,2L,7L,3L,5L,3L,3L,2L,5L,2L,3L,4L,7L,3L,5L,2L,4L,3L,4L,2L,7L,2L,3L,5L,4L,3L,5L,2L,7L,5L,3L,2L,6L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222084Inst : IEnumerable<long>
{
public static readonly long[] Value=A222084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222084.Bytes);
public long this[int i]=>Value[i];

public static A222084Inst Instance=new A222084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222085
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,6L,8L,15L,13L,8L,12L,10L,14L,10L,9L,31L,18L,21L,20L,12L,11L,14L,24L,24L,31L,16L,40L,14L,30L,11L,32L,63L,15L,20L,13L,25L,38L,22L,17L,20L,42L,19L,44L,18L,18L,26L,48L,52L,57L,43L,21L,20L,54L,66L,17L,22L,23L,32L,60L,15L,62L,34L,20L,127L,19L,23L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222085Inst : IEnumerable<long>
{
public static readonly long[] Value=A222085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222085.Bytes);
public long this[int i]=>Value[i];

public static A222085Inst Instance=new A222085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222086
{
public static readonly long[] Value={ 1L,30L,360L,840L,11088L,18018L,1713600L,32760L,327600L,350064L,39437798400L,180180L,8532905472000L,47361600L,720720L,1750320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222086Inst : IEnumerable<long>
{
public static readonly long[] Value=A222086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222086.Bytes);
public long this[int i]=>Value[i];

public static A222086Inst Instance=new A222086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222087
{
public static readonly long[] Value={ 1L,2L,6L,14L,15L,20L,22L,24L,33L,38L,46L,49L,51L,52L,62L,63L,86L,87L,91L,92L,93L,95L,118L,119L,121L,141L,142L,143L,145L,147L,148L,153L,158L,159L,165L,166L,169L,183L,198L,206L,210L,215L,217L,219L,244L,247L,249L,253L,262L,267L,270L,278L,279L,286L,287L,295L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222087Inst : IEnumerable<long>
{
public static readonly long[] Value=A222087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222087.Bytes);
public long this[int i]=>Value[i];

public static A222087Inst Instance=new A222087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222088
{
public static readonly long[] Value={ 5L,23L,44L,84L,132L,185L,335L,368L,1342L,2226L,3354L,4726L,7359L,7598L,8436L,10234L,12123L,18078L,18744L,19848L,20492L,20922L,21823L,21902L,23218L,24069L,24221L,31678L,36510L,36849L,40235L,45046L,46916L,49356L,49769L,50560L,51780L,52716L,53079L,59942L,60150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222088Inst : IEnumerable<long>
{
public static readonly long[] Value=A222088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222088.Bytes);
public long this[int i]=>Value[i];

public static A222088Inst Instance=new A222088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222089
{
public static readonly long[] Value={ 1L,4L,8L,16L,24L,48L,96L,192L,384L,480L,768L,960L,1920L,3840L,5760L,7680L,11520L,19440L,23040L,26880L,46080L,53760L,80640L,107520L,161280L,215040L,322560L,612360L,645120L,967680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222089Inst : IEnumerable<long>
{
public static readonly long[] Value=A222089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222089.Bytes);
public long this[int i]=>Value[i];

public static A222089Inst Instance=new A222089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222090
{
public static readonly long[] Value={ 3L,31L,308L,3034L,29860L,293848L,2891636L,28455036L,280009384L,2755404412L,27114269752L,266815111088L,2625565876172L,25836603103756L,254242357913972L,2501845009992824L,24619140986161492L,242262050800828048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222090Inst : IEnumerable<long>
{
public static readonly long[] Value=A222090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222090.Bytes);
public long this[int i]=>Value[i];

public static A222090Inst Instance=new A222090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222091
{
public static readonly BigInteger[] Value={ 8L,306L,11698L,439979L,16518325L,620167586L,23285438194L,874320487561L,32829136547878L,1232675333611674L,46284755942965861L,1737909791864677612L,BigInteger.Parse("65255401994426759727"),BigInteger.Parse("2450223514629565888639"),BigInteger.Parse("92001505833953763778608") };
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
public class A222091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222091Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222091.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222091Inst Instance=new A222091Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222092
{
public static readonly BigInteger[] Value={ 21L,3014L,439644L,62776264L,8936245171L,1271770432077L,181000238870646L,25760940724765249L,3666476510299319316L,BigInteger.Parse("521840279989725924865"),BigInteger.Parse("74272277349160073400124"),BigInteger.Parse("10570998423180909949529557") };
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
public class A222092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222092Inst Instance=new A222092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222093
{
public static readonly long[] Value={ 1L,3L,3L,8L,31L,8L,21L,306L,308L,21L,55L,3014L,11698L,3034L,55L,144L,29671L,439644L,439979L,29860L,144L,377L,292017L,16509768L,62776264L,16518325L,293848L,377L,987L,2873693L,619931605L,8938090933L,8936245171L,620167586L,2891636L,987L,2584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222093Inst : IEnumerable<long>
{
public static readonly long[] Value=A222093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222093.Bytes);
public long this[int i]=>Value[i];

public static A222093Inst Instance=new A222093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222094
{
public static readonly long[] Value={ 3L,31L,306L,3014L,29671L,292017L,2873693L,28278630L,278273755L,2738325414L,26946205188L,265161285275L,2609291560659L,25676457366269L,252666460567318L,2486337558528381L,24466541550530492L,240760412205806134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222094Inst : IEnumerable<long>
{
public static readonly long[] Value=A222094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222094.Bytes);
public long this[int i]=>Value[i];

public static A222094Inst Instance=new A222094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222095
{
public static readonly BigInteger[] Value={ 8L,308L,11698L,439644L,16509768L,619931605L,23277561783L,874033601365L,32818427706942L,1232273510253579L,46269666765829350L,1737343162836648930L,BigInteger.Parse("65234125114783960319"),BigInteger.Parse("2449424592893411034116"),BigInteger.Parse("91971507601402242033646") };
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
public class A222095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222095Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222095.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222095Inst Instance=new A222095Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222096
{
public static readonly BigInteger[] Value={ 21L,3034L,439979L,62776264L,8938090933L,1272224461900L,181075284907525L,25772100415484857L,3668085288770478139L,BigInteger.Parse("522070083851345084353"),BigInteger.Parse("74305016748179915810183"),BigInteger.Parse("10575659301127035698958882") };
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
public class A222096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222096Inst Instance=new A222096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222097
{
public static readonly BigInteger[] Value={ 1L,46L,17694L,57455502L,1579646506770L,368159933254055152L,BigInteger.Parse("727800879295716577956574") };
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
public class A222097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222097Inst Instance=new A222097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222098
{
public static readonly long[] Value={ 4L,46L,530L,6108L,70394L,811286L,9350020L,107758398L,1241908834L,14312922076L,164955536810L,1901102303238L,21910085816324L,252512376457166L,2910189435065650L,33539752256081628L,386543558932945114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222098Inst : IEnumerable<long>
{
public static readonly long[] Value=A222098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222098.Bytes);
public long this[int i]=>Value[i];

public static A222098Inst Instance=new A222098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222099
{
public static readonly BigInteger[] Value={ 16L,530L,17694L,591476L,19776286L,661254950L,22110369320L,739304841874L,24720154977078L,826568484486164L,27637992729347366L,924132309919617038L,BigInteger.Parse("30900237030548459544"),BigInteger.Parse("1033212061004215656522"),BigInteger.Parse("34547539617728922860542") };
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
public class A222099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222099Inst Instance=new A222099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222100
{
public static readonly BigInteger[] Value={ 64L,6108L,591476L,57455502L,5585183876L,543019517890L,52797111762730L,5133443560512386L,499123853931892192L,BigInteger.Parse("48529752000392073542"),BigInteger.Parse("4718542457622698098922"),BigInteger.Parse("458783377102773490580554") };
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
public class A222100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222100Inst Instance=new A222100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222101
{
public static readonly BigInteger[] Value={ 256L,70394L,19776286L,5585183876L,1579646506770L,446953377273926L,126478496485182708L,BigInteger.Parse("35792034236612394178"),BigInteger.Parse("10128858887832420661250"),BigInteger.Parse("2866394503623906825124412"),BigInteger.Parse("811169823087180821333896378") };
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
public class A222101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222101Inst Instance=new A222101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222102
{
public static readonly BigInteger[] Value={ 1024L,811286L,661254950L,543019517890L,446953377273926L,368159933254055152L,BigInteger.Parse("303334194244175791146"),BigInteger.Parse("249944768409450118648354"),BigInteger.Parse("205958518729604434520433962"),BigInteger.Parse("169714897772459528956828618538") };
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
public class A222102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222102Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222102.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222102Inst Instance=new A222102Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222103
{
public static readonly BigInteger[] Value={ 4096L,9350020L,22110369320L,52797111762730L,126478496485182708L,BigInteger.Parse("303334194244175791146"),BigInteger.Parse("727800879295716577956574"),BigInteger.Parse("1746526809024942183917202210"),BigInteger.Parse("4191462990610923771050017388728") };
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
public class A222103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222103Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A222103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222103.Bytes);
public BigInteger this[int i]=>Value[i];

public static A222103Inst Instance=new A222103Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A222104
{
public static readonly long[] Value={ 1L,4L,4L,16L,46L,16L,64L,530L,530L,64L,256L,6108L,17694L,6108L,256L,1024L,70394L,591476L,591476L,70394L,1024L,4096L,811286L,19776286L,57455502L,19776286L,811286L,4096L,16384L,9350020L,661254950L,5585183876L,5585183876L,661254950L,9350020L,16384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A222104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A222104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A222104Inst : IEnumerable<long>
{
public static readonly long[] Value=A222104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A222104.Bytes);
public long this[int i]=>Value[i];

public static A222104Inst Instance=new A222104Inst();

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