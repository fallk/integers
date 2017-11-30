using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A050045
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,9L,11L,13L,14L,27L,38L,47L,52L,56L,58L,60L,61L,121L,179L,235L,287L,334L,372L,399L,413L,426L,437L,446L,451L,455L,457L,459L,460L,919L,1376L,1831L,2282L,2728L,3165L,3591L,4004L,4403L,4775L,5109L,5396L,5631L,5810L,5931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050045Inst : IEnumerable<long>
{
public static readonly long[] Value=A050045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050045.Bytes);
public long this[int i]=>Value[i];

public static A050045Inst Instance=new A050045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050046
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,6L,8L,10L,13L,14L,16L,18L,21L,26L,32L,40L,50L,51L,53L,55L,58L,63L,69L,77L,87L,100L,114L,130L,148L,169L,195L,227L,267L,268L,270L,272L,275L,280L,286L,294L,304L,317L,331L,347L,365L,386L,412L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050046Inst : IEnumerable<long>
{
public static readonly long[] Value=A050046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050046.Bytes);
public long this[int i]=>Value[i];

public static A050046Inst Instance=new A050046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050047
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,10L,14L,24L,48L,50L,54L,64L,88L,138L,202L,340L,680L,682L,686L,696L,720L,770L,834L,972L,1312L,1994L,2690L,3460L,4432L,6426L,9886L,16312L,32624L,32626L,32630L,32640L,32664L,32714L,32778L,32916L,33256L,33938L,34634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050047Inst : IEnumerable<long>
{
public static readonly long[] Value=A050047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050047.Bytes);
public long this[int i]=>Value[i];

public static A050047Inst Instance=new A050047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050048
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,11L,18L,29L,30L,33L,40L,51L,80L,113L,164L,277L,278L,281L,288L,299L,328L,361L,412L,525L,802L,1083L,1382L,1743L,2268L,3351L,5094L,8445L,8446L,8449L,8456L,8467L,8496L,8529L,8580L,8693L,8970L,9251L,9550L,9911L,10436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050048Inst : IEnumerable<long>
{
public static readonly long[] Value=A050048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050048.Bytes);
public long this[int i]=>Value[i];

public static A050048Inst Instance=new A050048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050049
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,11L,14L,16L,17L,33L,47L,58L,64L,69L,72L,74L,75L,149L,221L,290L,354L,412L,459L,492L,509L,525L,539L,550L,556L,561L,564L,566L,567L,1133L,1697L,2258L,2814L,3364L,3903L,4428L,4937L,5429L,5888L,6300L,6654L,6944L,7165L,7314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050049Inst : IEnumerable<long>
{
public static readonly long[] Value=A050049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050049.Bytes);
public long this[int i]=>Value[i];

public static A050049Inst Instance=new A050049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050050
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,12L,16L,17L,19L,22L,26L,32L,39L,48L,60L,61L,63L,66L,70L,76L,83L,92L,104L,120L,137L,156L,178L,204L,236L,275L,323L,324L,326L,329L,333L,339L,346L,355L,367L,383L,400L,419L,441L,467L,499L,538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050050Inst : IEnumerable<long>
{
public static readonly long[] Value=A050050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050050.Bytes);
public long this[int i]=>Value[i];

public static A050050Inst Instance=new A050050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050051
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,12L,17L,29L,58L,60L,65L,77L,106L,166L,243L,409L,818L,820L,825L,837L,866L,926L,1003L,1169L,1578L,2398L,3235L,4161L,5330L,7728L,11889L,19617L,39234L,39236L,39241L,39253L,39282L,39342L,39419L,39585L,39994L,40814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050051Inst : IEnumerable<long>
{
public static readonly long[] Value=A050051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050051.Bytes);
public long this[int i]=>Value[i];

public static A050051Inst Instance=new A050051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050052
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,10L,14L,23L,37L,38L,42L,51L,65L,102L,144L,209L,353L,354L,358L,367L,381L,418L,460L,525L,669L,1022L,1380L,1761L,2221L,2890L,4270L,6491L,10761L,10762L,10766L,10775L,10789L,10826L,10868L,10933L,11077L,11430L,11788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050052Inst : IEnumerable<long>
{
public static readonly long[] Value=A050052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050052.Bytes);
public long this[int i]=>Value[i];

public static A050052Inst Instance=new A050052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050053
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,17L,19L,20L,39L,56L,69L,76L,82L,86L,88L,89L,177L,263L,345L,421L,490L,546L,585L,605L,624L,641L,654L,661L,667L,671L,673L,674L,1347L,2018L,2685L,3346L,4000L,4641L,5265L,5870L,6455L,7001L,7491L,7912L,8257L,8520L,8697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050053Inst : IEnumerable<long>
{
public static readonly long[] Value=A050053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050053.Bytes);
public long this[int i]=>Value[i];

public static A050053Inst Instance=new A050053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050054
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,14L,19L,20L,22L,26L,31L,38L,46L,56L,70L,71L,73L,77L,82L,89L,97L,107L,121L,140L,160L,182L,208L,239L,277L,323L,379L,380L,382L,386L,391L,398L,406L,416L,430L,449L,469L,491L,517L,548L,586L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050054Inst : IEnumerable<long>
{
public static readonly long[] Value=A050054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050054.Bytes);
public long this[int i]=>Value[i];

public static A050054Inst Instance=new A050054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050055
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,14L,20L,34L,68L,70L,76L,90L,124L,194L,284L,478L,956L,958L,964L,978L,1012L,1082L,1172L,1366L,1844L,2802L,3780L,4862L,6228L,9030L,13892L,22922L,45844L,45846L,45852L,45866L,45900L,45970L,46060L,46254L,46732L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050055Inst : IEnumerable<long>
{
public static readonly long[] Value=A050055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050055.Bytes);
public long this[int i]=>Value[i];

