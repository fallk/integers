using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A007993
{
public static readonly long[] Value={ 3L,12L,40L,102L,219L,419L,738L,1221L,1923L,2910L,4260L,6064L,8427L,11469L,15326L,20151L,26115L,33408L,42240L,52842L,65467L,80391L,97914L,118361L,142083L,169458L,200892L,236820L,277707L,324049L,376374L,435243L,501251L,575028L,657240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007993Inst : IEnumerable<long>
{
public static readonly long[] Value=A007993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007993.Bytes);
public long this[int i]=>Value[i];

public static A007993Inst Instance=new A007993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007994
{
public static readonly long[] Value={ 4L,22L,110L,453L,1482L,4083L,9926L,21959L,45122L,87347L,160922L,284310L,484528L,800206L,1285462L,2014746L,3088824L,4642092L,6851430L,9946827L,14224030L,20059493L,27927926L,38422769L,52279942L,70405249L,93905842L,124126180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007994Inst : IEnumerable<long>
{
public static readonly long[] Value=A007994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007994.Bytes);
public long this[int i]=>Value[i];

public static A007994Inst Instance=new A007994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007995
{
public static readonly long[] Value={ 5L,35L,235L,1380L,6711L,26630L,89695L,266305L,716460L,1780978L,4147915L,9144485L,19231895L,38819255L,75566971L,142424625L,260749275L,464984685L,809559075L,1378889190L,2301674475L,3771041860L,6072576655L,9622868805L,15021940010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007995Inst : IEnumerable<long>
{
public static readonly long[] Value=A007995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007995.Bytes);
public long this[int i]=>Value[i];

public static A007995Inst Instance=new A007995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007996
{
public static readonly long[] Value={ 2L,3L,7L,13L,43L,73L,139L,181L,547L,607L,1033L,1171L,1459L,1861L,1987L,2029L,2287L,2437L,4219L,4519L,6469L,7603L,8221L,9829L,12763L,13147L,13291L,13999L,15373L,17881L,17977L,19597L,20161L,20479L,20641L,20857L,20929L,21661L,23689L,23773L,27031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007996Inst : IEnumerable<long>
{
public static readonly long[] Value=A007996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007996.Bytes);
public long this[int i]=>Value[i];

public static A007996Inst Instance=new A007996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007997
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,4L,5L,7L,10L,12L,15L,19L,22L,26L,31L,35L,40L,46L,51L,57L,64L,70L,77L,85L,92L,100L,109L,117L,126L,136L,145L,155L,166L,176L,187L,199L,210L,222L,235L,247L,260L,274L,287L,301L,316L,330L,345L,361L,376L,392L,409L,425L,442L,460L,477L,495L,514L,532L,551L,571L,590L,610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007997Inst : IEnumerable<long>
{
public static readonly long[] Value=A007997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007997.Bytes);
public long this[int i]=>Value[i];

public static A007997Inst Instance=new A007997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007998
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,7L,8L,9L,9L,15L,11L,17L,17L,18L,18L,31L,21L,33L,30L,33L,30L,53L,34L,48L,46L,53L,43L,87L,47L,73L,69L,79L,66L,110L,65L,100L,94L,111L,80L,159L,86L,135L,130L,135L,108L,202L,116L,181L,153L,175L,133L,255L,150L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007998Inst : IEnumerable<long>
{
public static readonly long[] Value=A007998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007998.Bytes);
public long this[int i]=>Value[i];

public static A007998Inst Instance=new A007998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007999
{
public static readonly long[] Value={ 1L,1L,2L,3L,8L,19L,64L,213L,880L,3717L,18288L,92935L,531440L,3147495L,20525168L,138638825L,1015694832L,7700244745L,62623847536L,526317901451L,4705365925872L,43407723925499L,423149546210416L,4250149857500861L,44868038386273776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A007999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007999Inst : IEnumerable<long>
{
public static readonly long[] Value=A007999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A007999.Bytes);
public long this[int i]=>Value[i];

public static A007999Inst Instance=new A007999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008000
{
public static readonly long[] Value={ 1L,4L,10L,21L,36L,54L,78L,106L,136L,173L,214L,256L,306L,360L,414L,477L,544L,610L,686L,766L,844L,933L,1026L,1116L,1218L,1324L,1426L,1541L,1660L,1774L,1902L,2034L,2160L,2301L,2446L,2584L,2738L,2896L,3046L,3213L,3384L,3546L,3726L,3910L,4084L,4277L,4474L,4660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008000Inst : IEnumerable<long>
{
public static readonly long[] Value=A008000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008000.Bytes);
public long this[int i]=>Value[i];

public static A008000Inst Instance=new A008000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008001
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,85L,111L,143L,177L,213L,253L,297L,345L,396L,449L,506L,568L,633L,702L,774L,847L,925L,1008L,1094L,1184L,1276L,1371L,1472L,1577L,1684L,1793L,1906L,2024L,2145L,2269L,2396L,2526L,2660L,2798L,2941L,3088L,3236L,3387L,3544L,3704L,3866L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008001Inst : IEnumerable<long>
{
public static readonly long[] Value=A008001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008001.Bytes);
public long this[int i]=>Value[i];

public static A008001Inst Instance=new A008001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008002
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,88L,113L,143L,178L,214L,253L,297L,345L,395L,448L,508L,570L,632L,700L,774L,851L,927L,1007L,1096L,1185L,1275L,1372L,1474L,1577L,1681L,1793L,1910L,2025L,2142L,2267L,2398L,2528L,2660L,2800L,2944L,3088L,3235L,3389L,3546L,3703L,3864L,4031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008002Inst : IEnumerable<long>
{
public static readonly long[] Value=A008002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008002.Bytes);
public long this[int i]=>Value[i];

public static A008002Inst Instance=new A008002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008003
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,87L,113L,143L,176L,214L,253L,297L,345L,395L,451L,507L,568L,634L,700L,772L,848L,928L,1010L,1093L,1184L,1278L,1373L,1472L,1575L,1684L,1793L,1905L,2025L,2146L,2268L,2394L,2528L,2665L,2800L,2940L,3086L,3237L,3388L,3542L,3704L,3867L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008003Inst : IEnumerable<long>
{
public static readonly long[] Value=A008003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008003.Bytes);
public long this[int i]=>Value[i];

public static A008003Inst Instance=new A008003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008004
{
public static readonly long[] Value={ 1L,4L,11L,21L,37L,59L,85L,114L,150L,189L,232L,279L,331L,390L,455L,519L,589L,667L,748L,831L,921L,1015L,1115L,1220L,1327L,1439L,1560L,1679L,1802L,1936L,2073L,2213L,2361L,2507L,2659L,2820L,2982L,3150L,3327L,3501L,3681L,3871L,4061L,4254L,4458L,4661L,4868L,5085L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008004Inst : IEnumerable<long>
{
public static readonly long[] Value=A008004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008004.Bytes);
public long this[int i]=>Value[i];

public static A008004Inst Instance=new A008004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008005
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,58L,85L,115L,148L,188L,234L,280L,333L,390L,450L,519L,593L,666L,748L,833L,919L,1016L,1118L,1217L,1327L,1441L,1554L,1679L,1810L,1936L,2073L,2213L,2352L,2507L,2667L,2819L,2984L,3153L,3319L,3501L,3688L,3867L,4061L,4258L,4450L,4661L,4878L,5083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008005Inst : IEnumerable<long>
{
public static readonly long[] Value=A008005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008005.Bytes);
public long this[int i]=>Value[i];

public static A008005Inst Instance=new A008005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008006
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,59L,84L,115L,150L,186L,230L,282L,336L,390L,452L,520L,592L,667L,746L,833L,928L,1018L,1112L,1218L,1328L,1440L,1558L,1678L,1806L,1939L,2072L,2211L,2360L,2508L,2660L,2822L,2986L,3152L,3328L,3502L,3680L,3869L,4060L,4257L,4462L,4660L,4866L,5086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008006Inst : IEnumerable<long>
{
public static readonly long[] Value=A008006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008006.Bytes);
public long this[int i]=>Value[i];

public static A008006Inst Instance=new A008006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008007
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,53L,78L,108L,140L,172L,208L,250L,302L,359L,417L,473L,531L,598L,677L,764L,852L,934L,1016L,1103L,1203L,1311L,1421L,1529L,1638L,1755L,1883L,2019L,2155L,2286L,2421L,2564L,2719L,2876L,3030L,3180L,3335L,3507L,3694L,3886L,4071L,4246L,4425L,4617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008007Inst : IEnumerable<long>
{
public static readonly long[] Value=A008007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008007.Bytes);
public long this[int i]=>Value[i];

public static A008007Inst Instance=new A008007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008008
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,52L,74L,102L,136L,172L,212L,257L,307L,358L,412L,470L,535L,606L,683L,762L,840L,918L,1006L,1106L,1214L,1321L,1423L,1523L,1631L,1753L,1889L,2027L,2159L,2283L,2411L,2553L,2712L,2876L,3034L,3187L,3343L,3511L,3695L,3885L,4071L,4246L,4425L,4617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008008Inst : IEnumerable<long>
{
public static readonly long[] Value=A008008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008008.Bytes);
public long this[int i]=>Value[i];

public static A008008Inst Instance=new A008008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008009
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,55L,74L,98L,132L,173L,216L,260L,306L,353L,408L,473L,547L,617L,681L,748L,827L,918L,1016L,1115L,1214L,1313L,1415L,1526L,1650L,1772L,1889L,2007L,2139L,2281L,2421L,2563L,2711L,2864L,3024L,3193L,3371L,3538L,3693L,3855L,4042L,4244L,4443L,4634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008009Inst : IEnumerable<long>
{
public static readonly long[] Value=A008009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008009.Bytes);
public long this[int i]=>Value[i];

public static A008009Inst Instance=new A008009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008010
{
public static readonly long[] Value={ 1L,4L,12L,23L,36L,52L,75L,103L,135L,172L,215L,258L,303L,354L,413L,475L,539L,607L,682L,758L,837L,922L,1014L,1111L,1210L,1311L,1420L,1531L,1642L,1758L,1885L,2017L,2148L,2281L,2424L,2569L,2713L,2864L,3027L,3192L,3353L,3518L,3696L,3876L,4055L,4239L,4433L,4630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008010Inst : IEnumerable<long>
{
public static readonly long[] Value=A008010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008010.Bytes);
public long this[int i]=>Value[i];

public static A008010Inst Instance=new A008010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008011
{
public static readonly long[] Value={ 1L,4L,10L,18L,32L,52L,76L,105L,140L,171L,202L,244L,300L,361L,420L,472L,526L,591L,670L,763L,858L,939L,1014L,1096L,1198L,1311L,1422L,1526L,1632L,1751L,1880L,2017L,2158L,2289L,2416L,2556L,2720L,2885L,3034L,3172L,3322L,3497L,3688L,3889L,4082L,4251L,4416L,4604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008011Inst : IEnumerable<long>
{
public static readonly long[] Value=A008011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008011.Bytes);
public long this[int i]=>Value[i];

public static A008011Inst Instance=new A008011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008012
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,53L,76L,103L,135L,170L,208L,250L,299L,355L,412L,469L,530L,600L,678L,756L,834L,916L,1006L,1104L,1202L,1301L,1404L,1515L,1635L,1754L,1872L,1994L,2127L,2271L,2412L,2549L,2690L,2844L,3010L,3172L,3330L,3492L,3666L,3852L,4034L,4213L,4396L,4591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008012Inst : IEnumerable<long>
{
public static readonly long[] Value=A008012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008012.Bytes);
public long this[int i]=>Value[i];

public static A008012Inst Instance=new A008012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008013
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,54L,78L,104L,134L,168L,210L,256L,302L,352L,406L,470L,538L,604L,674L,748L,834L,924L,1010L,1100L,1194L,1302L,1414L,1520L,1630L,1744L,1874L,2008L,2134L,2264L,2398L,2550L,2706L,2852L,3002L,3156L,3330L,3508L,3674L,3844L,4018L,4214L,4414L,4600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008013Inst : IEnumerable<long>
{
public static readonly long[] Value=A008013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008013.Bytes);
public long this[int i]=>Value[i];

public static A008013Inst Instance=new A008013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008030
{
public static readonly long[] Value={ 1L,4L,9L,16L,23L,34L,57L,82L,98L,115L,141L,178L,224L,259L,282L,322L,377L,430L,486L,535L,578L,643L,717L,781L,851L,919L,984L,1072L,1160L,1231L,1320L,1417L,1502L,1600L,1698L,1789L,1907L,2023L,2115L,2227L,2348L,2461L,2598L,2728L,2831L,2962L,3108L,3241L,3392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008030Inst : IEnumerable<long>
{
public static readonly long[] Value=A008030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008030.Bytes);
public long this[int i]=>Value[i];

public static A008030Inst Instance=new A008030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008031
{
public static readonly long[] Value={ 1L,4L,10L,22L,39L,60L,87L,118L,154L,196L,242L,292L,345L,406L,471L,540L,616L,694L,780L,868L,959L,1060L,1161L,1270L,1384L,1500L,1626L,1750L,1881L,2020L,2159L,2308L,2458L,2614L,2778L,2940L,3111L,3286L,3465L,3652L,3840L,4036L,4236L,4438L,4647L,4860L,5079L,5302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008031Inst : IEnumerable<long>
{
public static readonly long[] Value=A008031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008031.Bytes);
public long this[int i]=>Value[i];

public static A008031Inst Instance=new A008031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008032
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,53L,75L,102L,132L,168L,208L,250L,298L,351L,407L,469L,534L,601L,675L,752L,832L,919L,1009L,1103L,1203L,1305L,1410L,1520L,1634L,1753L,1878L,2007L,2138L,2274L,2414L,2556L,2704L,2856L,3012L,3176L,3343L,3511L,3684L,3860L,4040L,4227L,4417L,4611L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008032Inst : IEnumerable<long>
{
public static readonly long[] Value=A008032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008032.Bytes);
public long this[int i]=>Value[i];

public static A008032Inst Instance=new A008032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008033
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,54L,76L,104L,136L,171L,211L,254L,302L,355L,411L,471L,536L,606L,679L,756L,837L,922L,1013L,1107L,1204L,1307L,1414L,1525L,1640L,1758L,1881L,2009L,2141L,2276L,2416L,2561L,2709L,2862L,3018L,3178L,3344L,3513L,3686L,3864L,4046L,4232L,4422L,4616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008033Inst : IEnumerable<long>
{
public static readonly long[] Value=A008033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008033.Bytes);
public long this[int i]=>Value[i];

public static A008033Inst Instance=new A008033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008034
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,57L,82L,112L,145L,184L,228L,275L,328L,385L,446L,512L,583L,658L,738L,823L,911L,1004L,1102L,1203L,1310L,1424L,1539L,1661L,1788L,1914L,2049L,2188L,2329L,2480L,2633L,2789L,2953L,3117L,3287L,3464L,3642L,3828L,4018L,4210L,4409L,4610L,4817L,5030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008034Inst : IEnumerable<long>
{
public static readonly long[] Value=A008034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008034.Bytes);
public long this[int i]=>Value[i];

public static A008034Inst Instance=new A008034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008035
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,59L,83L,113L,147L,186L,230L,278L,330L,386L,448L,513L,585L,660L,739L,824L,912L,1006L,1104L,1207L,1313L,1425L,1541L,1661L,1787L,1916L,2051L,2190L,2334L,2482L,2634L,2791L,2952L,3119L,3290L,3465L,3645L,3829L,4018L,4212L,4411L,4613L,4820L,5032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008035Inst : IEnumerable<long>
{
public static readonly long[] Value=A008035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008035.Bytes);
public long this[int i]=>Value[i];

public static A008035Inst Instance=new A008035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008036
{
public static readonly long[] Value={ 1L,4L,9L,19L,34L,48L,66L,96L,127L,151L,183L,232L,281L,316L,357L,427L,499L,540L,588L,684L,778L,823L,879L,1000L,1118L,1168L,1227L,1375L,1522L,1572L,1632L,1812L,1987L,2035L,2097L,2308L,2513L,2560L,2619L,2863L,3103L,3144L,3198L,3480L,3754L,3787L,3837L,4156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008036Inst : IEnumerable<long>
{
public static readonly long[] Value=A008036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008036.Bytes);
public long this[int i]=>Value[i];

public static A008036Inst Instance=new A008036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008037
{
public static readonly long[] Value={ 1L,4L,12L,18L,28L,52L,78L,88L,112L,162L,204L,220L,254L,328L,396L,414L,448L,556L,654L,664L,700L,846L,972L,976L,1010L,1192L,1356L,1350L,1372L,1600L,1806L,1780L,1792L,2070L,2316L,2272L,2270L,2596L,2892L,2826L,2800L,3184L,3534L,3436L,3388L,3834L,4236L,4108L,4034L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008037Inst : IEnumerable<long>
{
public static readonly long[] Value=A008037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008037.Bytes);
public long this[int i]=>Value[i];

public static A008037Inst Instance=new A008037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008038
{
public static readonly long[] Value={ 1L,4L,10L,19L,30L,46L,67L,93L,124L,154L,189L,232L,277L,325L,374L,428L,490L,557L,625L,690L,763L,844L,930L,1021L,1105L,1194L,1294L,1399L,1510L,1616L,1724L,1840L,1964L,2095L,2220L,2350L,2485L,2625L,2776L,2920L,3069L,3226L,3385L,3553L,3716L,3884L,4060L,4241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008038Inst : IEnumerable<long>
{
public static readonly long[] Value=A008038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008038.Bytes);
public long this[int i]=>Value[i];

public static A008038Inst Instance=new A008038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008039
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,49L,73L,97L,124L,157L,193L,236L,281L,325L,376L,434L,496L,559L,623L,692L,769L,853L,934L,1015L,1105L,1201L,1304L,1406L,1504L,1612L,1730L,1852L,1972L,2090L,2216L,2353L,2497L,2635L,2770L,2917L,3073L,3236L,3395L,3547L,3712L,3890L,4072L,4249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008039Inst : IEnumerable<long>
{
public static readonly long[] Value=A008039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008039.Bytes);
public long this[int i]=>Value[i];

public static A008039Inst Instance=new A008039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008040
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,51L,72L,96L,124L,155L,196L,238L,278L,324L,374L,436L,500L,558L,620L,688L,772L,857L,934L,1014L,1098L,1203L,1310L,1405L,1504L,1606L,1730L,1858L,1972L,2089L,2210L,2355L,2502L,2634L,2770L,2909L,3076L,3244L,3392L,3546L,3704L,3892L,4082L,4248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008040Inst : IEnumerable<long>
{
public static readonly long[] Value=A008040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008040.Bytes);
public long this[int i]=>Value[i];

public static A008040Inst Instance=new A008040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008041
{
public static readonly long[] Value={ 1L,4L,9L,18L,33L,52L,73L,96L,123L,158L,199L,239L,280L,329L,383L,438L,498L,564L,633L,704L,778L,857L,941L,1029L,1122L,1219L,1316L,1415L,1522L,1636L,1753L,1871L,1990L,2115L,2248L,2383L,2519L,2661L,2808L,2957L,3110L,3268L,3429L,3593L,3762L,3937L,4115L,4293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008041Inst : IEnumerable<long>
{
public static readonly long[] Value=A008041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008041.Bytes);
public long this[int i]=>Value[i];

public static A008041Inst Instance=new A008041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008042
{
public static readonly long[] Value={ 1L,4L,10L,21L,34L,48L,70L,100L,130L,159L,194L,236L,282L,332L,384L,439L,500L,564L,630L,702L,780L,861L,944L,1030L,1120L,1214L,1314L,1421L,1530L,1636L,1746L,1868L,1994L,2119L,2248L,2382L,2520L,2662L,2808L,2957L,3110L,3268L,3430L,3596L,3764L,3935L,4112L,4294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008042Inst : IEnumerable<long>
{
public static readonly long[] Value=A008042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008042.Bytes);
public long this[int i]=>Value[i];

public static A008042Inst Instance=new A008042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008043
{
public static readonly long[] Value={ 1L,4L,11L,22L,40L,64L,92L,121L,157L,200L,248L,297L,351L,414L,484L,555L,630L,709L,795L,885L,980L,1081L,1187L,1297L,1414L,1535L,1660L,1786L,1919L,2061L,2208L,2356L,2509L,2669L,2836L,3004L,3176L,3354L,3539L,3728L,3922L,4120L,4323L,4530L,4744L,4964L,5188L,5413L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008043Inst : IEnumerable<long>
{
public static readonly long[] Value=A008043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008043.Bytes);
public long this[int i]=>Value[i];

public static A008043Inst Instance=new A008043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008044
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,61L,88L,122L,160L,200L,246L,299L,358L,417L,480L,550L,628L,710L,796L,887L,984L,1083L,1188L,1298L,1412L,1530L,1656L,1789L,1926L,2063L,2206L,2356L,2512L,2670L,2832L,3001L,3178L,3357L,3540L,3728L,3922L,4120L,4324L,4533L,4746L,4961L,5184L,5414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008044Inst : IEnumerable<long>
{
public static readonly long[] Value=A008044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008044.Bytes);
public long this[int i]=>Value[i];

public static A008044Inst Instance=new A008044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008045
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,50L,72L,98L,128L,162L,200L,241L,285L,333L,386L,444L,506L,572L,641L,713L,789L,869L,953L,1042L,1136L,1233L,1333L,1437L,1545L,1657L,1773L,1893L,2017L,2145L,2277L,2413L,2553L,2697L,2845L,2996L,3150L,3309L,3473L,3641L,3813L,3989L,4168L,4350L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008045Inst : IEnumerable<long>
{
public static readonly long[] Value=A008045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008045.Bytes);
public long this[int i]=>Value[i];

public static A008045Inst Instance=new A008045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008046
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,50L,74L,97L,123L,158L,198L,237L,281L,336L,394L,447L,501L,566L,638L,709L,783L,868L,960L,1047L,1133L,1230L,1334L,1435L,1537L,1650L,1772L,1895L,2019L,2150L,2284L,2413L,2543L,2684L,2836L,2993L,3155L,3322L,3486L,3643L,3801L,3972L,4156L,4345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008046Inst : IEnumerable<long>
{
public static readonly long[] Value=A008046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008046.Bytes);
public long this[int i]=>Value[i];

public static A008046Inst Instance=new A008046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008047
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,71L,97L,128L,179L,226L,264L,323L,404L,467L,518L,602L,719L,800L,851L,967L,1131L,1215L,1266L,1426L,1628L,1716L,1772L,1965L,2215L,2313L,2353L,2590L,2903L,2988L,3016L,3313L,3672L,3749L,3774L,4112L,4531L,4610L,4603L,4997L,5495L,5545L,5514L,5984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008047Inst : IEnumerable<long>
{
public static readonly long[] Value=A008047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008047.Bytes);
public long this[int i]=>Value[i];

public static A008047Inst Instance=new A008047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008048
{
public static readonly long[] Value={ 1L,4L,12L,26L,42L,66L,102L,140L,164L,216L,288L,334L,372L,458L,556L,620L,668L,776L,922L,998L,1034L,1190L,1384L,1448L,1494L,1696L,1920L,1998L,2042L,2270L,2562L,2640L,2652L,2948L,3300L,3346L,3364L,3718L,4104L,4160L,4164L,4548L,5022L,5066L,5018L,5490L,6036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008048Inst : IEnumerable<long>
{
public static readonly long[] Value=A008048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008048.Bytes);
public long this[int i]=>Value[i];

public static A008048Inst Instance=new A008048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008049
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,51L,74L,101L,129L,158L,199L,242L,285L,341L,391L,441L,506L,578L,655L,711L,776L,880L,968L,1050L,1146L,1234L,1334L,1445L,1559L,1678L,1776L,1884L,2034L,2172L,2293L,2425L,2555L,2712L,2874L,3011L,3171L,3321L,3481L,3679L,3837L,4006L,4197L,4362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008049Inst : IEnumerable<long>
{
public static readonly long[] Value=A008049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008049.Bytes);
public long this[int i]=>Value[i];

public static A008049Inst Instance=new A008049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008050
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,48L,74L,104L,131L,159L,195L,245L,294L,331L,380L,447L,517L,582L,640L,710L,791L,874L,969L,1055L,1131L,1229L,1344L,1458L,1559L,1654L,1776L,1915L,2038L,2156L,2280L,2416L,2573L,2722L,2862L,3012L,3163L,3333L,3504L,3658L,3829L,4001L,4184L,4393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008050Inst : IEnumerable<long>
{
public static readonly long[] Value=A008050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008050.Bytes);
public long this[int i]=>Value[i];

public static A008050Inst Instance=new A008050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008051
{
public static readonly long[] Value={ 1L,4L,11L,19L,34L,50L,71L,98L,133L,162L,195L,241L,287L,345L,386L,442L,515L,563L,646L,728L,785L,873L,954L,1053L,1158L,1223L,1337L,1456L,1544L,1670L,1786L,1894L,2032L,2156L,2295L,2442L,2546L,2706L,2878L,3001L,3171L,3333L,3474L,3680L,3836L,4010L,4199L,4344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008051Inst : IEnumerable<long>
{
public static readonly long[] Value=A008051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008051.Bytes);
public long this[int i]=>Value[i];

public static A008051Inst Instance=new A008051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008052
{
public static readonly long[] Value={ 1L,4L,11L,21L,32L,49L,74L,101L,128L,162L,200L,243L,290L,334L,390L,445L,504L,583L,644L,708L,798L,881L,966L,1042L,1128L,1248L,1345L,1442L,1559L,1661L,1779L,1914L,2036L,2160L,2278L,2412L,2583L,2723L,2852L,3011L,3161L,3335L,3515L,3656L,3825L,4003L,4190L,4396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008052Inst : IEnumerable<long>
{
public static readonly long[] Value=A008052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008052.Bytes);
public long this[int i]=>Value[i];

public static A008052Inst Instance=new A008052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008053
{
public static readonly long[] Value={ 1L,4L,11L,20L,31L,53L,76L,97L,126L,168L,199L,235L,293L,336L,395L,447L,500L,582L,641L,717L,804L,856L,959L,1068L,1140L,1243L,1329L,1439L,1570L,1663L,1783L,1909L,2008L,2165L,2316L,2419L,2565L,2699L,2856L,3044L,3161L,3313L,3502L,3646L,3859L,4027L,4162L,4386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008053Inst : IEnumerable<long>
{
public static readonly long[] Value=A008053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008053.Bytes);
public long this[int i]=>Value[i];

public static A008053Inst Instance=new A008053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008054
{
public static readonly long[] Value={ 1L,4L,11L,18L,31L,52L,75L,100L,126L,158L,206L,247L,285L,335L,375L,450L,527L,573L,636L,703L,795L,903L,961L,1033L,1127L,1227L,1373L,1464L,1532L,1645L,1777L,1938L,2058L,2132L,2258L,2418L,2588L,2750L,2853L,2976L,3154L,3353L,3536L,3663L,3785L,3987L,4216L,4409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008054Inst : IEnumerable<long>
{
public static readonly long[] Value=A008054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008054.Bytes);
public long this[int i]=>Value[i];

public static A008054Inst Instance=new A008054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008055
{
public static readonly long[] Value={ 1L,4L,9L,17L,28L,42L,60L,84L,113L,140L,169L,211L,254L,287L,329L,386L,441L,493L,553L,622L,690L,751L,818L,904L,993L,1066L,1145L,1252L,1355L,1431L,1518L,1642L,1766L,1858L,1957L,2099L,2235L,2330L,2440L,2599L,2754L,2867L,2989L,3165L,3336L,3449L,3573L,3772L,3971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008055Inst : IEnumerable<long>
{
public static readonly long[] Value=A008055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008055.Bytes);
public long this[int i]=>Value[i];

public static A008055Inst Instance=new A008055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008056
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,39L,61L,86L,111L,141L,173L,202L,240L,293L,344L,388L,438L,493L,547L,608L,682L,763L,840L,907L,976L,1061L,1152L,1239L,1335L,1445L,1550L,1643L,1744L,1860L,1970L,2073L,2200L,2352L,2490L,2604L,2724L,2862L,3001L,3138L,3295L,3476L,3644L,3777L,3915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008056Inst : IEnumerable<long>
{
public static readonly long[] Value=A008056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008056.Bytes);
public long this[int i]=>Value[i];

public static A008056Inst Instance=new A008056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008057
{
public static readonly long[] Value={ 0L,5L,10L,16L,20L,27L,31L,35L,40L,47L,51L,56L,60L,65L,74L,78L,80L,86L,92L,96L,102L,106L,110L,120L,121L,125L,134L,137L,142L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008057Inst : IEnumerable<long>
{
public static readonly long[] Value=A008057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008057.Bytes);
public long this[int i]=>Value[i];

public static A008057Inst Instance=new A008057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008058
{
public static readonly long[] Value={ 1L,4L,10L,20L,37L,61L,83L,110L,144L,192L,238L,278L,328L,405L,464L,515L,589L,679L,751L,836L,935L,1030L,1130L,1233L,1338L,1462L,1577L,1682L,1827L,1976L,2093L,2228L,2393L,2551L,2693L,2840L,3009L,3215L,3371L,3520L,3736L,3947L,4100L,4296L,4516L,4724L,4940L,5138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008058Inst : IEnumerable<long>
{
public static readonly long[] Value=A008058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008058.Bytes);
public long this[int i]=>Value[i];

public static A008058Inst Instance=new A008058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008059
{
public static readonly long[] Value={ 1L,4L,10L,20L,36L,61L,85L,107L,147L,191L,234L,277L,339L,397L,461L,521L,588L,673L,760L,834L,925L,1039L,1133L,1222L,1345L,1464L,1569L,1687L,1828L,1970L,2100L,2230L,2387L,2554L,2692L,2833L,3021L,3203L,3370L,3533L,3727L,3940L,4125L,4283L,4504L,4746L,4927L,5120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008059Inst : IEnumerable<long>
{
public static readonly long[] Value=A008059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008059.Bytes);
public long this[int i]=>Value[i];

public static A008059Inst Instance=new A008059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008060
{
public static readonly long[] Value={ 1L,4L,11L,23L,37L,54L,82L,119L,152L,184L,233L,293L,342L,384L,448L,536L,605L,664L,751L,849L,939L,1028L,1127L,1234L,1343L,1455L,1579L,1712L,1829L,1949L,2106L,2256L,2381L,2524L,2697L,2877L,3030L,3175L,3369L,3579L,3733L,3893L,4116L,4330L,4512L,4714L,4939L,5173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008060Inst : IEnumerable<long>
{
public static readonly long[] Value=A008060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008060.Bytes);
public long this[int i]=>Value[i];

public static A008060Inst Instance=new A008060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008061
{
public static readonly long[] Value={ 1L,4L,11L,18L,37L,62L,85L,110L,147L,195L,236L,276L,332L,402L,466L,517L,588L,681L,764L,838L,927L,1034L,1130L,1229L,1346L,1465L,1573L,1694L,1830L,1976L,2101L,2224L,2389L,2560L,2697L,2836L,3027L,3213L,3370L,3532L,3728L,3941L,4126L,4290L,4510L,4753L,4936L,5130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008061Inst : IEnumerable<long>
{
public static readonly long[] Value=A008061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008061.Bytes);
public long this[int i]=>Value[i];

public static A008061Inst Instance=new A008061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008062
{
public static readonly long[] Value={ 2L,4L,7L,10L,12L,15L,18L,21L,24L,26L,29L,32L,35L,37L,40L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008062Inst : IEnumerable<long>
{
public static readonly long[] Value=A008062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008062.Bytes);
public long this[int i]=>Value[i];

public static A008062Inst Instance=new A008062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008063
{
public static readonly long[] Value={ 1L,4L,12L,23L,41L,70L,97L,125L,174L,224L,264L,318L,397L,462L,513L,594L,703L,791L,848L,952L,1113L,1201L,1255L,1406L,1595L,1698L,1762L,1938L,2178L,2285L,2335L,2553L,2847L,2954L,2998L,3269L,3610L,3705L,3743L,4056L,4446L,4555L,4576L,4929L,5402L,5480L,5469L,5904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008063Inst : IEnumerable<long>
{
public static readonly long[] Value=A008063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008063.Bytes);
public long this[int i]=>Value[i];

public static A008063Inst Instance=new A008063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008064
{
public static readonly long[] Value={ 1L,4L,12L,26L,43L,64L,101L,138L,165L,215L,284L,328L,372L,453L,546L,611L,665L,768L,907L,983L,1029L,1177L,1360L,1428L,1486L,1676L,1886L,1971L,2029L,2243L,2519L,2604L,2635L,2915L,3242L,3299L,3342L,3674L,4032L,4105L,4137L,4494L,4935L,4998L,4983L,5424L,5930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008064Inst : IEnumerable<long>
{
public static readonly long[] Value=A008064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008064.Bytes);
public long this[int i]=>Value[i];

public static A008064Inst Instance=new A008064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008065
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,72L,95L,128L,177L,225L,259L,322L,401L,460L,513L,597L,708L,790L,841L,960L,1113L,1199L,1257L,1411L,1602L,1693L,1755L,1944L,2180L,2283L,2331L,2564L,2858L,2947L,2989L,3277L,3612L,3697L,3743L,4067L,4455L,4550L,4565L,4941L,5404L,5470L,5469L,5915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008065Inst : IEnumerable<long>
{
public static readonly long[] Value=A008065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008065.Bytes);
public long this[int i]=>Value[i];

public static A008065Inst Instance=new A008065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008066
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,85L,110L,140L,173L,208L,246L,289L,336L,385L,437L,493L,553L,616L,682L,752L,825L,901L,981L,1065L,1152L,1241L,1334L,1432L,1533L,1636L,1742L,1853L,1968L,2085L,2205L,2329L,2457L,2588L,2722L,2860L,3001L,3145L,3293L,3445L,3600L,3757L,3918L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008066Inst : IEnumerable<long>
{
public static readonly long[] Value=A008066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008066.Bytes);
public long this[int i]=>Value[i];

public static A008066Inst Instance=new A008066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008067
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,65L,91L,121L,163L,208L,250L,301L,369L,433L,487L,557L,656L,745L,805L,894L,1026L,1131L,1200L,1315L,1482L,1597L,1676L,1818L,2015L,2147L,2221L,2400L,2647L,2774L,2849L,3065L,3343L,3484L,3564L,3806L,4127L,4277L,4358L,4627L,4990L,5147L,5223L,5544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008067Inst : IEnumerable<long>
{
public static readonly long[] Value=A008067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008067.Bytes);
public long this[int i]=>Value[i];

public static A008067Inst Instance=new A008067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008068
{
public static readonly long[] Value={ 1L,4L,12L,20L,37L,63L,91L,118L,164L,212L,245L,295L,369L,437L,489L,552L,656L,741L,804L,898L,1026L,1121L,1200L,1329L,1481L,1579L,1669L,1832L,2022L,2138L,2218L,2402L,2644L,2769L,2857L,3058L,3339L,3487L,3571L,3812L,4104L,4273L,4363L,4639L,5003L,5117L,5216L,5556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008068Inst : IEnumerable<long>
{
public static readonly long[] Value=A008068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008068.Bytes);
public long this[int i]=>Value[i];

public static A008068Inst Instance=new A008068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008069
{
public static readonly long[] Value={ 1L,4L,11L,24L,41L,59L,99L,130L,155L,202L,262L,315L,347L,425L,513L,576L,629L,720L,847L,917L,982L,1107L,1261L,1344L,1409L,1578L,1747L,1847L,1939L,2109L,2332L,2440L,2513L,2740L,2995L,3103L,3193L,3441L,3735L,3862L,3932L,4226L,4563L,4693L,4763L,5085L,5493L,5578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008069Inst : IEnumerable<long>
{
public static readonly long[] Value=A008069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008069.Bytes);
public long this[int i]=>Value[i];

public static A008069Inst Instance=new A008069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008070
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,63L,95L,132L,156L,199L,266L,307L,356L,420L,513L,580L,628L,719L,836L,931L,982L,1102L,1259L,1345L,1421L,1561L,1747L,1860L,1932L,2110L,2329L,2445L,2515L,2725L,3003L,3114L,3184L,3439L,3734L,3863L,3946L,4204L,4569L,4700L,4762L,5091L,5466L,5605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008070Inst : IEnumerable<long>
{
public static readonly long[] Value=A008070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008070.Bytes);
public long this[int i]=>Value[i];

public static A008070Inst Instance=new A008070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008071
{
public static readonly long[] Value={ 1L,4L,11L,23L,39L,62L,91L,124L,159L,203L,251L,311L,367L,424L,501L,570L,657L,741L,821L,910L,1013L,1132L,1234L,1342L,1463L,1585L,1734L,1855L,1995L,2147L,2287L,2451L,2605L,2777L,2938L,3127L,3315L,3473L,3669L,3874L,4090L,4302L,4491L,4694L,4926L,5172L,5410L,5642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008071Inst : IEnumerable<long>
{
public static readonly long[] Value=A008071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008071.Bytes);
public long this[int i]=>Value[i];

public static A008071Inst Instance=new A008071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008072
{
public static readonly long[] Value={ 1L,4L,12L,22L,37L,59L,93L,127L,158L,193L,251L,318L,363L,424L,497L,568L,644L,742L,820L,900L,1015L,1130L,1254L,1325L,1436L,1614L,1739L,1837L,1967L,2144L,2279L,2449L,2642L,2762L,2899L,3112L,3341L,3501L,3647L,3832L,4088L,4305L,4483L,4706L,4932L,5126L,5375L,5692L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008072Inst : IEnumerable<long>
{
public static readonly long[] Value=A008072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008072.Bytes);
public long this[int i]=>Value[i];

public static A008072Inst Instance=new A008072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008073
{
public static readonly long[] Value={ 1L,4L,12L,25L,40L,61L,86L,119L,164L,212L,253L,303L,366L,436L,506L,570L,644L,728L,826L,934L,1022L,1111L,1225L,1361L,1479L,1592L,1717L,1849L,2000L,2140L,2286L,2452L,2620L,2784L,2951L,3103L,3283L,3511L,3723L,3878L,4033L,4254L,4512L,4762L,4955L,5136L,5355L,5612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008073Inst : IEnumerable<long>
{
public static readonly long[] Value=A008073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008073.Bytes);
public long this[int i]=>Value[i];

public static A008073Inst Instance=new A008073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008074
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,63L,87L,121L,165L,208L,255L,294L,371L,435L,498L,579L,646L,734L,827L,924L,1020L,1117L,1217L,1350L,1481L,1598L,1719L,1845L,1998L,2145L,2301L,2448L,2608L,2776L,2943L,3118L,3301L,3493L,3676L,3894L,4080L,4252L,4492L,4741L,4953L,5158L,5376L,5605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008074Inst : IEnumerable<long>
{
public static readonly long[] Value=A008074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008074.Bytes);
public long this[int i]=>Value[i];

public static A008074Inst Instance=new A008074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008075
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,62L,94L,124L,158L,196L,252L,312L,372L,426L,488L,574L,666L,746L,814L,906L,1014L,1132L,1244L,1344L,1444L,1584L,1732L,1882L,2002L,2120L,2302L,2460L,2610L,2756L,2946L,3132L,3306L,3498L,3652L,3864L,4094L,4324L,4524L,4666L,4886L,5188L,5468L,5638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008075Inst : IEnumerable<long>
{
public static readonly long[] Value=A008075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008075.Bytes);
public long this[int i]=>Value[i];

public static A008075Inst Instance=new A008075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008076
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,57L,93L,121L,157L,210L,240L,300L,361L,445L,483L,570L,681L,705L,805L,935L,1027L,1110L,1224L,1329L,1443L,1630L,1729L,1851L,1968L,2100L,2323L,2485L,2595L,2721L,2943L,3141L,3292L,3467L,3679L,3897L,4059L,4248L,4518L,4705L,4879L,5226L,5424L,5511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008076Inst : IEnumerable<long>
{
public static readonly long[] Value=A008076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008076.Bytes);
public long this[int i]=>Value[i];

public static A008076Inst Instance=new A008076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008077
{
public static readonly long[] Value={ 1L,4L,12L,24L,33L,60L,97L,136L,150L,192L,264L,306L,378L,421L,487L,579L,660L,720L,817L,917L,1000L,1164L,1266L,1311L,1414L,1618L,1800L,1824L,1941L,2121L,2295L,2488L,2653L,2766L,2862L,3102L,3373L,3545L,3634L,3804L,4089L,4338L,4510L,4699L,4887L,5130L,5445L,5661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008077Inst : IEnumerable<long>
{
public static readonly long[] Value=A008077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008077.Bytes);
public long this[int i]=>Value[i];

public static A008077Inst Instance=new A008077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008094
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,46L,64L,90L,126L,164L,196L,222L,258L,316L,384L,444L,488L,532L,594L,676L,768L,850L,920L,990L,1074L,1176L,1282L,1386L,1486L,1586L,1692L,1804L,1928L,2060L,2192L,2318L,2440L,2574L,2722L,2876L,3026L,3170L,3320L,3482L,3656L,3830L,3994L,4158L,4336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008094Inst : IEnumerable<long>
{
public static readonly long[] Value=A008094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008094.Bytes);
public long this[int i]=>Value[i];

public static A008094Inst Instance=new A008094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008095
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,59L,92L,129L,167L,197L,246L,306L,367L,433L,491L,565L,660L,761L,839L,918L,1023L,1151L,1269L,1377L,1476L,1605L,1780L,1912L,2017L,2171L,2339L,2524L,2677L,2812L,2979L,3177L,3405L,3587L,3753L,3937L,4158L,4424L,4636L,4832L,5020L,5244L,5561L,5824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008095Inst : IEnumerable<long>
{
public static readonly long[] Value=A008095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008095.Bytes);
public long this[int i]=>Value[i];

public static A008095Inst Instance=new A008095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008096
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,68L,92L,118L,156L,213L,268L,307L,347L,432L,522L,586L,651L,723L,840L,969L,1045L,1118L,1251L,1400L,1526L,1614L,1741L,1880L,2063L,2210L,2338L,2496L,2646L,2849L,3038L,3187L,3355L,3554L,3772L,4014L,4223L,4359L,4530L,4845L,5135L,5300L,5501L,5696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008096Inst : IEnumerable<long>
{
public static readonly long[] Value=A008096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008096.Bytes);
public long this[int i]=>Value[i];

public static A008096Inst Instance=new A008096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008097
{
public static readonly long[] Value={ 1L,4L,12L,25L,41L,64L,88L,122L,160L,202L,256L,310L,369L,437L,511L,576L,649L,748L,834L,940L,1040L,1128L,1255L,1381L,1516L,1623L,1748L,1905L,2041L,2201L,2343L,2484L,2659L,2837L,3021L,3194L,3362L,3562L,3776L,3979L,4174L,4368L,4582L,4818L,5074L,5280L,5477L,5767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008097Inst : IEnumerable<long>
{
public static readonly long[] Value=A008097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008097.Bytes);
public long this[int i]=>Value[i];

public static A008097Inst Instance=new A008097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008098
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,60L,89L,124L,159L,194L,248L,317L,373L,435L,493L,570L,663L,755L,824L,913L,1037L,1157L,1255L,1366L,1483L,1622L,1788L,1905L,2024L,2163L,2320L,2519L,2677L,2819L,2987L,3181L,3402L,3592L,3752L,3921L,4143L,4424L,4625L,4799L,5003L,5262L,5562L,5804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008098Inst : IEnumerable<long>
{
public static readonly long[] Value=A008098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008098.Bytes);
public long this[int i]=>Value[i];

public static A008098Inst Instance=new A008098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008099
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,59L,91L,124L,160L,206L,257L,309L,358L,422L,513L,580L,654L,739L,837L,942L,1045L,1138L,1242L,1382L,1511L,1622L,1741L,1900L,2041L,2192L,2341L,2487L,2669L,2841L,3021L,3194L,3352L,3559L,3779L,3983L,4183L,4369L,4592L,4820L,5084L,5306L,5473L,5773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008099Inst : IEnumerable<long>
{
public static readonly long[] Value=A008099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008099.Bytes);
public long this[int i]=>Value[i];

public static A008099Inst Instance=new A008099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008100
{
public static readonly long[] Value={ 1L,4L,12L,20L,31L,61L,88L,120L,159L,197L,248L,299L,368L,427L,482L,589L,642L,725L,840L,939L,1005L,1126L,1271L,1367L,1465L,1624L,1732L,1876L,2067L,2148L,2297L,2502L,2674L,2838L,2972L,3157L,3374L,3561L,3764L,3936L,4143L,4362L,4624L,4826L,4962L,5286L,5508L,5733L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008100Inst : IEnumerable<long>
{
public static readonly long[] Value=A008100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008100.Bytes);
public long this[int i]=>Value[i];

public static A008100Inst Instance=new A008100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008101
{
public static readonly long[] Value={ 1L,4L,12L,20L,34L,57L,92L,131L,164L,202L,236L,298L,379L,436L,485L,555L,653L,757L,846L,919L,997L,1133L,1289L,1373L,1461L,1594L,1756L,1933L,2034L,2142L,2314L,2521L,2685L,2814L,2965L,3144L,3379L,3613L,3756L,3918L,4118L,4376L,4665L,4869L,4992L,5196L,5524L,5840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008101Inst : IEnumerable<long>
{
public static readonly long[] Value=A008101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008101.Bytes);
public long this[int i]=>Value[i];

public static A008101Inst Instance=new A008101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008102
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,60L,91L,126L,161L,195L,243L,309L,387L,441L,481L,585L,660L,741L,832L,921L,1029L,1154L,1271L,1344L,1481L,1628L,1780L,1908L,2035L,2154L,2325L,2535L,2680L,2817L,2973L,3164L,3424L,3604L,3732L,3913L,4166L,4421L,4613L,4803L,4960L,5281L,5574L,5765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008102Inst : IEnumerable<long>
{
public static readonly long[] Value=A008102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008102.Bytes);
public long this[int i]=>Value[i];

public static A008102Inst Instance=new A008102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008103
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,56L,90L,127L,157L,197L,236L,306L,395L,431L,482L,559L,670L,741L,833L,911L,1006L,1163L,1277L,1349L,1453L,1620L,1772L,1912L,2035L,2158L,2293L,2496L,2703L,2829L,2955L,3155L,3379L,3621L,3761L,3898L,4105L,4367L,4688L,4813L,4960L,5220L,5565L,5798L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008103Inst : IEnumerable<long>
{
public static readonly long[] Value=A008103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008103.Bytes);
public long this[int i]=>Value[i];

public static A008103Inst Instance=new A008103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008104
{
public static readonly long[] Value={ 1L,4L,11L,23L,45L,67L,88L,115L,162L,218L,261L,303L,356L,434L,522L,589L,646L,716L,859L,966L,1021L,1123L,1255L,1410L,1510L,1628L,1733L,1871L,2083L,2231L,2328L,2477L,2648L,2844L,3047L,3197L,3334L,3528L,3790L,4035L,4190L,4326L,4553L,4860L,5103L,5287L,5485L,5704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008104Inst : IEnumerable<long>
{
public static readonly long[] Value=A008104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008104.Bytes);
public long this[int i]=>Value[i];

public static A008104Inst Instance=new A008104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008105
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,120L,145L,173L,206L,244L,285L,327L,369L,413L,462L,517L,576L,636L,696L,757L,822L,893L,969L,1047L,1125L,1204L,1286L,1373L,1465L,1560L,1656L,1753L,1853L,1957L,2065L,2176L,2289L,2404L,2522L,2644L,2769L,2896L,3025L,3157L,3293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008105Inst : IEnumerable<long>
{
public static readonly long[] Value=A008105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008105.Bytes);
public long this[int i]=>Value[i];

public static A008105Inst Instance=new A008105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008106
{
public static readonly long[] Value={ 1L,4L,12L,21L,39L,66L,95L,126L,169L,221L,265L,311L,380L,459L,524L,587L,675L,783L,870L,943L,1058L,1176L,1296L,1401L,1525L,1681L,1788L,1929L,2094L,2246L,2403L,2517L,2733L,2933L,3063L,3245L,3423L,3687L,3865L,3995L,4269L,4469L,4716L,4914L,5122L,5444L,5594L,5871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008106Inst : IEnumerable<long>
{
public static readonly long[] Value=A008106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008106.Bytes);
public long this[int i]=>Value[i];

public static A008106Inst Instance=new A008106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008107
{
public static readonly long[] Value={ 1L,4L,12L,27L,43L,62L,97L,139L,172L,206L,264L,336L,387L,439L,519L,609L,690L,758L,855L,971L,1065L,1172L,1292L,1418L,1529L,1640L,1813L,1964L,2080L,2214L,2387L,2601L,2730L,2862L,3076L,3280L,3474L,3616L,3826L,4077L,4251L,4476L,4695L,4936L,5157L,5343L,5666L,5913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008107Inst : IEnumerable<long>
{
public static readonly long[] Value=A008107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008107.Bytes);
public long this[int i]=>Value[i];

public static A008107Inst Instance=new A008107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008108
{
public static readonly long[] Value={ 1L,4L,12L,20L,35L,67L,104L,121L,157L,223L,276L,308L,365L,460L,539L,582L,664L,783L,873L,951L,1036L,1197L,1291L,1382L,1530L,1686L,1814L,1898L,2059L,2305L,2388L,2523L,2687L,2943L,3124L,3190L,3429L,3686L,3855L,4050L,4176L,4545L,4701L,4865L,5172L,5401L,5675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008108Inst : IEnumerable<long>
{
public static readonly long[] Value=A008108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008108.Bytes);
public long this[int i]=>Value[i];

public static A008108Inst Instance=new A008108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008109
{
public static readonly long[] Value={ 1L,4L,12L,23L,40L,66L,96L,131L,164L,214L,272L,317L,384L,450L,516L,611L,670L,766L,860L,955L,1078L,1172L,1282L,1409L,1520L,1676L,1800L,1933L,2082L,2236L,2406L,2563L,2704L,2896L,3078L,3281L,3450L,3630L,3824L,4051L,4282L,4470L,4690L,4909L,5140L,5444L,5606L,5875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008109Inst : IEnumerable<long>
{
public static readonly long[] Value=A008109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008109.Bytes);
public long this[int i]=>Value[i];

public static A008109Inst Instance=new A008109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008158
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,67L,95L,133L,177L,219L,277L,338L,397L,471L,570L,640L,725L,823L,903L,1023L,1156L,1238L,1357L,1506L,1653L,1771L,1913L,2086L,2223L,2394L,2584L,2717L,2917L,3135L,3270L,3469L,3725L,3886L,4101L,4362L,4561L,4790L,5044L,5280L,5517L,5773L,6062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008158Inst : IEnumerable<long>
{
public static readonly long[] Value=A008158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008158.Bytes);
public long this[int i]=>Value[i];

public static A008158Inst Instance=new A008158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008159
{
public static readonly long[] Value={ 1L,4L,12L,26L,44L,64L,98L,144L,172L,222L,272L,340L,438L,476L,528L,642L,744L,840L,922L,1012L,1144L,1282L,1380L,1484L,1642L,1796L,1944L,2070L,2228L,2444L,2554L,2760L,2928L,3066L,3360L,3500L,3682L,3936L,4112L,4362L,4564L,4824L,5046L,5276L,5576L,5778L,6056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008159Inst : IEnumerable<long>
{
public static readonly long[] Value=A008159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008159.Bytes);
public long this[int i]=>Value[i];

public static A008159Inst Instance=new A008159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008160
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,69L,93L,121L,153L,189L,228L,270L,317L,368L,422L,480L,541L,606L,676L,749L,825L,905L,989L,1077L,1169L,1264L,1362L,1465L,1572L,1682L,1796L,1913L,2034L,2160L,2289L,2421L,2557L,2697L,2841L,2989L,3140L,3294L,3453L,3616L,3782L,3952L,4125L,4302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008160Inst : IEnumerable<long>
{
public static readonly long[] Value=A008160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008160.Bytes);
public long this[int i]=>Value[i];

public static A008160Inst Instance=new A008160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008161
{
public static readonly long[] Value={ 1L,4L,12L,22L,41L,61L,88L,125L,159L,198L,250L,297L,363L,415L,486L,558L,626L,729L,800L,885L,1002L,1082L,1213L,1308L,1414L,1557L,1662L,1833L,1931L,2070L,2250L,2363L,2557L,2686L,2855L,3051L,3187L,3418L,3560L,3759L,3986L,4130L,4402L,4561L,4797L,5036L,5208L,5503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008161Inst : IEnumerable<long>
{
public static readonly long[] Value=A008161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008161.Bytes);
public long this[int i]=>Value[i];

public static A008161Inst Instance=new A008161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008162
{
public static readonly long[] Value={ 1L,4L,11L,22L,36L,61L,93L,120L,154L,200L,255L,305L,353L,417L,480L,554L,640L,715L,807L,893L,986L,1103L,1201L,1310L,1414L,1536L,1694L,1814L,1945L,2069L,2214L,2407L,2551L,2689L,2836L,3020L,3245L,3409L,3559L,3734L,3961L,4214L,4389L,4551L,4761L,5023L,5279L,5468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008162Inst : IEnumerable<long>
{
public static readonly long[] Value=A008162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008162.Bytes);
public long this[int i]=>Value[i];

public static A008162Inst Instance=new A008162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008163
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,59L,92L,125L,159L,202L,250L,299L,364L,413L,480L,562L,633L,724L,800L,888L,993L,1100L,1215L,1305L,1403L,1549L,1681L,1828L,1940L,2066L,2224L,2393L,2568L,2684L,2834L,3025L,3223L,3427L,3571L,3740L,3958L,4178L,4414L,4560L,4773L,5009L,5243L,5507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008163Inst : IEnumerable<long>
{
public static readonly long[] Value=A008163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008163.Bytes);
public long this[int i]=>Value[i];

public static A008163Inst Instance=new A008163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008164
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,89L,126L,161L,196L,246L,306L,363L,419L,474L,545L,643L,733L,805L,874L,979L,1116L,1214L,1301L,1404L,1542L,1706L,1814L,1926L,2061L,2235L,2409L,2533L,2691L,2847L,3035L,3230L,3383L,3583L,3760L,3957L,4178L,4366L,4595L,4776L,4995L,5265L,5476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008164Inst : IEnumerable<long>
{
public static readonly long[] Value=A008164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008164.Bytes);
public long this[int i]=>Value[i];

public static A008164Inst Instance=new A008164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008165
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,64L,91L,117L,158L,209L,247L,294L,353L,429L,493L,551L,635L,708L,812L,903L,975L,1098L,1190L,1316L,1437L,1545L,1684L,1788L,1947L,2100L,2223L,2385L,2508L,2713L,2894L,3015L,3218L,3355L,3609L,3784L,3936L,4180L,4321L,4620L,4817L,4994L,5257L,5425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008165Inst : IEnumerable<long>
{
public static readonly long[] Value=A008165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008165.Bytes);
public long this[int i]=>Value[i];

public static A008165Inst Instance=new A008165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008166
{
public static readonly long[] Value={ 1L,4L,12L,23L,37L,62L,91L,120L,157L,206L,250L,294L,356L,421L,488L,555L,627L,725L,806L,894L,985L,1081L,1208L,1306L,1430L,1558L,1669L,1802L,1934L,2087L,2242L,2359L,2532L,2698L,2884L,3050L,3168L,3399L,3571L,3790L,3966L,4120L,4387L,4571L,4824L,5014L,5197L,5503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008166Inst : IEnumerable<long>
{
public static readonly long[] Value=A008166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008166.Bytes);
public long this[int i]=>Value[i];

public static A008166Inst Instance=new A008166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008167
{
public static readonly long[] Value={ 1L,4L,12L,21L,36L,61L,90L,122L,159L,196L,251L,305L,360L,413L,469L,561L,643L,720L,803L,875L,992L,1111L,1202L,1294L,1405L,1550L,1700L,1823L,1920L,2061L,2223L,2400L,2563L,2673L,2847L,3021L,3219L,3428L,3560L,3743L,3947L,4163L,4427L,4571L,4763L,4987L,5231L,5536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008167Inst : IEnumerable<long>
{
public static readonly long[] Value=A008167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008167.Bytes);
public long this[int i]=>Value[i];

public static A008167Inst Instance=new A008167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008168
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,63L,93L,123L,157L,206L,247L,304L,351L,420L,493L,556L,638L,711L,806L,902L,982L,1103L,1200L,1307L,1431L,1540L,1693L,1792L,1952L,2088L,2214L,2402L,2519L,2713L,2870L,3015L,3226L,3372L,3605L,3778L,3925L,4190L,4353L,4612L,4794L,4989L,5267L,5444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008168Inst : IEnumerable<long>
{
public static readonly long[] Value=A008168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008168.Bytes);
public long this[int i]=>Value[i];

public static A008168Inst Instance=new A008168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008169
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,61L,88L,124L,156L,197L,253L,296L,353L,420L,493L,562L,621L,718L,808L,891L,999L,1076L,1195L,1317L,1432L,1561L,1649L,1814L,1936L,2090L,2244L,2344L,2542L,2699L,2878L,3047L,3173L,3399L,3571L,3775L,3989L,4116L,4375L,4577L,4810L,5043L,5202L,5478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008169Inst : IEnumerable<long>
{
public static readonly long[] Value=A008169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008169.Bytes);
public long this[int i]=>Value[i];

public static A008169Inst Instance=new A008169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008170
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,56L,90L,132L,164L,193L,241L,312L,372L,414L,466L,552L,657L,730L,788L,875L,996L,1116L,1208L,1299L,1407L,1542L,1695L,1821L,1940L,2062L,2225L,2410L,2552L,2689L,2827L,3020L,3249L,3412L,3571L,3737L,3955L,4200L,4387L,4587L,4761L,4987L,5265L,5498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008170Inst : IEnumerable<long>
{
public static readonly long[] Value=A008170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008170.Bytes);
public long this[int i]=>Value[i];

public static A008170Inst Instance=new A008170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008171
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,63L,90L,121L,155L,201L,253L,301L,359L,413L,482L,566L,632L,710L,805L,898L,997L,1081L,1196L,1314L,1427L,1551L,1668L,1812L,1955L,2076L,2216L,2380L,2561L,2702L,2843L,3021L,3207L,3425L,3578L,3746L,3951L,4170L,4403L,4568L,4776L,5015L,5240L,5499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008171Inst : IEnumerable<long>
{
public static readonly long[] Value=A008171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008171.Bytes);
public long this[int i]=>Value[i];

public static A008171Inst Instance=new A008171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008172
{
public static readonly long[] Value={ 1L,4L,11L,23L,39L,62L,93L,119L,153L,204L,254L,301L,350L,418L,497L,559L,624L,705L,816L,919L,986L,1067L,1187L,1332L,1450L,1538L,1653L,1803L,1968L,2100L,2208L,2366L,2538L,2715L,2875L,3019L,3213L,3385L,3574L,3772L,3967L,4189L,4354L,4551L,4802L,5052L,5266L,5429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008172Inst : IEnumerable<long>
{
public static readonly long[] Value=A008172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008172.Bytes);
public long this[int i]=>Value[i];

public static A008172Inst Instance=new A008172Inst();

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