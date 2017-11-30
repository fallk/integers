using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210857
{
public static readonly BigInteger[] Value={ 4L,94L,6400L,1265336L,726175112L,1209791788480L,5850732722422240L,BigInteger.Parse("82137354029529991584"),BigInteger.Parse("3347356112567824150084288"),BigInteger.Parse("395998823277275732737683780672"),BigInteger.Parse("135993026862887355613684481546308800") };
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
public class A210857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210857Inst Instance=new A210857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210858
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,8L,3L,1L,10L,24L,20L,5L,1L,15L,59L,82L,45L,8L,1L,21L,125L,271L,251L,98L,13L,1L,28L,237L,765L,1073L,701L,204L,21L,1L,36L,413L,1898L,3860L,3802L,1842L,414L,34L,1L,45L,674L,4235L,12115L,17011L,12325L,4589L,820L,55L,1L,55L,1044L,8662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210858Inst : IEnumerable<long>
{
public static readonly long[] Value=A210858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210858.Bytes);
public long this[int i]=>Value[i];

public static A210858Inst Instance=new A210858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210859
{
public static readonly long[] Value={ 1L,2L,2L,3L,6L,3L,4L,16L,17L,5L,5L,35L,62L,40L,8L,6L,66L,189L,206L,90L,13L,7L,112L,494L,822L,603L,191L,21L,8L,176L,1133L,2787L,3101L,1638L,393L,34L,9L,261L,2337L,8255L,13209L,10483L,4175L,786L,55L,10L,370L,4427L,21730L,48753L,55089L,32705L,10157L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210859Inst : IEnumerable<long>
{
public static readonly long[] Value=A210859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210859.Bytes);
public long this[int i]=>Value[i];

public static A210859Inst Instance=new A210859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210860
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,10L,18L,12L,3L,26L,64L,62L,28L,5L,76L,230L,286L,183L,60L,8L,232L,846L,1298L,1073L,503L,126L,13L,764L,3220L,5832L,5884L,3563L,1288L,255L,21L,2620L,12608L,26436L,31530L,23353L,10956L,3158L,506L,34L,9496L,51084L,121276L,166630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210860Inst : IEnumerable<long>
{
public static readonly long[] Value=A210860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210860.Bytes);
public long this[int i]=>Value[i];

public static A210860Inst Instance=new A210860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210861
{
public static readonly long[] Value={ 1L,2L,2L,6L,7L,3L,16L,30L,20L,5L,50L,116L,108L,47L,8L,156L,460L,552L,338L,105L,13L,532L,1842L,2692L,2119L,941L,221L,21L,1856L,7532L,13072L,12574L,7216L,2452L,451L,34L,6876L,31600L,63240L,71860L,50525L,22371L,6035L,895L,55L,26200L,135576L,308568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210861Inst : IEnumerable<long>
{
public static readonly long[] Value=A210861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210861.Bytes);
public long this[int i]=>Value[i];

public static A210861Inst Instance=new A210861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210862
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,4L,6L,7L,3L,5L,15L,20L,16L,5L,6L,31L,57L,63L,37L,8L,7L,56L,153L,215L,184L,81L,13L,8L,92L,370L,684L,771L,513L,171L,21L,9L,141L,805L,2028L,2898L,2603L,1354L,351L,34L,10L,205L,1598L,5515L,10084L,11582L,8319L,3415L,703L,55L,11L,286L,2940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210862Inst : IEnumerable<long>
{
public static readonly long[] Value=A210862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210862.Bytes);
public long this[int i]=>Value[i];

public static A210862Inst Instance=new A210862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210863
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,3L,9L,13L,13L,5L,16L,37L,47L,32L,8L,25L,96L,152L,147L,73L,13L,36L,217L,469L,587L,432L,158L,21L,49L,435L,1344L,2127L,2090L,1183L,330L,34L,64L,793L,3487L,7186L,8979L,6965L,3064L,669L,55L,81L,1342L,8179L,22544L,35296L,35304L,21754L,7577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210863Inst : IEnumerable<long>
{
public static readonly long[] Value=A210863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210863.Bytes);
public long this[int i]=>Value[i];

public static A210863Inst Instance=new A210863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210864
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,2L,4L,9L,9L,3L,5L,21L,30L,21L,5L,6L,41L,91L,96L,47L,8L,7L,71L,242L,358L,278L,101L,13L,8L,113L,565L,1187L,1303L,757L,209L,21L,9L,169L,1182L,3517L,5238L,4364L,1951L,422L,34L,10L,241L,2263L,9332L,18816L,21213L,13674L,4802L,833L,55L,11L,331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210864Inst : IEnumerable<long>
{
public static readonly long[] Value=A210864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210864.Bytes);
public long this[int i]=>Value[i];

public static A210864Inst Instance=new A210864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210865
{
public static readonly long[] Value={ 1L,2L,2L,6L,7L,3L,12L,21L,18L,5L,20L,61L,75L,42L,8L,30L,151L,262L,231L,93L,13L,42L,323L,829L,1025L,656L,196L,21L,56L,617L,2330L,3935L,3607L,1742L,401L,34L,72L,1081L,5815L,13578L,16849L,11723L,4380L,799L,55L,90L,1771L,13070L,42167L,69475L,65727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210865Inst : IEnumerable<long>
{
public static readonly long[] Value=A210865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210865.Bytes);
public long this[int i]=>Value[i];

public static A210865Inst Instance=new A210865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210866
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,6L,2L,1L,10L,21L,14L,3L,1L,15L,55L,65L,31L,5L,1L,21L,120L,235L,187L,65L,8L,1L,28L,231L,700L,867L,503L,134L,13L,1L,36L,406L,1792L,3332L,2914L,1279L,268L,21L,1L,45L,666L,4074L,10955L,13882L,9084L,3122L,527L,34L,1L,55L,1035L,8430L,31563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210866Inst : IEnumerable<long>
{
public static readonly long[] Value=A210866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210866.Bytes);
public long this[int i]=>Value[i];

public static A210866Inst Instance=new A210866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210867
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,2L,4L,15L,12L,3L,5L,34L,51L,28L,5L,6L,65L,170L,156L,60L,8L,7L,111L,465L,680L,438L,126L,13L,8L,175L,1092L,2465L,2411L,1145L,255L,21L,9L,260L,2282L,7623L,10968L,7805L,2854L,506L,34L,10L,369L,4356L,20608L,42735L,43440L,23509L,6813L,984L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210867Inst : IEnumerable<long>
{
public static readonly long[] Value=A210867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210867.Bytes);
public long this[int i]=>Value[i];

public static A210867Inst Instance=new A210867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210868
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,2L,2L,3L,1L,2L,5L,3L,5L,1L,3L,5L,10L,5L,8L,1L,3L,9L,10L,20L,8L,13L,1L,4L,9L,22L,20L,38L,13L,21L,1L,4L,14L,22L,51L,38L,71L,21L,34L,1L,5L,14L,40L,51L,111L,71L,130L,34L,55L,1L,5L,20L,40L,105L,111L,233L,130L,235L,55L,89L,1L,6L,20L,65L,105L,256L,233L,474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210868Inst : IEnumerable<long>
{
public static readonly long[] Value=A210868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210868.Bytes);
public long this[int i]=>Value[i];

public static A210868Inst Instance=new A210868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210869
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,3L,0L,3L,0L,5L,1L,0L,7L,0L,8L,0L,4L,0L,15L,0L,13L,1L,0L,12L,0L,30L,0L,21L,0L,5L,0L,31L,0L,58L,0L,34L,1L,0L,18L,0L,73L,0L,109L,0L,55L,0L,6L,0L,54L,0L,162L,0L,201L,0L,89L,1L,0L,25L,0L,145L,0L,344L,0L,365L,0L,144L,0L,7L,0L,85L,0L,361L,0L,707L,0L,655L,0L,233L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210869Inst : IEnumerable<long>
{
public static readonly long[] Value=A210869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210869.Bytes);
public long this[int i]=>Value[i];

public static A210869Inst Instance=new A210869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210870
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,3L,3L,1L,4L,6L,5L,5L,1L,5L,8L,12L,8L,8L,1L,6L,12L,17L,23L,13L,13L,1L,7L,15L,29L,33L,43L,21L,21L,1L,8L,20L,38L,64L,63L,79L,34L,34L,1L,9L,24L,56L,86L,136L,117L,143L,55L,55L,1L,10L,30L,70L,140L,187L,279L,214L,256L,89L,89L,1L,11L,35L,95L,180L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210870Inst : IEnumerable<long>
{
public static readonly long[] Value=A210870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210870.Bytes);
public long this[int i]=>Value[i];

public static A210870Inst Instance=new A210870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210871
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,3L,2L,5L,1L,2L,7L,3L,8L,1L,4L,5L,15L,5L,13L,1L,3L,12L,10L,30L,8L,21L,1L,5L,9L,31L,20L,58L,13L,34L,1L,4L,18L,22L,73L,38L,109L,21L,55L,1L,6L,14L,54L,51L,162L,71L,201L,34L,89L,1L,5L,25L,40L,145L,111L,344L,130L,365L,55L,144L,1L,7L,20L,85L,105L,361L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210871Inst : IEnumerable<long>
{
public static readonly long[] Value=A210871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210871.Bytes);
public long this[int i]=>Value[i];

public static A210871Inst Instance=new A210871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210872
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,1L,5L,1L,0L,1L,4L,9L,1L,0L,1L,3L,12L,14L,1L,0L,1L,3L,9L,29L,20L,1L,0L,1L,3L,8L,27L,60L,27L,1L,0L,1L,3L,8L,22L,74L,111L,35L,1L,0L,1L,3L,8L,21L,63L,181L,189L,44L,1L,0L,1L,3L,8L,21L,56L,178L,399L,302L,54L,1L,0L,1L,3L,8L,21L,55L,154L,474L,806L,459L,65L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210872Inst : IEnumerable<long>
{
public static readonly long[] Value=A210872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210872.Bytes);
public long this[int i]=>Value[i];

public static A210872Inst Instance=new A210872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210873
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,3L,4L,1L,1L,2L,8L,5L,1L,1L,2L,6L,17L,6L,1L,1L,2L,5L,18L,31L,7L,1L,1L,2L,5L,14L,47L,51L,8L,1L,1L,2L,5L,13L,41L,107L,78L,9L,1L,1L,2L,5L,13L,35L,115L,218L,113L,10L,1L,1L,2L,5L,13L,34L,98L,296L,407L,157L,11L,1L,1L,2L,5L,13L,34L,90L,276L,695L,709L,211L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210873Inst : IEnumerable<long>
{
public static readonly long[] Value=A210873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210873.Bytes);
public long this[int i]=>Value[i];

public static A210873Inst Instance=new A210873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210874
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,4L,4L,7L,7L,7L,5L,9L,10L,12L,11L,6L,11L,13L,17L,19L,18L,7L,13L,16L,22L,27L,31L,29L,8L,15L,19L,27L,35L,44L,50L,47L,9L,17L,22L,32L,43L,57L,71L,81L,76L,10L,19L,25L,37L,51L,70L,92L,115L,131L,123L,11L,21L,28L,42L,59L,83L,113L,149L,186L,212L,199L,12L,23L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210874Inst : IEnumerable<long>
{
public static readonly long[] Value=A210874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210874.Bytes);
public long this[int i]=>Value[i];

public static A210874Inst Instance=new A210874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210875
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,2L,4L,7L,5L,3L,5L,9L,10L,9L,5L,6L,11L,13L,17L,14L,8L,7L,13L,16L,22L,27L,23L,13L,8L,15L,19L,27L,35L,44L,37L,21L,9L,17L,22L,32L,43L,57L,71L,60L,34L,10L,19L,25L,37L,51L,70L,92L,115L,97L,55L,11L,21L,28L,42L,59L,83L,113L,149L,186L,157L,89L,12L,23L,31L,47L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210875Inst : IEnumerable<long>
{
public static readonly long[] Value=A210875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210875.Bytes);
public long this[int i]=>Value[i];

public static A210875Inst Instance=new A210875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210876
{
public static readonly long[] Value={ 1L,2L,1L,1L,5L,1L,1L,4L,9L,1L,1L,3L,12L,14L,1L,1L,3L,9L,29L,20L,1L,1L,3L,8L,27L,60L,27L,1L,1L,3L,8L,22L,74L,111L,35L,1L,1L,3L,8L,21L,63L,181L,189L,44L,1L,1L,3L,8L,21L,56L,178L,399L,302L,54L,1L,1L,3L,8L,21L,55L,154L,474L,806L,459L,65L,1L,1L,3L,8L,21L,55L,145L,430L,1169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210876Inst : IEnumerable<long>
{
public static readonly long[] Value=A210876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210876.Bytes);
public long this[int i]=>Value[i];

public static A210876Inst Instance=new A210876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210877
{
public static readonly long[] Value={ 1L,0L,3L,0L,3L,4L,0L,2L,8L,5L,0L,2L,6L,17L,6L,0L,2L,5L,18L,31L,7L,0L,2L,5L,14L,47L,51L,8L,0L,2L,5L,13L,41L,107L,78L,9L,0L,2L,5L,13L,35L,115L,218L,113L,10L,0L,2L,5L,13L,34L,98L,296L,407L,157L,11L,0L,2L,5L,13L,34L,90L,276L,695L,709L,211L,12L,0L,2L,5L,13L,34L,89L,244L,750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210877Inst : IEnumerable<long>
{
public static readonly long[] Value=A210877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210877.Bytes);
public long this[int i]=>Value[i];

public static A210877Inst Instance=new A210877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210878
{
public static readonly long[] Value={ 1L,0L,3L,0L,4L,7L,0L,2L,14L,17L,0L,2L,12L,46L,41L,0L,2L,8L,54L,140L,99L,0L,2L,8L,42L,212L,408L,239L,0L,2L,8L,34L,200L,758L,1154L,577L,0L,2L,8L,34L,160L,866L,2544L,3194L,1393L,0L,2L,8L,34L,144L,754L,3448L,8154L,8696L,3363L,0L,2L,8L,34L,144L,642L,3400L,12850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210878Inst : IEnumerable<long>
{
public static readonly long[] Value=A210878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210878.Bytes);
public long this[int i]=>Value[i];

public static A210878Inst Instance=new A210878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210879
{
public static readonly long[] Value={ 1L,2L,2L,1L,5L,5L,1L,5L,16L,12L,1L,3L,21L,47L,29L,1L,3L,17L,79L,134L,70L,1L,3L,13L,79L,273L,373L,169L,1L,3L,13L,63L,333L,893L,1020L,408L,1L,3L,13L,55L,297L,1291L,2805L,2751L,985L,1L,3L,13L,55L,249L,1323L,4701L,8543L,7338L,2378L,1L,3L,13L,55L,233L,1147L,5525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210879Inst : IEnumerable<long>
{
public static readonly long[] Value=A210879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210879.Bytes);
public long this[int i]=>Value[i];

public static A210879Inst Instance=new A210879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210880
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,2L,4L,7L,7L,3L,5L,9L,10L,12L,5L,6L,11L,13L,17L,19L,8L,7L,13L,16L,22L,27L,31L,13L,8L,15L,19L,27L,35L,44L,50L,21L,9L,17L,22L,32L,43L,57L,71L,81L,34L,10L,19L,25L,37L,51L,70L,92L,115L,131L,55L,11L,21L,28L,42L,59L,83L,113L,149L,186L,212L,89L,12L,23L,31L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210880Inst : IEnumerable<long>
{
public static readonly long[] Value=A210880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210880.Bytes);
public long this[int i]=>Value[i];

public static A210880Inst Instance=new A210880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210881
{
public static readonly long[] Value={ 1L,1L,3L,3L,4L,4L,4L,7L,5L,7L,5L,9L,10L,9L,11L,6L,11L,13L,17L,14L,18L,7L,13L,16L,22L,27L,23L,29L,8L,15L,19L,27L,35L,44L,37L,47L,9L,17L,22L,32L,43L,57L,71L,60L,76L,10L,19L,25L,37L,51L,70L,92L,115L,97L,123L,11L,21L,28L,42L,59L,83L,113L,149L,186L,157L,199L,12L,23L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210881Inst : IEnumerable<long>
{
public static readonly long[] Value=A210881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210881.Bytes);
public long this[int i]=>Value[i];

public static A210881Inst Instance=new A210881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210882
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,11L,10L,9L,8L,13L,12L,17L,16L,15L,14L,19L,18L,23L,22L,21L,20L,29L,28L,27L,26L,25L,24L,31L,30L,37L,36L,35L,34L,33L,32L,41L,40L,39L,38L,43L,42L,47L,46L,45L,44L,53L,52L,51L,50L,49L,48L,59L,58L,57L,56L,55L,54L,61L,60L,67L,66L,65L,64L,63L,62L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210882Inst : IEnumerable<long>
{
public static readonly long[] Value=A210882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210882.Bytes);
public long this[int i]=>Value[i];

public static A210882Inst Instance=new A210882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210883
{
public static readonly long[] Value={ 638L,3652L,4321L,7335L,8004L,11016L,14700L,18382L,22066L,25748L,29432L,33115L,37172L,40186L,40855L,43869L,44538L,47550L,51234L,54916L,58600L,62282L,65966L,69649L,73707L,76721L,77390L,80404L,81073L,84085L,87769L,91451L,95135L,98817L,102501L,106184L,110241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210883Inst : IEnumerable<long>
{
public static readonly long[] Value=A210883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210883.Bytes);
public long this[int i]=>Value[i];

public static A210883Inst Instance=new A210883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210884
{
public static readonly long[] Value={ 10011001L,10100101L,10111101L,10200201L,10211201L,10300301L,10400401L,10500501L,10600601L,10700701L,10800801L,10900901L,11011011L,11100111L,11111111L,11200211L,11211211L,11300311L,11400411L,11500511L,11600611L,11700711L,11800811L,11900911L,12011021L,12100121L,12111121L,12200221L,12211221L,12300321L,12400421L,12500521L,12600621L,12700721L,12800821L,12900921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210884Inst : IEnumerable<long>
{
public static readonly long[] Value=A210884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210884.Bytes);
public long this[int i]=>Value[i];

public static A210884Inst Instance=new A210884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210885
{
public static readonly long[] Value={ 374L,749L,1124L,3652L,4027L,4402L,4778L,7305L,7681L,8056L,10959L,11334L,11709L,14612L,14988L,15363L,18266L,18641L,19016L,21919L,22295L,22670L,25573L,25948L,26323L,29226L,29602L,29977L,32880L,33255L,33630L,37202L,37577L,37952L,40480L,40855L,41231L,44134L,44509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210885Inst : IEnumerable<long>
{
public static readonly long[] Value=A210885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210885.Bytes);
public long this[int i]=>Value[i];

public static A210885Inst Instance=new A210885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210886
{
public static readonly long[] Value={ 10011001L,20011002L,30011003L,1011010L,11011011L,21011012L,31011013L,2011020L,12011021L,22011022L,3011030L,13011031L,23011032L,4011040L,14011041L,24011042L,5011050L,15011051L,25011052L,6011060L,16011061L,26011062L,7011070L,17011071L,27011072L,8011080L,18011081L,28011082L,9011090L,19011091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210886Inst : IEnumerable<long>
{
public static readonly long[] Value=A210886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210886.Bytes);
public long this[int i]=>Value[i];

public static A210886Inst Instance=new A210886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210887
{
public static readonly long[] Value={ 619L,994L,1369L,3897L,4272L,4648L,7551L,7926L,8301L,11204L,11579L,11955L,14858L,15233L,15608L,18511L,18886L,19262L,22165L,22540L,22915L,25818L,26193L,26569L,29472L,29847L,30222L,33125L,33500L,33876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210887Inst : IEnumerable<long>
{
public static readonly long[] Value=A210887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210887.Bytes);
public long this[int i]=>Value[i];

public static A210887Inst Instance=new A210887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210888
{
public static readonly long[] Value={ 101101L,201102L,301103L,11110L,111111L,211112L,21120L,121121L,221122L,31130L,131131L,231132L,41140L,141141L,241142L,51150L,151151L,251152L,61160L,161161L,261162L,71170L,171171L,271172L,81180L,181181L,281182L,91190L,191191L,291192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210888Inst : IEnumerable<long>
{
public static readonly long[] Value=A210888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210888.Bytes);
public long this[int i]=>Value[i];

public static A210888Inst Instance=new A210888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210889
{
public static readonly long[] Value={ 315L,346L,374L,405L,435L,466L,496L,527L,558L,619L,690L,721L,749L,780L,810L,841L,871L,902L,933L,994L,1065L,1124L,1155L,1185L,1216L,1246L,1277L,1308L,1369L,3958L,3968L,3999L,4027L,4058L,4088L,4119L,4149L,4180L,4211L,4231L,4262L,4272L,4292L,4324L,4343L,4374L,4403L,4434L,4464L,4495L,4525L,4556L,4587L,4598L,4629L,4648L,4659L,4691L,4719L,4778L,4839L,4900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210889Inst : IEnumerable<long>
{
public static readonly long[] Value=A210889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210889.Bytes);
public long this[int i]=>Value[i];

public static A210889Inst Instance=new A210889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210890
{
public static readonly long[] Value={ 10101L,10201L,10301L,10401L,10501L,10601L,10701L,10801L,10901L,101101L,20102L,20202L,20302L,20402L,20502L,20602L,20702L,20802L,20902L,201102L,30103L,30303L,30403L,30503L,30603L,30703L,30803L,30903L,301103L,1111L,11111L,11211L,11311L,11411L,11511L,11611L,11711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210890Inst : IEnumerable<long>
{
public static readonly long[] Value=A210890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210890.Bytes);
public long this[int i]=>Value[i];

public static A210890Inst Instance=new A210890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210891
{
public static readonly long[] Value={ 315L,346L,374L,405L,435L,466L,496L,527L,558L,619L,690L,721L,749L,780L,810L,841L,871L,902L,933L,994L,1065L,1124L,1155L,1185L,1216L,1246L,1277L,1308L,1369L,3968L,3999L,4027L,4058L,4088L,4119L,4149L,4180L,4211L,4272L,4343L,4374L,4403L,4434L,4464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210891Inst : IEnumerable<long>
{
public static readonly long[] Value=A210891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210891.Bytes);
public long this[int i]=>Value[i];

public static A210891Inst Instance=new A210891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210892
{
public static readonly long[] Value={ 10101L,10201L,10301L,10401L,10501L,10601L,10701L,10801L,10901L,101101L,20102L,20202L,20302L,20402L,20502L,20602L,20702L,20802L,20902L,201102L,30103L,30303L,30403L,30503L,30603L,30703L,30803L,30903L,301103L,11111L,11211L,11311L,11411L,11511L,11611L,11711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210892Inst : IEnumerable<long>
{
public static readonly long[] Value=A210892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210892.Bytes);
public long this[int i]=>Value[i];

public static A210892Inst Instance=new A210892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210893
{
public static readonly long[] Value={ 10011001L,1011010L,11011011L,2011020L,12011021L,3011030L,4011040L,5011050L,6011060L,7011070L,8011080L,9011090L,10111101L,1111110L,11111111L,2111120L,12111121L,3111130L,4111140L,5111150L,6111160L,7111170L,8111180L,9111190L,10211201L,1211210L,11211211L,2211220L,12211221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210893Inst : IEnumerable<long>
{
public static readonly long[] Value=A210893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210893.Bytes);
public long this[int i]=>Value[i];

public static A210893Inst Instance=new A210893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210894
{
public static readonly long[] Value={ 589L,600L,3603L,3614L,4272L,4283L,7255L,7297L,7955L,7966L,10967L,10978L,14651L,14662L,18333L,18344L,22017L,22028L,25699L,25710L,29383L,29394L,33066L,33077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210894Inst : IEnumerable<long>
{
public static readonly long[] Value=A210894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210894.Bytes);
public long this[int i]=>Value[i];

public static A210894Inst Instance=new A210894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210895
{
public static readonly long[] Value={ 101101L,102201L,11110L,12210L,111111L,112211L,21120L,22220L,121121L,122221L,31130L,32230L,41140L,42240L,51150L,52250L,61160L,62260L,71170L,72270L,81180L,82280L,91190L,92290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210895Inst : IEnumerable<long>
{
public static readonly long[] Value=A210895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210895.Bytes);
public long this[int i]=>Value[i];

public static A210895Inst Instance=new A210895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210896
{
public static readonly BigInteger[] Value={ 1L,2L,20L,400L,16716L,1444348L,258951340L,96266852004L,74214689922928L,118642250445743920L,BigInteger.Parse("393305989512539553728"),BigInteger.Parse("2703723885515478100466476"),BigInteger.Parse("38542035415959856159523945096") };
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
public class A210896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210896Inst Instance=new A210896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210897
{
public static readonly long[] Value={ 1L,3L,35L,792L,34547L,2902490L,468761578L,145469326676L,86673425993599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210897Inst : IEnumerable<long>
{
public static readonly long[] Value=A210897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210897.Bytes);
public long this[int i]=>Value[i];

public static A210897Inst Instance=new A210897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210898
{
public static readonly BigInteger[] Value={ 1L,3L,17L,199L,3494L,98664L,4322895L,299203520L,32406437104L,5516394350943L,1472647280151852L,617087491407309762L,BigInteger.Parse("405686597596735406852") };
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
public class A210898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210898Inst Instance=new A210898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210899
{
public static readonly BigInteger[] Value={ 0L,1L,2L,36L,1044L,74379L,10881920L,3566285692L,2524146683822L,3922290803244487L,13291420623117002040UL,BigInteger.Parse("98512903545177272401383") };
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
public class A210899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210899Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210899.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210899Inst Instance=new A210899Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210900
{
public static readonly BigInteger[] Value={ 1L,5L,102L,6390L,1086041L,502575673L,633196217205L,2172041686544831L,BigInteger.Parse("20286478141700961127"),BigInteger.Parse("515885869356108286483984"),BigInteger.Parse("35719903989356689494965133243"),BigInteger.Parse("6734055759629373955660905711394302") };
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
public class A210900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210900Inst Instance=new A210900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210901
{
public static readonly BigInteger[] Value={ 1L,2L,20L,464L,22564L,2472584L,603871080L,327862785884L,395850912855384L,1063574508841830552L,BigInteger.Parse("6358546221961060404292"),BigInteger.Parse("84578736940287879637237736") };
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
public class A210901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210901Inst Instance=new A210901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210902
{
public static readonly BigInteger[] Value={ 1L,3L,17L,252L,6328L,297609L,25886499L,4205102578L,1265408306700L,707818003940086L,733897633220152333L,BigInteger.Parse("1410044723992401143016") };
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
public class A210902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210902Inst Instance=new A210902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210903
{
public static readonly BigInteger[] Value={ 0L,1L,4L,78L,3740L,449340L,133337482L,98375439948L,180233106621896L,820210662659082911L,BigInteger.Parse("9270740885407976025652"),BigInteger.Parse("260267690197125447266436984"),BigInteger.Parse("18148375825241525659505646969576") };
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
public class A210903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210903Inst Instance=new A210903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210904
{
public static readonly BigInteger[] Value={ 1L,5L,108L,7722L,1640736L,1033777404L,1931855614272L,10707730229352132L,BigInteger.Parse("176032647122454516348"),BigInteger.Parse("8583448868806218541129800"),BigInteger.Parse("1241375815868250678950006865216"),BigInteger.Parse("532497522393110319522129344363284548") };
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
public class A210904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210904Inst Instance=new A210904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210905
{
public static readonly BigInteger[] Value={ 1L,2L,24L,552L,27204L,2812168L,611509240L,279902590168L,269562004096692L,546187771866465456L,BigInteger.Parse("2328406266027562097220"),BigInteger.Parse("20883572160878878738558896"),BigInteger.Parse("394075725737300936910238275696") };
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
public class A210905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210905Inst Instance=new A210905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210906
{
public static readonly BigInteger[] Value={ 1L,3L,20L,258L,5316L,175508L,9246604L,778330944L,104490906936L,22379344947816L,7640730937406288L,4158457819686881368L,BigInteger.Parse("3606450263851909019488") };
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
public class A210906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210906Inst Instance=new A210906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210907
{
public static readonly BigInteger[] Value={ 0L,1L,2L,51L,1726L,153098L,28152650L,11567939904L,10468180657260L,20883980738963652L,BigInteger.Parse("92033224229940826385"),BigInteger.Parse("894504588855167462245204") };
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
public class A210907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210907Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210907.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210907Inst Instance=new A210907Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210908
{
public static readonly BigInteger[] Value={ 1L,5L,113L,7778L,1470886L,763792392L,1088811691432L,4261103470283404L,BigInteger.Parse("45779341641362650312"),BigInteger.Parse("1350192169041023566949256"),BigInteger.Parse("109319888150289081250021299116"),BigInteger.Parse("24298544040660143463576152678947136") };
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
public class A210908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210908Inst Instance=new A210908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210909
{
public static readonly BigInteger[] Value={ 1L,2L,24L,616L,34972L,4448872L,1271872472L,816403740024L,1175380974129748L,3797950184579806600L,BigInteger.Parse("27543816778839681854992"),BigInteger.Parse("448288796291335397449297608") };
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
public class A210909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210909Inst Instance=new A210909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210910
{
public static readonly BigInteger[] Value={ 1L,3L,23L,401L,13984L,970083L,132838634L,35924634547L,19142194392682L,20077037322761989L,BigInteger.Parse("41429745313369193161"),BigInteger.Parse("168164789977096418548306") };
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
public class A210910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210910Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210910.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210910Inst Instance=new A210910Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210911
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,168L,1416L,13897L,153126L,1893180L,25796852L,383636151L,6177688914L,106969864696L,1980478817526L,39015578535585L,814416108606566L,17947777613632128L,416233580676722424L,10129555365300697267UL,BigInteger.Parse("258028441032419619786"),BigInteger.Parse("6864011282184757297896") };
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
public class A210911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210911Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210911.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210911Inst Instance=new A210911Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210912
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2451L,29922L,420841L,6692163L,118170959L,2296688956L,48661358989L,1115587992521L,27499790373121L,725031761113038L,20351018228318061L,605726610363853513L,BigInteger.Parse("19050158234570819809"),BigInteger.Parse("631097355371645795620"),BigInteger.Parse("21961423837720097681425") };
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
public class A210912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210912Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210912.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210912Inst Instance=new A210912Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210913
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,41223L,660220L,11979669L,243048992L,5448497434L,133595966164L,3555887814602L,102064563003898L,3141580135645330L,103198691666336823L,3602725068242695657L,BigInteger.Parse("133174089439019869924"),BigInteger.Parse("5195463138498447345478"),BigInteger.Parse("213295995976349091757666") };
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
public class A210913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210913Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210913.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210913Inst Instance=new A210913Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210914
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,45906L,797994L,15774047L,348543878L,8517326911L,228090873748L,6641805913833L,208882903017855L,7054977212140236L,254641097826922363L,9780088146805724737UL,BigInteger.Parse("398202474048334638184"),BigInteger.Parse("17130262219179411169927"),BigInteger.Parse("776303072938412423933278") };
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
public class A210914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210914Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210914.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210914Inst Instance=new A210914Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210915
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,45906L,845287L,17637091L,412976516L,10702355041L,304058582059L,9396887340381L,313853270626962L,11265355519125229L,432420217726582213L,17674492093095982705UL,BigInteger.Parse("766343475354260380416"),BigInteger.Parse("35129831766609666284023"),BigInteger.Parse("1697466558811335003294745") };
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
public class A210915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210915Inst Instance=new A210915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210916
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,45906L,845287L,18182926L,440710385L,11876274391L,351546957499L,11330575607067L,394862762014644L,14792903605828298L,592835563146850723L,BigInteger.Parse("25306351970600498930"),BigInteger.Parse("1146305330627242918543"),BigInteger.Parse("54914971513967144548105"),BigInteger.Parse("2773947252964889935144249") };
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
public class A210916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210916Inst Instance=new A210916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210917
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,45906L,845287L,18182926L,447797646L,12327513326L,374460094229L,12417692352452L,445937963850159L,17230880407496706L,712587605616915013L,BigInteger.Parse("31399448829720502520"),BigInteger.Parse("1468521294946336416768"),BigInteger.Parse("72650756455913144620677"),BigInteger.Parse("3790469182850937732166657") };
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
public class A210917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210917Inst Instance=new A210917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210918
{
public static readonly BigInteger[] Value={ 1L,1L,4L,26L,243L,2992L,45906L,845287L,18182926L,447797646L,12429760889L,382432412429L,12895551865341L,472172004983602L,18636388954609376L,788226102638064075L,BigInteger.Parse("35549770035085876130"),BigInteger.Parse("1702625512220935301410"),BigInteger.Parse("86287522467158470208030"),BigInteger.Parse("4612838996164892567266399") };
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
public class A210918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210918Inst Instance=new A210918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210919
{
public static readonly BigInteger[] Value={ 1L,2L,50L,5036L,1650722L,1726180511L,5772723512117L,61704243727319597L,BigInteger.Parse("2108342605082097217766"),BigInteger.Parse("230275999931688657463304318"),BigInteger.Parse("80396959992514189225966415632361") };
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
public class A210919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210919Inst Instance=new A210919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210920
{
public static readonly long[] Value={ 1L,3L,70L,6516L,1741480L,1297416720L,2686765690144L,15449867954722880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210920Inst : IEnumerable<long>
{
public static readonly long[] Value=A210920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210920.Bytes);
public long this[int i]=>Value[i];

public static A210920Inst Instance=new A210920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210921
{
public static readonly BigInteger[] Value={ 1L,3L,39L,2107L,277902L,87883641L,66460660741L,120226326939778L,520179215730042235L,BigInteger.Parse("5383068220104980704743"),BigInteger.Parse("133236771262960489496028245") };
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
public class A210921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210921Inst Instance=new A210921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210922
{
public static readonly BigInteger[] Value={ 0L,1L,2L,49L,3312L,818235L,488196032L,845278581938L,3889846475035188L,BigInteger.Parse("49699973559580684560") };
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
public class A210922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210922Inst Instance=new A210922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210923
{
public static readonly BigInteger[] Value={ 1L,5L,166L,35207L,30211455L,99371076165L,1250065064815292L,BigInteger.Parse("60143467055359131310"),BigInteger.Parse("11066941546543240934864887"),BigInteger.Parse("7788436930452056534815427874703"),BigInteger.Parse("20963150916521213172749181596782816735") };
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
public class A210923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210923Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210923.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210923Inst Instance=new A210923Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210924
{
public static readonly BigInteger[] Value={ 1L,2L,50L,5280L,1845589L,2131393730L,8110404963737L,101713393925588269L,BigInteger.Parse("4204356938900447492681"),BigInteger.Parse("572796548087149263352167089"),BigInteger.Parse("257205150385663723399847224344969") };
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
public class A210924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210924Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210924.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210924Inst Instance=new A210924Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210925
{
public static readonly BigInteger[] Value={ 1L,3L,39L,2212L,314852L,110451021L,95121973827L,200885189935045L,1039262747697700932L,BigInteger.Parse("13162671799070468638683") };
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
public class A210925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210925Inst Instance=new A210925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210926
{
public static readonly BigInteger[] Value={ 0L,1L,4L,95L,9220L,3055073L,3000338892L,8812917082915L,76878364475257062L,BigInteger.Parse("1995945343880703817038"),BigInteger.Parse("154116672749530867319434810") };
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
public class A210926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210926Inst Instance=new A210926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210927
{
public static readonly BigInteger[] Value={ 1L,5L,172L,38444L,36567600L,139088906848L,2108407726540016L,BigInteger.Parse("127364809805575916736"),BigInteger.Parse("30660305986899859448541568"),BigInteger.Parse("29412752846682454724638291977856") };
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
public class A210927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210927Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210927.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210927Inst Instance=new A210927Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210928
{
public static readonly BigInteger[] Value={ 1L,2L,55L,5892L,2081181L,2353015360L,8533282805517L,99227545384370981L,BigInteger.Parse("3699909251614783425693"),BigInteger.Parse("442375363534050667939662012"),BigInteger.Parse("169602369911112134429648742314656") };
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
public class A210928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210928Inst Instance=new A210928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210929
{
public static readonly BigInteger[] Value={ 1L,3L,42L,2316L,320744L,106842320L,85415568160L,163885278844480L,754594332585922688L,BigInteger.Parse("8337847863812427968768"),BigInteger.Parse("221082535444417970063262208") };
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
public class A210929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210929Inst Instance=new A210929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210930
{
public static readonly BigInteger[] Value={ 0L,1L,2L,64L,4730L,1354791L,943637970L,1907539841676L,10349004212065264L,BigInteger.Parse("156102455896727660205") };
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
public class A210930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210930Inst Instance=new A210930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210931
{
public static readonly BigInteger[] Value={ 1L,5L,178L,39460L,35878251L,125478724962L,1683060156006386L,BigInteger.Parse("86575081776631287402"),BigInteger.Parse("17078491833610134896199822"),BigInteger.Parse("12920202409647854108765238718313"),BigInteger.Parse("37484549282125499262636528834124614593") };
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
public class A210931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210931Inst Instance=new A210931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210932
{
public static readonly BigInteger[] Value={ 1L,2L,55L,6136L,2300729L,2853666014L,11691775609193L,158256127017674737L,BigInteger.Parse("7077134333752159967353"),BigInteger.Parse("1045606338210715698434693227") };
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
public class A210932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210932Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210932.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210932Inst Instance=new A210932Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210933
{
public static readonly BigInteger[] Value={ 1L,3L,45L,2597L,404200L,158571061L,155381740144L,379683866415546L,2311350169900872167L,BigInteger.Parse("35031061332072915278464") };
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
public class A210933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210933Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210933.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210933Inst Instance=new A210933Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210934
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,9L,8L,9L,9L,10L,10L,21L,12L,15L,11L,11L,12L,33L,21L,12L,39L,13L,14L,13L,16L,22L,19L,13L,18L,24L,14L,18L,28L,16L,15L,25L,81L,45L,16L,34L,15L,22L,15L,99L,19L,16L,57L,17L,26L,30L,21L,16L,24L,17L,48L,20L,16L,25L,141L,52L,75L,19L,22L,22L,159L,58L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210934Inst : IEnumerable<long>
{
public static readonly long[] Value=A210934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210934.Bytes);
public long this[int i]=>Value[i];

public static A210934Inst Instance=new A210934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210935
{
public static readonly long[] Value={ 1L,4L,64L,80L,108L,270L,351L,432L,729L,768L,864L,2916L,5184L,5832L,6250L,6912L,12096L,13500L,16384L,25600L,32832L,34992L,37500L,39366L,43200L,46656L,50000L,73008L,74304L,81648L,84375L,110592L,131250L,138240L,143748L,153664L,172800L,176418L,200000L,225000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210935Inst : IEnumerable<long>
{
public static readonly long[] Value=A210935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210935.Bytes);
public long this[int i]=>Value[i];

public static A210935Inst Instance=new A210935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210936
{
public static readonly long[] Value={ 0L,2L,4L,5L,7L,7L,8L,8L,13L,11L,10L,10L,11L,12L,25L,17L,31L,12L,16L,14L,12L,18L,43L,17L,13L,14L,22L,55L,13L,15L,15L,20L,23L,28L,41L,15L,20L,14L,85L,47L,91L,15L,26L,15L,18L,19L,17L,42L,115L,26L,35L,26L,16L,17L,16L,133L,71L,16L,30L,18L,52L,77L,25L,38L,22L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210936Inst : IEnumerable<long>
{
public static readonly long[] Value=A210936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210936.Bytes);
public long this[int i]=>Value[i];

public static A210936Inst Instance=new A210936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210937
{
public static readonly long[] Value={ 4L,2L,1L,4L,7L,8L,1L,6L,1L,2L,9L,8L,8L,6L,7L,3L,0L,9L,0L,6L,2L,0L,0L,9L,1L,1L,0L,4L,1L,1L,2L,1L,3L,6L,4L,3L,1L,1L,1L,4L,6L,0L,3L,3L,5L,0L,7L,7L,6L,8L,0L,9L,0L,3L,9L,6L,8L,4L,3L,3L,7L,4L,7L,8L,7L,9L,0L,8L,7L,9L,1L,4L,5L,4L,0L,0L,2L,2L,2L,0L,4L,8L,8L,1L,6L,9L,0L,0L,8L,5L,8L,7L,0L,5L,4L,9L,6L,8L,4L,4L,7L,5L,3L,5L,8L,2L,8L,2L,4L,3L,0L,7L,7L,2L,5L,0L,5L,0L,2L,4L,2L,5L,4L,2L,5L,8L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210937Inst : IEnumerable<long>
{
public static readonly long[] Value=A210937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210937.Bytes);
public long this[int i]=>Value[i];

public static A210937Inst Instance=new A210937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210938
{
public static readonly long[] Value={ 1L,1L,19L,1L,43L,187L,1L,67L,943L,1292L,1L,91L,2275L,14104L,7106L,1L,115L,4183L,52260L,162196L,33231L,1L,139L,6667L,129584L,914550L,1531961L,137394L,1L,163L,9727L,259900L,3045224L,13015219L,12389380L,515185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210938Inst : IEnumerable<long>
{
public static readonly long[] Value=A210938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210938.Bytes);
public long this[int i]=>Value[i];

public static A210938Inst Instance=new A210938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210939
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,16L,18L,20L,22L,24L,28L,30L,32L,36L,38L,40L,42L,44L,46L,48L,52L,54L,58L,60L,62L,66L,68L,70L,72L,74L,78L,80L,82L,84L,88L,90L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,126L,128L,130L,132L,136L,138L,140L,148L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210939Inst : IEnumerable<long>
{
public static readonly long[] Value=A210939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210939.Bytes);
public long this[int i]=>Value[i];

public static A210939Inst Instance=new A210939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210940
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,22L,23L,24L,28L,29L,30L,31L,32L,36L,37L,38L,40L,41L,42L,43L,44L,46L,47L,48L,52L,53L,54L,58L,59L,60L,61L,62L,66L,67L,68L,70L,71L,72L,73L,78L,79L,80L,82L,83L,84L,88L,89L,90L,96L,97L,98L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210940Inst : IEnumerable<long>
{
public static readonly long[] Value=A210940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210940.Bytes);
public long this[int i]=>Value[i];

public static A210940Inst Instance=new A210940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210941
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,4L,3L,2L,5L,2L,2L,2L,4L,2L,3L,3L,6L,3L,2L,2L,5L,2L,4L,3L,7L,2L,2L,2L,2L,4L,2L,2L,3L,3L,2L,6L,2L,5L,3L,4L,4L,8L,3L,2L,2L,2L,5L,2L,2L,4L,3L,2L,7L,2L,3L,3L,3L,6L,3L,5L,4L,9L,2L,2L,2L,2L,2L,4L,2L,2L,2L,3L,3L,2L,2L,6L,2L,2L,5L,3L,2L,4L,4L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210941Inst : IEnumerable<long>
{
public static readonly long[] Value=A210941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210941.Bytes);
public long this[int i]=>Value[i];

public static A210941Inst Instance=new A210941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210942
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,5L,2L,2L,4L,2L,3L,6L,3L,2L,2L,3L,5L,2L,4L,7L,3L,2L,2L,2L,4L,2L,3L,6L,3L,2L,2L,5L,4L,8L,4L,3L,2L,2L,2L,2L,3L,5L,2L,4L,7L,3L,2L,2L,3L,6L,3L,5L,9L,4L,3L,3L,2L,2L,2L,2L,2L,4L,2L,3L,6L,3L,2L,2L,5L,4L,8L,4L,3L,2L,2L,2L,2L,4L,7L,3L,6L,5L,10L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210942Inst : IEnumerable<long>
{
public static readonly long[] Value=A210942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210942.Bytes);
public long this[int i]=>Value[i];

public static A210942Inst Instance=new A210942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210943
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,4L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,5L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,4L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,6L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,2L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210943Inst : IEnumerable<long>
{
public static readonly long[] Value=A210943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210943.Bytes);
public long this[int i]=>Value[i];

public static A210943Inst Instance=new A210943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210944
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,0L,11L,1L,12L,2L,13L,3L,0L,14L,4L,1L,15L,5L,2L,16L,6L,3L,17L,7L,4L,18L,8L,5L,19L,9L,6L,20L,10L,7L,21L,11L,8L,22L,12L,9L,23L,13L,10L,24L,14L,11L,25L,15L,12L,26L,16L,13L,27L,17L,14L,28L,18L,15L,29L,19L,16L,30L,20L,17L,31L,21L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210944Inst : IEnumerable<long>
{
public static readonly long[] Value=A210944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210944.Bytes);
public long this[int i]=>Value[i];

public static A210944Inst Instance=new A210944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210945
{
public static readonly long[] Value={ 1L,2L,3L,5L,1L,7L,1L,11L,3L,1L,15L,3L,1L,22L,6L,3L,1L,30L,7L,4L,1L,42L,11L,7L,3L,1L,56L,13L,9L,4L,1L,77L,20L,15L,8L,3L,1L,101L,23L,18L,10L,4L,1L,135L,33L,27L,17L,8L,3L,1L,176L,40L,34L,22L,11L,4L,1L,231L,54L,47L,33L,18L,8L,3L,1L,297L,65L,58L,42L,24L,11L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210945Inst : IEnumerable<long>
{
public static readonly long[] Value=A210945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210945.Bytes);
public long this[int i]=>Value[i];

public static A210945Inst Instance=new A210945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210946
{
public static readonly long[] Value={ 1L,3L,5L,9L,2L,12L,3L,20L,9L,2L,25L,11L,3L,38L,22L,9L,2L,49L,28L,14L,3L,69L,44L,26L,9L,2L,87L,55L,37L,14L,3L,123L,83L,62L,29L,9L,2L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210946Inst : IEnumerable<long>
{
public static readonly long[] Value=A210946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210946.Bytes);
public long this[int i]=>Value[i];

public static A210946Inst Instance=new A210946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210947
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,11L,12L,12L,16L,18L,19L,20L,19L,27L,31L,33L,34L,35L,30L,41L,47L,50L,52L,53L,54L,45L,64L,73L,79L,82L,84L,85L,86L,67L,93L,108L,116L,121L,124L,126L,127L,128L,97L,138L,159L,172L,180L,185L,188L,190L,191L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210947Inst : IEnumerable<long>
{
public static readonly long[] Value=A210947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210947.Bytes);
public long this[int i]=>Value[i];

public static A210947Inst Instance=new A210947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210948
{
public static readonly long[] Value={ 1L,2L,4L,4L,6L,9L,7L,13L,16L,20L,12L,20L,26L,30L,35L,19L,35L,47L,55L,60L,66L,30L,52L,70L,82L,92L,98L,105L,45L,83L,110L,134L,149L,161L,168L,176L,67L,119L,164L,196L,221L,239L,253L,261L,270L,97L,179L,242L,294L,334L,364L,385L,401L,410L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210948Inst : IEnumerable<long>
{
public static readonly long[] Value=A210948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210948.Bytes);
public long this[int i]=>Value[i];

public static A210948Inst Instance=new A210948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210949
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,309L,4383L,78121L,1684706L,42801222L,1255919755L,41918624013L,1572257236114L,65619165625383L,3022617826829288L,152615633802149416L,8397224009015443509L,BigInteger.Parse("500957609480739613321"),BigInteger.Parse("32261529179806961067634"),BigInteger.Parse("2234133327582388824135291") };
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
public class A210949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210949Inst Instance=new A210949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210950
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,5L,1L,2L,4L,6L,7L,1L,2L,4L,7L,10L,11L,1L,2L,4L,7L,11L,14L,15L,1L,2L,4L,7L,12L,17L,21L,22L,1L,2L,4L,7L,12L,18L,25L,29L,30L,1L,2L,4L,7L,12L,19L,28L,36L,41L,42L,1L,2L,4L,7L,12L,19L,29L,40L,50L,55L,56L,1L,2L,4L,7L,12L,19L,30L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210950Inst : IEnumerable<long>
{
public static readonly long[] Value=A210950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210950.Bytes);
public long this[int i]=>Value[i];

public static A210950Inst Instance=new A210950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210951
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,0L,0L,1L,5L,0L,0L,0L,1L,7L,0L,0L,0L,1L,3L,11L,0L,0L,0L,0L,1L,3L,15L,0L,0L,0L,0L,1L,3L,6L,22L,0L,0L,0L,0L,0L,1L,4L,7L,30L,0L,0L,0L,0L,0L,1L,3L,7L,11L,42L,0L,0L,0L,0L,0L,0L,1L,4L,9L,13L,56L,0L,0L,0L,0L,0L,0L,1L,3L,8L,15L,20L,77L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210951Inst : IEnumerable<long>
{
public static readonly long[] Value=A210951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210951.Bytes);
public long this[int i]=>Value[i];

public static A210951Inst Instance=new A210951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210952
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,5L,1L,3L,7L,9L,1L,3L,7L,12L,12L,1L,3L,7L,14L,21L,20L,1L,3L,7L,14L,24L,31L,25L,1L,3L,7L,14L,26L,40L,47L,38L,1L,3L,7L,14L,26L,43L,61L,66L,49L,1L,3L,7L,14L,26L,45L,70L,92L,93L,69L,1L,3L,7L,14L,26L,45L,73L,106L,130L,124L,87L,1L,3L,7L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210952Inst : IEnumerable<long>
{
public static readonly long[] Value=A210952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210952.Bytes);
public long this[int i]=>Value[i];

public static A210952Inst Instance=new A210952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210953
{
public static readonly long[] Value={ 1L,0L,3L,0L,0L,5L,0L,0L,2L,9L,0L,0L,0L,3L,12L,0L,0L,0L,2L,9L,20L,0L,0L,0L,0L,3L,11L,25L,0L,0L,0L,0L,2L,9L,22L,38L,0L,0L,0L,0L,0L,3L,14L,28L,49L,0L,0L,0L,0L,0L,2L,9L,26L,44L,69L,0L,0L,0L,0L,0L,0L,3L,14L,37L,55L,87L,0L,0L,0L,0L,0L,0L,2L,9L,29L,62L,83L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210953Inst : IEnumerable<long>
{
public static readonly long[] Value=A210953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210953.Bytes);
public long this[int i]=>Value[i];

public static A210953Inst Instance=new A210953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210954
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,3L,1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,1L,-1L,4L,2L,-1L,5L,3L,-1L,7L,4L,-1L,10L,4L,-2L,12L,4L,-3L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,4L,-4L,13L,5L,-4L,14L,7L,-4L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210954Inst : IEnumerable<long>
{
public static readonly long[] Value=A210954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210954.Bytes);
public long this[int i]=>Value[i];

public static A210954Inst Instance=new A210954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210955
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,3L,5L,5L,6L,5L,6L,7L,7L,8L,7L,11L,13L,14L,14L,15L,11L,14L,16L,17L,18L,18L,19L,15L,23L,26L,29L,30L,31L,31L,32L,22L,29L,35L,37L,39L,40L,41L,41L,42L,30L,45L,51L,56L,59L,61L,62L,63L,63L,64L,42L,57L,67L,72L,76L,78L,80L,81L,82L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210955Inst : IEnumerable<long>
{
public static readonly long[] Value=A210955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210955.Bytes);
public long this[int i]=>Value[i];

public static A210955Inst Instance=new A210955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210956
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,5L,3L,7L,7L,11L,5L,7L,10L,10L,15L,7L,15L,21L,25L,25L,31L,11L,17L,23L,27L,32L,32L,39L,15L,31L,40L,52L,57L,63L,63L,71L,22L,36L,54L,62L,72L,78L,85L,85L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210956Inst : IEnumerable<long>
{
public static readonly long[] Value=A210956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210956.Bytes);
public long this[int i]=>Value[i];

public static A210956Inst Instance=new A210956Inst();

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