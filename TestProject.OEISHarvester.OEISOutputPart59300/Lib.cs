using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A066845
{
public static readonly long[] Value={ 3L,5L,3L,17L,11L,13L,43L,257L,57L,205L,683L,241L,2731L,3277L,331L,65537L,43691L,4033L,174763L,61681L,5419L,838861L,2796203L,65281L,1016801L,13421773L,261633L,15790321L,178956971L,80581L,715827883L,4294967297L,1397419L,3435973837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066845Inst : IEnumerable<long>
{
public static readonly long[] Value=A066845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066845.Bytes);
public long this[int i]=>Value[i];

public static A066845Inst Instance=new A066845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066846
{
public static readonly long[] Value={ 2L,5L,8L,28L,31L,54L,257L,260L,283L,512L,3126L,3129L,3152L,3381L,6250L,46657L,46660L,46683L,46912L,49781L,93312L,823544L,823547L,823570L,823799L,826668L,870199L,1647086L,16777217L,16777220L,16777243L,16777472L,16780341L,16823872L,17600759L,33554432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066846Inst : IEnumerable<long>
{
public static readonly long[] Value=A066846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066846.Bytes);
public long this[int i]=>Value[i];

public static A066846Inst Instance=new A066846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066847
{
public static readonly long[] Value={ 2L,3L,4L,7L,8L,12L,25L,26L,30L,48L,121L,122L,126L,144L,240L,721L,722L,726L,744L,840L,1440L,5041L,5042L,5046L,5064L,5160L,5760L,10080L,40321L,40322L,40326L,40344L,40440L,41040L,45360L,80640L,362881L,362882L,362886L,362904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066847Inst : IEnumerable<long>
{
public static readonly long[] Value=A066847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066847.Bytes);
public long this[int i]=>Value[i];

public static A066847Inst Instance=new A066847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066848
{
public static readonly long[] Value={ 1L,2L,3L,2436L,520L,60L,308L,2436L,15867L,61800L,8096L,55620L,77077L,20216L,51675L,2296992L,21607L,15867L,185820L,481680L,140805L,226644L,145866L,1568928L,1076000L,187772L,5596587L,1831956L,715778L,3540060L,836535L,2296992L,3088008L,1129514L,7096775L,1995048L,2018646L,3159168L,13019136L,15293320L,6936667L,11250624L,6877463L,20475136L,3380040L,3986360L,1052424L,17566608L,5152350L,1076000L,3824694L,8897564L,2987239L,17600004L,24056230L,89537336L,23397531L,2791424L,5393780L,19344660L,5306268L,8679008L,126415359L,30486400L,29303235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066848Inst : IEnumerable<long>
{
public static readonly long[] Value=A066848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066848.Bytes);
public long this[int i]=>Value[i];

public static A066848Inst Instance=new A066848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066849
{
public static readonly long[] Value={ 1L,2L,3L,401L,113L,22L,75L,401L,1986L,6547L,1110L,5949L,7952L,2445L,5578L,172617L,2590L,1986L,17471L,41341L,13631L,20900L,14063L,121563L,86009L,17648L,392866L,140171L,59293L,257162L,68370L,172617L,226693L,89942L,489653L,151601L,153287L,231508L,860521L,999664L,479352L,751180L,475540L,1312350L,246470L,287004L,84285L,1137690L,363942L,86009L,276267L,603972L,219888L,1139722L,1525515L,5227193L,1486480L,206546L,379708L,1244626L,374003L,590152L,7230480L,1903679L,1834403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066849Inst : IEnumerable<long>
{
public static readonly long[] Value=A066849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066849.Bytes);
public long this[int i]=>Value[i];

public static A066849Inst Instance=new A066849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066850
{
public static readonly long[] Value={ 1L,4L,2669L,9559L,15293L,32583L,36593L,38443L,255367L,257239L,273977L,283391L,314101L,421553L,488363L,532975L,768699L,839973L,871757L,1960479L,2337221L,2374867L,3084659L,3326653L,3735029L,4440017L,5387373L,7930439L,8114377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066850Inst : IEnumerable<long>
{
public static readonly long[] Value=A066850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066850.Bytes);
public long this[int i]=>Value[i];

public static A066850Inst Instance=new A066850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066851
{
public static readonly long[] Value={ 0L,0L,1L,0L,3L,0L,3L,3L,3L,0L,9L,1L,3L,6L,6L,3L,9L,0L,9L,9L,6L,0L,15L,6L,3L,12L,10L,3L,15L,0L,15L,12L,6L,6L,18L,9L,3L,12L,18L,6L,21L,0L,9L,21L,9L,6L,27L,7L,9L,12L,18L,9L,15L,12L,18L,24L,6L,0L,33L,6L,15L,18L,21L,12L,18L,12L,9L,27L,18L,0L,39L,9L,9L,24L,19L,21L,18L,0L,27L,27L,18L,6L,33L,18L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066851Inst : IEnumerable<long>
{
public static readonly long[] Value=A066851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066851.Bytes);
public long this[int i]=>Value[i];

public static A066851Inst Instance=new A066851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066852
{
public static readonly long[] Value={ 1L,25L,1105L,5095L,8925L,54549L,218295L,478423L,939575L,1475901L,5047977L,7635033L,11213895L,20680985L,16776123L,23599303L,19371925L,28569569L,31983147L,33984405L,30885975L,38189799L,42059765L,35086905L,49400043L,45711639L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066852Inst : IEnumerable<long>
{
public static readonly long[] Value=A066852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066852.Bytes);
public long this[int i]=>Value[i];

public static A066852Inst Instance=new A066852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066853
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,6L,9L,10L,7L,11L,9L,14L,15L,11L,13L,11L,12L,20L,9L,14L,19L,13L,25L,18L,27L,21L,10L,30L,19L,21L,19L,13L,35L,15L,29L,13L,25L,30L,19L,18L,33L,20L,45L,21L,15L,15L,37L,50L,35L,30L,37L,29L,12L,25L,33L,20L,37L,55L,25L,21L,23L,42L,45L,38L,51L,20L,29L,70L,44L,15L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066853Inst : IEnumerable<long>
{
public static readonly long[] Value=A066853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066853.Bytes);
public long this[int i]=>Value[i];

public static A066853Inst Instance=new A066853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066854
{
public static readonly long[] Value={ 18L,89L,165L,179L,77L,110L,146L,253L,103L,155L,91L,60L,159L,125L,44L,246L,217L,167L,191L,75L,246L,242L,221L,181L,186L,239L,60L,214L,233L,125L,215L,91L,231L,251L,123L,102L,246L,205L,167L,222L,91L,62L,183L,123L,189L,219L,93L,174L,191L,123L,231L,147L,223L,165L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066854Inst : IEnumerable<long>
{
public static readonly long[] Value=A066854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066854.Bytes);
public long this[int i]=>Value[i];

public static A066854Inst Instance=new A066854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066855
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,1L,3L,2L,1L,1L,2L,4L,4L,2L,1L,1L,1L,5L,5L,4L,2L,1L,1L,3L,7L,8L,6L,4L,2L,1L,1L,2L,8L,11L,9L,6L,4L,2L,1L,1L,2L,11L,16L,14L,10L,6L,4L,2L,1L,1L,1L,11L,20L,20L,15L,10L,6L,4L,2L,1L,1L,4L,15L,28L,29L,23L,16L,10L,6L,4L,2L,1L,1L,1L,16L,33L,39L,33L,24L,16L,10L,6L,4L,2L,1L,1L,2L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066855Inst : IEnumerable<long>
{
public static readonly long[] Value=A066855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066855.Bytes);
public long this[int i]=>Value[i];

public static A066855Inst Instance=new A066855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066856
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,3L,2L,1L,2L,2L,2L,3L,5L,3L,6L,2L,2L,3L,3L,3L,2L,2L,2L,1L,2L,3L,5L,4L,4L,5L,2L,5L,6L,1L,2L,4L,7L,1L,3L,4L,3L,3L,3L,4L,2L,5L,5L,6L,4L,4L,2L,2L,4L,3L,4L,2L,4L,4L,3L,5L,3L,4L,5L,4L,5L,6L,5L,2L,7L,1L,4L,2L,3L,1L,6L,3L,4L,7L,3L,3L,3L,5L,5L,4L,3L,8L,3L,6L,2L,4L,3L,4L,5L,6L,6L,5L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066856Inst : IEnumerable<long>
{
public static readonly long[] Value=A066856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066856.Bytes);
public long this[int i]=>Value[i];

public static A066856Inst Instance=new A066856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066857
{
public static readonly long[] Value={ 0L,1L,2L,8L,20L,44L,140L,320L,476L,3584L,12311L,4604L,74879L,414119L,2071775L,5703551L,11551671L,45680444L,442548224L,1960632176L,2657058876L,24923993276L,130518272975L,1478154932316L,5446454455004L,38610655379975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066857Inst : IEnumerable<long>
{
public static readonly long[] Value=A066857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066857.Bytes);
public long this[int i]=>Value[i];

public static A066857Inst Instance=new A066857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066858
{
public static readonly long[] Value={ 2L,3L,3L,5L,3L,7L,3L,7L,5L,11L,0L,13L,7L,5L,5L,17L,0L,19L,0L,7L,11L,23L,0L,21L,13L,19L,0L,29L,5L,31L,9L,11L,17L,13L,0L,37L,19L,13L,0L,41L,7L,43L,0L,0L,23L,47L,0L,43L,0L,17L,0L,53L,0L,21L,0L,19L,29L,59L,0L,61L,31L,0L,17L,13L,11L,67L,0L,23L,13L,71L,0L,73L,37L,0L,0L,31L,13L,79L,0L,55L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066858Inst : IEnumerable<long>
{
public static readonly long[] Value=A066858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066858.Bytes);
public long this[int i]=>Value[i];

public static A066858Inst Instance=new A066858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066859
{
public static readonly long[] Value={ 0L,0L,8L,21L,54L,108L,160L,315L,416L,666L,648L,1400L,1078L,1944L,2304L,3255L,2430L,5148L,3400L,7056L,6368L,7812L,6048L,14400L,9114L,12978L,13520L,19600L,12150L,28296L,14848L,29295L,24624L,29214L,27936L,52325L,25270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066859Inst : IEnumerable<long>
{
public static readonly long[] Value=A066859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066859.Bytes);
public long this[int i]=>Value[i];

public static A066859Inst Instance=new A066859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066860
{
public static readonly long[] Value={ 15L,20L,24L,95L,104L,207L,224L,287L,464L,1023L,1199L,1952L,4095L,4607L,8036L,12095L,15872L,16895L,19359L,22932L,23519L,28799L,45440L,45695L,54144L,77375L,101567L,102024L,130304L,159599L,163295L,223199L,296207L,317184L,352799L,522752L,524160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066860Inst : IEnumerable<long>
{
public static readonly long[] Value=A066860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066860.Bytes);
public long this[int i]=>Value[i];

public static A066860Inst Instance=new A066860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066861
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,12L,18L,19L,24L,26L,32L,34L,35L,43L,49L,56L,58L,60L,61L,65L,66L,67L,80L,96L,104L,106L,113L,121L,130L,131L,132L,133L,134L,144L,145L,146L,147L,148L,149L,153L,156L,157L,158L,167L,169L,176L,180L,181L,184L,186L,192L,196L,197L,198L,200L,202L,204L,205L,206L,207L,222L,223L,246L,247L,249L,254L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066861Inst : IEnumerable<long>
{
public static readonly long[] Value=A066861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066861.Bytes);
public long this[int i]=>Value[i];

public static A066861Inst Instance=new A066861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066862
{
public static readonly long[] Value={ 1L,4L,15L,16L,27L,48L,60L,64L,108L,144L,240L,256L,325L,432L,729L,891L,960L,1008L,1024L,1200L,1280L,1296L,1300L,1728L,1875L,2916L,3072L,3125L,3564L,3645L,3840L,3888L,4095L,4096L,5200L,6000L,6237L,6375L,6400L,6912L,7056L,7500L,8775L,9216L,11520L,11664L,12500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066862Inst : IEnumerable<long>
{
public static readonly long[] Value=A066862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066862.Bytes);
public long this[int i]=>Value[i];

public static A066862Inst Instance=new A066862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066863
{
public static readonly BigInteger[] Value={ 2L,6L,43L,557L,14432L,719469L,70372090L,13351521479L,4941545691252L,3559349503024593L,4993739972681894885L,BigInteger.Parse("13642580224488264353504") };
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
public class A066863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066863Inst Instance=new A066863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066864
{
public static readonly BigInteger[] Value={ 1L,2L,6L,42L,524L,13322L,647252L,61758332L,11435477118L,4129523869606L,2902264461628298L,3973109800760143708L,BigInteger.Parse("10590895512774862686570"),BigInteger.Parse("54979738656662942307796576"),BigInteger.Parse("555797909644630436677137498230"),BigInteger.Parse("10941698340065066230952215658836402"),BigInteger.Parse("419471520990343359533179780148504998680") };
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
public class A066864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066864Inst Instance=new A066864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066865
{
public static readonly long[] Value={ 1L,5L,22L,217L,4726L,164258L,14840533L,1834600977L,669877863205L,296979228487760L,434542100979981567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066865Inst : IEnumerable<long>
{
public static readonly long[] Value=A066865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066865.Bytes);
public long this[int i]=>Value[i];

public static A066865Inst Instance=new A066865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066866
{
public static readonly BigInteger[] Value={ 1L,5L,22L,201L,4216L,162314L,12329633L,1831137521L,528106112383L,296848246952000L,324932515409958655L,BigInteger.Parse("692572885398506075946"),BigInteger.Parse("2874785146216927021053015") };
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
public class A066866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066866Inst Instance=new A066866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066867
{
public static readonly long[] Value={ 21L,24L,27L,32L,40L,46L,56L,62L,73L,85L,94L,141L,157L,164L,170L,175L,183L,188L,216L,228L,234L,237L,261L,265L,268L,293L,300L,317L,331L,339L,349L,355L,359L,369L,376L,379L,386L,403L,410L,430L,442L,447L,451L,454L,458L,463L,472L,495L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066867Inst : IEnumerable<long>
{
public static readonly long[] Value=A066867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066867.Bytes);
public long this[int i]=>Value[i];

public static A066867Inst Instance=new A066867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066868
{
public static readonly long[] Value={ 2L,1L,10L,5L,2L,1L,2L,1L,12L,5L,2L,1L,4L,1L,4L,5L,2L,1L,2L,3L,4L,7L,12L,1L,2L,1L,4L,7L,2L,3L,2L,1L,4L,5L,2L,1L,4L,1L,6L,17L,2L,1L,4L,3L,6L,5L,2L,1L,2L,3L,4L,11L,12L,1L,2L,1L,4L,5L,2L,3L,2L,1L,4L,5L,14L,1L,2L,1L,10L,5L,2L,7L,10L,1L,6L,7L,2L,1L,8L,3L,4L,7L,26L,1L,2L,3L,6L,5L,2L,3L,2L,1L,4L,11L,2L,1L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066868Inst : IEnumerable<long>
{
public static readonly long[] Value=A066868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066868.Bytes);
public long this[int i]=>Value[i];

public static A066868Inst Instance=new A066868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066869
{
public static readonly long[] Value={ 5L,12L,23L,46L,93L,152L,235L,342L,509L,688L,915L,1178L,1525L,1884L,2267L,2734L,3213L,3716L,4279L,4866L,5585L,6424L,7287L,8174L,9157L,10176L,11363L,12646L,13953L,15272L,16639L,18078L,19565L,21088L,22707L,24530L,26437L,28464L,30503L,32566L,34665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066869Inst : IEnumerable<long>
{
public static readonly long[] Value=A066869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066869.Bytes);
public long this[int i]=>Value[i];

public static A066869Inst Instance=new A066869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066870
{
public static readonly long[] Value={ 10572550L,10854650L,32685250L,34538270L,35361326L,40117714L,35390008L,39259592L,186878110L,196323170L,242126704L,257841296L,250876395L,323303445L,300208696L,313576904L,388904355L,465418845L,395939775L,499717185L,541114808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066870Inst : IEnumerable<long>
{
public static readonly long[] Value=A066870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066870.Bytes);
public long this[int i]=>Value[i];

public static A066870Inst Instance=new A066870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066871
{
public static readonly long[] Value={ 2620L,2924L,10634085L,14084763L,23389695L,25132545L,34256222L,35997346L,46521405L,53011395L,63560025L,65003175L,80422335L,82977345L,120812175L,126671985L,190888155L,194594085L,256948065L,263110815L,281499435L,297034965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066871Inst : IEnumerable<long>
{
public static readonly long[] Value=A066871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066871.Bytes);
public long this[int i]=>Value[i];

public static A066871Inst Instance=new A066871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066872
{
public static readonly long[] Value={ 5L,10L,26L,50L,122L,170L,290L,362L,530L,842L,962L,1370L,1682L,1850L,2210L,2810L,3482L,3722L,4490L,5042L,5330L,6242L,6890L,7922L,9410L,10202L,10610L,11450L,11882L,12770L,16130L,17162L,18770L,19322L,22202L,22802L,24650L,26570L,27890L,29930L,32042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066872Inst : IEnumerable<long>
{
public static readonly long[] Value=A066872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066872.Bytes);
public long this[int i]=>Value[i];

public static A066872Inst Instance=new A066872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066873
{
public static readonly long[] Value={ 0L,0L,1L,5L,13L,42L,108L,236L,586L,1427L,3340L,7642L,17519L,39374L,87102L,190775L,415523L,901312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066873Inst : IEnumerable<long>
{
public static readonly long[] Value=A066873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066873.Bytes);
public long this[int i]=>Value[i];

public static A066873Inst Instance=new A066873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066874
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,8L,2L,2L,2L,11L,2L,12L,2L,14L,14L,2L,2L,17L,2L,17L,18L,20L,2L,20L,2L,23L,2L,22L,2L,742L,2L,2L,26L,29L,26L,27L,2L,32L,30L,29L,2L,1654L,2L,32L,32L,38L,2L,36L,2L,41L,38L,37L,2L,44L,38L,38L,42L,47L,2L,3004L,2L,50L,42L,2L,44L,5257L,2L,47L,50L,5066L,2L,47L,2L,59L,54L,52L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066874Inst : IEnumerable<long>
{
public static readonly long[] Value=A066874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066874.Bytes);
public long this[int i]=>Value[i];

public static A066874Inst Instance=new A066874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066875
{
public static readonly long[] Value={ 3L,16L,37L,40L,47L,55L,56L,74L,103L,108L,111L,119L,130L,161L,165L,185L,188L,195L,200L,219L,240L,272L,273L,292L,340L,359L,388L,420L,427L,465L,466L,509L,521L,554L,600L,606L,622L,630L,634L,668L,683L,684L,703L,710L,711L,734L,762L,792L,814L,822L,823L,830L,831L,883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066875Inst : IEnumerable<long>
{
public static readonly long[] Value=A066875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066875.Bytes);
public long this[int i]=>Value[i];

public static A066875Inst Instance=new A066875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066876
{
public static readonly long[] Value={ 5L,6L,7L,27L,28L,36L,41L,54L,80L,82L,94L,126L,127L,131L,160L,177L,236L,248L,287L,339L,362L,385L,387L,400L,401L,410L,432L,433L,477L,485L,566L,579L,580L,581L,586L,599L,689L,700L,735L,744L,793L,821L,863L,874L,954L,1031L,1043L,1069L,1081L,1113L,1143L,1145L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066876Inst : IEnumerable<long>
{
public static readonly long[] Value=A066876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066876.Bytes);
public long this[int i]=>Value[i];

public static A066876Inst Instance=new A066876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066877
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,1L,2L,2L,2L,4L,1L,2L,1L,4L,2L,3L,3L,3L,2L,4L,3L,2L,2L,3L,2L,2L,4L,5L,1L,3L,1L,1L,2L,3L,2L,5L,1L,4L,2L,4L,4L,7L,4L,5L,5L,2L,4L,3L,2L,5L,6L,4L,6L,6L,5L,6L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066877Inst : IEnumerable<long>
{
public static readonly long[] Value=A066877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066877.Bytes);
public long this[int i]=>Value[i];

public static A066877Inst Instance=new A066877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066878
{
public static readonly long[] Value={ 6857L,29789L,50651L,300761L,1295027L,3442949L,9393929L,13997519L,21253931L,49430861L,84604517L,95443991L,237176657L,329939369L,384240581L,487443401L,633839777L,904231061L,1284365501L,1605723209L,3183010109L,3301293167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066878Inst : IEnumerable<long>
{
public static readonly long[] Value=A066878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066878.Bytes);
public long this[int i]=>Value[i];

public static A066878Inst Instance=new A066878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066879
{
public static readonly long[] Value={ 4L,5L,18L,19L,20L,21L,24L,25L,70L,71L,74L,75L,76L,77L,82L,83L,84L,85L,88L,89L,98L,99L,100L,101L,104L,105L,112L,113L,270L,271L,278L,279L,282L,283L,284L,285L,294L,295L,298L,299L,300L,301L,306L,307L,308L,309L,312L,313L,326L,327L,330L,331L,332L,333L,338L,339L,340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066879Inst : IEnumerable<long>
{
public static readonly long[] Value=A066879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066879.Bytes);
public long this[int i]=>Value[i];

public static A066879Inst Instance=new A066879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066880
{
public static readonly long[] Value={ 2L,3L,6L,7L,14L,15L,30L,31L,62L,63L,126L,127L,254L,255L,510L,511L,1022L,1023L,2046L,2047L,4094L,4095L,8190L,8191L,16382L,16383L,32766L,32767L,65534L,65535L,131070L,131071L,262142L,262143L,524286L,524287L,1048574L,1048575L,2097150L,2097151L,4194302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066880Inst : IEnumerable<long>
{
public static readonly long[] Value=A066880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066880.Bytes);
public long this[int i]=>Value[i];

public static A066880Inst Instance=new A066880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066881
{
public static readonly long[] Value={ 121679L,1043909L,2350171L,2918263L,3396103L,3566807L,3688067L,4019467L,4562827L,5963407L,7300697L,7485979L,7853933L,8103301L,8364151L,9237779L,9514213L,9638527L,10531123L,11094619L,11384447L,12721937L,13576267L,15331313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066881Inst : IEnumerable<long>
{
public static readonly long[] Value=A066881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066881.Bytes);
public long this[int i]=>Value[i];

public static A066881Inst Instance=new A066881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066882
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,3L,1L,2L,2L,1L,1L,4L,1L,3L,2L,2L,1L,5L,1L,2L,1L,3L,1L,21L,1L,1L,2L,2L,2L,7L,1L,2L,2L,5L,1L,28L,1L,3L,4L,2L,1L,9L,1L,6L,2L,3L,1L,10L,2L,5L,2L,2L,1L,71L,1L,2L,4L,1L,2L,42L,1L,3L,2L,43L,1L,13L,1L,2L,6L,3L,2L,49L,1L,9L,1L,2L,1L,97L,2L,2L,2L,5L,1L,151L,2L,3L,2L,2L,2L,17L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066882Inst : IEnumerable<long>
{
public static readonly long[] Value=A066882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066882.Bytes);
public long this[int i]=>Value[i];

public static A066882Inst Instance=new A066882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066883
{
public static readonly long[] Value={ 0L,0L,2L,5L,15L,21L,38L,46L,68L,108L,121L,171L,210L,227L,268L,341L,412L,441L,524L,585L,612L,711L,781L,888L,1042L,1126L,1165L,1247L,1286L,1381L,1720L,1814L,1972L,2018L,2306L,2361L,2536L,2715L,2838L,3029L,3217L,3290L,3635L,3709L,3848L,3920L,4370L,4836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066883Inst : IEnumerable<long>
{
public static readonly long[] Value=A066883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066883.Bytes);
public long this[int i]=>Value[i];

public static A066883Inst Instance=new A066883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066884
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,15L,11L,6L,8L,31L,23L,13L,9L,16L,63L,47L,27L,14L,10L,32L,127L,95L,55L,29L,19L,12L,64L,255L,191L,111L,59L,30L,21L,17L,128L,511L,383L,223L,119L,61L,39L,22L,18L,256L,1023L,767L,447L,239L,123L,62L,43L,25L,20L,512L,2047L,1535L,895L,479L,247L,125L,79L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066884Inst : IEnumerable<long>
{
public static readonly long[] Value=A066884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066884.Bytes);
public long this[int i]=>Value[i];

public static A066884Inst Instance=new A066884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066885
{
public static readonly long[] Value={ 5L,13L,25L,61L,85L,145L,181L,265L,421L,481L,685L,841L,925L,1105L,1405L,1741L,1861L,2245L,2521L,2665L,3121L,3445L,3961L,4705L,5101L,5305L,5725L,5941L,6385L,8065L,8581L,9385L,9661L,11101L,11401L,12325L,13285L,13945L,14965L,16021L,16381L,18241L,18625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066885Inst : IEnumerable<long>
{
public static readonly long[] Value=A066885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066885.Bytes);
public long this[int i]=>Value[i];

public static A066885Inst Instance=new A066885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066886
{
public static readonly long[] Value={ 5L,15L,65L,175L,671L,1105L,2465L,3439L,6095L,12209L,14911L,25345L,34481L,39775L,51935L,74465L,102719L,113521L,150415L,178991L,194545L,246559L,285935L,352529L,456385L,515201L,546415L,612575L,647569L,721505L,1024255L,1124111L,1285745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066886Inst : IEnumerable<long>
{
public static readonly long[] Value=A066886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066886.Bytes);
public long this[int i]=>Value[i];

public static A066886Inst Instance=new A066886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066887
{
public static readonly long[] Value={ 3L,9L,10L,14L,20L,22L,27L,28L,30L,40L,42L,44L,46L,50L,56L,60L,66L,80L,81L,84L,88L,90L,92L,94L,98L,100L,112L,118L,120L,126L,132L,138L,150L,160L,166L,168L,176L,180L,184L,188L,196L,198L,200L,214L,224L,236L,240L,242L,243L,250L,252L,264L,270L,276L,282L,294L,300L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066887Inst : IEnumerable<long>
{
public static readonly long[] Value=A066887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066887.Bytes);
public long this[int i]=>Value[i];

public static A066887Inst Instance=new A066887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066888
{
public static readonly long[] Value={ 0L,2L,1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,3L,3L,3L,2L,4L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,4L,5L,3L,6L,6L,7L,5L,5L,6L,4L,8L,5L,6L,6L,8L,6L,8L,5L,7L,5L,11L,4L,6L,9L,7L,8L,9L,8L,7L,7L,9L,7L,8L,7L,12L,5L,9L,9L,11L,9L,7L,7L,12L,10L,10L,9L,9L,9L,6L,11L,10L,11L,9L,12L,11L,12L,9L,10L,11L,12L,10L,13L,9L,11L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066888Inst : IEnumerable<long>
{
public static readonly long[] Value=A066888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066888.Bytes);
public long this[int i]=>Value[i];

public static A066888Inst Instance=new A066888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066889
{
public static readonly long[] Value={ 2L,2L,3L,5L,7L,11L,17L,17L,37L,23L,47L,37L,29L,19L,47L,59L,19L,37L,71L,59L,31L,67L,239L,101L,739L,409L,43L,367L,167L,251L,73L,71L,419L,1567L,107L,83L,223L,191L,227L,449L,97L,173L,103L,523L,79L,137L,223L,1163L,661L,103L,103L,541L,227L,2383L,433L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066889Inst : IEnumerable<long>
{
public static readonly long[] Value=A066889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066889.Bytes);
public long this[int i]=>Value[i];

public static A066889Inst Instance=new A066889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066890
{
public static readonly long[] Value={ 216L,729L,1728L,5832L,6859L,8000L,13824L,15625L,19683L,21952L,24389L,27000L,46656L,54872L,64000L,68921L,74088L,85184L,91125L,97336L,110592L,125000L,148877L,157464L,175616L,185193L,195112L,216000L,250047L,287496L,300763L,328509L,343000L,357911L,373248L,421875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066890Inst : IEnumerable<long>
{
public static readonly long[] Value=A066890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066890.Bytes);
public long this[int i]=>Value[i];

public static A066890Inst Instance=new A066890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066891
{
public static readonly long[] Value={ 4L,6L,2L,22L,26L,42L,18L,9L,24L,66L,72L,36L,96L,82L,28L,114L,32L,126L,60L,150L,66L,152L,158L,200L,202L,84L,204L,42L,206L,62L,218L,110L,236L,270L,222L,126L,290L,135L,8L,300L,324L,330L,148L,350L,356L,408L,410L,420L,434L,17L,438L,384L,122L,15L,68L,446L,216L,456L,462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066891Inst : IEnumerable<long>
{
public static readonly long[] Value=A066891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066891.Bytes);
public long this[int i]=>Value[i];

public static A066891Inst Instance=new A066891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066892
{
public static readonly long[] Value={ 3L,4L,2L,8L,6L,13L,6L,5L,5L,12L,6L,7L,10L,9L,8L,13L,7L,13L,10L,9L,13L,5L,10L,13L,11L,7L,11L,5L,9L,13L,9L,14L,9L,12L,9L,8L,13L,13L,8L,11L,10L,18L,10L,14L,4L,16L,15L,9L,13L,5L,11L,16L,14L,7L,10L,12L,10L,18L,12L,13L,13L,12L,14L,11L,12L,20L,17L,11L,7L,13L,7L,10L,9L,12L,10L,17L,9L,15L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066892Inst : IEnumerable<long>
{
public static readonly long[] Value=A066892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066892.Bytes);
public long this[int i]=>Value[i];

public static A066892Inst Instance=new A066892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066893
{
public static readonly long[] Value={ 1L,2L,6L,21L,25L,32L,174L,400L,918L,960L,971L,987L,2374L,5928L,5935L,5942L,5977L,14838L,37259L,37282L,94154L,238309L,1556445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066893Inst : IEnumerable<long>
{
public static readonly long[] Value=A066893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066893.Bytes);
public long this[int i]=>Value[i];

public static A066893Inst Instance=new A066893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066894
{
public static readonly long[] Value={ 1L,2L,4L,6L,18L,42L,44L,49L,246L,257L,259L,272L,283L,294L,25284L,62648L,62664L,62673L,62700L,62701L,158706L,404835L,404859L,405119L,405448L,405451L,2630908L,2630929L,2631249L,2631303L,2631368L,2631414L,2631509L,2631517L,2631576L,2631666L,17405852L,44932936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066894Inst : IEnumerable<long>
{
public static readonly long[] Value=A066894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066894.Bytes);
public long this[int i]=>Value[i];

public static A066894Inst Instance=new A066894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066895
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,16L,30L,120L,182L,439L,1058L,4122L,25356L,40086L,40090L,40114L,40120L,63416L,100347L,159222L,251708L,399930L,637328L,637336L,637340L,1014636L,2582486L,4124468L,6592708L,6592728L,10553440L,10553445L,10553829L,16899052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066895Inst : IEnumerable<long>
{
public static readonly long[] Value=A066895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066895.Bytes);
public long this[int i]=>Value[i];

public static A066895Inst Instance=new A066895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066896
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,10L,11L,24L,34L,63L,150L,212L,213L,375L,1245L,2256L,7491L,10128L,10144L,10148L,18700L,25315L,25320L,25333L,401500L,401526L,1019658L,1393220L,1393236L,1393270L,2598060L,2598136L,9095338L,12457665L,17063254L,32038770L,43924379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066896Inst : IEnumerable<long>
{
public static readonly long[] Value=A066896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066896.Bytes);
public long this[int i]=>Value[i];

public static A066896Inst Instance=new A066896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066897
{
public static readonly long[] Value={ 1L,2L,5L,8L,15L,24L,39L,58L,90L,130L,190L,268L,379L,522L,722L,974L,1317L,1754L,2330L,3058L,4010L,5200L,6731L,8642L,11068L,14076L,17864L,22528L,28347L,35490L,44320L,55100L,68355L,84450L,104111L,127898L,156779L,191574L,233625L,284070L,344745L,417292L,504151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066897Inst : IEnumerable<long>
{
public static readonly long[] Value=A066897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066897.Bytes);
public long this[int i]=>Value[i];

public static A066897Inst Instance=new A066897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066898
{
public static readonly long[] Value={ 0L,1L,1L,4L,5L,11L,15L,28L,38L,62L,85L,131L,177L,258L,346L,489L,648L,890L,1168L,1572L,2042L,2699L,3475L,4532L,5783L,7446L,9430L,12017L,15106L,19073L,23815L,29827L,37011L,46012L,56765L,70116L,86033L,105627L,128962L,157476L,191359L,232499L,281286L,340180L,409871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066898Inst : IEnumerable<long>
{
public static readonly long[] Value=A066898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066898.Bytes);
public long this[int i]=>Value[i];

public static A066898Inst Instance=new A066898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066899
{
public static readonly long[] Value={ 1L,3L,1L,4L,2L,5L,1L,7L,2L,3L,2L,7L,2L,5L,2L,7L,2L,5L,2L,10L,2L,3L,3L,15L,2L,3L,2L,5L,3L,3L,1L,12L,4L,5L,2L,9L,2L,7L,2L,12L,3L,7L,2L,8L,4L,3L,2L,16L,2L,5L,3L,4L,4L,9L,2L,10L,2L,3L,4L,12L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066899Inst : IEnumerable<long>
{
public static readonly long[] Value=A066899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066899.Bytes);
public long this[int i]=>Value[i];

public static A066899Inst Instance=new A066899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066900
{
public static readonly long[] Value={ 2L,6L,2L,12L,3L,18L,2L,30L,5L,22L,3L,42L,7L,10L,9L,60L,3L,54L,5L,66L,11L,46L,15L,90L,13L,6L,7L,58L,5L,62L,2L,120L,21L,14L,3L,126L,19L,30L,5L,150L,7L,98L,11L,138L,27L,94L,3L,210L,5L,34L,13L,106L,33L,162L,7L,174L,29L,118L,35L,198L,31L,14L,39L,240L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066900Inst : IEnumerable<long>
{
public static readonly long[] Value=A066900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066900.Bytes);
public long this[int i]=>Value[i];

public static A066900Inst Instance=new A066900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066901
{
public static readonly long[] Value={ 5L,6L,9L,21L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066901Inst : IEnumerable<long>
{
public static readonly long[] Value=A066901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066901.Bytes);
public long this[int i]=>Value[i];

public static A066901Inst Instance=new A066901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066902
{
public static readonly long[] Value={ 3L,5L,20L,156L,254L,377L,593L,1800L,5903L,5981L,7925L,18669L,19240L,41274L,48296L,135700L,146866L,228028L,234303L,251216L,407377L,654288L,802222L,886223L,938654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066902Inst : IEnumerable<long>
{
public static readonly long[] Value=A066902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066902.Bytes);
public long this[int i]=>Value[i];

public static A066902Inst Instance=new A066902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066903
{
public static readonly long[] Value={ 7L,2L,5L,3L,19L,17L,17L,7L,7L,23L,5L,13L,13L,109L,29L,11L,11L,11L,19L,19L,19L,19L,107L,107L,17L,17L,17L,17L,113L,113L,113L,7L,41L,41L,103L,103L,23L,23L,23L,23L,23L,23L,23L,67L,31L,31L,31L,31L,31L,31L,13L,13L,13L,13L,101L,101L,13L,13L,127L,83L,127L,47L,47L,109L,47L,109L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066903Inst : IEnumerable<long>
{
public static readonly long[] Value=A066903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066903.Bytes);
public long this[int i]=>Value[i];

public static A066903Inst Instance=new A066903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066904
{
public static readonly long[] Value={ 1L,3L,6L,15L,15L,10L,10L,21L,21L,21L,6L,105L,105L,28L,28L,28L,28L,28L,15L,15L,15L,15L,15L,15L,36L,36L,36L,36L,10L,10L,10L,21L,21L,21L,21L,21L,21L,21L,78L,21L,91L,91L,55L,55L,55L,45L,45L,45L,45L,45L,45L,45L,45L,45L,120L,120L,120L,120L,120L,120L,120L,120L,66L,66L,136L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066904Inst : IEnumerable<long>
{
public static readonly long[] Value=A066904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066904.Bytes);
public long this[int i]=>Value[i];

public static A066904Inst Instance=new A066904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066905
{
public static readonly long[] Value={ 0L,1L,16L,9L,9L,4L,16L,16L,16L,9L,9L,9L,25L,25L,25L,25L,25L,100L,121L,36L,36L,36L,36L,49L,16L,16L,16L,16L,16L,16L,16L,16L,81L,81L,9L,25L,25L,25L,25L,25L,25L,25L,25L,25L,25L,100L,100L,100L,25L,144L,25L,100L,25L,25L,144L,144L,25L,25L,144L,64L,64L,64L,64L,64L,25L,25L,64L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066905Inst : IEnumerable<long>
{
public static readonly long[] Value=A066905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066905.Bytes);
public long this[int i]=>Value[i];

public static A066905Inst Instance=new A066905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066906
{
public static readonly long[] Value={ 3L,4L,5L,8L,9L,14L,15L,20L,21L,25L,32L,34L,35L,41L,43L,48L,52L,53L,56L,58L,60L,61L,62L,63L,88L,90L,92L,93L,108L,109L,110L,128L,135L,139L,142L,143L,144L,148L,149L,152L,154L,162L,163L,167L,172L,173L,174L,177L,178L,179L,192L,208L,212L,213L,214L,215L,226L,227L,231L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066906Inst : IEnumerable<long>
{
public static readonly long[] Value=A066906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066906.Bytes);
public long this[int i]=>Value[i];

public static A066906Inst Instance=new A066906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066907
{
public static readonly long[] Value={ 1L,4L,14L,28L,32L,56L,58L,176L,110L,128L,134L,392L,184L,232L,448L,608L,308L,440L,382L,896L,812L,536L,554L,2464L,752L,736L,974L,1624L,872L,1792L,994L,2336L,1876L,1232L,1856L,3080L,1408L,1528L,2576L,5632L,1724L,3248L,1894L,3752L,3520L,2216L,2258L,8512L,2746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066907Inst : IEnumerable<long>
{
public static readonly long[] Value=A066907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066907.Bytes);
public long this[int i]=>Value[i];

public static A066907Inst Instance=new A066907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066908
{
public static readonly BigInteger[] Value={ 0L,0L,2L,3L,136L,2405L,6336L,460663L,13148416L,347503689L,3772979200L,198133379411L,7608426080256L,281952316704253L,4709633119830016L,316248789972027375L,16013842065532911616UL,BigInteger.Parse("776149319714627324177") };
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
public class A066908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066908Inst Instance=new A066908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066909
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,5L,2L,1L,7L,1L,1L,1L,9L,3L,7L,7L,8L,17L,18L,9L,16L,15L,15L,1L,24L,1L,26L,13L,17L,1L,19L,9L,14L,23L,3L,23L,11L,31L,19L,1L,6L,37L,26L,21L,7L,45L,35L,35L,25L,41L,2L,17L,27L,1L,31L,43L,50L,41L,15L,49L,55L,9L,10L,51L,28L,37L,30L,13L,26L,47L,24L,13L,28L,27L,73L,73L,76L,43L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066909Inst : IEnumerable<long>
{
public static readonly long[] Value=A066909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066909.Bytes);
public long this[int i]=>Value[i];

public static A066909Inst Instance=new A066909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066910
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,4L,2L,3L,5L,0L,8L,4L,6L,10L,4L,5L,7L,11L,1L,17L,11L,18L,10L,15L,1L,21L,11L,16L,26L,17L,27L,16L,24L,7L,5L,1L,29L,13L,17L,25L,1L,33L,15L,20L,30L,5L,45L,33L,7L,2L,42L,22L,32L,52L,38L,8L,2L,47L,23L,32L,50L,25L,35L,55L,31L,46L,10L,3L,57L,29L,41L,65L,41L,64L,36L,53L,11L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066910Inst : IEnumerable<long>
{
public static readonly long[] Value=A066910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066910.Bytes);
public long this[int i]=>Value[i];

public static A066910Inst Instance=new A066910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066911
{
public static readonly long[] Value={ 0L,0L,2L,3L,5L,5L,10L,15L,14L,10L,17L,23L,28L,32L,33L,39L,41L,53L,58L,70L,67L,64L,77L,95L,95L,85L,97L,91L,100L,119L,129L,158L,146L,141L,148L,155L,160L,176L,181L,190L,197L,226L,238L,268L,273L,256L,281L,323L,321L,321L,308L,313L,328L,376L,365L,372L,359L,350L,381L,430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066911Inst : IEnumerable<long>
{
public static readonly long[] Value=A066911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066911.Bytes);
public long this[int i]=>Value[i];

public static A066911Inst Instance=new A066911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066912
{
public static readonly long[] Value={ 0L,1L,26L,302L,2416L,15619L,88234L,455192L,2203488L,10187685L,45533450L,198410786L,848090912L,3572085255L,14875399450L,61403313100L,251732291184L,1026509354985L,4168403181210L,16871482830550L,68111623139600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066912Inst : IEnumerable<long>
{
public static readonly long[] Value=A066912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066912.Bytes);
public long this[int i]=>Value[i];

public static A066912Inst Instance=new A066912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066913
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,5L,3L,7L,5L,0L,6L,11L,2L,4L,3L,7L,7L,17L,1L,10L,4L,20L,8L,23L,20L,7L,16L,7L,13L,29L,5L,30L,14L,5L,8L,11L,12L,24L,25L,30L,33L,16L,23L,4L,3L,26L,46L,35L,27L,21L,2L,1L,10L,52L,35L,36L,17L,2L,27L,10L,13L,34L,50L,51L,28L,23L,32L,5L,59L,64L,0L,58L,55L,7L,29L,7L,1L,70L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066913Inst : IEnumerable<long>
{
public static readonly long[] Value=A066913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066913.Bytes);
public long this[int i]=>Value[i];

public static A066913Inst Instance=new A066913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066914
{
public static readonly BigInteger[] Value={ 1L,261633L,BigInteger.Parse("1267650562449298664439414784001"),BigInteger.Parse("31828687130226288558838390973198420728675356591453158479231648944377496480115651397025793") };
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
public class A066914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066914Inst Instance=new A066914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066915
{
public static readonly BigInteger[] Value={ 2L,3L,10L,17L,626L,37L,117650L,4097L,531442L,10001L,25937424602L,20737L,23298085122482L,7529537L,2562890626L,4294967297L,BigInteger.Parse("48661191875666868482"),34012225L,BigInteger.Parse("104127350297911241532842"),25600000001L,7355827511386642L };
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
public class A066915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066915Inst Instance=new A066915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066916
{
public static readonly BigInteger[] Value={ 0L,1L,8L,15L,624L,35L,117648L,4095L,531440L,9999L,25937424600L,20735L,23298085122480L,7529535L,2562890624L,4294967295L,BigInteger.Parse("48661191875666868480"),34012223L,BigInteger.Parse("104127350297911241532840"),25599999999L,7355827511386640L };
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
public class A066916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066916Inst Instance=new A066916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066917
{
public static readonly BigInteger[] Value={ 4L,-20L,-216L,2025L,24457L,-661745L,-21930489L,485222400L,12094491106L,-594800640896L,-32850150466188L,1138086428486400L,42791463719713975L,-3042278237035388153L,BigInteger.Parse("-123027745203325414816"),BigInteger.Parse("5708406518410582200000"),BigInteger.Parse("275201338468042020170179") };
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
public class A066917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066917Inst Instance=new A066917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066918
{
public static readonly long[] Value={ 13L,17L,9L,4L,41L,30L,293L,166L,484L,796L,134L,12209L,1646L,467L,4673L,763L,1573L,7279L,37989L,153772L,102051L,377198L,593191L,41552L,677313L,473395L,557448L,5536093L,1643927L,22986338L,1877982L,14184432L,14828672L,23278807L,45383008L,82020263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066918Inst : IEnumerable<long>
{
public static readonly long[] Value=A066918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066918.Bytes);
public long this[int i]=>Value[i];

public static A066918Inst Instance=new A066918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066919
{
public static readonly long[] Value={ 0L,1L,3L,2L,3L,2L,4L,3L,5L,3L,4L,3L,4L,3L,5L,4L,4L,3L,5L,4L,6L,4L,5L,4L,7L,4L,6L,4L,5L,4L,6L,5L,6L,5L,6L,4L,5L,4L,6L,5L,5L,4L,6L,5L,6L,5L,6L,5L,8L,5L,6L,5L,5L,4L,6L,5L,7L,5L,6L,5L,6L,5L,7L,6L,6L,5L,7L,6L,7L,5L,6L,5L,6L,5L,7L,5L,7L,5L,7L,6L,10L,6L,6L,5L,6L,5L,7L,6L,6L,5L,7L,6L,8L,6L,7L,6L,6L,5L,7L,6L,7L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066919Inst : IEnumerable<long>
{
public static readonly long[] Value=A066919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066919.Bytes);
public long this[int i]=>Value[i];

public static A066919Inst Instance=new A066919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066920
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,4L,4L,6L,7L,7L,9L,11L,12L,15L,18L,19L,23L,26L,28L,34L,39L,42L,49L,56L,60L,69L,79L,85L,97L,110L,118L,133L,150L,162L,181L,203L,219L,243L,271L,292L,323L,359L,387L,425L,471L,507L,554L,612L,659L,719L,791L,851L,924L,1012L,1089L,1179L,1289L,1386L,1497L,1630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066920Inst : IEnumerable<long>
{
public static readonly long[] Value=A066920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066920.Bytes);
public long this[int i]=>Value[i];

public static A066920Inst Instance=new A066920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066921
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,1L,6L,1L,2L,2L,4L,1L,6L,1L,6L,2L,2L,1L,4L,2L,2L,3L,6L,1L,3L,1L,5L,2L,2L,2L,4L,1L,2L,2L,4L,1L,3L,1L,6L,6L,2L,1L,10L,2L,6L,2L,6L,1L,4L,2L,4L,2L,2L,1L,12L,1L,2L,6L,6L,2L,3L,1L,6L,2L,3L,1L,10L,1L,2L,6L,6L,2L,3L,1L,10L,4L,2L,1L,12L,2L,2L,2L,4L,1L,12L,2L,6L,2L,2L,2L,6L,1L,6L,6L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066921Inst : IEnumerable<long>
{
public static readonly long[] Value=A066921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066921.Bytes);
public long this[int i]=>Value[i];

public static A066921Inst Instance=new A066921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066922
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,3L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,1L,1L,2L,1L,2L,2L,2L,2L,1L,1L,1L,2L,1L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066922Inst : IEnumerable<long>
{
public static readonly long[] Value=A066922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066922.Bytes);
public long this[int i]=>Value[i];

public static A066922Inst Instance=new A066922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066923
{
public static readonly long[] Value={ 118L,12L,443L,190L,40L,16L,5847L,180L,108L,48L,1427L,670510L,2388L,228L,407L,1577L,424L,2500L,2500383L,22848L,4853L,1240L,323975L,0L,10668L,588L,10727L,45677L,18713L,1903672L,0L,0L,119028L,18880L,391659L,0L,883428L,480036L,1635467L,896933L,50380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066923Inst : IEnumerable<long>
{
public static readonly long[] Value=A066923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066923.Bytes);
public long this[int i]=>Value[i];

public static A066923Inst Instance=new A066923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066924
{
public static readonly long[] Value={ 1L,4L,9L,36L,345L,6489L,88473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066924Inst : IEnumerable<long>
{
public static readonly long[] Value=A066924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066924.Bytes);
public long this[int i]=>Value[i];

public static A066924Inst Instance=new A066924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066925
{
public static readonly long[] Value={ 1L,4L,9L,16L,18L,24L,25L,30L,36L,40L,48L,49L,64L,70L,72L,81L,84L,90L,96L,100L,108L,112L,120L,121L,126L,144L,150L,154L,160L,162L,168L,169L,180L,192L,196L,198L,204L,208L,210L,216L,220L,225L,228L,234L,240L,250L,252L,256L,264L,270L,276L,280L,286L,288L,289L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066925Inst : IEnumerable<long>
{
public static readonly long[] Value=A066925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066925.Bytes);
public long this[int i]=>Value[i];

public static A066925Inst Instance=new A066925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066926
{
public static readonly long[] Value={ 1L,4L,9L,16L,18L,24L,25L,30L,36L,40L,48L,49L,60L,64L,70L,72L,81L,84L,90L,96L,100L,105L,108L,112L,120L,121L,126L,132L,144L,150L,154L,156L,160L,162L,168L,169L,180L,192L,196L,198L,204L,208L,210L,216L,220L,225L,228L,234L,240L,250L,252L,256L,264L,270L,273L,276L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066926Inst : IEnumerable<long>
{
public static readonly long[] Value=A066926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066926.Bytes);
public long this[int i]=>Value[i];

public static A066926Inst Instance=new A066926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066927
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066927Inst : IEnumerable<long>
{
public static readonly long[] Value=A066927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066927.Bytes);
public long this[int i]=>Value[i];

public static A066927Inst Instance=new A066927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066928
{
public static readonly long[] Value={ 3L,4L,7L,9L,10L,12L,20L,29L,65L,67L,72L,73L,86L,93L,97L,98L,107L,117L,140L,143L,146L,147L,148L,150L,151L,153L,156L,182L,183L,186L,192L,194L,205L,206L,207L,211L,227L,228L,235L,236L,241L,248L,249L,253L,259L,270L,273L,279L,283L,289L,292L,298L,325L,330L,347L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066928Inst : IEnumerable<long>
{
public static readonly long[] Value=A066928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066928.Bytes);
public long this[int i]=>Value[i];

public static A066928Inst Instance=new A066928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066929
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,14L,15L,27L,28L,30L,42L,44L,45L,50L,52L,56L,60L,81L,84L,88L,90L,100L,104L,126L,132L,135L,136L,140L,162L,168L,176L,180L,200L,208L,243L,252L,264L,270L,272L,280L,300L,304L,312L,368L,378L,392L,396L,416L,486L,504L,528L,540L,544L,560L,600L,608L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066929Inst : IEnumerable<long>
{
public static readonly long[] Value=A066929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066929.Bytes);
public long this[int i]=>Value[i];

public static A066929Inst Instance=new A066929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066930
{
public static readonly long[] Value={ 1L,7L,9L,29L,71L,97L,109L,121L,139L,142L,175L,183L,194L,215L,225L,242L,244L,261L,278L,311L,344L,349L,355L,430L,497L,509L,516L,533L,556L,571L,605L,622L,631L,647L,673L,709L,729L,791L,817L,859L,911L,923L,1021L,1066L,1112L,1119L,1142L,1207L,1243L,1262L,1277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066930Inst : IEnumerable<long>
{
public static readonly long[] Value=A066930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066930.Bytes);
public long this[int i]=>Value[i];

public static A066930Inst Instance=new A066930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066931
{
public static readonly BigInteger[] Value={ 1L,1L,6L,113L,20174L,22306955L,123222909271L,3283834214485890L,BigInteger.Parse("421263391026827547540"),BigInteger.Parse("260028731850596651411721718"),BigInteger.Parse("772086476515163830856527013278243"),BigInteger.Parse("11025620741283840573496993339545350520150"),BigInteger.Parse("757129347300072898736973484532998417574513923224") };
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
public class A066931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066931Inst Instance=new A066931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066932
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,21L,224L,10848L,4843293L,98262557120L,989063619297120960L,BigInteger.Parse("197348115975871052843094930213"),BigInteger.Parse("380244324677612882673067751880150651746235378560") };
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
public class A066932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066932Inst Instance=new A066932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066933
{
public static readonly BigInteger[] Value={ 1L,2L,-5L,-70L,1275L,97748L,-2713585L,-251983958L,9651414311L,1137214908700L,-268100912462097L,-16553358418854560L,4303513869962179379L,BigInteger.Parse("602501593820064477686"),BigInteger.Parse("-50199332236439321779977"),BigInteger.Parse("-7847812115804566640572424"),BigInteger.Parse("2754406130856424049914030863") };
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
public class A066933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066933Inst Instance=new A066933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066934
{
public static readonly long[] Value={ 8L,12L,32L,48L,75L,108L,110L,125L,128L,170L,192L,208L,230L,280L,290L,312L,363L,368L,374L,405L,410L,420L,470L,506L,530L,552L,590L,638L,680L,684L,688L,702L,710L,782L,830L,848L,867L,890L,902L,935L,980L,986L,1008L,1010L,1020L,1032L,1034L,1044L,1070L,1080L,1088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066934Inst : IEnumerable<long>
{
public static readonly long[] Value=A066934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066934.Bytes);
public long this[int i]=>Value[i];

public static A066934Inst Instance=new A066934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066935
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,14L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,44L,47L,53L,55L,57L,59L,61L,63L,67L,71L,73L,75L,79L,83L,85L,86L,87L,89L,93L,94L,95L,97L,98L,101L,103L,107L,109L,113L,116L,118L,121L,122L,124L,127L,131L,133L,134L,135L,137L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066935Inst : IEnumerable<long>
{
public static readonly long[] Value=A066935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066935.Bytes);
public long this[int i]=>Value[i];

public static A066935Inst Instance=new A066935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066936
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,10L,11L,12L,14L,18L,21L,24L,30L,38L,42L,46L,67L,84L,87L,110L,121L,136L,159L,279L,306L,378L,428L,439L,516L,662L,682L,726L,1046L,1110L,1199L,1410L,1687L,2160L,2244L,2438L,2450L,2612L,2614L,2654L,3270L,3477L,3829L,7107L,7178L,8682L,9260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066936Inst : IEnumerable<long>
{
public static readonly long[] Value=A066936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066936.Bytes);
public long this[int i]=>Value[i];

public static A066936Inst Instance=new A066936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066937
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,6L,8L,11L,10L,13L,9L,17L,12L,19L,14L,23L,16L,20L,15L,29L,31L,22L,18L,25L,21L,26L,37L,24L,41L,43L,27L,34L,28L,47L,32L,38L,53L,35L,40L,33L,59L,44L,30L,61L,46L,49L,50L,39L,67L,42L,71L,36L,73L,58L,55L,79L,52L,48L,62L,83L,65L,51L,45L,89L,56L,57L,74L,97L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066937Inst : IEnumerable<long>
{
public static readonly long[] Value=A066937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066937.Bytes);
public long this[int i]=>Value[i];

public static A066937Inst Instance=new A066937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066938
{
public static readonly long[] Value={ 11L,17L,23L,31L,41L,47L,53L,59L,71L,79L,83L,89L,107L,113L,127L,131L,151L,167L,179L,191L,227L,239L,251L,263L,269L,271L,293L,311L,359L,383L,419L,431L,439L,443L,449L,479L,491L,503L,521L,587L,593L,599L,607L,631L,647L,659L,683L,701L,719L,727L,743L,773L,809L,827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066938Inst : IEnumerable<long>
{
public static readonly long[] Value=A066938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066938.Bytes);
public long this[int i]=>Value[i];

public static A066938Inst Instance=new A066938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066939
{
public static readonly long[] Value={ 13954L,106899L,307835L,783201L,979731L,2980255L,9266817L,18479215L,49062925L,109044425L,114029313L,120914101L,185480686L,218223299L,347941741L,429365395L,466423743L,492508289L,610803875L,895938847L,993189741L,1093958383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066939Inst : IEnumerable<long>
{
public static readonly long[] Value=A066939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066939.Bytes);
public long this[int i]=>Value[i];

public static A066939Inst Instance=new A066939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066940
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,17L,18L,20L,21L,24L,25L,26L,28L,29L,30L,33L,35L,36L,37L,41L,42L,43L,44L,45L,49L,50L,52L,53L,57L,58L,59L,60L,61L,64L,65L,66L,67L,68L,69L,70L,73L,74L,77L,78L,79L,81L,82L,83L,84L,87L,88L,89L,98L,99L,100L,101L,104L,105L,106L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066940Inst : IEnumerable<long>
{
public static readonly long[] Value=A066940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066940.Bytes);
public long this[int i]=>Value[i];

public static A066940Inst Instance=new A066940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066941
{
public static readonly long[] Value={ 4L,8L,14L,19L,22L,27L,31L,38L,46L,47L,48L,63L,75L,85L,90L,93L,94L,95L,114L,117L,124L,131L,143L,149L,153L,154L,155L,163L,181L,192L,207L,213L,224L,229L,232L,235L,241L,242L,247L,248L,249L,261L,276L,285L,299L,303L,304L,314L,327L,328L,333L,334L,335L,348L,364L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066941Inst : IEnumerable<long>
{
public static readonly long[] Value=A066941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066941.Bytes);
public long this[int i]=>Value[i];

public static A066941Inst Instance=new A066941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066942
{
public static readonly long[] Value={ 9L,15L,16L,23L,32L,39L,40L,51L,54L,55L,56L,71L,76L,86L,96L,97L,102L,103L,107L,108L,118L,119L,123L,139L,160L,161L,164L,165L,170L,184L,185L,194L,195L,199L,200L,208L,218L,219L,227L,238L,245L,252L,255L,267L,290L,291L,292L,293L,298L,311L,312L,329L,342L,345L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066942Inst : IEnumerable<long>
{
public static readonly long[] Value=A066942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066942.Bytes);
public long this[int i]=>Value[i];

public static A066942Inst Instance=new A066942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066943
{
public static readonly long[] Value={ 72L,92L,128L,132L,156L,166L,228L,246L,281L,282L,386L,417L,507L,519L,619L,620L,640L,641L,661L,712L,738L,739L,759L,801L,853L,898L,915L,1000L,1077L,1152L,1241L,1246L,1273L,1289L,1297L,1364L,1389L,1421L,1489L,1493L,1525L,1543L,1564L,1632L,1691L,1699L,1729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066943Inst : IEnumerable<long>
{
public static readonly long[] Value=A066943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066943.Bytes);
public long this[int i]=>Value[i];

public static A066943Inst Instance=new A066943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066944
{
public static readonly long[] Value={ 34L,80L,127L,145L,157L,175L,204L,222L,266L,289L,308L,316L,397L,442L,443L,518L,525L,578L,593L,656L,690L,746L,757L,773L,793L,832L,861L,866L,892L,908L,923L,949L,958L,971L,985L,1013L,1029L,1051L,1071L,1102L,1125L,1195L,1236L,1314L,1329L,1340L,1350L,1403L,1434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066944Inst : IEnumerable<long>
{
public static readonly long[] Value=A066944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066944.Bytes);
public long this[int i]=>Value[i];

public static A066944Inst Instance=new A066944Inst();

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