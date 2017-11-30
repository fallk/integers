using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A143003
{
public static readonly BigInteger[] Value={ 0L,1L,21L,1091L,114520L,21298264L,6410456640L,2923097201856L,1920450126458880L,1747596822651334656L,BigInteger.Parse("2133806329230225408000"),BigInteger.Parse("3405545462439659704320000"),BigInteger.Parse("6950705677729940374290432000"),BigInteger.Parse("17807686090745585163974737920000") };
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
public class A143003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143003Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143003.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143003Inst Instance=new A143003Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143004
{
public static readonly BigInteger[] Value={ 0L,1L,45L,4211L,704120L,191875384L,79755181632L,48072816950976L,40372248180436992L,BigInteger.Parse("45735898093934800896"),BigInteger.Parse("68049684624570789888000"),BigInteger.Parse("130036437291331549384704000"),BigInteger.Parse("313117351023401464093212672000") };
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
public class A143004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143004Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143004.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143004Inst Instance=new A143004Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143005
{
public static readonly BigInteger[] Value={ 0L,1L,81L,12491L,3176120L,1235165464L,697648230720L,550023729068736L,586201214122536960L,BigInteger.Parse("822460381655068717056"),BigInteger.Parse("1485544574481829982208000"),BigInteger.Parse("3389058487000919282503680000"),BigInteger.Parse("9606157364646714324010401792000") };
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
public class A143005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143005Inst Instance=new A143005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143006
{
public static readonly BigInteger[] Value={ 0L,1L,129L,30251L,11129080L,5985956824L,4501140404544L,4577449694922432L,6130634638657941504L,BigInteger.Parse("10576998168036159614976"),BigInteger.Parse("23068077837238986190848000"),BigInteger.Parse("62571876653848665596203008000"),BigInteger.Parse("208106990164246904792046895104000") };
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
public class A143006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143006Inst Instance=new A143006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143007
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,13L,13L,1L,1L,25L,73L,25L,1L,1L,41L,253L,253L,41L,1L,1L,61L,661L,1445L,661L,61L,1L,1L,85L,1441L,5741L,5741L,1441L,85L,1L,1L,113L,2773L,17861L,33001L,17861L,2773L,113L,1L,1L,145L,4873L,46705L,142001L,142001L,46705L,4873L,145L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143007Inst : IEnumerable<long>
{
public static readonly long[] Value=A143007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143007.Bytes);
public long this[int i]=>Value[i];

public static A143007Inst Instance=new A143007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143008
{
public static readonly long[] Value={ 1L,13L,73L,253L,661L,1441L,2773L,4873L,7993L,12421L,18481L,26533L,36973L,50233L,66781L,87121L,111793L,141373L,176473L,217741L,265861L,321553L,385573L,458713L,541801L,635701L,741313L,859573L,991453L,1137961L,1300141L,1479073L,1675873L,1891693L,2127721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143008Inst : IEnumerable<long>
{
public static readonly long[] Value=A143008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143008.Bytes);
public long this[int i]=>Value[i];

public static A143008Inst Instance=new A143008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143009
{
public static readonly long[] Value={ 1L,25L,253L,1445L,5741L,17861L,46705L,107353L,223465L,430081L,776821L,1331485L,2184053L,3451085L,5280521L,7856881L,11406865L,16205353L,22581805L,30927061L,41700541L,55437845L,72758753L,94375625L,121102201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143009Inst : IEnumerable<long>
{
public static readonly long[] Value=A143009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143009.Bytes);
public long this[int i]=>Value[i];

public static A143009Inst Instance=new A143009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143010
{
public static readonly long[] Value={ 1L,41L,661L,5741L,33001L,142001L,494341L,1465661L,3833941L,9073501L,19789001L,40328641L,77620661L,142282141L,250054001L,423621001L,694880441L,1107728161L,1721435341L,2614694501L,3890418001L,5681377241L,8156775661L,11529853541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143010Inst : IEnumerable<long>
{
public static readonly long[] Value=A143010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143010.Bytes);
public long this[int i]=>Value[i];

public static A143010Inst Instance=new A143010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143011
{
public static readonly long[] Value={ 1L,61L,1441L,17861L,142001L,819005L,3713305L,13980205L,45432805L,131091505L,342981013L,826861993L,1859914733L,3942293993L,7937011013L,15276834025L,28261896025L,50477521525L,87368496025L,147013666525L,241153442041L,386532523301L,606631094081L,933869816501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143011Inst : IEnumerable<long>
{
public static readonly long[] Value=A143011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143011.Bytes);
public long this[int i]=>Value[i];

public static A143011Inst Instance=new A143011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143012
{
public static readonly BigInteger[] Value={ 151L,2359L,599479L,9588151L,2454285751L,39268347319L,10052678938039L,41175768098368951L,658812288653553079L,BigInteger.Parse("2698495133088002829751"),BigInteger.Parse("690814754065816531725751"),BigInteger.Parse("11053036065049294753459639"),BigInteger.Parse("2829577232652317876553477559"),BigInteger.Parse("11589948344943812957569751412151") };
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
public class A143012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143012Inst Instance=new A143012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143013
{
public static readonly long[] Value={ 1L,2L,3L,7L,17L,43L,114L,310L,861L,2433L,6970L,20198L,59101L,174373L,518179L,1549545L,4659399L,14079553L,42732230L,130208246L,398174723L,1221573603L,3758835953L,11597578995L,35872937745L,111216324015L,345539568900L,1075693015920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143013Inst : IEnumerable<long>
{
public static readonly long[] Value=A143013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143013.Bytes);
public long this[int i]=>Value[i];

public static A143013Inst Instance=new A143013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143014
{
public static readonly BigInteger[] Value={ 1L,3L,9L,27L,189L,2457L,12285L,159705L,9103185L,2030010255L,11000625571845L,187010634721365L,45069562967848965L,BigInteger.Parse("188943190838905598464005"),BigInteger.Parse("3169167002067055110614170009605"),BigInteger.Parse("53875839035139936880440890163285") };
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
public class A143014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143014Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143014.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143014Inst Instance=new A143014Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143015
{
public static readonly long[] Value={ 1L,3L,3L,3L,7L,13L,5L,13L,57L,223L,5419L,17L,241L,4192257L,16773121L,17L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143015Inst : IEnumerable<long>
{
public static readonly long[] Value=A143015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143015.Bytes);
public long this[int i]=>Value[i];

public static A143015Inst Instance=new A143015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143048
{
public static readonly long[] Value={ 1L,1L,-5L,-15L,165L,630L,-8151L,-33780L,474045L,2052495L,-30206330L,-134392230L,2040588775L,9248893360L,-143569282680L,-659546365020L,10407737293965L,48303692377425L,-771991701692175L,-3611789245335285L,58311219888996170L,274581478640096340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143048Inst : IEnumerable<long>
{
public static readonly long[] Value=A143048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143048.Bytes);
public long this[int i]=>Value[i];

public static A143048Inst Instance=new A143048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143049
{
public static readonly long[] Value={ 1L,1L,-6L,-21L,286L,1281L,-20592L,-100226L,1749462L,8899086L,-162993402L,-852079872L,16106878320L,85783258295L,-1658113447608L,-8950840125828L,175904428301062L,959332126312266L,-19096256882857668L,-104984591307499239L,2111233112316364434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143049Inst : IEnumerable<long>
{
public static readonly long[] Value=A143049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143049.Bytes);
public long this[int i]=>Value[i];

public static A143049Inst Instance=new A143049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143050
{
public static readonly long[] Value={ 0L,-1L,0L,3L,-3L,2L,-5L,6L,0L,-24L,23L,-23L,47L,7L,88L,143L,-376L,-5L,5L,514L,755L,654L,2304L,-2992L,-3025L,3025L,2271L,11279L,-720L,18847L,-112L,-48141L,48141L,-29182L,85227L,-95338L,8960L,381240L,-389049L,389049L,-761329L,-69609L,-1445240L,-2268369L,6162200L,-110613L,110613L,-8541182L,-12033565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143050Inst : IEnumerable<long>
{
public static readonly long[] Value=A143050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143050.Bytes);
public long this[int i]=>Value[i];

public static A143050Inst Instance=new A143050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143051
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,9L,5L,6L,7L,8L,16L,10L,11L,12L,13L,14L,15L,25L,17L,18L,19L,20L,21L,22L,23L,24L,36L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,49L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,64L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,81L,65L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143051Inst : IEnumerable<long>
{
public static readonly long[] Value=A143051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143051.Bytes);
public long this[int i]=>Value[i];

public static A143051Inst Instance=new A143051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143052
{
public static readonly long[] Value={ 0L,1L,3L,4L,2L,6L,7L,8L,9L,5L,11L,12L,13L,14L,15L,16L,10L,18L,19L,20L,21L,22L,23L,24L,25L,17L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,26L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,37L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,50L,66L,67L,68L,69L,70L,71L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143052Inst : IEnumerable<long>
{
public static readonly long[] Value=A143052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143052.Bytes);
public long this[int i]=>Value[i];

public static A143052Inst Instance=new A143052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143053
{
public static readonly long[] Value={ 0L,1L,3L,4L,2L,8L,9L,5L,6L,7L,15L,16L,10L,11L,12L,13L,14L,24L,25L,17L,18L,19L,20L,21L,22L,23L,35L,36L,26L,27L,28L,29L,30L,31L,32L,33L,34L,48L,49L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,63L,64L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,80L,81L,65L,66L,67L,68L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143053Inst : IEnumerable<long>
{
public static readonly long[] Value=A143053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143053.Bytes);
public long this[int i]=>Value[i];

public static A143053Inst Instance=new A143053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143054
{
public static readonly long[] Value={ 0L,1L,4L,2L,3L,7L,8L,9L,5L,6L,12L,13L,14L,15L,16L,10L,11L,19L,20L,21L,22L,23L,24L,25L,17L,18L,28L,29L,30L,31L,32L,33L,34L,35L,36L,26L,27L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,37L,38L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,50L,51L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143054Inst : IEnumerable<long>
{
public static readonly long[] Value=A143054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143054.Bytes);
public long this[int i]=>Value[i];

public static A143054Inst Instance=new A143054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143055
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,5L,4L,-1L,-16L,-51L,-124L,-265L,-520L,-955L,-1652L,-2689L,-4080L,-5635L,-6668L,-5433L,1896L,22965L,72028L,174095L,370496L,725101L,1328452L,2292823L,3722904L,5631525L,7743404L,9086879L,7208304L,-3246371L,-32945004L,-101726745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143055Inst : IEnumerable<long>
{
public static readonly long[] Value=A143055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143055.Bytes);
public long this[int i]=>Value[i];

public static A143055Inst Instance=new A143055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143056
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,-3L,-9L,-19L,-32L,-43L,-39L,5L,128L,377L,783L,1305L,1728L,1513L,-367L,-5495L,-15744L,-32267L,-53177L,-69371L,-58464L,21693L,235305L,656909L,1328896L,2165489L,2781855L,2249009L,-1161856L,-10052911L,-27385695L,-54696687L,-88125696L,-111427091L,-86075113L,58797853L,428575584L,1140728485L,2249936377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143056Inst : IEnumerable<long>
{
public static readonly long[] Value=A143056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143056.Bytes);
public long this[int i]=>Value[i];

public static A143056Inst Instance=new A143056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143057
{
public static readonly long[] Value={ 5L,14L,24L,27L,44L,55L,65L,90L,98L,119L,120L,152L,153L,189L,209L,220L,230L,275L,299L,322L,324L,360L,377L,390L,434L,459L,493L,495L,551L,560L,608L,620L,629L,702L,735L,779L,782L,805L,840L,860L,874L,945L,1014L,1025L,1034L,1053L,1127L,1188L,1189L,1224L,1247L,1325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143057Inst : IEnumerable<long>
{
public static readonly long[] Value=A143057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143057.Bytes);
public long this[int i]=>Value[i];

public static A143057Inst Instance=new A143057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143058
{
public static readonly long[] Value={ 1L,7L,20L,41L,71L,111L,162L,225L,301L,391L,496L,617L,755L,911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143058Inst : IEnumerable<long>
{
public static readonly long[] Value=A143058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143058.Bytes);
public long this[int i]=>Value[i];

public static A143058Inst Instance=new A143058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143059
{
public static readonly long[] Value={ 1L,11L,46L,121L,252L,456L,751L,1156L,1691L,2377L,3236L,4291L,5566L,7086L,8877L,10966L,13381L,16151L,19306L,22877L,26896L,31396L,36411L,41976L,48127L,54901L,62336L,70471L,79346L,89002L,99481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143059Inst : IEnumerable<long>
{
public static readonly long[] Value=A143059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143059.Bytes);
public long this[int i]=>Value[i];

public static A143059Inst Instance=new A143059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143060
{
public static readonly long[] Value={ 1L,16L,96L,331L,842L,1782L,3337L,5727L,9207L,14068L,20638L,29283L,40408L,54458L,71919L,93319L,119229L,150264L,187084L,230395L,280950L,339550L,407045L,484335L,572371L,672156L,784746L,911251L,1052836L,1210722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143060Inst : IEnumerable<long>
{
public static readonly long[] Value=A143060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143060.Bytes);
public long this[int i]=>Value[i];

public static A143060Inst Instance=new A143060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143061
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,3L,5L,6L,7L,5L,8L,10L,11L,12L,8L,13L,16L,18L,19L,20L,13L,21L,26L,29L,31L,32L,33L,21L,34L,42L,47L,50L,52L,53L,54L,34L,55L,68L,76L,81L,84L,86L,87L,88L,55L,89L,110L,123L,131L,136L,139L,141L,142L,143L,89L,144L,178L,199L,212L,220L,225L,228L,230L,231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143061Inst : IEnumerable<long>
{
public static readonly long[] Value=A143061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143061.Bytes);
public long this[int i]=>Value[i];

public static A143061Inst Instance=new A143061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143062
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,-1L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143062Inst : IEnumerable<long>
{
public static readonly long[] Value=A143062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143062.Bytes);
public long this[int i]=>Value[i];

public static A143062Inst Instance=new A143062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143063
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,0L,2L,2L,0L,2L,2L,2L,0L,2L,4L,4L,2L,4L,6L,4L,4L,4L,8L,8L,6L,8L,12L,10L,10L,12L,16L,16L,14L,18L,22L,22L,20L,24L,30L,32L,30L,36L,42L,42L,42L,48L,56L,60L,58L,66L,76L,78L,80L,88L,102L,106L,108L,120L,134L,140L,144L,158L,178L,186L,192L,210L,232L,242L,252L,272L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143063Inst : IEnumerable<long>
{
public static readonly long[] Value=A143063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143063.Bytes);
public long this[int i]=>Value[i];

public static A143063Inst Instance=new A143063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143096
{
public static readonly long[] Value={ 1L,4L,5L,9L,17L,33L,65L,129L,257L,513L,1025L,2049L,4097L,8193L,16385L,32769L,65537L,131073L,262145L,524289L,1048577L,2097153L,4194305L,8388609L,16777217L,33554433L,67108865L,134217729L,268435457L,536870913L,1073741825L,2147483649L,4294967297L,8589934593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143096Inst : IEnumerable<long>
{
public static readonly long[] Value=A143096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143096.Bytes);
public long this[int i]=>Value[i];

public static A143096Inst Instance=new A143096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143097
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,6L,8L,10L,9L,11L,13L,12L,14L,16L,15L,17L,19L,18L,20L,22L,21L,23L,25L,24L,26L,28L,27L,29L,31L,30L,32L,34L,33L,35L,37L,36L,38L,40L,39L,41L,43L,42L,44L,46L,45L,47L,49L,48L,50L,52L,51L,53L,55L,54L,56L,58L,57L,59L,61L,60L,62L,64L,63L,65L,67L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143097Inst : IEnumerable<long>
{
public static readonly long[] Value=A143097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143097.Bytes);
public long this[int i]=>Value[i];

public static A143097Inst Instance=new A143097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143098
{
public static readonly long[] Value={ 1L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L,2L,2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143098Inst : IEnumerable<long>
{
public static readonly long[] Value=A143098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143098.Bytes);
public long this[int i]=>Value[i];

public static A143098Inst Instance=new A143098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143099
{
public static readonly long[] Value={ 1L,3L,9L,22L,50L,113L,256L,576L,1281L,2818L,6146L,13313L,28672L,61440L,131073L,278530L,589826L,1245185L,2621440L,5505024L,11534337L,24117250L,50331650L,104857601L,218103808L,452984832L,939524097L,1946157058L,4026531842L,8321499137L,17179869184L,35433480192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143099Inst : IEnumerable<long>
{
public static readonly long[] Value=A143099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143099.Bytes);
public long this[int i]=>Value[i];

public static A143099Inst Instance=new A143099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143100
{
public static readonly long[] Value={ 1L,3L,4L,6L,13L,30L,64L,129L,256L,510L,1021L,2046L,4096L,8193L,16384L,32766L,65533L,131070L,262144L,524289L,1048576L,2097150L,4194301L,8388606L,16777216L,33554433L,67108864L,134217726L,268435453L,536870910L,1073741824L,2147483649L,4294967296L,8589934590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143100Inst : IEnumerable<long>
{
public static readonly long[] Value=A143100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143100.Bytes);
public long this[int i]=>Value[i];

public static A143100Inst Instance=new A143100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143101
{
public static readonly long[] Value={ 1L,3L,7L,10L,15L,22L,28L,36L,46L,55L,66L,79L,91L,105L,121L,136L,153L,172L,190L,210L,232L,253L,276L,301L,325L,351L,379L,406L,435L,466L,496L,528L,562L,595L,630L,667L,703L,741L,781L,820L,861L,904L,946L,990L,1036L,1081L,1128L,1177L,1225L,1275L,1327L,1378L,1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143101Inst : IEnumerable<long>
{
public static readonly long[] Value=A143101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143101.Bytes);
public long this[int i]=>Value[i];

public static A143101Inst Instance=new A143101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143102
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,3L,7L,9L,10L,5L,8L,12L,14L,15L,7L,12L,15L,29L,21L,22L,6L,18L,18L,21L,25L,27L,28L,8L,14L,21L,26L,29L,33L,35L,36L,10L,18L,24L,31L,36L,39L,43L,45L,46L,9L,19L,27L,33L,40L,45L,48L,52L,54L,55L,11L,20L,30L,38L,44L,51L,56L,59L,63L,65L,66L,13L,24L,33L,43L,51L,57L,64L,69L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143102Inst : IEnumerable<long>
{
public static readonly long[] Value=A143102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143102.Bytes);
public long this[int i]=>Value[i];

public static A143102Inst Instance=new A143102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143103
{
public static readonly long[] Value={ 1L,5L,17L,29L,54L,96L,138L,202L,292L,382L,503L,659L,815L,1011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143103Inst : IEnumerable<long>
{
public static readonly long[] Value=A143103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143103.Bytes);
public long this[int i]=>Value[i];

public static A143103Inst Instance=new A143103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143104
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143104Inst : IEnumerable<long>
{
public static readonly long[] Value=A143104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143104.Bytes);
public long this[int i]=>Value[i];

public static A143104Inst Instance=new A143104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143105
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,21L,33L,41L,45L,53L,69L,77L,81L,93L,105L,113L,117L,125L,129L,141L,149L,153L,161L,165L,177L,185L,201L,213L,221L,225L,249L,261L,269L,273L,285L,297L,305L,309L,333L,341L,345L,357L,365L,369L,381L,405L,413L,417L,429L,437L,441L,453L,465L,473L,489L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143105Inst : IEnumerable<long>
{
public static readonly long[] Value=A143105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143105.Bytes);
public long this[int i]=>Value[i];

public static A143105Inst Instance=new A143105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143106
{
public static readonly long[] Value={ 1L,3L,5L,9L,17L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143106Inst : IEnumerable<long>
{
public static readonly long[] Value=A143106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143106.Bytes);
public long this[int i]=>Value[i];

public static A143106Inst Instance=new A143106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143107
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,2L,4L,8L,4L,2L,24L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143107Inst : IEnumerable<long>
{
public static readonly long[] Value=A143107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143107.Bytes);
public long this[int i]=>Value[i];

public static A143107Inst Instance=new A143107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143108
{
public static readonly long[] Value={ 0L,0L,3L,4L,10L,24L,32L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143108Inst : IEnumerable<long>
{
public static readonly long[] Value=A143108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143108.Bytes);
public long this[int i]=>Value[i];

public static A143108Inst Instance=new A143108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143109
{
public static readonly long[] Value={ 0L,0L,0L,11L,38L,88L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143109Inst : IEnumerable<long>
{
public static readonly long[] Value=A143109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143109.Bytes);
public long this[int i]=>Value[i];

public static A143109Inst Instance=new A143109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143110
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,1L,1L,2L,0L,2L,1L,0L,0L,0L,1L,1L,2L,1L,0L,0L,2L,1L,0L,0L,0L,0L,0L,1L,1L,2L,0L,2L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,2L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,2L,0L,2L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143110Inst : IEnumerable<long>
{
public static readonly long[] Value=A143110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143110.Bytes);
public long this[int i]=>Value[i];

public static A143110Inst Instance=new A143110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143111
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,1L,0L,2L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,3L,1L,0L,0L,0L,0L,0L,1L,1L,1L,0L,2L,0L,0L,0L,4L,1L,0L,1L,0L,0L,0L,0L,0L,3L,1L,1L,0L,0L,10L,0L,0L,0L,5L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,2L,0L,3L,0L,0L,0L,0L,0L,6L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143111Inst : IEnumerable<long>
{
public static readonly long[] Value=A143111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143111.Bytes);
public long this[int i]=>Value[i];

public static A143111Inst Instance=new A143111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143144
{
public static readonly long[] Value={ 3L,8L,10L,18L,21L,24L,28L,40L,45L,48L,50L,54L,55L,60L,66L,84L,91L,96L,104L,108L,117L,120L,130L,154L,165L,168L,176L,180L,187L,192L,204L,234L,247L,252L,266L,270L,285L,288L,304L,340L,357L,360L,374L,378L,391L,396L,414L,456L,475L,480L,494L,500L,504L,513L,520L,525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143144Inst : IEnumerable<long>
{
public static readonly long[] Value=A143144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143144.Bytes);
public long this[int i]=>Value[i];

public static A143144Inst Instance=new A143144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143145
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,15L,16L,20L,25L,30L,35L,36L,42L,49L,56L,63L,64L,70L,72L,77L,80L,81L,88L,90L,99L,100L,110L,121L,132L,143L,144L,156L,169L,182L,195L,196L,208L,210L,221L,224L,225L,238L,240L,255L,256L,272L,289L,306L,323L,324L,342L,361L,380L,399L,400L,418L,420L,437L,440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143145Inst : IEnumerable<long>
{
public static readonly long[] Value=A143145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143145.Bytes);
public long this[int i]=>Value[i];

public static A143145Inst Instance=new A143145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143146
{
public static readonly long[] Value={ 2L,2L,9L,12L,10L,12L,35L,56L,9L,10L,44L,12L,52L,42L,135L,240L,153L,180L,38L,180L,42L,44L,184L,216L,50L,52L,135L,56L,232L,150L,527L,992L,165L,170L,35L,180L,37L,38L,156L,240L,41L,42L,172L,44L,135L,184L,141L,240L,49L,50L,153L,52L,212L,216L,165L,56L,228L,232L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143146Inst : IEnumerable<long>
{
public static readonly long[] Value=A143146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143146.Bytes);
public long this[int i]=>Value[i];

public static A143146Inst Instance=new A143146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143147
{
public static readonly long[] Value={ 2L,10L,50L,150L,3150L,9450L,141750L,850500L,11056500L,154791000L,773955000L,41019615000L,1066509990000L,3199529970000L,15997649850000L,239964747750000L,2399647477500000L,43193654595000000L,2893974857865000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143147Inst : IEnumerable<long>
{
public static readonly long[] Value=A143147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143147.Bytes);
public long this[int i]=>Value[i];

public static A143147Inst Instance=new A143147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143148
{
public static readonly long[] Value={ 5L,1L,0L,6L,4L,6L,1L,1L,8L,9L,1L,3L,8L,3L,3L,8L,2L,7L,7L,6L,3L,1L,3L,0L,9L,5L,6L,7L,1L,6L,0L,0L,8L,7L,9L,1L,6L,4L,9L,0L,9L,9L,0L,4L,7L,8L,9L,1L,1L,1L,6L,3L,6L,1L,8L,1L,2L,3L,8L,5L,0L,6L,1L,9L,7L,8L,4L,4L,2L,1L,4L,5L,1L,5L,1L,1L,0L,6L,3L,5L,3L,2L,8L,1L,6L,0L,2L,9L,8L,7L,4L,0L,1L,3L,5L,2L,8L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143148Inst : IEnumerable<long>
{
public static readonly long[] Value=A143148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143148.Bytes);
public long this[int i]=>Value[i];

public static A143148Inst Instance=new A143148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143149
{
public static readonly long[] Value={ 3L,1L,3L,3L,2L,8L,5L,3L,4L,3L,2L,8L,8L,7L,5L,0L,6L,2L,8L,0L,1L,9L,7L,0L,6L,6L,0L,6L,0L,1L,3L,8L,0L,6L,5L,6L,6L,2L,5L,8L,7L,3L,3L,4L,2L,5L,7L,6L,2L,4L,2L,2L,8L,9L,5L,7L,8L,7L,4L,0L,4L,4L,7L,0L,4L,2L,7L,8L,6L,7L,0L,6L,8L,2L,5L,9L,8L,0L,2L,4L,6L,8L,6L,8L,3L,2L,4L,4L,7L,9L,7L,9L,7L,2L,5L,7L,1L,5L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143149Inst : IEnumerable<long>
{
public static readonly long[] Value=A143149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143149.Bytes);
public long this[int i]=>Value[i];

public static A143149Inst Instance=new A143149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143150
{
public static readonly long[] Value={ -1L,3L,4L,19L,17L,27L,53L,48L,55L,80L,111L,103L,107L,129L,175L,199L,188L,189L,208L,251L,324L,323L,309L,307L,323L,363L,433L,539L,489L,472L,467L,480L,517L,584L,687L,832L,703L,683L,675L,685L,719L,783L,883L,1025L,1215L,971L,948L,937L,944L,975L,1036L,1133L,1272L,1459L,1700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143150Inst : IEnumerable<long>
{
public static readonly long[] Value=A143150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143150.Bytes);
public long this[int i]=>Value[i];

public static A143150Inst Instance=new A143150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143151
{
public static readonly long[] Value={ 1L,1L,2L,1L,0L,3L,1L,2L,0L,2L,1L,0L,0L,0L,5L,1L,2L,3L,0L,0L,2L,1L,0L,0L,0L,0L,0L,7L,1L,2L,0L,2L,0L,0L,0L,2L,1L,0L,3L,0L,0L,0L,0L,0L,3L,1L,2L,0L,0L,5L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,1L,2L,3L,2L,0L,2L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L,1L,2L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143151Inst : IEnumerable<long>
{
public static readonly long[] Value=A143151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143151.Bytes);
public long this[int i]=>Value[i];

public static A143151Inst Instance=new A143151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143152
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,8L,7L,7L,10L,12L,12L,14L,12L,12L,9L,18L,13L,20L,14L,14L,16L,24L,16L,11L,18L,10L,16L,30L,20L,32L,11L,18L,22L,18L,19L,38L,24L,20L,18L,42L,22L,44L,20L,18L,28L,48L,20L,15L,17L,24L,22L,54L,18L,22L,20L,26L,34L,60L,28L,62L,36L,20L,13L,24L,26L,68L,26L,30L,26L,72L,25L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143152Inst : IEnumerable<long>
{
public static readonly long[] Value=A143152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143152.Bytes);
public long this[int i]=>Value[i];

public static A143152Inst Instance=new A143152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143153
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,0L,3L,0L,-2L,0L,2L,-1L,0L,0L,0L,5L,1L,-2L,-3L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,7L,0L,0L,0L,-2L,0L,0L,0L,2L,0L,0L,-3L,0L,0L,0L,0L,0L,3L,1L,-2L,0L,0L,-5L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,0L,2L,0L,-2L,0L,-2L,0L,0L,0L,0L,0L,2L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L,1L,-2L,0L,0L,0L,0L,-7L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143153Inst : IEnumerable<long>
{
public static readonly long[] Value=A143153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143153.Bytes);
public long this[int i]=>Value[i];

public static A143153Inst Instance=new A143153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143154
{
public static readonly BigInteger[] Value={ 1L,2L,18L,262L,5320L,138728L,4419156L,166319424L,7221397848L,355312006392L,19537581248592L,1187337791554176L,79025863405440432L,5716937001401316000L,BigInteger.Parse("446654003380859659488"),BigInteger.Parse("37480492611898380241248") };
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
public class A143154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143154Inst Instance=new A143154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143155
{
public static readonly BigInteger[] Value={ 1L,3L,26L,376L,7614L,198248L,6309092L,237291388L,10297903920L,506495785632L,27842563031304L,1691646018671376L,112569103111005072L,8142200129607522288L,BigInteger.Parse("636046143210331062048"),BigInteger.Parse("53366672768969064921024") };
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
public class A143155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143155Inst Instance=new A143155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143156
{
public static readonly long[] Value={ 1L,3L,2L,4L,3L,1L,7L,6L,4L,3L,8L,7L,5L,4L,1L,10L,9L,7L,6L,3L,2L,11L,10L,8L,7L,4L,3L,1L,15L,14L,12L,11L,8L,7L,5L,4L,16L,15L,13L,12L,9L,8L,6L,5L,1L,18L,17L,15L,14L,11L,10L,8L,7L,3L,2L,19L,18L,16L,15L,12L,11L,9L,8L,4L,3L,1L,22L,21L,19L,18L,15L,14L,12L,11L,7L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143156Inst : IEnumerable<long>
{
public static readonly long[] Value=A143156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143156.Bytes);
public long this[int i]=>Value[i];

public static A143156Inst Instance=new A143156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143157
{
public static readonly long[] Value={ 0L,1L,5L,8L,20L,25L,37L,44L,76L,85L,105L,116L,152L,165L,193L,208L,288L,305L,341L,360L,420L,441L,485L,508L,604L,629L,681L,708L,792L,821L,881L,912L,1104L,1137L,1205L,1240L,1348L,1385L,1461L,1500L,1660L,1701L,1785L,1828L,1960L,2005L,2097L,2144L,2384L,2433L,2533L,2584L,2740L,2793L,2901L,2956L,3180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143157Inst : IEnumerable<long>
{
public static readonly long[] Value=A143157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143157.Bytes);
public long this[int i]=>Value[i];

public static A143157Inst Instance=new A143157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143158
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-2L,-1L,-1L,-2L,-1L,0L,-2L,-3L,-2L,-1L,-1L,-1L,-2L,-1L,0L,0L,1L,-2L,-3L,-2L,-1L,-1L,0L,-1L,-2L,-3L,-2L,-1L,-1L,0L,-1L,0L,-2L,-3L,-2L,-1L,-1L,0L,-1L,0L,0L,-1L,-2L,-1L,0L,0L,1L,0L,1L,1L,1L,-2L,-3L,-2L,-1L,-1L,0L,-1L,0L,0L,0L,-1L,-2L,-3L,-2L,-1L,-1L,0L,-1L,0L,0L,0L,-1L,0L,-3L,-4L,-3L,-2L,-2L,-1L,-2L,-1L,-1L,-1L,-2L,-1L,-1L,-2L,-3L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143158Inst : IEnumerable<long>
{
public static readonly long[] Value=A143158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143158.Bytes);
public long this[int i]=>Value[i];

public static A143158Inst Instance=new A143158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143159
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,-3L,1L,1L,3L,2L,-2L,5L,-1L,1L,-2L,-4L,-2L,-3L,2L,-7L,-2L,4L,7L,0L,-1L,-1L,0L,4L,10L,5L,-7L,7L,-3L,-6L,-3L,0L,-1L,-5L,-6L,3L,-7L,1L,5L,-5L,1L,-4L,1L,-9L,7L,2L,16L,2L,-2L,8L,2L,5L,2L,5L,-11L,-4L,-1L,1L,1L,-2L,2L,6L,-12L,7L,-9L,-9L,1L,-15L,-2L,1L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143159Inst : IEnumerable<long>
{
public static readonly long[] Value=A143159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143159.Bytes);
public long this[int i]=>Value[i];

public static A143159Inst Instance=new A143159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143208
{
public static readonly long[] Value={ 2L,-1L,2L,8L,17L,29L,44L,62L,83L,107L,134L,164L,197L,233L,272L,314L,359L,407L,458L,512L,569L,629L,692L,758L,827L,899L,974L,1052L,1133L,1217L,1304L,1394L,1487L,1583L,1682L,1784L,1889L,1997L,2108L,2222L,2339L,2459L,2582L,2708L,2837L,2969L,3104L,3242L,3383L,3527L,3674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143208Inst : IEnumerable<long>
{
public static readonly long[] Value=A143208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143208.Bytes);
public long this[int i]=>Value[i];

public static A143208Inst Instance=new A143208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143209
{
public static readonly long[] Value={ 1L,-1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,1L,1L,3L,3L,2L,3L,3L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,4L,6L,4L,2L,4L,6L,4L,1L,1L,3L,3L,2L,3L,3L,2L,3L,3L,1L,1L,5L,10L,10L,5L,2L,5L,10L,10L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143209Inst : IEnumerable<long>
{
public static readonly long[] Value=A143209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143209.Bytes);
public long this[int i]=>Value[i];

public static A143209Inst Instance=new A143209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143210
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,14L,14L,1L,1L,23L,99L,23L,1L,1L,37L,441L,441L,37L,1L,1L,68L,244L,456L,244L,68L,1L,1L,140L,167L,386L,386L,167L,140L,1L,1L,269L,408L,255L,785L,255L,408L,269L,1L,1L,527L,912L,788L,987L,987L,788L,912L,527L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143210Inst : IEnumerable<long>
{
public static readonly long[] Value=A143210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143210.Bytes);
public long this[int i]=>Value[i];

public static A143210Inst Instance=new A143210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143211
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,3L,3L,6L,9L,5L,5L,10L,15L,25L,8L,8L,16L,24L,40L,64L,13L,13L,26L,39L,65L,104L,169L,21L,21L,42L,63L,105L,168L,273L,441L,34L,34L,68L,102L,170L,272L,442L,714L,1156L,55L,55L,110L,165L,275L,440L,715L,1155L,1870L,3025L,89L,89L,178L,267L,445L,712L,1157L,1869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143211Inst : IEnumerable<long>
{
public static readonly long[] Value=A143211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143211.Bytes);
public long this[int i]=>Value[i];

public static A143211Inst Instance=new A143211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143212
{
public static readonly long[] Value={ 1L,2L,8L,21L,60L,160L,429L,1134L,2992L,7865L,20648L,54144L,141897L,371722L,973560L,2549421L,6675460L,17478176L,45761045L,119808150L,313668576L,821205937L,2149962768L,5628704256L,14736185425L,38579909330L,101003635304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143212Inst : IEnumerable<long>
{
public static readonly long[] Value=A143212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143212.Bytes);
public long this[int i]=>Value[i];

public static A143212Inst Instance=new A143212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143213
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,28L,28L,1L,1L,106L,149L,106L,1L,1L,155L,987L,987L,155L,1L,1L,955L,440L,514L,440L,955L,1L,1L,194L,137L,974L,974L,137L,194L,1L,1L,340L,754L,60L,293L,60L,754L,340L,1L,1L,181L,238L,166L,377L,377L,166L,238L,181L,1L,1L,977L,283L,540L,411L,142L,411L,540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143213Inst : IEnumerable<long>
{
public static readonly long[] Value=A143213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143213.Bytes);
public long this[int i]=>Value[i];

public static A143213Inst Instance=new A143213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143214
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,2L,2L,1L,1L,6L,5L,6L,1L,1L,7L,15L,15L,7L,1L,1L,5L,8L,30L,8L,5L,1L,1L,4L,31L,50L,50L,31L,4L,1L,1L,12L,18L,36L,101L,36L,18L,12L,1L,1L,13L,54L,126L,65L,65L,126L,54L,13L,1L,1L,15L,59L,68L,187L,130L,187L,68L,59L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143214Inst : IEnumerable<long>
{
public static readonly long[] Value=A143214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143214.Bytes);
public long this[int i]=>Value[i];

public static A143214Inst Instance=new A143214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143215
{
public static readonly long[] Value={ 4L,15L,50L,119L,308L,533L,986L,1463L,2300L,3741L,4960L,7289L,9758L,12083L,15416L,20193L,25960L,30561L,38056L,45369L,51976L,62489L,72542L,85707L,102820L,117261L,130192L,146697L,161320L,180009L,218440L,242481L,272356L,295653L,339124L,366477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143215Inst : IEnumerable<long>
{
public static readonly long[] Value=A143215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143215.Bytes);
public long this[int i]=>Value[i];

public static A143215Inst Instance=new A143215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143216
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,6L,6L,12L,36L,24L,24L,48L,144L,576L,120L,120L,240L,720L,2880L,14400L,720L,720L,1440L,4320L,17280L,86400L,518400L,5040L,5040L,10080L,30240L,120960L,604800L,3628800L,25401600L,40320L,40320L,80640L,241920L,967680L,4838400L,29030400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143216Inst : IEnumerable<long>
{
public static readonly long[] Value=A143216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143216.Bytes);
public long this[int i]=>Value[i];

public static A143216Inst Instance=new A143216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143217
{
public static readonly BigInteger[] Value={ 1L,2L,8L,60L,816L,18480L,629280L,29806560L,1864154880L,148459288320L,14652782323200L,1754531527795200L,250496911136102400L,BigInteger.Parse("42032247888401971200"),BigInteger.Parse("8188505926989625036800"),BigInteger.Parse("1832839841629043799552000"),BigInteger.Parse("467088574163459753336832000"),BigInteger.Parse("134454052266325985991942144000") };
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
public class A143217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A143217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A143217Inst Instance=new A143217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143218
{
public static readonly long[] Value={ 1L,3L,9L,5L,15L,25L,7L,21L,35L,49L,9L,27L,45L,63L,81L,11L,33L,55L,77L,99L,121L,13L,39L,65L,91L,117L,143L,169L,15L,45L,75L,105L,135L,165L,195L,225L,17L,51L,85L,119L,153L,187L,221L,255L,289L,19L,57L,95L,133L,171L,209L,247L,285L,323L,361L,21L,63L,105L,147L,189L,231L,273L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143218Inst : IEnumerable<long>
{
public static readonly long[] Value=A143218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143218.Bytes);
public long this[int i]=>Value[i];

public static A143218Inst Instance=new A143218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143219
{
public static readonly long[] Value={ 1L,2L,6L,3L,9L,18L,4L,12L,24L,40L,5L,15L,30L,50L,75L,6L,18L,36L,60L,90L,126L,7L,21L,42L,70L,105L,147L,196L,8L,24L,48L,80L,120L,168L,224L,288L,9L,27L,54L,90L,135L,189L,252L,324L,405L,10L,30L,60L,100L,150L,210L,280L,360L,450L,550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143219Inst : IEnumerable<long>
{
public static readonly long[] Value=A143219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143219.Bytes);
public long this[int i]=>Value[i];

public static A143219Inst Instance=new A143219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143220
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143220Inst : IEnumerable<long>
{
public static readonly long[] Value=A143220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143220.Bytes);
public long this[int i]=>Value[i];

public static A143220Inst Instance=new A143220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143221
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143221Inst : IEnumerable<long>
{
public static readonly long[] Value=A143221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143221.Bytes);
public long this[int i]=>Value[i];

public static A143221Inst Instance=new A143221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143222
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143222Inst : IEnumerable<long>
{
public static readonly long[] Value=A143222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143222.Bytes);
public long this[int i]=>Value[i];

public static A143222Inst Instance=new A143222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143223
{
public static readonly long[] Value={ 0L,2L,1L,1L,1L,1L,2L,1L,2L,0L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,3L,2L,1L,1L,3L,2L,1L,1L,2L,2L,1L,3L,2L,3L,1L,2L,0L,0L,3L,2L,2L,2L,-1L,3L,2L,3L,0L,4L,6L,0L,1L,4L,4L,1L,1L,-2L,-1L,3L,-1L,3L,3L,1L,5L,3L,1L,3L,1L,2L,4L,-1L,6L,1L,1L,4L,4L,4L,7L,-1L,3L,8L,-2L,5L,3L,5L,1L,0L,5L,5L,1L,2L,3L,2L,1L,5L,3L,3L,2L,3L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143223Inst : IEnumerable<long>
{
public static readonly long[] Value=A143223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143223.Bytes);
public long this[int i]=>Value[i];

public static A143223Inst Instance=new A143223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143304
{
public static readonly long[] Value={ 0L,6L,5L,3L,5L,1L,4L,2L,5L,9L,2L,3L,0L,3L,7L,3L,2L,1L,3L,7L,8L,7L,8L,2L,6L,2L,6L,7L,6L,3L,1L,0L,7L,9L,3L,0L,8L,1L,3L,0L,2L,4L,5L,3L,6L,8L,4L,9L,4L,2L,3L,7L,9L,7L,6L,5L,9L,0L,7L,1L,4L,4L,9L,6L,8L,1L,5L,7L,7L,0L,7L,5L,8L,0L,5L,4L,3L,1L,9L,9L,4L,9L,4L,6L,9L,4L,2L,0L,6L,8L,7L,1L,6L,3L,6L,4L,5L,5L,8L,9L,9L,7L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143304Inst : IEnumerable<long>
{
public static readonly long[] Value=A143304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143304.Bytes);
public long this[int i]=>Value[i];

public static A143304Inst Instance=new A143304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143305
{
public static readonly long[] Value={ 3L,3L,6L,4L,3L,1L,7L,5L,7L,8L,1L,5L,5L,8L,9L,9L,1L,0L,6L,0L,6L,7L,7L,1L,3L,3L,8L,6L,5L,0L,3L,4L,4L,1L,2L,6L,9L,4L,5L,6L,7L,1L,1L,6L,5L,2L,1L,6L,1L,2L,3L,5L,4L,2L,0L,9L,5L,5L,5L,7L,7L,7L,8L,0L,8L,1L,3L,6L,2L,7L,8L,2L,1L,1L,6L,8L,5L,6L,2L,3L,2L,3L,7L,7L,4L,5L,7L,6L,3L,4L,7L,7L,3L,7L,3L,9L,0L,9L,3L,4L,1L,0L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143305Inst : IEnumerable<long>
{
public static readonly long[] Value=A143305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143305.Bytes);
public long this[int i]=>Value[i];

public static A143305Inst Instance=new A143305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143306
{
public static readonly long[] Value={ 7L,2L,6L,6L,4L,3L,2L,4L,6L,8L,1L,3L,2L,4L,2L,5L,0L,9L,5L,9L,0L,2L,1L,9L,5L,5L,5L,9L,4L,1L,9L,8L,5L,5L,6L,3L,2L,5L,7L,2L,7L,8L,9L,3L,3L,4L,6L,9L,9L,9L,4L,0L,0L,8L,6L,8L,7L,9L,7L,5L,9L,0L,8L,3L,5L,7L,0L,9L,0L,2L,6L,6L,9L,3L,7L,0L,9L,4L,5L,6L,3L,3L,7L,3L,1L,3L,2L,1L,9L,9L,5L,4L,5L,0L,3L,0L,7L,6L,9L,5L,1L,2L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143306Inst : IEnumerable<long>
{
public static readonly long[] Value=A143306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143306.Bytes);
public long this[int i]=>Value[i];

public static A143306Inst Instance=new A143306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143307
{
public static readonly long[] Value={ 2L,2L,3L,9L,4L,3L,3L,1L,0L,4L,0L,0L,5L,2L,6L,0L,7L,3L,1L,7L,5L,4L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143307Inst : IEnumerable<long>
{
public static readonly long[] Value=A143307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143307.Bytes);
public long this[int i]=>Value[i];

public static A143307Inst Instance=new A143307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143308
{
public static readonly long[] Value={ 1L,4L,2L,6L,3L,3L,12L,8L,4L,4L,10L,5L,5L,5L,5L,24L,18L,12L,6L,6L,6L,14L,7L,7L,7L,7L,7L,7L,32L,24L,16L,16L,8L,8L,8L,8L,27L,18L,18L,9L,9L,9L,9L,9L,9L,40L,30L,20L,20L,20L,10L,10L,10L,10L,10L,12L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,72L,60L,48L,36L,24L,24L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143308Inst : IEnumerable<long>
{
public static readonly long[] Value=A143308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143308.Bytes);
public long this[int i]=>Value[i];

public static A143308Inst Instance=new A143308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143309
{
public static readonly long[] Value={ 1L,3L,2L,5L,3L,3L,8L,6L,4L,4L,9L,5L,5L,5L,5L,15L,13L,9L,6L,6L,6L,13L,7L,7L,7L,7L,7L,7L,20L,16L,12L,12L,8L,8L,8L,8L,21L,15L,15L,9L,9L,9L,9L,9L,9L,27L,23L,15L,15L,15L,10L,10L,10L,10L,10L,10L,21L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,40L,36L,32L,26L,18L,18L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143309Inst : IEnumerable<long>
{
public static readonly long[] Value=A143309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143309.Bytes);
public long this[int i]=>Value[i];

public static A143309Inst Instance=new A143309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143310
{
public static readonly long[] Value={ 1L,3L,2L,6L,2L,3L,10L,6L,3L,4L,15L,6L,3L,4L,5L,15L,6L,3L,4L,5L,21L,12L,9L,4L,5L,6L,28L,12L,9L,4L,5L,6L,7L,36L,20L,9L,12L,5L,6L,7L,8L,45L,20L,18L,12L,5L,6L,7L,8L,9L,55L,30L,18L,12L,15L,6L,7L,8L,9L,10L,66L,30L,18L,12L,15L,6L,7L,8L,9L,10L,11L,78L,42L,30L,24L,15L,18L,7L,8L,9L,10L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143310Inst : IEnumerable<long>
{
public static readonly long[] Value=A143310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143310.Bytes);
public long this[int i]=>Value[i];

public static A143310Inst Instance=new A143310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143311
{
public static readonly long[] Value={ 1L,4L,2L,9L,0L,3L,16L,8L,0L,4L,25L,0L,0L,0L,5L,36L,18L,12L,0L,0L,6L,49L,0L,0L,0L,0L,0L,7L,64L,32L,0L,16L,0L,0L,0L,8L,81L,0L,27L,0L,0L,0L,0L,0L,9L,100L,50L,0L,0L,20L,0L,0L,0L,0L,10L,121L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,144L,72L,48L,36L,0L,24L,0L,0L,0L,0L,0L,12L,169L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143311Inst : IEnumerable<long>
{
public static readonly long[] Value=A143311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143311.Bytes);
public long this[int i]=>Value[i];

public static A143311Inst Instance=new A143311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143312
{
public static readonly long[] Value={ 1L,3L,2L,8L,0L,3L,12L,6L,0L,4L,24L,0L,0L,0L,5L,24L,16L,9L,0L,0L,6L,48L,0L,0L,0L,0L,0L,7L,48L,24L,0L,12L,0L,0L,0L,8L,72L,0L,24L,0L,0L,0L,0L,0L,9L,72L,48L,0L,0L,15L,0L,0L,0L,0L,10L,120L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,96L,48L,36L,32L,0L,18L,0L,0L,0L,0L,0L,12L,168L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143312Inst : IEnumerable<long>
{
public static readonly long[] Value=A143312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143312.Bytes);
public long this[int i]=>Value[i];

public static A143312Inst Instance=new A143312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143313
{
public static readonly long[] Value={ 1L,4L,1L,5L,1L,1L,11L,4L,1L,1L,7L,1L,1L,1L,1L,20L,8L,4L,1L,1L,19L,1L,1L,1L,1L,1L,1L,26L,11L,4L,4L,1L,1L,1L,1L,18L,5L,5L,1L,1L,1L,1L,1L,1L,28L,10L,4L,4L,4L,1L,1L,1L,1L,1L,13L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,55L,27L,15L,8L,4L,4L,1L,1L,1L,1L,1L,1L,15L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143313Inst : IEnumerable<long>
{
public static readonly long[] Value=A143313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143313.Bytes);
public long this[int i]=>Value[i];

public static A143313Inst Instance=new A143313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143314
{
public static readonly long[] Value={ 0L,0L,0L,0L,40L,1844L,41584L,611340L,6588116L,55482100L,380126920L,2177910310L,10644616240L,45049914588L,167011924492L,547315800984L,1597026077496L,4173458163098L,9813490226056L,20841357619302L,40096048882028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143314Inst : IEnumerable<long>
{
public static readonly long[] Value=A143314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143314.Bytes);
public long this[int i]=>Value[i];

public static A143314Inst Instance=new A143314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143315
{
public static readonly long[] Value={ 1L,3L,1L,5L,0L,1L,7L,3L,0L,1L,9L,0L,0L,0L,1L,11L,5L,3L,0L,0L,1L,13L,0L,0L,0L,0L,0L,1L,15L,7L,0L,3L,0L,0L,0L,1L,17L,0L,5L,0L,0L,0L,0L,0L,1L,19L,9L,0L,0L,30L,0L,0L,0L,1L,21L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,23L,11L,7L,5L,0L,3L,0L,0L,0L,0L,0L,1L,25L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143315Inst : IEnumerable<long>
{
public static readonly long[] Value=A143315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143315.Bytes);
public long this[int i]=>Value[i];

public static A143315Inst Instance=new A143315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143316
{
public static readonly long[] Value={ 1L,2L,1L,4L,0L,1L,4L,2L,0L,1L,8L,0L,0L,0L,1L,4L,4L,2L,2L,0L,0L,1L,12L,0L,0L,0L,0L,0L,1L,8L,4L,0L,2L,0L,0L,0L,1L,12L,0L,4L,0L,0L,0L,0L,0L,1L,8L,8L,0L,0L,2L,0L,0L,0L,0L,1L,20L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,8L,4L,4L,4L,0L,2L,0L,0L,0L,0L,0L,1L,24L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143316Inst : IEnumerable<long>
{
public static readonly long[] Value=A143316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143316.Bytes);
public long this[int i]=>Value[i];

public static A143316Inst Instance=new A143316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143317
{
public static readonly long[] Value={ 1L,3L,-1L,4L,0L,-1L,7L,-3L,0L,0L,6L,0L,0L,0L,-1L,12L,-4L,-3L,0L,0L,1L,8L,0L,0L,0L,0L,0L,-1L,15L,-7L,0L,0L,0L,0L,0L,0L,13L,0L,-4L,0L,0L,0L,0L,0L,0L,18L,-6L,0L,0L,-3L,0L,0L,0L,0L,1L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,28L,-1L,-7L,0L,0L,3L,0L,0L,0L,0L,0L,0L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143317Inst : IEnumerable<long>
{
public static readonly long[] Value=A143317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143317.Bytes);
public long this[int i]=>Value[i];

public static A143317Inst Instance=new A143317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143318
{
public static readonly long[] Value={ 1L,2L,-1L,3L,-1L,-1L,4L,-3L,0L,0L,5L,-1L,-1L,-1L,-1L,6L,-6L,-2L,1L,1L,1L,7L,-1L,-1L,-1L,-1L,-1L,-1L,8L,-7L,0L,0L,0L,0L,0L,0L,9L,-4L,-4L,0L,0L,0L,0L,0L,0L,10L,-8L,-2L,-2L,-2L,1L,1L,1L,1L,1L,11L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,12L,-16L,-4L,3L,3L,3L,3L,0L,0L,0L,0L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143318Inst : IEnumerable<long>
{
public static readonly long[] Value=A143318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143318.Bytes);
public long this[int i]=>Value[i];

public static A143318Inst Instance=new A143318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143319
{
public static readonly long[] Value={ 1L,3L,-1L,4L,-1L,-1L,7L,-4L,0L,0L,6L,-1L,-1L,-1L,-1L,12L,-8L,-3L,1L,1L,1L,8L,-1L,-1L,-1L,-1L,-1L,-1L,15L,-11L,0L,0L,0L,0L,0L,0L,13L,-5L,-5L,0L,0L,0L,0L,0L,0L,18L,-10L,-3L,-3L,-3L,1L,1L,1L,1L,1L,12L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,-1L,28L,-27L,-4L,4L,4L,4L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143319Inst : IEnumerable<long>
{
public static readonly long[] Value=A143319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143319.Bytes);
public long this[int i]=>Value[i];

public static A143319Inst Instance=new A143319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143416
{
public static readonly long[] Value={ 6L,21L,22L,57L,77L,161L,166L,201L,205L,221L,301L,309L,377L,437L,454L,497L,517L,597L,745L,749L,886L,901L,1057L,1357L,1457L,1461L,1469L,1517L,1577L,1841L,1961L,2021L,2041L,2077L,2182L,2317L,2361L,2537L,2701L,3046L,3097L,3397L,3437L,3497L,3737L,3841L,3901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143416Inst : IEnumerable<long>
{
public static readonly long[] Value=A143416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143416.Bytes);
public long this[int i]=>Value[i];

public static A143416Inst Instance=new A143416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143417
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,12L,24L,5L,10L,15L,16L,20L,30L,40L,48L,60L,80L,120L,240L,7L,9L,14L,18L,21L,28L,36L,42L,56L,63L,72L,84L,126L,168L,252L,504L,32L,96L,160L,480L,11L,22L,33L,44L,66L,88L,132L,264L,13L,26L,35L,39L,45L,52L,65L,70L,78L,90L,91L,104L,105L,112L,117L,130L,140L,144L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143417Inst : IEnumerable<long>
{
public static readonly long[] Value=A143417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143417.Bytes);
public long this[int i]=>Value[i];

public static A143417Inst Instance=new A143417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143418
{
public static readonly long[] Value={ 1L,3L,3L,6L,15L,6L,10L,45L,45L,10L,15L,105L,190L,105L,15L,21L,210L,595L,595L,210L,21L,28L,378L,1540L,2415L,1540L,378L,28L,36L,630L,3486L,7875L,7875L,3486L,630L,36L,45L,980L,7140L,21945L,31626L,21945L,7140L,980L,45L,55L,1485L,27060L,54285L,106491L,106491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143418Inst : IEnumerable<long>
{
public static readonly long[] Value=A143418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143418.Bytes);
public long this[int i]=>Value[i];

public static A143418Inst Instance=new A143418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143419
{
public static readonly long[] Value={ 1L,-1L,1L,0L,1L,1L,1L,2L,2L,4L,4L,7L,9L,12L,17L,23L,32L,44L,60L,83L,113L,156L,214L,294L,403L,554L,760L,1044L,1433L,1967L,2701L,3708L,5091L,6988L,9596L,13172L,18085L,24828L,34086L,46797L,64246L,88203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143419Inst : IEnumerable<long>
{
public static readonly long[] Value=A143419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143419.Bytes);
public long this[int i]=>Value[i];

public static A143419Inst Instance=new A143419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143420
{
public static readonly long[] Value={ 1L,8L,55L,370L,2520L,15272L,123151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143420Inst : IEnumerable<long>
{
public static readonly long[] Value=A143420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143420.Bytes);
public long this[int i]=>Value[i];

public static A143420Inst Instance=new A143420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143421
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,3L,1L,1L,1L,3L,3L,2L,1L,1L,2L,1L,1L,1L,1L,4L,1L,1L,1L,6L,1L,2L,1L,2L,2L,1L,4L,2L,1L,1L,1L,4L,1L,2L,1L,6L,1L,1L,1L,3L,1L,1L,1L,5L,1L,1L,3L,2L,2L,1L,1L,4L,1L,2L,1L,5L,1L,1L,4L,1L,1L,3L,1L,1L,1L,1L,7L,2L,1L,2L,1L,1L,2L,1L,10L,1L,4L,1L,1L,1L,3L,1L,1L,2L,4L,3L,1L,6L,1L,1L,1L,2L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143421Inst : IEnumerable<long>
{
public static readonly long[] Value=A143421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143421.Bytes);
public long this[int i]=>Value[i];

public static A143421Inst Instance=new A143421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A143422
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,1L,4L,5L,2L,3L,1L,7L,1L,1L,6L,5L,6L,2L,2L,1L,9L,1L,1L,2L,1L,5L,7L,1L,1L,11L,1L,8L,1L,4L,4L,2L,13L,2L,1L,2L,1L,5L,1L,4L,2L,11L,1L,8L,1L,4L,1L,1L,2L,16L,1L,1L,4L,10L,2L,2L,1L,8L,1L,6L,1L,5L,3L,1L,17L,1L,1L,5L,2L,3L,1L,2L,12L,3L,1L,6L,1L,1L,4L,1L,21L,1L,5L,9L,2L,1L,7L,1L,1L,3L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A143422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A143422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A143422Inst : IEnumerable<long>
{
public static readonly long[] Value=A143422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A143422.Bytes);
public long this[int i]=>Value[i];

public static A143422Inst Instance=new A143422Inst();

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