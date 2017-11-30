using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188098
{
public static readonly long[] Value={ 708L,143L,243L,643L,1482L,2374L,2866L,3110L,3322L,3542L,3834L,4523L,6132L,8705L,11842L,15620L,20530L,26624L,33574L,41854L,52875L,67653L,86424L,110303L,141833L,183214L,235538L,301250L,385634L,494647L,633374L,809368L,1035564L,1327770L,1702014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188098Inst : IEnumerable<long>
{
public static readonly long[] Value=A188098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188098.Bytes);
public long this[int i]=>Value[i];

public static A188098Inst Instance=new A188098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188099
{
public static readonly long[] Value={ 1417L,243L,486L,1421L,3013L,3765L,4041L,4285L,4537L,4817L,5317L,6393L,9606L,13599L,18088L,23397L,31095L,39853L,49607L,61257L,78509L,100814L,128604L,163599L,211894L,274000L,351345L,447545L,574297L,737165L,943062L,1202809L,1541403L,1978219L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188099Inst : IEnumerable<long>
{
public static readonly long[] Value=A188099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188099.Bytes);
public long this[int i]=>Value[i];

public static A188099Inst Instance=new A188099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188100
{
public static readonly long[] Value={ 3594L,643L,1421L,3341L,5037L,5661L,5953L,6253L,6581L,7077L,8093L,10545L,15169L,21210L,28063L,36652L,47741L,60743L,75573L,94591L,120733L,154829L,197606L,253160L,326927L,421650L,539884L,689913L,884297L,1133733L,1449457L,1852530L,2373725L,3044695L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188100Inst : IEnumerable<long>
{
public static readonly long[] Value=A188100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188100.Bytes);
public long this[int i]=>Value[i];

public static A188100Inst Instance=new A188100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188101
{
public static readonly long[] Value={ 8274L,1482L,3013L,5037L,7661L,8509L,8873L,9265L,9825L,10805L,13085L,16429L,22789L,30417L,41390L,53819L,69824L,88077L,111955L,140633L,179247L,227737L,292825L,375142L,483400L,619787L,796650L,1019420L,1306745L,1670689L,2140197L,2737929L,3508474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188101Inst : IEnumerable<long>
{
public static readonly long[] Value=A188101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188101.Bytes);
public long this[int i]=>Value[i];

public static A188101Inst Instance=new A188101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188102
{
public static readonly long[] Value={ 13814L,2374L,3765L,5661L,8509L,10229L,10653L,11245L,12257L,14405L,17321L,21217L,28861L,38625L,49581L,64510L,84199L,108156L,136221L,172155L,220493L,282863L,360297L,460529L,592854L,763168L,976611L,1248786L,1601392L,2054357L,2627885L,3360377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188102Inst : IEnumerable<long>
{
public static readonly long[] Value=A188102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188102.Bytes);
public long this[int i]=>Value[i];

public static A188102Inst Instance=new A188102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188103
{
public static readonly long[] Value={ 17850L,2866L,4041L,5953L,8873L,10653L,11457L,12477L,14633L,17361L,20685L,25233L,34381L,45145L,57105L,71309L,94870L,122775L,155200L,194417L,252139L,324969L,414279L,524585L,676957L,872342L,1116632L,1421135L,1825426L,2345560L,3003909L,3832777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188103Inst : IEnumerable<long>
{
public static readonly long[] Value=A188103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188103.Bytes);
public long this[int i]=>Value[i];

public static A188103Inst Instance=new A188103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188104
{
public static readonly long[] Value={ 20888L,3110L,4285L,6253L,9265L,11245L,12477L,14853L,17589L,20717L,24669L,30593L,40709L,52461L,66065L,83805L,108473L,140714L,178759L,226864L,292013L,376487L,480369L,612051L,785445L,1010405L,1292818L,1651136L,2116315L,2717534L,3480088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188104Inst : IEnumerable<long>
{
public static readonly long[] Value=A188104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188104.Bytes);
public long this[int i]=>Value[i];

public static A188104Inst Instance=new A188104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188105
{
public static readonly long[] Value={ 65536L,708L,708L,1417L,143L,1417L,3594L,243L,243L,3594L,8274L,643L,486L,643L,8274L,13814L,1482L,1421L,1421L,1482L,13814L,17850L,2374L,3013L,3341L,3013L,2374L,17850L,20888L,2866L,3765L,5037L,5037L,3765L,2866L,20888L,24117L,3110L,4041L,5661L,7661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188105Inst : IEnumerable<long>
{
public static readonly long[] Value=A188105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188105.Bytes);
public long this[int i]=>Value[i];

public static A188105Inst Instance=new A188105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188106
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,5L,1L,6L,14L,11L,1L,8L,27L,42L,25L,1L,10L,44L,101L,119L,56L,1L,12L,65L,196L,342L,322L,126L,1L,14L,90L,335L,770L,1080L,847L,283L,1L,16L,119L,526L,1495L,2772L,3248L,9414L,5521L,1429L,1L,18L,152L,777L,2625L,6032L,9366L,9414L,5521L,1429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188106Inst : IEnumerable<long>
{
public static readonly long[] Value=A188106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188106.Bytes);
public long this[int i]=>Value[i];

public static A188106Inst Instance=new A188106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188107
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,1L,3L,7L,4L,1L,4L,12L,14L,9L,1L,5L,18L,31L,35L,14L,1L,6L,25L,56L,87L,70L,28L,1L,7L,33L,90L,175L,207L,154L,47L,1L,8L,42L,134L,310L,476L,504L,306L,89L,1L,9L,52L,189L,504L,941L,1274L,1137L,633L,155L,1L,10L,63L,256L,770L,1680L,2745L,3188L,2571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188107Inst : IEnumerable<long>
{
public static readonly long[] Value=A188107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188107.Bytes);
public long this[int i]=>Value[i];

public static A188107Inst Instance=new A188107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188684
{
public static readonly BigInteger[] Value={ 1L,2L,11L,155L,3180L,77709L,2116893L,62210397L,1933897566L,62782453191L,2109727864416L,72915894194016L,2579631197677680L,93078664247524864L,3415556450680435264L,BigInteger.Parse("127175745034380516160"),BigInteger.Parse("4795994499281447607841") };
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
public class A188684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188684Inst Instance=new A188684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188685
{
public static readonly BigInteger[] Value={ 1L,0L,9L,135L,2890L,71639L,1967545L,58125959L,1813561210L,59034994415L,1987910416810L,68818255912790L,2437897047570874L,88061136002276310L,3234416650430634090L,BigInteger.Parse("120525771933269446806"),BigInteger.Parse("4548292982313797644875") };
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
public class A188685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188685Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188685.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188685Inst Instance=new A188685Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188686
{
public static readonly long[] Value={ 1L,4L,22L,139L,934L,6484L,45931L,329893L,2393470L,17499892L,128732992L,951674398L,7064138779L,52616241370L,393052285291L,2943582912904L,22093111508686L,166141033332448L,1251528633163264L,9442096410241438L,71333250226656784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188686Inst : IEnumerable<long>
{
public static readonly long[] Value=A188686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188686.Bytes);
public long this[int i]=>Value[i];

public static A188686Inst Instance=new A188686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188687
{
public static readonly long[] Value={ 1L,2L,6L,25L,126L,704L,4183L,25897L,165166L,1077520L,7156352L,48222354L,328859011L,2265428728L,15740837575L,110187356134L,776336572878L,5501042194580L,39177463572112L,280277949384146L,2013277273220064L,14514764553512488L,104993261648226446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188687Inst : IEnumerable<long>
{
public static readonly long[] Value=A188687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188687.Bytes);
public long this[int i]=>Value[i];

public static A188687Inst Instance=new A188687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188688
{
public static readonly BigInteger[] Value={ 2L,16L,218L,4008L,139307L,15547072L,3647921173L,1302269111985L,832889881464413L,1248703703842553735L,BigInteger.Parse("4253189666054817624993") };
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
public class A188688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188688Inst Instance=new A188688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188689
{
public static readonly long[] Value={ 7L,49L,218L,857L,3609L,15942L,69852L,302053L,1305379L,5658937L,24549216L,106431608L,461300682L,1999592300L,8668312567L,37577096221L,162893110032L,706125302623L,3060997024742L,13269191906269L,57520894059888L,249348416142040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188689Inst : IEnumerable<long>
{
public static readonly long[] Value=A188689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188689.Bytes);
public long this[int i]=>Value[i];

public static A188689Inst Instance=new A188689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188690
{
public static readonly long[] Value={ 12L,144L,857L,4008L,20662L,120839L,708519L,3984317L,22096751L,123685638L,697749740L,3933600940L,22113174257L,124226310961L,698384857435L,3928070328882L,22091307667400L,124217141507585L,698440667872786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188690Inst : IEnumerable<long>
{
public static readonly long[] Value=A188690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188690.Bytes);
public long this[int i]=>Value[i];

public static A188690Inst Instance=new A188690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188691
{
public static readonly long[] Value={ 21L,441L,3609L,20662L,139307L,1181340L,9908740L,75877068L,567455273L,4366586742L,34248998327L,267095931282L,2063862354490L,15938318691269L,123521439902876L,958572046267137L,7431458286122944L,57564941872885645L,445967087965474764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188691Inst : IEnumerable<long>
{
public static readonly long[] Value=A188691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188691.Bytes);
public long this[int i]=>Value[i];

public static A188691Inst Instance=new A188691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188692
{
public static readonly long[] Value={ 37L,1369L,15942L,120839L,1181340L,15547072L,196218615L,2192313402L,24054473035L,276006561506L,3234462955790L,37449962388209L,428641886155948L,4913977515021699L,56626336478764044L,653091347923944174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188692Inst : IEnumerable<long>
{
public static readonly long[] Value=A188692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188692.Bytes);
public long this[int i]=>Value[i];

public static A188692Inst Instance=new A188692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188693
{
public static readonly BigInteger[] Value={ 65L,4225L,69852L,708519L,9908740L,196218615L,3647921173L,58576420100L,923989193674L,15401563228402L,262861087544592L,4415950575544932L,73179716713561551L,1215743329351151607L,BigInteger.Parse("20324632650740759847") };
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
public class A188693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188693Inst Instance=new A188693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188694
{
public static readonly BigInteger[] Value={ 114L,12996L,302053L,3984317L,75877068L,2192313402L,58576420100L,1302269111985L,28206984293659L,655766390218062L,15755573245806302L,370650107059787034L,8548930540422322425L,BigInteger.Parse("197761650191226073279"),BigInteger.Parse("4617841834907852976248") };
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
public class A188694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188694Inst Instance=new A188694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188695
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,21L,144L,218L,144L,21L,37L,441L,857L,857L,441L,37L,65L,1369L,3609L,4008L,3609L,1369L,65L,114L,4225L,15942L,20662L,20662L,15942L,4225L,114L,200L,12996L,69852L,120839L,139307L,120839L,69852L,12996L,200L,351L,40000L,302053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188695Inst : IEnumerable<long>
{
public static readonly long[] Value=A188695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188695.Bytes);
public long this[int i]=>Value[i];

public static A188695Inst Instance=new A188695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188696
{
public static readonly BigInteger[] Value={ 1L,26L,676L,17576L,456974L,11881272L,308911722L,8031669672L,208822498874L,5429361243280L,141162775414434L,3670216121163384L,95425202122161082L,2481044412493313472L,BigInteger.Parse("64506872816303408306"),BigInteger.Parse("1677171363634329163848"),BigInteger.Parse("43606264885996836679850"),BigInteger.Parse("1133757932276682326501264"),BigInteger.Parse("29477577416016603603796450"),BigInteger.Parse("766413663428463660467554840") };
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
public class A188696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188696Inst Instance=new A188696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188697
{
public static readonly BigInteger[] Value={ 1L,26L,676L,17576L,456972L,11881168L,308907672L,8031529376L,208817941280L,5429219088800L,141158464323104L,3670088041052160L,95421456259562432L,2480936209934965120L,BigInteger.Parse("64503778490067388160"),BigInteger.Parse("1677083603695215199744"),BigInteger.Parse("43603793136187040353536"),BigInteger.Parse("1133688727070116383116288"),BigInteger.Parse("29475649649828842801150464"),BigInteger.Parse("766360202350076625301264384") };
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
public class A188697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188697Inst Instance=new A188697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188698
{
public static readonly long[] Value={ 1L,2L,690L,33190L,57106L,77140L,135606L,258990L,303430L,331140L,337536L,359230L,375646L,455526L,458326L,493396L,548226L,550540L,585106L,602056L,659250L,680830L,742306L,800406L,827680L,870240L,918340L,925390L,968320L,1203100L,1273890L,1455526L,1497576L,1605016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188698Inst : IEnumerable<long>
{
public static readonly long[] Value=A188698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188698.Bytes);
public long this[int i]=>Value[i];

public static A188698Inst Instance=new A188698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188699
{
public static readonly long[] Value={ 10L,46L,52L,15406L,450066L,117116L,225159022L,1872426L,680627620L,223657336L,147298L,589192L,11922706L,74527876206L,141991475986L,2377827762166L,584200732L,32196037719226L,4698165844L,18792663376L,2948912018446566L,175158375580L,700633502320L,708490569714927006L,2737249942690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188699Inst : IEnumerable<long>
{
public static readonly long[] Value=A188699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188699.Bytes);
public long this[int i]=>Value[i];

public static A188699Inst Instance=new A188699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188732
{
public static readonly long[] Value={ 2L,1L,3L,5L,0L,4L,1L,6L,1L,2L,6L,5L,1L,1L,0L,9L,0L,6L,5L,6L,8L,8L,2L,8L,7L,1L,2L,2L,6L,2L,6L,5L,1L,6L,9L,0L,2L,2L,6L,1L,3L,8L,4L,1L,8L,9L,4L,4L,1L,4L,2L,7L,2L,1L,6L,6L,9L,6L,2L,0L,7L,2L,9L,3L,3L,6L,5L,1L,3L,0L,9L,3L,1L,4L,8L,9L,4L,5L,4L,5L,0L,9L,0L,7L,0L,9L,0L,5L,5L,0L,8L,7L,1L,1L,1L,6L,7L,4L,8L,2L,5L,3L,0L,1L,5L,0L,2L,7L,2L,4L,5L,2L,9L,0L,1L,2L,1L,8L,7L,4L,6L,9L,1L,0L,7L,5L,7L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188732Inst : IEnumerable<long>
{
public static readonly long[] Value=A188732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188732.Bytes);
public long this[int i]=>Value[i];

public static A188732Inst Instance=new A188732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188733
{
public static readonly long[] Value={ 2L,6L,3L,0L,1L,9L,9L,3L,2L,2L,3L,4L,9L,0L,3L,6L,9L,3L,5L,0L,1L,6L,0L,3L,0L,1L,2L,8L,7L,9L,7L,3L,2L,6L,0L,0L,6L,5L,5L,3L,1L,6L,9L,0L,5L,0L,6L,3L,1L,7L,2L,9L,2L,4L,4L,0L,0L,9L,0L,5L,4L,1L,6L,5L,5L,6L,5L,8L,1L,1L,6L,4L,4L,1L,9L,5L,7L,2L,5L,8L,1L,8L,4L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188733Inst : IEnumerable<long>
{
public static readonly long[] Value=A188733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188733.Bytes);
public long this[int i]=>Value[i];

public static A188733Inst Instance=new A188733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188734
{
public static readonly long[] Value={ 3L,7L,6L,5L,5L,6L,4L,4L,3L,7L,0L,7L,4L,6L,3L,7L,4L,1L,3L,0L,9L,1L,6L,5L,3L,3L,0L,7L,5L,7L,5L,9L,4L,2L,7L,8L,2L,7L,8L,3L,5L,9L,9L,0L,7L,6L,4L,0L,2L,1L,4L,3L,3L,4L,6L,9L,8L,4L,1L,4L,8L,0L,9L,7L,3L,1L,5L,9L,6L,8L,7L,3L,7L,7L,5L,6L,4L,2L,2L,0L,5L,0L,7L,4L,0L,0L,3L,8L,5L,6L,6L,6L,7L,9L,3L,0L,7L,6L,6L,0L,9L,0L,9L,3L,6L,0L,6L,1L,6L,5L,3L,4L,9L,8L,6L,4L,7L,8L,0L,5L,3L,4L,3L,7L,1L,6L,3L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188734Inst : IEnumerable<long>
{
public static readonly long[] Value=A188734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188734.Bytes);
public long this[int i]=>Value[i];

public static A188734Inst Instance=new A188734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188735
{
public static readonly long[] Value={ 4L,7L,1L,2L,2L,1L,4L,4L,5L,0L,4L,4L,9L,0L,2L,6L,1L,8L,0L,4L,3L,6L,5L,5L,2L,8L,5L,3L,7L,2L,9L,4L,0L,6L,1L,2L,0L,4L,2L,4L,0L,3L,4L,0L,7L,1L,8L,6L,0L,6L,9L,1L,0L,4L,2L,9L,3L,0L,7L,8L,8L,6L,3L,2L,4L,5L,9L,1L,1L,0L,1L,4L,5L,9L,2L,6L,9L,1L,9L,6L,5L,7L,5L,2L,3L,3L,0L,0L,1L,9L,6L,0L,2L,8L,8L,5L,6L,4L,4L,0L,6L,0L,9L,5L,2L,5L,2L,9L,9L,7L,1L,7L,9L,3L,7L,2L,9L,9L,9L,2L,9L,5L,1L,8L,7L,7L,5L,9L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188735Inst : IEnumerable<long>
{
public static readonly long[] Value=A188735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188735.Bytes);
public long this[int i]=>Value[i];

public static A188735Inst Instance=new A188735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188736
{
public static readonly long[] Value={ 1L,7L,6L,6L,1L,9L,0L,3L,7L,8L,9L,6L,9L,0L,6L,0L,0L,9L,4L,1L,7L,4L,8L,3L,0L,5L,7L,5L,5L,0L,9L,1L,1L,6L,6L,1L,5L,3L,0L,4L,2L,7L,9L,6L,6L,6L,9L,7L,7L,1L,9L,4L,3L,9L,0L,8L,9L,0L,0L,0L,1L,3L,4L,8L,9L,7L,3L,5L,6L,2L,0L,1L,2L,3L,9L,9L,3L,4L,2L,5L,2L,5L,5L,3L,3L,0L,4L,8L,0L,6L,5L,2L,9L,0L,6L,0L,7L,0L,7L,9L,7L,1L,1L,3L,5L,7L,9L,2L,4L,4L,1L,5L,0L,7L,0L,9L,8L,2L,2L,7L,0L,3L,6L,2L,7L,7L,4L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188736Inst : IEnumerable<long>
{
public static readonly long[] Value=A188736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188736.Bytes);
public long this[int i]=>Value[i];

public static A188736Inst Instance=new A188736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188737
{
public static readonly long[] Value={ 2L,7L,0L,3L,2L,5L,7L,4L,0L,9L,5L,4L,8L,8L,1L,4L,5L,5L,1L,6L,6L,7L,0L,4L,5L,7L,1L,3L,6L,2L,7L,1L,3L,2L,1L,9L,2L,8L,7L,4L,4L,6L,7L,5L,0L,8L,1L,2L,0L,4L,1L,0L,6L,6L,8L,0L,0L,1L,2L,9L,2L,0L,3L,4L,2L,4L,0L,4L,4L,5L,1L,7L,1L,1L,3L,3L,6L,4L,5L,9L,1L,0L,1L,2L,7L,9L,8L,2L,3L,4L,8L,4L,6L,5L,5L,4L,6L,7L,6L,0L,8L,2L,3L,3L,8L,9L,9L,6L,8L,1L,4L,6L,4L,7L,8L,6L,1L,4L,0L,2L,5L,3L,5L,4L,1L,1L,0L,5L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188737Inst : IEnumerable<long>
{
public static readonly long[] Value=A188737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188737.Bytes);
public long this[int i]=>Value[i];

public static A188737Inst Instance=new A188737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188738
{
public static readonly long[] Value={ 1L,9L,0L,6L,2L,3L,6L,0L,4L,1L,4L,7L,3L,3L,0L,6L,1L,4L,2L,5L,9L,4L,2L,8L,2L,5L,6L,5L,4L,1L,5L,5L,5L,2L,6L,8L,6L,6L,3L,0L,2L,2L,2L,0L,2L,0L,9L,8L,3L,5L,6L,4L,6L,1L,7L,3L,5L,2L,7L,3L,3L,7L,6L,8L,0L,9L,7L,0L,9L,0L,8L,8L,4L,4L,9L,2L,2L,1L,1L,4L,1L,7L,5L,2L,8L,9L,1L,5L,0L,6L,9L,9L,1L,0L,3L,7L,0L,9L,9L,6L,5L,5L,4L,3L,2L,5L,2L,3L,9L,9L,5L,5L,8L,1L,9L,8L,4L,7L,5L,9L,5L,9L,2L,6L,2L,9L,9L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188738Inst : IEnumerable<long>
{
public static readonly long[] Value=A188738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188738.Bytes);
public long this[int i]=>Value[i];

public static A188738Inst Instance=new A188738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188739
{
public static readonly long[] Value={ 5L,2L,4L,5L,9L,4L,0L,0L,5L,2L,7L,7L,0L,7L,5L,9L,8L,5L,6L,4L,6L,1L,1L,4L,6L,6L,8L,6L,1L,6L,3L,7L,6L,9L,7L,2L,6L,8L,5L,1L,4L,7L,1L,9L,8L,5L,3L,0L,1L,5L,6L,2L,6L,8L,8L,1L,9L,8L,6L,6L,1L,8L,7L,8L,6L,3L,8L,4L,4L,4L,1L,7L,2L,2L,5L,7L,8L,7L,4L,0L,4L,7L,3L,8L,9L,8L,7L,2L,8L,5L,0L,0L,5L,9L,2L,9L,5L,7L,5L,5L,1L,9L,9L,5L,0L,0L,2L,5L,9L,8L,6L,8L,4L,2L,4L,1L,3L,5L,0L,8L,4L,0L,4L,2L,1L,9L,7L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188739Inst : IEnumerable<long>
{
public static readonly long[] Value=A188739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188739.Bytes);
public long this[int i]=>Value[i];

public static A188739Inst Instance=new A188739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188740
{
public static readonly BigInteger[] Value={ 2L,16L,292L,17286L,3283906L,1536573216L,2307086087740L,10143499802360135L,BigInteger.Parse("123466985032906186049"),BigInteger.Parse("4528058434298770108386326"),BigInteger.Parse("481947777827695507476795332215"),BigInteger.Parse("147455854241909275954639647341005231") };
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
public class A188740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188740Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188740.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188740Inst Instance=new A188740Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188741
{
public static readonly long[] Value={ 8L,64L,292L,1651L,9504L,52072L,289776L,1617326L,8992115L,50039730L,278556885L,1550225927L,8627663414L,48018101493L,267244802833L,1487352476813L,8277889631533L,46070713404315L,256407195751421L,1427038070447781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188741Inst : IEnumerable<long>
{
public static readonly long[] Value=A188741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188741.Bytes);
public long this[int i]=>Value[i];

public static A188741Inst Instance=new A188741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188742
{
public static readonly long[] Value={ 16L,256L,1723L,17286L,176002L,1605680L,15398676L,148041805L,1404107414L,13398153644L,127892153741L,1218764127847L,11622887616476L,110848330389832L,1056953079327533L,10079078798340060L,96114455989370660L,916528036067337866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188742Inst : IEnumerable<long>
{
public static readonly long[] Value=A188742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188742.Bytes);
public long this[int i]=>Value[i];

public static A188742Inst Instance=new A188742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188743
{
public static readonly long[] Value={ 32L,1024L,10327L,184411L,3283906L,50067824L,828466161L,13666030547L,221062541460L,3615827505717L,59094131400635L,963450629620601L,15731137751927915L,256815197782250586L,4191335618980407425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188743Inst : IEnumerable<long>
{
public static readonly long[] Value=A188743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188743.Bytes);
public long this[int i]=>Value[i];

public static A188743Inst Instance=new A188743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188744
{
public static readonly BigInteger[] Value={ 64L,4096L,61996L,1944586L,60714322L,1536573216L,43558358008L,1229158478968L,33715030639152L,940176798492406L,26184077081950792L,726505692803789842L,BigInteger.Parse("20205409790700030932"),BigInteger.Parse("561795999161298554570"),BigInteger.Parse("15612682504741076575246") };
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
public class A188744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188744Inst Instance=new A188744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188745
{
public static readonly BigInteger[] Value={ 128L,16384L,371641L,20544154L,1127318294L,47325959200L,2307086087740L,111642244016936L,5198138560322655L,247778079713183493L,11784953664767609408UL,BigInteger.Parse("557503350633218495686"),BigInteger.Parse("26469014360403565983659") };
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
public class A188745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188745Inst Instance=new A188745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188746
{
public static readonly BigInteger[] Value={ 256L,65536L,2227333L,217243096L,20939826298L,1458401558672L,122293738629021L,10143499802360135L,801618812875139251L,BigInteger.Parse("65318162143525733827"),BigInteger.Parse("5304356577782619235403"),BigInteger.Parse("427773556302789402791981") };
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
public class A188746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188746Inst Instance=new A188746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188747
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,7L,16L,64L,49L,13L,32L,256L,292L,169L,24L,64L,1024L,1723L,1651L,576L,44L,128L,4096L,10327L,17286L,9504L,1936L,81L,256L,16384L,61996L,184411L,176002L,52072L,6561L,149L,512L,65536L,371641L,1944586L,3283906L,1605680L,289776L,22201L,274L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188747Inst : IEnumerable<long>
{
public static readonly long[] Value=A188747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188747.Bytes);
public long this[int i]=>Value[i];

public static A188747Inst Instance=new A188747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188764
{
public static readonly long[] Value={ 29L,127L,24391L,274627L,328511L,357913L,571789L,1157627L,1442899L,1860869L,2146691L,2924209L,5177719L,9129331L,9938377L,10503461L,12326393L,15438251L,18191449L,24642173L,26730901L,28372627L,30080233L,39651823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188764Inst : IEnumerable<long>
{
public static readonly long[] Value=A188764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188764.Bytes);
public long this[int i]=>Value[i];

public static A188764Inst Instance=new A188764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188765
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,30L,57L,108L,207L,397L,761L,1456L,2784L,5324L,10185L,19488L,37288L,71341L,136486L,261117L,499561L,955756L,1828549L,3498364L,6693021L,12804983L,24498304L,46869822L,89670729L,171556853L,328220258L,627946528L,1201378750L,2298461537L,4397385531L,8413018547L,16095673253L,30794024151L,58914710037L,112714825621L,215644478604L,412568097507L,789319699503L,1510115764260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188765Inst : IEnumerable<long>
{
public static readonly long[] Value=A188765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188765.Bytes);
public long this[int i]=>Value[i];

public static A188765Inst Instance=new A188765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188766
{
public static readonly long[] Value={ 1L,12L,15L,17L,18L,22L,23L,24L,25L,27L,29L,31L,33L,37L,42L,44L,45L,46L,49L,50L,51L,52L,53L,54L,58L,59L,60L,61L,63L,64L,66L,67L,69L,70L,71L,73L,77L,79L,80L,81L,82L,83L,84L,85L,86L,87L,90L,92L,95L,96L,97L,98L,99L,100L,101L,102L,107L,110L,112L,115L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188766Inst : IEnumerable<long>
{
public static readonly long[] Value=A188766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188766.Bytes);
public long this[int i]=>Value[i];

public static A188766Inst Instance=new A188766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188767
{
public static readonly BigInteger[] Value={ 2L,16L,240L,7868L,738031L,186969392L,118984786902L,191430611504482L,791786310866344064L,BigInteger.Parse("8423565813650647334361"),BigInteger.Parse("229714505025192315490199222"),BigInteger.Parse("16049804227721101224353628972128") };
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
public class A188767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188767Inst Instance=new A188767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188768
{
public static readonly long[] Value={ 7L,49L,240L,1103L,5357L,26564L,130828L,641137L,3143331L,15426387L,75714198L,371548402L,1823195326L,8946675170L,43903164079L,215441286043L,1057208843688L,5187912250379L,25458023997998L,124927142385391L,613040099740828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188768Inst : IEnumerable<long>
{
public static readonly long[] Value=A188768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188768.Bytes);
public long this[int i]=>Value[i];

public static A188768Inst Instance=new A188768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188769
{
public static readonly long[] Value={ 12L,144L,1103L,7868L,60215L,471349L,3658041L,28240356L,218167554L,1687182731L,13048449716L,100897161709L,780153946407L,6032429478257L,46645504480302L,360683651186398L,2788957182000107L,21565381169985048L,166752620658425497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188769Inst : IEnumerable<long>
{
public static readonly long[] Value=A188769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188769.Bytes);
public long this[int i]=>Value[i];

public static A188769Inst Instance=new A188769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188770
{
public static readonly long[] Value={ 21L,441L,5357L,60215L,738031L,9260851L,114928827L,1418719059L,17534258973L,216934553467L,2683742012463L,33195135531017L,410584897617051L,5078597128434733L,62818418192287393L,777013463038269315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188770Inst : IEnumerable<long>
{
public static readonly long[] Value=A188770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188770.Bytes);
public long this[int i]=>Value[i];

public static A188770Inst Instance=new A188770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188771
{
public static readonly BigInteger[] Value={ 37L,1369L,26564L,471349L,9260851L,186969392L,3725504150L,73772281769L,1462969839335L,29048017912245L,576713868595398L,11447410876473182L,227220607547197774L,4510286415908468400L,BigInteger.Parse("89529020198750399977") };
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
public class A188771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188771Inst Instance=new A188771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188772
{
public static readonly BigInteger[] Value={ 65L,4225L,130828L,3658041L,114928827L,3725504150L,118984786902L,3772804871287L,119816916752612L,3810670337663147L,121188283006836223L,3853067582126261844L,BigInteger.Parse("122500758733139379893"),BigInteger.Parse("3894834135997239917934"),BigInteger.Parse("123835414312916823578527") };
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
public class A188772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188772Inst Instance=new A188772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188773
{
public static readonly BigInteger[] Value={ 114L,12996L,641137L,28240356L,1418719059L,73772281769L,3772804871287L,191430611504482L,9730213136489790L,495351189671153051L,BigInteger.Parse("25215983801380475678"),BigInteger.Parse("1283271380583388569167"),BigInteger.Parse("65304983732786290676835") };
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
public class A188773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188773Inst Instance=new A188773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188774
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,12L,49L,49L,12L,21L,144L,240L,144L,21L,37L,441L,1103L,1103L,441L,37L,65L,1369L,5357L,7868L,5357L,1369L,65L,114L,4225L,26564L,60215L,60215L,26564L,4225L,114L,200L,12996L,130828L,471349L,738031L,471349L,130828L,12996L,200L,351L,40000L,641137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188774Inst : IEnumerable<long>
{
public static readonly long[] Value=A188774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188774.Bytes);
public long this[int i]=>Value[i];

public static A188774Inst Instance=new A188774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188775
{
public static readonly long[] Value={ 1L,2L,3L,6L,14L,42L,46L,1806L,2185L,4758L,5266L,10895L,24342L,26495L,44063L,52793L,381826L,543026L,547311L,805002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188775Inst : IEnumerable<long>
{
public static readonly long[] Value=A188775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188775.Bytes);
public long this[int i]=>Value[i];

public static A188775Inst Instance=new A188775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188776
{
public static readonly long[] Value={ 1L,2L,9L,30L,6871L,185779L,208541L,813162L,864355L,2573155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188776Inst : IEnumerable<long>
{
public static readonly long[] Value=A188776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188776.Bytes);
public long this[int i]=>Value[i];

public static A188776Inst Instance=new A188776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188777
{
public static readonly long[] Value={ 1L,4L,0L,9L,4L,0L,16L,20L,0L,0L,25L,56L,28L,0L,0L,36L,120L,152L,24L,0L,0L,49L,220L,488L,328L,8L,0L,0L,64L,364L,1192L,1720L,584L,0L,0L,0L,81L,560L,2468L,5816L,5464L,840L,0L,0L,0L,100L,816L,4560L,15424L,26360L,15824L,784L,0L,0L,0L,121L,1140L,7760L,34736L,91120L,112680L,40496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188777Inst : IEnumerable<long>
{
public static readonly long[] Value=A188777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188777.Bytes);
public long this[int i]=>Value[i];

public static A188777Inst Instance=new A188777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188778
{
public static readonly long[] Value={ 0L,0L,28L,152L,488L,1192L,2468L,4560L,7760L,12400L,18860L,27560L,38968L,53592L,71988L,94752L,122528L,156000L,195900L,243000L,298120L,362120L,435908L,520432L,616688L,725712L,848588L,986440L,1140440L,1311800L,1501780L,1711680L,1942848L,2196672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188778Inst : IEnumerable<long>
{
public static readonly long[] Value=A188778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188778.Bytes);
public long this[int i]=>Value[i];

public static A188778Inst Instance=new A188778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188779
{
public static readonly long[] Value={ 0L,0L,24L,328L,1720L,5816L,15424L,34736L,69776L,128528L,221448L,361528L,564872L,850696L,1241968L,1765344L,2451872L,3336864L,4460664L,5868456L,7611096L,9744856L,12332320L,15442064L,19149616L,23537072L,28694120L,34717592L,41712552L,49791784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188779Inst : IEnumerable<long>
{
public static readonly long[] Value=A188779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188779.Bytes);
public long this[int i]=>Value[i];

public static A188779Inst Instance=new A188779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188796
{
public static readonly long[] Value={ 5L,1L,1L,1L,1L,2L,7L,1L,7L,3L,1L,5L,2L,5L,1L,1L,1L,3L,6L,8L,26L,2L,1L,2L,3L,1L,1L,1L,13L,1L,10L,2L,5L,1L,10L,1L,1L,4L,1L,1L,2L,1L,3L,3L,2L,7L,1L,2L,21L,1L,1L,1L,1L,3L,2L,8L,9L,4L,2L,8L,1L,2L,1L,7L,1L,1L,19L,1L,4L,9L,1L,2L,1L,4L,2L,1L,4L,1L,4L,6L,2L,5L,10L,1L,2L,2L,10L,1L,1L,25L,1L,4L,13L,9L,2L,1L,2L,4L,8L,1L,1L,33L,1L,2L,1L,1L,1L,21L,1L,3L,1L,18L,1L,6L,43L,2L,1L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188796Inst : IEnumerable<long>
{
public static readonly long[] Value=A188796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188796.Bytes);
public long this[int i]=>Value[i];

public static A188796Inst Instance=new A188796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188797
{
public static readonly long[] Value={ 1L,-1L,-3L,-9L,-18L,-54L,69L,513L,4968L,14904L,321L,33588L,257580L,502200L,1506600L,160839L,2808945L,20019960L,162100440L,796330440L,2388991320L,1416951L,-41843142L,-376375410L,-9465715080L,-144916218720L,-1289959784640L,-3869879353920L,-388946691L,-6519779667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188797Inst : IEnumerable<long>
{
public static readonly long[] Value=A188797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188797.Bytes);
public long this[int i]=>Value[i];

public static A188797Inst Instance=new A188797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188798
{
public static readonly BigInteger[] Value={ 1L,-3L,-54L,14904L,1506600L,2388991320L,-3869879353920L,-4031870972999040L,-2165167367958199680L,BigInteger.Parse("-98412959103275185776000"),BigInteger.Parse("400340096281866699127468800"),BigInteger.Parse("2867095983985997250950399692800"),BigInteger.Parse("20515582531363614789223090393804800"),BigInteger.Parse("-111176909793416483402959193090747904000") };
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
public class A188798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188798Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188798.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188798Inst Instance=new A188798Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188799
{
public static readonly BigInteger[] Value={ -1L,-18L,4968L,502200L,796330440L,-1289959784640L,-1343956990999680L,-721722455986066560L,BigInteger.Parse("-32804319701091728592000"),BigInteger.Parse("133446698760622233042489600"),BigInteger.Parse("955698661328665750316799897600"),BigInteger.Parse("6838527510454538263074363464601600"),BigInteger.Parse("-37058969931138827800986397696915968000") };
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
public class A188799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188799Inst Instance=new A188799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188800
{
public static readonly BigInteger[] Value={ 1L,-1L,-9L,69L,321L,160839L,1416951L,-388946691L,25514578881L,-7647989401521L,-1013917176434889L,-155812911328032651L,BigInteger.Parse("58581931023896704641"),BigInteger.Parse("-5858755019306243919081"),BigInteger.Parse("-408029640141643683923529"),BigInteger.Parse("1792307462194161463885110189"),BigInteger.Parse("320024081648207578976876009601") };
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
public class A188800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188800Inst Instance=new A188800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188801
{
public static readonly BigInteger[] Value={ -3L,-18L,513L,33588L,2808945L,-41843142L,-6519779667L,-485174610648L,-544306979739483L,-86437871519050170L,457002245380426137L,BigInteger.Parse("3569731062346847916252"),BigInteger.Parse("-620271257755918954475367"),BigInteger.Parse("292423979518758253028885778"),BigInteger.Parse("278778044913113754743640514245") };
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
public class A188801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188801Inst Instance=new A188801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188802
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,10L,-1L,-32L,-95L,-198L,-331L,-440L,-389L,82L,1375L,3968L,8161L,13490L,17669L,15048L,-5045L,-58918L,-165601L,-336160L,-549439L,-708758L,-579595L,275848L,2518651L,6905250L,13838399L,22363648L,28398145L,22214242L,-14137211L,-107434360L,-287695349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188802Inst : IEnumerable<long>
{
public static readonly long[] Value=A188802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188802.Bytes);
public long this[int i]=>Value[i];

public static A188802Inst Instance=new A188802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188803
{
public static readonly BigInteger[] Value={ 3L,17L,257L,641L,65537L,167772161L,2748779069441L,46179488366593L,BigInteger.Parse("1328165573307087716353"),BigInteger.Parse("188894659314785808547841") };
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
public class A188803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188803Inst Instance=new A188803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188804
{
public static readonly long[] Value={ 0L,2L,1L,3L,1L,1L,2L,3L,1L,4L,1L,1L,34L,4L,1L,3L,2L,1L,2L,2L,14L,1L,9L,5L,1L,1L,1L,1L,1L,9L,2L,1L,3L,2L,2L,2L,3L,26L,1L,8L,10L,2L,1L,23L,1L,67L,1L,2L,5L,1L,2L,3L,1L,1L,2L,1L,1L,17L,1L,2L,1L,9L,3L,8L,3L,3L,1L,2L,1L,21L,4L,1L,3L,1L,74L,1L,3L,1L,26L,1L,19L,1L,1L,2L,3L,1L,5L,1L,4L,2L,1L,2L,1L,2L,1L,1L,1L,1L,3L,4L,1L,1L,2L,1L,1L,1L,7L,1L,2L,38L,1L,9L,5L,6L,1L,1L,2L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188804Inst : IEnumerable<long>
{
public static readonly long[] Value=A188804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188804.Bytes);
public long this[int i]=>Value[i];

public static A188804Inst Instance=new A188804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188805
{
public static readonly BigInteger[] Value={ -1L,3L,-16L,126L,-1320L,17280L,-271440L,4974480L,-104186880L,2454883200L,-64269676800L,1850862182400L,-58147441228800L,1979015707468800L,-72535825410048000L,2848518844883712000L,BigInteger.Parse("-119320306456006656000"),BigInteger.Parse("5310538503447969792000") };
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
public class A188805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188805Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188805.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188805Inst Instance=new A188805Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188806
{
public static readonly long[] Value={ 6L,82L,2720L,194568L,26101232L,5919004912L,2103543163584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188806Inst : IEnumerable<long>
{
public static readonly long[] Value=A188806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188806.Bytes);
public long this[int i]=>Value[i];

public static A188806Inst Instance=new A188806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188807
{
public static readonly long[] Value={ 24L,1313L,194568L,72104097L,57951767544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188807Inst : IEnumerable<long>
{
public static readonly long[] Value=A188807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188807.Bytes);
public long this[int i]=>Value[i];

public static A188807Inst Instance=new A188807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188808
{
public static readonly long[] Value={ 1L,2L,2L,6L,9L,6L,24L,82L,82L,24L,120L,1313L,2720L,1313L,120L,720L,32826L,194568L,194568L,32826L,720L,5040L,1181737L,26101232L,72104097L,26101232L,1181737L,5040L,40320L,57905114L,5919004912L,57951767544L,57951767544L,5919004912L,57905114L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188808Inst : IEnumerable<long>
{
public static readonly long[] Value=A188808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188808.Bytes);
public long this[int i]=>Value[i];

public static A188808Inst Instance=new A188808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188809
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,17L,29L,31L,43L,47L,59L,67L,71L,79L,83L,97L,103L,107L,127L,157L,163L,269L,271L,359L,383L,439L,457L,463L,487L,509L,547L,569L,571L,607L,643L,659L,683L,701L,709L,751L,769L,863L,907L,929L,983L,1087L,1217L,1303L,1427L,1487L,2069L,2371L,2609L,2671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188809Inst : IEnumerable<long>
{
public static readonly long[] Value=A188809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188809.Bytes);
public long this[int i]=>Value[i];

public static A188809Inst Instance=new A188809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188810
{
public static readonly long[] Value={ 1L,4L,20L,272L,6032L,205312L,9672448L,601903360L,47722897664L,4692633242624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188810Inst : IEnumerable<long>
{
public static readonly long[] Value=A188810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188810.Bytes);
public long this[int i]=>Value[i];

public static A188810Inst Instance=new A188810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188811
{
public static readonly long[] Value={ 2L,20L,448L,25904L,2952608L,596917696L,194286402560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188811Inst : IEnumerable<long>
{
public static readonly long[] Value=A188811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188811.Bytes);
public long this[int i]=>Value[i];

public static A188811Inst Instance=new A188811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188892
{
public static readonly long[] Value={ 11L,18L,38L,102L,198L,326L,486L,678L,902L,1158L,1446L,1766L,2118L,2918L,3366L,3846L,4358L,4902L,5478L,6086L,6726L,7398L,8102L,8838L,9606L,10406L,11238L,12102L,12998L,13926L,14886L,15878L,16902L,17958L,19046L,20166L,21318L,22502L,24966L,26246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188892Inst : IEnumerable<long>
{
public static readonly long[] Value=A188892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188892.Bytes);
public long this[int i]=>Value[i];

public static A188892Inst Instance=new A188892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188893
{
public static readonly long[] Value={ 2L,8L,20L,3L,10L,6L,25L,4L,0L,14L,8L,50L,5L,9L,21L,0L,43L,23L,6L,154L,11L,16L,26L,56L,12L,7L,49L,34L,40L,342L,19L,25L,1634L,8L,115L,0L,33L,89L,15L,47L,54L,638L,9L,36L,117L,30L,99L,204L,38L,17L,146L,133L,10L,62L,70L,18L,41L,49L,34L,4806L,105L,161L,329L,11L,439L,223L,28L,5974L,20L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188893Inst : IEnumerable<long>
{
public static readonly long[] Value=A188893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188893.Bytes);
public long this[int i]=>Value[i];

public static A188893Inst Instance=new A188893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188894
{
public static readonly long[] Value={ 2L,6L,12L,2L,5L,3L,10L,2L,0L,5L,3L,15L,2L,3L,6L,0L,11L,6L,2L,35L,3L,4L,6L,12L,3L,2L,10L,7L,8L,63L,4L,5L,285L,2L,20L,0L,6L,15L,3L,8L,9L,99L,2L,6L,18L,5L,15L,30L,6L,3L,21L,19L,2L,9L,10L,3L,6L,7L,5L,621L,14L,21L,42L,2L,55L,28L,4L,725L,3L,10L,11L,195L,7L,8L,460L,2L,14L,6L,28L,56L,10L,4L,36L,2107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188894Inst : IEnumerable<long>
{
public static readonly long[] Value=A188894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188894.Bytes);
public long this[int i]=>Value[i];

public static A188894Inst Instance=new A188894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188895
{
public static readonly long[] Value={ 1L,4L,96L,384L,30720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188895Inst : IEnumerable<long>
{
public static readonly long[] Value=A188895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188895.Bytes);
public long this[int i]=>Value[i];

public static A188895Inst Instance=new A188895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188896
{
public static readonly long[] Value={ 10L,20L,52L,164L,340L,580L,884L,1252L,1684L,2180L,2740L,4052L,4804L,5620L,6500L,7444L,8452L,9524L,10660L,11860L,13124L,14452L,15844L,17300L,18820L,20404L,22052L,25540L,27380L,29284L,31252L,33284L,35380L,37540L,39764L,42052L,44404L,46820L,49300L,51844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188896Inst : IEnumerable<long>
{
public static readonly long[] Value=A188896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188896.Bytes);
public long this[int i]=>Value[i];

public static A188896Inst Instance=new A188896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188897
{
public static readonly long[] Value={ 0L,1L,3L,3L,33L,429L,429L,429L,858L,4862L,14586L,25194L,25194L,1938L,21318L,490314L,245157L,72105L,312455L,148005L,148005L,4292145L,390195L,525915L,2103660L,4628052L,6052068L,672452L,2017356L,2573868L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188897Inst : IEnumerable<long>
{
public static readonly long[] Value=A188897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188897.Bytes);
public long this[int i]=>Value[i];

public static A188897Inst Instance=new A188897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188898
{
public static readonly long[] Value={ 8L,2L,81L,25L,6L,9L,2L,0L,7L,4L,3L,9L,22L,2L,49L,4L,8L,0L,17L,9L,81L,5L,2L,25L,46L,3L,10L,121L,6L,9L,18L,4L,31L,2L,11L,169L,7L,6L,1681L,49L,8L,4L,4961L,12L,225L,8L,2L,16L,32L,0L,49L,25L,17L,13L,289L,9L,49L,7L,27L,81L,118L,2L,136161L,196L,14L,4L,10L,841L,1521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188898Inst : IEnumerable<long>
{
public static readonly long[] Value=A188898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188898.Bytes);
public long this[int i]=>Value[i];

public static A188898Inst Instance=new A188898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188899
{
public static readonly BigInteger[] Value={ 1L,5L,36L,281L,2245L,18061L,145601L,1174500L,9475901L,76455961L,616891945L,4977472781L,40161441636L,324048393905L,2614631600701L,21096536145301L,170220478472105L,1373448758774436L,11081871650713781L,89415697915538545L,721463601671126161L,5821234309893001301L,BigInteger.Parse("46969478172465070500"),BigInteger.Parse("378980086070257592201"),BigInteger.Parse("3057856106268358639861") };
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
public class A188899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188899Inst Instance=new A188899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188900
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,31L,60L,114L,215L,402L,746L,1375L,2520L,4593L,8329L,15036L,27027L,48389L,86314L,153432L,271853L,480207L,845804L,1485703L,2603018L,4549521L,7933239L,13803293L,23966682L,41530721L,71830198L,124010381L,213725823L,367736268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188900Inst : IEnumerable<long>
{
public static readonly long[] Value=A188900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188900.Bytes);
public long this[int i]=>Value[i];

public static A188900Inst Instance=new A188900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188901
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,3L,2L,5L,4L,3L,1L,6L,5L,4L,2L,7L,3L,6L,5L,3L,8L,4L,2L,7L,6L,4L,9L,5L,3L,8L,4L,7L,5L,1L,10L,6L,4L,9L,5L,3L,8L,6L,2L,11L,7L,5L,10L,6L,4L,2L,9L,7L,3L,5L,12L,8L,6L,2L,11L,7L,5L,3L,10L,8L,4L,6L,4L,13L,9L,7L,3L,12L,8L,6L,4L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188901Inst : IEnumerable<long>
{
public static readonly long[] Value=A188901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188901.Bytes);
public long this[int i]=>Value[i];

public static A188901Inst Instance=new A188901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188902
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,1L,2L,3L,2L,1L,3L,1L,2L,2L,5L,1L,3L,1L,3L,2L,2L,1L,4L,3L,2L,2L,3L,1L,4L,1L,3L,2L,2L,2L,9L,1L,2L,2L,4L,1L,4L,1L,3L,3L,2L,1L,5L,3L,3L,2L,3L,1L,4L,2L,4L,2L,2L,1L,6L,1L,2L,3L,7L,2L,4L,1L,3L,2L,4L,1L,6L,1L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188902Inst : IEnumerable<long>
{
public static readonly long[] Value=A188902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188902.Bytes);
public long this[int i]=>Value[i];

public static A188902Inst Instance=new A188902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188903
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,4L,2L,2L,4L,2L,2L,4L,2L,4L,16L,2L,2L,4L,8L,2L,4L,2L,2L,4L,2L,4L,16L,2L,4L,16L,2L,2L,4L,8L,2L,4L,2L,2L,4L,8L,2L,4L,2L,4L,16L,2L,4L,16L,8L,2L,4L,2L,2L,4L,2L,2L,4L,2L,4L,16L,8L,16L,16L,0L,2L,4L,2L,4L,64L,2L,2L,4L,8L,8L,0L,2L,2L,4L,8L,2L,4L,32L,2L,4L,2L,4L,16L,2L,4L,16L,2L,2L,4L,8L,8L,64L,2L,2L,4L,2L,2L,4L,8L,8L,16L,32L,2L,4L,128L,8L,64L,32L,2L,4L,2L,2L,4L,2L,4L,16L,2L,2L,4L,8L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188903Inst : IEnumerable<long>
{
public static readonly long[] Value=A188903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188903.Bytes);
public long this[int i]=>Value[i];

public static A188903Inst Instance=new A188903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188904
{
public static readonly BigInteger[] Value={ 2L,16L,400L,21904L,2895584L,1139265009L,1206854973408L,2985549816834225L,18186473807187428754UL,BigInteger.Parse("295962659559743287398400"),BigInteger.Parse("12785274595721911779350877195"),BigInteger.Parse("1397108287594488818133966259024144") };
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
public class A188904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188904Inst Instance=new A188904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188905
{
public static readonly long[] Value={ 16L,256L,2500L,21904L,204304L,1971216L,18939904L,180741136L,1723910400L,16461916416L,157253488704L,1501977704704L,14344641154624L,136999721177344L,1308451781910784L,12496746537167104L,119353489692353536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188905Inst : IEnumerable<long>
{
public static readonly long[] Value=A188905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188905.Bytes);
public long this[int i]=>Value[i];

public static A188905Inst Instance=new A188905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188906
{
public static readonly long[] Value={ 32L,1024L,16100L,204304L,2895584L,44408896L,677191152L,10097838144L,150112575200L,2241104809024L,33534325413472L,501445374136576L,7493497502749632L,111977702705444416L,1673632397800327552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188906Inst : IEnumerable<long>
{
public static readonly long[] Value=A188906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188906.Bytes);
public long this[int i]=>Value[i];

public static A188906Inst Instance=new A188906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188907
{
public static readonly BigInteger[] Value={ 64L,4096L,103684L,1971216L,44408896L,1139265009L,28911561156L,705042350224L,17119758585609L,419737861125025L,10337825553309604L,254188800577960000L,6241275057112377604L,BigInteger.Parse("153258807856450932736"),BigInteger.Parse("3765253223213197555984") };
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
public class A188907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188907Inst Instance=new A188907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188924
{
public static readonly long[] Value={ 2L,8L,0L,5L,8L,8L,3L,7L,0L,1L,4L,7L,5L,7L,7L,8L,7L,1L,5L,0L,9L,8L,0L,8L,8L,8L,0L,9L,5L,6L,9L,3L,0L,4L,9L,6L,2L,8L,4L,2L,7L,5L,1L,3L,0L,9L,9L,9L,0L,9L,4L,3L,4L,7L,7L,6L,4L,5L,0L,9L,8L,7L,1L,0L,0L,2L,1L,7L,7L,7L,4L,0L,8L,0L,4L,8L,2L,7L,6L,6L,2L,3L,9L,4L,2L,0L,5L,3L,7L,7L,0L,7L,4L,1L,9L,7L,0L,2L,6L,5L,0L,0L,2L,9L,7L,0L,9L,4L,2L,6L,8L,9L,7L,2L,7L,1L,2L,2L,1L,3L,6L,7L,0L,3L,8L,6L,0L,7L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188924Inst : IEnumerable<long>
{
public static readonly long[] Value=A188924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188924.Bytes);
public long this[int i]=>Value[i];

public static A188924Inst Instance=new A188924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188925
{
public static readonly long[] Value={ 2L,1L,4L,6L,1L,1L,2L,25L,3L,1L,3L,2L,3L,1L,27L,1L,2L,1L,2L,2L,3L,2L,1L,1739L,1L,6L,2L,1L,2L,2L,13L,3L,1L,1L,24L,1L,1L,1L,1L,1L,1L,10L,49L,1L,4L,1L,1L,1L,1L,1L,1L,11L,3L,1L,1L,1L,10L,1L,8L,953L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,4L,2L,1L,2L,3L,278L,1L,1L,13L,1L,21L,4L,1L,1L,2L,6L,1L,1L,5L,1L,1L,1L,4L,6L,1L,1L,1L,2L,1L,2L,2L,1L,1L,6L,1L,2L,17L,1L,2L,2L,9L,3L,1L,10L,2L,1L,1L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188925Inst : IEnumerable<long>
{
public static readonly long[] Value=A188925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188925.Bytes);
public long this[int i]=>Value[i];

public static A188925Inst Instance=new A188925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188926
{
public static readonly long[] Value={ 1L,3L,2L,9L,5L,0L,8L,1L,3L,4L,3L,2L,7L,8L,7L,9L,2L,4L,9L,8L,9L,5L,7L,2L,3L,2L,4L,3L,7L,4L,0L,9L,4L,4L,4L,7L,1L,3L,3L,5L,9L,6L,0L,8L,7L,1L,9L,6L,7L,0L,0L,6L,1L,5L,6L,0L,8L,4L,7L,9L,6L,4L,8L,5L,0L,1L,0L,2L,5L,7L,3L,6L,9L,5L,8L,2L,0L,5L,2L,4L,2L,2L,9L,5L,2L,4L,1L,3L,7L,1L,6L,4L,9L,6L,4L,3L,1L,5L,2L,7L,1L,3L,0L,5L,7L,6L,8L,4L,4L,5L,4L,5L,4L,7L,8L,2L,6L,7L,9L,0L,9L,2L,1L,0L,8L,3L,3L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188926Inst : IEnumerable<long>
{
public static readonly long[] Value=A188926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188926.Bytes);
public long this[int i]=>Value[i];

public static A188926Inst Instance=new A188926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188927
{
public static readonly long[] Value={ 1L,3L,28L,1L,2L,2L,42L,1L,1L,1L,4L,2L,2L,5L,3L,1L,6L,12L,1L,9L,1L,2L,14L,2L,1L,3L,1L,16L,3L,2L,1L,1L,1L,1L,2L,34L,1L,3L,5L,1L,2L,2L,1L,27L,1L,1L,4L,3L,1L,3L,1L,16L,1L,7L,2L,15L,1L,30L,1L,78L,1L,2L,1L,6L,5L,1L,1L,5L,1L,393L,3L,13L,2L,1L,2L,1L,5L,1L,7L,1L,31L,2L,1L,3L,1L,24L,1L,1L,5L,1L,2L,1L,2L,1L,4L,6L,10L,1L,10L,8L,1L,12L,73L,1L,2L,2L,1L,17L,1L,1L,1L,24L,1L,1L,3L,14L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188927Inst : IEnumerable<long>
{
public static readonly long[] Value=A188927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188927.Bytes);
public long this[int i]=>Value[i];

public static A188927Inst Instance=new A188927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188928
{
public static readonly long[] Value={ 7L,0L,6L,9L,6L,5L,2L,8L,9L,0L,6L,0L,1L,7L,4L,3L,8L,8L,0L,1L,7L,4L,1L,1L,3L,9L,5L,0L,4L,8L,2L,2L,4L,0L,6L,8L,0L,1L,3L,6L,9L,0L,7L,0L,8L,1L,4L,6L,6L,0L,0L,7L,4L,6L,8L,8L,2L,2L,0L,6L,7L,0L,1L,5L,1L,3L,1L,0L,3L,2L,9L,8L,2L,1L,1L,0L,6L,1L,0L,5L,1L,9L,3L,6L,6L,9L,1L,1L,4L,5L,5L,5L,3L,2L,9L,8L,7L,8L,6L,9L,0L,2L,4L,7L,6L,6L,4L,6L,4L,8L,5L,4L,8L,7L,6L,9L,4L,6L,4L,3L,5L,9L,7L,0L,5L,6L,8L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188928Inst : IEnumerable<long>
{
public static readonly long[] Value=A188928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188928.Bytes);
public long this[int i]=>Value[i];

public static A188928Inst Instance=new A188928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188929
{
public static readonly long[] Value={ 7L,14L,2L,1L,4L,21L,3L,9L,1L,4L,2L,1L,1L,1L,2L,3L,25L,1L,4L,2L,1L,28L,1L,2L,1L,1L,33L,1L,1L,2L,4L,5L,17L,2L,1L,1L,1L,2L,2L,1L,5L,1L,13L,3L,1L,1L,1L,1L,1L,2L,1L,1L,34L,1L,3L,4L,7L,1L,62L,1L,38L,1L,6L,1L,2L,1L,1L,2L,3L,1L,2L,2L,196L,1L,1L,1L,26L,1L,2L,1L,2L,2L,1L,16L,1L,15L,5L,1L,1L,2L,12L,3L,1L,2L,2L,1L,2L,1L,2L,2L,12L,5L,2L,5L,17L,1L,5L,1L,1L,36L,2L,1L,5L,1L,8L,3L,50L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188929Inst : IEnumerable<long>
{
public static readonly long[] Value=A188929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188929.Bytes);
public long this[int i]=>Value[i];

public static A188929Inst Instance=new A188929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188930
{
public static readonly long[] Value={ 4L,6L,8L,5L,5L,5L,7L,7L,2L,0L,2L,8L,2L,9L,6L,7L,7L,9L,4L,6L,0L,6L,4L,5L,7L,7L,4L,3L,4L,3L,7L,1L,6L,7L,6L,2L,7L,4L,0L,6L,5L,6L,5L,8L,4L,0L,2L,6L,8L,1L,9L,5L,8L,5L,2L,7L,0L,3L,5L,8L,9L,8L,1L,2L,6L,6L,1L,4L,8L,1L,3L,0L,3L,0L,9L,5L,1L,1L,9L,9L,2L,5L,9L,5L,4L,2L,7L,3L,8L,4L,1L,4L,8L,3L,4L,2L,2L,5L,0L,9L,7L,8L,8L,1L,0L,2L,7L,7L,7L,3L,7L,7L,3L,8L,7L,9L,7L,2L,6L,2L,9L,1L,1L,2L,1L,3L,3L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188930Inst : IEnumerable<long>
{
public static readonly long[] Value=A188930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188930.Bytes);
public long this[int i]=>Value[i];

public static A188930Inst Instance=new A188930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188931
{
public static readonly long[] Value={ 4L,1L,2L,5L,1L,1L,4L,1L,2L,24L,1L,2L,4L,2L,1L,3L,8L,3L,1L,2L,1L,1L,1L,40L,3L,1L,3L,1L,3L,3L,5L,14L,1L,5L,3L,6L,1L,9L,3L,1L,1L,10L,1L,2L,2L,1L,1L,23L,6L,4L,1L,1L,4L,1L,3L,21L,1L,3L,4L,1L,2L,1L,1L,1L,1L,4L,54L,8L,2L,3L,1L,6L,1L,6L,3L,2L,32L,1L,1L,4L,2L,1L,1L,2L,1L,1L,6L,1L,4L,2L,2L,1L,1L,1L,3L,14L,1L,11L,2L,3L,6L,32L,1L,1L,1L,8L,1L,1L,1L,3L,1L,2L,1L,10L,1L,4L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188931Inst : IEnumerable<long>
{
public static readonly long[] Value=A188931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188931.Bytes);
public long this[int i]=>Value[i];

public static A188931Inst Instance=new A188931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188932
{
public static readonly long[] Value={ 5L,4L,7L,4L,1L,7L,8L,4L,3L,5L,8L,1L,0L,7L,8L,0L,6L,8L,8L,1L,0L,4L,9L,9L,3L,2L,0L,2L,0L,5L,8L,6L,5L,6L,5L,8L,2L,8L,4L,9L,6L,0L,2L,9L,3L,3L,8L,3L,6L,3L,4L,6L,3L,2L,6L,7L,2L,1L,6L,9L,3L,9L,3L,5L,1L,8L,2L,5L,3L,3L,7L,8L,0L,1L,5L,4L,4L,9L,7L,7L,0L,5L,4L,6L,1L,1L,6L,7L,9L,5L,5L,1L,2L,9L,8L,2L,6L,7L,5L,6L,0L,8L,5L,0L,9L,2L,2L,7L,0L,8L,0L,0L,3L,2L,2L,0L,5L,7L,1L,4L,5L,5L,9L,3L,2L,0L,2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188932Inst : IEnumerable<long>
{
public static readonly long[] Value=A188932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188932.Bytes);
public long this[int i]=>Value[i];

public static A188932Inst Instance=new A188932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188933
{
public static readonly long[] Value={ 5L,2L,9L,5L,2L,687L,6L,4L,1L,2L,2L,1L,2L,3L,1L,1L,1L,1L,1L,317L,19L,1L,1L,1L,6L,3L,8L,11L,10L,7L,1L,1L,5L,2L,1L,14L,1L,35L,6L,6L,1L,7L,2L,4L,1L,3L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,4L,2L,84L,1L,3L,1L,6L,2L,1L,1L,2L,3L,1L,1L,7L,1L,4L,1L,31L,9L,1L,3L,9L,7L,1L,3L,1L,1L,3L,1L,1L,62L,12L,1L,24L,2L,1L,4L,1L,2L,1L,2L,2L,1L,1L,1L,1L,2L,3L,1L,3L,1L,10L,1L,1L,1L,14L,1L,1L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188933Inst : IEnumerable<long>
{
public static readonly long[] Value=A188933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188933.Bytes);
public long this[int i]=>Value[i];

public static A188933Inst Instance=new A188933Inst();

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