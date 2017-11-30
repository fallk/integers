using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A174705
{
public static readonly long[] Value={ 1L,0L,0L,2L,14L,90L,462L,1668L,4496L,11332L,31718L,100258L,336142L,1123212L,3614554L,11128872L,33226646L,98298782L,292626532L,879380718L,2654884024L,8000680668L,23965094526L,71287278676L,210922844362L,622218231406L,1833225926678L,5397521667296L,15876398740556L,46626957024628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174705Inst : IEnumerable<long>
{
public static readonly long[] Value=A174705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174705.Bytes);
public long this[int i]=>Value[i];

public static A174705Inst Instance=new A174705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174706
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,14L,12L,0L,0L,0L,0L,30L,104L,112L,48L,40L,48L,112L,400L,964L,1276L,1202L,1280L,1714L,3004L,6120L,11472L,16730L,20884L,26308L,36676L,57570L,96642L,158864L,237592L,330064L,453476L,647862L,975210L,1515766L,2345634L,3505078L,5064148L,7241688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174706Inst : IEnumerable<long>
{
public static readonly long[] Value=A174706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174706.Bytes);
public long this[int i]=>Value[i];

public static A174706Inst Instance=new A174706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174707
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,2L,28L,144L,292L,272L,160L,272L,844L,3888L,15830L,49080L,113468L,208224L,352112L,662810L,1497286L,3853054L,10238142L,25892602L,60223752L,130042700L,271136524L,572265830L,1258121046L,2878870324L,6714840216L,15583281118L,35434903508L,78777769972L,172664047056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174707Inst : IEnumerable<long>
{
public static readonly long[] Value=A174707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174707.Bytes);
public long this[int i]=>Value[i];

public static A174707Inst Instance=new A174707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174708
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,2L,18L,12L,0L,0L,0L,0L,0L,0L,30L,136L,112L,0L,0L,0L,0L,0L,0L,400L,1348L,1352L,408L,180L,120L,180L,408L,1352L,7356L,19008L,23028L,16788L,12630L,11744L,16742L,31320L,70256L,181106L,367560L,503800L,533504L,546468L,623546L,881384L,1468398L,2697374L,5164896L,8976002L,12977384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174708Inst : IEnumerable<long>
{
public static readonly long[] Value=A174708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174708.Bytes);
public long this[int i]=>Value[i];

public static A174708Inst Instance=new A174708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174709
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,8L,10L,12L,14L,16L,18L,21L,24L,27L,30L,33L,36L,40L,44L,48L,52L,56L,60L,65L,70L,75L,80L,85L,90L,96L,102L,108L,114L,120L,126L,133L,140L,147L,154L,161L,168L,176L,184L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174709Inst : IEnumerable<long>
{
public static readonly long[] Value=A174709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174709.Bytes);
public long this[int i]=>Value[i];

public static A174709Inst Instance=new A174709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174710
{
public static readonly long[] Value={ 1L,2L,275L,1556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174710Inst : IEnumerable<long>
{
public static readonly long[] Value=A174710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174710.Bytes);
public long this[int i]=>Value[i];

public static A174710Inst Instance=new A174710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174711
{
public static readonly BigInteger[] Value={ 9L,55L,513L,6251L,93313L,1647087L,33554433L,774840979L,20000000001L,570623341223L,605750213184507L,22224013651116033L,875787780761718751L,BigInteger.Parse("36893488147419103233"),BigInteger.Parse("1654480523772673528355"),BigInteger.Parse("3956839311320627178247959") };
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
public class A174711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174711Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174711.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174711Inst Instance=new A174711Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174712
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,11L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,0L,22L,0L,0L,0L,0L,0L,0L,0L,0L,0L,30L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174712Inst : IEnumerable<long>
{
public static readonly long[] Value=A174712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174712.Bytes);
public long this[int i]=>Value[i];

public static A174712Inst Instance=new A174712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174713
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,2L,4L,2L,2L,3L,5L,3L,4L,3L,6L,4L,4L,3L,5L,8L,5L,6L,6L,5L,10L,6L,8L,6L,5L,7L,12L,8L,10L,9L,10L,7L,15L,10L,12L,12L,10L,7L,11L,18L,12L,16L,15L,15L,14L,11L,22L,15L,20L,18L,20L,14L,11L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174713Inst : IEnumerable<long>
{
public static readonly long[] Value=A174713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174713.Bytes);
public long this[int i]=>Value[i];

public static A174713Inst Instance=new A174713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174714
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,4L,1L,5L,2L,7L,2L,2L,9L,4L,2L,13L,5L,4L,16L,7L,4L,3L,22L,9L,8L,3L,27L,13L,10L,6L,36L,16L,14L,6L,5L,44L,22L,18L,12L,5L,57L,27L,26L,15L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174714Inst : IEnumerable<long>
{
public static readonly long[] Value=A174714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174714.Bytes);
public long this[int i]=>Value[i];

public static A174714Inst Instance=new A174714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174715
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,1L,6L,1L,9L,2L,12L,3L,16L,4L,2L,22L,6L,2L,29L,9L,4L,38L,12L,6L,50L,16L,8L,3L,64L,22L,12L,3L,82L,29L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174715Inst : IEnumerable<long>
{
public static readonly long[] Value=A174715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174715.Bytes);
public long this[int i]=>Value[i];

public static A174715Inst Instance=new A174715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174716
{
public static readonly long[] Value={ 30L,1230L,1290L,1482L,2730L,3390L,3930L,4092L,4230L,5520L,8010L,8970L,13680L,16830L,17190L,19890L,20982L,22092L,22110L,27690L,36528L,37812L,41202L,60102L,71340L,81930L,96330L,97650L,98010L,108960L,110880L,111270L,116790L,121632L,129402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174716Inst : IEnumerable<long>
{
public static readonly long[] Value=A174716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174716.Bytes);
public long this[int i]=>Value[i];

public static A174716Inst Instance=new A174716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174717
{
public static readonly long[] Value={ 432L,4788L,9000L,211500L,437472L,564300L,1231200L,1232352L,1271088L,2368800L,2609208L,3042900L,5523408L,6773580L,8560692L,9604980L,9985500L,12797568L,14653548L,15630300L,15850800L,24770592L,26462700L,33242400L,34716348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174717Inst : IEnumerable<long>
{
public static readonly long[] Value=A174717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174717.Bytes);
public long this[int i]=>Value[i];

public static A174717Inst Instance=new A174717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174718
{
public static readonly long[] Value={ 1L,1L,1L,1L,-2L,1L,1L,-13L,-13L,1L,1L,-44L,-74L,-44L,1L,1L,-123L,-278L,-278L,-123L,1L,1L,-314L,-881L,-1196L,-881L,-314L,1L,1L,-761L,-2539L,-4317L,-4317L,-2539L,-761L,1L,1L,-1784L,-6884L,-14024L,-17594L,-14024L,-6884L,-1784L,1L,1L,-4087L,-17884L,-42412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174718Inst : IEnumerable<long>
{
public static readonly long[] Value=A174718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174718.Bytes);
public long this[int i]=>Value[i];

public static A174718Inst Instance=new A174718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174719
{
public static readonly long[] Value={ 1L,1L,1L,1L,-7L,1L,1L,-51L,-51L,1L,1L,-239L,-399L,-239L,1L,1L,-967L,-2177L,-2177L,-967L,1L,1L,-3639L,-10191L,-13831L,-10191L,-3639L,1L,1L,-13115L,-43719L,-74323L,-74323L,-43719L,-13115L,1L,1L,-45919L,-177119L,-360799L,-452639L,-360799L,-177119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174719Inst : IEnumerable<long>
{
public static readonly long[] Value=A174719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174719.Bytes);
public long this[int i]=>Value[i];

public static A174719Inst Instance=new A174719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174720
{
public static readonly long[] Value={ 1L,1L,1L,1L,-14L,1L,1L,-125L,-125L,1L,1L,-764L,-1274L,-764L,1L,1L,-4091L,-9206L,-9206L,-4091L,1L,1L,-20474L,-57329L,-77804L,-57329L,-20474L,1L,1L,-98297L,-327659L,-557021L,-557021L,-327659L,-98297L,1L,1L,-458744L,-1769444L,-3604424L,-4521914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174720Inst : IEnumerable<long>
{
public static readonly long[] Value=A174720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174720.Bytes);
public long this[int i]=>Value[i];

public static A174720Inst Instance=new A174720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174721
{
public static readonly long[] Value={ 1L,2L,4L,10L,13L,20L,31L,33L,48L,55L,64L,66L,70L,82L,98L,103L,241L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174721Inst : IEnumerable<long>
{
public static readonly long[] Value=A174721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174721.Bytes);
public long this[int i]=>Value[i];

public static A174721Inst Instance=new A174721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174722
{
public static readonly long[] Value={ 3L,5L,17L,103L,233L,1367L,1753L,2351L,7393L,19543L,20593L,46639L,54449L,284527L,344249L,407791L,512009L,812431L,844433L,1214407L,1316033L,2109671L,2233601L,11251351L,11267777L,13903271L,14449489L,16203287L,16451713L,18219679L,18367721L,18529111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174722Inst : IEnumerable<long>
{
public static readonly long[] Value=A174722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174722.Bytes);
public long this[int i]=>Value[i];

public static A174722Inst Instance=new A174722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174723
{
public static readonly long[] Value={ 1L,5L,16L,38L,75L,131L,210L,316L,453L,625L,836L,1090L,1391L,1743L,2150L,2616L,3145L,3741L,4408L,5150L,5971L,6875L,7866L,8948L,10125L,11401L,12780L,14266L,15863L,17575L,19406L,21360L,23441L,25653L,28000L,30486L,33115L,35891L,38818L,41900L,45141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174723Inst : IEnumerable<long>
{
public static readonly long[] Value=A174723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174723.Bytes);
public long this[int i]=>Value[i];

public static A174723Inst Instance=new A174723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174724
{
public static readonly long[] Value={ 4L,7L,9L,11L,13L,15L,17L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174724Inst : IEnumerable<long>
{
public static readonly long[] Value=A174724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174724.Bytes);
public long this[int i]=>Value[i];

public static A174724Inst Instance=new A174724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174725
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,0L,2L,1L,2L,0L,4L,0L,2L,2L,4L,0L,4L,0L,4L,2L,2L,0L,10L,1L,2L,2L,4L,0L,6L,0L,8L,2L,2L,2L,13L,0L,2L,2L,10L,0L,6L,0L,4L,4L,2L,0L,24L,1L,4L,2L,4L,0L,10L,2L,10L,2L,2L,0L,22L,0L,2L,4L,16L,2L,6L,0L,4L,2L,6L,0L,38L,0L,2L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174725Inst : IEnumerable<long>
{
public static readonly long[] Value=A174725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174725.Bytes);
public long this[int i]=>Value[i];

public static A174725Inst Instance=new A174725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174726
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,1L,1L,4L,1L,4L,1L,4L,1L,1L,1L,10L,1L,1L,2L,4L,1L,7L,1L,8L,1L,1L,1L,13L,1L,1L,1L,10L,1L,7L,1L,4L,4L,1L,1L,24L,1L,4L,1L,4L,1L,10L,1L,10L,1L,1L,1L,22L,1L,1L,4L,16L,1L,7L,1L,4L,1L,7L,1L,38L,1L,1L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174726Inst : IEnumerable<long>
{
public static readonly long[] Value=A174726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174726.Bytes);
public long this[int i]=>Value[i];

public static A174726Inst Instance=new A174726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174727
{
public static readonly long[] Value={ 2L,6L,8L,180L,288L,10080L,17280L,453600L,806400L,47900160L,87091200L,217945728000L,402361344000L,2241727488000L,4184557977600L,2000741783040000L,3766102179840000L,2838385676206080000L,5377993912811520000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174727Inst : IEnumerable<long>
{
public static readonly long[] Value=A174727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174727.Bytes);
public long this[int i]=>Value[i];

public static A174727Inst Instance=new A174727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174728
{
public static readonly long[] Value={ 1L,1L,1L,1L,-8L,1L,1L,-69L,-69L,1L,1L,-374L,-974L,-374L,1L,1L,-1735L,-9330L,-9330L,-1735L,1L,1L,-7496L,-74969L,-152144L,-74969L,-7496L,1L,1L,-31241L,-545083L,-1983485L,-1983485L,-545083L,-31241L,1L,1L,-127754L,-3724784L,-22499414L,-39828194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174728Inst : IEnumerable<long>
{
public static readonly long[] Value=A174728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174728.Bytes);
public long this[int i]=>Value[i];

public static A174728Inst Instance=new A174728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174729
{
public static readonly long[] Value={ 1L,1L,1L,1L,-23L,1L,1L,-259L,-259L,1L,1L,-1999L,-5199L,-1999L,1L,1L,-13551L,-72841L,-72841L,-13551L,1L,1L,-86631L,-866319L,-1758119L,-866319L,-86631L,1L,1L,-537755L,-9382311L,-34140947L,-34140947L,-9382311L,-537755L,1L,1L,-3286559L,-95821919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174729Inst : IEnumerable<long>
{
public static readonly long[] Value=A174729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174729.Bytes);
public long this[int i]=>Value[i];

public static A174729Inst Instance=new A174729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174730
{
public static readonly long[] Value={ 1L,1L,1L,1L,-44L,1L,1L,-629L,-629L,1L,1L,-6374L,-16574L,-6374L,1L,1L,-57287L,-307922L,-307922L,-57287L,1L,1L,-487304L,-4873049L,-9889424L,-4873049L,-487304L,1L,1L,-4030217L,-70315835L,-255869693L,-255869693L,-70315835L,-4030217L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174730Inst : IEnumerable<long>
{
public static readonly long[] Value=A174730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174730.Bytes);
public long this[int i]=>Value[i];

public static A174730Inst Instance=new A174730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174731
{
public static readonly long[] Value={ 1L,1L,1L,1L,-13L,1L,1L,-74L,-74L,1L,1L,-278L,-588L,-278L,1L,1L,-881L,-3086L,-3086L,-881L,1L,1L,-2539L,-13207L,-22097L,-13207L,-2539L,1L,1L,-6884L,-49724L,-124694L,-124694L,-49724L,-6884L,1L,1L,-17884L,-171184L,-600424L,-900892L,-600424L,-171184L,-17884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174731Inst : IEnumerable<long>
{
public static readonly long[] Value=A174731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174731.Bytes);
public long this[int i]=>Value[i];

public static A174731Inst Instance=new A174731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174732
{
public static readonly long[] Value={ 1L,1L,1L,1L,-51L,1L,1L,-399L,-399L,1L,1L,-2177L,-4597L,-2177L,1L,1L,-10191L,-35671L,-35671L,-10191L,1L,1L,-43719L,-227343L,-380363L,-227343L,-43719L,1L,1L,-177119L,-1279199L,-3207839L,-3207839L,-1279199L,-177119L,1L,1L,-688869L,-6593469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174732Inst : IEnumerable<long>
{
public static readonly long[] Value=A174732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174732.Bytes);
public long this[int i]=>Value[i];

public static A174732Inst Instance=new A174732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174733
{
public static readonly long[] Value={ 1L,1L,1L,1L,-125L,1L,1L,-1274L,-1274L,1L,1L,-9206L,-19436L,-9206L,1L,1L,-57329L,-200654L,-200654L,-57329L,1L,1L,-327659L,-1703831L,-2850641L,-1703831L,-327659L,1L,1L,-1769444L,-12779324L,-32046614L,-32046614L,-12779324L,-1769444L,1L,1L,-9175004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174733Inst : IEnumerable<long>
{
public static readonly long[] Value=A174733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174733.Bytes);
public long this[int i]=>Value[i];

public static A174733Inst Instance=new A174733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174734
{
public static readonly long[] Value={ 3L,7L,37L,211L,271L,307L,331L,337L,601L,727L,1171L,1237L,1297L,1531L,1657L,2221L,2281L,2557L,3037L,3061L,3067L,4261L,4447L,4801L,4951L,5227L,5581L,5851L,6151L,6361L,6691L,6841L,6967L,7621L,7681L,7687L,7867L,8017L,8167L,8191L,8287L,8521L,8527L,8647L,8941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174734Inst : IEnumerable<long>
{
public static readonly long[] Value=A174734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174734.Bytes);
public long this[int i]=>Value[i];

public static A174734Inst Instance=new A174734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174735
{
public static readonly long[] Value={ 22L,3L,14L,26L,7L,18L,29L,11L,21L,2L,12L,24L,5L,16L,27L,9L,20L,1L,11L,22L,3L,14L,25L,8L,18L,29L,10L,21L,2L,13L,23L,6L,17L,27L,8L,20L,1L,11L,22L,4L,15L,26L,7L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174735Inst : IEnumerable<long>
{
public static readonly long[] Value=A174735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174735.Bytes);
public long this[int i]=>Value[i];

public static A174735Inst Instance=new A174735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174736
{
public static readonly BigInteger[] Value={ 2L,8L,2048L,8796093022208L,BigInteger.Parse("2993155353253689176481146537402947624255349848014848") };
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
public class A174736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174736Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174736.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174736Inst Instance=new A174736Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174737
{
public static readonly long[] Value={ 2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L,1L,3L,2L,-1L,-3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174737Inst : IEnumerable<long>
{
public static readonly long[] Value=A174737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174737.Bytes);
public long this[int i]=>Value[i];

public static A174737Inst Instance=new A174737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174738
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,3L,4L,5L,6L,7L,9L,11L,13L,15L,17L,19L,21L,24L,27L,30L,33L,36L,39L,42L,46L,50L,54L,58L,62L,66L,70L,75L,80L,85L,90L,95L,100L,105L,111L,117L,123L,129L,135L,141L,147L,154L,161L,168L,175L,182L,189L,196L,204L,212L,220L,228L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174738Inst : IEnumerable<long>
{
public static readonly long[] Value=A174738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174738.Bytes);
public long this[int i]=>Value[i];

public static A174738Inst Instance=new A174738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174739
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,0L,0L,2L,3L,-1L,0L,0L,3L,5L,0L,-1L,0L,0L,5L,7L,-1L,0L,-2L,0L,0L,7L,11L,0L,-1L,0L,-3L,0L,0L,11L,15L,0L,0L,-2L,0L,-5L,0L,15L,22L,0L,0L,0L,-3L,0L,-7L,0L,0L,22L,30L,0L,0L,0L,0L,-5L,0L,-11L,0L,0L,30L,42L,1L,0L,0L,0L,0L,-7L,0L,-15L,0L,0L,42L,56L,0L,1L,0L,0L,0L,0L,-11L,0L,-22L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174739Inst : IEnumerable<long>
{
public static readonly long[] Value=A174739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174739.Bytes);
public long this[int i]=>Value[i];

public static A174739Inst Instance=new A174739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174740
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,5L,6L,-5L,7L,10L,-5L,11L,14L,-10L,-7L,15L,22L,-15L,7L,22L,30L,-25L,-14L,22L,30L,-25L,-14L,30L,44L,-35L,-21L,42L,60L,-55L,-35L,56L,84L,-75L,-49L,12L,77L,112L,-110L,-77L,12L,101L,154L,-150L,-105L,24L,13L,202L,-210L,-54L,36L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174740Inst : IEnumerable<long>
{
public static readonly long[] Value=A174740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174740.Bytes);
public long this[int i]=>Value[i];

public static A174740Inst Instance=new A174740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174741
{
public static readonly long[] Value={ 4L,8L,18L,17L,29L,87L,79L,70L,58L,292L,506L,424L,766L,937L,542L,2026L,1820L,2842L,4960L,5215L,2136L,4687L,4461L,12809L,13992L,3666L,16231L,17662L,17338L,41935L,60010L,46063L,61469L,144060L,114441L,137956L,293037L,290348L,443629L,457617L,264395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174741Inst : IEnumerable<long>
{
public static readonly long[] Value=A174741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174741.Bytes);
public long this[int i]=>Value[i];

public static A174741Inst Instance=new A174741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174742
{
public static readonly long[] Value={ 2L,3L,13L,37L,43L,47L,59L,73L,89L,97L,103L,107L,113L,127L,131L,137L,151L,167L,173L,179L,181L,191L,193L,199L,223L,227L,233L,239L,241L,251L,257L,263L,269L,277L,307L,313L,317L,331L,353L,359L,367L,373L,383L,397L,419L,421L,433L,439L,443L,461L,479L,487L,503L,521L,523L,541L,557L,563L,569L,571L,577L,587L,593L,599L,601L,607L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174742Inst : IEnumerable<long>
{
public static readonly long[] Value=A174742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174742.Bytes);
public long this[int i]=>Value[i];

public static A174742Inst Instance=new A174742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174743
{
public static readonly BigInteger[] Value={ 1L,3L,7L,15L,31L,63L,131L,279L,621L,1469L,3766L,10694L,34728L,133582L,636719L,3955451L,33664265L,407703531L,7147333784L,180948983492L,6537204164708L,332740721681412L,23627093701822296L,2324803141466748032L,BigInteger.Parse("315610211340647518667"),BigInteger.Parse("58953876234603150481383") };
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
public class A174743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174743Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174743.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174743Inst Instance=new A174743Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174744
{
public static readonly BigInteger[] Value={ 9L,49L,961L,16129L,4190209L,67092481L,17179607041L,274876858369L,70368727400449L,288230375077969921L,4611686014132420609L,BigInteger.Parse("18889465931203702947841"),BigInteger.Parse("4835703278454118652313601"),BigInteger.Parse("77371252455318674995150849"),BigInteger.Parse("19807040628565802923409276929") };
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
public class A174744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174744Inst Instance=new A174744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174745
{
public static readonly BigInteger[] Value={ 0L,12L,1320L,145188L,15969360L,1756484412L,193197315960L,21249948271188L,2337301112514720L,257081872428348012L,BigInteger.Parse("28276668666005766600"),BigInteger.Parse("3110176471388205977988"),BigInteger.Parse("342091135184036651812080") };
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
public class A174745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174745Inst Instance=new A174745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174746
{
public static readonly BigInteger[] Value={ 1L,1520L,4620799L,14047227440L,42703566796801L,129818829015047600L,BigInteger.Parse("394649197502177907199"),BigInteger.Parse("1199733430587791822837360"),BigInteger.Parse("3647189234337689639247667201"),BigInteger.Parse("11087454072653145915521085453680") };
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
public class A174746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174746Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174746.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174746Inst Instance=new A174746Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174747
{
public static readonly BigInteger[] Value={ 1L,73L,10657L,1555849L,227143297L,33161365513L,4841332221601L,706801342988233L,103188154744060417L,15064763791289832649UL,BigInteger.Parse("2199352325373571506337"),BigInteger.Parse("321090374740750150092553"),BigInteger.Parse("46876995359824148342006401") };
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
public class A174747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174747Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174747.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174747Inst Instance=new A174747Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174748
{
public static readonly BigInteger[] Value={ 1L,23L,1057L,48599L,2234497L,102738263L,4723725601L,217188639383L,9985953686017L,459136680917399L,21110301368514337L,970614726270742103L,BigInteger.Parse("44627167107085622401"),BigInteger.Parse("2051879072199667888343"),BigInteger.Parse("94341810154077637241377"),BigInteger.Parse("4337671388015371645214999") };
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
public class A174748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174748Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174748.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174748Inst Instance=new A174748Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174749
{
public static readonly BigInteger[] Value={ 1L,35L,2449L,171395L,11995201L,839492675L,58752492049L,4111834950755L,287769694060801L,20139766749305315L,1409495902757311249L,BigInteger.Parse("98644573426262482115"),BigInteger.Parse("6903710643935616436801"),BigInteger.Parse("483161100502066888093955") };
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
public class A174749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174749Inst Instance=new A174749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174750
{
public static readonly BigInteger[] Value={ 1L,37L,2737L,202501L,14982337L,1108490437L,82013310001L,6067876449637L,448940843963137L,33215554576822501L,2457502097840901937L,BigInteger.Parse("181821939685649920837"),BigInteger.Parse("13452366034640253240001"),BigInteger.Parse("995293264623693089839237") };
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
public class A174750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174750Inst Instance=new A174750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174751
{
public static readonly BigInteger[] Value={ 1L,25L,1249L,62425L,3120001L,155937625L,7793761249L,389532124825L,19468812480001L,973051091875225L,48633085781281249L,2430681237972187225L,BigInteger.Parse("121485428812828080001"),BigInteger.Parse("6071840759403431812825"),BigInteger.Parse("303470552541358762561249") };
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
public class A174751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174751Inst Instance=new A174751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174752
{
public static readonly BigInteger[] Value={ 1L,2049L,8396801L,34410088449L,141012534067201L,577869330197301249L,BigInteger.Parse("2368108374136006451201"),BigInteger.Parse("9704507539340024239720449"),BigInteger.Parse("39769069528107045198367948801"),BigInteger.Parse("162973637221675131882887614466049") };
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
public class A174752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174752Inst Instance=new A174752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174753
{
public static readonly BigInteger[] Value={ 1L,3482L,24248647L,168867574226L,1175993762661217L,8189620394305140962L,BigInteger.Parse("57032515249947238998151"),BigInteger.Parse("397174428011012178077982602"),BigInteger.Parse("2765922659636173558187831842177") };
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
public class A174753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174753Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174753.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174753Inst Instance=new A174753Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174754
{
public static readonly BigInteger[] Value={ 1L,24335L,1184384449L,57643991108495L,2805533046066067201L,BigInteger.Parse("136545293294391499564175"),BigInteger.Parse("6645659421832501237722330049"),BigInteger.Parse("323444243924042541945554303920655") };
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
public class A174754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174754Inst Instance=new A174754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174755
{
public static readonly BigInteger[] Value={ 1L,48L,4607L,442224L,42448897L,4074651888L,391124132351L,37543842053808L,3603817713033217L,345928956609135024L,BigInteger.Parse("33205576016763929087"),BigInteger.Parse("3187389368652728057328"),BigInteger.Parse("305956173814645129574401") };
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
public class A174755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174755Inst Instance=new A174755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174756
{
public static readonly BigInteger[] Value={ 1L,50L,4999L,499850L,49980001L,4997500250L,499700044999L,49965006999650L,4996000999920001L,499550134985000450L,BigInteger.Parse("49950017497500124999"),BigInteger.Parse("4994502199615027499450"),BigInteger.Parse("499400269944005249820001") };
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
public class A174756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174756Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174756.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174756Inst Instance=new A174756Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174757
{
public static readonly BigInteger[] Value={ 1L,66249L,8777860001L,1163048894346249L,BigInteger.Parse("154101652394311440001"),BigInteger.Parse("20418160737778428282906249"),BigInteger.Parse("2705365461280064538234200740001"),BigInteger.Parse("358455512868267830449176701365746249") };
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
public class A174757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174757Inst Instance=new A174757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174758
{
public static readonly BigInteger[] Value={ 1L,89L,15841L,2819609L,501874561L,89330852249L,15900389825761L,2830180058133209L,503756149957885441L,BigInteger.Parse("89665764512445475289"),BigInteger.Parse("15960002327065336716001"),BigInteger.Parse("2840790748453117489972889") };
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
public class A174758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174758Inst Instance=new A174758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174759
{
public static readonly BigInteger[] Value={ 1L,151L,45601L,13771351L,4158902401L,1255974753751L,379300216730401L,114547409477827351L,BigInteger.Parse("34592938362087129601"),BigInteger.Parse("10446952837940835312151"),BigInteger.Parse("3154945164119770177140001"),BigInteger.Parse("952782992611332652660968151") };
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
public class A174759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174759Inst Instance=new A174759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174760
{
public static readonly BigInteger[] Value={ 1L,19603L,768555217L,30131975818099L,1181354243155834177L,BigInteger.Parse("46316174427035658925363"),BigInteger.Parse("1815871933405005800671947601"),BigInteger.Parse("71193074974760482994108718719443") };
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
public class A174760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174760Inst Instance=new A174760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174761
{
public static readonly BigInteger[] Value={ 1L,530L,561799L,595506410L,631236232801L,669109811262650L,709255768702176199L,BigInteger.Parse("751810445714495508290"),BigInteger.Parse("796918363201596536611201"),BigInteger.Parse("844732713183246614312364770"),BigInteger.Parse("895415879055878209574570044999") };
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
public class A174761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174761Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174761.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174761Inst Instance=new A174761Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174762
{
public static readonly BigInteger[] Value={ 1L,1766319049L,6239765965720528801L,BigInteger.Parse("22042834973108102061352541449"),BigInteger.Parse("77869358613928486808166555366140995201"),BigInteger.Parse("275084262906388245923976756042747916825335226249"),BigInteger.Parse("971773147303355325052564141449134520779147876502526039201") };
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
public class A174762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174762Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174762.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174762Inst Instance=new A174762Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174763
{
public static readonly BigInteger[] Value={ 1L,63L,7937L,999999L,125991937L,15873984063L,1999996000001L,251983622016063L,31747936378023937L,3999988000008999999L,BigInteger.Parse("503966740064755975937"),BigInteger.Parse("63495809260159243968063"),BigInteger.Parse("7999968000039999984000001") };
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
public class A174763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174763Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174763.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174763Inst Instance=new A174763Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174764
{
public static readonly long[] Value={ 0L,1L,3L,18L,70L,330L,1386L,6328L,28008L,130140L,603460L,2895816L,14024088L,69786808L,352043160L,1817317440L,9525774016L,50958843408L,276906491568L,1532719442080L,8615750596320L,49260355141536L,285887468809888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174764Inst : IEnumerable<long>
{
public static readonly long[] Value=A174764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174764.Bytes);
public long this[int i]=>Value[i];

public static A174764Inst Instance=new A174764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174765
{
public static readonly BigInteger[] Value={ 0L,39L,13260L,4508361L,1532829480L,521157514839L,177192022215780L,60244766395850361L,BigInteger.Parse("20483043382566906960"),BigInteger.Parse("6964174505306352516039"),BigInteger.Parse("2367798848760777288546300"),BigInteger.Parse("805044644404158971753225961") };
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
public class A174765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174765Inst Instance=new A174765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174766
{
public static readonly BigInteger[] Value={ 0L,42L,16548L,6519870L,2568812232L,1012105499538L,398766998005740L,157113185108762022L,BigInteger.Parse("61902196165854230928"),BigInteger.Parse("24389308176161458223610"),BigInteger.Parse("9609325519211448685871412"),BigInteger.Parse("3786049865261134620775112718") };
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
public class A174766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174766Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174766.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174766Inst Instance=new A174766Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174767
{
public static readonly BigInteger[] Value={ 0L,5L,240L,11515L,552480L,26507525L,1271808720L,61020311035L,2927703120960L,140468729495045L,6739571312641200L,323358954277282555L,15514490233996921440UL,BigInteger.Parse("744372172277574946565"),BigInteger.Parse("35714349779089600513680") };
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
public class A174767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174767Inst Instance=new A174767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174768
{
public static readonly BigInteger[] Value={ 0L,10L,1020L,104030L,10610040L,1082120050L,110365635060L,11256212656070L,1148023325284080L,117087122966320090L,11941738519239365100UL,BigInteger.Parse("1217940241839448920110"),BigInteger.Parse("124217962929104550486120"),BigInteger.Parse("12669014278526824700664130"),BigInteger.Parse("1292115238446807014917255140"),BigInteger.Parse("131783085307295788696859360150") };
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
public class A174768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174768Inst Instance=new A174768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174769
{
public static readonly BigInteger[] Value={ 1L,9801L,192119201L,3765920568201L,73819574785756801L,BigInteger.Parse("1447011301184484245001"),BigInteger.Parse("28364315451998685384752801"),BigInteger.Parse("555997310043066929727440160201"),BigInteger.Parse("10898659243099882504518596635507201") };
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
public class A174769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174769Inst Instance=new A174769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174770
{
public static readonly BigInteger[] Value={ 0L,1820L,35675640L,699313893460L,13707950903927280L,BigInteger.Parse("268703252919468649100"),BigInteger.Parse("5267121150019473555730920"),BigInteger.Parse("103246108513978467719968844740"),BigInteger.Parse("2023830213823884774227355738862560") };
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
public class A174770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174770Inst Instance=new A174770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174771
{
public static readonly BigInteger[] Value={ 0L,273L,829920L,2522956527L,7669787012160L,23316149994009873L,BigInteger.Parse("70881088312003001760"),BigInteger.Parse("215478485152339131340527"),BigInteger.Parse("655054523982022647272200320"),BigInteger.Parse("1991365537426863695368357632273") };
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
public class A174771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174771Inst Instance=new A174771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174772
{
public static readonly BigInteger[] Value={ 0L,4L,184L,8460L,388976L,17884436L,822295080L,37807689244L,1738331410144L,79925437177380L,3674831778749336L,168962336385292076L,7768592641944686160L,BigInteger.Parse("357186299193070271284"),BigInteger.Parse("16422801170239287792904"),BigInteger.Parse("755091667531814168202300"),BigInteger.Parse("34717793905293212449512896") };
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
public class A174772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174772Inst Instance=new A174772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174773
{
public static readonly BigInteger[] Value={ 0L,6L,420L,29394L,2057160L,143971806L,10075969260L,705173876394L,49352095378320L,3453941502606006L,241726553087042100L,16917404774590340994UL,BigInteger.Parse("1183976607668236827480"),BigInteger.Parse("82861445132001987582606") };
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
public class A174773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174773Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174773.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174773Inst Instance=new A174773Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174774
{
public static readonly long[] Value={ 0L,1L,3L,30L,130L,780L,3696L,19768L,97560L,510660L,2603260L,13754136L,72333768L,390339040L,2116922640L,11722194240L,65521880896L,372897624528L,2146502657520L,12558129505120L,74371827119520L,447090649997376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174774Inst : IEnumerable<long>
{
public static readonly long[] Value=A174774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174774.Bytes);
public long this[int i]=>Value[i];

public static A174774Inst Instance=new A174774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174775
{
public static readonly BigInteger[] Value={ 0L,12L,1752L,255780L,37342128L,5451694908L,795910114440L,116197425013332L,16964028141832032L,2476631911282463340L,BigInteger.Parse("361571295019097815608"),BigInteger.Parse("52786932440876998615428"),BigInteger.Parse("7706530565073022700036880") };
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
public class A174775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174775Inst Instance=new A174775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174776
{
public static readonly BigInteger[] Value={ 0L,4L,200L,9996L,499600L,24970004L,1248000600L,62375059996L,3117504999200L,155812874900004L,7787526240001000L,389220499125149996L,BigInteger.Parse("19453237430017498800"),BigInteger.Parse("972272651001749790004"),BigInteger.Parse("48594179312657472001400") };
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
public class A174776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174776Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174776.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174776Inst Instance=new A174776Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174777
{
public static readonly BigInteger[] Value={ 0L,6L,444L,32850L,2430456L,179820894L,13304315700L,984339540906L,72827821711344L,5388274467098550L,398659482743581356L,BigInteger.Parse("29495413448557921794"),BigInteger.Parse("2182261935710542631400"),BigInteger.Parse("161457887829131596801806") };
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
public class A174777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174777Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174777.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174777Inst Instance=new A174777Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174778
{
public static readonly BigInteger[] Value={ 0L,320L,1311360L,5373952960L,22022457918720L,90248027176961600L,BigInteger.Parse("369836393348730718080"),BigInteger.Parse("1515589449695071305730240"),BigInteger.Parse("6210885195014008862151805440"),BigInteger.Parse("25452206013577958622026792962880") };
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
public class A174778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174778Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174778.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174778Inst Instance=new A174778Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174779
{
public static readonly BigInteger[] Value={ 0L,2L,52L,1350L,35048L,909898L,23622300L,613269902L,15921395152L,413343004050L,10730996710148L,278592571459798L,7232675861244600L,187770979820899802L,4874812799482150252L,BigInteger.Parse("126557361806715006750"),BigInteger.Parse("3285616594175108025248") };
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
public class A174779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174779Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174779.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174779Inst Instance=new A174779Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174780
{
public static readonly BigInteger[] Value={ 0L,531L,3697884L,25752063645L,179337367525896L,1248905401698276099L,BigInteger.Parse("8697377038089427227540"),BigInteger.Parse("60568532444349369514312461"),BigInteger.Parse("421799251245071971208244750864"),BigInteger.Parse("2937409925102148763144846930704435"),BigInteger.Parse("20456122296612112741468742817180934476") };
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
public class A174780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A174780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A174780Inst Instance=new A174780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174781
{
public static readonly long[] Value={ 1L,2L,4L,8L,11L,12L,14L,18L,21L,22L,24L,28L,41L,42L,44L,48L,81L,82L,84L,88L,111L,112L,114L,118L,121L,122L,124L,128L,141L,142L,144L,148L,181L,182L,184L,188L,211L,212L,214L,218L,221L,222L,224L,228L,241L,242L,244L,248L,281L,282L,284L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174781Inst : IEnumerable<long>
{
public static readonly long[] Value=A174781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174781.Bytes);
public long this[int i]=>Value[i];

public static A174781Inst Instance=new A174781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174782
{
public static readonly long[] Value={ 0L,1L,3L,54L,250L,1950L,10206L,64288L,350064L,2065500L,11509300L,66905256L,380767608L,2226036904L,12949377000L,76842172800L,457297336576L,2766381692688L,16849247813424L,104116268476000L,64904382495120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174782Inst : IEnumerable<long>
{
public static readonly long[] Value=A174782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174782.Bytes);
public long this[int i]=>Value[i];

public static A174782Inst Instance=new A174782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174783
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,9L,14L,29L,49L,99L,175L,351L,637L,1275L,2353L,4707L,8788L,17577L,33098L,66197L,125476L,250953L,478192L,956385L,1830270L,3660541L,7030570L,14061141L,27088870L,54177741L,104647630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174783Inst : IEnumerable<long>
{
public static readonly long[] Value=A174783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174783.Bytes);
public long this[int i]=>Value[i];

public static A174783Inst Instance=new A174783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174784
{
public static readonly long[] Value={ 0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L,-1L,1L,0L,-1L,-1L,0L,1L,-1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174784Inst : IEnumerable<long>
{
public static readonly long[] Value=A174784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174784.Bytes);
public long this[int i]=>Value[i];

public static A174784Inst Instance=new A174784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174785
{
public static readonly long[] Value={ 1L,2L,-1L,-1L,-5L,1L,1L,8L,-1L,-1L,-11L,1L,1L,14L,-1L,-1L,-17L,1L,1L,20L,-1L,-1L,-23L,1L,1L,26L,-1L,-1L,-29L,1L,1L,32L,-1L,-1L,-35L,1L,1L,38L,-1L,-1L,-41L,1L,1L,44L,-1L,-1L,-47L,1L,1L,50L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174785Inst : IEnumerable<long>
{
public static readonly long[] Value=A174785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174785.Bytes);
public long this[int i]=>Value[i];

public static A174785Inst Instance=new A174785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174786
{
public static readonly long[] Value={ 3L,9L,15L,21L,39L,45L,51L,81L,99L,105L,129L,165L,171L,189L,225L,231L,249L,255L,261L,309L,345L,351L,381L,441L,459L,501L,555L,561L,585L,591L,639L,645L,651L,675L,819L,855L,879L,939L,945L,969L,975L,1011L,1089L,1095L,1101L,1179L,1185L,1215L,1221L,1275L,1281L,1299L,1359L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174786Inst : IEnumerable<long>
{
public static readonly long[] Value=A174786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174786.Bytes);
public long this[int i]=>Value[i];

public static A174786Inst Instance=new A174786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174787
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,4L,4L,6L,7L,9L,9L,13L,13L,15L,17L,21L,21L,25L,25L,29L,31L,33L,33L,43L,44L,46L,48L,52L,52L,58L,58L,66L,68L,70L,72L,85L,85L,87L,89L,99L,99L,105L,105L,109L,113L,115L,115L,139L,140L,144L,146L,150L,150L,160L,162L,172L,174L,176L,176L,198L,198L,200L,204L,220L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174787Inst : IEnumerable<long>
{
public static readonly long[] Value=A174787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174787.Bytes);
public long this[int i]=>Value[i];

public static A174787Inst Instance=new A174787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174788
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,15L,16L,17L,18L,22L,23L,27L,28L,32L,33L,34L,35L,45L,46L,47L,49L,53L,54L,61L,62L,70L,71L,72L,73L,86L,87L,88L,89L,99L,100L,107L,108L,112L,116L,117L,118L,142L,143L,147L,148L,152L,153L,163L,164L,174L,175L,176L,177L,199L,200L,201L,205L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174788Inst : IEnumerable<long>
{
public static readonly long[] Value=A174788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174788.Bytes);
public long this[int i]=>Value[i];

public static A174788Inst Instance=new A174788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174789
{
public static readonly long[] Value={ 1L,2L,2L,6L,7L,1L,24L,32L,8L,120L,178L,61L,3L,720L,1164L,494L,50L,5040L,8748L,4348L,655L,15L,40320L,74304L,41768L,8204L,420L,362880L,704016L,437148L,104272L,8365L,105L,3628800L,7362720L,4965912L,1376864L,149282L,4410L,39916800L,84255840L,60961176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174789Inst : IEnumerable<long>
{
public static readonly long[] Value=A174789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174789.Bytes);
public long this[int i]=>Value[i];

public static A174789Inst Instance=new A174789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174790
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,37L,37L,1L,1L,289L,721L,289L,1L,1L,2401L,10801L,10801L,2401L,1L,1L,21601L,151201L,273601L,151201L,21601L,1L,1L,211681L,2116801L,5997601L,5997601L,2116801L,211681L,1L,1L,2257921L,30481921L,124185601L,194745601L,124185601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174790Inst : IEnumerable<long>
{
public static readonly long[] Value=A174790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174790.Bytes);
public long this[int i]=>Value[i];

public static A174790Inst Instance=new A174790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174791
{
public static readonly long[] Value={ 1L,1L,1L,1L,13L,1L,1L,181L,181L,1L,1L,2401L,9361L,2401L,1L,1L,33601L,361201L,361201L,33601L,1L,1L,514081L,12852001L,34776001L,12852001L,514081L,1L,1L,8678881L,454265281L,2755015201L,2755015201L,454265281L,8678881L,1L,1L,161602561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174791Inst : IEnumerable<long>
{
public static readonly long[] Value=A174791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174791.Bytes);
public long this[int i]=>Value[i];

public static A174791Inst Instance=new A174791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174792
{
public static readonly long[] Value={ 0L,1L,1L,-7L,-15L,33L,145L,-71L,-1119L,-767L,7137L,13625L,-35567L,-138079L,97265L,1099385L,556609L,-7236351L,-12231999L,37865849L,130726193L,-122102751L,-1075051951L,-351058887L,7296407521L,10828871681L,-39894922079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174792Inst : IEnumerable<long>
{
public static readonly long[] Value=A174792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174792.Bytes);
public long this[int i]=>Value[i];

public static A174792Inst Instance=new A174792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174793
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,1L,1L,0L,0L,0L,2L,0L,2L,0L,1L,1L,3L,1L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,2L,0L,2L,0L,2L,2L,2L,0L,1L,1L,3L,1L,3L,1L,3L,3L,3L,1L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,4L,0L,1L,1L,1L,1L,1L,1L,5L,1L,1L,1L,5L,1L,0L,0L,0L,2L,0L,2L,0L,6L,2L,2L,0L,6L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174793Inst : IEnumerable<long>
{
public static readonly long[] Value=A174793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174793.Bytes);
public long this[int i]=>Value[i];

public static A174793Inst Instance=new A174793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174794
{
public static readonly long[] Value={ 0L,1L,5L,17L,45L,97L,181L,305L,477L,705L,997L,1361L,1805L,2337L,2965L,3697L,4541L,5505L,6597L,7825L,9197L,10721L,12405L,14257L,16285L,18497L,20901L,23505L,26317L,29345L,32597L,36081L,39805L,43777L,48005L,52497L,57261L,62305L,67637L,73265L,79197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174794Inst : IEnumerable<long>
{
public static readonly long[] Value=A174794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174794.Bytes);
public long this[int i]=>Value[i];

public static A174794Inst Instance=new A174794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174795
{
public static readonly long[] Value={ 1L,2L,5L,14L,56L,202L,715L,3244L,12945L,49742L,238048L,996158L,3991995L,19676358L,84649176L,347993910L,1747681160L,7656026268L,32018897274L,162900330572L,722787262419L,3060338457400L,15718332812096L,70407433197686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174795Inst : IEnumerable<long>
{
public static readonly long[] Value=A174795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174795.Bytes);
public long this[int i]=>Value[i];

public static A174795Inst Instance=new A174795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174796
{
public static readonly long[] Value={ 1L,2L,7L,30L,143L,728L,3148L,15986L,86009L,478907L,2731365L,13131703L,72135374L,412835191L,2416852480L,14369476066L,72067537808L,409636973141L,2412844770335L,14479410843183L,87964452906330L,451313038006432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174796Inst : IEnumerable<long>
{
public static readonly long[] Value=A174796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174796.Bytes);
public long this[int i]=>Value[i];

public static A174796Inst Instance=new A174796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174797
{
public static readonly long[] Value={ 1L,4L,21L,87L,120L,141L,142L,168L,188L,320L,363L,387L,434L,464L,496L,539L,593L,675L,721L,794L,810L,995L,1032L,1105L,1147L,1166L,1228L,1356L,1391L,1477L,1478L,1498L,1702L,1771L,1790L,1797L,1803L,1818L,1849L,1850L,1881L,1967L,2016L,2039L,2052L,2065L,2091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174797Inst : IEnumerable<long>
{
public static readonly long[] Value=A174797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174797.Bytes);
public long this[int i]=>Value[i];

public static A174797Inst Instance=new A174797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174798
{
public static readonly long[] Value={ 1L,3L,10L,33L,43L,49L,50L,57L,63L,100L,113L,120L,131L,140L,149L,159L,173L,195L,206L,224L,230L,277L,284L,303L,315L,320L,332L,366L,373L,394L,395L,401L,448L,463L,469L,471L,473L,477L,483L,484L,492L,513L,524L,530L,534L,537L,543L,555L,558L,576L,577L,592L,600L,608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174798Inst : IEnumerable<long>
{
public static readonly long[] Value=A174798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174798.Bytes);
public long this[int i]=>Value[i];

public static A174798Inst Instance=new A174798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174799
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,12L,14L,15L,17L,18L,20L,22L,24L,25L,27L,28L,30L,32L,34L,35L,37L,39L,41L,44L,46L,47L,49L,50L,52L,54L,56L,59L,61L,62L,64L,66L,68L,69L,71L,72L,74L,76L,78L,79L,81L,83L,85L,88L,90L,91L,93L,95L,97L,100L,102L,103L,105L,106L,108L,110L,112L,115L,117L,118L,120L,122L,124L,125L,127L,128L,130L,132L,134L,137L,139L,140L,142L,144L,146L,147L,149L,151L,153L,156L,158L,159L,161L,163L,165L,168L,170L,173L,175L,176L,178L,180L,182L,183L,185L,186L,188L,190L,192L,193L,195L,196L,198L,200L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174799Inst : IEnumerable<long>
{
public static readonly long[] Value=A174799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174799.Bytes);
public long this[int i]=>Value[i];

public static A174799Inst Instance=new A174799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174800
{
public static readonly long[] Value={ 0L,1L,4L,9L,10L,11L,14L,19L,20L,22L,28L,30L,33L,40L,41L,44L,49L,50L,55L,60L,66L,70L,77L,80L,82L,88L,90L,91L,94L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,114L,119L,120L,122L,128L,130L,133L,140L,141L,144L,149L,150L,155L,160L,166L,170L,177L,180L,182L,188L,190L,191L,194L,199L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174800Inst : IEnumerable<long>
{
public static readonly long[] Value=A174800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174800.Bytes);
public long this[int i]=>Value[i];

public static A174800Inst Instance=new A174800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174801
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,18L,21L,37L,44L,59L,65L,78L,82L,88L,100L,112L,121L,122L,130L,134L,151L,168L,183L,191L,197L,198L,203L,216L,221L,231L,257L,260L,273L,287L,295L,301L,306L,322L,347L,366L,375L,378L,407L,415L,422L,438L,455L,459L,466L,491L,521L,556L,560L,574L,585L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174801Inst : IEnumerable<long>
{
public static readonly long[] Value=A174801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174801.Bytes);
public long this[int i]=>Value[i];

public static A174801Inst Instance=new A174801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174802
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,5L,5L,4L,1L,1L,8L,9L,8L,5L,1L,1L,13L,17L,14L,12L,6L,1L,1L,21L,31L,27L,22L,17L,7L,1L,1L,34L,57L,53L,41L,34L,23L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174802Inst : IEnumerable<long>
{
public static readonly long[] Value=A174802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174802.Bytes);
public long this[int i]=>Value[i];

public static A174802Inst Instance=new A174802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174803
{
public static readonly long[] Value={ 0L,2L,4L,5L,8L,11L,12L,13L,14L,18L,22L,23L,24L,25L,26L,27L,32L,37L,38L,39L,40L,41L,42L,43L,44L,50L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,72L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,98L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,128L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174803Inst : IEnumerable<long>
{
public static readonly long[] Value=A174803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174803.Bytes);
public long this[int i]=>Value[i];

public static A174803Inst Instance=new A174803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A174804
{
public static readonly long[] Value={ 0L,1L,4L,6L,16L,30L,36L,42L,48L,81L,120L,132L,144L,156L,168L,180L,256L,340L,360L,380L,400L,420L,440L,460L,480L,625L,780L,810L,840L,870L,900L,930L,960L,990L,1020L,1050L,1296L,1554L,1596L,1638L,1680L,1722L,1764L,1806L,1848L,1890L,1932L,1974L,2016L,2401L,2800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A174804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A174804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A174804Inst : IEnumerable<long>
{
public static readonly long[] Value=A174804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A174804.Bytes);
public long this[int i]=>Value[i];

public static A174804Inst Instance=new A174804Inst();

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