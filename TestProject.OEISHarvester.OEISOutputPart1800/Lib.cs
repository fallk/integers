using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A277515
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,3L,3L,3L,3L,13L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,19L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,13L,3L,3L,3L,3L,7L,3L,3L,3L,3L,3L,5L,3L,3L,3L,3L,7L,3L,3L,3L,3L,7L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,11L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,13L,3L,3L,3L,3L,3L,7L,3L,3L,3L,3L,19L,3L,3L,3L,3L,3L,5L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277515Inst : IEnumerable<long>
{
public static readonly long[] Value=A277515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277515.Bytes);
public long this[int i]=>Value[i];

public static A277515Inst Instance=new A277515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277514
{
public static readonly long[] Value={ 4L,6L,8L,10L,7L,35L,11L,70L,30L,7L,129L,143L,10L,191L,458L,93L,11L,262L,1112L,605L,11L,370L,2209L,2513L,273L,8L,484L,4007L,7646L,2562L,10L,595L,6683L,19361L,12878L,938L,9L,765L,10697L,42633L,47555L,10311L,11L,917L,16103L,85860L,143382L,62541L,3183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277514Inst : IEnumerable<long>
{
public static readonly long[] Value=A277514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277514.Bytes);
public long this[int i]=>Value[i];

public static A277514Inst Instance=new A277514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277513
{
public static readonly long[] Value={ 4L,12L,24L,16L,40L,80L,60L,240L,64L,84L,560L,448L,112L,1120L,1792L,256L,144L,2016L,5376L,2304L,180L,3360L,13440L,11520L,1024L,220L,5280L,29568L,42240L,11264L,264L,7920L,59136L,126720L,67584L,4096L,312L,11440L,109824L,329472L,292864L,53248L,364L,16016L,192192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277513Inst : IEnumerable<long>
{
public static readonly long[] Value=A277513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277513.Bytes);
public long this[int i]=>Value[i];

public static A277513Inst Instance=new A277513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277512
{
public static readonly long[] Value={ 13L,88L,5708L,15095L,18300L,20718L,23424L,45625L,59638L,63958L,66438L,71747L,78239L,154992L,225235L,411285L,418434L,550190L,571439L,743873L,883958L,938420L,989479L,1169298L,1198004L,1256049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277512Inst : IEnumerable<long>
{
public static readonly long[] Value=A277512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277512.Bytes);
public long this[int i]=>Value[i];

public static A277512Inst Instance=new A277512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277511
{
public static readonly BigInteger[] Value={ 0L,1L,0L,9L,28L,485L,4866L,83587L,1428456L,30190617L,698093830L,18258392471L,523907661036L,16487285529013L,562892775847962L,20749534387671195L,820928954404107856L,BigInteger.Parse("34705399650797034929"),BigInteger.Parse("1561214366024349903246"),BigInteger.Parse("74464277343448593371167"),BigInteger.Parse("3753594453131028132576660") };
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
public class A277511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277511Inst Instance=new A277511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277510
{
public static readonly BigInteger[] Value={ -1L,2L,-2L,6L,8L,170L,1872L,29246L,519808L,10698642L,248787200L,6458737142L,185138721792L,5808233422394L,197952647108608L,7283047491096750L,287705410381709312L,12145740050403520034UL,BigInteger.Parse("545696709922799419392"),BigInteger.Parse("25998534614835587104742"),BigInteger.Parse("1309210567403228200960000") };
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
public class A277510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277510Inst Instance=new A277510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277509
{
public static readonly BigInteger[] Value={ 1L,0L,4L,15L,196L,2145L,33786L,587041L,12080888L,278692497L,7213075030L,205967845281L,6444486304884L,219096784628761L,8044651840755362L,317224112769528945L,13371158269397088496UL,BigInteger.Parse("599930571306586259745"),BigInteger.Parse("28547657791777984900014"),BigInteger.Parse("1436014157616531876023713") };
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
public class A277509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277509Inst Instance=new A277509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277508
{
public static readonly BigInteger[] Value={ -1L,2L,-4L,15L,-44L,385L,-294L,32473L,280120L,8528049L,170757910L,4748977321L,132530188308L,4210910824393L,142940443542274L,5273270156096265L,208276214340505456L,8800344095155520353L,BigInteger.Parse("395536292522024420142"),BigInteger.Parse("18853858817276143333321"),BigInteger.Parse("949787282108877829653580") };
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
public class A277508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277508Inst Instance=new A277508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277443
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,18L,0L,0L,2L,12L,84L,0L,0L,0L,114L,264L,260L,0L,0L,2L,180L,2652L,1920L,630L,0L,0L,0L,858L,16080L,29660L,8520L,1302L,0L,0L,2L,1932L,119844L,367080L,198030L,28140L,2408L,0L,0L,0L,7074L,816984L,4843460L,4067280L,932862L,76272L,4104L,0L,0L,2L,18660L,5784492L,62682480L,85847910L,28576380L,3440024L,179424L,6570L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277443Inst : IEnumerable<long>
{
public static readonly long[] Value=A277443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277443.Bytes);
public long this[int i]=>Value[i];

public static A277443Inst Instance=new A277443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277442
{
public static readonly long[] Value={ 0L,10L,101L,100L,10006L,950005L,1001L,9569005L,100105L,100500L,1000L,95370001L,1000201L,102100005L,9957800L,100006L,9500005L,1100005L,100100L,1010005L,10001L,10000096L,10005005L,1000105L,1001005L,999578000L,1002600005L,12500100L,100010505L,1050500005L,1000500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277442Inst : IEnumerable<long>
{
public static readonly long[] Value=A277442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277442.Bytes);
public long this[int i]=>Value[i];

public static A277442Inst Instance=new A277442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277441
{
public static readonly long[] Value={ 0L,10L,95L,950L,9500L,89476L,894760L,8946105L,89448001L,894438005L,8944300005L,89442827780L,894427300005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277441Inst : IEnumerable<long>
{
public static readonly long[] Value=A277441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277441.Bytes);
public long this[int i]=>Value[i];

public static A277441Inst Instance=new A277441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277440
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,1L,24L,3L,40L,3L,120L,1L,42L,5L,224L,5L,2592L,1L,540L,7L,220L,7L,4224L,5L,19968L,27L,728L,81L,1575L,1L,230400L,11L,8704L,77L,1377L,35L,18468L,13L,3891200L,13L,18063360L,1L,698544L,3645L,253L,3645L,5087232L,7L,307200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277440Inst : IEnumerable<long>
{
public static readonly long[] Value=A277440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277440.Bytes);
public long this[int i]=>Value[i];

public static A277440Inst Instance=new A277440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277439
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,16L,27L,20L,11L,12L,13L,56L,135L,64L,85L,18L,19L,320L,567L,352L,115L,144L,175L,832L,1215L,2240L,29L,30L,217L,2560L,8019L,78336L,70L,5184L,925L,1064L,199017L,1120L,451L,42L,5375L,315392L,5670L,329728L,2585L,1152L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277439Inst : IEnumerable<long>
{
public static readonly long[] Value=A277439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277439.Bytes);
public long this[int i]=>Value[i];

public static A277439Inst Instance=new A277439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277438
{
public static readonly long[] Value={ 2L,5L,10L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277438Inst : IEnumerable<long>
{
public static readonly long[] Value=A277438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277438.Bytes);
public long this[int i]=>Value[i];

public static A277438Inst Instance=new A277438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277437
{
public static readonly long[] Value={ 1L,3L,2L,5L,4L,9L,7L,6L,12L,20L,8L,10L,21L,36L,72L,11L,13L,25L,50L,91L,144L,14L,16L,32L,56L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277437Inst : IEnumerable<long>
{
public static readonly long[] Value=A277437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277437.Bytes);
public long this[int i]=>Value[i];

public static A277437Inst Instance=new A277437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277436
{
public static readonly BigInteger[] Value={ 1L,2L,5L,34L,569L,14426L,518557L,25400810L,1625695409L,131681938834L,13168189962101L,1593350918236562L,229442532743676265L,BigInteger.Parse("38775788044161003434"),BigInteger.Parse("7600054456561351409549"),BigInteger.Parse("1710012252724103327072026"),BigInteger.Parse("437763136697393060993682017"),BigInteger.Parse("126513546505547193228474910370") };
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
public class A277436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277436Inst Instance=new A277436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277435
{
public static readonly long[] Value={ 6L,3L,2L,0L,9L,8L,6L,6L,1L,0L,5L,0L,8L,2L,9L,2L,5L,0L,3L,5L,5L,4L,5L,0L,6L,4L,5L,9L,9L,0L,7L,8L,0L,8L,6L,2L,7L,9L,9L,4L,7L,4L,5L,5L,2L,3L,2L,4L,1L,6L,4L,4L,7L,9L,6L,6L,9L,7L,2L,3L,3L,8L,2L,4L,3L,2L,5L,8L,6L,1L,6L,2L,7L,6L,1L,5L,0L,9L,6L,2L,1L,4L,7L,0L,9L,1L,7L,6L,6L,4L,9L,4L,2L,6L,6L,7L,7L,3L,7L,1L,6L,3L,7L,9L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277435Inst : IEnumerable<long>
{
public static readonly long[] Value=A277435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277435.Bytes);
public long this[int i]=>Value[i];

public static A277435Inst Instance=new A277435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277434
{
public static readonly long[] Value={ 2L,7L,97L,708158977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277434Inst : IEnumerable<long>
{
public static readonly long[] Value=A277434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277434.Bytes);
public long this[int i]=>Value[i];

public static A277434Inst Instance=new A277434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277433
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,6L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277433Inst : IEnumerable<long>
{
public static readonly long[] Value=A277433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277433.Bytes);
public long this[int i]=>Value[i];

public static A277433Inst Instance=new A277433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277432
{
public static readonly BigInteger[] Value={ 0L,1L,2L,8L,32L,164L,984L,6896L,55168L,496528L,4965280L,54618112L,655417344L,8520425536L,119285957504L,1789289362688L,28628629803008L,486686706651392L,8760360719725056L,166446853674776576L,3328937073495531520L,BigInteger.Parse("69907678543406162944"),BigInteger.Parse("1537968927954935584768") };
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
public class A277432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277432Inst Instance=new A277432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277431
{
public static readonly BigInteger[] Value={ 1L,1L,4L,12L,52L,260L,1568L,10976L,87824L,790416L,7904192L,86946112L,1043353408L,13563594304L,189890320384L,2848354805760L,45573676892416L,774752507171072L,13945545129079808L,264965357452516352L,5299307149050328064L,BigInteger.Parse("111285450130056889344"),BigInteger.Parse("2448279902861251567616") };
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
public class A277431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277431Inst Instance=new A277431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277430
{
public static readonly BigInteger[] Value={ 72L,288L,2073600L,33177600L,2809213747200L,179789679820800L,BigInteger.Parse("704200217922109440000"),BigInteger.Parse("180275255788060016640000"),BigInteger.Parse("6231974256792696936191754240000"),BigInteger.Parse("6381541638955721662660356341760000"),BigInteger.Parse("292214732887898713986916575925267070976000000"),BigInteger.Parse("1196911545908833132490410294989893922717696000000") };
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
public class A277430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277430Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277430.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277430Inst Instance=new A277430Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277429
{
public static readonly BigInteger[] Value={ 67L,73L,46657L,25219L,29407171L,10997359L,109661317247L,31733679209L,558462830097043L,132566737763827L,BigInteger.Parse("646476041042787542443"),BigInteger.Parse("130499244418507180561"),BigInteger.Parse("2411172049639892707896547"),BigInteger.Parse("424191560077453917728503"),BigInteger.Parse("84883189962706557116984038531"),BigInteger.Parse("172244289373664036915914887721") };
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
public class A277429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277429Inst Instance=new A277429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277428
{
public static readonly long[] Value={ 0L,1L,4L,9L,11L,22L,75L,105L,449L,425L,1426L,2837L,4765L,2775L,21895L,57558L,87602L,145177L,123788L,694479L,677326L,1516496L,3363284L,2048443L,26968428L,24488513L,98733728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277428Inst : IEnumerable<long>
{
public static readonly long[] Value=A277428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277428.Bytes);
public long this[int i]=>Value[i];

public static A277428Inst Instance=new A277428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277363
{
public static readonly BigInteger[] Value={ 1L,2L,6L,52L,646L,13756L,458780L,24525352L,2094232006L,287618113900L,63647556127412L,22739228686869592L,13126310109506278556UL,BigInteger.Parse("12250085882856201785816"),BigInteger.Parse("18488349380363585366790264"),BigInteger.Parse("45134497176992058331312333648"),BigInteger.Parse("178246891228174428563552421395782") };
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
public class A277363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277363Inst Instance=new A277363Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277362
{
public static readonly BigInteger[] Value={ 1L,2L,14L,164L,2646L,53852L,1316364L,37467080L,1215510118L,44249471916L,1785942489700L,79150848980216L,3821494523507708L,199668288426274968L,11225643465179779544UL,BigInteger.Parse("675769562728962818448"),BigInteger.Parse("43370783734391689628294"),BigInteger.Parse("2956329387192674856638668") };
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
public class A277362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277362Inst Instance=new A277362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277361
{
public static readonly long[] Value={ 0L,0L,1L,2L,11L,28L,80L,194L,461L,1036L,2263L,4800L,9960L,20268L,40577L,80086L,156115L,301004L,574744L,1087918L,2043229L,3810320L,7060079L,13004832L,23826480L,43437240L,78827425L,142446698L,256400411L,459826588L,821834624L,1464149690L,2600662157L,4606368148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277361Inst : IEnumerable<long>
{
public static readonly long[] Value=A277361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277361.Bytes);
public long this[int i]=>Value[i];

public static A277361Inst Instance=new A277361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277360
{
public static readonly BigInteger[] Value={ 1L,9L,491L,64159L,15314361L,5799651689L,3193954129651L,2410542221526399L,2388182999073694001L,BigInteger.Parse("3006071549433968619529"),BigInteger.Parse("4685653563347872021885371"),BigInteger.Parse("8859314350383162594502273439"),BigInteger.Parse("19975392290718104323103596377961"),BigInteger.Parse("52949467092712165429316121638458089") };
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
public class A277360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277360Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277360.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277360Inst Instance=new A277360Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277359
{
public static readonly BigInteger[] Value={ 1L,2L,7L,32L,176L,1126L,8227L,67768L,622706L,6323932L,70400734L,852952952L,11176241098L,157506733030L,2375966883371L,38200984291800L,652179787654530L,11783182484950980L,224623760504277810L,4505795627243046240L,BigInteger.Parse("94873821120923655336"),BigInteger.Parse("2092249161797280567516") };
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
public class A277359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277359Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277359.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277359Inst Instance=new A277359Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277358
{
public static readonly BigInteger[] Value={ 1L,2L,9L,58L,491L,5142L,64159L,929078L,15314361L,283091122L,5799651689L,130423248378L,3193954129651L,84607886351462L,2410542221526399L,73500777054712438L,2388182999073694001L,BigInteger.Parse("82374234401380995042"),BigInteger.Parse("3006071549433968619529"),BigInteger.Parse("115713455097715665452858") };
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
public class A277358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277358Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277358.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277358Inst Instance=new A277358Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277357
{
public static readonly BigInteger[] Value={ 1L,4L,29L,436L,13517L,851572L,108149645L,27578159476L,14092439492237L,14416565600558452L,BigInteger.Parse("29510709784343151245"),BigInteger.Parse("120846356566885204348276"),BigInteger.Parse("989852506639356708816728717"),BigInteger.Parse("16216753616272580960544466570612"),BigInteger.Parse("531374365744403660334160536119243405") };
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
public class A277357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277357Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277357.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277357Inst Instance=new A277357Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277356
{
public static readonly BigInteger[] Value={ 21L,85L,341L,5461L,22369621L,178956971L,5726623061L,45812984491L,91625968981L,733007751851L,46912496118443L,187649984473771L,3002399751580331L,1537228672809129301L,BigInteger.Parse("49191317529892137643"),BigInteger.Parse("787061080478274202283"),BigInteger.Parse("3148244321913096809131") };
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
public class A277356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277356Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277356.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277356Inst Instance=new A277356Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277355
{
public static readonly BigInteger[] Value={ 1L,3L,18L,198L,3960L,146520L,10256400L,1384614000L,365538096000L,190445348016000L,196920489848544000L,BigInteger.Parse("405459288598152096000"),BigInteger.Parse("1665626757561208810368000"),BigInteger.Parse("13666467545789718289069440000"),BigInteger.Parse("224102734815859800504160677120000"),BigInteger.Parse("7346759955468331839927899478024960000") };
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
public class A277355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277355Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277355.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277355Inst Instance=new A277355Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277354
{
public static readonly BigInteger[] Value={ 1L,5L,85L,3145L,204425L,20646925L,2993804125L,589779412625L,151573309044625L,49261325439503125L,BigInteger.Parse("19753791501240753125"),BigInteger.Parse("9580588878101765265625"),BigInteger.Parse("5527999782664718558265625"),BigInteger.Parse("3742455852864014463945828125"),BigInteger.Parse("2937827844498251354197475078125") };
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
public class A277354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277354Inst Instance=new A277354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277353
{
public static readonly BigInteger[] Value={ 1L,4L,52L,1456L,71344L,5422144L,591013696L,87470027008L,16881715212544L,4119138511860736L,1239860692070081536L,BigInteger.Parse("451309291913509679104"),BigInteger.Parse("195416923398549691052032"),BigInteger.Parse("99271797086463243054432256"),BigInteger.Parse("58471088483926850159060598784"),BigInteger.Parse("39526455815134550707524964777984") };
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
public class A277353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277353Inst Instance=new A277353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277352
{
public static readonly BigInteger[] Value={ 1L,3L,27L,513L,16929L,863379L,63026667L,6239640033L,804913564257L,131200910973891L,26371383105752091L,6408246094697758113L,BigInteger.Parse("1851983121367652094657"),BigInteger.Parse("627822278143634060088723"),BigInteger.Parse("246734155310448185614868139"),BigInteger.Parse("111277104045012131712305530689") };
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
public class A277352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A277352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A277352Inst Instance=new A277352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277351
{
public static readonly long[] Value={ 5L,14L,19L,44L,53L,62L,71L,152L,169L,186L,203L,220L,237L,254L,271L,560L,593L,626L,659L,692L,725L,758L,791L,824L,857L,890L,923L,956L,989L,1022L,1055L,2144L,2209L,2274L,2339L,2404L,2469L,2534L,2599L,2664L,2729L,2794L,2859L,2924L,2989L,3054L,3119L,3184L,3249L,3314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277351Inst : IEnumerable<long>
{
public static readonly long[] Value=A277351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277351.Bytes);
public long this[int i]=>Value[i];

public static A277351Inst Instance=new A277351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277350
{
public static readonly long[] Value={ 1L,15853L,5520343L,111966563L,2232207889L,5551501871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277350Inst : IEnumerable<long>
{
public static readonly long[] Value=A277350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277350.Bytes);
public long this[int i]=>Value[i];

public static A277350Inst Instance=new A277350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277349
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,2L,1L,1L,0L,0L,1L,2L,2L,1L,1L,0L,1L,3L,3L,2L,1L,1L,1L,3L,4L,3L,2L,1L,2L,4L,5L,5L,3L,2L,2L,5L,7L,6L,5L,3L,3L,6L,9L,9L,7L,5L,4L,7L,11L,12L,10L,7L,6L,9L,14L,16L,14L,11L,8L,11L,17L,20L,19L,15L,12L,14L,21L,26L,25L,21L,17L,18L,26L,32L,33L,28L,23L,24L,32L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277349Inst : IEnumerable<long>
{
public static readonly long[] Value=A277349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277349.Bytes);
public long this[int i]=>Value[i];

public static A277349Inst Instance=new A277349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A277348
{
public static readonly long[] Value={ 1L,11L,341L,581337017L,7202608727L,27146455379L,1358496201131L,9843739213499L,172392038905691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A277348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A277348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A277348Inst : IEnumerable<long>
{
public static readonly long[] Value=A277348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A277348.Bytes);
public long this[int i]=>Value[i];

public static A277348Inst Instance=new A277348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276915
{
public static readonly BigInteger[] Value={ 0L,1L,10L,143L,1988L,27693L,385710L,5372251L,74825800L,1042188953L,14515819538L,202179284583L,2815994164620L,39221739020101L,546288352116790L,7608815190614963L,105977124316492688L,1476070925240282673L,BigInteger.Parse("20559015829047464730"),BigInteger.Parse("286350150681424223551") };
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
public class A276915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276915Inst Instance=new A276915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276914
{
public static readonly long[] Value={ 0L,1L,10L,15L,36L,45L,78L,91L,136L,153L,210L,231L,300L,325L,406L,435L,528L,561L,666L,703L,820L,861L,990L,1035L,1176L,1225L,1378L,1431L,1596L,1653L,1830L,1891L,2080L,2145L,2346L,2415L,2628L,2701L,2926L,3003L,3240L,3321L,3570L,3655L,3916L,4005L,4278L,4371L,4656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276914Inst : IEnumerable<long>
{
public static readonly long[] Value=A276914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276914.Bytes);
public long this[int i]=>Value[i];

public static A276914Inst Instance=new A276914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276913
{
public static readonly BigInteger[] Value={ 1L,0L,3L,0L,-35L,0L,6111L,0L,-3015207L,0L,3457389595L,0L,-7910176435083L,0L,32652618744201015L,0L,BigInteger.Parse("-225992449753641748943"),0L,BigInteger.Parse("2477459751096859267509171"),0L,BigInteger.Parse("-41090881423264757483386565235"),0L,BigInteger.Parse("992851798453466404257942193460239"),0L,BigInteger.Parse("-33857339246997857308988305386104611575"),0L,BigInteger.Parse("1586206583926227307173185697414192414735051"),0L,BigInteger.Parse("-99763501980273385738989314186327124186627104987"),0L };
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
public class A276913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276913Inst Instance=new A276913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276912
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,13L,116L,661L,8632L,70617L,1247248L,13329001L,285675776L,3782734693L,107823153088L,1685127882621L,28683829833856L,574020572798641L,133507199865641216L,2477747434090344913L,BigInteger.Parse("-832289494713919714304"),BigInteger.Parse("-16453576647394853560899"),BigInteger.Parse("11260772482520581109810176"),BigInteger.Parse("246622016098219255086463333"),BigInteger.Parse("-219530418791080092679815129088"),BigInteger.Parse("-5247252347909156791432867741559"),BigInteger.Parse("6177525915951437030555334153342976"),BigInteger.Parse("160073955175697692672876432040185401") };
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
public class A276912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276912Inst Instance=new A276912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276911
{
public static readonly BigInteger[] Value={ 1L,2L,6L,28L,180L,1446L,13888L,156472L,2034000L,29724490L,476806176L,8502508884L,174802753216L,3768345692398L,63300353418240L,1386349221087856L,149879079531401472L,5097575010920072850L,BigInteger.Parse("-780487993325688128000"),BigInteger.Parse("-32524149870689487270260"),BigInteger.Parse("10927977097616993825596416"),BigInteger.Parse("490896441869732669067535414"),BigInteger.Parse("-213936255246865273137807851520"),BigInteger.Parse("-10450262329586550037066790750808"),BigInteger.Parse("6047981224337998054714885264691200") };
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
public class A276911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276911Inst Instance=new A276911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276910
{
public static readonly BigInteger[] Value={ 1L,0L,-3L,0L,85L,0L,-6111L,0L,872649L,0L,-195062395L,0L,76208072733L,0L,-12330526252695L,0L,125980697776559377L,0L,BigInteger.Parse("857710566759117989133"),0L,BigInteger.Parse("11428318296234746748941925"),0L,BigInteger.Parse("222333914273403535165432496561"),0L,BigInteger.Parse("6242434914385931957857138485252825"),0L,BigInteger.Parse("244888574110309970555770302512462694549"),0L,BigInteger.Parse("13082369513456349871152908238665975845490989"),0L,BigInteger.Parse("930879791318792717095933863751868808486774883065"),0L };
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
public class A276910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276910Inst Instance=new A276910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276909
{
public static readonly BigInteger[] Value={ 1L,0L,3L,0L,85L,0L,6111L,0L,872649L,0L,195062395L,0L,76208072733L,0L,12330526252695L,0L,125980697776559377L,0L,BigInteger.Parse("-857710566759117989133"),0L,BigInteger.Parse("11428318296234746748941925"),0L,BigInteger.Parse("-222333914273403535165432496561"),0L,BigInteger.Parse("6242434914385931957857138485252825"),0L,BigInteger.Parse("-244888574110309970555770302512462694549"),0L,BigInteger.Parse("13082369513456349871152908238665975845490989"),0L,BigInteger.Parse("-930879791318792717095933863751868808486774883065"),0L };
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
public class A276909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276909Inst Instance=new A276909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276908
{
public static readonly BigInteger[] Value={ 1L,0L,-3L,0L,5L,0L,609L,0L,-49239L,0L,13360325L,0L,-15252271827L,0L,37424782201065L,0L,-170209716095463727L,0L,BigInteger.Parse("1318010670452522053773"),0L,BigInteger.Parse("-16258330635018856956323115"),0L,BigInteger.Parse("303578009078402791805745874289"),0L,BigInteger.Parse("-8239767220259502118041112282583175"),0L,BigInteger.Parse("314540395737200378455353074387646404949"),0L,BigInteger.Parse("-16429342682031325194203779796586447506765059"),0L,BigInteger.Parse("1147197863673453312133563419500631514117221228025"),0L };
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
public class A276908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276908Inst Instance=new A276908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276907
{
public static readonly BigInteger[] Value={ 1L,1L,7L,17L,56L,199L,890L,4649L,27817L,195946L,1684398L,17397323L,208799982L,2932164012L,49785808832L,1022745137705L,24671296028079L,695270673553051L,23526126768837873L,965093874912658722L,BigInteger.Parse("46827415587504280547"),BigInteger.Parse("2655503102769481320544"),BigInteger.Parse("179856174616910379655073"),BigInteger.Parse("14761130793635395568878091"),BigInteger.Parse("1439881917495260610082685956"),BigInteger.Parse("164363140573098989525137162900"),BigInteger.Parse("22322323085863965044351721067969") };
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
public class A276907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276907Inst Instance=new A276907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276906
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,7L,18L,53L,188L,799L,4001L,24050L,179248L,1639637L,17764040L,227653634L,3550628492L,67513114323L,1519274903363L,40153164845377L,1278514703044023L,49536414234360980L,2279497269454146657L,BigInteger.Parse("122986833567853232448"),BigInteger.Parse("7942922462379370617039"),BigInteger.Parse("622994706862172074402587"),BigInteger.Parse("58218522316121110190816538"),BigInteger.Parse("6379893924028925326363565894") };
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
public class A276906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276906Inst Instance=new A276906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276905
{
public static readonly long[] Value={ 12L,1452L,11352L,79398L,146520L,281622L,352110L,536778L,643302L,680988L,723492L,739200L,878988L,992112L,1115268L,1189650L,1397022L,1698378L,1698510L,1728540L,1806222L,2486220L,2873178L,3031578L,3571458L,3946140L,4467012L,4983858L,5064510L,5135658L,5567562L,5753352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276905Inst : IEnumerable<long>
{
public static readonly long[] Value=A276905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276905.Bytes);
public long this[int i]=>Value[i];

public static A276905Inst Instance=new A276905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276904
{
public static readonly long[] Value={ 0L,1L,3L,14L,68L,358L,1966L,11172L,65104L,387029L,2337919L,14309783L,88555917L,553171371L,3483277785L,22087378303L,140913963221L,903876307075L,5825742149049L,37710582868464L,245052827645474L,1598017940728401L,10454217006683855L,68591382498826168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276904Inst : IEnumerable<long>
{
public static readonly long[] Value=A276904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276904.Bytes);
public long this[int i]=>Value[i];

public static A276904Inst Instance=new A276904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276903
{
public static readonly long[] Value={ 0L,1L,2L,7L,25L,96L,382L,1567L,6575L,28096L,121847L,534953L,2373032L,10619922L,47890013L,217395690L,992640367L,4555957948L,21007405327L,97266928685L,452046424465L,2108022305795L,9860773604035L,46256877824220L,217555982625385L,1025667805621986L,4846240583558277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276903Inst : IEnumerable<long>
{
public static readonly long[] Value=A276903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276903.Bytes);
public long this[int i]=>Value[i];

public static A276903Inst Instance=new A276903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276902
{
public static readonly long[] Value={ 0L,1L,3L,12L,56L,284L,1526L,8530L,49106L,289149L,1733347L,10542987L,64904203L,403632551L,2531971729L,16002136283L,101795589297L,651286316903L,4188174878517L,27055199929042L,175488689467350L,1142479579205721L,7462785088260791L,48896570201100002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276902Inst : IEnumerable<long>
{
public static readonly long[] Value=A276902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276902.Bytes);
public long this[int i]=>Value[i];

public static A276902Inst Instance=new A276902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276901
{
public static readonly long[] Value={ 0L,1L,2L,9L,34L,159L,730L,3579L,17762L,90538L,467796L,2452727L,12997554L,69549847L,375159290L,2038068813L,11140256754L,61227097438L,338140106124L,1875581756078L,10444142352812L,58364192607047L,327203347219250L,1839778650617309L,10372512509521074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276901Inst : IEnumerable<long>
{
public static readonly long[] Value=A276901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276901.Bytes);
public long this[int i]=>Value[i];

public static A276901Inst Instance=new A276901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276900
{
public static readonly BigInteger[] Value={ 1L,1L,3L,13L,75L,541L,4683L,47293L,545835L,7087261L,102247563L,1520385010L,23523325304L,380789137336L,6467270373536L,115360990236256L,2161133759447744L,42490485277902688L,875847933546165968L,BigInteger.Parse("18903517993567133752"),BigInteger.Parse("426618313415065361204"),BigInteger.Parse("10043227358229156346032") };
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
public class A276900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276900Inst Instance=new A276900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276883
{
public static readonly long[] Value={ 1L,2L,5L,6L,9L,10L,13L,16L,17L,20L,21L,24L,25L,28L,31L,32L,35L,36L,39L,40L,43L,46L,47L,50L,51L,54L,57L,58L,61L,62L,65L,66L,69L,72L,73L,76L,77L,80L,81L,84L,87L,88L,91L,92L,95L,96L,99L,102L,103L,106L,107L,110L,113L,114L,117L,118L,121L,122L,125L,128L,129L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276883Inst : IEnumerable<long>
{
public static readonly long[] Value=A276883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276883.Bytes);
public long this[int i]=>Value[i];

public static A276883Inst Instance=new A276883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276882
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,12L,15L,16L,19L,22L,25L,26L,29L,32L,33L,36L,39L,42L,43L,46L,49L,50L,53L,56L,57L,60L,63L,66L,67L,70L,73L,74L,77L,80L,83L,84L,87L,90L,91L,94L,97L,98L,101L,104L,107L,108L,111L,114L,115L,118L,121L,124L,125L,128L,131L,132L,135L,138L,141L,142L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276882Inst : IEnumerable<long>
{
public static readonly long[] Value=A276882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276882.Bytes);
public long this[int i]=>Value[i];

public static A276882Inst Instance=new A276882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276881
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,14L,15L,18L,21L,24L,27L,28L,31L,34L,37L,40L,41L,44L,47L,50L,53L,54L,57L,60L,63L,66L,69L,70L,73L,76L,79L,82L,83L,86L,89L,92L,95L,96L,99L,102L,105L,108L,109L,112L,115L,118L,121L,124L,125L,128L,131L,134L,137L,138L,141L,144L,147L,150L,151L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276881Inst : IEnumerable<long>
{
public static readonly long[] Value=A276881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276881.Bytes);
public long this[int i]=>Value[i];

public static A276881Inst Instance=new A276881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276880
{
public static readonly long[] Value={ 1L,4L,7L,12L,15L,18L,23L,26L,29L,34L,37L,42L,45L,48L,53L,56L,59L,64L,67L,70L,75L,78L,83L,86L,89L,94L,97L,100L,105L,108L,111L,116L,119L,124L,127L,130L,135L,138L,141L,146L,149L,154L,157L,160L,165L,168L,171L,176L,179L,182L,187L,190L,195L,198L,201L,206L,209L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276880Inst : IEnumerable<long>
{
public static readonly long[] Value=A276880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276880.Bytes);
public long this[int i]=>Value[i];

public static A276880Inst Instance=new A276880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276879
{
public static readonly long[] Value={ 1L,6L,11L,18L,23L,30L,35L,40L,47L,52L,59L,64L,69L,76L,81L,88L,93L,100L,105L,110L,117L,122L,129L,134L,139L,146L,151L,158L,163L,170L,175L,180L,187L,192L,199L,204L,209L,216L,221L,228L,233L,238L,245L,250L,257L,262L,269L,274L,279L,286L,291L,298L,303L,308L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276879Inst : IEnumerable<long>
{
public static readonly long[] Value=A276879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276879.Bytes);
public long this[int i]=>Value[i];

public static A276879Inst Instance=new A276879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276878
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,10L,11L,14L,15L,16L,17L,20L,21L,22L,23L,24L,27L,28L,29L,30L,33L,34L,35L,36L,39L,40L,41L,42L,45L,46L,47L,48L,49L,52L,53L,54L,55L,58L,59L,60L,61L,64L,65L,66L,67L,68L,71L,72L,73L,74L,77L,78L,79L,80L,83L,84L,85L,86L,89L,90L,91L,92L,93L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276878Inst : IEnumerable<long>
{
public static readonly long[] Value=A276878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276878.Bytes);
public long this[int i]=>Value[i];

public static A276878Inst Instance=new A276878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276877
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,14L,17L,20L,23L,24L,27L,30L,33L,36L,39L,42L,45L,46L,49L,52L,55L,58L,61L,64L,67L,68L,71L,74L,77L,80L,83L,86L,89L,90L,93L,96L,99L,102L,105L,108L,111L,112L,115L,118L,121L,124L,127L,130L,133L,134L,137L,140L,143L,146L,149L,152L,155L,156L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276877Inst : IEnumerable<long>
{
public static readonly long[] Value=A276877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276877.Bytes);
public long this[int i]=>Value[i];

public static A276877Inst Instance=new A276877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276876
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,9L,12L,13L,14L,15L,18L,19L,20L,23L,24L,25L,26L,29L,30L,31L,34L,35L,36L,37L,40L,41L,42L,45L,46L,47L,50L,51L,52L,53L,56L,57L,58L,61L,62L,63L,64L,67L,68L,69L,72L,73L,74L,75L,78L,79L,80L,83L,84L,85L,88L,89L,90L,91L,94L,95L,96L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276876Inst : IEnumerable<long>
{
public static readonly long[] Value=A276876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276876.Bytes);
public long this[int i]=>Value[i];

public static A276876Inst Instance=new A276876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276875
{
public static readonly long[] Value={ 1L,4L,7L,12L,15L,18L,23L,26L,31L,34L,37L,42L,45L,50L,53L,56L,61L,64L,69L,72L,75L,80L,83L,88L,91L,94L,99L,102L,105L,110L,113L,118L,121L,124L,129L,132L,137L,140L,143L,148L,151L,156L,159L,162L,167L,170L,175L,178L,181L,186L,189L,194L,197L,200L,205L,208L,211L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276875Inst : IEnumerable<long>
{
public static readonly long[] Value=A276875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276875.Bytes);
public long this[int i]=>Value[i];

public static A276875Inst Instance=new A276875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276874
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,18L,21L,24L,27L,30L,35L,38L,41L,44L,47L,52L,55L,58L,61L,64L,69L,72L,75L,78L,81L,86L,89L,92L,95L,100L,103L,106L,109L,112L,117L,120L,123L,126L,129L,134L,137L,140L,143L,146L,151L,154L,157L,160L,163L,168L,171L,174L,177L,180L,185L,188L,191L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276874Inst : IEnumerable<long>
{
public static readonly long[] Value=A276874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276874.Bytes);
public long this[int i]=>Value[i];

public static A276874Inst Instance=new A276874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276873
{
public static readonly long[] Value={ 1L,4L,9L,12L,17L,20L,25L,28L,33L,36L,41L,46L,49L,54L,57L,62L,65L,70L,73L,78L,81L,86L,91L,94L,99L,102L,107L,110L,115L,118L,123L,128L,131L,136L,139L,144L,147L,152L,155L,160L,163L,168L,173L,176L,181L,184L,189L,192L,197L,200L,205L,208L,213L,218L,221L,226L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276873Inst : IEnumerable<long>
{
public static readonly long[] Value=A276873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276873.Bytes);
public long this[int i]=>Value[i];

public static A276873Inst Instance=new A276873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276872
{
public static readonly long[] Value={ 1L,6L,11L,16L,21L,28L,33L,38L,43L,50L,55L,60L,65L,70L,77L,82L,87L,92L,99L,104L,109L,114L,119L,126L,131L,136L,141L,148L,153L,158L,163L,168L,175L,180L,185L,190L,197L,202L,207L,212L,217L,224L,229L,234L,239L,246L,251L,256L,261L,268L,273L,278L,283L,288L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276872Inst : IEnumerable<long>
{
public static readonly long[] Value=A276872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276872.Bytes);
public long this[int i]=>Value[i];

public static A276872Inst Instance=new A276872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276871
{
public static readonly long[] Value={ 1L,10L,19L,28L,37L,48L,57L,66L,75L,86L,95L,104L,113L,124L,133L,142L,151L,162L,171L,180L,189L,198L,209L,218L,227L,236L,247L,256L,265L,274L,285L,294L,303L,312L,323L,332L,341L,350L,359L,370L,379L,388L,397L,408L,417L,426L,435L,446L,455L,464L,473L,484L,493L,502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276871Inst : IEnumerable<long>
{
public static readonly long[] Value=A276871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276871.Bytes);
public long this[int i]=>Value[i];

public static A276871Inst Instance=new A276871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276870
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L,3L,3L,3L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276870Inst : IEnumerable<long>
{
public static readonly long[] Value=A276870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276870.Bytes);
public long this[int i]=>Value[i];

public static A276870Inst Instance=new A276870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276869
{
public static readonly long[] Value={ 2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276869Inst : IEnumerable<long>
{
public static readonly long[] Value=A276869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276869.Bytes);
public long this[int i]=>Value[i];

public static A276869Inst Instance=new A276869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276868
{
public static readonly long[] Value={ 4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,4L,5L,5L,4L,5L,5L,4L,5L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276868Inst : IEnumerable<long>
{
public static readonly long[] Value=A276868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276868.Bytes);
public long this[int i]=>Value[i];

public static A276868Inst Instance=new A276868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276867
{
public static readonly long[] Value={ 3L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,3L,4L,4L,3L,4L,4L,3L,4L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276867Inst : IEnumerable<long>
{
public static readonly long[] Value=A276867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276867.Bytes);
public long this[int i]=>Value[i];

public static A276867Inst Instance=new A276867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276866
{
public static readonly long[] Value={ 4L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L,4L,4L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276866Inst : IEnumerable<long>
{
public static readonly long[] Value=A276866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276866.Bytes);
public long this[int i]=>Value[i];

public static A276866Inst Instance=new A276866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276865
{
public static readonly long[] Value={ 3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,4L,3L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276865Inst : IEnumerable<long>
{
public static readonly long[] Value=A276865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276865.Bytes);
public long this[int i]=>Value[i];

public static A276865Inst Instance=new A276865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276864
{
public static readonly long[] Value={ 3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L,3L,4L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276864Inst : IEnumerable<long>
{
public static readonly long[] Value=A276864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276864.Bytes);
public long this[int i]=>Value[i];

public static A276864Inst Instance=new A276864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276863
{
public static readonly long[] Value={ 3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L,3L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276863Inst : IEnumerable<long>
{
public static readonly long[] Value=A276863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276863.Bytes);
public long this[int i]=>Value[i];

public static A276863Inst Instance=new A276863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276862
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276862Inst : IEnumerable<long>
{
public static readonly long[] Value=A276862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276862.Bytes);
public long this[int i]=>Value[i];

public static A276862Inst Instance=new A276862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276861
{
public static readonly long[] Value={ 6L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L,6L,6L,7L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276861Inst : IEnumerable<long>
{
public static readonly long[] Value=A276861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276861.Bytes);
public long this[int i]=>Value[i];

public static A276861Inst Instance=new A276861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276860
{
public static readonly long[] Value={ 5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L,6L,5L,5L,6L,5L,6L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276860Inst : IEnumerable<long>
{
public static readonly long[] Value=A276860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276860.Bytes);
public long this[int i]=>Value[i];

public static A276860Inst Instance=new A276860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276859
{
public static readonly long[] Value={ 2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276859Inst : IEnumerable<long>
{
public static readonly long[] Value=A276859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276859.Bytes);
public long this[int i]=>Value[i];

public static A276859Inst Instance=new A276859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276858
{
public static readonly long[] Value={ 2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276858Inst : IEnumerable<long>
{
public static readonly long[] Value=A276858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276858.Bytes);
public long this[int i]=>Value[i];

public static A276858Inst Instance=new A276858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276857
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276857Inst : IEnumerable<long>
{
public static readonly long[] Value=A276857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276857.Bytes);
public long this[int i]=>Value[i];

public static A276857Inst Instance=new A276857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276856
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L,3L,2L,2L,3L,2L,3L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276856Inst : IEnumerable<long>
{
public static readonly long[] Value=A276856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276856.Bytes);
public long this[int i]=>Value[i];

public static A276856Inst Instance=new A276856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276855
{
public static readonly long[] Value={ 0L,4L,9L,13L,18L,23L,27L,32L,36L,41L,46L,50L,55L,60L,64L,69L,73L,78L,83L,87L,92L,96L,101L,106L,110L,115L,120L,124L,129L,133L,138L,143L,147L,152L,157L,161L,166L,170L,175L,180L,184L,189L,193L,198L,203L,207L,212L,217L,221L,226L,230L,235L,240L,244L,249L,253L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276855Inst : IEnumerable<long>
{
public static readonly long[] Value=A276855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276855.Bytes);
public long this[int i]=>Value[i];

public static A276855Inst Instance=new A276855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276854
{
public static readonly long[] Value={ 0L,3L,6L,9L,12L,16L,19L,22L,25L,29L,32L,35L,38L,42L,45L,48L,51L,55L,58L,61L,64L,67L,71L,74L,77L,80L,84L,87L,90L,93L,97L,100L,103L,106L,110L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,161L,165L,168L,171L,174L,177L,181L,184L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276854Inst : IEnumerable<long>
{
public static readonly long[] Value=A276854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276854.Bytes);
public long this[int i]=>Value[i];

public static A276854Inst Instance=new A276854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276853
{
public static readonly long[] Value={ 0L,5L,10L,16L,21L,27L,32L,38L,43L,48L,54L,59L,65L,70L,76L,81L,86L,92L,97L,103L,108L,114L,119L,125L,130L,135L,141L,146L,152L,157L,163L,168L,173L,179L,184L,190L,195L,201L,206L,212L,217L,222L,228L,233L,239L,244L,250L,255L,260L,266L,271L,277L,282L,288L,293L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276853Inst : IEnumerable<long>
{
public static readonly long[] Value=A276853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276853.Bytes);
public long this[int i]=>Value[i];

public static A276853Inst Instance=new A276853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276852
{
public static readonly long[] Value={ 0L,1L,2L,7L,28L,121L,560L,2677L,13230L,66742L,343092L,1788681L,9439870L,50321865L,270594896L,1465941763L,7993664588L,43839212778L,241650560756L,1338084935826L,7439615051328L,41516113036777L,232452845782308L,1305500166481715L,7352433083806020L,41514430735834714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276852Inst : IEnumerable<long>
{
public static readonly long[] Value=A276852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276852.Bytes);
public long this[int i]=>Value[i];

public static A276852Inst Instance=new A276852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276723
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,877L,3263L,11155L,36810L,120635L,398736L,1340561L,4605989L,15908448L,54826671L,188085307L,642431001L,2188102307L,7446095610L,25366540627L,86531467800L,295449388797L,1009134603216L,3446558809107L,11767813404774L,40167156826109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276723Inst : IEnumerable<long>
{
public static readonly long[] Value=A276723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276723.Bytes);
public long this[int i]=>Value[i];

public static A276723Inst Instance=new A276723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276722
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,203L,674L,2066L,6184L,18587L,56867L,178317L,561319L,1760125L,5489888L,17057701L,52931331L,164466672L,511758485L,1593612234L,4962950389L,15451453190L,48088784307L,149640967002L,465653853729L,1449146745582L,4510183339086L,14037494547193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276722Inst : IEnumerable<long>
{
public static readonly long[] Value=A276722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276722.Bytes);
public long this[int i]=>Value[i];

public static A276722Inst Instance=new A276722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276721
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,52L,151L,409L,1100L,3012L,8487L,23949L,67179L,187431L,521889L,1455667L,4066220L,11363476L,31747666L,88659265L,247559056L,691294366L,1930595096L,5391864630L,15058449487L,42054270461L,117445036871L,327989716409L,915985822220L,2558107420307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276721Inst : IEnumerable<long>
{
public static readonly long[] Value=A276721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276721.Bytes);
public long this[int i]=>Value[i];

public static A276721Inst Instance=new A276721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276720
{
public static readonly long[] Value={ 1L,1L,2L,5L,15L,37L,87L,208L,515L,1271L,3112L,7594L,18578L,45510L,111464L,272839L,667809L,1634784L,4002217L,9797781L,23985131L,58715973L,143739040L,351879841L,861416293L,2108779100L,5162371032L,12637686756L,30937555540L,75736343956L,185405513889L,453879917561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276720Inst : IEnumerable<long>
{
public static readonly long[] Value=A276720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276720.Bytes);
public long this[int i]=>Value[i];

public static A276720Inst Instance=new A276720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276719
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,1L,0L,1L,1L,2L,3L,1L,0L,1L,1L,2L,5L,5L,1L,0L,1L,1L,2L,5L,10L,8L,1L,0L,1L,1L,2L,5L,15L,20L,13L,1L,0L,1L,1L,2L,5L,15L,37L,42L,21L,1L,0L,1L,1L,2L,5L,15L,52L,87L,87L,34L,1L,0L,1L,1L,2L,5L,15L,52L,151L,208L,179L,55L,1L,0L,1L,1L,2L,5L,15L,52L,203L,409L,515L,370L,89L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276719Inst : IEnumerable<long>
{
public static readonly long[] Value=A276719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276719.Bytes);
public long this[int i]=>Value[i];

public static A276719Inst Instance=new A276719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276718
{
public static readonly long[] Value={ 4L,52655L,57343L,443749L,526559L,573439L,656249L,2515624L,4437499L,5265599L,5734399L,6562499L,8484374L,44374999L,52655999L,57343999L,65624999L,401953124L,443749999L,526559999L,573439999L,656249999L,698046874L,4437499999L,5265599999L,5734399999L,6562499999L,44374999999L,52655999999L,57343999999L,65624999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276718Inst : IEnumerable<long>
{
public static readonly long[] Value=A276718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276718.Bytes);
public long this[int i]=>Value[i];

public static A276718Inst Instance=new A276718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276717
{
public static readonly long[] Value={ 1L,1L,5L,7L,17L,11L,13L,37L,17L,19L,89L,19L,41L,71L,29L,13L,73L,199L,37L,157L,41L,43L,17L,47L,113L,433L,53L,541L,809L,59L,61L,997L,89L,67L,1009L,71L,73L,113L,521L,79L,1553L,83L,1721L,1693L,89L,1873L,1697L,107L,97L,313L,101L,103L,761L,107L,109L,11L,113L,239L,1433L,2269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276717Inst : IEnumerable<long>
{
public static readonly long[] Value=A276717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276717.Bytes);
public long this[int i]=>Value[i];

public static A276717Inst Instance=new A276717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276716
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,2L,2L,6L,8L,10L,12L,14L,16L,18L,20L,4L,6L,4L,10L,12L,14L,16L,18L,20L,22L,6L,8L,10L,6L,14L,16L,18L,20L,22L,24L,8L,10L,12L,14L,8L,18L,20L,22L,24L,26L,10L,12L,14L,16L,18L,10L,22L,24L,26L,28L,12L,14L,16L,18L,20L,22L,12L,26L,28L,30L,14L,16L,18L,20L,22L,24L,26L,14L,30L,32L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276716Inst : IEnumerable<long>
{
public static readonly long[] Value=A276716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276716.Bytes);
public long this[int i]=>Value[i];

public static A276716Inst Instance=new A276716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276715
{
public static readonly long[] Value={ 1L,14L,33L,42677635L,51L,46L,155L,62L,69L,46L,174L,154L,285L,182L,141L,62L,138L,142L,235L,158L,123L,94L,213L,322L,295L,94L,177L,118L,159L,406L,376L,266L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276715Inst : IEnumerable<long>
{
public static readonly long[] Value=A276715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276715.Bytes);
public long this[int i]=>Value[i];

public static A276715Inst Instance=new A276715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276714
{
public static readonly long[] Value={ 42677635L,276742235L,6439057062L,7512673242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276714Inst : IEnumerable<long>
{
public static readonly long[] Value=A276714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276714.Bytes);
public long this[int i]=>Value[i];

public static A276714Inst Instance=new A276714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276713
{
public static readonly long[] Value={ 2L,35L,55L,62L,74L,82L,91L,102L,115L,119L,122L,135L,142L,143L,155L,158L,172L,186L,202L,203L,206L,214L,215L,218L,242L,255L,259L,262L,282L,295L,298L,299L,302L,323L,326L,343L,351L,354L,355L,362L,391L,395L,399L,425L,426L,435L,451L,466L,478L,482L,492L,502L,511L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276713Inst : IEnumerable<long>
{
public static readonly long[] Value=A276713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276713.Bytes);
public long this[int i]=>Value[i];

public static A276713Inst Instance=new A276713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276712
{
public static readonly long[] Value={ 1L,5L,0L,2L,5L,7L,1L,1L,2L,8L,9L,4L,9L,4L,9L,2L,8L,5L,6L,7L,4L,9L,6L,7L,2L,7L,0L,1L,8L,8L,9L,3L,1L,2L,4L,8L,8L,4L,5L,6L,2L,3L,2L,8L,6L,5L,4L,2L,5L,6L,2L,3L,6L,0L,2L,2L,4L,0L,3L,3L,9L,4L,4L,4L,1L,7L,7L,2L,9L,7L,7L,5L,7L,2L,3L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276712Inst : IEnumerable<long>
{
public static readonly long[] Value=A276712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276712.Bytes);
public long this[int i]=>Value[i];

public static A276712Inst Instance=new A276712Inst();

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