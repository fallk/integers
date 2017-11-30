using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257882
{
public static readonly long[] Value={ 2L,1L,4L,5L,3L,7L,12L,9L,15L,11L,6L,13L,21L,14L,8L,17L,27L,19L,10L,22L,33L,23L,36L,25L,39L,26L,41L,29L,45L,31L,16L,34L,18L,35L,54L,37L,57L,38L,20L,42L,63L,43L,66L,44L,68L,47L,24L,49L,75L,51L,78L,53L,81L,55L,28L,58L,30L,59L,90L,61L,93L,62L,32L,65L,99L,67L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257882Inst : IEnumerable<long>
{
public static readonly long[] Value=A257882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257882.Bytes);
public long this[int i]=>Value[i];

public static A257882Inst Instance=new A257882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257883
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,9L,4L,10L,6L,11L,8L,15L,7L,16L,14L,22L,12L,23L,17L,27L,13L,25L,18L,31L,19L,33L,20L,35L,24L,40L,21L,38L,29L,47L,26L,45L,28L,48L,30L,51L,36L,58L,32L,55L,39L,63L,34L,59L,37L,64L,41L,67L,42L,70L,43L,72L,44L,74L,50L,81L,46L,78L,111L,49L,83L,52L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257883Inst : IEnumerable<long>
{
public static readonly long[] Value=A257883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257883.Bytes);
public long this[int i]=>Value[i];

public static A257883Inst Instance=new A257883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257884
{
public static readonly long[] Value={ 0L,2L,1L,4L,8L,3L,9L,5L,10L,7L,14L,6L,15L,13L,21L,11L,22L,16L,26L,12L,24L,17L,30L,18L,32L,19L,34L,23L,39L,20L,37L,28L,46L,25L,44L,27L,47L,29L,50L,35L,57L,31L,54L,38L,62L,33L,58L,36L,63L,40L,66L,41L,69L,42L,71L,43L,73L,49L,80L,45L,77L,110L,48L,82L,51L,86L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257884Inst : IEnumerable<long>
{
public static readonly long[] Value=A257884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257884.Bytes);
public long this[int i]=>Value[i];

public static A257884Inst Instance=new A257884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257885
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,3L,8L,7L,13L,5L,12L,20L,9L,18L,11L,21L,15L,10L,22L,33L,14L,27L,17L,31L,16L,32L,19L,34L,25L,42L,24L,43L,23L,41L,29L,49L,26L,47L,30L,52L,28L,51L,35L,59L,37L,62L,36L,63L,38L,64L,50L,46L,74L,39L,68L,40L,70L,101L,44L,76L,45L,78L,48L,82L,53L,88L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257885Inst : IEnumerable<long>
{
public static readonly long[] Value=A257885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257885.Bytes);
public long this[int i]=>Value[i];

public static A257885Inst Instance=new A257885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257886
{
public static readonly long[] Value={ 2L,1L,2L,1L,1L,1L,1L,13L,1L,1L,29L,1L,1L,37L,29L,17L,31L,71L,71L,37L,23L,1L,37L,1L,41L,41L,31L,31L,59L,31L,41L,41L,41L,41L,41L,37L,41L,193L,83L,41L,53L,67L,149L,97L,59L,73L,113L,107L,137L,59L,137L,67L,101L,83L,73L,101L,241L,71L,73L,79L,83L,227L,199L,223L,127L,83L,83L,181L,227L,149L,103L,1L,587L,179L,229L,167L,127L,163L,109L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257886Inst : IEnumerable<long>
{
public static readonly long[] Value=A257886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257886.Bytes);
public long this[int i]=>Value[i];

public static A257886Inst Instance=new A257886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257887
{
public static readonly BigInteger[] Value={ 1L,5L,34L,273L,2436L,23391L,237090L,2505228L,27360612L,306956091L,3521389998L,41164654020L,489017000736L,5890746106977L,71829149873286L,885296835708778L,11015753148497480L,138241674405266782L,1748203287998505712L,BigInteger.Parse("22261537862360050040"),BigInteger.Parse("285268915333307553016") };
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
public class A257887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257887Inst Instance=new A257887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257888
{
public static readonly long[] Value={ 4L,36L,224L,1200L,5940L,28028L,128128L,572832L,2519400L,10943240L,47070144L,200880160L,851809140L,3592795500L,15085939200L,63102895680L,263083395960L,1093683448440L,4535210472000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257888Inst : IEnumerable<long>
{
public static readonly long[] Value=A257888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257888.Bytes);
public long this[int i]=>Value[i];

public static A257888Inst Instance=new A257888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257889
{
public static readonly long[] Value={ 1L,1L,2L,5L,10L,28L,70L,170L,340L,960L,2688L,7308L,18270L,48440L,117640L,285600L,571200L,1543600L,4358400L,12038400L,33707520L,92875776L,252506016L,677656224L,1694140560L,4596220440L,12186147680L,32083749600L,77917677600L,203473437920L,493981756800L,1217092396800L,2434184793600L,6357547392000L,17180514976000L,46002675920000L,129889908480000L,349123704576000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257889Inst : IEnumerable<long>
{
public static readonly long[] Value=A257889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257889.Bytes);
public long this[int i]=>Value[i];

public static A257889Inst Instance=new A257889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257890
{
public static readonly long[] Value={ 3L,12L,34L,80L,166L,314L,553L,920L,1461L,2232L,3300L,4744L,6656L,9142L,12323L,16336L,21335L,27492L,34998L,44064L,54922L,67826L,83053L,100904L,121705L,145808L,173592L,205464L,241860L,283246L,330119L,383008L,442475L,509116L,583562L,666480L,758574L,860586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257890Inst : IEnumerable<long>
{
public static readonly long[] Value=A257890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257890.Bytes);
public long this[int i]=>Value[i];

public static A257890Inst Instance=new A257890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257891
{
public static readonly long[] Value={ 30L,105L,210L,385L,1001L,1155L,2310L,2431L,4199L,5005L,7429L,12673L,15015L,17017L,20677L,30030L,33263L,46189L,47027L,65231L,82861L,85085L,96577L,107113L,146969L,190747L,215441L,241133L,255255L,290177L,323323L,347261L,392863L,409457L,478661L,510510L,583573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257891Inst : IEnumerable<long>
{
public static readonly long[] Value=A257891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257891.Bytes);
public long this[int i]=>Value[i];

public static A257891Inst Instance=new A257891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257892
{
public static readonly long[] Value={ 332L,878L,1999L,3949L,4524L,5953L,6576L,8676L,10068L,11840L,17107L,17208L,19034L,19525L,46771L,46828L,52767L,54567L,54927L,56879L,58695L,61748L,65926L,77168L,77676L,79722L,92775L,92823L,96099L,101607L,111007L,136141L,160095L,160418L,173404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257892Inst : IEnumerable<long>
{
public static readonly long[] Value=A257892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257892.Bytes);
public long this[int i]=>Value[i];

public static A257892Inst Instance=new A257892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257893
{
public static readonly long[] Value={ 3076521984L,3718250496L,6398410752L,1384906752L,2769813504L,2845310976L,1578369024L,1074659328L,4761059328L,9805234176L,2507931648L,1294073856L,5619843072L,6591873024L,9073852416L,9574023168L,1208549376L,1249837056L,6103498752L,1542389760L,1683947520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257893Inst : IEnumerable<long>
{
public static readonly long[] Value=A257893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257893.Bytes);
public long this[int i]=>Value[i];

public static A257893Inst Instance=new A257893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257894
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,11L,7L,1L,1L,25L,85L,15L,1L,1L,137L,415L,575L,31L,1L,1L,49L,12019L,5845L,3661L,63L,1L,1L,363L,13489L,874853L,76111L,22631L,127L,1L,1L,761L,726301L,336581L,58067611L,952525L,137845L,255L,1L,1L,7129L,3144919L,129973303L,68165041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257894Inst : IEnumerable<long>
{
public static readonly long[] Value=A257894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257894.Bytes);
public long this[int i]=>Value[i];

public static A257894Inst Instance=new A257894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257895
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,6L,4L,1L,1L,12L,36L,8L,1L,1L,60L,144L,216L,16L,1L,1L,20L,3600L,1728L,1296L,32L,1L,1L,140L,3600L,216000L,20736L,7776L,64L,1L,1L,280L,176400L,72000L,12960000L,248832L,46656L,128L,1L,1L,2520L,705600L,24696000L,12960000L,777600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257895Inst : IEnumerable<long>
{
public static readonly long[] Value=A257895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257895.Bytes);
public long this[int i]=>Value[i];

public static A257895Inst Instance=new A257895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257896
{
public static readonly long[] Value={ 3L,0L,6L,1L,0L,4L,2L,5L,3L,5L,8L,2L,1L,4L,6L,2L,4L,9L,4L,7L,5L,4L,8L,4L,2L,9L,4L,8L,1L,2L,7L,6L,2L,2L,0L,5L,7L,9L,8L,9L,0L,7L,3L,9L,5L,9L,9L,7L,3L,4L,8L,2L,3L,4L,6L,2L,1L,6L,6L,9L,4L,5L,7L,2L,3L,0L,5L,0L,7L,3L,7L,6L,1L,5L,9L,9L,7L,0L,9L,7L,3L,5L,3L,6L,6L,6L,7L,2L,3L,7L,5L,7L,6L,5L,7L,9L,0L,2L,4L,0L,5L,4L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257896Inst : IEnumerable<long>
{
public static readonly long[] Value=A257896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257896.Bytes);
public long this[int i]=>Value[i];

public static A257896Inst Instance=new A257896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257897
{
public static readonly long[] Value={ 63L,103L,128L,147L,155L,212L,272L,292L,351L,452L,486L,497L,525L,527L,537L,584L,607L,624L,648L,729L,979L,999L,1024L,1296L,1323L,1359L,1533L,1541L,1575L,1809L,1872L,2048L,2050L,2107L,2187L,2448L,2512L,2537L,2564L,2763L,2793L,2886L,3072L,3357L,3927L,4096L,4263L,4284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257897Inst : IEnumerable<long>
{
public static readonly long[] Value=A257897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257897.Bytes);
public long this[int i]=>Value[i];

public static A257897Inst Instance=new A257897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257898
{
public static readonly long[] Value={ 1L,1L,4L,7L,7L,9L,6L,8L,0L,1L,3L,9L,8L,7L,0L,7L,5L,9L,1L,1L,5L,0L,7L,7L,8L,8L,9L,6L,7L,5L,6L,7L,9L,6L,1L,9L,1L,6L,6L,5L,1L,8L,8L,6L,8L,4L,3L,2L,8L,7L,6L,5L,2L,3L,0L,3L,2L,3L,1L,4L,7L,6L,5L,5L,4L,6L,8L,5L,6L,2L,1L,0L,6L,1L,4L,7L,4L,7L,0L,4L,4L,8L,9L,6L,5L,5L,8L,2L,4L,0L,2L,2L,1L,2L,7L,6L,5L,8L,9L,3L,1L,6L,1L,7L,7L,5L,5L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257898Inst : IEnumerable<long>
{
public static readonly long[] Value=A257898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257898.Bytes);
public long this[int i]=>Value[i];

public static A257898Inst Instance=new A257898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257899
{
public static readonly long[] Value={ 7246198035L,3410256897L,5361708249L,5902183746L,6820513794L,8145396207L,8269753401L,9145036728L,9537240186L,1257389406L,1359426078L,4379605281L,1742063598L,6185973240L,2081654397L,2095471863L,6472951380L,2170936485L,2304859617L,2415930786L,2419650873L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257899Inst : IEnumerable<long>
{
public static readonly long[] Value=A257899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257899.Bytes);
public long this[int i]=>Value[i];

public static A257899Inst Instance=new A257899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257900
{
public static readonly long[] Value={ 1L,-1L,0L,-1L,2L,0L,0L,-1L,2L,-2L,0L,0L,2L,0L,0L,-1L,2L,-2L,0L,-2L,0L,0L,0L,0L,3L,-2L,0L,0L,2L,0L,0L,-1L,0L,-2L,0L,-2L,2L,0L,0L,-2L,2L,0L,0L,0L,4L,0L,0L,0L,1L,-3L,0L,-2L,2L,0L,0L,0L,0L,-2L,0L,0L,2L,0L,0L,-1L,4L,0L,0L,-2L,0L,0L,0L,-2L,2L,-2L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257900Inst : IEnumerable<long>
{
public static readonly long[] Value=A257900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257900.Bytes);
public long this[int i]=>Value[i];

public static A257900Inst Instance=new A257900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257901
{
public static readonly long[] Value={ 1304296875L,1342968750L,1437890625L,1824609375L,9123046875L,1923046875L,3104296875L,3142968750L,3649218750L,4137890625L,4862109375L,1034296875L,1269843750L,6349218750L,1284609375L,1293046875L,1347890625L,1432968750L,8124609375L,1629843750L,8462109375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257901Inst : IEnumerable<long>
{
public static readonly long[] Value=A257901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257901.Bytes);
public long this[int i]=>Value[i];

public static A257901Inst Instance=new A257901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257902
{
public static readonly long[] Value={ 2L,1L,3L,-2L,4L,-3L,5L,-1L,6L,-8L,7L,8L,-11L,9L,-7L,10L,-6L,-5L,12L,11L,-19L,13L,-10L,14L,-15L,16L,-13L,15L,-9L,17L,-18L,19L,-20L,18L,-12L,20L,-23L,21L,-17L,22L,-24L,23L,-16L,24L,-22L,25L,-26L,27L,-25L,26L,-14L,-4L,28L,-35L,29L,-28L,30L,31L,-57L,32L,-31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257902Inst : IEnumerable<long>
{
public static readonly long[] Value=A257902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257902.Bytes);
public long this[int i]=>Value[i];

public static A257902Inst Instance=new A257902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257903
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,9L,5L,11L,8L,15L,7L,16L,10L,18L,13L,23L,12L,24L,14L,25L,38L,17L,31L,19L,34L,20L,36L,21L,39L,22L,41L,28L,45L,26L,46L,30L,51L,27L,49L,29L,52L,43L,67L,32L,57L,35L,61L,33L,60L,37L,65L,40L,69L,42L,72L,54L,47L,78L,44L,76L,50L,83L,53L,87L,48L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257903Inst : IEnumerable<long>
{
public static readonly long[] Value=A257903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257903.Bytes);
public long this[int i]=>Value[i];

public static A257903Inst Instance=new A257903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257904
{
public static readonly long[] Value={ 3L,1L,2L,-1L,4L,-2L,5L,-4L,6L,-3L,7L,-8L,9L,-6L,8L,-5L,10L,-11L,12L,-10L,11L,13L,-21L,14L,-12L,15L,-14L,16L,-15L,18L,-17L,19L,-13L,17L,-19L,20L,-16L,21L,-24L,22L,-20L,23L,-9L,24L,-35L,25L,-22L,26L,-28L,27L,-23L,28L,-25L,29L,-27L,30L,-18L,-7L,31L,-34L,32L,-26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257904Inst : IEnumerable<long>
{
public static readonly long[] Value=A257904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257904.Bytes);
public long this[int i]=>Value[i];

public static A257904Inst Instance=new A257904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257905
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,11L,4L,9L,6L,13L,7L,15L,10L,8L,17L,35L,12L,25L,14L,29L,16L,33L,18L,37L,19L,39L,20L,41L,21L,43L,22L,45L,23L,47L,30L,26L,53L,24L,49L,40L,28L,57L,27L,55L,31L,63L,32L,65L,38L,42L,34L,69L,36L,73L,48L,97L,44L,89L,46L,93L,51L,103L,52L,105L,50L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257905Inst : IEnumerable<long>
{
public static readonly long[] Value=A257905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257905.Bytes);
public long this[int i]=>Value[i];

public static A257905Inst Instance=new A257905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257906
{
public static readonly long[] Value={ 0L,2L,5L,3L,7L,4L,9L,8L,15L,6L,14L,10L,19L,11L,21L,16L,31L,12L,23L,13L,25L,18L,35L,17L,33L,20L,39L,22L,43L,27L,53L,24L,47L,26L,51L,28L,55L,29L,57L,30L,59L,34L,67L,32L,63L,41L,81L,36L,71L,37L,73L,40L,79L,38L,75L,44L,87L,45L,89L,42L,83L,46L,91L,48L,95L,49L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257906Inst : IEnumerable<long>
{
public static readonly long[] Value=A257906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257906.Bytes);
public long this[int i]=>Value[i];

public static A257906Inst Instance=new A257906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257907
{
public static readonly long[] Value={ 1L,2L,3L,-2L,4L,-3L,5L,-1L,7L,-9L,8L,-4L,9L,-8L,10L,-5L,15L,-19L,11L,-10L,12L,-7L,17L,-18L,16L,-13L,19L,-17L,21L,-16L,26L,-29L,23L,-21L,25L,-23L,27L,-26L,28L,-27L,29L,-25L,33L,-35L,31L,-22L,40L,-45L,35L,-34L,36L,-33L,39L,-41L,37L,-31L,43L,-42L,44L,-47L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257907Inst : IEnumerable<long>
{
public static readonly long[] Value=A257907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257907.Bytes);
public long this[int i]=>Value[i];

public static A257907Inst Instance=new A257907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257908
{
public static readonly long[] Value={ 0L,1L,4L,2L,6L,3L,8L,7L,15L,5L,11L,23L,9L,19L,10L,21L,13L,27L,12L,25L,14L,29L,16L,33L,17L,35L,18L,37L,30L,24L,20L,41L,22L,45L,40L,28L,57L,26L,53L,31L,63L,34L,69L,32L,65L,38L,77L,36L,73L,39L,79L,43L,87L,42L,85L,46L,93L,44L,89L,47L,95L,48L,97L,49L,99L,55L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257908Inst : IEnumerable<long>
{
public static readonly long[] Value=A257908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257908.Bytes);
public long this[int i]=>Value[i];

public static A257908Inst Instance=new A257908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257909
{
public static readonly long[] Value={ 2L,1L,3L,-2L,4L,-3L,5L,-1L,8L,-10L,6L,12L,-14L,10L,-9L,11L,-8L,14L,-15L,13L,-11L,15L,-13L,17L,-16L,18L,-17L,19L,-7L,-6L,-4L,21L,-19L,23L,-5L,-12L,29L,-31L,27L,-22L,32L,-29L,35L,-37L,33L,-27L,39L,-41L,37L,-34L,40L,-36L,44L,-45L,43L,-39L,47L,-49L,45L,-42L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257909Inst : IEnumerable<long>
{
public static readonly long[] Value=A257909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257909.Bytes);
public long this[int i]=>Value[i];

public static A257909Inst Instance=new A257909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257910
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,4L,9L,5L,11L,8L,17L,7L,15L,10L,21L,12L,25L,13L,27L,14L,29L,18L,37L,16L,33L,19L,39L,20L,41L,23L,47L,22L,45L,28L,57L,24L,49L,26L,53L,31L,63L,32L,65L,30L,61L,34L,69L,35L,71L,42L,36L,73L,43L,87L,38L,77L,40L,81L,55L,48L,97L,44L,89L,46L,93L,51L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257910Inst : IEnumerable<long>
{
public static readonly long[] Value=A257910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257910.Bytes);
public long this[int i]=>Value[i];

public static A257910Inst Instance=new A257910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257911
{
public static readonly long[] Value={ 2L,1L,4L,5L,3L,7L,12L,6L,13L,8L,14L,10L,18L,9L,19L,11L,20L,17L,28L,15L,27L,16L,29L,22L,36L,21L,37L,23L,38L,26L,43L,24L,42L,25L,44L,34L,54L,30L,51L,31L,53L,32L,55L,33L,57L,39L,64L,35L,61L,45L,72L,40L,68L,41L,70L,47L,77L,46L,78L,48L,79L,112L,49L,83L,50L,85L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257911Inst : IEnumerable<long>
{
public static readonly long[] Value=A257911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257911.Bytes);
public long this[int i]=>Value[i];

public static A257911Inst Instance=new A257911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257912
{
public static readonly long[] Value={ 2L,-1L,3L,1L,-2L,4L,5L,-6L,7L,-5L,6L,-4L,8L,-9L,10L,-8L,9L,-3L,11L,-13L,12L,-11L,13L,-7L,14L,-15L,16L,-14L,15L,-12L,17L,-19L,18L,-17L,19L,-10L,20L,-24L,21L,-20L,22L,-21L,23L,-22L,24L,-18L,25L,-29L,26L,-16L,27L,-32L,28L,-27L,29L,-23L,30L,-31L,32L,-30L,31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257912Inst : IEnumerable<long>
{
public static readonly long[] Value=A257912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257912.Bytes);
public long this[int i]=>Value[i];

public static A257912Inst Instance=new A257912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257913
{
public static readonly long[] Value={ 2845310976L,1379524608L,1745960832L,6398410752L,3076521984L,5892341760L,2305179648L,3718250496L,1578369024L,9145036728L,5392687104L,1356709824L,1607952384L,3215904768L,1485029376L,5638470912L,5619843072L,6185973240L,5234098176L,7246198035L,1072963584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257913Inst : IEnumerable<long>
{
public static readonly long[] Value=A257913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257913.Bytes);
public long this[int i]=>Value[i];

public static A257913Inst Instance=new A257913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257914
{
public static readonly long[] Value={ 3076521984L,1342968750L,3718250496L,6398410752L,1304296875L,1437890625L,3142968750L,1824609375L,3649218750L,9123046875L,1542389760L,1923046875L,1683947520L,1384906752L,2769813504L,2845310976L,1578369024L,3104296875L,1269843750L,6349218750L,1074659328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257914Inst : IEnumerable<long>
{
public static readonly long[] Value=A257914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257914.Bytes);
public long this[int i]=>Value[i];

public static A257914Inst Instance=new A257914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257915
{
public static readonly long[] Value={ 3L,1L,2L,-1L,4L,-2L,5L,-4L,6L,-3L,7L,-5L,8L,-6L,9L,-7L,10L,-8L,-9L,12L,11L,-10L,13L,-11L,14L,-13L,15L,-12L,16L,-14L,-15L,18L,17L,-16L,19L,-17L,20L,-19L,-18L,22L,21L,-20L,23L,-22L,24L,-21L,25L,-23L,26L,-25L,27L,-24L,28L,-26L,-27L,30L,-28L,29L,31L,-29L,32L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257915Inst : IEnumerable<long>
{
public static readonly long[] Value=A257915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257915.Bytes);
public long this[int i]=>Value[i];

public static A257915Inst Instance=new A257915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257916
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,3350529L,33640210792449L,BigInteger.Parse("2852374425137128275969"),BigInteger.Parse("46730819857678988884581779099803448292025618771438557470916609") };
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
public class A257916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257916Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257916.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257916Inst Instance=new A257916Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257917
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,3349888L,33640210518272L,BigInteger.Parse("2852314775548000778752"),BigInteger.Parse("46730819857678988884581779099803448292025618770199631109363712") };
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
public class A257917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257917Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257917.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257917Inst Instance=new A257917Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257918
{
public static readonly long[] Value={ 2L,-1L,3L,1L,-2L,4L,5L,-3L,6L,-4L,-5L,7L,8L,-7L,-6L,9L,10L,-8L,-9L,12L,11L,-10L,13L,-11L,14L,-13L,15L,-12L,16L,-14L,-15L,18L,-16L,17L,19L,-17L,20L,-19L,-18L,22L,21L,-20L,23L,-22L,24L,-21L,-23L,25L,26L,-24L,27L,-25L,28L,-26L,-27L,30L,-28L,29L,31L,-29L,32L,-31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257918Inst : IEnumerable<long>
{
public static readonly long[] Value=A257918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257918.Bytes);
public long this[int i]=>Value[i];

public static A257918Inst Instance=new A257918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257919
{
public static readonly BigInteger[] Value={ 7L,304L,9958L,288280L,7973053L,217032088L,5875893676L,158794026640L,4288744989139L,115807878426592L,3126918614998354L,84427755760664680L,2279557984193621065L,BigInteger.Parse("61548142781949118216"),BigInteger.Parse("1661800549993751359192"),BigInteger.Parse("44868621103769828836000"),BigInteger.Parse("1211452826087259054393631") };
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
public class A257919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257919Inst Instance=new A257919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257920
{
public static readonly long[] Value={ 1L,2L,0L,1L,4L,0L,0L,2L,0L,3L,2L,0L,2L,2L,0L,0L,2L,0L,3L,4L,0L,0L,2L,0L,0L,4L,0L,2L,2L,0L,1L,2L,0L,0L,6L,0L,2L,0L,0L,4L,0L,0L,0L,2L,0L,3L,4L,0L,0L,4L,0L,0L,2L,0L,4L,2L,0L,0L,2L,0L,0L,2L,0L,1L,4L,0L,2L,6L,0L,0L,2L,0L,2L,2L,0L,0L,0L,0L,0L,4L,0L,4L,2L,0L,3L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257920Inst : IEnumerable<long>
{
public static readonly long[] Value=A257920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257920.Bytes);
public long this[int i]=>Value[i];

public static A257920Inst Instance=new A257920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257921
{
public static readonly long[] Value={ 1L,-2L,2L,-2L,0L,0L,1L,-2L,4L,0L,0L,0L,0L,-4L,2L,-2L,0L,0L,3L,-2L,2L,-2L,0L,0L,2L,-2L,2L,0L,0L,0L,0L,-2L,2L,-2L,0L,0L,3L,-2L,4L,-2L,0L,0L,0L,-6L,2L,0L,0L,0L,0L,-2L,4L,0L,0L,0L,2L,-2L,2L,-4L,0L,0L,1L,0L,2L,0L,0L,0L,0L,-2L,6L,-2L,0L,0L,2L,-4L,0L,-2L,0L,0L,4L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257921Inst : IEnumerable<long>
{
public static readonly long[] Value=A257921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257921.Bytes);
public long this[int i]=>Value[i];

public static A257921Inst Instance=new A257921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257922
{
public static readonly long[] Value={ 4L,522L,1932L,5100L,6132L,6552L,8220L,18312L,18540L,22110L,29568L,45342L,70488L,70950L,92220L,105360L,109662L,114600L,116532L,117192L,123552L,128982L,131838L,132762L,136710L,148302L,149160L,166848L,177012L,183438L,197340L,206280L,233550L,235008L,257868L,272808L,273900L,276780L,279708L,286590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257922Inst : IEnumerable<long>
{
public static readonly long[] Value=A257922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257922.Bytes);
public long this[int i]=>Value[i];

public static A257922Inst Instance=new A257922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257923
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,6L,7L,7L,7L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257923Inst : IEnumerable<long>
{
public static readonly long[] Value=A257923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257923.Bytes);
public long this[int i]=>Value[i];

public static A257923Inst Instance=new A257923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257924
{
public static readonly long[] Value={ 3L,7L,31L,89L,199L,8009L,11551L,20129L,23549L,38609L,47501L,67231L,96221L,97001L,103409L,111871L,120473L,131071L,143261L,146681L,168869L,174761L,183091L,193951L,196181L,208279L,208961L,219727L,229769L,237691L,238519L,240641L,247759L,270271L,290249L,291101L,293201L,337039L,340577L,352831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257924Inst : IEnumerable<long>
{
public static readonly long[] Value=A257924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257924.Bytes);
public long this[int i]=>Value[i];

public static A257924Inst Instance=new A257924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257925
{
public static readonly long[] Value={ 1L,15L,77L,247L,609L,1271L,2365L,4047L,6497L,9919L,14541L,20615L,28417L,38247L,50429L,65311L,83265L,104687L,129997L,159639L,194081L,233815L,279357L,331247L,390049L,456351L,530765L,613927L,706497L,809159L,922621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257925Inst : IEnumerable<long>
{
public static readonly long[] Value=A257925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257925.Bytes);
public long this[int i]=>Value[i];

public static A257925Inst Instance=new A257925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257926
{
public static readonly long[] Value={ 6L,4L,10L,8L,451L,426L,622L,175L,1424L,500L,33L,703L,1761L,4428L,1563L,959L,8147L,7055L,5948L,250L,7517L,12706L,8405L,2948L,2610L,1949L,10424L,2214L,6722L,1963L,3335L,16382L,15687L,17591L,15073L,7818L,32202L,31169L,2248L,14899L,69955L,7580L,2393L,39295L,42352L,5884L,9367L,3630L,14090L,1305L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257926Inst : IEnumerable<long>
{
public static readonly long[] Value=A257926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257926.Bytes);
public long this[int i]=>Value[i];

public static A257926Inst Instance=new A257926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257927
{
public static readonly long[] Value={ 0L,3L,0L,2L,0L,0L,1L,0L,0L,0L,1L,6L,0L,0L,0L,1L,5L,6L,0L,0L,0L,1L,4L,0L,6L,0L,0L,0L,1L,3L,0L,0L,6L,0L,0L,0L,1L,2L,3L,0L,0L,6L,0L,0L,0L,1L,2L,8L,3L,0L,0L,6L,0L,0L,0L,1L,2L,5L,5L,3L,0L,0L,6L,0L,0L,0L,1L,2L,2L,0L,7L,3L,0L,0L,6L,0L,0L,0L,1L,1L,0L,2L,0L,1L,3L,0L,0L,6L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257927Inst : IEnumerable<long>
{
public static readonly long[] Value=A257927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257927.Bytes);
public long this[int i]=>Value[i];

public static A257927Inst Instance=new A257927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257928
{
public static readonly long[] Value={ 13L,7L,13L,67L,19L,79L,47L,193L,107L,41L,229L,179L,383L,281L,173L,1327L,193L,701L,1429L,211L,113L,73L,1093L,83L,1447L,659L,197L,719L,331L,761L,1171L,2269L,467L,509L,863L,113L,643L,577L,563L,379L,607L,1291L,283L,3593L,2549L,881L,1523L,4663L,2657L,3583L,8807L,683L,2251L,863L,8929L,163L,6737L,2459L,4919L,6553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257928Inst : IEnumerable<long>
{
public static readonly long[] Value=A257928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257928.Bytes);
public long this[int i]=>Value[i];

public static A257928Inst Instance=new A257928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257929
{
public static readonly long[] Value={ 5L,19L,37L,139L,262880929L,1551042113L,64548518479L,1573353619909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257929Inst : IEnumerable<long>
{
public static readonly long[] Value=A257929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257929.Bytes);
public long this[int i]=>Value[i];

public static A257929Inst Instance=new A257929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257930
{
public static readonly long[] Value={ 23L,269L,1049L,1277L,8869951L,972928919L,74885169679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257930Inst : IEnumerable<long>
{
public static readonly long[] Value=A257930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257930.Bytes);
public long this[int i]=>Value[i];

public static A257930Inst Instance=new A257930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257931
{
public static readonly long[] Value={ 0L,1L,1L,0L,-2L,-1L,0L,1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,-1L,0L,1L,2L,0L,-1L,-1L,0L,1L,1L,0L,-2L,-1L,0L,1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,-1L,0L,1L,2L,0L,-1L,-1L,0L,1L,1L,0L,-2L,-1L,0L,1L,0L,0L,-1L,-1L,0L,1L,1L,0L,0L,-1L,0L,1L,2L,0L,-1L,-1L,0L,1L,1L,0L,-2L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257931Inst : IEnumerable<long>
{
public static readonly long[] Value=A257931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257931.Bytes);
public long this[int i]=>Value[i];

public static A257931Inst Instance=new A257931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257932
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,12L,22L,38L,67L,118L,207L,363L,638L,1119L,1964L,3447L,6049L,10615L,18629L,32691L,57369L,100676L,176674L,310041L,544085L,954802L,1675561L,2940405L,5160051L,9055258L,15890871L,27886534L,48937456L,85879249L,150707576L,264473359L,464118392L,814471000L,1429296968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257932Inst : IEnumerable<long>
{
public static readonly long[] Value=A257932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257932.Bytes);
public long this[int i]=>Value[i];

public static A257932Inst Instance=new A257932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257933
{
public static readonly long[] Value={ 79L,223L,439L,1087L,1223L,2399L,3023L,4759L,5927L,8647L,14159L,14639L,21023L,24023L,25919L,28559L,31327L,33487L,42023L,47087L,56167L,61007L,64007L,67079L,70223L,71287L,89399L,90599L,91807L,95479L,104327L,112223L,116279L,126023L,137639L,152879L,172223L,199807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257933Inst : IEnumerable<long>
{
public static readonly long[] Value=A257933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257933.Bytes);
public long this[int i]=>Value[i];

public static A257933Inst Instance=new A257933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257934
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,14L,26L,48L,89L,163L,300L,552L,1016L,1868L,3436L,6320L,11625L,21381L,39326L,72332L,133040L,244698L,450070L,827808L,1522577L,2800455L,5150840L,9473872L,17425168L,32049880L,58948920L,108423968L,199422769L,366795657L,674642394L,1240860820L,2282298872L,4197802086L,7720961778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257934Inst : IEnumerable<long>
{
public static readonly long[] Value=A257934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257934.Bytes);
public long this[int i]=>Value[i];

public static A257934Inst Instance=new A257934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257935
{
public static readonly BigInteger[] Value={ 1L,0L,-5L,3L,-61L,5L,-125L,7L,-121L,9L,-325L,11L,-17071L,13L,-35L,15L,-7697L,17L,36685L,19L,-177911L,21L,852995L,23L,-236396851L,25L,8553025L,27L,-23749473209L,29L,8615841061175L,31L,-7709321049377L,33L,2577687858265L,35L,BigInteger.Parse("-26315271553088022793"),37L };
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
public class A257935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257935Inst Instance=new A257935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257936
{
public static readonly long[] Value={ 6L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257936Inst : IEnumerable<long>
{
public static readonly long[] Value=A257936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257936.Bytes);
public long this[int i]=>Value[i];

public static A257936Inst Instance=new A257936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257937
{
public static readonly long[] Value={ 1111151L,1111181L,1111211L,1111711L,1114111L,1117111L,1171111L,2999999L,3233333L,3331333L,3333133L,3333233L,3333313L,3333331L,3333373L,3333383L,3333433L,3337333L,3353333L,3433333L,3733333L,4999999L,7477777L,7577777L,7727777L,7772777L,7774777L,7777727L,7778777L,7877777L,9899999L,9929999L,9999299L,9999929L,9999991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257937Inst : IEnumerable<long>
{
public static readonly long[] Value=A257937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257937.Bytes);
public long this[int i]=>Value[i];

public static A257937Inst Instance=new A257937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257938
{
public static readonly long[] Value={ 6L,3L,8L,71L,12L,14L,105L,221L,24L,499L,261L,612L,1341L,175L,917L,549L,1351L,2303L,2273L,4767L,364L,1395L,1390L,1431L,6481L,2479L,918L,2412L,17783L,3178L,2994L,7538L,3409L,1361L,9645L,3454L,9197L,7074L,10418L,6059L,36235L,182L,1910L,4648L,1130L,695L,3973L,10839L,8647L,7942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257938Inst : IEnumerable<long>
{
public static readonly long[] Value=A257938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257938.Bytes);
public long this[int i]=>Value[i];

public static A257938Inst Instance=new A257938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257939
{
public static readonly BigInteger[] Value={ 0L,2L,116L,798L,37512L,257114L,12078908L,82790070L,3889371024L,26658145586L,1252365390980L,8583840088782L,403257766524696L,2763969850442378L,129847748455561292L,889989708002357094L,BigInteger.Parse("41810571744924211488"),BigInteger.Parse("286573922006908542050"),BigInteger.Parse("13462874254117140538004") };
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
public class A257939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257939Inst Instance=new A257939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257940
{
public static readonly BigInteger[] Value={ 0L,1L,52L,357L,16776L,114985L,5401852L,37024845L,1739379600L,11921885137L,560074829380L,3838809989301L,180342355680792L,1236084894669817L,58069678454385676L,398015497273691805L,BigInteger.Parse("18698256119956506912"),BigInteger.Parse("128159754037234091425"),BigInteger.Parse("6020780400947540840020") };
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
public class A257940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257940Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257940.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257940Inst Instance=new A257940Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257941
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,26L,9L,20L,34L,24L,39L,55L,22L,45L,66L,28L,47L,72L,85L,49L,76L,108L,68L,99L,53L,82L,112L,70L,114L,149L,74L,122L,172L,93L,145L,203L,101L,160L,95L,162L,216L,118L,187L,224L,141L,214L,143L,235L,139L,195L,281L,164L,241L,329L,166L,260L,170L,283L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257941Inst : IEnumerable<long>
{
public static readonly long[] Value=A257941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257941.Bytes);
public long this[int i]=>Value[i];

public static A257941Inst Instance=new A257941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257942
{
public static readonly long[] Value={ 1L,3L,12L,20L,15L,21L,56L,72L,45L,55L,132L,156L,91L,105L,240L,272L,153L,171L,380L,420L,231L,253L,552L,600L,325L,351L,756L,812L,435L,465L,992L,1056L,561L,595L,1260L,1332L,703L,741L,1560L,1640L,861L,903L,1892L,1980L,1035L,1081L,2256L,2352L,1225L,1275L,2652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257942Inst : IEnumerable<long>
{
public static readonly long[] Value=A257942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257942.Bytes);
public long this[int i]=>Value[i];

public static A257942Inst Instance=new A257942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257943
{
public static readonly long[] Value={ 1L,2L,2L,5L,5L,3L,14L,14L,8L,4L,41L,41L,23L,11L,5L,122L,122L,68L,32L,14L,6L,365L,365L,203L,95L,41L,17L,7L,1094L,1094L,608L,284L,122L,50L,20L,8L,3281L,3281L,1823L,851L,365L,149L,59L,23L,9L,9842L,9842L,5468L,2552L,1094L,446L,176L,68L,26L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257943Inst : IEnumerable<long>
{
public static readonly long[] Value=A257943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257943.Bytes);
public long this[int i]=>Value[i];

public static A257943Inst Instance=new A257943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257944
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,26L,16L,31L,20L,37L,50L,22L,41L,64L,35L,56L,83L,39L,69L,45L,54L,79L,111L,58L,92L,130L,60L,96L,136L,73L,115L,163L,75L,121L,168L,77L,134L,193L,98L,149L,182L,102L,157L,206L,117L,178L,244L,138L,210L,277L,140L,214L,282L,153L,229L,307L,155L,220L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257944Inst : IEnumerable<long>
{
public static readonly long[] Value=A257944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257944.Bytes);
public long this[int i]=>Value[i];

public static A257944Inst Instance=new A257944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257945
{
public static readonly long[] Value={ 6L,9L,3L,2L,0L,5L,4L,6L,4L,6L,2L,3L,7L,9L,7L,3L,2L,0L,4L,3L,4L,3L,6L,3L,7L,0L,4L,2L,2L,4L,1L,3L,8L,6L,8L,7L,9L,4L,1L,0L,2L,1L,7L,5L,0L,1L,6L,9L,2L,1L,9L,0L,1L,3L,3L,9L,9L,5L,5L,5L,8L,6L,7L,5L,2L,9L,5L,5L,8L,1L,4L,8L,8L,3L,1L,6L,6L,1L,0L,4L,3L,0L,2L,2L,3L,3L,6L,0L,6L,9L,1L,5L,2L,6L,8L,1L,8L,5L,8L,3L,5L,0L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257945Inst : IEnumerable<long>
{
public static readonly long[] Value=A257945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257945.Bytes);
public long this[int i]=>Value[i];

public static A257945Inst Instance=new A257945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257946
{
public static readonly long[] Value={ 10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,25L,219L,26L,419L,27L,35L,28L,819L,29L,1128L,45L,37L,229L,1235L,38L,55L,429L,39L,47L,1146L,56L,1139L,48L,239L,829L,57L,49L,1148L,1247L,439L,58L,1149L,67L,1166L,249L,59L,1158L,1257L,68L,77L,159L,839L,449L,1357L,69L,259L,78L,1177L,1276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257946Inst : IEnumerable<long>
{
public static readonly long[] Value=A257946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257946.Bytes);
public long this[int i]=>Value[i];

public static A257946Inst Instance=new A257946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257947
{
public static readonly BigInteger[] Value={ 1L,26L,1858L,236926L,53470032L,21496173692L,15580846842786L,20666722709050752L,BigInteger.Parse("50987383226899017116"),BigInteger.Parse("237747620610010161018672"),BigInteger.Parse("2125708489963555363039732518"),BigInteger.Parse("36886187432874074894930307867796"),BigInteger.Parse("1253964425811022692146824416678500176") };
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
public class A257947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257947Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257947.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257947Inst Instance=new A257947Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257948
{
public static readonly long[] Value={ 1L,35L,35L,35L,56L,56L,56L,56L,35L,1L,56L,56L,56L,56L,35L,35L,56L,56L,35L,35L,10L,56L,56L,56L,56L,56L,56L,14L,35L,35L,56L,56L,35L,35L,56L,56L,35L,35L,56L,35L,56L,56L,14L,56L,35L,56L,14L,35L,56L,56L,2L,56L,56L,56L,56L,35L,5L,56L,35L,56L,56L,56L,10L,56L,56L,35L,35L,56L,35L,56L,56L,56L,56L,2L,35L,35L,56L,56L,56L,56L,35L,35L,56L,35L,56L,56L,35L,56L,56L,35L,56L,56L,56L,56L,35L,56L,56L,56L,56L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257948Inst : IEnumerable<long>
{
public static readonly long[] Value=A257948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257948.Bytes);
public long this[int i]=>Value[i];

public static A257948Inst Instance=new A257948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257949
{
public static readonly long[] Value={ 0L,0L,0L,12L,0L,60L,36L,168L,384L,396L,1620L,1452L,5388L,6396L,14616L,25860L,40128L,87108L,115992L,259236L,358860L,710220L,1096392L,1885080L,3216768L,4991700L,8916024L,13349448L,23633064L,35731944L,60638400L,94572072L,152913120L,245107764L,382072212L,620410980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257949Inst : IEnumerable<long>
{
public static readonly long[] Value=A257949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257949.Bytes);
public long this[int i]=>Value[i];

public static A257949Inst Instance=new A257949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257950
{
public static readonly long[] Value={ 1L,10L,100L,103L,301L,367L,608L,806L,1000L,1030L,3010L,3056L,5630L,6080L,6703L,6791L,8060L,9167L,10000L,10003L,10275L,10300L,11241L,12770L,12939L,13929L,14112L,17027L,17502L,20175L,21921L,22119L,27501L,30001L,30067L,30100L,30616L,31606L,36700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257950Inst : IEnumerable<long>
{
public static readonly long[] Value=A257950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257950.Bytes);
public long this[int i]=>Value[i];

public static A257950Inst Instance=new A257950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257951
{
public static readonly long[] Value={ 465460L,672832L,829363L,891802L,919088L,1703659L,2656715L,2669971L,3035410L,3223041L,3585960L,3608292L,3636024L,4047253L,4058989L,4232549L,4591286L,4785400L,4797700L,5054313L,5120280L,5599321L,5872369L,6089675L,6541163L,6963642L,7957852L,8234393L,9069087L,9082140L,9312431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257951Inst : IEnumerable<long>
{
public static readonly long[] Value=A257951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257951.Bytes);
public long this[int i]=>Value[i];

public static A257951Inst Instance=new A257951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257952
{
public static readonly BigInteger[] Value={ 1L,1L,5L,37L,766L,43318L,7695805L,4015896016L,6371333036059L,30153126159555641L,BigInteger.Parse("431453249608567040694"),BigInteger.Parse("18558756256964594960321428"),BigInteger.Parse("2411839397220672351872242339314"),BigInteger.Parse("945878376319424018440202856702995909"),BigInteger.Parse("1121914029089423867715407724741780046405923") };
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
public class A257952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257952Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257952.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257952Inst Instance=new A257952Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257953
{
public static readonly BigInteger[] Value={ 1L,0L,1L,2L,9L,44L,265L,1854L,14833L,133496L,1334961L,14684570L,176214841L,2290792932L,32071101049L,481066515734L,7697064251745L,130850092279664L,2355301661033953L,44750731559645106L,312426715251262464L,2178674876680100744L,15178362413058474596UL,BigInteger.Parse("105663183116236278362") };
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
public class A257953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257953Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257953.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257953Inst Instance=new A257953Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257954
{
public static readonly BigInteger[] Value={ 380300389L,13416840252277L,BigInteger.Parse("102114787991863121805337"),BigInteger.Parse("3602567760523753992917728705"),BigInteger.Parse("27418932936218445934971843788960252365"),BigInteger.Parse("967328687318574474761362987583880892300813"),BigInteger.Parse("7362282174260114825535960626325353709734456640627073") };
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
public class A257954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257954Inst Instance=new A257954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257955
{
public static readonly long[] Value={ 2L,8L,1L,1L,2L,9L,7L,5L,1L,4L,6L,7L,0L,8L,6L,1L,6L,4L,2L,1L,2L,2L,7L,9L,0L,8L,0L,3L,7L,1L,0L,4L,8L,1L,6L,9L,3L,5L,2L,8L,1L,6L,5L,5L,2L,2L,3L,2L,9L,1L,7L,6L,5L,6L,8L,2L,2L,8L,9L,6L,5L,9L,0L,5L,3L,9L,3L,8L,6L,1L,5L,4L,8L,8L,7L,0L,1L,9L,2L,0L,5L,6L,8L,5L,1L,8L,8L,4L,8L,7L,4L,2L,3L,1L,8L,9L,0L,9L,3L,6L,4L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257955Inst : IEnumerable<long>
{
public static readonly long[] Value=A257955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257955.Bytes);
public long this[int i]=>Value[i];

public static A257955Inst Instance=new A257955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257956
{
public static readonly long[] Value={ 1L,6L,24L,74L,220L,626L,1754L,4860L,13390L,36762L,100728L,275666L,753898L,2060924L,5632550L,15391650L,42056008L,114907626L,313947186L,857741852L,2343430222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257956Inst : IEnumerable<long>
{
public static readonly long[] Value=A257956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257956.Bytes);
public long this[int i]=>Value[i];

public static A257956Inst Instance=new A257956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257957
{
public static readonly long[] Value={ 1L,0L,3L,3L,6L,4L,6L,1L,2L,5L,7L,6L,5L,5L,8L,2L,7L,0L,6L,4L,8L,5L,5L,3L,7L,4L,5L,5L,3L,3L,1L,6L,1L,7L,8L,6L,6L,7L,1L,0L,0L,3L,0L,8L,7L,0L,1L,5L,9L,5L,9L,8L,8L,6L,0L,4L,4L,8L,2L,1L,8L,5L,7L,5L,2L,9L,5L,1L,1L,3L,1L,2L,7L,1L,4L,7L,9L,4L,5L,4L,4L,8L,1L,4L,7L,9L,6L,9L,8L,4L,1L,8L,5L,8L,0L,5L,3L,8L,5L,5L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257957Inst : IEnumerable<long>
{
public static readonly long[] Value=A257957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257957.Bytes);
public long this[int i]=>Value[i];

public static A257957Inst Instance=new A257957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257958
{
public static readonly long[] Value={ 3L,2L,9L,0L,2L,1L,3L,9L,6L,0L,1L,7L,3L,2L,2L,4L,0L,9L,0L,8L,4L,3L,0L,9L,0L,8L,4L,5L,5L,4L,0L,0L,1L,9L,0L,3L,7L,4L,0L,2L,1L,9L,3L,2L,8L,2L,0L,0L,7L,0L,1L,6L,1L,2L,9L,3L,8L,8L,9L,5L,3L,1L,8L,3L,7L,5L,5L,3L,7L,5L,6L,6L,5L,3L,3L,7L,1L,7L,9L,1L,2L,9L,1L,5L,3L,2L,8L,7L,7L,1L,1L,1L,6L,9L,3L,5L,6L,7L,3L,1L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257958Inst : IEnumerable<long>
{
public static readonly long[] Value=A257958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257958.Bytes);
public long this[int i]=>Value[i];

public static A257958Inst Instance=new A257958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257959
{
public static readonly long[] Value={ 9L,2L,3L,6L,3L,2L,6L,7L,5L,9L,6L,1L,3L,3L,7L,7L,3L,4L,6L,0L,0L,0L,2L,6L,3L,3L,4L,7L,4L,8L,6L,7L,4L,7L,1L,3L,9L,8L,9L,4L,8L,9L,3L,2L,1L,5L,2L,6L,1L,0L,2L,7L,5L,3L,8L,5L,3L,5L,3L,9L,9L,3L,1L,5L,7L,2L,2L,0L,1L,3L,8L,9L,5L,4L,1L,0L,3L,9L,8L,8L,6L,7L,3L,3L,8L,7L,7L,1L,3L,7L,8L,2L,8L,0L,9L,1L,7L,3L,1L,0L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257959Inst : IEnumerable<long>
{
public static readonly long[] Value=A257959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257959.Bytes);
public long this[int i]=>Value[i];

public static A257959Inst Instance=new A257959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257960
{
public static readonly long[] Value={ 2L,7L,7L,8L,6L,7L,4L,9L,8L,9L,6L,8L,4L,5L,6L,8L,1L,7L,2L,3L,0L,6L,4L,4L,9L,9L,4L,5L,7L,9L,0L,3L,1L,0L,1L,4L,9L,0L,6L,9L,3L,6L,4L,2L,1L,1L,4L,6L,6L,7L,6L,5L,8L,8L,8L,3L,9L,1L,0L,1L,9L,3L,3L,2L,5L,5L,1L,9L,0L,2L,7L,1L,3L,7L,0L,9L,9L,9L,2L,5L,5L,5L,0L,1L,2L,2L,7L,6L,9L,6L,8L,8L,3L,0L,9L,6L,8L,3L,3L,0L,6L,8L,4L,7L,6L,3L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257960Inst : IEnumerable<long>
{
public static readonly long[] Value=A257960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257960.Bytes);
public long this[int i]=>Value[i];

public static A257960Inst Instance=new A257960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257961
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,3L,1L,4L,2L,0L,5L,2L,7L,4L,1L,6L,3L,0L,8L,3L,11L,6L,1L,9L,4L,12L,7L,2L,10L,5L,0L,13L,5L,18L,10L,2L,15L,7L,20L,12L,4L,17L,9L,1L,14L,6L,19L,11L,3L,16L,8L,0L,21L,8L,29L,16L,3L,24L,11L,32L,19L,6L,27L,14L,1L,22L,9L,30L,17L,4L,25L,12L,33L,20L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257961Inst : IEnumerable<long>
{
public static readonly long[] Value=A257961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257961.Bytes);
public long this[int i]=>Value[i];

public static A257961Inst Instance=new A257961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257962
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,3L,2L,1L,4L,0L,5L,3L,2L,7L,1L,6L,4L,0L,8L,5L,3L,11L,2L,10L,7L,1L,9L,6L,4L,12L,0L,13L,8L,5L,18L,3L,16L,11L,2L,15L,10L,7L,20L,1L,14L,9L,6L,19L,4L,17L,12L,0L,21L,13L,8L,29L,5L,26L,18L,3L,24L,16L,11L,32L,2L,23L,15L,10L,31L,7L,28L,20L,1L,22L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257962Inst : IEnumerable<long>
{
public static readonly long[] Value=A257962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257962.Bytes);
public long this[int i]=>Value[i];

public static A257962Inst Instance=new A257962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257963
{
public static readonly long[] Value={ 1L,0L,2L,5L,7L,6L,0L,5L,1L,0L,9L,3L,1L,3L,3L,0L,4L,5L,0L,3L,9L,8L,5L,4L,8L,6L,6L,0L,9L,6L,9L,5L,5L,2L,7L,9L,5L,3L,3L,4L,8L,7L,1L,8L,5L,6L,2L,1L,5L,0L,6L,9L,3L,9L,4L,2L,2L,3L,3L,8L,6L,8L,4L,4L,0L,1L,5L,8L,5L,1L,9L,2L,0L,8L,9L,9L,0L,7L,0L,9L,4L,2L,2L,2L,6L,7L,8L,7L,8L,7L,9L,1L,9L,7L,7L,9L,5L,3L,0L,7L,1L,3L,2L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257963Inst : IEnumerable<long>
{
public static readonly long[] Value=A257963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257963.Bytes);
public long this[int i]=>Value[i];

public static A257963Inst Instance=new A257963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257964
{
public static readonly long[] Value={ 7L,6L,9L,4L,0L,2L,1L,5L,0L,2L,8L,0L,8L,0L,0L,4L,8L,4L,1L,2L,2L,1L,2L,6L,9L,7L,1L,9L,4L,6L,0L,0L,5L,3L,1L,5L,5L,7L,6L,2L,0L,5L,5L,3L,2L,0L,3L,3L,5L,4L,3L,5L,8L,7L,7L,1L,5L,5L,6L,3L,4L,4L,4L,8L,1L,1L,1L,6L,2L,1L,5L,3L,7L,1L,4L,1L,0L,2L,9L,9L,9L,0L,9L,7L,0L,5L,4L,8L,0L,7L,3L,4L,1L,4L,1L,0L,0L,3L,7L,2L,0L,4L,3L,5L,5L,6L,7L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257964Inst : IEnumerable<long>
{
public static readonly long[] Value=A257964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257964.Bytes);
public long this[int i]=>Value[i];

public static A257964Inst Instance=new A257964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257965
{
public static readonly long[] Value={ 2L,32L,125L,162L,512L,1250L,2000L,2592L,4802L,8192L,10125L,13122L,20000L,29282L,32000L,41472L,49000L,57122L,76832L,78125L,92450L,101250L,131072L,152881L,162000L,167042L,207025L,209952L,215306L,260642L,300125L,320000L,388962L,468512L,512000L,559682L,663552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257965Inst : IEnumerable<long>
{
public static readonly long[] Value=A257965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257965.Bytes);
public long this[int i]=>Value[i];

public static A257965Inst Instance=new A257965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257966
{
public static readonly long[] Value={ 12L,14L,18L,32L,33L,52L,77L,100L,105L,130L,143L,180L,210L,226L,357L,377L,472L,548L,989L,1129L,1174L,1421L,1722L,4769L,6544L,6879L,7893L,18888L,21061L,24419L,25884L,32675L,53776L,62186L,109848L,110989L,123527L,160462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257966Inst : IEnumerable<long>
{
public static readonly long[] Value=A257966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257966.Bytes);
public long this[int i]=>Value[i];

public static A257966Inst Instance=new A257966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257967
{
public static readonly BigInteger[] Value={ 11L,41L,641L,10462721L,20920321L,10917370260001L,BigInteger.Parse("364090824435675874561"),BigInteger.Parse("3037065045777476472194281921"),BigInteger.Parse("97067184407836614348142428161"),BigInteger.Parse("3237159714751144204638073829896089601"),BigInteger.Parse("26434543100644872259207947255028288307201"),BigInteger.Parse("3600373169282616313621210190325730096037120382894091") };
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
public class A257967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257967Inst Instance=new A257967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257968
{
public static readonly long[] Value={ 1L,2L,38296L,151373L,398293L,422558L,733381L,971973L,2797318L,3833215L,6988327L,7271256L,8174876L,8732657L,9872323L,9981181L,11617988L,11798921L,14791421L,15376465L,15487926L,15625186L,16549885L,18543639L,21316582L,21492828L,22346329L,22867986L,23373644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257968Inst : IEnumerable<long>
{
public static readonly long[] Value=A257968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257968.Bytes);
public long this[int i]=>Value[i];

public static A257968Inst Instance=new A257968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257969
{
public static readonly long[] Value={ 1L,10L,100L,1000L,7972L,10000L,53941L,79720L,100000L,134242L,539410L,698614L,797200L,1000000L,1342420L,5394100L,6986140L,7525615L,7972000L,9000864L,10000000L,10057054L,13424200L,15366307L,17513566L,20602674L,23280211L,24716905L,25274655L,25665559L,32083981L,34326702L,34446204L,34534816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257969Inst : IEnumerable<long>
{
public static readonly long[] Value=A257969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257969.Bytes);
public long this[int i]=>Value[i];

public static A257969Inst Instance=new A257969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257970
{
public static readonly long[] Value={ 1L,2L,5L,16L,48L,144L,432L,1296L,3888L,11664L,34992L,104976L,314928L,944784L,2834352L,8503056L,25509168L,76527504L,229582512L,688747536L,2066242608L,6198727824L,18596183472L,55788550416L,167365651248L,502096953744L,1506290861232L,4518872583696L,13556617751088L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257970Inst : IEnumerable<long>
{
public static readonly long[] Value=A257970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257970.Bytes);
public long this[int i]=>Value[i];

public static A257970Inst Instance=new A257970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257971
{
public static readonly long[] Value={ 0L,2L,-1L,5L,-2L,8L,-5L,21L,-8L,34L,-21L,81L,-34L,128L,-81L,337L,-128L,546L,-337L,1301L,-546L,2056L,-1301L,5381L,-2056L,8706L,-5381L,20737L,-8706L,32768L,-20737L,86273L,-32768L,139778L,-86273L,333061L,-139778L,526344L,-333061L,1377557L,-526344L,2228770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257971Inst : IEnumerable<long>
{
public static readonly long[] Value=A257971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257971.Bytes);
public long this[int i]=>Value[i];

public static A257971Inst Instance=new A257971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257972
{
public static readonly long[] Value={ 5L,4L,2L,6L,6L,6L,7L,3L,2L,5L,7L,0L,2L,8L,2L,7L,5L,4L,2L,8L,8L,8L,5L,0L,7L,4L,7L,6L,3L,9L,6L,2L,4L,7L,4L,8L,7L,9L,1L,4L,2L,0L,3L,6L,3L,7L,6L,3L,0L,9L,2L,7L,2L,0L,0L,9L,5L,0L,7L,8L,6L,6L,0L,1L,3L,8L,1L,0L,1L,1L,7L,9L,9L,6L,4L,3L,2L,3L,3L,3L,6L,7L,3L,6L,3L,9L,8L,3L,4L,5L,7L,0L,2L,2L,3L,6L,5L,4L,2L,0L,4L,8L,2L,8L,6L,3L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257972Inst : IEnumerable<long>
{
public static readonly long[] Value=A257972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257972.Bytes);
public long this[int i]=>Value[i];

public static A257972Inst Instance=new A257972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257973
{
public static readonly long[] Value={ 323L,767L,949L,989L,10001L,11111L,11611L,11911L,12121L,12521L,13031L,13631L,14041L,14141L,14941L,15151L,15751L,16861L,17071L,17371L,17671L,17771L,18581L,18881L,19091L,31813L,32023L,32723L,33133L,33233L,33433L,33833L,34043L,34343L,34943L,35953L,36163L,36763L,37973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257973Inst : IEnumerable<long>
{
public static readonly long[] Value=A257973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257973.Bytes);
public long this[int i]=>Value[i];

public static A257973Inst Instance=new A257973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257974
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,23L,29L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,89L,97L,101L,103L,107L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,211L,223L,227L,229L,233L,239L,241L,257L,263L,269L,271L,277L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257974Inst : IEnumerable<long>
{
public static readonly long[] Value=A257974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257974.Bytes);
public long this[int i]=>Value[i];

public static A257974Inst Instance=new A257974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257975
{
public static readonly BigInteger[] Value={ 970L,3940L,219246804790L,BigInteger.Parse("205684244417408273530"),BigInteger.Parse("11480068853945505053489115880"),BigInteger.Parse("47065929034956905708053692550"),BigInteger.Parse("2626939693541678540279445026253849400"),BigInteger.Parse("2464437767031050248773603452558570281788774040"),BigInteger.Parse("137550230606703955058365608367051590003016395627772390") };
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
public class A257975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257975Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257975.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257975Inst Instance=new A257975Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257976
{
public static readonly long[] Value={ 23L,94L,123L,147L,269L,806L,1049L,1081L,1179L,1277L,1775L,2575L,5374L,14865L,20490L,20845L,27177L,54934L,72599L,87031L,101827L,391514L,452574L,534389L,1197146L,1219229L,1297767L,1327510L,4565354L,4946164L,6124646L,7967984L,8637602L,8869951L,9615708L,10061718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257976Inst : IEnumerable<long>
{
public static readonly long[] Value=A257976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257976.Bytes);
public long this[int i]=>Value[i];

public static A257976Inst Instance=new A257976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257977
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,3L,2L,1L,4L,1L,2L,3L,4L,1L,4L,1L,4L,3L,2L,1L,6L,5L,2L,3L,4L,1L,6L,1L,4L,3L,2L,5L,6L,1L,2L,3L,8L,1L,6L,1L,4L,7L,2L,1L,8L,7L,6L,3L,4L,1L,6L,5L,8L,3L,2L,1L,10L,1L,2L,9L,8L,5L,6L,1L,4L,3L,10L,1L,9L,1L,2L,7L,4L,7L,6L,1L,10L,9L,2L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257977Inst : IEnumerable<long>
{
public static readonly long[] Value=A257977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257977.Bytes);
public long this[int i]=>Value[i];

public static A257977Inst Instance=new A257977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257978
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,4L,4L,3L,3L,4L,5L,8L,5L,7L,6L,7L,10L,6L,10L,11L,11L,10L,11L,10L,13L,12L,12L,12L,12L,18L,15L,19L,19L,14L,16L,16L,21L,19L,19L,18L,19L,15L,20L,22L,20L,22L,20L,22L,26L,19L,29L,29L,24L,30L,28L,23L,27L,27L,36L,25L,30L,31L,29L,36L,35L,28L,32L,34L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257978Inst : IEnumerable<long>
{
public static readonly long[] Value=A257978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257978.Bytes);
public long this[int i]=>Value[i];

public static A257978Inst Instance=new A257978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257979
{
public static readonly long[] Value={ 2L,3L,11L,19L,13L,31L,47L,43L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257979Inst : IEnumerable<long>
{
public static readonly long[] Value=A257979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257979.Bytes);
public long this[int i]=>Value[i];

public static A257979Inst Instance=new A257979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257980
{
public static readonly long[] Value={ 3L,1L,2L,-1L,4L,-2L,5L,-4L,6L,-3L,9L,-10L,8L,-5L,11L,-9L,13L,-12L,14L,-13L,15L,-11L,19L,-21L,17L,-14L,20L,-19L,21L,-18L,24L,-25L,23L,-17L,29L,-33L,25L,-23L,27L,-22L,32L,-31L,33L,-35L,31L,-27L,35L,-34L,36L,-29L,-6L,37L,-30L,44L,-49L,39L,-37L,41L,-26L,-7L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257980Inst : IEnumerable<long>
{
public static readonly long[] Value=A257980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257980.Bytes);
public long this[int i]=>Value[i];

public static A257980Inst Instance=new A257980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257981
{
public static readonly long[] Value={ 1L,3L,2L,5L,10L,4L,8L,6L,12L,7L,14L,11L,22L,9L,18L,36L,13L,26L,15L,30L,16L,32L,17L,34L,24L,20L,40L,19L,38L,21L,42L,23L,46L,28L,56L,25L,50L,41L,29L,58L,31L,62L,27L,54L,47L,39L,78L,33L,66L,37L,74L,35L,70L,44L,88L,45L,90L,43L,86L,48L,96L,52L,104L,49L,98L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A257981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257981Inst : IEnumerable<long>
{
public static readonly long[] Value=A257981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A257981.Bytes);
public long this[int i]=>Value[i];

public static A257981Inst Instance=new A257981Inst();

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