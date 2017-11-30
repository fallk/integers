using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A076496
{
public static readonly long[] Value={ 1L,24L,30L,42L,54L,66L,78L,102L,114L,121L,138L,174L,186L,222L,246L,258L,282L,304L,318L,354L,366L,402L,426L,438L,474L,498L,534L,582L,606L,618L,642L,654L,678L,762L,780L,786L,822L,834L,894L,906L,942L,978L,1002L,1038L,1074L,1086L,1146L,1158L,1182L,1194L,1266L,1338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076496Inst : IEnumerable<long>
{
public static readonly long[] Value=A076496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076496.Bytes);
public long this[int i]=>Value[i];

public static A076496Inst Instance=new A076496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076495
{
public static readonly long[] Value={ 2L,20L,4L,9L,0L,25L,8L,10L,15L,14L,21L,24L,27L,22L,16L,26L,39L,208L,36L,34L,51L,38L,57L,112L,95L,46L,69L,48L,115L,841L,32L,58L,45L,62L,93L,660L,155L,1369L,162L,44L,63L,1681L,50L,82L,123L,52L,129L,60L,75L,94L,72L,352L,235L,90L,329L,84L,99L,68L,265L,96L,371L,118L,64L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076495Inst : IEnumerable<long>
{
public static readonly long[] Value=A076495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076495.Bytes);
public long this[int i]=>Value[i];

public static A076495Inst Instance=new A076495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076494
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,2L,2L,3L,2L,1L,2L,3L,2L,1L,2L,2L,3L,4L,3L,2L,1L,1L,1L,4L,4L,5L,6L,6L,4L,3L,3L,5L,6L,6L,5L,4L,4L,5L,5L,5L,6L,7L,6L,6L,7L,6L,6L,7L,7L,6L,5L,5L,6L,5L,7L,8L,7L,8L,8L,8L,8L,8L,8L,7L,9L,9L,9L,7L,6L,7L,7L,8L,8L,8L,7L,9L,9L,8L,9L,9L,9L,9L,8L,9L,10L,10L,9L,7L,8L,8L,9L,10L,10L,10L,10L,9L,9L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076494Inst : IEnumerable<long>
{
public static readonly long[] Value=A076494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076494.Bytes);
public long this[int i]=>Value[i];

public static A076494Inst Instance=new A076494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076493
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,1L,0L,0L,0L,2L,1L,1L,1L,1L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,2L,1L,2L,1L,0L,1L,1L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,2L,1L,1L,0L,0L,1L,1L,0L,0L,0L,2L,1L,0L,2L,2L,1L,1L,0L,1L,1L,1L,1L,0L,1L,2L,1L,2L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,3L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076493Inst : IEnumerable<long>
{
public static readonly long[] Value=A076493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076493.Bytes);
public long this[int i]=>Value[i];

public static A076493Inst Instance=new A076493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076492
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,1L,2L,3L,5L,4L,4L,3L,4L,4L,3L,5L,8L,7L,7L,6L,5L,7L,9L,7L,8L,9L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,9L,9L,10L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076492Inst : IEnumerable<long>
{
public static readonly long[] Value=A076492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076492.Bytes);
public long this[int i]=>Value[i];

public static A076492Inst Instance=new A076492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076491
{
public static readonly long[] Value={ 2L,3L,11L,13L,101L,103L,1031L,1033L,10223L,10243L,18379L,18397L,126079L,126097L,1206479L,1206497L,100438279L,100438297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076491Inst : IEnumerable<long>
{
public static readonly long[] Value=A076491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076491.Bytes);
public long this[int i]=>Value[i];

public static A076491Inst Instance=new A076491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076490
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,0L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,1L,2L,0L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076490Inst : IEnumerable<long>
{
public static readonly long[] Value=A076490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076490.Bytes);
public long this[int i]=>Value[i];

public static A076490Inst Instance=new A076490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076489
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076489Inst : IEnumerable<long>
{
public static readonly long[] Value=A076489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076489.Bytes);
public long this[int i]=>Value[i];

public static A076489Inst Instance=new A076489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076488
{
public static readonly long[] Value={ 4L,8L,16L,20L,27L,32L,40L,60L,63L,64L,68L,80L,104L,120L,126L,128L,136L,160L,164L,171L,189L,204L,212L,220L,232L,240L,243L,256L,260L,272L,279L,294L,296L,312L,315L,320L,340L,342L,343L,350L,351L,356L,363L,375L,378L,387L,404L,408L,416L,424L,464L,476L,480L,492L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076488Inst : IEnumerable<long>
{
public static readonly long[] Value=A076488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076488.Bytes);
public long this[int i]=>Value[i];

public static A076488Inst Instance=new A076488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076487
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,13L,14L,15L,16L,17L,19L,20L,21L,22L,23L,26L,27L,29L,30L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,46L,47L,51L,53L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,77L,78L,79L,80L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076487Inst : IEnumerable<long>
{
public static readonly long[] Value=A076487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076487.Bytes);
public long this[int i]=>Value[i];

public static A076487Inst Instance=new A076487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076486
{
public static readonly long[] Value={ 9L,25L,28L,36L,45L,50L,52L,75L,76L,81L,84L,90L,98L,100L,117L,121L,124L,144L,148L,150L,153L,156L,175L,180L,208L,225L,228L,234L,242L,244L,245L,252L,261L,268L,275L,289L,292L,300L,304L,306L,316L,324L,325L,333L,338L,360L,364L,369L,372L,380L,388L,392L,400L,405L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076486Inst : IEnumerable<long>
{
public static readonly long[] Value=A076486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076486.Bytes);
public long this[int i]=>Value[i];

public static A076486Inst Instance=new A076486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076485
{
public static readonly long[] Value={ 12L,18L,24L,44L,48L,49L,54L,56L,72L,88L,92L,96L,99L,108L,112L,116L,125L,132L,135L,140L,147L,152L,162L,168L,169L,172L,176L,184L,188L,192L,196L,198L,200L,207L,216L,224L,236L,248L,250L,264L,270L,276L,280L,284L,288L,297L,308L,328L,332L,336L,344L,348L,352L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076485Inst : IEnumerable<long>
{
public static readonly long[] Value=A076485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076485.Bytes);
public long this[int i]=>Value[i];

public static A076485Inst Instance=new A076485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076484
{
public static readonly long[] Value={ 2L,12L,14L,30L,42L,56L,78L,140L,168L,190L,248L,264L,270L,418L,570L,594L,616L,630L,714L,744L,812L,840L,910L,1240L,1254L,1672L,1848L,2214L,2376L,2436L,2580L,2730L,3080L,3596L,3720L,3828L,3956L,4064L,4180L,4522L,4674L,5016L,5278L,5396L,5544L,6426L,6678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076484Inst : IEnumerable<long>
{
public static readonly long[] Value=A076484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076484.Bytes);
public long this[int i]=>Value[i];

public static A076484Inst Instance=new A076484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076467
{
public static readonly long[] Value={ 1L,8L,16L,27L,32L,64L,81L,125L,128L,216L,243L,256L,343L,512L,625L,729L,1000L,1024L,1296L,1331L,1728L,2048L,2187L,2197L,2401L,2744L,3125L,3375L,4096L,4913L,5832L,6561L,6859L,7776L,8000L,8192L,9261L,10000L,10648L,12167L,13824L,14641L,15625L,16384L,16807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076467Inst : IEnumerable<long>
{
public static readonly long[] Value=A076467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076467.Bytes);
public long this[int i]=>Value[i];

public static A076467Inst Instance=new A076467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076466
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,10L,13L,16L,23L,30L,38L,40L,41L,42L,54L,60L,69L,72L,87L,100L,116L,122L,129L,144L,163L,182L,202L,208L,213L,240L,263L,288L,312L,318L,321L,324L,352L,362L,373L,400L,431L,462L,494L,504L,513L,552L,587L,624L,660L,670L,677L,728L,767L,810L,850L,860L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076466Inst : IEnumerable<long>
{
public static readonly long[] Value=A076466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076466.Bytes);
public long this[int i]=>Value[i];

public static A076466Inst Instance=new A076466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076465
{
public static readonly long[] Value={ 1L,571L,12938L,115270L,630755L,2543401L,8307796L,23249388L,57792165L,130790935L,274285726L,540036146L,1008233863L,1798831685L,3085968040L,5116005976L,8229746121L,12889413363L,19711057330L,29503047070L,43311380651L,62472570721L,88674907388L,124028940100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076465Inst : IEnumerable<long>
{
public static readonly long[] Value=A076465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076465.Bytes);
public long this[int i]=>Value[i];

public static A076465Inst Instance=new A076465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076464
{
public static readonly long[] Value={ 145L,4567L,38570L,183670L,630755L,1751365L,4187092L,8957100L,17583765L,32236435L,55893310L,92521442L,147274855L,226710785L,339024040L,494299480L,704782617L,985168335L,1352907730L,1828533070L,2436000875L,3203053117L,4161596540L,5348100100L,6804010525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076464Inst : IEnumerable<long>
{
public static readonly long[] Value=A076464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076464.Bytes);
public long this[int i]=>Value[i];

public static A076464Inst Instance=new A076464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076463
{
public static readonly long[] Value={ 85L,2803L,24026L,115270L,397655L,1107505L,2653588L,5685996L,11176665L,20511535L,35594350L,58962098L,93912091L,144640685L,216393640L,315628120L,450186333L,629480811L,864691330L,1168973470L,1557678815L,2048586793L,2662148156L,3421740100L,4353933025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076463Inst : IEnumerable<long>
{
public static readonly long[] Value=A076463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076463.Bytes);
public long this[int i]=>Value[i];

public static A076463Inst Instance=new A076463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076462
{
public static readonly long[] Value={ 41L,1471L,12938L,62870L,218555L,611821L,1471316L,3161388L,6227565L,11448635L,19895326L,32995586L,52606463L,81092585L,121411240L,177204056L,252895281L,353796663L,486218930L,657589870L,876579011L,1153228901L,1499092988L,1927380100L,2453105525L,3093248691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076462Inst : IEnumerable<long>
{
public static readonly long[] Value=A076462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076462.Bytes);
public long this[int i]=>Value[i];

public static A076462Inst Instance=new A076462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076461
{
public static readonly long[] Value={ 13L,571L,5306L,26470L,93455L,264313L,640276L,1383276L,2736465L,5047735L,8796238L,14621906L,23357971L,36066485L,54076840L,79027288L,112909461L,158115891L,217490530L,294382270L,392701463L,516979441L,672431036L,865020100L,1101528025L,1389625263L,1737945846L,2156164906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076461Inst : IEnumerable<long>
{
public static readonly long[] Value=A076461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076461.Bytes);
public long this[int i]=>Value[i];

public static A076461Inst Instance=new A076461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076460
{
public static readonly long[] Value={ 1L,103L,1130L,6070L,22355L,64981L,160468L,351660L,703365L,1308835L,2297086L,3841058L,6166615L,9562385L,14390440L,21097816L,30228873L,42438495L,58506130L,79350670L,106046171L,139838413L,182162300L,234660100L,299200525L,377898651L,473136678L,587585530L,724227295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076460Inst : IEnumerable<long>
{
public static readonly long[] Value=A076460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076460.Bytes);
public long this[int i]=>Value[i];

public static A076460Inst Instance=new A076460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076459
{
public static readonly long[] Value={ 1L,57L,390L,1510L,4335L,10311L,21532L,40860L,72045L,119845L,190146L,290082L,428155L,614355L,860280L,1179256L,1586457L,2099025L,2736190L,3519390L,4472391L,5621407L,6995220L,8625300L,10545925L,12794301L,15410682L,18438490L,21924435L,25918635L,30474736L,35650032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076459Inst : IEnumerable<long>
{
public static readonly long[] Value=A076459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076459.Bytes);
public long this[int i]=>Value[i];

public static A076459Inst Instance=new A076459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076458
{
public static readonly long[] Value={ 17L,165L,678L,1910L,4335L,8547L,15260L,25308L,39645L,59345L,85602L,119730L,163163L,217455L,284280L,365432L,462825L,578493L,714590L,873390L,1057287L,1268795L,1510548L,1785300L,2095925L,2445417L,2836890L,3273578L,3758835L,4296135L,4889072L,5541360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076458Inst : IEnumerable<long>
{
public static readonly long[] Value=A076458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076458.Bytes);
public long this[int i]=>Value[i];

public static A076458Inst Instance=new A076458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076457
{
public static readonly long[] Value={ 13L,129L,534L,1510L,3435L,6783L,12124L,20124L,31545L,47245L,68178L,95394L,130039L,173355L,226680L,291448L,369189L,461529L,570190L,696990L,843843L,1012759L,1205844L,1425300L,1673425L,1952613L,2265354L,2614234L,3001935L,3431235L,3905008L,4426224L,4997949L,5623345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076457Inst : IEnumerable<long>
{
public static readonly long[] Value=A076457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076457.Bytes);
public long this[int i]=>Value[i];

public static A076457Inst Instance=new A076457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076456
{
public static readonly long[] Value={ 9L,93L,390L,1110L,2535L,5019L,8988L,14940L,23445L,35145L,50754L,71058L,96915L,129255L,169080L,217464L,275553L,344565L,425790L,520590L,630399L,756723L,901140L,1065300L,1250925L,1459809L,1693818L,1954890L,2245035L,2566335L,2920944L,3311088L,3739065L,4207245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076456Inst : IEnumerable<long>
{
public static readonly long[] Value=A076456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076456.Bytes);
public long this[int i]=>Value[i];

public static A076456Inst Instance=new A076456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076455
{
public static readonly long[] Value={ 5L,57L,246L,710L,1635L,3255L,5852L,9756L,15345L,23045L,33330L,46722L,63791L,85155L,111480L,143480L,181917L,227601L,281390L,344190L,416955L,500687L,596436L,705300L,828425L,967005L,1122282L,1295546L,1488135L,1701435L,1936880L,2195952L,2480181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076455Inst : IEnumerable<long>
{
public static readonly long[] Value=A076455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076455.Bytes);
public long this[int i]=>Value[i];

public static A076455Inst Instance=new A076455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076454
{
public static readonly long[] Value={ 1L,21L,102L,310L,735L,1491L,2716L,4572L,7245L,10945L,15906L,22386L,30667L,41055L,53880L,69496L,88281L,110637L,136990L,167790L,203511L,244651L,291732L,345300L,405925L,474201L,550746L,636202L,731235L,836535L,952816L,1080816L,1221297L,1375045L,1542870L,1725606L,1924111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076454Inst : IEnumerable<long>
{
public static readonly long[] Value=A076454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076454.Bytes);
public long this[int i]=>Value[i];

public static A076454Inst Instance=new A076454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076453
{
public static readonly long[] Value={ 1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076453Inst : IEnumerable<long>
{
public static readonly long[] Value=A076453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076453.Bytes);
public long this[int i]=>Value[i];

public static A076453Inst Instance=new A076453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076452
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L,1L,1L,0L,-1L,1L,2L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076452Inst : IEnumerable<long>
{
public static readonly long[] Value=A076452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076452.Bytes);
public long this[int i]=>Value[i];

public static A076452Inst Instance=new A076452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076451
{
public static readonly long[] Value={ 2L,2L,2L,1L,0L,2L,1L,2L,2L,1L,2L,2L,1L,2L,0L,1L,2L,2L,1L,0L,0L,1L,2L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,2L,1L,2L,2L,1L,2L,2L,1L,2L,0L,1L,2L,2L,1L,0L,0L,1L,2L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,1L,2L,2L,1L,0L,2L,1L,2L,2L,1L,2L,2L,1L,2L,0L,1L,2L,2L,1L,0L,0L,1L,2L,0L,1L,0L,0L,1L,0L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076451Inst : IEnumerable<long>
{
public static readonly long[] Value=A076451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076451.Bytes);
public long this[int i]=>Value[i];

public static A076451Inst Instance=new A076451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076450
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,16L,18L,20L,22L,24L,30L,32L,34L,36L,40L,42L,44L,48L,50L,54L,60L,64L,66L,68L,70L,72L,74L,75L,80L,84L,88L,90L,96L,100L,102L,108L,110L,120L,128L,130L,132L,134L,135L,136L,138L,140L,144L,148L,150L,154L,156L,160L,162L,168L,176L,180L,192L,196L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076450Inst : IEnumerable<long>
{
public static readonly long[] Value=A076450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076450.Bytes);
public long this[int i]=>Value[i];

public static A076450Inst Instance=new A076450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076449
{
public static readonly long[] Value={ 1L,2L,25L,13L,37L,107L,127L,113L,167L,1027L,179L,137L,1036L,1127L,1013L,1137L,1235L,1136L,1123L,1037L,1139L,1079L,10124L,10126L,1349L,1279L,1237L,3479L,10699L,1367L,10179L,1379L,10127L,10079L,10138L,10123L,10234L,10235L,10247L,10339L,10267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076449Inst : IEnumerable<long>
{
public static readonly long[] Value=A076449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076449.Bytes);
public long this[int i]=>Value[i];

public static A076449Inst Instance=new A076449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076448
{
public static readonly BigInteger[] Value={ 5L,17L,129L,4097L,2097153L,274877906945L,BigInteger.Parse("2361183241434822606849"),BigInteger.Parse("87112285931760246646623899502532662132737"),BigInteger.Parse("59285549689505892056868344324448208820874232148807968788202283012051522375647233") };
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
public class A076448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076448Inst Instance=new A076448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076447
{
public static readonly long[] Value={ 2L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L,1L,2L,0L,1L,2L,2L,1L,2L,2L,1L,0L,2L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076447Inst : IEnumerable<long>
{
public static readonly long[] Value=A076447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076447.Bytes);
public long this[int i]=>Value[i];

public static A076447Inst Instance=new A076447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076446
{
public static readonly long[] Value={ 3L,4L,1L,7L,9L,2L,5L,4L,13L,15L,8L,9L,19L,8L,13L,4L,3L,16L,25L,27L,4L,16L,9L,18L,13L,32L,1L,35L,19L,18L,31L,8L,32L,9L,43L,16L,12L,17L,47L,49L,23L,27L,1L,53L,55L,16L,41L,23L,36L,61L,7L,4L,28L,24L,65L,36L,27L,4L,69L,71L,27L,8L,21L,17L,3L,72L,77L,47L,32L,81L,47L,36L,36L,49L,87L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076446Inst : IEnumerable<long>
{
public static readonly long[] Value=A076446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076446.Bytes);
public long this[int i]=>Value[i];

public static A076446Inst Instance=new A076446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076445
{
public static readonly BigInteger[] Value={ 25L,70225L,130576327L,189750625L,512706121225L,13837575261123L,99612037019889L,1385331749802025L,3743165875258953025L,BigInteger.Parse("10114032809617941274225"),BigInteger.Parse("8905398244301708746029223"),BigInteger.Parse("27328112908421802064005625"),BigInteger.Parse("73840550964522899559001927225") };
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
public class A076445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076445Inst Instance=new A076445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076444
{
public static readonly long[] Value={ 8L,25L,1L,4L,4L,214369L,1L,1L,16L,2187L,16L,4L,36L,30459361L,1L,9L,8L,9L,8L,16L,4L,27L,4L,1L,100L,1L,9L,4L,196L,6859L,1L,4L,16L,899236854927L,1L,36L,27L,1331L,25L,9L,8L,518436000625L,200L,64L,4L,243L,25L,1L,32L,625L,49L,144L,72L,27L,9L,8L,64L,109503L,49L,4L,64L,3025L,1L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076444Inst : IEnumerable<long>
{
public static readonly long[] Value=A076444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076444.Bytes);
public long this[int i]=>Value[i];

public static A076444Inst Instance=new A076444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076443
{
public static readonly BigInteger[] Value={ 1331L,698896L,1003003001L,637832238736L,1000030000300001L,1033394994933301L,1331399339931331L,4099923883299904L,BigInteger.Parse("1000000300000030000001"),BigInteger.Parse("1003303931991393033001"),BigInteger.Parse("1030331909339091330301"),BigInteger.Parse("1331003993003993001331"),BigInteger.Parse("6916103777337773016196") };
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
public class A076443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076443Inst Instance=new A076443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076442
{
public static readonly long[] Value={ 1L,9L,1331L,3375L,35937L,59319L,357911L,753571L,759375L,5177717L,5359375L,5735339L,9393931L,17373979L,37595375L,39135393L,37159393753L,99317171591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076442Inst : IEnumerable<long>
{
public static readonly long[] Value=A076442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076442.Bytes);
public long this[int i]=>Value[i];

public static A076442Inst Instance=new A076442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076441
{
public static readonly long[] Value={ 2L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L,1L,0L,2L,1L,2L,2L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076441Inst : IEnumerable<long>
{
public static readonly long[] Value=A076441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076441.Bytes);
public long this[int i]=>Value[i];

public static A076441Inst Instance=new A076441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076440
{
public static readonly long[] Value={ 1L,2L,10L,30L,38L,46L,122L,126L,138L,142L,146L,150L,154L,166L,170L,190L,194L,214L,222L,234L,270L,282L,298L,318L,338L,342L,354L,370L,382L,386L,406L,486L,490L,498L,502L,518L,546L,550L,566L,574L,582L,586L,594L,638L,666L,678L,686L,694L,710L,726L,730L,734L,746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076440Inst : IEnumerable<long>
{
public static readonly long[] Value=A076440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076440.Bytes);
public long this[int i]=>Value[i];

public static A076440Inst Instance=new A076440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076439
{
public static readonly long[] Value={ 29L,43L,52L,59L,173L,181L,263L,283L,317L,332L,347L,349L,361L,379L,383L,419L,428L,436L,461L,467L,479L,484L,491L,509L,523L,529L,569L,571L,607L,613L,619L,641L,643L,653L,661L,677L,691L,709L,733L,773L,787L,788L,811L,827L,839L,853L,877L,881L,883L,907L,911L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076439Inst : IEnumerable<long>
{
public static readonly long[] Value=A076439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076439.Bytes);
public long this[int i]=>Value[i];

public static A076439Inst Instance=new A076439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076438
{
public static readonly long[] Value={ 1L,2L,10L,29L,30L,38L,43L,46L,52L,59L,122L,126L,138L,142L,146L,150L,154L,166L,170L,173L,181L,190L,194L,214L,222L,234L,263L,270L,282L,283L,298L,317L,318L,332L,338L,342L,347L,349L,354L,361L,370L,379L,382L,383L,386L,406L,419L,428L,436L,461L,467L,479L,484L,486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076438Inst : IEnumerable<long>
{
public static readonly long[] Value=A076438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076438.Bytes);
public long this[int i]=>Value[i];

public static A076438Inst Instance=new A076438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076437
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,12L,13L,15L,17L,18L,20L,21L,22L,25L,26L,27L,28L,31L,36L,37L,38L,40L,41L,42L,43L,45L,46L,48L,51L,52L,53L,55L,56L,57L,58L,60L,63L,66L,68L,70L,72L,73L,75L,76L,77L,78L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076437Inst : IEnumerable<long>
{
public static readonly long[] Value=A076437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076437.Bytes);
public long this[int i]=>Value[i];

public static A076437Inst Instance=new A076437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076436
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,10L,12L,13L,15L,18L,20L,21L,22L,25L,26L,27L,28L,31L,36L,37L,38L,40L,42L,43L,45L,46L,48L,51L,52L,55L,56L,57L,58L,60L,63L,66L,68L,70L,72L,73L,75L,76L,78L,80L,81L,82L,85L,86L,87L,88L,90L,91L,93L,96L,97L,100L,102L,103L,105L,106L,108L,110L,111L,112L,115L,116L,117L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076436Inst : IEnumerable<long>
{
public static readonly long[] Value=A076436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076436.Bytes);
public long this[int i]=>Value[i];

public static A076436Inst Instance=new A076436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076435
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,6L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076435Inst : IEnumerable<long>
{
public static readonly long[] Value=A076435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076435.Bytes);
public long this[int i]=>Value[i];

public static A076435Inst Instance=new A076435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076434
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,4L,16L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076434Inst : IEnumerable<long>
{
public static readonly long[] Value=A076434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076434.Bytes);
public long this[int i]=>Value[i];

public static A076434Inst Instance=new A076434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076433
{
public static readonly long[] Value={ 25L,121L,2187L,6431296L,6434856L,6956883693L,27027009001L,34359738368L,42618264157L,312078649600L,312079600999L,328080365089L,11305780833649L,11305786504384L,19287643015432L,62854896459664L,79723523012809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076433Inst : IEnumerable<long>
{
public static readonly long[] Value=A076433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076433.Bytes);
public long this[int i]=>Value[i];

public static A076433Inst Instance=new A076433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076432
{
public static readonly BigInteger[] Value={ 36L,144L,2209L,6436369L,312079766881L,328081510656L,11305787558464L,62854912315881L,79723540870416L,4550858480922601L,11435943732416784L,3109406220195722500L,6258210474706101136L,7596357574791306304L,BigInteger.Parse("21016258678615763761"),BigInteger.Parse("32645304184825666489") };
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
public class A076432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076432Inst Instance=new A076432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076431
{
public static readonly long[] Value={ 9L,16L,36L,128L,144L,256L,361L,529L,1024L,1369L,1764L,2209L,2809L,3136L,3481L,5041L,5929L,6889L,8281L,9409L,10816L,12321L,13924L,16900L,17689L,19881L,22201L,24649L,27225L,29929L,33124L,36100L,39601L,43264L,51076L,55225L,59536L,64009L,69169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076431Inst : IEnumerable<long>
{
public static readonly long[] Value=A076431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076431.Bytes);
public long this[int i]=>Value[i];

public static A076431Inst Instance=new A076431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076430
{
public static readonly long[] Value={ 1L,70L,1610L,22715L,170170L,675376L,2224824L,5696295L,21057190L,52798270L,111385170L,261955560L,414410780L,628310711L,1187225546L,2369546790L,3631067090L,5339542890L,8459444455L,10969197540L,15154637940L,22349763995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076430Inst : IEnumerable<long>
{
public static readonly long[] Value=A076430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076430.Bytes);
public long this[int i]=>Value[i];

public static A076430Inst Instance=new A076430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076429
{
public static readonly long[] Value={ 1L,14L,114L,675L,2610L,6576L,14616L,27423L,65758L,121590L,200250L,354600L,481740L,636111L,972946L,1543438L,2052330L,2654850L,3609375L,4292820L,5326308L,6902883L,8780068L,12023616L,15516000L,17510850L,19669731L,22045986L,24606288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076429Inst : IEnumerable<long>
{
public static readonly long[] Value=A076429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076429.Bytes);
public long this[int i]=>Value[i];

public static A076429Inst Instance=new A076429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076428
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,14L,15L,20L,24L,28L,30L,36L,40L,42L,48L,50L,56L,60L,63L,70L,72L,80L,84L,90L,96L,100L,108L,110L,120L,121L,132L,144L,150L,153L,156L,168L,180L,192L,200L,204L,216L,220L,228L,231L,240L,250L,252L,264L,276L,288L,290L,291L,295L,300L,304L,305L,312L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076428Inst : IEnumerable<long>
{
public static readonly long[] Value=A076428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076428.Bytes);
public long this[int i]=>Value[i];

public static A076428Inst Instance=new A076428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076427
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,0L,5L,3L,4L,1L,4L,2L,3L,0L,3L,3L,7L,3L,5L,2L,2L,2L,4L,5L,2L,3L,3L,7L,1L,1L,2L,4L,2L,0L,3L,2L,3L,1L,4L,4L,3L,0L,1L,3L,4L,1L,6L,4L,3L,0L,2L,1L,2L,2L,3L,4L,3L,0L,1L,4L,2L,0L,4L,4L,4L,0L,2L,5L,2L,0L,4L,4L,6L,2L,3L,3L,2L,0L,4L,4L,4L,0L,2L,2L,2L,0L,3L,3L,6L,0L,3L,4L,4L,2L,4L,5L,3L,2L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076427Inst : IEnumerable<long>
{
public static readonly long[] Value=A076427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076427.Bytes);
public long this[int i]=>Value[i];

public static A076427Inst Instance=new A076427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076426
{
public static readonly long[] Value={ 5750L,33866L,74841L,517250L,577750L,5538710L,51414250L,51454250L,51687250L,51727250L,51748250L,51858250L,52525250L,57515750L,57535750L,57575750L,57757750L,67597352L,841794296L,5120202250L,5120802250L,5121612250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076426Inst : IEnumerable<long>
{
public static readonly long[] Value=A076426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076426.Bytes);
public long this[int i]=>Value[i];

public static A076426Inst Instance=new A076426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076425
{
public static readonly long[] Value={ 2074L,2113L,2179L,2914L,3111L,4112L,4371L,4390L,4456L,4956L,4978L,5185L,5450L,5750L,6474L,6585L,6827L,7248L,7259L,7285L,7467L,8175L,8625L,8647L,9378L,9711L,9739L,10199L,10975L,11407L,11752L,12006L,12232L,12338L,12445L,12826L,13224L,13396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076425Inst : IEnumerable<long>
{
public static readonly long[] Value=A076425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076425.Bytes);
public long this[int i]=>Value[i];

public static A076425Inst Instance=new A076425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076424
{
public static readonly long[] Value={ 1L,2L,3L,12L,31L,23L,56L,102L,193L,257L,570L,1129L,4970L,3229L,11551L,11969L,24232L,20094L,24103L,35996L,100090L,222284L,116269L,231488L,388768L,1751753L,2046872L,1140163L,1149979L,2156214L,3199384L,2971734L,7018074L,10163234L,13135933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076424Inst : IEnumerable<long>
{
public static readonly long[] Value=A076424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076424.Bytes);
public long this[int i]=>Value[i];

public static A076424Inst Instance=new A076424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076423
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,1L,2L,3L,1L,1L,2L,4L,3L,1L,1L,2L,3L,2L,3L,2L,1L,1L,6L,3L,1L,1L,2L,2L,2L,2L,5L,3L,1L,1L,1L,3L,5L,1L,1L,4L,4L,3L,2L,3L,2L,1L,5L,2L,1L,6L,1L,6L,2L,2L,1L,7L,1L,1L,2L,3L,2L,1L,3L,2L,1L,2L,7L,3L,1L,2L,3L,4L,4L,1L,6L,4L,1L,2L,4L,2L,2L,1L,6L,4L,1L,1L,1L,2L,4L,2L,1L,4L,1L,1L,1L,3L,3L,2L,2L,1L,2L,8L,3L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076423Inst : IEnumerable<long>
{
public static readonly long[] Value=A076423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076423.Bytes);
public long this[int i]=>Value[i];

public static A076423Inst Instance=new A076423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076422
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,1L,7L,6L,1L,2L,2L,8L,1L,3L,0L,3L,0L,5L,4L,5L,4L,6L,8L,2L,0L,5L,5L,9L,4L,6L,5L,6L,5L,3L,9L,8L,2L,4L,9L,5L,3L,0L,5L,7L,9L,8L,9L,5L,5L,1L,3L,9L,1L,9L,2L,3L,3L,4L,8L,2L,1L,1L,1L,2L,5L,8L,1L,7L,5L,3L,1L,0L,7L,5L,1L,5L,7L,9L,1L,4L,0L,1L,0L,7L,6L,3L,9L,3L,0L,3L,5L,8L,5L,9L,5L,7L,6L,8L,2L,4L,2L,2L,8L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076422Inst : IEnumerable<long>
{
public static readonly long[] Value=A076422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076422.Bytes);
public long this[int i]=>Value[i];

public static A076422Inst Instance=new A076422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076421
{
public static readonly long[] Value={ 7L,0L,6L,8L,5L,8L,2L,7L,4L,5L,6L,2L,8L,7L,3L,2L,0L,8L,8L,5L,5L,2L,9L,5L,8L,9L,2L,7L,5L,4L,6L,6L,6L,5L,3L,7L,6L,4L,3L,7L,6L,4L,7L,5L,5L,0L,0L,6L,4L,2L,3L,5L,6L,4L,4L,0L,5L,9L,4L,3L,7L,7L,5L,4L,3L,4L,5L,0L,1L,3L,4L,3L,0L,5L,6L,6L,0L,8L,6L,9L,3L,9L,5L,4L,0L,8L,4L,7L,5L,2L,6L,1L,5L,2L,2L,3L,6L,6L,0L,8L,3L,8L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076421Inst : IEnumerable<long>
{
public static readonly long[] Value=A076421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076421.Bytes);
public long this[int i]=>Value[i];

public static A076421Inst Instance=new A076421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076420
{
public static readonly long[] Value={ 3L,9L,2L,6L,6L,0L,2L,3L,1L,2L,0L,4L,7L,9L,1L,8L,7L,7L,8L,2L,3L,8L,5L,3L,3L,3L,4L,3L,6L,2L,7L,0L,2L,4L,8L,9L,5L,1L,6L,1L,1L,5L,2L,0L,8L,6L,9L,9L,5L,3L,3L,7L,3L,0L,7L,4L,2L,0L,6L,6L,8L,6L,5L,4L,2L,5L,5L,2L,7L,9L,7L,0L,8L,9L,0L,9L,6L,4L,6L,4L,2L,4L,7L,4L,1L,9L,4L,3L,3L,8L,0L,0L,1L,5L,6L,2L,1L,9L,4L,2L,2L,0L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076420Inst : IEnumerable<long>
{
public static readonly long[] Value=A076420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076420.Bytes);
public long this[int i]=>Value[i];

public static A076420Inst Instance=new A076420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076419
{
public static readonly long[] Value={ 7L,8L,5L,4L,7L,5L,7L,4L,3L,8L,2L,3L,7L,6L,1L,2L,5L,6L,4L,8L,6L,1L,0L,0L,8L,5L,8L,2L,7L,6L,4L,5L,7L,0L,4L,5L,7L,8L,4L,8L,5L,4L,1L,9L,2L,9L,2L,3L,0L,0L,4L,6L,6L,9L,4L,4L,2L,3L,2L,8L,1L,4L,4L,8L,8L,2L,6L,5L,6L,1L,4L,2L,1L,4L,0L,8L,6L,5L,3L,5L,2L,8L,2L,3L,4L,9L,8L,6L,6L,7L,8L,9L,3L,9L,9L,9L,8L,0L,0L,5L,3L,6L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076419Inst : IEnumerable<long>
{
public static readonly long[] Value=A076419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076419.Bytes);
public long this[int i]=>Value[i];

public static A076419Inst Instance=new A076419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076418
{
public static readonly long[] Value={ 4L,6L,9L,4L,0L,9L,1L,1L,3L,2L,9L,7L,4L,1L,7L,4L,5L,7L,6L,4L,3L,6L,3L,9L,1L,7L,7L,8L,0L,1L,9L,8L,1L,2L,0L,4L,9L,3L,8L,9L,8L,9L,6L,7L,3L,7L,5L,4L,5L,7L,6L,6L,8L,2L,8L,9L,7L,2L,8L,0L,3L,2L,7L,7L,8L,4L,9L,0L,7L,7L,9L,3L,6L,8L,0L,1L,0L,5L,2L,5L,0L,8L,0L,0L,3L,5L,8L,8L,5L,0L,2L,7L,8L,1L,5L,5L,4L,2L,7L,3L,1L,5L,7L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076418Inst : IEnumerable<long>
{
public static readonly long[] Value=A076418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076418.Bytes);
public long this[int i]=>Value[i];

public static A076418Inst Instance=new A076418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076417
{
public static readonly long[] Value={ 1L,8L,7L,5L,1L,0L,4L,0L,6L,8L,7L,1L,1L,9L,6L,1L,1L,6L,6L,4L,4L,5L,3L,0L,8L,2L,4L,1L,0L,7L,8L,2L,1L,4L,1L,6L,2L,5L,7L,0L,1L,1L,1L,7L,3L,3L,5L,3L,1L,0L,6L,9L,9L,8L,8L,2L,4L,5L,4L,1L,3L,7L,1L,3L,1L,0L,5L,6L,7L,9L,9L,5L,2L,8L,4L,0L,4L,2L,8L,6L,3L,8L,5L,2L,6L,5L,6L,6L,5L,5L,0L,5L,8L,1L,8L,8L,6L,0L,3L,7L,0L,8L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076417Inst : IEnumerable<long>
{
public static readonly long[] Value=A076417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076417.Bytes);
public long this[int i]=>Value[i];

public static A076417Inst Instance=new A076417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076416
{
public static readonly long[] Value={ 1L,0L,9L,9L,5L,6L,0L,7L,8L,3L,8L,0L,0L,1L,6L,7L,0L,9L,0L,6L,6L,6L,9L,0L,3L,2L,5L,1L,9L,1L,0L,5L,8L,9L,2L,4L,1L,7L,5L,4L,2L,8L,0L,3L,0L,3L,0L,5L,7L,6L,3L,6L,1L,9L,9L,7L,0L,7L,6L,5L,5L,5L,9L,0L,2L,6L,5L,6L,9L,2L,2L,8L,2L,8L,9L,0L,0L,2L,8L,7L,1L,2L,0L,3L,7L,6L,1L,7L,8L,7L,6L,2L,0L,2L,3L,5L,3L,4L,9L,8L,2L,7L,7L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076416Inst : IEnumerable<long>
{
public static readonly long[] Value=A076416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076416.Bytes);
public long this[int i]=>Value[i];

public static A076416Inst Instance=new A076416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076415
{
public static readonly long[] Value={ 7L,8L,5L,3L,2L,0L,4L,6L,2L,4L,0L,9L,5L,8L,3L,7L,5L,5L,6L,4L,7L,7L,0L,6L,6L,6L,8L,7L,2L,5L,4L,0L,4L,9L,7L,9L,0L,3L,2L,2L,3L,0L,4L,1L,7L,3L,9L,9L,0L,6L,7L,4L,6L,1L,4L,8L,4L,1L,3L,3L,7L,3L,0L,8L,5L,1L,0L,5L,5L,9L,4L,1L,7L,8L,1L,9L,2L,9L,2L,8L,4L,9L,4L,8L,3L,8L,8L,6L,7L,6L,0L,0L,3L,1L,2L,4L,3L,8L,8L,4L,4L,1L,0L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076415Inst : IEnumerable<long>
{
public static readonly long[] Value=A076415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076415.Bytes);
public long this[int i]=>Value[i];

public static A076415Inst Instance=new A076415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076414
{
public static readonly long[] Value={ 4L,7L,3L,0L,0L,4L,0L,7L,4L,4L,8L,6L,2L,7L,0L,4L,0L,2L,6L,0L,2L,4L,0L,4L,8L,1L,0L,0L,8L,3L,3L,8L,8L,4L,8L,1L,9L,8L,9L,8L,3L,4L,1L,8L,0L,0L,7L,0L,6L,8L,4L,8L,6L,8L,9L,0L,9L,6L,3L,5L,5L,8L,4L,5L,3L,6L,9L,1L,3L,6L,6L,6L,9L,8L,5L,2L,0L,1L,3L,1L,8L,2L,1L,8L,1L,9L,5L,4L,8L,9L,3L,9L,2L,7L,3L,2L,0L,9L,1L,6L,5L,8L,5L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076414Inst : IEnumerable<long>
{
public static readonly long[] Value=A076414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076414.Bytes);
public long this[int i]=>Value[i];

public static A076414Inst Instance=new A076414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076413
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,6L,0L,1L,1L,0L,0L,6L,0L,6L,1L,1L,0L,28L,0L,1L,0L,6L,0L,45L,0L,0L,1L,1L,1L,72L,0L,1L,1L,28L,0L,45L,0L,6L,6L,1L,0L,120L,0L,6L,1L,6L,0L,28L,1L,28L,1L,1L,0L,850L,0L,1L,6L,0L,1L,45L,0L,6L,1L,45L,0L,672L,0L,1L,6L,6L,1L,45L,0L,120L,0L,1L,0L,850L,1L,1L,1L,28L,0L,850L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076413Inst : IEnumerable<long>
{
public static readonly long[] Value=A076413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076413.Bytes);
public long this[int i]=>Value[i];

public static A076413Inst Instance=new A076413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076412
{
public static readonly long[] Value={ 1L,3L,4L,1L,7L,9L,2L,5L,4L,13L,15L,17L,19L,21L,4L,3L,16L,25L,27L,20L,9L,18L,13L,33L,35L,19L,18L,39L,41L,43L,28L,17L,47L,49L,51L,53L,55L,57L,59L,61L,39L,24L,65L,67L,69L,71L,35L,38L,75L,77L,79L,81L,47L,36L,85L,87L,89L,23L,68L,71L,10L,12L,95L,97L,99L,101L,103L,40L,65L,107L,109L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076412Inst : IEnumerable<long>
{
public static readonly long[] Value=A076412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076412.Bytes);
public long this[int i]=>Value[i];

public static A076412Inst Instance=new A076412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076411
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,2L,3L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076411Inst : IEnumerable<long>
{
public static readonly long[] Value=A076411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076411.Bytes);
public long this[int i]=>Value[i];

public static A076411Inst Instance=new A076411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076410
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,4L,7L,6L,9L,10L,10L,9L,13L,13L,15L,16L,14L,18L,17L,19L,22L,24L,25L,23L,25L,27L,28L,29L,30L,34L,33L,37L,34L,39L,40L,36L,43L,42L,45L,41L,48L,49L,45L,51L,52L,54L,57L,58L,52L,60L,59L,64L,59L,67L,62L,69L,70L,69L,73L,75L,68L,78L,79L,81L,84L,84L,87L,88L,80L,87L,93L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076410Inst : IEnumerable<long>
{
public static readonly long[] Value=A076410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076410.Bytes);
public long this[int i]=>Value[i];

public static A076410Inst Instance=new A076410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076409
{
public static readonly long[] Value={ 1L,1L,5L,7L,22L,39L,68L,76L,92L,203L,186L,333L,410L,430L,423L,689L,767L,915L,1072L,994L,1314L,1343L,1577L,1958L,2328L,2525L,2369L,2675L,2943L,3164L,3683L,3930L,4658L,4587L,5513L,5134L,6123L,6520L,6012L,7439L,7518L,8145L,7831L,9264L,9653L,8955L,10761L,11596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076409Inst : IEnumerable<long>
{
public static readonly long[] Value=A076409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076409.Bytes);
public long this[int i]=>Value[i];

public static A076409Inst Instance=new A076409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076408
{
public static readonly long[] Value={ 1L,5L,13L,22L,38L,63L,90L,122L,158L,207L,271L,352L,452L,573L,698L,826L,970L,1139L,1335L,1551L,1776L,2019L,2275L,2564L,2888L,3231L,3592L,3992L,4433L,4917L,5429L,5958L,6534L,7159L,7835L,8564L,9348L,10189L,11089L,12050L,13050L,14074L,15163L,16319L,17544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076408Inst : IEnumerable<long>
{
public static readonly long[] Value=A076408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076408.Bytes);
public long this[int i]=>Value[i];

public static A076408Inst Instance=new A076408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076407
{
public static readonly long[] Value={ 1L,1L,1L,5L,5L,5L,5L,13L,22L,22L,22L,22L,22L,22L,22L,38L,38L,38L,38L,38L,38L,38L,38L,38L,63L,63L,90L,90L,90L,90L,90L,122L,122L,122L,122L,158L,158L,158L,158L,158L,158L,158L,158L,158L,158L,158L,158L,158L,207L,207L,207L,207L,207L,207L,207L,207L,207L,207L,207L,207L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076407Inst : IEnumerable<long>
{
public static readonly long[] Value=A076407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076407.Bytes);
public long this[int i]=>Value[i];

public static A076407Inst Instance=new A076407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076406
{
public static readonly long[] Value={ 2L,3L,5L,7L,98L,640L,735L,980L,2401L,2625L,2744L,4913L,5145L,6272L,6400L,9800L,9856L,14336L,27440L,33614L,36015L,58564L,62720L,64000L,94325L,98000L,98560L,143360L,188650L,232925L,252105L,274400L,298144L,336140L,401408L,405769L,465850L,570999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076406Inst : IEnumerable<long>
{
public static readonly long[] Value=A076406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076406.Bytes);
public long this[int i]=>Value[i];

public static A076406Inst Instance=new A076406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076405
{
public static readonly long[] Value={ 1L,8L,16L,27L,32L,125L,81L,64L,216L,343L,128L,243L,1000L,1331L,625L,256L,1728L,2197L,2744L,1296L,3375L,729L,512L,4913L,5832L,2401L,6859L,8000L,9261L,10648L,1024L,12167L,13824L,3125L,17576L,2187L,21952L,24389L,27000L,29791L,10000L,2048L,35937L,39304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076405Inst : IEnumerable<long>
{
public static readonly long[] Value=A076405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076405.Bytes);
public long this[int i]=>Value[i];

public static A076405Inst Instance=new A076405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076404
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076404Inst : IEnumerable<long>
{
public static readonly long[] Value=A076404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076404.Bytes);
public long this[int i]=>Value[i];

public static A076404Inst Instance=new A076404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076131
{
public static readonly BigInteger[] Value={ 0L,1L,5L,41L,657L,21025L,1345601L,172236929L,44092653825L,22575438758401L,23117249288602625L,BigInteger.Parse("47344126543058176001"),BigInteger.Parse("193921542320366288900097"),BigInteger.Parse("1588605274688440638669594625"),BigInteger.Parse("26027708820495411423962638336001") };
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
public class A076131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076131Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076131.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076131Inst Instance=new A076131Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076130
{
public static readonly long[] Value={ 13L,299L,5229L,75961L,715492L,11137824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076130Inst : IEnumerable<long>
{
public static readonly long[] Value=A076130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076130.Bytes);
public long this[int i]=>Value[i];

public static A076130Inst Instance=new A076130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076129
{
public static readonly long[] Value={ 4L,2L,7L,2L,1L,9L,3L,33L,29L,4L,14L,1L,5L,16L,35L,81L,11L,86L,25L,11L,24L,214L,34L,17L,16L,2L,40L,16L,233L,16L,166L,91L,250L,14L,8L,11L,30L,2L,56L,289L,3L,98L,217L,501L,47L,163L,197L,200L,127L,6L,362L,142L,10L,137L,486L,31L,229L,81L,354L,514L,333L,185L,175L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076129Inst : IEnumerable<long>
{
public static readonly long[] Value=A076129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076129.Bytes);
public long this[int i]=>Value[i];

public static A076129Inst Instance=new A076129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076128
{
public static readonly long[] Value={ 0L,-1L,0L,14L,105L,699L,5012L,40284L,362835L,3628745L,39916734L,479001522L,6227020709L,87178291095L,1307674367880L,20922789887864L,355687428095847L,6402373705727829L,121645100408831810L,2432902008176639790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076128Inst : IEnumerable<long>
{
public static readonly long[] Value=A076128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076128.Bytes);
public long this[int i]=>Value[i];

public static A076128Inst Instance=new A076128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076127
{
public static readonly BigInteger[] Value={ 0L,1L,101L,101001L,1010010001L,101001000100001L,BigInteger.Parse("101001000100001000001"),BigInteger.Parse("1010010001000010000010000001"),BigInteger.Parse("101001000100001000001000000100000001"),BigInteger.Parse("101001000100001000001000000100000001000000001") };
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
public class A076127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076127Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076127.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076127Inst Instance=new A076127Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076126
{
public static readonly long[] Value={ 2L,6L,24L,12L,120L,120L,720L,1080L,120L,5040L,10080L,2520L,40320L,100800L,40320L,1680L,362880L,1088640L,604800L,60480L,3628800L,12700800L,9072000L,1512000L,30240L,39916800L,159667200L,139708800L,33264000L,1663200L,479001600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076126Inst : IEnumerable<long>
{
public static readonly long[] Value=A076126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076126.Bytes);
public long this[int i]=>Value[i];

public static A076126Inst Instance=new A076126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076125
{
public static readonly long[] Value={ 2L,4L,9L,8L,8L,25L,12L,12L,29L,16L,16L,37L,20L,20L,61L,24L,24L,57L,28L,28L,65L,32L,32L,129L,36L,36L,85L,40L,40L,93L,44L,44L,129L,48L,48L,113L,52L,52L,121L,56L,56L,165L,60L,60L,141L,64L,64L,149L,68L,68L,265L,72L,72L,169L,76L,76L,177L,80L,80L,233L,84L,84L,197L,88L,88L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076125Inst : IEnumerable<long>
{
public static readonly long[] Value=A076125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076125.Bytes);
public long this[int i]=>Value[i];

public static A076125Inst Instance=new A076125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076124
{
public static readonly long[] Value={ 1L,4L,12L,36L,180L,1260L,7560L,25200L,277200L,1663200L,21621600L,64864800L,735134400L,6983776800L,146659312800L,1613252440800L,37104806138400L,445257673660800L,4452576736608000L,38588998383936000L,1080491954750208000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076124Inst : IEnumerable<long>
{
public static readonly long[] Value=A076124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076124.Bytes);
public long this[int i]=>Value[i];

public static A076124Inst Instance=new A076124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076123
{
public static readonly long[] Value={ 1L,2L,8L,3L,6L,4L,18L,5L,15L,7L,42L,9L,16L,10L,20L,11L,55L,12L,45L,13L,91L,14L,27L,17L,68L,19L,76L,21L,210L,22L,110L,23L,253L,24L,330L,25L,48L,26L,130L,28L,364L,29L,2639L,30L,105L,31L,93L,32L,34L,33L,561L,35L,665L,36L,171L,37L,777L,38L,1995L,39L,858L,40L,44L,41L,943L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076123Inst : IEnumerable<long>
{
public static readonly long[] Value=A076123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076123.Bytes);
public long this[int i]=>Value[i];

public static A076123Inst Instance=new A076123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076122
{
public static readonly long[] Value={ 1L,2L,8L,36L,72L,50L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076122Inst : IEnumerable<long>
{
public static readonly long[] Value=A076122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076122.Bytes);
public long this[int i]=>Value[i];

public static A076122Inst Instance=new A076122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076121
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076121Inst : IEnumerable<long>
{
public static readonly long[] Value=A076121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076121.Bytes);
public long this[int i]=>Value[i];

public static A076121Inst Instance=new A076121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076120
{
public static readonly long[] Value={ 3L,4L,9L,8L,25L,12L,35L,16L,27L,20L,77L,24L,65L,28L,45L,32L,85L,36L,133L,40L,63L,44L,115L,48L,125L,52L,81L,56L,319L,60L,217L,64L,99L,68L,175L,72L,185L,76L,117L,80L,451L,84L,215L,88L,135L,92L,235L,96L,343L,100L,153L,104L,265L,108L,275L,112L,171L,116L,413L,120L,427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076120Inst : IEnumerable<long>
{
public static readonly long[] Value=A076120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076120.Bytes);
public long this[int i]=>Value[i];

public static A076120Inst Instance=new A076120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076119
{
public static readonly long[] Value={ 20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L,3L,7L,8L,14L,12L,20L,18L,13L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076119Inst : IEnumerable<long>
{
public static readonly long[] Value=A076119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076119.Bytes);
public long this[int i]=>Value[i];

public static A076119Inst Instance=new A076119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076118
{
public static readonly long[] Value={ 0L,1L,1L,-1L,-3L,-2L,2L,5L,3L,-3L,-7L,-4L,4L,9L,5L,-5L,-11L,-6L,6L,13L,7L,-7L,-15L,-8L,8L,17L,9L,-9L,-19L,-10L,10L,21L,11L,-11L,-23L,-12L,12L,25L,13L,-13L,-27L,-14L,14L,29L,15L,-15L,-31L,-16L,16L,33L,17L,-17L,-35L,-18L,18L,37L,19L,-19L,-39L,-20L,20L,41L,21L,-21L,-43L,-22L,22L,45L,23L,-23L,-47L,-24L,24L,49L,25L,-25L,-51L,-26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076118Inst : IEnumerable<long>
{
public static readonly long[] Value=A076118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076118.Bytes);
public long this[int i]=>Value[i];

public static A076118Inst Instance=new A076118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076117
{
public static readonly long[] Value={ 1L,27L,27L,0L,125L,27L,343L,0L,216L,125L,1331L,0L,2197L,343L,3375L,216L,4913L,729L,6859L,0L,9261L,1331L,12167L,0L,1000L,2197L,729L,0L,24389L,3375L,29791L,0L,35937L,4913L,42875L,0L,50653L,6859L,59319L,0L,68921L,9261L,79507L,0L,3375L,12167L,103823L,5832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076117Inst : IEnumerable<long>
{
public static readonly long[] Value=A076117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076117.Bytes);
public long this[int i]=>Value[i];

public static A076117Inst Instance=new A076117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076116
{
public static readonly long[] Value={ 1L,13L,8L,0L,23L,2L,46L,0L,20L,8L,116L,0L,163L,18L,218L,6L,281L,32L,352L,0L,431L,50L,518L,0L,28L,72L,14L,0L,827L,98L,946L,0L,1073L,128L,1208L,0L,1351L,162L,1502L,0L,1661L,200L,1828L,0L,53L,242L,2186L,98L,32L,43L,2576L,0L,2783L,36L,2998L,0L,3221L,392L,3452L,0L,3691L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076116Inst : IEnumerable<long>
{
public static readonly long[] Value=A076116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076116.Bytes);
public long this[int i]=>Value[i];

public static A076116Inst Instance=new A076116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076115
{
public static readonly long[] Value={ 1L,9L,9L,0L,25L,81L,49L,36L,81L,225L,121L,0L,169L,441L,225L,0L,289L,225L,361L,0L,441L,1089L,529L,324L,400L,1521L,729L,0L,841L,2025L,961L,784L,1089L,2601L,1225L,0L,1369L,3249L,1521L,900L,1681L,3969L,1849L,0L,2025L,4761L,2209L,0L,1225L,2025L,2601L,0L,2809L,2025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076115Inst : IEnumerable<long>
{
public static readonly long[] Value=A076115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076115.Bytes);
public long this[int i]=>Value[i];

public static A076115Inst Instance=new A076115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076114
{
public static readonly long[] Value={ 1L,4L,2L,0L,3L,11L,4L,1L,5L,18L,6L,0L,7L,25L,8L,0L,9L,4L,10L,0L,11L,39L,12L,2L,4L,46L,14L,0L,15L,53L,16L,9L,17L,60L,18L,0L,19L,67L,20L,3L,21L,74L,22L,0L,23L,81L,24L,0L,1L,16L,26L,0L,27L,11L,28L,4L,29L,102L,30L,0L,31L,109L,32L,0L,33L,116L,34L,0L,35L,123L,36L,5L,37L,130L,11L,0L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076114Inst : IEnumerable<long>
{
public static readonly long[] Value=A076114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076114.Bytes);
public long this[int i]=>Value[i];

public static A076114Inst Instance=new A076114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076113
{
public static readonly BigInteger[] Value={ 1L,2L,27L,4096L,9765625L,470184984576L,558545864083284007L,BigInteger.Parse("19342813113834066795298816"),BigInteger.Parse("22528399544939174411840147874772641"),BigInteger.Parse("1000000000000000000000000000000000000000000000") };
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
public class A076113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076113Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076113.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076113Inst Instance=new A076113Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076112
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,9L,1L,4L,16L,64L,1L,5L,25L,125L,625L,1L,6L,36L,216L,1296L,7776L,1L,7L,49L,343L,2401L,16807L,117649L,1L,8L,64L,512L,4096L,32768L,262144L,2097152L,1L,9L,81L,729L,6561L,59049L,531441L,4782969L,43046721L,1L,10L,100L,1000L,10000L,100000L,1000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076112Inst : IEnumerable<long>
{
public static readonly long[] Value=A076112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076112.Bytes);
public long this[int i]=>Value[i];

public static A076112Inst Instance=new A076112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076111
{
public static readonly BigInteger[] Value={ 1L,2L,15L,280L,9945L,576576L,49579075L,5925744000L,939536222625L,190787784140800L,48279601331512551L,14894665739501184000UL,BigInteger.Parse("5502449072258318805625"),BigInteger.Parse("2397950328737212204032000") };
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
public class A076111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076111Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A076111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076111.Bytes);
public BigInteger this[int i]=>Value[i];

public static A076111Inst Instance=new A076111Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076110
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,5L,1L,4L,7L,10L,1L,5L,9L,13L,17L,1L,6L,11L,16L,21L,26L,1L,7L,13L,19L,25L,31L,37L,1L,8L,15L,22L,29L,36L,43L,50L,1L,9L,17L,25L,33L,41L,49L,57L,65L,1L,10L,19L,28L,37L,46L,55L,64L,73L,82L,1L,11L,21L,31L,41L,51L,61L,71L,81L,91L,101L,1L,12L,23L,34L,45L,56L,67L,78L,89L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076110Inst : IEnumerable<long>
{
public static readonly long[] Value=A076110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076110.Bytes);
public long this[int i]=>Value[i];

public static A076110Inst Instance=new A076110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A076109
{
public static readonly long[] Value={ 1L,1L,3L,0L,5L,3L,7L,0L,3L,5L,11L,0L,13L,7L,15L,0L,17L,3L,19L,0L,21L,11L,23L,0L,5L,13L,3L,0L,29L,15L,31L,0L,33L,17L,35L,0L,37L,19L,39L,0L,41L,21L,43L,0L,15L,23L,47L,0L,7L,5L,51L,0L,53L,3L,55L,0L,57L,29L,59L,0L,61L,31L,21L,0L,65L,33L,67L,0L,69L,35L,71L,0L,73L,37L,15L,0L,77L,39L,79L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A076109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A076109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A076109Inst : IEnumerable<long>
{
public static readonly long[] Value=A076109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A076109.Bytes);
public long this[int i]=>Value[i];

public static A076109Inst Instance=new A076109Inst();

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