public static A050055Inst Instance=new A050055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050056
{
public static readonly long[] Value={ 1L,3L,1L,2L,3L,4L,5L,8L,13L,14L,15L,18L,23L,36L,51L,74L,125L,126L,127L,130L,135L,148L,163L,186L,237L,362L,489L,624L,787L,1024L,1513L,2300L,3813L,3814L,3815L,3818L,3823L,3836L,3851L,3874L,3925L,4050L,4177L,4312L,4475L,4712L,5201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050056Inst : IEnumerable<long>
{
public static readonly long[] Value=A050056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050056.Bytes);
public long this[int i]=>Value[i];

public static A050056Inst Instance=new A050056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050057
{
public static readonly long[] Value={ 1L,3L,1L,4L,5L,9L,10L,13L,14L,27L,37L,46L,51L,55L,56L,59L,60L,119L,175L,230L,281L,327L,364L,391L,405L,418L,428L,437L,442L,446L,447L,450L,451L,901L,1348L,1794L,2236L,2673L,3101L,3519L,3924L,4315L,4679L,5006L,5287L,5517L,5692L,5811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050057Inst : IEnumerable<long>
{
public static readonly long[] Value=A050057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050057.Bytes);
public long this[int i]=>Value[i];

public static A050057Inst Instance=new A050057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050058
{
public static readonly long[] Value={ 1L,3L,1L,2L,5L,6L,9L,10L,12L,13L,16L,17L,19L,24L,30L,39L,49L,50L,53L,54L,56L,61L,67L,76L,86L,98L,111L,127L,144L,163L,187L,217L,256L,257L,260L,261L,263L,268L,274L,283L,293L,305L,318L,334L,351L,370L,394L,424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050058Inst : IEnumerable<long>
{
public static readonly long[] Value=A050058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050058.Bytes);
public long this[int i]=>Value[i];

public static A050058Inst Instance=new A050058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050059
{
public static readonly long[] Value={ 1L,3L,1L,4L,8L,11L,15L,26L,52L,55L,59L,70L,96L,151L,221L,372L,744L,747L,751L,762L,788L,843L,913L,1064L,1436L,2183L,2945L,3788L,4852L,7035L,10823L,17858L,35716L,35719L,35723L,35734L,35760L,35815L,35885L,36036L,36408L,37155L,37917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050059Inst : IEnumerable<long>
{
public static readonly long[] Value=A050059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050059.Bytes);
public long this[int i]=>Value[i];

public static A050059Inst Instance=new A050059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050060
{
public static readonly long[] Value={ 1L,3L,2L,3L,5L,6L,8L,13L,21L,22L,24L,29L,37L,58L,82L,119L,201L,202L,204L,209L,217L,238L,262L,299L,381L,582L,786L,1003L,1265L,1646L,2432L,3697L,6129L,6130L,6132L,6137L,6145L,6166L,6190L,6227L,6309L,6510L,6714L,6931L,7193L,7574L,8360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050060Inst : IEnumerable<long>
{
public static readonly long[] Value=A050060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050060.Bytes);
public long this[int i]=>Value[i];

public static A050060Inst Instance=new A050060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050061
{
public static readonly long[] Value={ 1L,3L,2L,5L,6L,11L,13L,16L,17L,33L,46L,57L,63L,68L,70L,73L,74L,147L,217L,285L,348L,405L,451L,484L,501L,517L,530L,541L,547L,552L,554L,557L,558L,1115L,1669L,2221L,2768L,3309L,3839L,4356L,4857L,5341L,5792L,6197L,6545L,6830L,7047L,7194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050061Inst : IEnumerable<long>
{
public static readonly long[] Value=A050061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050061.Bytes);
public long this[int i]=>Value[i];

public static A050061Inst Instance=new A050061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050062
{
public static readonly long[] Value={ 1L,3L,2L,3L,6L,7L,10L,12L,15L,16L,19L,21L,24L,30L,37L,47L,59L,60L,63L,65L,68L,74L,81L,91L,103L,118L,134L,153L,174L,198L,228L,265L,312L,313L,316L,318L,321L,327L,334L,344L,356L,371L,387L,406L,427L,451L,481L,518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050062Inst : IEnumerable<long>
{
public static readonly long[] Value=A050062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050062.Bytes);
public long this[int i]=>Value[i];

public static A050062Inst Instance=new A050062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050063
{
public static readonly long[] Value={ 1L,3L,2L,5L,10L,13L,18L,31L,62L,65L,70L,83L,114L,179L,262L,441L,882L,885L,890L,903L,934L,999L,1082L,1261L,1702L,2587L,3490L,4489L,5750L,8337L,12826L,21163L,42326L,42329L,42334L,42347L,42378L,42443L,42526L,42705L,43146L,44031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050063Inst : IEnumerable<long>
{
public static readonly long[] Value=A050063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050063.Bytes);
public long this[int i]=>Value[i];

public static A050063Inst Instance=new A050063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050064
{
public static readonly long[] Value={ 1L,3L,3L,4L,7L,8L,11L,18L,29L,30L,33L,40L,51L,80L,113L,164L,277L,278L,281L,288L,299L,328L,361L,412L,525L,802L,1083L,1382L,1743L,2268L,3351L,5094L,8445L,8446L,8449L,8456L,8467L,8496L,8529L,8580L,8693L,8970L,9251L,9550L,9911L,10436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050064Inst : IEnumerable<long>
{
public static readonly long[] Value=A050064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050064.Bytes);
public long this[int i]=>Value[i];

public static A050064Inst Instance=new A050064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050065
{
public static readonly long[] Value={ 1L,3L,3L,6L,7L,13L,16L,19L,20L,39L,55L,68L,75L,81L,84L,87L,88L,175L,259L,340L,415L,483L,538L,577L,597L,616L,632L,645L,652L,658L,661L,664L,665L,1329L,1990L,2648L,3300L,3945L,4577L,5193L,5790L,6367L,6905L,7388L,7803L,8143L,8402L,8577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050065Inst : IEnumerable<long>
{
public static readonly long[] Value=A050065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050065.Bytes);
public long this[int i]=>Value[i];

public static A050065Inst Instance=new A050065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050066
{
public static readonly long[] Value={ 1L,3L,3L,4L,7L,8L,11L,14L,18L,19L,22L,25L,29L,36L,44L,55L,69L,70L,73L,76L,80L,87L,95L,106L,120L,138L,157L,179L,204L,233L,269L,313L,368L,369L,372L,375L,379L,386L,394L,405L,419L,437L,456L,478L,503L,532L,568L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050066Inst : IEnumerable<long>
{
public static readonly long[] Value=A050066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050066.Bytes);
public long this[int i]=>Value[i];

public static A050066Inst Instance=new A050066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050067
{
public static readonly long[] Value={ 1L,3L,3L,6L,12L,15L,21L,36L,72L,75L,81L,96L,132L,207L,303L,510L,1020L,1023L,1029L,1044L,1080L,1155L,1251L,1458L,1968L,2991L,4035L,5190L,6648L,9639L,14829L,24468L,48936L,48939L,48945L,48960L,48996L,49071L,49167L,49374L,49884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050067Inst : IEnumerable<long>
{
public static readonly long[] Value=A050067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050067.Bytes);
public long this[int i]=>Value[i];

public static A050067Inst Instance=new A050067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050068
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,10L,14L,23L,37L,38L,42L,51L,65L,102L,144L,209L,353L,354L,358L,367L,381L,418L,460L,525L,669L,1022L,1380L,1761L,2221L,2890L,4270L,6491L,10761L,10762L,10766L,10775L,10789L,10826L,10868L,10933L,11077L,11430L,11788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050068Inst : IEnumerable<long>
{
public static readonly long[] Value=A050068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050068.Bytes);
public long this[int i]=>Value[i];

public static A050068Inst Instance=new A050068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050069
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,15L,19L,22L,23L,45L,64L,79L,87L,94L,98L,101L,102L,203L,301L,395L,482L,561L,625L,670L,693L,715L,734L,749L,757L,764L,768L,771L,772L,1543L,2311L,3075L,3832L,4581L,5315L,6030L,6723L,7393L,8018L,8579L,9061L,9456L,9757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050069Inst : IEnumerable<long>
{
public static readonly long[] Value=A050069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050069.Bytes);
public long this[int i]=>Value[i];

public static A050069Inst Instance=new A050069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050070
{
public static readonly long[] Value={ 1L,3L,4L,5L,8L,9L,12L,16L,21L,22L,25L,29L,34L,42L,51L,63L,79L,80L,83L,87L,92L,100L,109L,121L,137L,158L,180L,205L,234L,268L,310L,361L,424L,425L,428L,432L,437L,445L,454L,466L,482L,503L,525L,550L,579L,613L,655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050070Inst : IEnumerable<long>
{
public static readonly long[] Value=A050070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050070.Bytes);
public long this[int i]=>Value[i];

public static A050070Inst Instance=new A050070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050071
{
public static readonly long[] Value={ 1L,3L,4L,7L,14L,17L,24L,41L,82L,85L,92L,109L,150L,235L,344L,579L,1158L,1161L,1168L,1185L,1226L,1311L,1420L,1655L,2234L,3395L,4580L,5891L,7546L,10941L,16832L,27773L,55546L,55549L,55556L,55573L,55614L,55699L,55808L,56043L,56622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050071Inst : IEnumerable<long>
{
public static readonly long[] Value=A050071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050071.Bytes);
public long this[int i]=>Value[i];

public static A050071Inst Instance=new A050071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050072
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050072Inst : IEnumerable<long>
{
public static readonly long[] Value=A050072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050072.Bytes);
public long this[int i]=>Value[i];

public static A050072Inst Instance=new A050072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050073
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050073Inst : IEnumerable<long>
{
public static readonly long[] Value=A050073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050073.Bytes);
public long this[int i]=>Value[i];

public static A050073Inst Instance=new A050073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050074
{
public static readonly long[] Value={ 1L,2L,3L,1L,0L,1L,2L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,2L,0L,1L,1L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050074Inst : IEnumerable<long>
{
public static readonly long[] Value=A050074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050074.Bytes);
public long this[int i]=>Value[i];

public static A050074Inst Instance=new A050074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050075
{
public static readonly long[] Value={ 1L,2L,3L,2L,0L,1L,1L,2L,0L,1L,1L,2L,0L,0L,1L,0L,2L,1L,1L,2L,0L,0L,1L,0L,2L,2L,1L,0L,2L,2L,2L,1L,1L,0L,2L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,2L,1L,0L,2L,2L,2L,1L,1L,1L,1L,0L,0L,2L,0L,2L,1L,0L,2L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,2L,1L,0L,2L,2L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050075Inst : IEnumerable<long>
{
public static readonly long[] Value=A050075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050075.Bytes);
public long this[int i]=>Value[i];

public static A050075Inst Instance=new A050075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050076
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,5L,10L,3L,6L,12L,24L,48L,96L,32L,64L,21L,7L,14L,28L,9L,18L,36L,72L,144L,288L,576L,192L,384L,128L,42L,84L,168L,56L,112L,37L,74L,148L,49L,98L,196L,65L,130L,43L,86L,172L,57L,19L,38L,76L,25L,50L,100L,33L,11L,22L,44L,88L,29L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050076Inst : IEnumerable<long>
{
public static readonly long[] Value=A050076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050076.Bytes);
public long this[int i]=>Value[i];

public static A050076Inst Instance=new A050076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050077
{
public static readonly long[] Value={ 1L,2L,8L,3L,6L,9L,17L,4L,20L,7L,54L,10L,75L,18L,70L,5L,65L,21L,47L,73L,16L,55L,81L,11L,50L,76L,89L,19L,58L,71L,216L,14L,53L,66L,211L,22L,35L,48L,118L,74L,175L,30L,43L,56L,69L,82L,258L,12L,38L,51L,64L,77L,209L,90L,222L,33L,46L,59L,160L,72L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050077Inst : IEnumerable<long>
{
public static readonly long[] Value=A050077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050077.Bytes);
public long this[int i]=>Value[i];

public static A050077Inst Instance=new A050077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050078
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,14L,17L,18L,20L,21L,22L,23L,24L,25L,27L,30L,31L,33L,35L,36L,38L,39L,41L,43L,44L,47L,48L,50L,51L,54L,55L,56L,58L,59L,60L,62L,65L,66L,67L,70L,71L,73L,75L,76L,77L,78L,81L,82L,83L,85L,86L,89L,90L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050078Inst : IEnumerable<long>
{
public static readonly long[] Value=A050078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050078.Bytes);
public long this[int i]=>Value[i];

public static A050078Inst Instance=new A050078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050079
{
public static readonly long[] Value={ 5L,7L,13L,15L,16L,19L,26L,28L,29L,32L,34L,37L,40L,42L,45L,46L,49L,52L,53L,57L,61L,63L,64L,68L,69L,72L,74L,79L,80L,84L,87L,88L,96L,98L,99L,100L,103L,105L,109L,110L,114L,116L,117L,123L,124L,128L,130L,132L,135L,138L,141L,144L,145L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050079Inst : IEnumerable<long>
{
public static readonly long[] Value=A050079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050079.Bytes);
public long this[int i]=>Value[i];

public static A050079Inst Instance=new A050079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050080
{
public static readonly long[] Value={ 1L,4L,16L,5L,20L,6L,2L,8L,32L,10L,3L,12L,48L,192L,64L,21L,7L,28L,9L,36L,144L,576L,2304L,768L,256L,85L,340L,113L,37L,148L,49L,196L,65L,260L,86L,344L,114L,38L,152L,50L,200L,66L,22L,88L,29L,116L,464L,154L,51L,17L,68L,272L,90L,30L,120L,40L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050080Inst : IEnumerable<long>
{
public static readonly long[] Value=A050080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050080.Bytes);
public long this[int i]=>Value[i];

public static A050080Inst Instance=new A050080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050081
{
public static readonly long[] Value={ 1L,7L,11L,2L,4L,6L,17L,8L,19L,10L,91L,12L,57L,75L,102L,3L,50L,68L,86L,5L,16L,43L,61L,70L,88L,106L,115L,18L,45L,54L,203L,9L,90L,99L,230L,20L,29L,38L,135L,56L,144L,74L,83L,92L,101L,110L,293L,13L,31L,40L,49L,58L,259L,67L,207L,76L,85L,94L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050081Inst : IEnumerable<long>
{
public static readonly long[] Value=A050081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050081.Bytes);
public long this[int i]=>Value[i];

public static A050081Inst Instance=new A050081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050082
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,11L,12L,13L,17L,19L,20L,21L,22L,26L,29L,31L,33L,35L,38L,40L,43L,45L,46L,50L,51L,54L,57L,58L,61L,62L,64L,68L,70L,71L,75L,76L,78L,80L,83L,86L,88L,91L,92L,94L,96L,99L,102L,103L,106L,107L,110L,112L,115L,116L,117L,118L,119L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050082Inst : IEnumerable<long>
{
public static readonly long[] Value=A050082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050082.Bytes);
public long this[int i]=>Value[i];

public static A050082Inst Instance=new A050082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050083
{
public static readonly long[] Value={ 3L,5L,6L,9L,10L,14L,15L,16L,18L,23L,24L,25L,27L,28L,30L,32L,34L,36L,37L,39L,41L,42L,44L,47L,48L,49L,52L,53L,55L,56L,59L,60L,63L,65L,66L,67L,69L,72L,73L,74L,77L,79L,81L,82L,84L,85L,87L,89L,90L,93L,95L,97L,98L,100L,101L,104L,105L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050083Inst : IEnumerable<long>
{
public static readonly long[] Value=A050083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050083.Bytes);
public long this[int i]=>Value[i];

public static A050083Inst Instance=new A050083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050084
{
public static readonly long[] Value={ 1L,5L,25L,8L,2L,10L,3L,15L,75L,375L,125L,41L,13L,4L,20L,6L,30L,150L,50L,16L,80L,26L,130L,43L,14L,70L,23L,7L,35L,11L,55L,18L,90L,450L,2250L,750L,250L,83L,27L,9L,45L,225L,1125L,5625L,1875L,625L,208L,69L,345L,115L,38L,12L,60L,300L,100L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050084Inst : IEnumerable<long>
{
public static readonly long[] Value=A050084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050084.Bytes);
public long this[int i]=>Value[i];

public static A050084Inst Instance=new A050084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050085
{
public static readonly long[] Value={ 1L,5L,7L,14L,2L,16L,28L,4L,40L,6L,30L,52L,13L,25L,8L,20L,91L,32L,86L,15L,81L,140L,27L,135L,3L,22L,39L,93L,221L,17L,88L,248L,56L,179L,29L,110L,174L,51L,105L,137L,12L,73L,24L,196L,41L,68L,127L,191L,287L,19L,90L,186L,250L,314L,31L,149L,213L,85L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050085Inst : IEnumerable<long>
{
public static readonly long[] Value=A050085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050085.Bytes);
public long this[int i]=>Value[i];

public static A050085Inst Instance=new A050085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050086
{
public static readonly long[] Value={ 1L,2L,5L,7L,8L,9L,14L,16L,17L,20L,22L,25L,28L,30L,32L,33L,34L,40L,41L,42L,43L,48L,52L,53L,56L,57L,60L,62L,64L,68L,70L,73L,74L,77L,81L,82L,86L,88L,91L,93L,94L,97L,99L,102L,105L,107L,110L,111L,112L,116L,119L,121L,123L,127L,129L,130L,135L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050086Inst : IEnumerable<long>
{
public static readonly long[] Value=A050086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050086.Bytes);
public long this[int i]=>Value[i];

public static A050086Inst Instance=new A050086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050087
{
public static readonly long[] Value={ 3L,4L,6L,10L,11L,12L,13L,15L,18L,19L,21L,23L,24L,26L,27L,29L,31L,35L,36L,37L,38L,39L,44L,45L,46L,47L,49L,50L,51L,54L,55L,58L,59L,61L,63L,65L,66L,67L,69L,71L,72L,75L,76L,78L,79L,80L,83L,84L,85L,87L,89L,90L,92L,95L,96L,98L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050087Inst : IEnumerable<long>
{
public static readonly long[] Value=A050087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050087.Bytes);
public long this[int i]=>Value[i];

public static A050087Inst Instance=new A050087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050088
{
public static readonly long[] Value={ 1L,6L,2L,12L,4L,24L,8L,48L,16L,5L,30L,10L,3L,18L,108L,36L,216L,72L,432L,144L,864L,288L,96L,32L,192L,64L,21L,7L,42L,14L,84L,28L,9L,54L,324L,1944L,648L,3888L,1296L,7776L,2592L,15552L,5184L,1728L,576L,3456L,1152L,384L,128L,768L,256L,85L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050088Inst : IEnumerable<long>
{
public static readonly long[] Value=A050088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050088.Bytes);
public long this[int i]=>Value[i];

public static A050088Inst Instance=new A050088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050089
{
public static readonly long[] Value={ 1L,3L,13L,5L,10L,2L,28L,7L,33L,12L,88L,4L,122L,30L,114L,9L,106L,14L,77L,119L,27L,90L,132L,6L,82L,124L,145L,32L,95L,11L,279L,24L,87L,108L,271L,16L,58L,79L,192L,121L,29L,71L,92L,113L,134L,347L,8L,63L,84L,105L,126L,339L,34L,289L,55L,76L,97L,189L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050089Inst : IEnumerable<long>
{
public static readonly long[] Value=A050089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050089.Bytes);
public long this[int i]=>Value[i];

public static A050089Inst Instance=new A050089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050090
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,13L,14L,16L,18L,20L,24L,28L,30L,33L,34L,35L,37L,39L,41L,45L,49L,52L,55L,58L,60L,63L,65L,68L,71L,73L,77L,79L,82L,84L,88L,90L,92L,95L,97L,99L,102L,106L,108L,110L,114L,115L,119L,122L,124L,126L,128L,132L,134L,136L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050090Inst : IEnumerable<long>
{
public static readonly long[] Value=A050090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050090.Bytes);
public long this[int i]=>Value[i];

public static A050090Inst Instance=new A050090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050091
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,11L,12L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,32L,36L,38L,40L,42L,43L,44L,46L,47L,48L,50L,51L,53L,54L,56L,57L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,76L,78L,80L,81L,83L,85L,86L,87L,89L,91L,93L,94L,96L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050091Inst : IEnumerable<long>
{
public static readonly long[] Value=A050091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050091.Bytes);
public long this[int i]=>Value[i];

public static A050091Inst Instance=new A050091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050092
{
public static readonly long[] Value={ 1L,7L,2L,14L,4L,28L,9L,3L,21L,147L,49L,16L,5L,35L,11L,77L,25L,8L,56L,18L,6L,42L,294L,98L,32L,10L,70L,23L,161L,53L,17L,119L,39L,13L,91L,30L,210L,1470L,490L,163L,54L,378L,126L,882L,6174L,2058L,686L,228L,76L,532L,177L,59L,19L,133L,44L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050092Inst : IEnumerable<long>
{
public static readonly long[] Value=A050092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050092.Bytes);
public long this[int i]=>Value[i];

public static A050092Inst Instance=new A050092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050093
{
public static readonly long[] Value={ 1L,3L,8L,5L,13L,21L,2L,18L,7L,26L,15L,81L,34L,4L,67L,12L,31L,20L,53L,64L,9L,133L,28L,252L,17L,61L,72L,6L,130L,36L,249L,25L,152L,58L,14L,163L,343L,80L,33L,282L,462L,22L,221L,55L,509L,66L,232L,376L,11L,88L,135L,351L,30L,41L,146L,19L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050093Inst : IEnumerable<long>
{
public static readonly long[] Value=A050093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050093.Bytes);
public long this[int i]=>Value[i];

public static A050093Inst Instance=new A050093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050094
{
public static readonly long[] Value={ 1L,3L,5L,8L,9L,13L,15L,18L,21L,22L,26L,28L,31L,34L,36L,37L,41L,43L,44L,49L,53L,55L,58L,61L,64L,67L,68L,72L,74L,75L,81L,82L,85L,88L,90L,93L,94L,95L,101L,103L,106L,109L,112L,115L,118L,121L,123L,126L,130L,133L,135L,136L,140L,143L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050094Inst : IEnumerable<long>
{
public static readonly long[] Value=A050094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050094.Bytes);
public long this[int i]=>Value[i];

public static A050094Inst Instance=new A050094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050095
{
public static readonly long[] Value={ 2L,4L,6L,7L,10L,11L,12L,14L,16L,17L,19L,20L,23L,24L,25L,27L,29L,30L,32L,33L,35L,38L,39L,40L,42L,45L,46L,47L,48L,50L,51L,52L,54L,56L,57L,59L,60L,62L,63L,65L,66L,69L,70L,71L,73L,76L,77L,78L,79L,80L,83L,84L,86L,87L,89L,91L,92L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050095Inst : IEnumerable<long>
{
public static readonly long[] Value=A050095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050095.Bytes);
public long this[int i]=>Value[i];

public static A050095Inst Instance=new A050095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050096
{
public static readonly long[] Value={ 1L,8L,2L,16L,5L,40L,13L,4L,32L,10L,3L,24L,192L,64L,21L,7L,56L,18L,6L,48L,384L,128L,42L,14L,112L,37L,12L,96L,768L,256L,85L,28L,9L,72L,576L,4608L,1536L,512L,170L,1360L,453L,151L,50L,400L,133L,44L,352L,117L,39L,312L,104L,34L,11L,88L,29L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050096Inst : IEnumerable<long>
{
public static readonly long[] Value=A050096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050096.Bytes);
public long this[int i]=>Value[i];

public static A050096Inst Instance=new A050096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050097
{
public static readonly long[] Value={ 1L,3L,11L,8L,5L,19L,16L,2L,33L,10L,53L,27L,7L,24L,70L,4L,145L,18L,64L,272L,15L,61L,295L,12L,58L,292L,81L,32L,55L,367L,78L,9L,286L,52L,75L,205L,26L,335L,49L,6L,228L,23L,358L,46L,69L,199L,251L,20L,381L,43L,144L,196L,248L,300L,352L,17L,115L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050097Inst : IEnumerable<long>
{
public static readonly long[] Value=A050097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050097.Bytes);
public long this[int i]=>Value[i];

public static A050097Inst Instance=new A050097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050098
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,12L,16L,19L,20L,24L,27L,28L,33L,34L,35L,39L,43L,46L,49L,53L,55L,58L,61L,64L,65L,70L,71L,75L,78L,81L,82L,83L,84L,90L,94L,97L,100L,101L,104L,109L,111L,115L,116L,117L,122L,123L,129L,132L,133L,138L,140L,145L,146L,148L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050098Inst : IEnumerable<long>
{
public static readonly long[] Value=A050098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050098.Bytes);
public long this[int i]=>Value[i];

public static A050098Inst Instance=new A050098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050099
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,10L,13L,14L,15L,17L,18L,21L,22L,23L,25L,26L,29L,30L,31L,32L,36L,37L,38L,40L,41L,42L,44L,45L,47L,48L,50L,51L,52L,54L,56L,57L,59L,60L,62L,63L,66L,67L,68L,69L,72L,73L,74L,76L,77L,79L,80L,85L,86L,87L,88L,89L,91L,92L,93L,95L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050099Inst : IEnumerable<long>
{
public static readonly long[] Value=A050099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050099.Bytes);
public long this[int i]=>Value[i];

public static A050099Inst Instance=new A050099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050100
{
public static readonly long[] Value={ 1L,10L,3L,30L,300L,100L,33L,11L,110L,36L,12L,4L,40L,13L,130L,43L,14L,140L,46L,15L,5L,50L,16L,160L,53L,17L,170L,56L,18L,6L,2L,20L,200L,66L,22L,7L,70L,23L,230L,76L,25L,8L,80L,26L,260L,86L,28L,9L,90L,900L,9000L,3000L,1000L,333L,111L,37L,370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050100Inst : IEnumerable<long>
{
public static readonly long[] Value=A050100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050100.Bytes);
public long this[int i]=>Value[i];

public static A050100Inst Instance=new A050100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050101
{
public static readonly long[] Value={ 1L,31L,3L,12L,21L,30L,36L,42L,48L,2L,8L,11L,14L,17L,20L,23L,26L,29L,208L,32L,211L,35L,38L,78L,41L,44L,118L,47L,84L,4L,155L,87L,7L,158L,90L,10L,56L,93L,263L,13L,59L,96L,16L,300L,62L,19L,201L,269L,402L,22L,102L,204L,25L,306L,68L,28L,207L,241L,275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050101Inst : IEnumerable<long>
{
public static readonly long[] Value=A050101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050101.Bytes);
public long this[int i]=>Value[i];

public static A050101Inst Instance=new A050101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050102
{
public static readonly long[] Value={ 1L,3L,4L,8L,12L,14L,17L,21L,23L,26L,31L,32L,36L,38L,42L,44L,48L,49L,50L,56L,59L,62L,64L,68L,71L,74L,78L,79L,84L,87L,90L,93L,96L,97L,102L,103L,108L,111L,114L,118L,119L,120L,121L,127L,132L,135L,138L,141L,142L,147L,151L,155L,158L,160L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050102Inst : IEnumerable<long>
{
public static readonly long[] Value=A050102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050102.Bytes);
public long this[int i]=>Value[i];

public static A050102Inst Instance=new A050102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050103
{
public static readonly long[] Value={ 2L,5L,6L,7L,9L,10L,11L,13L,15L,16L,18L,19L,20L,22L,24L,25L,27L,28L,29L,30L,33L,34L,35L,37L,39L,40L,41L,43L,45L,46L,47L,51L,52L,53L,54L,55L,57L,58L,60L,61L,63L,65L,66L,67L,69L,70L,72L,73L,75L,76L,77L,80L,81L,82L,83L,85L,86L,88L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050103Inst : IEnumerable<long>
{
public static readonly long[] Value=A050103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050103.Bytes);
public long this[int i]=>Value[i];

public static A050103Inst Instance=new A050103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050104
{
public static readonly long[] Value={ 1L,3L,9L,2L,6L,18L,4L,12L,36L,108L,27L,81L,20L,5L,15L,45L,11L,33L,8L,24L,72L,216L,54L,13L,39L,117L,29L,7L,21L,63L,189L,47L,141L,35L,105L,26L,78L,19L,57L,14L,42L,10L,30L,90L,22L,66L,16L,48L,144L,432L,1296L,324L,972L,243L,60L,180L,540L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050104Inst : IEnumerable<long>
{
public static readonly long[] Value=A050104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050104.Bytes);
public long this[int i]=>Value[i];

public static A050104Inst Instance=new A050104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050105
{
public static readonly long[] Value={ 1L,4L,2L,7L,14L,5L,28L,19L,3L,42L,17L,8L,24L,40L,15L,47L,72L,6L,38L,13L,29L,45L,70L,20L,61L,36L,11L,77L,27L,43L,68L,136L,18L,127L,34L,9L,152L,75L,25L,143L,100L,41L,168L,91L,16L,159L,32L,48L,322L,150L,73L,399L,528L,23L,98L,64L,39L,338L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050105Inst : IEnumerable<long>
{
public static readonly long[] Value=A050105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050105.Bytes);
public long this[int i]=>Value[i];

public static A050105Inst Instance=new A050105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050106
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,14L,15L,17L,19L,20L,21L,24L,25L,28L,29L,30L,32L,34L,36L,38L,40L,42L,43L,45L,47L,48L,49L,50L,52L,55L,56L,58L,61L,62L,64L,65L,68L,70L,72L,73L,75L,77L,78L,79L,80L,82L,85L,87L,89L,91L,92L,94L,96L,98L,100L,101L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050106Inst : IEnumerable<long>
{
public static readonly long[] Value=A050106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050106.Bytes);
public long this[int i]=>Value[i];

public static A050106Inst Instance=new A050106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050107
{
public static readonly long[] Value={ 3L,6L,10L,12L,13L,16L,18L,22L,23L,26L,27L,31L,33L,35L,37L,39L,41L,44L,46L,51L,53L,54L,57L,59L,60L,63L,66L,67L,69L,71L,74L,76L,81L,83L,84L,86L,88L,90L,93L,95L,97L,99L,102L,105L,107L,109L,111L,113L,116L,118L,121L,122L,125L,126L,129L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050107Inst : IEnumerable<long>
{
public static readonly long[] Value=A050107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050107.Bytes);
public long this[int i]=>Value[i];

public static A050107Inst Instance=new A050107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050108
{
public static readonly long[] Value={ 1L,5L,25L,6L,30L,7L,35L,8L,2L,10L,50L,12L,3L,15L,75L,18L,4L,20L,100L,500L,125L,31L,155L,38L,9L,45L,11L,55L,13L,65L,16L,80L,400L,2000L,10000L,2500L,625L,156L,39L,195L,48L,240L,60L,300L,1500L,375L,93L,23L,115L,28L,140L,700L,175L,43L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050108Inst : IEnumerable<long>
{
public static readonly long[] Value=A050108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050108.Bytes);
public long this[int i]=>Value[i];

public static A050108Inst Instance=new A050108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050109
{
public static readonly long[] Value={ 1L,9L,13L,17L,2L,4L,6L,8L,25L,10L,27L,12L,29L,85L,14L,31L,87L,16L,74L,18L,89L,117L,48L,104L,3L,91L,119L,50L,78L,5L,22L,93L,121L,581L,7L,80L,108L,24L,39L,95L,123L,421L,54L,192L,26L,110L,138L,41L,69L,11L,125L,315L,56L,153L,28L,84L,112L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050109Inst : IEnumerable<long>
{
public static readonly long[] Value=A050109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050109.Bytes);
public long this[int i]=>Value[i];

public static A050109Inst Instance=new A050109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050110
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,10L,13L,14L,17L,18L,19L,22L,25L,27L,29L,31L,32L,33L,34L,39L,41L,43L,44L,48L,50L,51L,54L,56L,58L,60L,62L,64L,66L,69L,71L,74L,75L,78L,80L,81L,85L,87L,89L,91L,93L,95L,96L,99L,101L,104L,105L,108L,110L,112L,114L,117L,119L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050110Inst : IEnumerable<long>
{
public static readonly long[] Value=A050110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050110.Bytes);
public long this[int i]=>Value[i];

public static A050110Inst Instance=new A050110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050111
{
public static readonly long[] Value={ 3L,5L,7L,8L,11L,12L,15L,16L,20L,21L,23L,24L,26L,28L,30L,35L,36L,37L,38L,40L,42L,45L,46L,47L,49L,52L,53L,55L,57L,59L,61L,63L,65L,67L,68L,70L,72L,73L,76L,77L,79L,82L,83L,84L,86L,88L,90L,92L,94L,97L,98L,100L,102L,103L,106L,107L,109L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050111Inst : IEnumerable<long>
{
public static readonly long[] Value=A050111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050111.Bytes);
public long this[int i]=>Value[i];

public static A050111Inst Instance=new A050111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050112
{
public static readonly long[] Value={ 1L,6L,36L,9L,2L,12L,3L,18L,4L,24L,144L,864L,216L,54L,13L,78L,19L,114L,28L,7L,42L,10L,60L,15L,90L,22L,5L,30L,180L,45L,11L,66L,16L,96L,576L,3456L,20736L,5184L,1296L,324L,81L,20L,120L,720L,4320L,1080L,270L,67L,402L,100L,25L,150L,37L,222L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050112Inst : IEnumerable<long>
{
public static readonly long[] Value=A050112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050112.Bytes);
public long this[int i]=>Value[i];

public static A050112Inst Instance=new A050112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050113
{
public static readonly long[] Value={ 1L,5L,7L,9L,27L,2L,20L,93L,4L,22L,31L,6L,15L,72L,24L,33L,65L,8L,17L,42L,74L,26L,193L,10L,51L,83L,99L,19L,273L,28L,76L,92L,108L,124L,541L,3L,53L,69L,85L,101L,188L,21L,204L,550L,30L,62L,165L,94L,110L,692L,126L,268L,653L,14L,55L,158L,71L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050113Inst : IEnumerable<long>
{
public static readonly long[] Value=A050113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050113.Bytes);
public long this[int i]=>Value[i];

public static A050113Inst Instance=new A050113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050114
{
public static readonly long[] Value={ 1L,2L,5L,7L,9L,10L,11L,15L,17L,20L,22L,24L,27L,28L,31L,33L,34L,35L,36L,42L,43L,44L,48L,51L,53L,55L,57L,59L,62L,65L,66L,69L,72L,74L,76L,77L,79L,83L,85L,87L,89L,93L,94L,96L,99L,101L,102L,104L,108L,110L,112L,114L,116L,119L,121L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050114Inst : IEnumerable<long>
{
public static readonly long[] Value=A050114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050114.Bytes);
public long this[int i]=>Value[i];

public static A050114Inst Instance=new A050114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050115
{
public static readonly long[] Value={ 3L,4L,6L,8L,12L,13L,14L,16L,18L,19L,21L,23L,25L,26L,29L,30L,32L,37L,38L,39L,40L,41L,45L,46L,47L,49L,50L,52L,54L,56L,58L,60L,61L,63L,64L,67L,68L,70L,71L,73L,75L,78L,80L,81L,82L,84L,86L,88L,90L,91L,92L,95L,97L,98L,100L,103L,105L,106L,107L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050115Inst : IEnumerable<long>
{
public static readonly long[] Value=A050115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050115.Bytes);
public long this[int i]=>Value[i];

public static A050115Inst Instance=new A050115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050116
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,8L,11L,12L,14L,18L,21L,22L,28L,29L,33L,36L,44L,47L,54L,58L,72L,76L,77L,87L,94L,116L,123L,126L,141L,152L,188L,198L,199L,203L,228L,246L,304L,319L,322L,329L,369L,398L,492L,517L,521L,522L,532L,597L,644L,796L,836L,843L,846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050116Inst : IEnumerable<long>
{
public static readonly long[] Value=A050116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050116.Bytes);
public long this[int i]=>Value[i];

public static A050116Inst Instance=new A050116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050117
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,4L,3L,1L,6L,1L,4L,3L,8L,3L,7L,4L,14L,4L,1L,10L,7L,22L,7L,3L,15L,11L,36L,10L,1L,4L,25L,18L,58L,15L,3L,7L,40L,29L,94L,25L,4L,1L,10L,65L,47L,152L,40L,7L,3L,15L,105L,76L,246L,65L,10L,1L,4L,25L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050117Inst : IEnumerable<long>
{
public static readonly long[] Value=A050117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050117.Bytes);
public long this[int i]=>Value[i];

public static A050117Inst Instance=new A050117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050118
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,16L,18L,21L,22L,28L,29L,33L,36L,44L,47L,49L,54L,58L,72L,76L,77L,87L,94L,116L,121L,123L,126L,141L,152L,188L,198L,199L,203L,228L,246L,304L,319L,322L,324L,329L,369L,398L,492L,517L,521L,522L,532L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050118Inst : IEnumerable<long>
{
public static readonly long[] Value=A050118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050118.Bytes);
public long this[int i]=>Value[i];

public static A050118Inst Instance=new A050118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050119
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,2L,2L,3L,1L,6L,1L,4L,3L,8L,3L,2L,5L,4L,14L,4L,1L,10L,7L,22L,5L,2L,3L,15L,11L,36L,10L,1L,4L,25L,18L,58L,15L,3L,2L,5L,40L,29L,94L,25L,4L,1L,10L,65L,47L,152L,40L,5L,2L,3L,15L,105L,76L,246L,65L,10L,1L,4L,25L,170L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050119Inst : IEnumerable<long>
{
public static readonly long[] Value=A050119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050119.Bytes);
public long this[int i]=>Value[i];

public static A050119Inst Instance=new A050119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050120
{
public static readonly long[] Value={ 0L,3L,4L,7L,11L,14L,18L,22L,29L,33L,36L,47L,54L,58L,76L,87L,90L,94L,123L,141L,145L,152L,199L,228L,232L,235L,246L,322L,369L,376L,380L,398L,521L,597L,608L,611L,615L,644L,843L,966L,984L,988L,995L,1042L,1364L,1563L,1592L,1596L,1599L,1610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050120Inst : IEnumerable<long>
{
public static readonly long[] Value=A050120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050120.Bytes);
public long this[int i]=>Value[i];

public static A050120Inst Instance=new A050120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050121
{
public static readonly long[] Value={ 3L,1L,3L,4L,3L,4L,4L,7L,4L,3L,11L,7L,4L,18L,11L,3L,4L,29L,18L,4L,7L,47L,29L,4L,3L,11L,76L,47L,7L,4L,18L,123L,76L,11L,3L,4L,29L,199L,123L,18L,4L,7L,47L,322L,199L,29L,4L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050121Inst : IEnumerable<long>
{
public static readonly long[] Value=A050121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050121.Bytes);
public long this[int i]=>Value[i];

public static A050121Inst Instance=new A050121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050122
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,8L,11L,14L,18L,21L,22L,29L,33L,36L,47L,54L,55L,58L,76L,87L,90L,94L,123L,141L,144L,145L,152L,199L,228L,232L,235L,246L,322L,369L,376L,377L,380L,398L,521L,597L,608L,611L,615L,644L,843L,966L,984L,987L,988L,995L,1042L,1364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050122Inst : IEnumerable<long>
{
public static readonly long[] Value=A050122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050122.Bytes);
public long this[int i]=>Value[i];

public static A050122Inst Instance=new A050122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050123
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,3L,3L,4L,3L,1L,7L,4L,3L,11L,7L,1L,3L,18L,11L,3L,4L,29L,18L,3L,1L,7L,47L,29L,4L,3L,11L,76L,47L,7L,1L,3L,18L,123L,76L,11L,3L,4L,29L,199L,123L,18L,3L,1L,7L,47L,322L,199L,29L,4L,3L,11L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050123Inst : IEnumerable<long>
{
public static readonly long[] Value=A050123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050123.Bytes);
public long this[int i]=>Value[i];

public static A050123Inst Instance=new A050123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050124
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,3L,6L,12L,24L,48L,9L,18L,36L,7L,14L,28L,5L,10L,20L,40L,80L,160L,32L,64L,128L,25L,50L,100L,200L,400L,800L,1600L,320L,640L,1280L,256L,51L,102L,204L,408L,81L,162L,324L,648L,129L,258L,516L,103L,206L,41L,82L,164L,328L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050124Inst : IEnumerable<long>
{
public static readonly long[] Value=A050124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050124.Bytes);
public long this[int i]=>Value[i];

public static A050124Inst Instance=new A050124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050125
{
public static readonly long[] Value={ 1L,2L,6L,3L,17L,7L,14L,4L,11L,18L,108L,8L,55L,15L,175L,5L,92L,12L,182L,19L,69L,109L,149L,9L,26L,56L,86L,16L,146L,176L,206L,23L,63L,93L,113L,13L,163L,183L,213L,20L,50L,70L,90L,110L,130L,150L,170L,10L,210L,27L,37L,57L,77L,87L,107L,117L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050125Inst : IEnumerable<long>
{
public static readonly long[] Value=A050125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050125.Bytes);
public long this[int i]=>Value[i];

public static A050125Inst Instance=new A050125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050126
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,17L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,30L,31L,33L,34L,37L,38L,39L,41L,42L,43L,45L,46L,48L,50L,51L,52L,55L,56L,57L,58L,59L,61L,63L,64L,65L,66L,69L,70L,71L,72L,74L,75L,77L,78L,79L,80L,82L,83L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050126Inst : IEnumerable<long>
{
public static readonly long[] Value=A050126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050126.Bytes);
public long this[int i]=>Value[i];

public static A050126Inst Instance=new A050126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050127
{
public static readonly long[] Value={ 5L,10L,13L,16L,22L,25L,32L,35L,36L,40L,44L,47L,49L,53L,54L,60L,62L,67L,68L,73L,76L,81L,84L,85L,89L,91L,98L,101L,103L,106L,107L,112L,116L,120L,123L,127L,129L,133L,136L,140L,144L,145L,148L,153L,158L,160L,162L,166L,169L,173L,174L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050127Inst : IEnumerable<long>
{
public static readonly long[] Value=A050127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050127.Bytes);
public long this[int i]=>Value[i];

public static A050127Inst Instance=new A050127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050128
{
public static readonly long[] Value={ 1L,4L,2L,8L,10L,5L,14L,7L,3L,20L,22L,11L,26L,13L,6L,32L,16L,36L,18L,9L,42L,21L,46L,23L,50L,25L,12L,56L,28L,60L,30L,15L,66L,33L,70L,35L,17L,76L,38L,19L,82L,41L,86L,43L,90L,45L,94L,47L,98L,49L,24L,104L,52L,108L,54L,27L,114L,57L,118L,59L,29L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050128Inst : IEnumerable<long>
{
public static readonly long[] Value=A050128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050128.Bytes);
public long this[int i]=>Value[i];

public static A050128Inst Instance=new A050128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050129
{
public static readonly long[] Value={ 1L,3L,9L,2L,6L,15L,8L,4L,20L,5L,12L,27L,14L,7L,32L,17L,37L,19L,40L,10L,22L,11L,24L,51L,26L,13L,56L,29L,61L,31L,64L,16L,34L,71L,36L,18L,76L,39L,81L,163L,42L,21L,44L,91L,46L,23L,48L,99L,50L,25L,104L,53L,109L,55L,112L,28L,58L,119L,60L,30L,124L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050129Inst : IEnumerable<long>
{
public static readonly long[] Value=A050129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050129.Bytes);
public long this[int i]=>Value[i];

public static A050129Inst Instance=new A050129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050130
{
public static readonly long[] Value={ 2L,4L,5L,7L,10L,11L,13L,16L,18L,21L,23L,25L,28L,30L,33L,35L,38L,41L,43L,45L,47L,49L,52L,54L,57L,59L,62L,65L,67L,69L,72L,74L,77L,79L,82L,83L,85L,87L,89L,92L,94L,95L,97L,100L,102L,105L,107L,110L,113L,115L,117L,120L,122L,125L,127L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050130Inst : IEnumerable<long>
{
public static readonly long[] Value=A050130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050130.Bytes);
public long this[int i]=>Value[i];

public static A050130Inst Instance=new A050130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050131
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,10L,12L,15L,17L,20L,22L,24L,27L,29L,32L,34L,37L,40L,42L,44L,46L,48L,51L,53L,56L,58L,61L,64L,66L,68L,71L,73L,76L,78L,81L,82L,84L,86L,88L,91L,93L,94L,96L,99L,101L,104L,106L,109L,112L,114L,116L,119L,121L,124L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050131Inst : IEnumerable<long>
{
public static readonly long[] Value=A050131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050131.Bytes);
public long this[int i]=>Value[i];

public static A050131Inst Instance=new A050131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050132
{
public static readonly long[] Value={ 1L,6L,3L,12L,15L,7L,21L,10L,5L,2L,33L,16L,8L,4L,45L,22L,11L,54L,27L,13L,63L,31L,69L,34L,17L,78L,39L,19L,9L,90L,93L,46L,23L,102L,51L,25L,111L,55L,117L,58L,29L,14L,129L,64L,32L,138L,141L,70L,35L,150L,75L,37L,18L,162L,81L,40L,20L,174L,87L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050132Inst : IEnumerable<long>
{
public static readonly long[] Value=A050132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050132.Bytes);
public long this[int i]=>Value[i];

public static A050132Inst Instance=new A050132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050133
{
public static readonly long[] Value={ 1L,10L,3L,14L,9L,2L,6L,13L,29L,8L,17L,4L,20L,42L,5L,12L,25L,53L,28L,57L,7L,16L,33L,69L,36L,73L,19L,78L,41L,85L,22L,45L,11L,24L,49L,101L,52L,105L,27L,56L,114L,230L,60L,121L,15L,32L,65L,133L,68L,137L,35L,72L,146L,18L,38L,77L,157L,40L,81L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050133Inst : IEnumerable<long>
{
public static readonly long[] Value=A050133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050133.Bytes);
public long this[int i]=>Value[i];

public static A050133Inst Instance=new A050133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050134
{
public static readonly long[] Value={ 2L,4L,5L,7L,11L,15L,18L,21L,23L,26L,30L,31L,34L,37L,39L,43L,46L,47L,50L,54L,58L,61L,63L,66L,70L,74L,75L,79L,82L,86L,87L,90L,93L,95L,98L,102L,106L,109L,111L,115L,118L,122L,123L,126L,127L,130L,134L,138L,141L,143L,147L,150L,151L,154L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050134Inst : IEnumerable<long>
{
public static readonly long[] Value=A050134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050134.Bytes);
public long this[int i]=>Value[i];

public static A050134Inst Instance=new A050134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050135
{
public static readonly long[] Value={ 1L,8L,4L,2L,20L,10L,5L,32L,16L,40L,44L,22L,11L,56L,28L,14L,7L,3L,76L,38L,19L,9L,92L,46L,23L,104L,52L,26L,13L,6L,124L,62L,31L,15L,140L,70L,35L,17L,156L,78L,39L,168L,84L,42L,21L,184L,188L,94L,47L,200L,100L,50L,25L,12L,220L,110L,55L,27L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050135Inst : IEnumerable<long>
{
public static readonly long[] Value=A050135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050135.Bytes);
public long this[int i]=>Value[i];

public static A050135Inst Instance=new A050135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050136
{
public static readonly long[] Value={ 1L,10L,5L,20L,25L,12L,6L,3L,45L,22L,11L,60L,30L,15L,7L,80L,40L,90L,95L,47L,23L,110L,55L,27L,13L,130L,65L,32L,16L,8L,4L,2L,165L,82L,41L,180L,185L,92L,46L,200L,100L,50L,215L,107L,53L,26L,235L,117L,58L,29L,14L,260L,265L,132L,66L,33L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050136Inst : IEnumerable<long>
{
public static readonly long[] Value=A050136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050136.Bytes);
public long this[int i]=>Value[i];

public static A050136Inst Instance=new A050136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050137
{
public static readonly long[] Value={ 2L,1L,6L,3L,10L,5L,14L,7L,18L,9L,4L,24L,12L,28L,30L,15L,34L,17L,8L,40L,20L,44L,22L,11L,50L,25L,54L,27L,13L,60L,62L,31L,66L,33L,16L,72L,36L,76L,38L,19L,82L,41L,86L,43L,21L,92L,46L,23L,98L,49L,102L,51L,106L,53L,26L,112L,56L,116L,58L,29L,122L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050137Inst : IEnumerable<long>
{
public static readonly long[] Value=A050137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050137.Bytes);
public long this[int i]=>Value[i];

public static A050137Inst Instance=new A050137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050138
{
public static readonly long[] Value={ 2L,6L,3L,1L,15L,7L,21L,10L,5L,30L,33L,16L,8L,4L,45L,22L,11L,54L,27L,13L,63L,31L,69L,34L,17L,78L,39L,19L,9L,90L,93L,46L,23L,102L,51L,25L,12L,114L,57L,28L,14L,126L,129L,64L,32L,138L,141L,70L,35L,150L,75L,37L,18L,162L,81L,40L,20L,174L,87L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050138Inst : IEnumerable<long>
{
public static readonly long[] Value=A050138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050138.Bytes);
public long this[int i]=>Value[i];

public static A050138Inst Instance=new A050138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050139
{
public static readonly long[] Value={ 2L,1L,12L,6L,3L,24L,28L,14L,7L,40L,20L,10L,5L,56L,60L,30L,15L,72L,36L,18L,9L,4L,92L,46L,23L,11L,108L,54L,27L,13L,124L,62L,31L,136L,68L,34L,17L,8L,156L,78L,39L,19L,172L,86L,43L,21L,188L,94L,47L,200L,100L,50L,25L,216L,220L,110L,55L,232L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050139Inst : IEnumerable<long>
{
public static readonly long[] Value=A050139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050139.Bytes);
public long this[int i]=>Value[i];

public static A050139Inst Instance=new A050139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050140
{
public static readonly long[] Value={ 1L,4L,5L,8L,11L,12L,15L,16L,19L,22L,23L,26L,29L,30L,33L,34L,37L,40L,41L,44L,45L,48L,51L,52L,55L,58L,59L,62L,63L,66L,69L,70L,73L,76L,77L,80L,81L,84L,87L,88L,91L,92L,95L,98L,99L,102L,105L,106L,109L,110L,113L,116L,117L,120L,121L,124L,127L,128L,131L,134L,135L,138L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050140Inst : IEnumerable<long>
{
public static readonly long[] Value=A050140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050140.Bytes);
public long this[int i]=>Value[i];

public static A050140Inst Instance=new A050140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050141
{
public static readonly long[] Value={ 3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050141Inst : IEnumerable<long>
{
public static readonly long[] Value=A050141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050141.Bytes);
public long this[int i]=>Value[i];

public static A050141Inst Instance=new A050141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050142
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,2L,3L,4L,6L,9L,4L,6L,6L,9L,12L,18L,8L,8L,12L,18L,22L,33L,38L,16L,16L,22L,28L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050142Inst : IEnumerable<long>
{
public static readonly long[] Value=A050142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050142.Bytes);
public long this[int i]=>Value[i];

public static A050142Inst Instance=new A050142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050143
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,1L,0L,1L,4L,7L,1L,0L,1L,5L,12L,15L,1L,0L,1L,6L,18L,32L,31L,1L,0L,1L,7L,25L,56L,80L,63L,1L,0L,1L,8L,33L,88L,160L,192L,127L,1L,0L,1L,9L,42L,129L,280L,432L,448L,255L,1L,0L,1L,10L,52L,180L,450L,832L,1120L,1024L,511L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050143Inst : IEnumerable<long>
{
public static readonly long[] Value=A050143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050143.Bytes);
public long this[int i]=>Value[i];

public static A050143Inst Instance=new A050143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A050144
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,2L,3L,4L,1L,5L,9L,14L,6L,1L,14L,28L,48L,27L,8L,1L,42L,90L,165L,110L,44L,10L,1L,132L,297L,572L,429L,208L,65L,12L,1L,429L,1001L,2002L,1638L,910L,350L,90L,14L,1L,1430L,3432L,7072L,6188L,3808L,1700L,544L,119L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A050144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A050144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A050144Inst : IEnumerable<long>
{
public static readonly long[] Value=A050144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A050144.Bytes);
public long this[int i]=>Value[i];

public static A050144Inst Instance=new A050144Inst();

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