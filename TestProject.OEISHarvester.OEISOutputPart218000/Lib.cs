using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256382
{
public static readonly long[] Value={ 10L,18L,29L,30L,42L,53L,61L,73L,78L,81L,89L,90L,91L,115L,119L,125L,137L,138L,162L,165L,173L,181L,198L,205L,209L,210L,213L,217L,222L,258L,263L,291L,295L,299L,305L,323L,325L,330L,331L,390L,399L,407L,411L,441L,449L,450L,462L,477L,485L,489L,493L,497L,501L,515L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256382Inst : IEnumerable<long>
{
public static readonly long[] Value=A256382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256382.Bytes);
public long this[int i]=>Value[i];

public static A256382Inst Instance=new A256382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256383
{
public static readonly long[] Value={ 9L,20L,30L,44L,60L,82L,90L,116L,124L,128L,138L,150L,164L,182L,208L,210L,214L,242L,254L,294L,296L,300L,304L,314L,324L,334L,360L,366L,376L,386L,398L,408L,412L,422L,432L,442L,476L,506L,510L,522L,524L,532L,538L,540L,548L,578L,584L,586L,628L,674L,676L,684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256383Inst : IEnumerable<long>
{
public static readonly long[] Value=A256383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256383.Bytes);
public long this[int i]=>Value[i];

public static A256383Inst Instance=new A256383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256384
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,3L,1L,1L,1L,14L,19L,5L,1L,1L,1L,41L,171L,74L,7L,1L,1L,1L,122L,1675L,1975L,248L,11L,1L,1L,1L,365L,16683L,64182L,20096L,814L,15L,1L,1L,1L,1094L,166699L,2203215L,2213016L,187921L,2457L,22L,1L,1L,1L,3281L,1666731L,76727374L,268446852L,69406700L,1609727L,7168L,30L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256384Inst : IEnumerable<long>
{
public static readonly long[] Value=A256384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256384.Bytes);
public long this[int i]=>Value[i];

public static A256384Inst Instance=new A256384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256385
{
public static readonly long[] Value={ 8L,10L,11L,15L,16L,20L,26L,27L,28L,31L,33L,36L,37L,40L,41L,43L,44L,45L,46L,49L,53L,54L,55L,57L,58L,59L,61L,64L,67L,68L,71L,73L,74L,75L,77L,78L,80L,83L,88L,89L,91L,92L,93L,95L,98L,101L,103L,105L,106L,107L,108L,111L,112L,113L,114L,116L,117L,118L,120L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256385Inst : IEnumerable<long>
{
public static readonly long[] Value=A256385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256385.Bytes);
public long this[int i]=>Value[i];

public static A256385Inst Instance=new A256385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256386
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,11L,59L,1319L,1619L,4259L,5099L,6659L,6779L,11699L,12539L,21059L,66359L,83219L,88259L,107099L,110879L,114659L,127679L,130199L,140759L,141959L,144539L,148199L,149519L,157559L,161339L,163859L,175079L,186479L,204599L,230939L,249539L,267959L,273899L,312839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256386Inst : IEnumerable<long>
{
public static readonly long[] Value=A256386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256386.Bytes);
public long this[int i]=>Value[i];

public static A256386Inst Instance=new A256386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256387
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,19L,21L,23L,25L,29L,31L,33L,35L,37L,41L,43L,45L,47L,49L,51L,53L,55L,59L,61L,63L,65L,67L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,101L,103L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,137L,139L,141L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256387Inst : IEnumerable<long>
{
public static readonly long[] Value=A256387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256387.Bytes);
public long this[int i]=>Value[i];

public static A256387Inst Instance=new A256387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256388
{
public static readonly long[] Value={ 1L,3L,9L,15L,27L,39L,57L,69L,99L,105L,135L,147L,177L,189L,195L,225L,237L,267L,279L,309L,345L,417L,429L,459L,519L,567L,597L,615L,639L,657L,807L,819L,825L,855L,879L,1017L,1029L,1047L,1059L,1089L,1149L,1227L,1275L,1287L,1299L,1317L,1425L,1449L,1479L,1485L,1605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256388Inst : IEnumerable<long>
{
public static readonly long[] Value=A256388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256388.Bytes);
public long this[int i]=>Value[i];

public static A256388Inst Instance=new A256388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256389
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,22L,24L,26L,27L,28L,30L,32L,34L,36L,38L,39L,40L,42L,44L,46L,48L,50L,52L,54L,56L,57L,58L,60L,62L,64L,66L,68L,69L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256389Inst : IEnumerable<long>
{
public static readonly long[] Value=A256389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256389.Bytes);
public long this[int i]=>Value[i];

public static A256389Inst Instance=new A256389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256390
{
public static readonly long[] Value={ 1L,4L,13L,22L,55L,64L,133L,172L,247L,280L,469L,508L,781L,868L,997L,1144L,1621L,1714L,2323L,2488L,2785L,3010L,3907L,4078L,4837L,5176L,5833L,6178L,7627L,7798L,9463L,10102L,10927L,11530L,12631L,13006L,15379L,16150L,17311L,17926L,20863L,21256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256390Inst : IEnumerable<long>
{
public static readonly long[] Value=A256390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256390.Bytes);
public long this[int i]=>Value[i];

public static A256390Inst Instance=new A256390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256391
{
public static readonly long[] Value={ 1L,7L,35L,79L,243L,319L,787L,1155L,1859L,2295L,4267L,4891L,8295L,9743L,11851L,14539L,22191L,24359L,35427L,39387L,45915L,51687L,71171L,76407L,94911L,105047L,123251L,134447L,174003L,180835L,229783L,253007L,281447L,305111L,343315L,360215L,442547L,476115L,523111L,552307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256391Inst : IEnumerable<long>
{
public static readonly long[] Value=A256391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256391.Bytes);
public long this[int i]=>Value[i];

public static A256391Inst Instance=new A256391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256392
{
public static readonly long[] Value={ 2L,1L,7L,7L,7L,8L,7L,1L,6L,6L,1L,9L,5L,3L,6L,3L,7L,8L,3L,2L,3L,0L,0L,7L,5L,1L,4L,1L,1L,9L,4L,4L,6L,8L,1L,3L,1L,3L,0L,7L,9L,7L,7L,5L,5L,0L,0L,1L,3L,5L,5L,9L,3L,7L,6L,4L,8L,2L,7L,6L,4L,0L,3L,5L,2L,3L,6L,2L,6L,4L,9L,1L,1L,1L,2L,2L,5L,2L,6L,2L,0L,5L,5L,7L,9L,2L,5L,4L,4L,3L,8L,2L,3L,5L,6L,3L,7L,6L,5L,6L,9L,1L,8L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256392Inst : IEnumerable<long>
{
public static readonly long[] Value=A256392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256392.Bytes);
public long this[int i]=>Value[i];

public static A256392Inst Instance=new A256392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256393
{
public static readonly long[] Value={ 2L,4L,6L,9L,12L,15L,18L,21L,24L,27L,30L,35L,40L,45L,48L,51L,54L,57L,60L,65L,70L,77L,84L,91L,98L,105L,108L,111L,114L,133L,140L,147L,150L,155L,160L,165L,168L,175L,180L,185L,190L,209L,220L,231L,234L,247L,260L,273L,276L,299L,312L,325L,330L,341L,352L,363L,366L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256393Inst : IEnumerable<long>
{
public static readonly long[] Value=A256393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256393.Bytes);
public long this[int i]=>Value[i];

public static A256393Inst Instance=new A256393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256394
{
public static readonly long[] Value={ 2L,3L,11L,67L,71L,439L,1051L,6469L,40087L,100361L,100363L,251737L,251761L,637319L,637327L,4124459L,10553513L,10553551L,27067277L,69709733L,179993171L,465769817L,3140421769L,8179002109L,8179002133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256394Inst : IEnumerable<long>
{
public static readonly long[] Value=A256394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256394.Bytes);
public long this[int i]=>Value[i];

public static A256394Inst Instance=new A256394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256395
{
public static readonly long[] Value={ 34L,169L,194L,610L,985L,1325L,4181L,6466L,9077L,10946L,14701L,37666L,51641L,62210L,75025L,135137L,195025L,196418L,294685L,499393L,646018L,925765L,1136689L,1278818L,1346269L,1441889L,2012674L,2423525L,3524578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256395Inst : IEnumerable<long>
{
public static readonly long[] Value=A256395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256395.Bytes);
public long this[int i]=>Value[i];

public static A256395Inst Instance=new A256395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256396
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,19L,29L,37L,53L,59L,61L,67L,79L,83L,97L,101L,103L,107L,131L,139L,149L,163L,173L,179L,181L,193L,197L,199L,211L,227L,269L,271L,293L,307L,313L,317L,347L,349L,367L,373L,379L,389L,409L,419L,421L,439L,443L,461L,463L,467L,487L,491L,499L,509L,523L,541L,547L,557L,563L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256396Inst : IEnumerable<long>
{
public static readonly long[] Value=A256396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256396.Bytes);
public long this[int i]=>Value[i];

public static A256396Inst Instance=new A256396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256397
{
public static readonly long[] Value={ 17L,23L,41L,47L,71L,89L,113L,137L,167L,191L,233L,239L,257L,263L,281L,311L,353L,359L,383L,401L,431L,449L,479L,503L,521L,569L,593L,599L,617L,641L,647L,719L,743L,761L,809L,839L,857L,863L,881L,887L,911L,929L,953L,977L,983L,1031L,1049L,1097L,1103L,1151L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256397Inst : IEnumerable<long>
{
public static readonly long[] Value=A256397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256397.Bytes);
public long this[int i]=>Value[i];

public static A256397Inst Instance=new A256397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256398
{
public static readonly long[] Value={ 0L,2L,8L,101L,242L,404L,585L,909L,10001L,12221L,14841L,20402L,24642L,40004L,44244L,48884L,50805L,90009L,96269L,1000001L,1030301L,1080801L,1210121L,1244421L,1298921L,1440441L,1478741L,1690961L,2004002L,2234322L,2468642L,2484842L,4000004L,4050504L,4410144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256398Inst : IEnumerable<long>
{
public static readonly long[] Value=A256398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256398.Bytes);
public long this[int i]=>Value[i];

public static A256398Inst Instance=new A256398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256399
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,3L,1L,3L,8L,3L,5L,4L,3L,1L,4L,10L,1L,4L,4L,4L,4L,7L,4L,9L,3L,1L,4L,3L,4L,16L,4L,4L,4L,8L,1L,8L,7L,1L,8L,4L,4L,8L,3L,4L,4L,8L,16L,1L,3L,1L,11L,1L,4L,12L,7L,5L,3L,1L,8L,3L,5L,19L,4L,1L,3L,16L,5L,11L,1L,4L,4L,11L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256399Inst : IEnumerable<long>
{
public static readonly long[] Value=A256399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256399.Bytes);
public long this[int i]=>Value[i];

public static A256399Inst Instance=new A256399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256400
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,7L,16L,67L,88L,617L,2626L,18176L,6949L,423271L,2172172L,19151162L,58438907L,899510224L,7656246634L,1236339998L,460251204914L,6682341795214L,55431849118769L,58399157390146L,2845938531282919L,54648005951674444L,12207653488921678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256400Inst : IEnumerable<long>
{
public static readonly long[] Value=A256400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256400.Bytes);
public long this[int i]=>Value[i];

public static A256400Inst Instance=new A256400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256401
{
public static readonly long[] Value={ 1L,-1L,0L,1L,-1L,1L,1L,-5L,-8L,43L,-74L,-559L,697L,-13232L,-30727L,450991L,-5519014L,8250311L,59081053L,-2113948301L,19352683736L,-113555728681L,-4421555920L,10403170713454L,4947541575776L,-1037548987977353L,4668788227294924L,20521746955820009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256401Inst : IEnumerable<long>
{
public static readonly long[] Value=A256401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256401.Bytes);
public long this[int i]=>Value[i];

public static A256401Inst Instance=new A256401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256402
{
public static readonly ulong[] Value={ 1L,1L,1L,3L,3L,5L,45L,63L,105L,405L,14175L,17325L,18711L,552825L,14189175L,49116375L,91216125L,144729585L,97692469875L,109185701625L,1031198293125L,10257709336875L,3430178002251L,2348038513445625L,1034450533895625L,160789593855515625L,16025362854266390625UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256402Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A256402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256402.Bytes);
public ulong this[int i]=>Value[i];

public static A256402Inst Instance=new A256402Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256403
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,21L,24L,69L,201L,213L,319L,469L,519L,1141L,2321L,39203L,72899L,324899L,359999L,675683L,777923L,1127843L,4536899L,6718463L,10036223L,30272003L,44916803L,54022499L,100761443L,108743183L,110249999L,212051843L,233722943L,289952783L,326163599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256403Inst : IEnumerable<long>
{
public static readonly long[] Value=A256403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256403.Bytes);
public long this[int i]=>Value[i];

public static A256403Inst Instance=new A256403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256404
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,13L,17L,22L,25L,70L,82L,158L,174L,184L,194L,261L,293L,331L,616L,745L,983L,1076L,1672L,2177L,2821L,3599L,6591L,7804L,10174L,11629L,13141L,13397L,15589L,17767L,18814L,19859L,21112L,21247L,23242L,24785L,34351L,36447L,40122L,45630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256404Inst : IEnumerable<long>
{
public static readonly long[] Value=A256404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256404.Bytes);
public long this[int i]=>Value[i];

public static A256404Inst Instance=new A256404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256405
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,5L,5L,9L,9L,9L,9L,13L,13L,13L,13L,17L,17L,17L,17L,17L,22L,22L,22L,25L,25L,25L,25L,25L,29L,29L,29L,29L,29L,29L,29L,29L,29L,29L,29L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256405Inst : IEnumerable<long>
{
public static readonly long[] Value=A256405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256405.Bytes);
public long this[int i]=>Value[i];

public static A256405Inst Instance=new A256405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256406
{
public static readonly long[] Value={ 3L,198L,270L,570L,522L,600L,822L,882L,1062L,2130L,1950L,2592L,2268L,2310L,3168L,2970L,5502L,6702L,5022L,7350L,10038L,10428L,10500L,9438L,14562L,14010L,15288L,17028L,18060L,19698L,17958L,19890L,18522L,20772L,29670L,20550L,22158L,16650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256406Inst : IEnumerable<long>
{
public static readonly long[] Value=A256406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256406.Bytes);
public long this[int i]=>Value[i];

public static A256406Inst Instance=new A256406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256407
{
public static readonly long[] Value={ 3L,198L,270L,522L,570L,600L,822L,882L,1062L,1950L,2130L,2268L,2310L,2592L,2970L,3168L,5022L,5502L,6702L,7350L,9438L,10038L,10428L,10500L,14010L,14562L,15288L,16650L,17028L,17958L,18060L,18522L,19698L,19890L,20550L,20718L,20772L,22158L,22638L,23058L,23562L,24108L,25170L,25602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256407Inst : IEnumerable<long>
{
public static readonly long[] Value=A256407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256407.Bytes);
public long this[int i]=>Value[i];

public static A256407Inst Instance=new A256407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256408
{
public static readonly long[] Value={ 2L,3L,5L,9L,13L,17L,22L,25L,29L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,81L,86L,89L,97L,100L,146L,153L,154L,169L,196L,198L,249L,253L,300L,337L,340L,409L,411L,412L,414L,449L,587L,589L,610L,625L,958L,1201L,1202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256408Inst : IEnumerable<long>
{
public static readonly long[] Value=A256408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256408.Bytes);
public long this[int i]=>Value[i];

public static A256408Inst Instance=new A256408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256409
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,21L,24L,29L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,81L,93L,102L,111L,114L,163L,171L,198L,199L,259L,281L,292L,302L,426L,433L,451L,533L,550L,585L,586L,617L,747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256409Inst : IEnumerable<long>
{
public static readonly long[] Value=A256409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256409.Bytes);
public long this[int i]=>Value[i];

public static A256409Inst Instance=new A256409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256410
{
public static readonly long[] Value={ 2L,197L,269L,521L,569L,599L,821L,881L,1061L,1949L,2129L,2267L,2309L,2591L,2969L,3167L,5021L,5501L,6701L,7349L,9437L,10037L,10427L,10499L,14009L,14561L,15287L,16649L,17027L,17957L,18059L,18521L,19697L,19889L,20549L,20717L,20771L,22157L,22637L,23057L,23561L,24107L,25169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256410Inst : IEnumerable<long>
{
public static readonly long[] Value=A256410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256410.Bytes);
public long this[int i]=>Value[i];

public static A256410Inst Instance=new A256410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256411
{
public static readonly long[] Value={ 1L,2L,8L,3L,37L,113L,4L,145L,1257L,3492L,5L,452L,9020L,67394L,183732L,6L,1374L,60826L,938194L,6398792L,17061118L,7L,3933L,356023L,30492722L,466578957L,3032145644L,7743056064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256411Inst : IEnumerable<long>
{
public static readonly long[] Value=A256411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256411.Bytes);
public long this[int i]=>Value[i];

public static A256411Inst Instance=new A256411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256412
{
public static readonly long[] Value={ 8L,37L,145L,452L,1374L,3933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256412Inst : IEnumerable<long>
{
public static readonly long[] Value=A256412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256412.Bytes);
public long this[int i]=>Value[i];

public static A256412Inst Instance=new A256412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256413
{
public static readonly long[] Value={ 1L,1L,5L,14L,64L,189L,841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256413Inst : IEnumerable<long>
{
public static readonly long[] Value=A256413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256413.Bytes);
public long this[int i]=>Value[i];

public static A256413Inst Instance=new A256413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256414
{
public static readonly long[] Value={ 2L,3L,10L,13L,21L,26L,34L,35L,47L,54L,61L,68L,77L,82L,91L,100L,109L,118L,127L,136L,137L,151L,156L,168L,181L,191L,201L,208L,209L,217L,240L,245L,262L,263L,278L,292L,299L,307L,320L,329L,339L,346L,367L,370L,379L,380L,405L,420L,433L,441L,446L,456L,461L,474L,488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256414Inst : IEnumerable<long>
{
public static readonly long[] Value=A256414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256414.Bytes);
public long this[int i]=>Value[i];

public static A256414Inst Instance=new A256414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256415
{
public static readonly long[] Value={ 1L,4L,6L,4L,10L,4L,14L,8L,6L,10L,22L,12L,26L,14L,10L,16L,34L,18L,38L,20L,14L,22L,46L,24L,25L,26L,27L,28L,58L,30L,62L,32L,22L,34L,35L,36L,74L,38L,26L,40L,82L,42L,86L,44L,45L,46L,94L,48L,49L,50L,34L,52L,106L,54L,55L,56L,38L,58L,118L,60L,122L,62L,63L,64L,65L,66L,134L,68L,46L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256415Inst : IEnumerable<long>
{
public static readonly long[] Value=A256415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256415.Bytes);
public long this[int i]=>Value[i];

public static A256415Inst Instance=new A256415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256416
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,6L,8L,10L,10L,10L,12L,14L,14L,14L,16L,18L,20L,22L,22L,22L,24L,25L,26L,26L,26L,27L,28L,30L,32L,34L,34L,34L,35L,36L,38L,38L,38L,40L,42L,44L,45L,46L,46L,46L,48L,49L,50L,52L,54L,55L,56L,58L,58L,58L,60L,62L,62L,62L,63L,64L,65L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256416Inst : IEnumerable<long>
{
public static readonly long[] Value=A256416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256416.Bytes);
public long this[int i]=>Value[i];

public static A256416Inst Instance=new A256416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256417
{
public static readonly long[] Value={ 1L,4L,4L,4L,6L,6L,12L,8L,10L,10L,10L,18L,14L,14L,14L,24L,16L,20L,22L,22L,22L,27L,30L,25L,35L,28L,26L,26L,26L,36L,32L,34L,34L,34L,42L,38L,38L,38L,45L,40L,44L,46L,46L,46L,48L,50L,52L,54L,56L,49L,63L,60L,55L,65L,70L,58L,58L,58L,66L,62L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256417Inst : IEnumerable<long>
{
public static readonly long[] Value=A256417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256417.Bytes);
public long this[int i]=>Value[i];

public static A256417Inst Instance=new A256417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256418
{
public static readonly long[] Value={ 24L,96L,120L,216L,240L,336L,384L,480L,600L,720L,840L,864L,960L,1080L,1176L,1320L,1344L,1536L,1920L,1944L,2016L,2160L,2184L,2400L,2520L,2880L,2904L,3000L,3024L,3360L,3456L,3696L,3840L,3960L,4056L,4320L,4704L,4896L,5280L,5376L,5400L,5544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256418Inst : IEnumerable<long>
{
public static readonly long[] Value=A256418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256418.Bytes);
public long this[int i]=>Value[i];

public static A256418Inst Instance=new A256418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256419
{
public static readonly long[] Value={ 1L,4L,6L,4L,4L,8L,6L,10L,12L,10L,14L,10L,14L,18L,14L,16L,24L,20L,22L,25L,22L,30L,22L,26L,27L,26L,36L,26L,28L,42L,32L,34L,38L,34L,38L,34L,38L,45L,48L,35L,40L,49L,44L,56L,46L,50L,46L,52L,46L,54L,60L,58L,55L,58L,65L,58L,70L,63L,62L,66L,62L,64L,62L,68L,72L,74L,75L,74L,78L,74L,76L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256419Inst : IEnumerable<long>
{
public static readonly long[] Value=A256419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256419.Bytes);
public long this[int i]=>Value[i];

public static A256419Inst Instance=new A256419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256420
{
public static readonly long[] Value={ 2L,1L,3L,8L,4L,12L,5L,16L,18L,20L,6L,24L,7L,28L,30L,32L,9L,36L,10L,40L,42L,44L,11L,48L,50L,52L,54L,56L,13L,60L,14L,64L,66L,68L,70L,72L,15L,76L,78L,80L,17L,84L,19L,88L,90L,92L,21L,96L,98L,100L,102L,104L,22L,108L,110L,112L,114L,116L,23L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256420Inst : IEnumerable<long>
{
public static readonly long[] Value=A256420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256420.Bytes);
public long this[int i]=>Value[i];

public static A256420Inst Instance=new A256420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256421
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,63L,65L,67L,69L,71L,73L,74L,75L,77L,79L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256421Inst : IEnumerable<long>
{
public static readonly long[] Value=A256421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256421.Bytes);
public long this[int i]=>Value[i];

public static A256421Inst Instance=new A256421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256422
{
public static readonly long[] Value={ 5L,293L,331L,616L,745L,983L,1076L,1672L,2177L,2821L,3599L,6591L,7804L,10174L,11629L,13141L,13397L,15589L,17767L,18814L,19859L,21112L,21247L,23242L,24785L,34351L,36447L,40122L,45630L,48033L,51235L,51519L,61179L,63826L,73394L,78624L,80112L,88259L,89607L,102217L,115981L,119167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256422Inst : IEnumerable<long>
{
public static readonly long[] Value=A256422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256422.Bytes);
public long this[int i]=>Value[i];

public static A256422Inst Instance=new A256422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256423
{
public static readonly long[] Value={ 8L,39203L,72899L,324899L,359999L,675683L,777923L,1127843L,4536899L,6718463L,10036223L,30272003L,44916803L,54022499L,100761443L,108743183L,110249999L,212051843L,233722943L,289952783L,326163599L,388011203L,395612099L,431475983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256423Inst : IEnumerable<long>
{
public static readonly long[] Value=A256423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256423.Bytes);
public long this[int i]=>Value[i];

public static A256423Inst Instance=new A256423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256424
{
public static readonly long[] Value={ 1L,4L,6L,4L,4L,8L,6L,10L,12L,10L,14L,10L,14L,18L,14L,16L,27L,20L,22L,24L,22L,26L,22L,26L,28L,26L,32L,30L,34L,25L,34L,35L,34L,40L,42L,38L,36L,38L,44L,38L,46L,45L,46L,48L,46L,50L,54L,52L,58L,56L,58L,49L,58L,63L,60L,77L,62L,55L,62L,65L,62L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256424Inst : IEnumerable<long>
{
public static readonly long[] Value=A256424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256424.Bytes);
public long this[int i]=>Value[i];

public static A256424Inst Instance=new A256424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256425
{
public static readonly long[] Value={ 6L,7L,7L,8L,0L,7L,1L,6L,3L,7L,8L,4L,2L,3L,2L,2L,1L,0L,5L,3L,3L,7L,2L,4L,6L,1L,2L,4L,5L,4L,9L,1L,4L,3L,8L,3L,1L,6L,9L,3L,1L,2L,5L,7L,9L,6L,3L,2L,5L,5L,6L,2L,0L,4L,1L,5L,2L,6L,8L,5L,6L,2L,3L,1L,3L,2L,5L,5L,8L,8L,2L,1L,3L,1L,6L,7L,1L,5L,3L,6L,5L,4L,0L,5L,2L,7L,2L,4L,7L,8L,2L,6L,8L,2L,1L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256425Inst : IEnumerable<long>
{
public static readonly long[] Value=A256425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256425.Bytes);
public long this[int i]=>Value[i];

public static A256425Inst Instance=new A256425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256426
{
public static readonly long[] Value={ 2L,3L,5L,17L,44L,47L,78L,504L,533L,768L,915L,1155L,1313L,7128L,8088L,15717L,33074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256426Inst : IEnumerable<long>
{
public static readonly long[] Value=A256426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256426.Bytes);
public long this[int i]=>Value[i];

public static A256426Inst Instance=new A256426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256427
{
public static readonly long[] Value={ 3L,2L,1L,2L,3L,3L,3L,2L,2L,2L,3L,5L,5L,3L,2L,1L,2L,3L,3L,3L,3L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,3L,3L,2L,2L,2L,3L,5L,5L,3L,2L,1L,2L,3L,3L,3L,3L,2L,2L,3L,2L,1L,3L,2L,1L,2L,3L,3L,3L,2L,2L,2L,3L,5L,5L,3L,2L,1L,2L,3L,3L,3L,3L,2L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256427Inst : IEnumerable<long>
{
public static readonly long[] Value=A256427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256427.Bytes);
public long this[int i]=>Value[i];

public static A256427Inst Instance=new A256427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256428
{
public static readonly long[] Value={ 0L,0L,1L,6L,26L,102L,386L,1441L,5353L,19854L,73612L,272940L,1012137L,3753696L,13922343L,51640040L,191546040L,710504359L,2635506573L,9776051185L,36263011505L,134513166002L,498960289449L,1850833274594L,6865444733208L,25466548032582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256428Inst : IEnumerable<long>
{
public static readonly long[] Value=A256428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256428.Bytes);
public long this[int i]=>Value[i];

public static A256428Inst Instance=new A256428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256429
{
public static readonly long[] Value={ 1L,6L,11L,16L,41L,106L,211L,416L,941L,2106L,4411L,9316L,20341L,44106L,94111L,201716L,435741L,938606L,2014311L,4330116L,9324641L,20060606L,43122511L,92747016L,199552041L,429222606L,923076211L,1985467416L,4270895441L,9186237106L,19758020411L,42498043816L,91411232341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256429Inst : IEnumerable<long>
{
public static readonly long[] Value=A256429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256429.Bytes);
public long this[int i]=>Value[i];

public static A256429Inst Instance=new A256429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256430
{
public static readonly long[] Value={ 1L,4L,18L,50L,294L,1210L,1014L,578L,2166L,58190L,35322L,28830L,8214L,16810L,77658L,1117754L,219102L,1413286L,111630L,1481370L,1058610L,31974L,486798L,2824490L,871310L,56454L,102010L,1082118L,15776722L,71286L,536298L,677418L,6692790L,638146L,29329278L,4928622L,684030L,1922622L,159414L,189812534L,54051774L,62736278L,982830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256430Inst : IEnumerable<long>
{
public static readonly long[] Value=A256430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256430.Bytes);
public long this[int i]=>Value[i];

public static A256430Inst Instance=new A256430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256431
{
public static readonly long[] Value={ 1L,4L,18L,50L,294L,450L,578L,1014L,1210L,2166L,5202L,7350L,8214L,10890L,14450L,16810L,25350L,28830L,31974L,35322L,49686L,54150L,56454L,58190L,71286L,77658L,84966L,102010L,106134L,111630L,130050L,132098L,151290L,159414L,177870L,205350L,219102L,223494L,293046L,349690L,366054L,402486L,486798L,523710L,536298L,613470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256431Inst : IEnumerable<long>
{
public static readonly long[] Value=A256431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256431.Bytes);
public long this[int i]=>Value[i];

public static A256431Inst Instance=new A256431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256432
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256432Inst : IEnumerable<long>
{
public static readonly long[] Value=A256432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256432.Bytes);
public long this[int i]=>Value[i];

public static A256432Inst Instance=new A256432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256433
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256433Inst : IEnumerable<long>
{
public static readonly long[] Value=A256433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256433.Bytes);
public long this[int i]=>Value[i];

public static A256433Inst Instance=new A256433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256434
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256434Inst : IEnumerable<long>
{
public static readonly long[] Value=A256434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256434.Bytes);
public long this[int i]=>Value[i];

public static A256434Inst Instance=new A256434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256435
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,1L,3L,3L,1L,1L,2L,5L,1L,3L,3L,2L,2L,1L,3L,1L,4L,4L,1L,2L,1L,5L,3L,3L,1L,3L,4L,1L,1L,6L,1L,1L,3L,4L,1L,7L,1L,2L,1L,3L,2L,3L,4L,3L,1L,4L,1L,3L,3L,2L,6L,1L,7L,1L,1L,2L,1L,4L,4L,3L,2L,2L,5L,1L,3L,5L,2L,1L,4L,8L,1L,2L,1L,3L,2L,3L,3L,4L,6L,3L,4L,1L,3L,3L,1L,1L,7L,1L,2L,1L,5L,6L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256435Inst : IEnumerable<long>
{
public static readonly long[] Value=A256435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256435.Bytes);
public long this[int i]=>Value[i];

public static A256435Inst Instance=new A256435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256436
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256436Inst : IEnumerable<long>
{
public static readonly long[] Value=A256436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256436.Bytes);
public long this[int i]=>Value[i];

public static A256436Inst Instance=new A256436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256437
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,12L,20L,21L,30L,100L,101L,102L,110L,111L,120L,200L,201L,210L,220L,300L,310L,1000L,1001L,1002L,1010L,1011L,1012L,1020L,1021L,1022L,1100L,1101L,1102L,1110L,1111L,1120L,1200L,1201L,1210L,1300L,2000L,2001L,2010L,2011L,2100L,2101L,2110L,2200L,2201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256437Inst : IEnumerable<long>
{
public static readonly long[] Value=A256437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256437.Bytes);
public long this[int i]=>Value[i];

public static A256437Inst Instance=new A256437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256438
{
public static readonly BigInteger[] Value={ 3L,5L,17L,65L,4097L,65537L,262145L,1073741825L,1152921504606846977L,BigInteger.Parse("309485009821345068724781057"),BigInteger.Parse("81129638414606681695789005144065"),BigInteger.Parse("85070591730234615865843651857942052865") };
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
public class A256438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256438Inst Instance=new A256438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256439
{
public static readonly long[] Value={ 3L,5L,17L,26L,171L,257L,265L,1921L,9385L,26665L,65537L,263041L,437761L,1057801L,2038648321L,10866583226L,11453097097L,982923711145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256439Inst : IEnumerable<long>
{
public static readonly long[] Value=A256439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256439.Bytes);
public long this[int i]=>Value[i];

public static A256439Inst Instance=new A256439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256440
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,3L,2L,4L,1L,5L,3L,2L,4L,1L,5L,3L,2L,4L,6L,1L,7L,5L,3L,2L,4L,6L,1L,7L,5L,3L,2L,4L,8L,6L,1L,7L,5L,3L,9L,2L,4L,8L,6L,1L,7L,5L,3L,9L,2L,4L,10L,8L,6L,1L,11L,7L,5L,3L,9L,2L,4L,10L,8L,6L,1L,11L,7L,5L,3L,9L,2L,4L,10L,8L,6L,12L,1L,13L,11L,7L,5L,3L,9L,2L,4L,10L,8L,6L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256440Inst : IEnumerable<long>
{
public static readonly long[] Value=A256440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256440.Bytes);
public long this[int i]=>Value[i];

public static A256440Inst Instance=new A256440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256441
{
public static readonly long[] Value={ 0L,29L,28L,17L,16L,205L,204L,193L,192L,221L,220L,209L,208L,7437L,7436L,7425L,7424L,7453L,7452L,7441L,7440L,7629L,7628L,7617L,7616L,7645L,7644L,7633L,7632L,7181L,7180L,7169L,7168L,7197L,7196L,7185L,7184L,7373L,7372L,7361L,7360L,7389L,7388L,7377L,7376L,4365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256441Inst : IEnumerable<long>
{
public static readonly long[] Value=A256441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256441.Bytes);
public long this[int i]=>Value[i];

public static A256441Inst Instance=new A256441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256442
{
public static readonly long[] Value={ 1L,6L,60L,280L,5040L,22176L,192192L,823680L,28005120L,118243840L,141892608L,593369088L,9889484800L,41079398400L,2382605107200L,9848101109760L,649974673244160L,2676366301593600L,22005678479769600L,90339101127475200L,1481561258490593280L,6067346106199572480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256442Inst : IEnumerable<long>
{
public static readonly long[] Value=A256442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256442.Bytes);
public long this[int i]=>Value[i];

public static A256442Inst Instance=new A256442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256443
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,3L,6L,3L,4L,3L,5L,4L,5L,2L,3L,5L,5L,6L,3L,4L,5L,1L,3L,4L,5L,3L,4L,7L,3L,5L,7L,4L,5L,7L,2L,3L,5L,7L,5L,6L,7L,3L,4L,5L,7L,1L,3L,4L,5L,7L,2L,3L,4L,5L,7L,4L,5L,6L,7L,3L,5L,7L,8L,1L,3L,5L,7L,8L,4L,5L,7L,9L,1L,4L,5L,7L,9L,4L,5L,7L,11L,2L,3L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256443Inst : IEnumerable<long>
{
public static readonly long[] Value=A256443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256443.Bytes);
public long this[int i]=>Value[i];

public static A256443Inst Instance=new A256443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256444
{
public static readonly long[] Value={ 3L,5L,17L,26L,257L,65537L,10866583226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256444Inst : IEnumerable<long>
{
public static readonly long[] Value=A256444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256444.Bytes);
public long this[int i]=>Value[i];

public static A256444Inst Instance=new A256444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256445
{
public static readonly long[] Value={ 1L,2L,3L,4L,2L,3L,1L,2L,3L,3L,4L,3L,5L,4L,5L,2L,3L,5L,1L,2L,3L,5L,3L,4L,5L,1L,3L,4L,5L,3L,4L,7L,3L,5L,7L,4L,5L,7L,2L,3L,5L,7L,1L,2L,3L,5L,7L,3L,4L,5L,7L,1L,3L,4L,5L,7L,1L,1L,3L,4L,5L,7L,1L,1L,1L,3L,4L,5L,7L,3L,5L,7L,8L,1L,3L,5L,7L,8L,4L,5L,7L,9L,1L,4L,5L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256445Inst : IEnumerable<long>
{
public static readonly long[] Value=A256445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256445.Bytes);
public long this[int i]=>Value[i];

public static A256445Inst Instance=new A256445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256446
{
public static readonly long[] Value={ 2L,4L,9L,12L,12L,18L,17L,36L,32L,34L,50L,33L,31L,60L,77L,57L,58L,77L,49L,66L,89L,90L,136L,132L,65L,61L,63L,70L,211L,240L,132L,105L,167L,183L,121L,180L,161L,164L,191L,138L,215L,215L,109L,108L,263L,462L,336L,126L,122L,209L,183L,262L,354L,281L,270L,199L,192L,249L,139L,312L,605L,495L,156L,162L,492L,562L,458L,359L,178L,302L,424L,443L,377L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256446Inst : IEnumerable<long>
{
public static readonly long[] Value=A256446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256446.Bytes);
public long this[int i]=>Value[i];

public static A256446Inst Instance=new A256446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256447
{
public static readonly long[] Value={ 2L,3L,3L,7L,5L,9L,6L,13L,23L,9L,28L,22L,12L,24L,39L,37L,17L,44L,32L,16L,53L,37L,53L,76L,46L,23L,43L,20L,49L,161L,48L,82L,23L,142L,27L,91L,90L,66L,103L,97L,41L,181L,41L,74L,39L,228L,228L,86L,45L,86L,130L,44L,217L,134L,141L,138L,46L,148L,106L,47L,261L,355L,116L,53L,109L,387L,166L,284L,65L,119L,181L,243L,198L,195L,122L,190L,268L,125L,265L,330L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256447Inst : IEnumerable<long>
{
public static readonly long[] Value=A256447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256447.Bytes);
public long this[int i]=>Value[i];

public static A256447Inst Instance=new A256447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256448
{
public static readonly long[] Value={ -1L,1L,2L,7L,3L,12L,4L,13L,23L,6L,28L,21L,7L,21L,40L,40L,14L,45L,33L,13L,52L,37L,60L,86L,42L,18L,43L,21L,50L,192L,50L,82L,25L,156L,30L,90L,95L,61L,94L,97L,34L,174L,35L,69L,35L,234L,250L,81L,36L,79L,139L,45L,220L,140L,132L,153L,44L,143L,92L,51L,250L,379L,103L,53L,105L,396L,174L,294L,59L,121L,181L,245L,182L,184L,129L,203L,261L,136L,265L,339L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256448Inst : IEnumerable<long>
{
public static readonly long[] Value=A256448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256448.Bytes);
public long this[int i]=>Value[i];

public static A256448Inst Instance=new A256448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256449
{
public static readonly long[] Value={ 3L,2L,1L,0L,2L,-3L,2L,0L,0L,3L,0L,1L,5L,3L,-1L,-3L,3L,-1L,-1L,3L,1L,0L,-7L,-10L,4L,5L,0L,-1L,-1L,-31L,-2L,0L,-2L,-14L,-3L,1L,-5L,5L,9L,0L,7L,7L,6L,5L,4L,-6L,-22L,5L,9L,7L,-9L,-1L,-3L,-6L,9L,-15L,2L,5L,14L,-4L,11L,-24L,13L,0L,4L,-9L,-8L,-10L,6L,-2L,0L,-2L,16L,11L,-7L,-13L,7L,-11L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256449Inst : IEnumerable<long>
{
public static readonly long[] Value=A256449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256449.Bytes);
public long this[int i]=>Value[i];

public static A256449Inst Instance=new A256449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256450
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,20L,21L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,56L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,89L,91L,92L,93L,95L,97L,98L,99L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256450Inst : IEnumerable<long>
{
public static readonly long[] Value=A256450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256450.Bytes);
public long this[int i]=>Value[i];

public static A256450Inst Instance=new A256450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256451
{
public static readonly long[] Value={ 2L,4L,27L,63L,756L,899L,8088L,15216L,47969L,50943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256451Inst : IEnumerable<long>
{
public static readonly long[] Value=A256451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256451.Bytes);
public long this[int i]=>Value[i];

public static A256451Inst Instance=new A256451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256452
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,3L,1L,3L,1L,3L,1L,1L,3L,1L,1L,1L,1L,5L,3L,1L,1L,3L,3L,1L,1L,1L,3L,3L,1L,3L,1L,3L,3L,3L,1L,1L,1L,3L,1L,1L,1L,1L,5L,3L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,1L,9L,1L,1L,3L,1L,3L,1L,1L,3L,3L,5L,1L,1L,3L,1L,3L,1L,3L,1L,1L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256452Inst : IEnumerable<long>
{
public static readonly long[] Value=A256452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256452.Bytes);
public long this[int i]=>Value[i];

public static A256452Inst Instance=new A256452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256453
{
public static readonly long[] Value={ 1L,-5L,8L,-2L,-5L,4L,-11L,19L,-2L,-6L,-9L,-7L,26L,-2L,-7L,-4L,-6L,11L,-5L,-7L,12L,12L,4L,-32L,-20L,28L,23L,1L,0L,-52L,24L,7L,5L,12L,-10L,-8L,-11L,12L,-1L,33L,-28L,-2L,-32L,22L,12L,9L,26L,-26L,-40L,-19L,33L,44L,-8L,18L,-33L,-32L,34L,-44L,8L,58L,16L,-66L,7L,-13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256453Inst : IEnumerable<long>
{
public static readonly long[] Value=A256453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256453.Bytes);
public long this[int i]=>Value[i];

public static A256453Inst Instance=new A256453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256454
{
public static readonly long[] Value={ 2L,3L,7L,23L,89L,139L,199L,293L,1831L,1913L,3089L,3229L,4177L,5531L,5953L,6491L,10799L,11743L,12853L,30593L,33247L,34981L,36389L,81463L,86629L,95651L,103237L,106033L,153191L,181303L,189067L,190409L,288583L,294563L,326369L,399283L,507217L,514967L,570253L,642281L,815729L,841459L,979567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256454Inst : IEnumerable<long>
{
public static readonly long[] Value=A256454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256454.Bytes);
public long this[int i]=>Value[i];

public static A256454Inst Instance=new A256454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256455
{
public static readonly long[] Value={ 3L,4L,5L,7L,9L,11L,12L,13L,15L,17L,19L,21L,23L,24L,25L,27L,29L,31L,33L,35L,37L,39L,40L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,60L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256455Inst : IEnumerable<long>
{
public static readonly long[] Value=A256455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256455.Bytes);
public long this[int i]=>Value[i];

public static A256455Inst Instance=new A256455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256456
{
public static readonly long[] Value={ 0L,1L,1L,4L,8L,29L,79L,280L,912L,3260L,11410L,41272L,148976L,544802L,1997499L,7372080L,27299360L,101520714L,378721134L,1417339352L,5318837680L,20012141478L,75473438326L,285268537424L,1080433781728L,4099860518208L,15585111068644L,59343308199216L,226312777319776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256456Inst : IEnumerable<long>
{
public static readonly long[] Value=A256456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256456.Bytes);
public long this[int i]=>Value[i];

public static A256456Inst Instance=new A256456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256457
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,11L,13L,31L,41L,61L,17L,71L,19L,2L,23L,29L,3L,13L,31L,23L,43L,53L,37L,73L,83L,41L,43L,47L,5L,53L,59L,61L,67L,7L,17L,71L,37L,73L,47L,67L,79L,97L,83L,89L,19L,29L,59L,79L,97L,89L,11L,11L,101L,13L,31L,103L,41L,401L,61L,601L,17L,71L,107L,701L,19L,109L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256457Inst : IEnumerable<long>
{
public static readonly long[] Value=A256457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256457.Bytes);
public long this[int i]=>Value[i];

public static A256457Inst Instance=new A256457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256458
{
public static readonly long[] Value={ 2L,4L,5L,6L,11L,26L,92L,98L,110L,215L,232L,354L,522L,648L,1862L,2322L,2934L,3797L,6017L,11236L,24748L,30011L,37864L,42904L,57414L,195478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256458Inst : IEnumerable<long>
{
public static readonly long[] Value=A256458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256458.Bytes);
public long this[int i]=>Value[i];

public static A256458Inst Instance=new A256458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256459
{
public static readonly long[] Value={ 5L,17L,125L,4901L,274625L,36125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256459Inst : IEnumerable<long>
{
public static readonly long[] Value=A256459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256459.Bytes);
public long this[int i]=>Value[i];

public static A256459Inst Instance=new A256459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256460
{
public static readonly long[] Value={ 3L,6L,6L,0L,8L,5L,8L,1L,0L,5L,1L,3L,9L,8L,4L,4L,7L,7L,9L,6L,1L,6L,3L,4L,2L,0L,7L,0L,5L,8L,1L,3L,4L,4L,2L,6L,7L,0L,9L,6L,2L,0L,7L,3L,5L,1L,0L,0L,3L,0L,7L,5L,1L,2L,0L,8L,0L,8L,3L,1L,7L,4L,6L,9L,6L,1L,4L,8L,7L,7L,7L,2L,7L,3L,3L,9L,2L,8L,8L,3L,2L,9L,1L,8L,4L,3L,6L,0L,8L,1L,4L,1L,7L,4L,8L,4L,2L,5L,8L,3L,1L,0L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256460Inst : IEnumerable<long>
{
public static readonly long[] Value=A256460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256460.Bytes);
public long this[int i]=>Value[i];

public static A256460Inst Instance=new A256460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256461
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,4L,1L,0L,1L,1L,1L,18L,1L,5L,0L,0L,1L,1L,1L,1L,1L,2L,0L,1L,1L,1L,1L,9L,1L,1L,4L,1L,4L,1L,4L,0L,1L,1L,1L,1L,1L,16L,1L,0L,1L,1L,1L,7L,1L,1L,9L,1L,5L,0L,0L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,4L,1L,7L,0L,1L,5L,1L,1L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256461Inst : IEnumerable<long>
{
public static readonly long[] Value=A256461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256461.Bytes);
public long this[int i]=>Value[i];

public static A256461Inst Instance=new A256461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256462
{
public static readonly BigInteger[] Value={ 1L,14L,238L,4092L,70070L,1192516L,20177164L,339653880L,5692584870L,95050101300L,1581953021220L,26255495764680L,434697697648188L,7181635051211432L,118422830335911640L,1949458102569167344L,BigInteger.Parse("32043155434056810246"),BigInteger.Parse("525974795270875804308") };
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
public class A256462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256462Inst Instance=new A256462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256463
{
public static readonly long[] Value={ 1L,2L,3L,5L,24L,37L,53L,63L,84L,299L,506L,1687L,6660L,7473L,8754L,24048L,68078L,71223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256463Inst : IEnumerable<long>
{
public static readonly long[] Value=A256463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256463.Bytes);
public long this[int i]=>Value[i];

public static A256463Inst Instance=new A256463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256464
{
public static readonly long[] Value={ 1L,2L,5L,4L,13L,6L,23L,9L,19L,13L,43L,12L,59L,22L,27L,19L,79L,19L,97L,22L,41L,35L,113L,24L,89L,43L,59L,33L,157L,31L,173L,41L,77L,61L,101L,36L,211L,71L,95L,45L,239L,46L,257L,59L,71L,86L,281L,48L,209L,73L,127L,73L,331L,62L,167L,67L,143L,111L,373L,60L,389L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256464Inst : IEnumerable<long>
{
public static readonly long[] Value=A256464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256464.Bytes);
public long this[int i]=>Value[i];

public static A256464Inst Instance=new A256464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256465
{
public static readonly long[] Value={ 3L,7L,9L,11L,17L,21L,21L,23L,27L,33L,37L,37L,41L,45L,45L,47L,53L,59L,61L,65L,69L,69L,69L,69L,75L,85L,89L,89L,93L,97L,97L,99L,101L,105L,109L,111L,117L,121L,121L,125L,133L,137L,137L,137L,141L,145L,145L,145L,147L,155L,161L,165L,173L,177L,177L,177L,177L,181L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256465Inst : IEnumerable<long>
{
public static readonly long[] Value=A256465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256465.Bytes);
public long this[int i]=>Value[i];

public static A256465Inst Instance=new A256465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256466
{
public static readonly long[] Value={ 1L,2L,6L,3L,12L,4L,8L,10L,5L,15L,20L,24L,14L,7L,21L,27L,9L,18L,22L,11L,33L,30L,26L,13L,39L,42L,28L,35L,40L,32L,16L,48L,51L,17L,34L,38L,19L,57L,54L,36L,44L,52L,56L,46L,23L,69L,60L,45L,55L,65L,70L,50L,25L,75L,66L,58L,29L,87L,78L,62L,31L,93L,84L,63L,72L,64L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256466Inst : IEnumerable<long>
{
public static readonly long[] Value=A256466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256466.Bytes);
public long this[int i]=>Value[i];

public static A256466Inst Instance=new A256466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256467
{
public static readonly BigInteger[] Value={ 0L,1L,2L,-9L,28L,-55L,-234L,5047L,-59464L,620433L,-6210710L,60312791L,-552386988L,4291343641L,-14786103682L,-469083221865L,17904311480176L,-458594711604703L,10473023418660306L,-228670491372982217L,4899169866194557580L,BigInteger.Parse("-104056906653521654679"),BigInteger.Parse("2196053393686810460902") };
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
public class A256467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256467Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256467.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256467Inst Instance=new A256467Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256468
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,8L,5L,12L,22L,8L,27L,21L,11L,23L,38L,36L,16L,43L,31L,15L,52L,36L,52L,75L,45L,22L,42L,19L,48L,160L,47L,81L,22L,141L,26L,90L,89L,65L,102L,96L,40L,180L,40L,73L,38L,227L,227L,85L,44L,85L,129L,43L,216L,133L,140L,137L,45L,147L,105L,46L,260L,354L,115L,52L,108L,386L,165L,283L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256468Inst : IEnumerable<long>
{
public static readonly long[] Value=A256468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256468.Bytes);
public long this[int i]=>Value[i];

public static A256468Inst Instance=new A256468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256469
{
public static readonly long[] Value={ 1L,3L,4L,9L,5L,14L,6L,15L,25L,8L,30L,23L,9L,23L,42L,42L,16L,47L,35L,15L,54L,39L,62L,88L,44L,20L,45L,23L,52L,194L,52L,84L,27L,158L,32L,92L,97L,63L,96L,99L,36L,176L,37L,71L,37L,236L,252L,83L,38L,81L,141L,47L,222L,142L,134L,155L,46L,145L,94L,53L,252L,381L,105L,55L,107L,398L,176L,296L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256469Inst : IEnumerable<long>
{
public static readonly long[] Value=A256469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256469.Bytes);
public long this[int i]=>Value[i];

public static A256469Inst Instance=new A256469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256470
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,6L,1L,3L,3L,0L,3L,2L,-2L,0L,4L,6L,0L,4L,4L,0L,2L,3L,10L,13L,-1L,-2L,3L,4L,4L,34L,5L,3L,5L,17L,6L,2L,8L,-2L,-6L,3L,-4L,-4L,-3L,-2L,-1L,9L,25L,-2L,-6L,-4L,12L,4L,6L,9L,-6L,18L,1L,-2L,-11L,7L,-8L,27L,-10L,3L,-1L,12L,11L,13L,-3L,5L,3L,5L,-13L,-8L,10L,16L,-4L,14L,3L,12L,-3L,23L,5L,4L,6L,-8L,19L,-13L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256470Inst : IEnumerable<long>
{
public static readonly long[] Value=A256470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256470.Bytes);
public long this[int i]=>Value[i];

public static A256470Inst Instance=new A256470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256471
{
public static readonly long[] Value={ 1L,10L,14L,17L,20L,90L,110L,152L,176L,185L,193L,230L,344L,377L,391L,392L,404L,441L,442L,542L,1066L,1533L,1550L,1632L,1638L,1639L,1810L,2115L,2210L,2302L,2567L,2768L,2921L,3172L,3518L,3615L,3764L,4357L,4577L,4787L,4853L,5060L,5278L,6329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256471Inst : IEnumerable<long>
{
public static readonly long[] Value=A256471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256471.Bytes);
public long this[int i]=>Value[i];

public static A256471Inst Instance=new A256471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256472
{
public static readonly long[] Value={ 2L,29L,43L,59L,71L,463L,601L,881L,1049L,1103L,1171L,1451L,2311L,2591L,2689L,2693L,2777L,3083L,3089L,3917L,8543L,12889L,13007L,13799L,13873L,13877L,15497L,18457L,19477L,20369L,23017L,25073L,26641L,29179L,32801L,33757L,35327L,41647L,43987L,46279L,47041L,49211L,51577L,63113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256472Inst : IEnumerable<long>
{
public static readonly long[] Value=A256472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256472.Bytes);
public long this[int i]=>Value[i];

public static A256472Inst Instance=new A256472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256473
{
public static readonly long[] Value={ 3L,31L,47L,61L,73L,467L,607L,883L,1051L,1109L,1181L,1453L,2333L,2593L,2693L,2699L,2789L,3089L,3109L,3919L,8563L,12893L,13009L,13807L,13877L,13879L,15511L,18461L,19483L,20389L,23021L,25087L,26647L,29191L,32803L,33767L,35339L,41651L,43991L,46301L,47051L,49223L,51581L,63127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256473Inst : IEnumerable<long>
{
public static readonly long[] Value=A256473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256473.Bytes);
public long this[int i]=>Value[i];

public static A256473Inst Instance=new A256473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256474
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,40L,46L,47L,51L,52L,53L,54L,56L,57L,60L,62L,64L,66L,67L,68L,70L,71L,72L,75L,76L,78L,79L,80L,82L,83L,84L,85L,87L,89L,90L,91L,93L,94L,95L,97L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256474Inst : IEnumerable<long>
{
public static readonly long[] Value=A256474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256474.Bytes);
public long this[int i]=>Value[i];

public static A256474Inst Instance=new A256474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256475
{
public static readonly long[] Value={ 13L,25L,26L,38L,39L,41L,42L,43L,44L,45L,48L,49L,50L,55L,58L,59L,61L,63L,65L,69L,73L,74L,77L,81L,86L,88L,92L,96L,98L,101L,103L,106L,107L,108L,109L,116L,117L,120L,121L,122L,124L,125L,128L,141L,142L,143L,145L,146L,148L,149L,151L,155L,158L,159L,166L,169L,172L,173L,177L,179L,181L,182L,183L,190L,191L,194L,195L,196L,197L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256475Inst : IEnumerable<long>
{
public static readonly long[] Value=A256475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256475.Bytes);
public long this[int i]=>Value[i];

public static A256475Inst Instance=new A256475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256476
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,11L,12L,15L,16L,18L,19L,21L,22L,23L,24L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,40L,46L,47L,51L,52L,53L,54L,56L,57L,60L,62L,64L,66L,67L,68L,70L,71L,72L,75L,76L,78L,79L,80L,82L,83L,84L,85L,87L,89L,91L,93L,94L,95L,97L,99L,100L,102L,104L,105L,111L,112L,113L,114L,115L,118L,119L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256476Inst : IEnumerable<long>
{
public static readonly long[] Value=A256476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256476.Bytes);
public long this[int i]=>Value[i];

public static A256476Inst Instance=new A256476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256477
{
public static readonly long[] Value={ 1L,10L,13L,14L,17L,20L,25L,26L,38L,39L,41L,42L,43L,44L,45L,48L,49L,50L,55L,58L,59L,61L,63L,65L,69L,73L,74L,77L,81L,86L,88L,90L,92L,96L,98L,101L,103L,106L,107L,108L,109L,110L,116L,117L,120L,121L,122L,124L,125L,128L,141L,142L,143L,145L,146L,148L,149L,151L,152L,155L,158L,159L,166L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256477Inst : IEnumerable<long>
{
public static readonly long[] Value=A256477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256477.Bytes);
public long this[int i]=>Value[i];

public static A256477Inst Instance=new A256477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256478
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,2L,3L,3L,2L,2L,3L,1L,2L,3L,4L,4L,3L,3L,3L,2L,2L,4L,2L,3L,3L,4L,1L,2L,3L,4L,5L,5L,4L,4L,4L,3L,3L,4L,3L,3L,3L,5L,2L,2L,4L,3L,4L,2L,4L,5L,3L,3L,2L,3L,4L,4L,5L,1L,2L,3L,4L,5L,6L,6L,5L,5L,5L,4L,4L,5L,4L,4L,4L,5L,3L,3L,4L,4L,4L,3L,4L,6L,3L,3L,3L,3L,5L,5L,4L,2L,2L,4L,3L,5L,3L,4L,5L,6L,2L,4L,4L,4L,5L,3L,4L,3L,3L,2L,5L,5L,3L,6L,2L,4L,4L,3L,4L,5L,5L,6L,1L,2L,3L,4L,5L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256478Inst : IEnumerable<long>
{
public static readonly long[] Value=A256478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256478.Bytes);
public long this[int i]=>Value[i];

public static A256478Inst Instance=new A256478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256479
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,2L,2L,1L,3L,2L,1L,0L,1L,2L,2L,2L,3L,3L,1L,3L,2L,2L,1L,4L,3L,2L,1L,0L,1L,2L,2L,2L,3L,3L,2L,3L,3L,3L,1L,4L,4L,2L,3L,2L,4L,2L,1L,3L,3L,4L,3L,2L,2L,1L,5L,4L,3L,2L,1L,0L,1L,2L,2L,2L,3L,3L,2L,3L,3L,3L,2L,4L,4L,3L,3L,3L,4L,3L,1L,4L,4L,4L,4L,2L,2L,3L,5L,5L,3L,4L,2L,4L,3L,2L,1L,5L,3L,3L,3L,2L,4L,3L,4L,4L,5L,2L,2L,4L,1L,5L,3L,3L,4L,3L,2L,2L,1L,6L,5L,4L,3L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256479Inst : IEnumerable<long>
{
public static readonly long[] Value=A256479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256479.Bytes);
public long this[int i]=>Value[i];

public static A256479Inst Instance=new A256479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256480
{
public static readonly long[] Value={ 0L,11L,0L,13L,0L,0L,0L,17L,0L,19L,0L,211L,0L,113L,0L,0L,0L,317L,0L,419L,0L,421L,0L,223L,0L,0L,0L,127L,0L,229L,0L,131L,0L,233L,0L,0L,0L,137L,0L,139L,0L,241L,0L,443L,0L,0L,0L,347L,0L,149L,0L,151L,0L,353L,0L,0L,0L,157L,0L,359L,0L,461L,0L,163L,0L,0L,0L,167L,0L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256480Inst : IEnumerable<long>
{
public static readonly long[] Value=A256480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256480.Bytes);
public long this[int i]=>Value[i];

public static A256480Inst Instance=new A256480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256481
{
public static readonly long[] Value={ 2L,11L,23L,31L,41L,53L,61L,71L,83L,97L,101L,113L,127L,131L,149L,151L,163L,173L,181L,191L,2011L,211L,223L,233L,241L,251L,263L,271L,281L,293L,307L,311L,3299L,331L,347L,353L,367L,373L,383L,397L,401L,419L,421L,431L,443L,457L,461L,479L,487L,491L,503L,511111L,521L,5333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256481Inst : IEnumerable<long>
{
public static readonly long[] Value=A256481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256481.Bytes);
public long this[int i]=>Value[i];

public static A256481Inst Instance=new A256481Inst();

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