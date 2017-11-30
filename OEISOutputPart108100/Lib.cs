using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A142235
{
public static readonly long[] Value={ 79L,571L,653L,1063L,1637L,1801L,2129L,2293L,2539L,2621L,3359L,3769L,3851L,4261L,4507L,4999L,5081L,5573L,5737L,6229L,6311L,6803L,6967L,7213L,7459L,7541L,7951L,8443L,8689L,9181L,10247L,10657L,10739L,10903L,11149L,11887L,11969L,12379L,12953L,13691L,14347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142235Inst : IEnumerable<long>
{
public static readonly long[] Value=A142235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142235.Bytes);
public long this[int i]=>Value[i];

public static A142235Inst Instance=new A142235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142236
{
public static readonly long[] Value={ 367L,449L,613L,859L,941L,1187L,1433L,1597L,2089L,2417L,2663L,2909L,3319L,4057L,4139L,4549L,4877L,5779L,5861L,6271L,6353L,6599L,6763L,7583L,7829L,7993L,8731L,9059L,9551L,10289L,10453L,10781L,11027L,11273L,11437L,11519L,12011L,12421L,12503L,13159L,13241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142236Inst : IEnumerable<long>
{
public static readonly long[] Value=A142236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142236.Bytes);
public long this[int i]=>Value[i];

public static A142236Inst Instance=new A142236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142237
{
public static readonly long[] Value={ 163L,409L,491L,983L,1229L,1721L,2131L,2213L,2377L,2459L,3361L,3607L,3853L,4099L,4591L,4673L,4919L,5657L,5821L,5903L,6067L,7297L,7789L,8117L,8363L,8527L,8609L,9511L,9839L,10331L,10987L,11069L,11807L,11971L,12791L,13037L,13693L,14431L,14759L,14923L,15497L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142237Inst : IEnumerable<long>
{
public static readonly long[] Value=A142237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142237.Bytes);
public long this[int i]=>Value[i];

public static A142237Inst Instance=new A142237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142238
{
public static readonly long[] Value={ 1L,5L,11L,49L,109L,485L,1079L,4801L,10681L,47525L,105731L,470449L,1046629L,4656965L,10360559L,46099201L,102558961L,456335045L,1015229051L,4517251249L,10049731549L,44716177445L,99482086439L,442644523201L,984771132841L,4381729054565L,9748229241971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142238Inst : IEnumerable<long>
{
public static readonly long[] Value=A142238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142238.Bytes);
public long this[int i]=>Value[i];

public static A142238Inst Instance=new A142238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142239
{
public static readonly long[] Value={ 1L,4L,9L,40L,89L,396L,881L,3920L,8721L,38804L,86329L,384120L,854569L,3802396L,8459361L,37639840L,83739041L,372596004L,828931049L,3688320200L,8205571449L,36510605996L,81226783441L,361417739760L,804062262961L,3577666791604L,7959395846169L,35415250176280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142239Inst : IEnumerable<long>
{
public static readonly long[] Value=A142239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142239.Bytes);
public long this[int i]=>Value[i];

public static A142239Inst Instance=new A142239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142240
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,2L,4L,4L,2L,2L,5L,6L,5L,2L,2L,6L,8L,8L,6L,2L,2L,7L,10L,11L,10L,7L,2L,2L,8L,12L,14L,14L,12L,8L,2L,2L,9L,14L,17L,18L,17L,14L,9L,2L,2L,10L,16L,20L,22L,22L,20L,16L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142240Inst : IEnumerable<long>
{
public static readonly long[] Value=A142240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142240.Bytes);
public long this[int i]=>Value[i];

public static A142240Inst Instance=new A142240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142241
{
public static readonly long[] Value={ 14L,38L,62L,86L,110L,134L,158L,182L,206L,230L,254L,278L,302L,326L,350L,374L,398L,422L,446L,470L,494L,518L,542L,566L,590L,614L,638L,662L,686L,710L,734L,758L,782L,806L,830L,854L,878L,902L,926L,950L,974L,998L,1022L,1046L,1070L,1094L,1118L,1142L,1166L,1190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142241Inst : IEnumerable<long>
{
public static readonly long[] Value=A142241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142241.Bytes);
public long this[int i]=>Value[i];

public static A142241Inst Instance=new A142241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142242
{
public static readonly long[] Value={ 2L,2L,0L,2L,0L,0L,-4L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,2L,0L,0L,-4L,0L,-4L,-4L,-12L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,0L,-4L,-4L,-12L,-4L,-12L,-12L,-28L,-4L,-12L,-12L,-28L,-12L,-28L,-28L,-60L,2L,0L,0L,-4L,0L,-4L,-4L,-12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142242Inst : IEnumerable<long>
{
public static readonly long[] Value=A142242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142242.Bytes);
public long this[int i]=>Value[i];

public static A142242Inst Instance=new A142242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142243
{
public static readonly long[] Value={ 1L,2L,2L,6L,8L,6L,20L,36L,30L,20L,70L,160L,168L,112L,70L,252L,700L,900L,720L,420L,252L,924L,3024L,4620L,4400L,2970L,1584L,924L,3432L,12936L,22932L,25480L,20020L,12012L,6006L,3432L,12870L,54912L,110880L,141120L,127400L,87360L,48048L,22880L,12870L,48620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142243Inst : IEnumerable<long>
{
public static readonly long[] Value=A142243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142243.Bytes);
public long this[int i]=>Value[i];

public static A142243Inst Instance=new A142243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142244
{
public static readonly long[] Value={ 23L,107L,149L,191L,233L,317L,359L,401L,443L,569L,653L,821L,863L,947L,1031L,1283L,1367L,1409L,1451L,1493L,1619L,1787L,1871L,1913L,1997L,2039L,2081L,2207L,2333L,2417L,2459L,2543L,2711L,2753L,2837L,2879L,2963L,3089L,3257L,3299L,3467L,3593L,3677L,3719L,3761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142244Inst : IEnumerable<long>
{
public static readonly long[] Value=A142244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142244.Bytes);
public long this[int i]=>Value[i];

public static A142244Inst Instance=new A142244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142245
{
public static readonly long[] Value={ 0L,12L,34L,68L,124L,214L,360L,596L,978L,1596L,2596L,4214L,6832L,11068L,17922L,29012L,46956L,75990L,122968L,198980L,321970L,520972L,842964L,1363958L,2206944L,3570924L,5777890L,9348836L,15126748L,24475606L,39602376L,64078004L,103680402L,167758428L,271438852L,439197302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142245Inst : IEnumerable<long>
{
public static readonly long[] Value=A142245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142245.Bytes);
public long this[int i]=>Value[i];

public static A142245Inst Instance=new A142245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142246
{
public static readonly long[] Value={ 3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,2L,3L,7L,2L,3L,2L,2L,3L,3L,2L,3L,3L,3L,3L,2L,2L,2L,7L,3L,2L,7L,2L,3L,3L,3L,3L,3L,3L,2L,2L,3L,3L,2L,2L,2L,2L,3L,3L,3L,2L,3L,3L,3L,3L,3L,2L,3L,3L,3L,13L,2L,2L,7L,3L,3L,2L,3L,3L,3L,3L,3L,3L,3L,3L,3L,3L,2L,3L,2L,3L,3L,3L,2L,3L,2L,2L,3L,3L,7L,3L,3L,7L,2L,2L,7L,3L,3L,7L,2L,3L,3L,2L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142246Inst : IEnumerable<long>
{
public static readonly long[] Value=A142246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142246.Bytes);
public long this[int i]=>Value[i];

public static A142246Inst Instance=new A142246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142247
{
public static readonly BigInteger[] Value={ 3L,5L,7L,11L,29L,31L,127L,131L,8191L,131071L,524287L,536870909L,2147483647L,2305843009213693951L,BigInteger.Parse("147573952589676412931"),BigInteger.Parse("618970019642690137449562111"),BigInteger.Parse("162259276829213363391578010288127") };
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
public class A142247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142247Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A142247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142247.Bytes);
public BigInteger this[int i]=>Value[i];

public static A142247Inst Instance=new A142247Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142280
{
public static readonly long[] Value={ 31L,461L,547L,719L,977L,1063L,1321L,1493L,1579L,2267L,3041L,3299L,3557L,3643L,4073L,4159L,4933L,5449L,5879L,6481L,6653L,6911L,6997L,8287L,8803L,9319L,9491L,9749L,10007L,10093L,10781L,10867L,11383L,11813L,12071L,12157L,12329L,13103L,13619L,13877L,13963L,14221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142280Inst : IEnumerable<long>
{
public static readonly long[] Value=A142280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142280.Bytes);
public long this[int i]=>Value[i];

public static A142280Inst Instance=new A142280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142281
{
public static readonly long[] Value={ 419L,677L,1021L,1193L,1279L,1451L,1709L,2053L,2311L,2741L,2999L,3257L,3343L,4289L,4547L,5407L,5923L,6353L,6869L,7127L,7213L,7643L,7901L,8761L,8933L,9277L,10223L,10567L,10739L,11083L,12373L,12889L,13147L,13577L,13921L,14437L,14867L,15383L,15641L,15727L,16673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142281Inst : IEnumerable<long>
{
public static readonly long[] Value=A142281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142281.Bytes);
public long this[int i]=>Value[i];

public static A142281Inst Instance=new A142281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142282
{
public static readonly long[] Value={ 463L,1151L,1237L,1409L,1667L,1753L,2011L,2269L,2441L,2699L,2957L,3301L,3559L,3989L,4591L,5021L,5107L,5279L,5623L,5881L,6053L,6311L,6397L,6569L,6827L,7687L,8117L,8461L,8719L,9923L,10009L,10181L,10267L,11213L,11299L,11471L,11987L,12073L,12503L,12589L,13879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142282Inst : IEnumerable<long>
{
public static readonly long[] Value=A142282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142282.Bytes);
public long this[int i]=>Value[i];

public static A142282Inst Instance=new A142282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142283
{
public static readonly long[] Value={ 163L,421L,593L,937L,1109L,1367L,1453L,2141L,2399L,2657L,3001L,3259L,3517L,3947L,4463L,4549L,4721L,5237L,5323L,5581L,5839L,6011L,6269L,6871L,7043L,7129L,7559L,7817L,8161L,8419L,8677L,8849L,9623L,9967L,10139L,11171L,11257L,12203L,12289L,12547L,13063L,13751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142283Inst : IEnumerable<long>
{
public static readonly long[] Value=A142283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142283.Bytes);
public long this[int i]=>Value[i];

public static A142283Inst Instance=new A142283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142284
{
public static readonly long[] Value={ 293L,379L,809L,1153L,1583L,1669L,2099L,2357L,3217L,3389L,3733L,4421L,4507L,4679L,4937L,5023L,5281L,5711L,6571L,6829L,7001L,7517L,7603L,8291L,8377L,8807L,8893L,9151L,9323L,9839L,10613L,10957L,11731L,11903L,12161L,12763L,13451L,13537L,13709L,13967L,14741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142284Inst : IEnumerable<long>
{
public static readonly long[] Value=A142284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142284.Bytes);
public long this[int i]=>Value[i];

public static A142284Inst Instance=new A142284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142285
{
public static readonly long[] Value={ 79L,251L,337L,509L,853L,1283L,1627L,2143L,2659L,2917L,3089L,3347L,3433L,3691L,3863L,4637L,4723L,5153L,5669L,5927L,6271L,6529L,6701L,6959L,7561L,9109L,9281L,9539L,9883L,10141L,10313L,10399L,10657L,11087L,11173L,11689L,12119L,12377L,12721L,12893L,12979L,13151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142285Inst : IEnumerable<long>
{
public static readonly long[] Value=A142285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142285.Bytes);
public long this[int i]=>Value[i];

public static A142285Inst Instance=new A142285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142286
{
public static readonly long[] Value={ 37L,467L,811L,983L,1069L,1327L,1499L,2273L,2531L,2617L,2789L,3391L,3821L,3907L,4079L,4337L,4423L,5197L,6143L,6229L,6659L,6917L,7433L,7691L,7949L,8293L,9067L,9239L,9497L,10099L,10271L,10357L,10529L,11131L,12163L,12421L,13109L,13367L,13711L,13883L,14657L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142286Inst : IEnumerable<long>
{
public static readonly long[] Value=A142286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142286.Bytes);
public long this[int i]=>Value[i];

public static A142286Inst Instance=new A142286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142287
{
public static readonly long[] Value={ 167L,683L,769L,941L,1543L,1801L,1973L,2833L,3607L,3779L,4639L,5413L,5843L,6101L,6359L,6703L,6961L,7219L,7477L,7649L,7907L,7993L,8423L,8681L,9283L,10487L,10831L,11003L,11261L,11519L,11777L,11863L,12379L,12637L,12809L,13411L,13669L,13841L,15131L,15217L,15647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142287Inst : IEnumerable<long>
{
public static readonly long[] Value=A142287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142287.Bytes);
public long this[int i]=>Value[i];

public static A142287Inst Instance=new A142287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142288
{
public static readonly long[] Value={ 211L,383L,641L,727L,1759L,1931L,2017L,2447L,2791L,2963L,3049L,3221L,3307L,3823L,4253L,4339L,4597L,5113L,5801L,6317L,6661L,6833L,7177L,7349L,7607L,7951L,8123L,8209L,8467L,9241L,9413L,9929L,10273L,10531L,10789L,11047L,11821L,12251L,12853L,13627L,13799L,14057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142288Inst : IEnumerable<long>
{
public static readonly long[] Value=A142288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142288.Bytes);
public long this[int i]=>Value[i];

public static A142288Inst Instance=new A142288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142289
{
public static readonly long[] Value={ 83L,599L,857L,1201L,1373L,1459L,1889L,2663L,2749L,4211L,4297L,4813L,5501L,6361L,6619L,6791L,7307L,7393L,7823L,8081L,8167L,8597L,8941L,9199L,9371L,9629L,9887L,9973L,11177L,11779L,12037L,12553L,12983L,13241L,13327L,13499L,13757L,15391L,15649L,15907L,17627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142289Inst : IEnumerable<long>
{
public static readonly long[] Value=A142289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142289.Bytes);
public long this[int i]=>Value[i];

public static A142289Inst Instance=new A142289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142290
{
public static readonly long[] Value={ 41L,127L,557L,643L,1847L,1933L,2621L,2707L,2879L,3137L,3739L,3911L,4513L,4943L,5717L,6491L,6577L,7351L,7523L,7867L,8039L,8297L,8641L,9157L,9587L,9931L,10103L,11393L,11909L,12253L,12511L,12941L,13457L,14489L,14747L,15091L,15263L,15349L,15607L,16381L,16553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142290Inst : IEnumerable<long>
{
public static readonly long[] Value=A142290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142290.Bytes);
public long this[int i]=>Value[i];

public static A142290Inst Instance=new A142290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142291
{
public static readonly long[] Value={ 257L,601L,773L,859L,1031L,1117L,1289L,2063L,2579L,2837L,3181L,3697L,4127L,4643L,4729L,4987L,5417L,5503L,6277L,6449L,6793L,7309L,7481L,8513L,8599L,9029L,9631L,9803L,10061L,10663L,11093L,11351L,11437L,11867L,11953L,12211L,12641L,12899L,13759L,13931L,14447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142291Inst : IEnumerable<long>
{
public static readonly long[] Value=A142291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142291.Bytes);
public long this[int i]=>Value[i];

public static A142291Inst Instance=new A142291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142292
{
public static readonly long[] Value={ 89L,353L,397L,617L,661L,881L,1013L,1277L,1321L,1409L,1453L,2069L,2113L,2333L,2377L,2729L,2861L,3037L,3169L,3257L,3301L,3389L,3433L,3697L,3917L,4049L,4093L,4357L,4621L,4973L,5237L,5281L,5413L,5501L,5897L,6029L,6073L,6337L,6469L,6689L,6733L,6997L,7129L,7349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142292Inst : IEnumerable<long>
{
public static readonly long[] Value=A142292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142292.Bytes);
public long this[int i]=>Value[i];

public static A142292Inst Instance=new A142292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142293
{
public static readonly long[] Value={ 3L,47L,179L,223L,311L,443L,487L,619L,751L,839L,883L,971L,1103L,1279L,1367L,1499L,1543L,2027L,2203L,2423L,2467L,2687L,2731L,2819L,3083L,3259L,3347L,3391L,3919L,4007L,4051L,4139L,4271L,4447L,4799L,4931L,5107L,5503L,5591L,5987L,6163L,6427L,6691L,6779L,6823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142293Inst : IEnumerable<long>
{
public static readonly long[] Value=A142293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142293.Bytes);
public long this[int i]=>Value[i];

public static A142293Inst Instance=new A142293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142294
{
public static readonly long[] Value={ 5L,137L,181L,269L,313L,401L,577L,709L,797L,929L,1061L,1193L,1237L,1721L,2029L,2161L,2293L,2381L,2557L,2689L,2777L,2909L,2953L,3041L,3217L,3613L,3701L,3833L,3877L,4229L,4273L,4493L,4801L,4889L,4933L,5021L,5153L,5197L,5417L,5813L,5857L,6121L,6473L,6737L,6781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142294Inst : IEnumerable<long>
{
public static readonly long[] Value=A142294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142294.Bytes);
public long this[int i]=>Value[i];

public static A142294Inst Instance=new A142294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142295
{
public static readonly long[] Value={ 7L,139L,227L,271L,359L,491L,887L,1019L,1063L,1151L,1283L,1327L,1459L,1723L,1811L,1987L,2207L,2251L,2339L,2383L,2647L,2999L,3307L,3527L,3571L,3659L,3923L,3967L,4099L,4231L,4363L,4451L,4583L,4759L,5023L,5419L,5507L,5639L,5683L,5903L,6079L,6211L,6299L,6343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142295Inst : IEnumerable<long>
{
public static readonly long[] Value=A142295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142295.Bytes);
public long this[int i]=>Value[i];

public static A142295Inst Instance=new A142295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142344
{
public static readonly long[] Value={ 71L,163L,347L,439L,577L,761L,853L,991L,1129L,1451L,1543L,2003L,2141L,2371L,2417L,2647L,2693L,2969L,3061L,3613L,3659L,3797L,3889L,4027L,4073L,4211L,4349L,4441L,4993L,5039L,5407L,5591L,5683L,5821L,5867L,6143L,6373L,6833L,6971L,7109L,7247L,7477L,7523L,7753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142344Inst : IEnumerable<long>
{
public static readonly long[] Value=A142344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142344.Bytes);
public long this[int i]=>Value[i];

public static A142344Inst Instance=new A142344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142345
{
public static readonly long[] Value={ 3L,23L,29L,37L,41L,47L,61L,67L,83L,103L,113L,149L,157L,167L,193L,269L,277L,281L,331L,347L,439L,521L,569L,593L,677L,733L,823L,827L,877L,911L,1019L,1061L,1097L,1117L,1153L,1217L,1259L,1289L,1381L,1433L,1447L,1489L,1499L,1553L,1607L,1637L,1693L,1699L,1733L,1801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142345Inst : IEnumerable<long>
{
public static readonly long[] Value=A142345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142345.Bytes);
public long this[int i]=>Value[i];

public static A142345Inst Instance=new A142345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142346
{
public static readonly long[] Value={ 2L,11L,47L,73L,131L,151L,173L,181L,227L,239L,271L,307L,367L,379L,383L,461L,523L,643L,661L,677L,743L,797L,991L,997L,1021L,1063L,1091L,1307L,1459L,1567L,1637L,1723L,1811L,1831L,1951L,1987L,1999L,2027L,2111L,2251L,2273L,2297L,2543L,2609L,2647L,2699L,2707L,2801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142346Inst : IEnumerable<long>
{
public static readonly long[] Value=A142346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142346.Bytes);
public long this[int i]=>Value[i];

public static A142346Inst Instance=new A142346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142347
{
public static readonly long[] Value={ 1L,22L,32L,42L,58L,66L,88L,99L,104L,114L,119L,144L,166L,196L,200L,214L,221L,253L,279L,287L,291L,300L,314L,326L,345L,352L,372L,400L,407L,418L,426L,442L,454L,472L,482L,502L,506L,513L,538L,556L,566L,573L,580L,590L,602L,612L,618L,625L,630L,669L,698L,708L,717L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142347Inst : IEnumerable<long>
{
public static readonly long[] Value=A142347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142347.Bytes);
public long this[int i]=>Value[i];

public static A142347Inst Instance=new A142347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142348
{
public static readonly long[] Value={ 2L,13L,19L,31L,37L,47L,61L,103L,137L,149L,293L,313L,349L,397L,421L,439L,463L,491L,587L,727L,751L,863L,929L,1049L,1153L,1187L,1229L,1289L,1297L,1361L,1427L,1483L,1493L,1553L,1571L,1601L,1741L,1787L,1847L,1867L,1933L,1997L,2027L,2069L,2131L,2239L,2389L,2411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142348Inst : IEnumerable<long>
{
public static readonly long[] Value=A142348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142348.Bytes);
public long this[int i]=>Value[i];

public static A142348Inst Instance=new A142348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142349
{
public static readonly long[] Value={ 2L,3L,5L,7L,5L,5L,7L,11L,17L,23L,37L,41L,43L,29L,31L,61L,41L,43L,67L,71L,73L,79L,53L,83L,89L,97L,67L,107L,109L,113L,131L,67L,137L,139L,149L,151L,101L,163L,109L,167L,113L,173L,181L,191L,193L,197L,199L,223L,229L,233L,157L,239L,241L,163L,257L,173L,263L,181L,281L,193L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142349Inst : IEnumerable<long>
{
public static readonly long[] Value=A142349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142349.Bytes);
public long this[int i]=>Value[i];

public static A142349Inst Instance=new A142349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142350
{
public static readonly long[] Value={ 1L,4L,8L,6L,8L,14L,10L,18L,20L,21L,15L,24L,25L,27L,28L,30L,21L,32L,22L,34L,24L,25L,26L,42L,44L,45L,46L,48L,49L,50L,34L,52L,54L,55L,56L,38L,58L,40L,42L,64L,65L,66L,68L,46L,48L,75L,51L,77L,52L,80L,81L,82L,84L,86L,87L,88L,90L,91L,92L,93L,63L,95L,96L,98L,66L,100L,102L,104L,70L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142350Inst : IEnumerable<long>
{
public static readonly long[] Value=A142350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142350.Bytes);
public long this[int i]=>Value[i];

public static A142350Inst Instance=new A142350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142351
{
public static readonly long[] Value={ 3L,13L,11L,17L,29L,31L,23L,41L,43L,53L,61L,41L,43L,67L,47L,71L,73L,79L,83L,67L,101L,107L,109L,113L,79L,137L,139L,97L,149L,101L,157L,107L,167L,173L,179L,127L,191L,193L,197L,199L,139L,211L,223L,151L,227L,229L,241L,167L,251L,179L,269L,271L,277L,281L,283L,307L,311L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142351Inst : IEnumerable<long>
{
public static readonly long[] Value=A142351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142351.Bytes);
public long this[int i]=>Value[i];

public static A142351Inst Instance=new A142351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142352
{
public static readonly long[] Value={ 2L,5L,7L,11L,17L,23L,19L,31L,23L,43L,59L,31L,67L,47L,71L,73L,79L,83L,59L,89L,53L,107L,109L,113L,127L,131L,89L,137L,139L,97L,149L,103L,157L,163L,167L,173L,179L,181L,127L,191L,131L,197L,199L,223L,151L,227L,22L,9L,233L,239L,241L,163L,263L,271L,181L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142352Inst : IEnumerable<long>
{
public static readonly long[] Value=A142352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142352.Bytes);
public long this[int i]=>Value[i];

public static A142352Inst Instance=new A142352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142353
{
public static readonly long[] Value={ 2L,5L,5L,7L,11L,11L,17L,23L,17L,13L,19L,31L,37L,19L,41L,43L,47L,59L,61L,43L,71L,73L,79L,83L,61L,47L,97L,103L,73L,113L,83L,127L,131L,137L,149L,151L,157L,163L,167L,173L,191L,193L,211L,149L,227L,229L,157L,239L,241L,167L,257L,269L,271L,281L,293L,197L,307L,311L,211L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142353Inst : IEnumerable<long>
{
public static readonly long[] Value=A142353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142353.Bytes);
public long this[int i]=>Value[i];

public static A142353Inst Instance=new A142353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142354
{
public static readonly long[] Value={ 0L,0L,2L,0L,6L,6L,0L,2L,0L,4L,0L,0L,8L,4L,8L,0L,0L,0L,0L,0L,0L,0L,2L,6L,2L,0L,0L,2L,0L,6L,6L,0L,8L,0L,6L,6L,0L,2L,0L,4L,4L,0L,2L,0L,4L,0L,0L,8L,4L,8L,0L,0L,8L,4L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142354Inst : IEnumerable<long>
{
public static readonly long[] Value=A142354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142354.Bytes);
public long this[int i]=>Value[i];

public static A142354Inst Instance=new A142354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142355
{
public static readonly long[] Value={ 2L,331L,613L,1459L,1553L,1741L,2399L,2963L,3433L,3527L,4091L,4373L,4561L,4937L,5407L,5501L,5689L,5783L,6911L,7193L,7757L,8039L,10859L,11047L,11329L,11423L,11987L,12269L,12457L,12739L,13397L,13679L,14149L,14243L,14431L,14713L,15277L,15559L,16217L,17627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142355Inst : IEnumerable<long>
{
public static readonly long[] Value=A142355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142355.Bytes);
public long this[int i]=>Value[i];

public static A142355Inst Instance=new A142355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142356
{
public static readonly long[] Value={ 239L,521L,709L,991L,1367L,1931L,2213L,2683L,2777L,3529L,3623L,4093L,4657L,4751L,5503L,5879L,6067L,7477L,7759L,7853L,8699L,8887L,9733L,10391L,10861L,11519L,11801L,12553L,12647L,13399L,13681L,13963L,14057L,14621L,15091L,15373L,15467L,15749L,15937L,17159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142356Inst : IEnumerable<long>
{
public static readonly long[] Value=A142356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142356.Bytes);
public long this[int i]=>Value[i];

public static A142356Inst Instance=new A142356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142357
{
public static readonly long[] Value={ 53L,241L,523L,617L,1087L,1181L,1933L,2027L,2309L,2591L,3061L,3343L,3719L,3907L,4001L,4283L,5693L,5881L,6163L,6257L,7103L,7573L,7949L,8231L,8419L,8513L,9547L,9829L,9923L,10111L,10487L,10957L,11239L,11897L,12743L,14153L,14341L,14717L,15187L,16033L,16127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142357Inst : IEnumerable<long>
{
public static readonly long[] Value=A142357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142357.Bytes);
public long this[int i]=>Value[i];

public static A142357Inst Instance=new A142357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142358
{
public static readonly long[] Value={ 7L,101L,383L,571L,853L,947L,1229L,1511L,1699L,2357L,3109L,3203L,3391L,3673L,3767L,4049L,4519L,4801L,5647L,5741L,6211L,6869L,7057L,7151L,7433L,7621L,8467L,9689L,10159L,10253L,10723L,11287L,12227L,12697L,12791L,12979L,14107L,14389L,15329L,16363L,16927L,17021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142358Inst : IEnumerable<long>
{
public static readonly long[] Value=A142358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142358.Bytes);
public long this[int i]=>Value[i];

public static A142358Inst Instance=new A142358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142359
{
public static readonly long[] Value={ 149L,337L,431L,619L,1277L,1559L,1747L,2029L,2311L,2593L,2687L,2969L,3251L,3533L,4003L,4567L,4943L,5413L,5507L,6353L,6823L,6917L,7481L,7669L,7951L,8233L,8609L,9173L,9643L,10301L,10771L,11617L,13121L,13309L,13591L,13873L,13967L,14249L,14437L,14813L,15377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142359Inst : IEnumerable<long>
{
public static readonly long[] Value=A142359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142359.Bytes);
public long this[int i]=>Value[i];

public static A142359Inst Instance=new A142359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142440
{
public static readonly long[] Value={ 31L,227L,521L,619L,1109L,1697L,2089L,2383L,2579L,2677L,2971L,3167L,3461L,3559L,3853L,4049L,4441L,4637L,4931L,5323L,5519L,5813L,6793L,7283L,7577L,8263L,8753L,9341L,9439L,9733L,9929L,10223L,10321L,10909L,11399L,11497L,11987L,12281L,12379L,12967L,13163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142440Inst : IEnumerable<long>
{
public static readonly long[] Value=A142440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142440.Bytes);
public long this[int i]=>Value[i];

public static A142440Inst Instance=new A142440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142441
{
public static readonly long[] Value={ 179L,277L,571L,1061L,1453L,1747L,2237L,2531L,3119L,3217L,3413L,3511L,4001L,4099L,5471L,5569L,6353L,6451L,7039L,7333L,7529L,7823L,8117L,8803L,8999L,9293L,9391L,9587L,10273L,10567L,10861L,11057L,11351L,11743L,11939L,12037L,12527L,12821L,12919L,13997L,14389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142441Inst : IEnumerable<long>
{
public static readonly long[] Value=A142441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142441.Bytes);
public long this[int i]=>Value[i];

public static A142441Inst Instance=new A142441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142442
{
public static readonly long[] Value={ 131L,229L,523L,719L,1013L,1307L,1601L,1699L,1993L,2287L,2777L,3169L,3463L,3659L,4051L,4639L,4933L,5227L,5521L,5717L,6011L,6599L,6991L,7187L,7481L,7873L,8069L,8167L,8363L,8461L,8951L,9049L,9343L,9539L,9833L,9931L,11597L,12479L,12577L,14243L,14341L,14537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142442Inst : IEnumerable<long>
{
public static readonly long[] Value=A142442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142442.Bytes);
public long this[int i]=>Value[i];

public static A142442Inst Instance=new A142442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142443
{
public static readonly long[] Value={ 83L,181L,769L,1063L,1259L,1553L,1847L,2141L,2239L,2729L,3023L,3121L,3709L,4003L,4297L,4493L,4591L,4787L,5081L,5179L,5669L,6257L,6551L,7237L,7433L,7727L,8609L,8707L,9001L,9491L,9883L,10079L,10177L,10667L,11059L,11353L,11549L,11941L,12823L,13313L,13411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142443Inst : IEnumerable<long>
{
public static readonly long[] Value=A142443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142443.Bytes);
public long this[int i]=>Value[i];

public static A142443Inst Instance=new A142443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142444
{
public static readonly long[] Value={ 281L,379L,673L,967L,1163L,2143L,2339L,2437L,2633L,2731L,2927L,3221L,3319L,3613L,3907L,4201L,4397L,4691L,4789L,5279L,5573L,5867L,6553L,7043L,8219L,8317L,8513L,8807L,9199L,9689L,9787L,11159L,11257L,11551L,12041L,12433L,12923L,13217L,13903L,14197L,15373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142444Inst : IEnumerable<long>
{
public static readonly long[] Value=A142444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142444.Bytes);
public long this[int i]=>Value[i];

public static A142444Inst Instance=new A142444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142445
{
public static readonly long[] Value={ 37L,233L,331L,821L,919L,1213L,1409L,1801L,1997L,2389L,2683L,2879L,3271L,3467L,3761L,4153L,4349L,4447L,4643L,4937L,5231L,5623L,6113L,6211L,6701L,7583L,7681L,7877L,8171L,8269L,8563L,9151L,9739L,11503L,11699L,12973L,13267L,13463L,13757L,14051L,14149L,14639L,14737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142445Inst : IEnumerable<long>
{
public static readonly long[] Value=A142445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142445.Bytes);
public long this[int i]=>Value[i];

public static A142445Inst Instance=new A142445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142446
{
public static readonly long[] Value={ 283L,479L,577L,773L,1361L,1459L,1753L,1949L,2243L,2341L,3517L,4007L,4889L,4987L,5281L,5477L,5869L,6163L,6359L,6653L,6947L,7829L,7927L,8123L,8221L,9103L,9397L,9887L,10181L,10867L,11161L,12043L,12239L,13121L,13219L,13513L,13709L,13807L,14591L,14983L,15277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142446Inst : IEnumerable<long>
{
public static readonly long[] Value=A142446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142446.Bytes);
public long this[int i]=>Value[i];

public static A142446Inst Instance=new A142446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142447
{
public static readonly long[] Value={ 137L,431L,823L,1019L,1117L,1607L,1901L,1999L,2293L,3371L,3469L,4057L,4253L,4547L,5233L,5527L,5821L,6311L,6703L,6899L,6997L,7193L,7487L,7879L,8369L,8467L,8663L,8761L,9349L,9643L,9839L,10133L,10427L,11113L,11701L,11897L,12289L,12583L,13171L,13367L,13759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142447Inst : IEnumerable<long>
{
public static readonly long[] Value=A142447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142447.Bytes);
public long this[int i]=>Value[i];

public static A142447Inst Instance=new A142447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142448
{
public static readonly long[] Value={ 89L,383L,677L,971L,1069L,1559L,1657L,1951L,2441L,2539L,2833L,3323L,3617L,3911L,4597L,4793L,5087L,5381L,5479L,6067L,6263L,6361L,6949L,7243L,7537L,8419L,8713L,9007L,9203L,9497L,9791L,10477L,10771L,11261L,12143L,12241L,12437L,12829L,13417L,13613L,13711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142448Inst : IEnumerable<long>
{
public static readonly long[] Value=A142448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142448.Bytes);
public long this[int i]=>Value[i];

public static A142448Inst Instance=new A142448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142449
{
public static readonly long[] Value={ 41L,139L,433L,727L,1021L,1217L,1511L,1609L,2099L,2393L,2687L,3079L,3373L,3863L,4157L,4451L,4549L,5039L,5333L,5431L,6607L,6803L,7489L,8273L,8861L,9547L,9743L,10037L,10331L,10429L,10723L,11213L,11311L,11801L,12487L,12781L,13859L,14153L,14251L,14447L,14741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142449Inst : IEnumerable<long>
{
public static readonly long[] Value=A142449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142449.Bytes);
public long this[int i]=>Value[i];

public static A142449Inst Instance=new A142449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142450
{
public static readonly long[] Value={ 43L,239L,337L,631L,827L,1709L,2003L,2297L,2591L,2689L,3571L,3767L,4159L,4649L,4943L,5237L,5531L,5923L,6217L,7001L,7393L,7589L,7687L,7883L,8863L,9059L,9157L,9941L,10039L,10333L,10529L,10627L,11117L,11411L,12097L,12391L,12979L,13469L,13567L,13763L,14057L,14449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142450Inst : IEnumerable<long>
{
public static readonly long[] Value=A142450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142450.Bytes);
public long this[int i]=>Value[i];

public static A142450Inst Instance=new A142450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142451
{
public static readonly long[] Value={ 191L,877L,1171L,1367L,1759L,2053L,2347L,2543L,2837L,3229L,3719L,4013L,4111L,4993L,5189L,5483L,5581L,6659L,7247L,7541L,7639L,7933L,8423L,8521L,9011L,9109L,9403L,9697L,11069L,11657L,12049L,12343L,12539L,12637L,13127L,13421L,14009L,14107L,14303L,14401L,14891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142451Inst : IEnumerable<long>
{
public static readonly long[] Value=A142451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142451.Bytes);
public long this[int i]=>Value[i];

public static A142451Inst Instance=new A142451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142452
{
public static readonly long[] Value={ 241L,829L,1123L,1319L,1613L,1907L,2593L,2789L,2887L,3083L,3181L,3671L,3769L,4259L,4357L,4651L,5827L,6121L,6317L,6709L,7297L,7591L,8081L,8179L,8669L,8963L,9257L,9551L,9649L,10139L,10433L,10531L,11119L,11903L,12197L,12491L,12589L,13177L,14549L,14843L,15137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142452Inst : IEnumerable<long>
{
public static readonly long[] Value=A142452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142452.Bytes);
public long this[int i]=>Value[i];

public static A142452Inst Instance=new A142452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142453
{
public static readonly long[] Value={ 193L,389L,487L,683L,977L,1663L,2153L,2251L,2447L,2741L,3329L,3623L,3917L,4211L,4603L,4799L,5387L,5779L,6073L,6269L,6367L,6563L,6661L,6857L,7151L,8719L,9013L,9209L,9601L,10091L,10973L,11071L,11953L,12149L,12541L,13619L,13913L,14011L,14207L,15187L,15383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142453Inst : IEnumerable<long>
{
public static readonly long[] Value=A142453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142453.Bytes);
public long this[int i]=>Value[i];

public static A142453Inst Instance=new A142453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142454
{
public static readonly long[] Value={ 47L,439L,733L,929L,1223L,1321L,1811L,2203L,2399L,2693L,2791L,3673L,3967L,4261L,4457L,4751L,5437L,5927L,6221L,6907L,7103L,7691L,7789L,8377L,8573L,8867L,9161L,9749L,10141L,10337L,10631L,10729L,11317L,11807L,12101L,12689L,12983L,13669L,13963L,14159L,14551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142454Inst : IEnumerable<long>
{
public static readonly long[] Value=A142454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142454.Bytes);
public long this[int i]=>Value[i];

public static A142454Inst Instance=new A142454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142455
{
public static readonly long[] Value={ 97L,293L,587L,881L,1567L,1861L,2351L,2939L,3037L,3331L,3527L,3821L,3919L,4409L,4507L,4703L,4801L,5683L,5879L,6173L,6271L,6761L,7349L,7643L,7741L,7937L,8231L,8329L,8623L,8819L,10093L,10289L,11171L,12347L,12641L,12739L,13033L,13229L,13327L,13523L,14503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142455Inst : IEnumerable<long>
{
public static readonly long[] Value=A142455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142455.Bytes);
public long this[int i]=>Value[i];

public static A142455Inst Instance=new A142455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142520
{
public static readonly long[] Value={ 79L,131L,443L,547L,599L,859L,911L,1171L,1223L,1327L,1483L,1847L,1951L,2003L,2731L,2887L,2939L,3251L,3407L,3511L,3719L,3823L,4447L,4603L,4759L,4967L,5227L,5279L,5591L,5851L,5903L,6007L,6163L,7151L,7307L,7411L,7723L,7879L,8087L,8191L,8243L,8867L,8971L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142520Inst : IEnumerable<long>
{
public static readonly long[] Value=A142520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142520.Bytes);
public long this[int i]=>Value[i];

public static A142520Inst Instance=new A142520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142521
{
public static readonly long[] Value={ 29L,601L,653L,757L,809L,1069L,1277L,1381L,1433L,1693L,1901L,2161L,2213L,2473L,2837L,3253L,3461L,3617L,3877L,3929L,4241L,4397L,4657L,4813L,4969L,5021L,5281L,5333L,5437L,5749L,5801L,6113L,6217L,6269L,6373L,6529L,6581L,6737L,6841L,6997L,7309L,7517L,7621L,7673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142521Inst : IEnumerable<long>
{
public static readonly long[] Value=A142521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142521.Bytes);
public long this[int i]=>Value[i];

public static A142521Inst Instance=new A142521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142522
{
public static readonly long[] Value={ 31L,83L,239L,499L,811L,863L,967L,1019L,1123L,1279L,1487L,1747L,2111L,2267L,2371L,2423L,2579L,2683L,3203L,3307L,3359L,3463L,3671L,3931L,4139L,4243L,4451L,4919L,5023L,5179L,5231L,5387L,5647L,6011L,6271L,6323L,6427L,6791L,6947L,7103L,7207L,7727L,7883L,8039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142522Inst : IEnumerable<long>
{
public static readonly long[] Value=A142522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142522.Bytes);
public long this[int i]=>Value[i];

public static A142522Inst Instance=new A142522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142523
{
public static readonly long[] Value={ 137L,241L,293L,397L,449L,709L,761L,1021L,1229L,1489L,1697L,1801L,2113L,2269L,2477L,2633L,2789L,3049L,3257L,3361L,3413L,3517L,3673L,3881L,4297L,4349L,4817L,4973L,5077L,5233L,5441L,5701L,5857L,6221L,6481L,6637L,6689L,6793L,6949L,7001L,7417L,7573L,7937L,8093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142523Inst : IEnumerable<long>
{
public static readonly long[] Value=A142523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142523.Bytes);
public long this[int i]=>Value[i];

public static A142523Inst Instance=new A142523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142524
{
public static readonly long[] Value={ 139L,191L,347L,503L,607L,659L,919L,971L,1231L,1283L,1439L,1543L,1699L,1907L,2011L,2063L,2531L,2687L,2791L,2843L,2999L,3259L,3467L,3571L,3623L,3727L,3779L,4091L,4507L,4663L,4871L,5443L,5651L,5807L,6067L,6379L,6691L,6899L,7159L,7211L,7523L,8147L,8563L,8719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142524Inst : IEnumerable<long>
{
public static readonly long[] Value=A142524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142524.Bytes);
public long this[int i]=>Value[i];

public static A142524Inst Instance=new A142524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142525
{
public static readonly long[] Value={ 37L,89L,193L,349L,401L,557L,661L,1129L,1181L,1493L,1597L,1753L,2221L,2273L,2377L,2689L,2741L,2897L,3001L,3209L,3313L,3469L,3677L,3833L,3989L,4093L,4457L,4561L,5081L,5237L,5393L,5653L,5861L,6121L,6173L,6277L,6329L,7057L,7109L,7213L,7369L,7577L,7681L,7993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142525Inst : IEnumerable<long>
{
public static readonly long[] Value=A142525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142525.Bytes);
public long this[int i]=>Value[i];

public static A142525Inst Instance=new A142525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142526
{
public static readonly long[] Value={ 41L,197L,353L,457L,509L,613L,769L,821L,977L,1237L,1289L,1549L,1601L,1861L,1913L,2017L,2069L,2381L,2693L,2797L,2953L,3109L,3733L,3889L,4201L,4253L,4357L,4409L,4513L,4721L,4877L,5189L,5449L,5501L,5657L,5813L,6073L,6229L,7321L,7477L,7529L,7789L,7841L,8101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142526Inst : IEnumerable<long>
{
public static readonly long[] Value=A142526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142526.Bytes);
public long this[int i]=>Value[i];

public static A142526Inst Instance=new A142526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142527
{
public static readonly long[] Value={ 43L,199L,251L,563L,719L,823L,1031L,1187L,1291L,1447L,1499L,1759L,1811L,2383L,2539L,2591L,2851L,2903L,3163L,3319L,3371L,3527L,3631L,3943L,4099L,4463L,4567L,4723L,4931L,5087L,5347L,5399L,5503L,5659L,5711L,5867L,6491L,6803L,6907L,6959L,7219L,7583L,7687L,8311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142527Inst : IEnumerable<long>
{
public static readonly long[] Value=A142527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142527.Bytes);
public long this[int i]=>Value[i];

public static A142527Inst Instance=new A142527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142528
{
public static readonly long[] Value={ 97L,149L,409L,461L,617L,773L,877L,929L,1033L,1553L,1657L,1709L,2281L,2333L,2437L,2593L,2749L,2801L,2957L,3061L,3217L,3373L,3529L,3581L,4049L,4153L,4517L,4621L,4673L,4933L,5297L,5557L,5869L,6337L,6389L,6701L,6857L,6961L,7013L,7481L,7741L,7793L,7949L,8053L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142528Inst : IEnumerable<long>
{
public static readonly long[] Value=A142528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142528.Bytes);
public long this[int i]=>Value[i];

public static A142528Inst Instance=new A142528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142529
{
public static readonly long[] Value={ 47L,151L,307L,359L,463L,619L,827L,983L,1087L,1399L,1451L,1607L,1867L,2179L,2543L,2647L,2699L,2803L,3011L,3167L,3271L,3323L,3583L,3739L,3947L,4051L,4259L,4363L,4519L,4831L,4987L,5039L,5351L,5507L,5923L,6079L,6131L,6287L,6547L,6599L,6703L,6911L,7639L,7691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142529Inst : IEnumerable<long>
{
public static readonly long[] Value=A142529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142529.Bytes);
public long this[int i]=>Value[i];

public static A142529Inst Instance=new A142529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142530
{
public static readonly long[] Value={ 101L,257L,569L,673L,829L,881L,1193L,1297L,1453L,1609L,1973L,2129L,2389L,2441L,2753L,2857L,2909L,3169L,3221L,3533L,3637L,3793L,4001L,4157L,4261L,4729L,4937L,5197L,5717L,5821L,6029L,6133L,6653L,7069L,7121L,7433L,7537L,7589L,7901L,8161L,8317L,8369L,8629L,8681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142530Inst : IEnumerable<long>
{
public static readonly long[] Value=A142530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142530.Bytes);
public long this[int i]=>Value[i];

public static A142530Inst Instance=new A142530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142531
{
public static readonly long[] Value={ 103L,311L,467L,571L,727L,883L,1039L,1091L,1559L,1663L,1871L,2027L,2131L,2287L,2339L,2963L,3067L,3119L,3691L,3847L,4003L,4159L,4211L,4523L,4679L,4783L,5147L,5303L,5407L,5563L,5927L,6343L,6551L,6863L,6967L,7019L,7331L,7487L,7591L,7643L,8059L,8111L,8423L,8527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142531Inst : IEnumerable<long>
{
public static readonly long[] Value=A142531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142531.Bytes);
public long this[int i]=>Value[i];

public static A142531Inst Instance=new A142531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142532
{
public static readonly long[] Value={ 2L,373L,479L,691L,797L,1009L,1327L,1433L,2069L,2281L,2917L,3023L,3659L,4507L,4931L,5779L,6203L,6521L,6733L,7369L,7687L,7793L,8111L,8429L,8641L,8747L,9277L,10337L,10867L,10973L,11503L,11821L,11927L,12457L,13093L,13411L,13729L,14153L,14683L,15107L,15319L,16061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142532Inst : IEnumerable<long>
{
public static readonly long[] Value=A142532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142532.Bytes);
public long this[int i]=>Value[i];

public static A142532Inst Instance=new A142532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142533
{
public static readonly long[] Value={ 3L,109L,1063L,1381L,1487L,1699L,2017L,2441L,2971L,3607L,4243L,4349L,4561L,5197L,5303L,5939L,6151L,6257L,6469L,7211L,7529L,7741L,8059L,8377L,9013L,9437L,9649L,9967L,10391L,10709L,11027L,11239L,11981L,12511L,12829L,13147L,14207L,14419L,14737L,14843L,15161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142533Inst : IEnumerable<long>
{
public static readonly long[] Value=A142533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142533.Bytes);
public long this[int i]=>Value[i];

public static A142533Inst Instance=new A142533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142534
{
public static readonly long[] Value={ 163L,269L,587L,1117L,1223L,1753L,2389L,2707L,3343L,3449L,3767L,4297L,4721L,4933L,5039L,5569L,6311L,6841L,6947L,7159L,7477L,7583L,7901L,8219L,8431L,8537L,9067L,9173L,9491L,10657L,11399L,11717L,12671L,14897L,15427L,16063L,16381L,16487L,16699L,17123L,17971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142534Inst : IEnumerable<long>
{
public static readonly long[] Value=A142534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142534.Bytes);
public long this[int i]=>Value[i];

public static A142534Inst Instance=new A142534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142535
{
public static readonly long[] Value={ 5L,641L,853L,1171L,1277L,1489L,1913L,2549L,3079L,3821L,4139L,4457L,4987L,5623L,6047L,6577L,7001L,7213L,8167L,8273L,8803L,9227L,9439L,10181L,10499L,10711L,12301L,12619L,13043L,13679L,13997L,14633L,14951L,15269L,16223L,17389L,17707L,18131L,18661L,18979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142535Inst : IEnumerable<long>
{
public static readonly long[] Value=A142535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142535.Bytes);
public long this[int i]=>Value[i];

public static A142535Inst Instance=new A142535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142600
{
public static readonly long[] Value={ 3L,45L,6L,165L,63L,357L,30L,621L,195L,957L,72L,1365L,399L,1845L,132L,2397L,675L,3021L,210L,3717L,1023L,4485L,306L,5325L,1443L,6237L,420L,7221L,1935L,8277L,552L,9405L,2499L,10605L,702L,11877L,3135L,13221L,870L,14637L,3843L,16125L,1056L,17685L,4623L,19317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142600Inst : IEnumerable<long>
{
public static readonly long[] Value=A142600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142600.Bytes);
public long this[int i]=>Value[i];

public static A142600Inst Instance=new A142600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142601
{
public static readonly long[] Value={ 331L,661L,881L,991L,1321L,1871L,2311L,2531L,2861L,2971L,3191L,3301L,3631L,3851L,4621L,4951L,5171L,5281L,5501L,6271L,6491L,7151L,7481L,7591L,8581L,9241L,9461L,9791L,9901L,10781L,10891L,11551L,12101L,12211L,12541L,13421L,13751L,14081L,14411L,14741L,14851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142601Inst : IEnumerable<long>
{
public static readonly long[] Value=A142601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142601.Bytes);
public long this[int i]=>Value[i];

public static A142601Inst Instance=new A142601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142602
{
public static readonly long[] Value={ 2L,167L,277L,607L,827L,937L,1487L,1597L,2477L,2917L,3137L,3467L,3797L,3907L,4127L,4457L,4567L,4787L,5227L,5557L,6217L,6547L,7207L,7537L,7757L,7867L,8087L,8527L,8747L,9187L,10067L,10177L,10837L,11057L,11497L,11717L,11827L,12157L,12377L,12487L,13037L,13147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142602Inst : IEnumerable<long>
{
public static readonly long[] Value=A142602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142602.Bytes);
public long this[int i]=>Value[i];

public static A142602Inst Instance=new A142602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142603
{
public static readonly long[] Value={ 3L,113L,223L,443L,773L,883L,1103L,1213L,1433L,1543L,1873L,2203L,2423L,2753L,3083L,3413L,3853L,4073L,4513L,4733L,5393L,5503L,6053L,6163L,6823L,7043L,7703L,8363L,8693L,8803L,9133L,9463L,10343L,10453L,11003L,11113L,11443L,12323L,12433L,12653L,12763L,12983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142603Inst : IEnumerable<long>
{
public static readonly long[] Value=A142603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142603.Bytes);
public long this[int i]=>Value[i];

public static A142603Inst Instance=new A142603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142604
{
public static readonly long[] Value={ 59L,389L,499L,719L,829L,1049L,1489L,1709L,2039L,2699L,3359L,3469L,4019L,4129L,4349L,4679L,4789L,5009L,5119L,5449L,5669L,5779L,6329L,6659L,7649L,7759L,8089L,8419L,8969L,9629L,9739L,10069L,10289L,10399L,10729L,10949L,11059L,11279L,11719L,11939L,12049L,12269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142604Inst : IEnumerable<long>
{
public static readonly long[] Value=A142604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142604.Bytes);
public long this[int i]=>Value[i];

public static A142604Inst Instance=new A142604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142605
{
public static readonly long[] Value={ 61L,281L,941L,1051L,1381L,1601L,1931L,2371L,2591L,3251L,3361L,3581L,3691L,3911L,4021L,4241L,5011L,5231L,6221L,6551L,6661L,6991L,7211L,7321L,7541L,8311L,8641L,8861L,8971L,9521L,9631L,9851L,10181L,11171L,11831L,11941L,12161L,12491L,12601L,12821L,13151L,13591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142605Inst : IEnumerable<long>
{
public static readonly long[] Value=A142605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142605.Bytes);
public long this[int i]=>Value[i];

public static A142605Inst Instance=new A142605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142606
{
public static readonly long[] Value={ 7L,227L,337L,557L,887L,997L,1217L,1327L,1657L,1877L,1987L,2207L,2647L,3307L,3527L,3637L,3967L,4297L,4517L,4957L,5507L,6277L,6607L,6827L,7487L,7817L,7927L,8147L,8807L,9137L,9467L,9907L,10457L,10567L,11117L,11447L,11777L,11887L,12107L,12437L,12547L,13537L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142606Inst : IEnumerable<long>
{
public static readonly long[] Value=A142606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142606.Bytes);
public long this[int i]=>Value[i];

public static A142606Inst Instance=new A142606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142607
{
public static readonly long[] Value={ 173L,283L,503L,613L,1163L,1493L,1823L,1933L,2153L,2593L,3253L,3583L,3803L,4133L,4243L,4463L,4793L,4903L,5233L,5563L,5783L,6113L,6553L,6883L,7103L,7213L,7433L,7873L,8093L,8423L,8753L,8863L,9413L,9743L,10513L,10733L,11173L,11393L,11503L,11833L,12163L,12713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142607Inst : IEnumerable<long>
{
public static readonly long[] Value=A142607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142607.Bytes);
public long this[int i]=>Value[i];

public static A142607Inst Instance=new A142607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142608
{
public static readonly long[] Value={ 229L,449L,1109L,1439L,1549L,1879L,2099L,2539L,3089L,3529L,4079L,4409L,4519L,5179L,5399L,5839L,6389L,6719L,6829L,7159L,7489L,8039L,8369L,8699L,9029L,9689L,10459L,10789L,11119L,11779L,12109L,12329L,12659L,13099L,13649L,13759L,14419L,14639L,14969L,15299L,15629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142608Inst : IEnumerable<long>
{
public static readonly long[] Value=A142608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142608.Bytes);
public long this[int i]=>Value[i];

public static A142608Inst Instance=new A142608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142609
{
public static readonly long[] Value={ 67L,397L,617L,727L,947L,1277L,1607L,2267L,2377L,2707L,2927L,3037L,3257L,3697L,3917L,4027L,4357L,5237L,5347L,5897L,6007L,6337L,6997L,7547L,7877L,8317L,8537L,8647L,8867L,9857L,9967L,10627L,10847L,10957L,11177L,11287L,11617L,12277L,12497L,13267L,13487L,13597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142609Inst : IEnumerable<long>
{
public static readonly long[] Value=A142609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142609.Bytes);
public long this[int i]=>Value[i];

public static A142609Inst Instance=new A142609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142610
{
public static readonly long[] Value={ 13L,233L,563L,673L,1223L,1553L,1663L,1993L,2213L,2543L,3203L,3313L,3533L,3643L,3863L,4523L,5623L,5843L,5953L,6173L,6833L,7603L,7823L,7933L,8263L,8923L,9473L,9803L,10133L,10243L,10463L,10903L,11783L,12113L,12553L,13103L,13763L,13873L,14423L,14533L,14753L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142610Inst : IEnumerable<long>
{
public static readonly long[] Value=A142610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142610.Bytes);
public long this[int i]=>Value[i];

public static A142610Inst Instance=new A142610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142611
{
public static readonly long[] Value={ 179L,509L,619L,839L,1279L,1499L,1609L,2269L,2819L,3259L,3919L,4139L,4799L,4909L,5569L,6229L,6449L,6779L,7109L,7219L,7549L,7879L,8209L,8429L,8539L,9199L,9419L,9749L,9859L,10079L,10739L,11069L,11399L,11839L,12829L,13049L,13159L,13709L,14149L,14369L,14479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142611Inst : IEnumerable<long>
{
public static readonly long[] Value=A142611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142611.Bytes);
public long this[int i]=>Value[i];

public static A142611Inst Instance=new A142611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142612
{
public static readonly long[] Value={ 71L,181L,401L,1061L,1171L,1721L,1831L,2161L,2381L,2711L,3041L,3371L,3701L,4691L,4801L,5021L,5351L,5791L,6011L,6121L,6451L,6781L,7001L,7331L,8101L,8431L,8761L,9091L,9311L,9421L,10301L,10631L,11071L,11621L,11731L,12281L,12391L,12611L,12721L,12941L,13381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142612Inst : IEnumerable<long>
{
public static readonly long[] Value=A142612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142612.Bytes);
public long this[int i]=>Value[i];

public static A142612Inst Instance=new A142612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142613
{
public static readonly long[] Value={ 17L,127L,347L,457L,677L,787L,1117L,1447L,1667L,1777L,1997L,2437L,2657L,2767L,4637L,4967L,5077L,5297L,5407L,5737L,6067L,6287L,6397L,6947L,7057L,7607L,7717L,7937L,8377L,8597L,8707L,9257L,9587L,9697L,10247L,10357L,10687L,11677L,11897L,12007L,12227L,13217L,13327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142613Inst : IEnumerable<long>
{
public static readonly long[] Value=A142613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142613.Bytes);
public long this[int i]=>Value[i];

public static A142613Inst Instance=new A142613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142614
{
public static readonly long[] Value={ 73L,293L,733L,953L,1063L,1283L,1613L,1723L,2053L,2273L,2383L,2713L,3373L,3593L,3923L,4253L,4363L,4583L,5023L,5573L,5683L,5903L,6343L,6563L,6673L,7333L,7883L,7993L,8543L,9203L,9533L,9643L,9973L,10193L,10303L,10853L,11953L,12503L,12613L,13163L,13933L,14153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142614Inst : IEnumerable<long>
{
public static readonly long[] Value=A142614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142614.Bytes);
public long this[int i]=>Value[i];

public static A142614Inst Instance=new A142614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142615
{
public static readonly long[] Value={ 19L,239L,349L,569L,1009L,1229L,1559L,1669L,1889L,1999L,2549L,2659L,2879L,3209L,3319L,3539L,4639L,4969L,5189L,5519L,5849L,6619L,6949L,7499L,7829L,8269L,8599L,8819L,8929L,9479L,10139L,10799L,10909L,11239L,11789L,12119L,12889L,13109L,13219L,13879L,14759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142615Inst : IEnumerable<long>
{
public static readonly long[] Value=A142615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142615.Bytes);
public long this[int i]=>Value[i];

public static A142615Inst Instance=new A142615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142664
{
public static readonly long[] Value={ 167L,223L,503L,727L,839L,1063L,1231L,1399L,1511L,1567L,1847L,2239L,2351L,2687L,3023L,3079L,3191L,3359L,3527L,3583L,3863L,3919L,4423L,4591L,4703L,4759L,4871L,5039L,5431L,5711L,5879L,6047L,6271L,6551L,6607L,6719L,7559L,7727L,7951L,8231L,8287L,8623L,9127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142664Inst : IEnumerable<long>
{
public static readonly long[] Value=A142664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142664.Bytes);
public long this[int i]=>Value[i];

public static A142664Inst Instance=new A142664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142665
{
public static readonly long[] Value={ 229L,457L,571L,1483L,1597L,2053L,2281L,2851L,3079L,3307L,3877L,4219L,4447L,4561L,4789L,4903L,5701L,6043L,6271L,6841L,7069L,7297L,7411L,7639L,7753L,7867L,8209L,8779L,8893L,9007L,9349L,9463L,10831L,11059L,11173L,11287L,11743L,11971L,12541L,13339L,13567L,13681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142665Inst : IEnumerable<long>
{
public static readonly long[] Value=A142665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142665.Bytes);
public long this[int i]=>Value[i];

public static A142665Inst Instance=new A142665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142666
{
public static readonly long[] Value={ 2L,59L,173L,401L,743L,857L,971L,1427L,1997L,2111L,2339L,2909L,3023L,3137L,3251L,3593L,3821L,4049L,4391L,4733L,5189L,5303L,5417L,5531L,5987L,6101L,6329L,6899L,7013L,7127L,7583L,8039L,8609L,8837L,8951L,9293L,9521L,9749L,10091L,10433L,10889L,11003L,11117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142666Inst : IEnumerable<long>
{
public static readonly long[] Value=A142666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142666.Bytes);
public long this[int i]=>Value[i];

public static A142666Inst Instance=new A142666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142667
{
public static readonly long[] Value={ 61L,631L,859L,1087L,1201L,1429L,1543L,1657L,1999L,2113L,2341L,2683L,2797L,3253L,3709L,3823L,4051L,4507L,4621L,5077L,5419L,5647L,6217L,6673L,7129L,7243L,7699L,7927L,8269L,8839L,9067L,9181L,10093L,10321L,10663L,10891L,11119L,11689L,12373L,12487L,12601L,12829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142667Inst : IEnumerable<long>
{
public static readonly long[] Value=A142667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142667.Bytes);
public long this[int i]=>Value[i];

public static A142667Inst Instance=new A142667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142668
{
public static readonly long[] Value={ 5L,233L,347L,461L,1031L,1259L,1373L,1487L,1601L,2399L,2741L,2969L,3083L,3539L,3767L,3881L,4337L,4451L,4679L,4793L,5021L,5477L,5591L,6047L,6389L,6959L,7187L,7529L,7643L,7757L,8669L,8783L,9011L,9239L,9467L,9923L,10037L,10151L,10607L,10949L,11177L,11519L,11633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142668Inst : IEnumerable<long>
{
public static readonly long[] Value=A142668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142668.Bytes);
public long this[int i]=>Value[i];

public static A142668Inst Instance=new A142668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142669
{
public static readonly long[] Value={ 7L,349L,463L,577L,691L,919L,1033L,1489L,1831L,2287L,2857L,2971L,3313L,3541L,3769L,4111L,4339L,4567L,4909L,5023L,5479L,5821L,6163L,6277L,6619L,6733L,6961L,7417L,7759L,7873L,8101L,8329L,8443L,9013L,9127L,9241L,9697L,9811L,10039L,10267L,10723L,10837L,11863L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142669Inst : IEnumerable<long>
{
public static readonly long[] Value=A142669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142669.Bytes);
public long this[int i]=>Value[i];

public static A142669Inst Instance=new A142669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A142670
{
public static readonly long[] Value={ 179L,293L,521L,863L,977L,1091L,1319L,1433L,1889L,2003L,2459L,2687L,2801L,3257L,3371L,4283L,4397L,4967L,5081L,5309L,5651L,5879L,6221L,6449L,6563L,6791L,7019L,7247L,7589L,7703L,7817L,8273L,8387L,8501L,9413L,10211L,10667L,10781L,11351L,11579L,11807L,12149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A142670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A142670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A142670Inst : IEnumerable<long>
{
public static readonly long[] Value=A142670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A142670.Bytes);
public long this[int i]=>Value[i];

public static A142670Inst Instance=new A142670Inst();

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