using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A178905
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,18L,19L,20L,22L,25L,36L,37L,38L,44L,45L,50L,51L,52L,74L,75L,76L,77L,89L,90L,100L,101L,102L,105L,109L,147L,150L,153L,154L,165L,166L,173L,178L,179L,180L,181L,204L,205L,210L,212L,214L,217L,293L,294L,299L,300L,301L,306L,308L,309L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178905Inst : IEnumerable<long>
{
public static readonly long[] Value=A178905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178905.Bytes);
public long this[int i]=>Value[i];

public static A178905Inst Instance=new A178905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178906
{
public static readonly BigInteger[] Value={ 0L,1L,111L,12221L,1345431L,148120741L,16306859151L,1795249291661L,197641985459271L,21758735456812981L,2395455437160313791L,BigInteger.Parse("263719679979113532701"),BigInteger.Parse("29033338933965570750711"),BigInteger.Parse("3196328653672267000058821"),BigInteger.Parse("351889146664225079931458031"),BigInteger.Parse("38740062414361757172385959341"),BigInteger.Parse("4264958013327732538141695683751") };
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
public class A178906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178906Inst Instance=new A178906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178907
{
public static readonly long[] Value={ 4L,7L,12L,18L,26L,32L,40L,47L,56L,67L,74L,85L,94L,101L,110L,121L,132L,140L,152L,162L,170L,182L,192L,204L,218L,228L,236L,246L,254L,264L,284L,294L,306L,314L,330L,338L,350L,362L,372L,384L,396L,405L,422L,431L,442L,451L,470L,489L,500L,509L,520L,533L,542L,559L,572L,585L,598L,607L,620L,631L,640L,657L,678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178907Inst : IEnumerable<long>
{
public static readonly long[] Value=A178907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178907.Bytes);
public long this[int i]=>Value[i];

public static A178907Inst Instance=new A178907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178908
{
public static readonly long[] Value={ 1L,3L,2L,7L,7L,6L,6L,15L,12L,9L,10L,14L,12L,10L,8L,31L,25L,20L,18L,21L,19L,30L,24L,30L,24L,20L,18L,18L,20L,24L,30L,63L,60L,43L,40L,36L,36L,54L,54L,45L,40L,53L,48L,54L,48L,40L,46L,62L,60L,40L,42L,36L,36L,54L,54L,34L,36L,60L,58L,56L,60L,34L,38L,127L,121L,68L,66L,79L,79L,120L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178908Inst : IEnumerable<long>
{
public static readonly long[] Value=A178908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178908.Bytes);
public long this[int i]=>Value[i];

public static A178908Inst Instance=new A178908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178909
{
public static readonly long[] Value={ 1L,6L,36L,54L,120L,2470L,2640L,3144L,3780L,32640L,41280L,52632L,67184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178909Inst : IEnumerable<long>
{
public static readonly long[] Value=A178909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178909.Bytes);
public long this[int i]=>Value[i];

public static A178909Inst Instance=new A178909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178910
{
public static readonly long[] Value={ 1L,3L,2L,7L,4L,6L,6L,15L,11L,12L,10L,14L,12L,10L,8L,31L,16L,29L,18L,28L,16L,30L,22L,30L,29L,20L,16L,18L,28L,24L,30L,63L,40L,48L,32L,49L,36L,54L,40L,60L,40L,48L,42L,54L,44L,58L,46L,62L,55L,39L,32L,36L,52L,48L,56L,34L,40L,36L,58L,56L,60L,34L,38L,127L,72L,120L,66L,112L,80L,96L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178910Inst : IEnumerable<long>
{
public static readonly long[] Value=A178910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178910.Bytes);
public long this[int i]=>Value[i];

public static A178910Inst Instance=new A178910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178911
{
public static readonly long[] Value={ 1L,6L,120L,198L,3696L,6240L,32640L,56160L,1941408L,3592200L,8119800L,15628032L,27125280L,59032080L,61788240L,125859840L,1635834720L,2147450880L,3709081680L,16328199552L,26198072160L,52344970080L,52396088160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178911Inst : IEnumerable<long>
{
public static readonly long[] Value=A178911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178911.Bytes);
public long this[int i]=>Value[i];

public static A178911Inst Instance=new A178911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178912
{
public static readonly long[] Value={ 9L,0L,240L,1380L,4578L,10794L,19494L,27912L,32195L,30085L,22748L,13820L,6656L,2486L,695L,137L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178912Inst : IEnumerable<long>
{
public static readonly long[] Value=A178912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178912.Bytes);
public long this[int i]=>Value[i];

public static A178912Inst Instance=new A178912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178913
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,5L,2L,6L,1L,9L,3L,11L,4L,11L,5L,13L,5L,17L,6L,17L,8L,21L,7L,21L,9L,23L,10L,27L,8L,29L,12L,28L,13L,31L,12L,33L,17L,36L,15L,38L,13L,41L,18L,40L,19L,45L,18L,46L,20L,46L,20L,51L,22L,52L,21L,53L,26L,56L,24L,58L,27L,57L,27L,59L,27L,64L,29L,65L,30L,69L,28L,70L,34L,69L,33L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178913Inst : IEnumerable<long>
{
public static readonly long[] Value=A178913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178913.Bytes);
public long this[int i]=>Value[i];

public static A178913Inst Instance=new A178913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178914
{
public static readonly long[] Value={ 10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,90L,89L,88L,87L,86L,85L,84L,83L,82L,81L,80L,79L,78L,77L,76L,75L,74L,73L,72L,71L,70L,69L,68L,67L,66L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178914Inst : IEnumerable<long>
{
public static readonly long[] Value=A178914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178914.Bytes);
public long this[int i]=>Value[i];

public static A178914Inst Instance=new A178914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178915
{
public static readonly long[] Value={ 4L,2L,3L,1L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178915Inst : IEnumerable<long>
{
public static readonly long[] Value=A178915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178915.Bytes);
public long this[int i]=>Value[i];

public static A178915Inst Instance=new A178915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178916
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,5L,5L,1L,1L,7L,1L,7L,7L,1L,7L,7L,1L,7L,7L,7L,11L,11L,1L,1L,19L,1L,1L,23L,11L,17L,1L,11L,1L,1L,11L,17L,29L,1L,1L,13L,1L,13L,1L,29L,11L,29L,1L,13L,1L,11L,11L,1L,1L,17L,1L,13L,17L,29L,1L,47L,13L,1L,13L,19L,17L,29L,1L,17L,59L,1L,1L,29L,1L,41L,29L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178916Inst : IEnumerable<long>
{
public static readonly long[] Value=A178916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178916.Bytes);
public long this[int i]=>Value[i];

public static A178916Inst Instance=new A178916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178917
{
public static readonly long[] Value={ 89L,97L,359L,367L,389L,397L,449L,457L,479L,487L,719L,727L,929L,937L,1069L,1087L,1109L,1117L,1259L,1277L,1439L,1447L,1559L,1567L,1759L,1777L,1979L,1987L,2459L,2467L,2609L,2617L,2699L,2707L,2879L,2887L,2909L,2917L,3209L,3217L,3449L,3457L,3719L,3727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178917Inst : IEnumerable<long>
{
public static readonly long[] Value=A178917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178917.Bytes);
public long this[int i]=>Value[i];

public static A178917Inst Instance=new A178917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178918
{
public static readonly long[] Value={ 8L,44L,63L,80L,116L,152L,188L,207L,224L,260L,296L,332L,351L,368L,404L,440L,476L,495L,512L,548L,575L,584L,620L,624L,639L,656L,692L,728L,764L,783L,800L,836L,872L,908L,927L,944L,980L,1016L,1024L,1052L,1071L,1088L,1124L,1160L,1196L,1215L,1224L,1232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178918Inst : IEnumerable<long>
{
public static readonly long[] Value=A178918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178918.Bytes);
public long this[int i]=>Value[i];

public static A178918Inst Instance=new A178918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178919
{
public static readonly long[] Value={ 2223L,5823L,9423L,13023L,16623L,20223L,23823L,27423L,31023L,32975L,34623L,38223L,41823L,45423L,49023L,52623L,56223L,59823L,63423L,67023L,70623L,74223L,77075L,77823L,81423L,85023L,88623L,92223L,95823L,99423L,103023L,106623L,110223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178919Inst : IEnumerable<long>
{
public static readonly long[] Value=A178919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178919.Bytes);
public long this[int i]=>Value[i];

public static A178919Inst Instance=new A178919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178920
{
public static readonly BigInteger[] Value={ 1L,4L,39L,616L,13445L,374976L,12738523L,510366592L,23561390889L,1231594508800L,71902556218031L,4637321353737216L,327439395476545261L,BigInteger.Parse("25123251004703358976"),BigInteger.Parse("2081326422827575699875") };
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
public class A178920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178920Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178920.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178920Inst Instance=new A178920Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178921
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,5L,2L,0L,0L,1L,0L,3L,4L,9L,0L,1L,0L,11L,0L,5L,0L,2L,0L,0L,8L,15L,2L,1L,0L,17L,10L,3L,0L,4L,0L,9L,2L,21L,0L,1L,0L,3L,14L,11L,0L,1L,6L,5L,16L,27L,0L,2L,0L,29L,4L,0L,8L,8L,0L,15L,20L,6L,0L,1L,0L,35L,2L,17L,4L,10L,0L,3L,0L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178921Inst : IEnumerable<long>
{
public static readonly long[] Value=A178921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178921.Bytes);
public long this[int i]=>Value[i];

public static A178921Inst Instance=new A178921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178922
{
public static readonly BigInteger[] Value={ 1L,7L,55L,561L,7151L,109873L,1979503L,40949569L,956953279L,24937424601L,717070946087L,22555076751793L,770416688131663L,28399211252136481L,1123728578581456351L,BigInteger.Parse("47508270371060021505"),BigInteger.Parse("2137250367863029663487") };
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
public class A178922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178922Inst Instance=new A178922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178923
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,2L,6L,0L,0L,0L,2L,18L,0L,0L,0L,0L,2L,42L,24L,0L,0L,0L,0L,2L,90L,144L,0L,0L,0L,0L,0L,2L,186L,600L,120L,0L,0L,0L,0L,0L,2L,378L,2160L,1200L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178923Inst : IEnumerable<long>
{
public static readonly long[] Value=A178923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178923.Bytes);
public long this[int i]=>Value[i];

public static A178923Inst Instance=new A178923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178924
{
public static readonly long[] Value={ 0L,1L,2L,5L,6L,23L,16L,89L,106L,267L,364L,1741L,526L,5135L,9360L,17681L,16914L,99347L,71188L,404501L,372758L,892951L,1763352L,7720985L,2809882L,17154075L,34201628L,82821149L,83623966L,435683359L,189300768L,1452343329L,1695678498L,4418961443L,8835694628L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178924Inst : IEnumerable<long>
{
public static readonly long[] Value=A178924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178924.Bytes);
public long this[int i]=>Value[i];

public static A178924Inst Instance=new A178924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178925
{
public static readonly long[] Value={ 1L,2L,4L,11L,32L,146L,934L,10624L,223629L,9444562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178925Inst : IEnumerable<long>
{
public static readonly long[] Value=A178925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178925.Bytes);
public long this[int i]=>Value[i];

public static A178925Inst Instance=new A178925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178926
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,4L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,2L,0L,0L,2L,4L,0L,2L,0L,0L,0L,0L,0L,0L,6L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178926Inst : IEnumerable<long>
{
public static readonly long[] Value=A178926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178926.Bytes);
public long this[int i]=>Value[i];

public static A178926Inst Instance=new A178926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178927
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,5L,6L,8L,11L,15L,19L,26L,32L,42L,54L,69L,86L,111L,137L,173L,215L,268L,329L,409L,499L,614L,748L,914L,1106L,1346L,1621L,1958L,2352L,2827L,3380L,4048L,4821L,5746L,6824L,8102L,9587L,11346L,13383L,15781L,18566L,21824L,25597L,30007L,35100L,41029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178927Inst : IEnumerable<long>
{
public static readonly long[] Value=A178927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178927.Bytes);
public long this[int i]=>Value[i];

public static A178927Inst Instance=new A178927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178928
{
public static readonly BigInteger[] Value={ 10L,121L,123L,1234L,123451L,1234561L,1234567L,123456782L,12345678911L,123456789101L,123456789101117L,12345678910111229L,123456789101112133L,BigInteger.Parse("123456789101112131414"),BigInteger.Parse("1234567891011121314159") };
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
public class A178928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178928Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178928.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178928Inst Instance=new A178928Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178929
{
public static readonly long[] Value={ 14979L,19167L,19497L,19839L,20247L,20499L,21657L,21864L,22185L,22227L,22329L,25299L,25755L,26325L,28344L,28665L,29643L,32184L,32319L,32418L,32724L,32889L,34194L,34692L,35265L,35853L,36489L,36957L,39588L,41754L,42327L,42564L,42723L,43476L,43656L,44382L,44445L,44997L,45714L,45765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178929Inst : IEnumerable<long>
{
public static readonly long[] Value=A178929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178929.Bytes);
public long this[int i]=>Value[i];

public static A178929Inst Instance=new A178929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178930
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,2L,3L,5L,3L,4L,8L,4L,5L,8L,7L,8L,11L,10L,11L,12L,13L,15L,19L,16L,21L,24L,21L,24L,32L,27L,34L,43L,37L,39L,53L,47L,54L,65L,65L,68L,79L,80L,90L,98L,102L,114L,129L,122L,138L,160L,157L,172L,207L,193L,211L,247L,244L,262L,306L,305L,329L,363L,378L,399L,448L,460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178930Inst : IEnumerable<long>
{
public static readonly long[] Value=A178930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178930.Bytes);
public long this[int i]=>Value[i];

public static A178930Inst Instance=new A178930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178931
{
public static readonly long[] Value={ 2L,6L,8L,11L,16L,18L,23L,24L,26L,33L,34L,35L,38L,48L,49L,50L,52L,54L,56L,69L,71L,72L,73L,74L,77L,78L,80L,83L,99L,102L,103L,105L,106L,107L,109L,110L,114L,115L,116L,119L,124L,144L,147L,148L,150L,152L,154L,156L,157L,158L,160L,162L,163L,164L,168L,170L,172L,173L,178L,185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178931Inst : IEnumerable<long>
{
public static readonly long[] Value=A178931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178931.Bytes);
public long this[int i]=>Value[i];

public static A178931Inst Instance=new A178931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178932
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,5L,6L,6L,9L,11L,11L,15L,19L,18L,26L,29L,32L,38L,48L,47L,62L,68L,79L,89L,108L,110L,135L,152L,166L,191L,223L,237L,275L,306L,345L,380L,429L,472L,537L,588L,650L,721L,808L,902L,972L,1083L,1205L,1316L,1450L,1617L,1742L,1919L,2130L,2312L,2531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178932Inst : IEnumerable<long>
{
public static readonly long[] Value=A178932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178932.Bytes);
public long this[int i]=>Value[i];

public static A178932Inst Instance=new A178932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178933
{
public static readonly long[] Value={ 1L,1L,14L,35L,205L,521L,2507L,6709L,26712L,73834L,262431L,724537L,2384988L,6552033L,20289864L,55244988L,163342701L,439201501L,1251532060L,3321188863L,9177476977L,24028568664L,64709650590L,167153761523L,440300702427L,1122562426240L,2900254892900L,7301575351055L,18544013542057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178933Inst : IEnumerable<long>
{
public static readonly long[] Value=A178933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178933.Bytes);
public long this[int i]=>Value[i];

public static A178933Inst Instance=new A178933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178934
{
public static readonly long[] Value={ 1L,3L,13L,49L,186L,711L,2749L,10705L,41946L,165159L,652765L,2587441L,10278906L,40903047L,162974461L,649984657L,2594199066L,10359577575L,41386654237L,165391648753L,661101690426L,2643012047943L,10567864050493L,42258903778129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178934Inst : IEnumerable<long>
{
public static readonly long[] Value=A178934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178934.Bytes);
public long this[int i]=>Value[i];

public static A178934Inst Instance=new A178934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178935
{
public static readonly long[] Value={ 0L,1L,6L,27L,121L,517L,2166L,8955L,36697L,149413L,605526L,2445723L,9853753L,39627589L,159148086L,638505531L,2559761689L,10256265445L,41076717846L,164461839579L,658312262905L,2634643765381L,10542759202806L,42183589235067L,168772014211801L,675201028661797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178935Inst : IEnumerable<long>
{
public static readonly long[] Value=A178935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178935.Bytes);
public long this[int i]=>Value[i];

public static A178935Inst Instance=new A178935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178936
{
public static readonly long[] Value={ 1L,2L,6L,15L,42L,116L,330L,951L,2778L,8180L,24234L,72087L,215034L,642644L,1923018L,5759223L,17258010L,51734708L,155125482L,465219159L,1395342906L,4185399572L,12554940426L,37662304695L,112981880922L,338935576436L,1016786596650L,3050319524631L,9150878043258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178936Inst : IEnumerable<long>
{
public static readonly long[] Value=A178936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178936.Bytes);
public long this[int i]=>Value[i];

public static A178936Inst Instance=new A178936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178937
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,20L,35L,58L,101L,172L,300L,509L,888L,1538L,2683L,4611L,8033L,13941L,24236L,41766L,72504L,125592L,217563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178937Inst : IEnumerable<long>
{
public static readonly long[] Value=A178937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178937.Bytes);
public long this[int i]=>Value[i];

public static A178937Inst Instance=new A178937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178938
{
public static readonly long[] Value={ 1L,2L,4L,3L,4L,8L,18L,16L,5L,9L,8L,18L,16L,9L,7L,16L,15L,21L,16L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178938Inst : IEnumerable<long>
{
public static readonly long[] Value=A178938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178938.Bytes);
public long this[int i]=>Value[i];

public static A178938Inst Instance=new A178938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178939
{
public static readonly long[] Value={ 1L,1L,4L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178939Inst : IEnumerable<long>
{
public static readonly long[] Value=A178939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178939.Bytes);
public long this[int i]=>Value[i];

public static A178939Inst Instance=new A178939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178940
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,18L,27L,50L,79L,138L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178940Inst : IEnumerable<long>
{
public static readonly long[] Value=A178940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178940.Bytes);
public long this[int i]=>Value[i];

public static A178940Inst Instance=new A178940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178941
{
public static readonly long[] Value={ 1L,3L,7L,17L,37L,85L,181L,399L,841L,1805L,3757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178941Inst : IEnumerable<long>
{
public static readonly long[] Value=A178941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178941.Bytes);
public long this[int i]=>Value[i];

public static A178941Inst Instance=new A178941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178942
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,29L,37L,47L,53L,61L,67L,71L,79L,83L,131L,137L,151L,163L,173L,233L,277L,331L,359L,379L,397L,401L,419L,439L,773L,823L,941L,947L,1021L,1031L,1033L,1063L,1087L,1097L,1117L,1123L,1153L,1187L,1237L,1277L,1709L,1789L,1823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178942Inst : IEnumerable<long>
{
public static readonly long[] Value=A178942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178942.Bytes);
public long this[int i]=>Value[i];

public static A178942Inst Instance=new A178942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178943
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,163L,167L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,269L,271L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178943Inst : IEnumerable<long>
{
public static readonly long[] Value=A178943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178943.Bytes);
public long this[int i]=>Value[i];

public static A178943Inst Instance=new A178943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178944
{
public static readonly long[] Value={ 1L,2L,4L,11L,34L,156L,1044L,12346L,274646L,12005070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178944Inst : IEnumerable<long>
{
public static readonly long[] Value=A178944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178944.Bytes);
public long this[int i]=>Value[i];

public static A178944Inst Instance=new A178944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178945
{
public static readonly long[] Value={ 1L,2L,7L,16L,42L,96L,228L,512L,1160L,2560L,5648L,12288L,26656L,57344L,122944L,262144L,557184L,1179648L,2490624L,5242880L,11010560L,23068672L,48235520L,100663296L,209717248L,436207616L,905973760L,1879048192L,3892322304L,8053063680L,16643014656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178945Inst : IEnumerable<long>
{
public static readonly long[] Value=A178945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178945.Bytes);
public long this[int i]=>Value[i];

public static A178945Inst Instance=new A178945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178946
{
public static readonly long[] Value={ 1L,3L,11L,22L,45L,73L,119L,172L,249L,335L,451L,578L,741L,917L,1135L,1368L,1649L,1947L,2299L,2670L,3101L,3553L,4071L,4612L,5225L,5863L,6579L,7322L,8149L,9005L,9951L,10928L,12001L,13107L,14315L,15558L,16909L,18297L,19799L,21340L,23001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178946Inst : IEnumerable<long>
{
public static readonly long[] Value=A178946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178946.Bytes);
public long this[int i]=>Value[i];

public static A178946Inst Instance=new A178946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178947
{
public static readonly long[] Value={ 1L,4L,17L,38L,81L,138L,229L,340L,497L,680L,921L,1194L,1537L,1918L,2381L,2888L,3489L,4140L,4897L,5710L,6641L,7634L,8757L,9948L,11281L,12688L,14249L,15890L,17697L,19590L,21661L,23824L,26177L,28628L,31281L,34038L,37009L,40090L,43397L,46820L,50481L,54264L,58297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178947Inst : IEnumerable<long>
{
public static readonly long[] Value=A178947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178947.Bytes);
public long this[int i]=>Value[i];

public static A178947Inst Instance=new A178947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178948
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,0L,-1L,0L,-1L,1L,-1L,0L,-1L,0L,-1L,1L,-1L,0L,-1L,0L,-1L,2L,-1L,0L,-1L,2L,-1L,1L,-1L,0L,-1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,2L,-1L,0L,-1L,0L,-1L,1L,-1L,0L,-1L,1L,-1L,2L,-1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,3L,-1L,0L,-1L,0L,-1L,1L,-1L,1L,-1L,0L,-1L,3L,-1L,0L,-1L,1L,-1L,1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178948Inst : IEnumerable<long>
{
public static readonly long[] Value=A178948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178948.Bytes);
public long this[int i]=>Value[i];

public static A178948Inst Instance=new A178948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178949
{
public static readonly BigInteger[] Value={ 1L,2L,36L,1920L,210000L,39191040L,11181360960L,4534378168320L,2481970620729600L,1764322560000000000L,BigInteger.Parse("1580868516481859404800"),BigInteger.Parse("1743505552795995891302400"),BigInteger.Parse("2321376488366363008816435200"),BigInteger.Parse("3671767205084150828189614080000") };
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
public class A178949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178949Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178949.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178949Inst Instance=new A178949Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178950
{
public static readonly long[] Value={ 1L,6L,8L,14L,16L,21L,27L,29L,48L,49L,52L,55L,57L,60L,61L,65L,85L,86L,90L,95L,96L,112L,117L,120L,121L,122L,123L,124L,135L,145L,153L,169L,179L,181L,186L,191L,213L,214L,215L,216L,238L,255L,256L,257L,258L,259L,260L,263L,267L,274L,275L,281L,288L,324L,325L,340L,343L,345L,354L,355L,356L,357L,359L,366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178950Inst : IEnumerable<long>
{
public static readonly long[] Value=A178950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178950.Bytes);
public long this[int i]=>Value[i];

public static A178950Inst Instance=new A178950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178951
{
public static readonly long[] Value={ 49L,61L,86L,96L,121L,122L,123L,124L,214L,215L,216L,256L,257L,258L,259L,260L,275L,325L,355L,356L,357L,412L,518L,519L,545L,546L,547L,588L,589L,771L,772L,773L,774L,775L,776L,777L,778L,779L,780L,827L,833L,840L,904L,905L,906L,982L,983L,984L,1176L,1177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178951Inst : IEnumerable<long>
{
public static readonly long[] Value=A178951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178951.Bytes);
public long this[int i]=>Value[i];

public static A178951Inst Instance=new A178951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178952
{
public static readonly long[] Value={ 0L,1L,1L,0L,3L,0L,0L,3L,3L,0L,1L,4L,0L,4L,1L,0L,6L,0L,0L,6L,0L,0L,6L,3L,0L,3L,6L,0L,1L,7L,0L,4L,4L,0L,7L,1L,0L,9L,0L,0L,9L,0L,0L,9L,0L,0L,9L,3L,0L,6L,6L,0L,3L,9L,0L,1L,10L,0L,4L,7L,0L,7L,4L,0L,10L,1L,0L,12L,0L,0L,12L,0L,0L,12L,0L,0L,12L,0L,0L,12L,3L,0L,9L,6L,0L,6L,9L,0L,3L,12L,0L,1L,13L,0L,4L,10L,0L,7L,7L,0L,10L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178952Inst : IEnumerable<long>
{
public static readonly long[] Value=A178952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178952.Bytes);
public long this[int i]=>Value[i];

public static A178952Inst Instance=new A178952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178953
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,14L,15L,21L,22L,29L,30L,35L,38L,46L,48L,49L,50L,52L,53L,57L,58L,60L,61L,62L,65L,66L,90L,91L,95L,96L,97L,99L,114L,120L,121L,122L,123L,124L,125L,128L,145L,146L,149L,153L,154L,163L,176L,179L,180L,186L,187L,189L,191L,192L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178953Inst : IEnumerable<long>
{
public static readonly long[] Value=A178953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178953.Bytes);
public long this[int i]=>Value[i];

public static A178953Inst Instance=new A178953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178954
{
public static readonly long[] Value={ 2L,3L,7L,19L,23L,43L,47L,73L,79L,109L,113L,149L,163L,199L,223L,227L,229L,239L,241L,269L,271L,281L,283L,293L,313L,317L,463L,467L,499L,503L,509L,523L,619L,659L,661L,673L,677L,683L,691L,719L,829L,839L,859L,883L,887L,967L,1049L,1063L,1069L,1109L,1117L,1129L,1153L,1163L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178954Inst : IEnumerable<long>
{
public static readonly long[] Value=A178954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178954.Bytes);
public long this[int i]=>Value[i];

public static A178954Inst Instance=new A178954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178955
{
public static readonly BigInteger[] Value={ 1L,-1L,0L,1L,2L,-2L,-28L,-65L,338L,3262L,4352L,-113082L,-879140L,1145012L,68641120L,409571279L,-3075414734L,-67796919090L,-235926569056L,6635196777226L,98653814115636L,-51631812077716L,-17882630766156440L,-190179698567684014L,1532579370407751292L,BigInteger.Parse("62028205219536446948"),BigInteger.Parse("405883930741148425152"),BigInteger.Parse("-11224575706163698420700"),BigInteger.Parse("-269584771812788695251352"),BigInteger.Parse("-338220005828087037972744") };
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
public class A178955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178955Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178955.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178955Inst Instance=new A178955Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178956
{
public static readonly BigInteger[] Value={ 1L,-1L,0L,1L,1L,-1L,-7L,-13L,169L,233L,17L,-18847L,-43957L,26023L,429007L,31505483L,-31381783L,-753299101L,-7372705283L,195152846389L,632396244331L,-52258919107L,-447065769153911L,-13584264183406001L,34831349327448893L,674219621951483119L,2113978805943481381L,-6602691591860999071L,BigInteger.Parse("-370308752490094361609"),BigInteger.Parse("-95867348590727618473"),BigInteger.Parse("752151788353653780085507") };
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
public class A178956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178956Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178956.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178956Inst Instance=new A178956Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178957
{
public static readonly BigInteger[] Value={ 1L,1L,1L,6L,12L,60L,180L,1008L,20160L,25920L,14175L,6652800L,23950080L,141523200L,544864320L,100590336000L,213497856000L,3952082534400L,200074178304000L,3577797070848000L,15595525693440000L,51711479930880000L,BigInteger.Parse("28100018194440192000"),BigInteger.Parse("1846572624206069760000"),BigInteger.Parse("14101100039391805440000"),BigInteger.Parse("168600109166641152000000"),BigInteger.Parse("2100476360034404352000000"),BigInteger.Parse("6405217323775501271040000"),BigInteger.Parse("418802671169936621568000000"),BigInteger.Parse("2506168365572477878272000000"),BigInteger.Parse("2368329105465991594967040000000") };
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
public class A178957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178957Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178957.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178957Inst Instance=new A178957Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178958
{
public static readonly long[] Value={ 15L,28L,35L,39L,51L,52L,55L,63L,66L,70L,75L,76L,87L,95L,99L,111L,112L,115L,119L,123L,124L,130L,135L,143L,147L,148L,154L,155L,159L,171L,172L,176L,183L,186L,187L,190L,195L,196L,203L,207L,208L,215L,219L,232L,235L,238L,244L,246L,255L,267L,268L,275L,276L,279L,280L,286L,287L,291L,292L,295L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178958Inst : IEnumerable<long>
{
public static readonly long[] Value=A178958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178958.Bytes);
public long this[int i]=>Value[i];

public static A178958Inst Instance=new A178958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178959
{
public static readonly long[] Value={ 6L,5L,2L,7L,0L,3L,6L,4L,4L,6L,6L,6L,1L,3L,9L,3L,0L,2L,2L,9L,6L,5L,6L,6L,7L,4L,6L,4L,6L,1L,3L,7L,0L,4L,0L,7L,9L,9L,9L,2L,4L,8L,6L,4L,5L,6L,3L,1L,8L,6L,1L,2L,2L,5L,5L,2L,7L,5L,1L,7L,2L,4L,3L,7L,3L,5L,8L,6L,8L,3L,5L,5L,7L,2L,1L,9L,7L,0L,5L,2L,9L,1L,5L,6L,9L,6L,6L,7L,7L,3L,6L,8L,5L,2L,0L,0L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178959Inst : IEnumerable<long>
{
public static readonly long[] Value=A178959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178959.Bytes);
public long this[int i]=>Value[i];

public static A178959Inst Instance=new A178959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178960
{
public static readonly long[] Value={ 23L,27L,31L,33L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178960Inst : IEnumerable<long>
{
public static readonly long[] Value=A178960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178960.Bytes);
public long this[int i]=>Value[i];

public static A178960Inst Instance=new A178960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178961
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,23L,41L,61L,117L,165L,343L,475L,1049L,1397L,3267L,4275L,10419L,13231L,33545L,41965L,109499L,133895L,359367L,434123L,1189795L,1412351L,3952757L,4646449L,13211071L,15318819L,44260077L,50916453L,148927917L,169476849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178961Inst : IEnumerable<long>
{
public static readonly long[] Value=A178961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178961.Bytes);
public long this[int i]=>Value[i];

public static A178961Inst Instance=new A178961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178962
{
public static readonly BigInteger[] Value={ 1L,7L,46L,366L,3647L,44205L,630956L,10350572L,191704349L,3954598099L,89888942874L,2231742720730L,60083847852539L,1743321481158041L,54226970410827160L,1800062257926566488L,BigInteger.Parse("63512168752599139129"),BigInteger.Parse("2373501269897667585631") };
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
public class A178962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178962Inst Instance=new A178962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178963
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,3L,9L,19L,99L,477L,1513L,11259L,74601L,315523L,3052323L,25740261L,136085041L,1620265923L,16591655817L,105261234643L,1488257158851L,17929265150637L,132705221399353L,2172534146099019L,30098784753112329L,254604707462013571L,4736552519729393091L,BigInteger.Parse("74180579084559895221"),BigInteger.Parse("705927677520644167681"),BigInteger.Parse("14708695606607601165843"),BigInteger.Parse("256937013876000351610089"),BigInteger.Parse("2716778010767155313771539") };
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
public class A178963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178963Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178963.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178963Inst Instance=new A178963Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178964
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,4L,14L,34L,69L,496L,2896L,11056L,33661L,349504L,2856944L,14873104L,60376809L,819786496L,8615785216L,56814228736L,288294050521L,4835447317504L,62112775514624L,495812444583424L,3019098162602349L,60283564499562496L,915153344223809536L,8575634961418940416L,BigInteger.Parse("60921822444067346581"),BigInteger.Parse("1411083019275488149504"),BigInteger.Parse("24716980773496372066304") };
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
public class A178964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178964Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178964.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178964Inst Instance=new A178964Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178965
{
public static readonly long[] Value={ 0L,1L,5L,15L,43L,103L,263L,591L,1391L,3103L,7007L,15039L,33983L,72063L,156543L,334591L,722687L,1510911L,3255807L,6773759L,14433279L,30193663L,63535103L,131264511L,278589439L,575004671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178965Inst : IEnumerable<long>
{
public static readonly long[] Value=A178965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178965.Bytes);
public long this[int i]=>Value[i];

public static A178965Inst Instance=new A178965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178966
{
public static readonly BigInteger[] Value={ 3L,68491L,1472837L,20933977L,115763405909L,BigInteger.Parse("860612330076805920786264707"),BigInteger.Parse("295312333859267885313149356219"),BigInteger.Parse("3030645565448009172324576658633624992466799"),BigInteger.Parse("1438089684181622246462815859549895702132195129054882453928357949021844283495791173") };
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
public class A178966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178966Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178966.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178966Inst Instance=new A178966Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178967
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,248L,7320L,82758L,562384L,2756122L,10771928L,35504296L,102677536L,267284836L,638673432L,1420555842L,2974232240L,5911536526L,11232560320L,20516606128L,36191817440L,61893239340L,102950022616L,167010533830L,264869097472L,411497661102L,627378473416L,940130628920L,1386570370640L,2015178519904L,2889176379864L,4090150245318L,5722507236712L,7918655437366L,10845295301648L,14710646654420L,19773136732920L,26351274869008L,34835414789584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178967Inst : IEnumerable<long>
{
public static readonly long[] Value=A178967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178967.Bytes);
public long this[int i]=>Value[i];

public static A178967Inst Instance=new A178967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178968
{
public static readonly long[] Value={ 8L,13L,17L,22L,24L,26L,29L,31L,35L,42L,44L,46L,49L,53L,57L,62L,64L,66L,69L,71L,75L,80L,92L,94L,96L,99L,103L,107L,112L,114L,116L,119L,121L,125L,130L,141L,145L,152L,154L,156L,159L,161L,165L,170L,191L,195L,202L,204L,206L,209L,211L,215L,220L,240L,251L,255L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178968Inst : IEnumerable<long>
{
public static readonly long[] Value=A178968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178968.Bytes);
public long this[int i]=>Value[i];

public static A178968Inst Instance=new A178968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178969
{
public static readonly long[] Value={ 8L,2L,6L,4L,2L,2L,6L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178969Inst : IEnumerable<long>
{
public static readonly long[] Value=A178969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178969.Bytes);
public long this[int i]=>Value[i];

public static A178969Inst Instance=new A178969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178970
{
public static readonly long[] Value={ 2L,3L,4L,2L,6L,7L,2L,9L,10L,2L,12L,8L,20L,15L,16L,2L,22L,19L,2L,21L,22L,38L,24L,32L,2L,27L,52L,2L,30L,31L,2L,8L,34L,2L,36L,37L,17L,43L,40L,20L,42L,8L,2L,45L,32L,2L,27L,49L,29L,51L,52L,23L,54L,55L,2L,57L,77L,11L,15L,28L,2L,108L,64L,2L,66L,32L,47L,69L,70L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178970Inst : IEnumerable<long>
{
public static readonly long[] Value=A178970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178970.Bytes);
public long this[int i]=>Value[i];

public static A178970Inst Instance=new A178970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178971
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,10L,12L,15L,24L,25L,35L,37L,46L,51L,53L,75L,98L,112L,115L,172L,251L,271L,329L,500L,1158L,1330L,1430L,2034L,3121L,4795L,4802L,4816L,5185L,7407L,17690L,18236L,19140L,42613L,46126L,66325L,161209L,217506L,252191L,966512L,997515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178971Inst : IEnumerable<long>
{
public static readonly long[] Value=A178971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178971.Bytes);
public long this[int i]=>Value[i];

public static A178971Inst Instance=new A178971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178972
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,144L,392L,896L,1620L,2800L,4356L,6624L,9464L,13328L,18000L,24064L,31212L,40176L,50540L,63200L,77616L,94864L,114264L,137088L,162500L,191984L,224532L,261856L,302760L,349200L,399776L,456704L,518364L,587248L,661500L,743904L,832352L,929936L,1034280L,1148800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178972Inst : IEnumerable<long>
{
public static readonly long[] Value=A178972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178972.Bytes);
public long this[int i]=>Value[i];

public static A178972Inst Instance=new A178972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178973
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,588L,3328L,9720L,27600L,59048L,124992L,226460L,408464L,666900L,1086464L,1650768L,2505168L,3610000L,5198400L,7191828L,9945232L,13320220L,17835264L,23265000L,30341584L,38718648L,49401408L,61880780L,77504400L,95550308L,117788672L,143225280L,174144464L,209210400L,251325504L,298732228L,355068048L,418062060L,492217600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178973Inst : IEnumerable<long>
{
public static readonly long[] Value=A178973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178973.Bytes);
public long this[int i]=>Value[i];

public static A178973Inst Instance=new A178973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178974
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,98L,3328L,17496L,99600L,316052L,1041408L,2501538L,6157536L,12531150L,25938944L,47168268L,86938272L,145818008L,247240000L,390084786L,620964256L,933865918L,1414946304L,2047225000L,2980849040L,4177648224L,5886858432L,8032809818L,11012886000L,14689386642L,19674427392L,25732782504L,33779841296L,43433208000L,56027023488L,70963952198L,90145026976L,112667956362L,141187744000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178974Inst : IEnumerable<long>
{
public static readonly long[] Value=A178974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178974.Bytes);
public long this[int i]=>Value[i];

public static A178974Inst Instance=new A178974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178975
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,640L,7290L,123640L,640574L,3869280L,12950132L,47022360L,123467040L,340840960L,759697190L,1758672648L,3494388306L,7150739360L,13041285516L,24354594440L,41566378136L,72345297024L,117101090250L,192694385416L,298703838186L,469581881888L,702148696580L,1062719841960L,1541332566284L,2259300468736L,3192255589842L,4552716843720L,6288527141890L,8758324830240L,11859789616944L,16178716174856L,21527161542900L,28834708173440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178975Inst : IEnumerable<long>
{
public static readonly long[] Value=A178975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178975.Bytes);
public long this[int i]=>Value[i];

public static A178975Inst Instance=new A178975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178976
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,4L,4L,4L,5L,5L,5L,6L,8L,11L,11L,12L,12L,12L,14L,14L,14L,16L,18L,20L,22L,24L,26L,29L,29L,29L,30L,31L,32L,35L,35L,35L,37L,38L,40L,43L,43L,45L,46L,50L,51L,52L,55L,55L,57L,57L,59L,61L,63L,65L,69L,69L,74L,74L,74L,76L,77L,78L,81L,82L,82L,86L,89L,91L,93L,96L,99L,100L,104L,105L,106L,107L,108L,112L,113L,115L,115L,117L,121L,122L,122L,124L,124L,125L,126L,131L,133L,134L,137L,139L,141L,146L,148L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178976Inst : IEnumerable<long>
{
public static readonly long[] Value=A178976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178976.Bytes);
public long this[int i]=>Value[i];

public static A178976Inst Instance=new A178976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178977
{
public static readonly long[] Value={ 5L,20L,44L,77L,119L,170L,230L,299L,377L,464L,560L,665L,779L,902L,1034L,1175L,1325L,1484L,1652L,1829L,2015L,2210L,2414L,2627L,2849L,3080L,3320L,3569L,3827L,4094L,4370L,4655L,4949L,5252L,5564L,5885L,6215L,6554L,6902L,7259L,7625L,8000L,8384L,8777L,9179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178977Inst : IEnumerable<long>
{
public static readonly long[] Value=A178977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178977.Bytes);
public long this[int i]=>Value[i];

public static A178977Inst Instance=new A178977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178978
{
public static readonly long[] Value={ 0L,2L,5L,1L,14L,20L,1L,35L,44L,2L,65L,77L,10L,104L,119L,5L,152L,170L,7L,209L,230L,28L,275L,299L,4L,350L,377L,5L,434L,464L,55L,527L,560L,22L,629L,665L,26L,740L,779L,91L,860L,902L,35L,989L,1034L,40L,1127L,1175L,136L,1274L,1325L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178978Inst : IEnumerable<long>
{
public static readonly long[] Value=A178978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178978.Bytes);
public long this[int i]=>Value[i];

public static A178978Inst Instance=new A178978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178979
{
public static readonly long[] Value={ 1L,1L,1L,4L,0L,1L,11L,3L,0L,1L,41L,10L,0L,0L,1L,162L,30L,10L,0L,0L,1L,715L,126L,35L,0L,0L,0L,1L,3425L,623L,56L,35L,0L,0L,0L,1L,17722L,2934L,364L,126L,0L,0L,0L,0L,1L,98253L,15165L,2220L,210L,126L,0L,0L,0L,0L,1L,580317L,86900L,10560L,330L,462L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178979Inst : IEnumerable<long>
{
public static readonly long[] Value=A178979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178979.Bytes);
public long this[int i]=>Value[i];

public static A178979Inst Instance=new A178979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178980
{
public static readonly long[] Value={ 16L,18L,20L,22L,24L,26L,6374L,6376L,6378L,6380L,6450L,6452L,6454L,6456L,6458L,6460L,6572L,6574L,6576L,6578L,6580L,6582L,6588L,6590L,6596L,6682L,6684L,6924L,6926L,6928L,6934L,6936L,6958L,6960L,6966L,6974L,6976L,6990L,6994L,6998L,7012L,7014L,7016L,7018L,7020L,7048L,7050L,7052L,7056L,7330L,7332L,7374L,7376L,7404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178980Inst : IEnumerable<long>
{
public static readonly long[] Value=A178980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178980.Bytes);
public long this[int i]=>Value[i];

public static A178980Inst Instance=new A178980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178981
{
public static readonly long[] Value={ 2L,2L,4L,64L,4096L,1152921504606846976L,1152921504606846976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178981Inst : IEnumerable<long>
{
public static readonly long[] Value=A178981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178981.Bytes);
public long this[int i]=>Value[i];

public static A178981Inst Instance=new A178981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178982
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,4L,8L,14L,24L,41L,68L,112L,184L,300L,488L,793L,1286L,2084L,3376L,5466L,8848L,14321L,23176L,37504L,60688L,98200L,158896L,257105L,416010L,673124L,1089144L,1762278L,2851432L,4613721L,7465164L,12078896L,19544072L,31622980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178982Inst : IEnumerable<long>
{
public static readonly long[] Value=A178982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178982.Bytes);
public long this[int i]=>Value[i];

public static A178982Inst Instance=new A178982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178983
{
public static readonly long[] Value={ 0L,1L,27L,343L,64L,125L,64L,27L,8L,729L,1000L,91125L,125L,1331L,140608L,15625L,216L,1728L,85184L,2197L,205379L,216L,226981L,103823L,13824L,125L,9261L,27L,1728L,729L,39304L,1331L,5832L,1331L,343L,35937L,97336L,3375L,13824L,39304L,4096L,531441L,42875L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178983Inst : IEnumerable<long>
{
public static readonly long[] Value=A178983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178983.Bytes);
public long this[int i]=>Value[i];

public static A178983Inst Instance=new A178983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178984
{
public static readonly long[] Value={ 3L,3L,5L,3L,5L,3L,5L,7L,3L,7L,5L,3L,5L,7L,7L,3L,7L,5L,3L,7L,5L,7L,19L,5L,3L,5L,3L,5L,19L,5L,7L,3L,11L,3L,7L,7L,5L,7L,7L,3L,11L,3L,5L,3L,13L,13L,5L,3L,5L,7L,3L,11L,7L,7L,7L,3L,7L,5L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178984Inst : IEnumerable<long>
{
public static readonly long[] Value=A178984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178984.Bytes);
public long this[int i]=>Value[i];

public static A178984Inst Instance=new A178984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178985
{
public static readonly BigInteger[] Value={ 3L,19L,11L,227L,1019L,269201L,186023729L,457933343698297657L,BigInteger.Parse("2267602862220213494836920572800947269169358383491"),BigInteger.Parse("3510117420185552058703020362961660520827436011216742688744177") };
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
public class A178985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178985Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178985.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178985Inst Instance=new A178985Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178986
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,44L,0L,1092L,0L,0L,0L,16932L,0L,24776L,0L,0L,0L,1881492L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178986Inst : IEnumerable<long>
{
public static readonly long[] Value=A178986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178986.Bytes);
public long this[int i]=>Value[i];

public static A178986Inst Instance=new A178986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178987
{
public static readonly long[] Value={ 0L,-1L,-2L,0L,16L,80L,288L,896L,2560L,6912L,17920L,45056L,110592L,266240L,630784L,1474560L,3407872L,7798784L,17694720L,39845888L,89128960L,198180864L,438304768L,964689920L,2113929216L,4613734400L,10032775168L,21743271936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178987Inst : IEnumerable<long>
{
public static readonly long[] Value=A178987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178987.Bytes);
public long this[int i]=>Value[i];

public static A178987Inst Instance=new A178987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178988
{
public static readonly long[] Value={ 7L,5L,7L,5L,5L,2L,2L,1L,2L,8L,1L,0L,1L,1L,4L,9L,2L,9L,7L,6L,9L,2L,0L,8L,0L,5L,6L,3L,0L,6L,4L,4L,5L,8L,0L,9L,2L,7L,0L,3L,7L,5L,3L,2L,6L,1L,9L,3L,9L,2L,9L,2L,1L,4L,7L,5L,9L,1L,2L,9L,9L,2L,1L,3L,9L,5L,2L,4L,5L,6L,5L,1L,0L,6L,0L,2L,5L,9L,4L,9L,6L,8L,8L,5L,3L,3L,6L,9L,9L,2L,8L,4L,4L,4L,9L,8L,4L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178988Inst : IEnumerable<long>
{
public static readonly long[] Value=A178988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178988.Bytes);
public long this[int i]=>Value[i];

public static A178988Inst Instance=new A178988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178989
{
public static readonly BigInteger[] Value={ 1L,1L,14L,1128L,90942080L,57157560576L,67818988957718528L,BigInteger.Parse("115047995548743401472"),BigInteger.Parse("674758653138775267142795264"),BigInteger.Parse("40819609745761407890621234130376982528") };
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
public class A178989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178989Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178989.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178989Inst Instance=new A178989Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178990
{
public static readonly long[] Value={ 0L,1L,1L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1924L,1924L,0L,0L,0L,0L,19799L,68302L,19799L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3219407612L,25797991623L,25797991623L,3219407612L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178990Inst : IEnumerable<long>
{
public static readonly long[] Value=A178990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178990.Bytes);
public long this[int i]=>Value[i];

public static A178990Inst Instance=new A178990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178991
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,43L,59L,67L,313L,443L,449L,619L,991L,1051L,1601L,2143L,2593L,2609L,2753L,3169L,6829L,20749L,24917L,28661L,38447L,49393L,54323L,56873L,75029L,372121L,974177L,1346273L,1346333L,1718369L,1806209L,2178313L,2178373L,3524603L,3525019L,6683821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178991Inst : IEnumerable<long>
{
public static readonly long[] Value=A178991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178991.Bytes);
public long this[int i]=>Value[i];

public static A178991Inst Instance=new A178991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178992
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,10L,11L,13L,21L,22L,26L,27L,43L,45L,53L,54L,86L,90L,91L,107L,109L,173L,181L,182L,214L,218L,346L,347L,363L,365L,429L,437L,693L,694L,726L,730L,858L,859L,875L,1387L,1389L,1453L,1461L,1717L,1718L,1750L,2774L,2778L,2906L,2907L,2923L,3435L,3437L,3501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178992Inst : IEnumerable<long>
{
public static readonly long[] Value=A178992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178992.Bytes);
public long this[int i]=>Value[i];

public static A178992Inst Instance=new A178992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178993
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,7L,7L,8L,8L,6L,12L,12L,13L,15L,16L,16L,18L,18L,19L,17L,16L,20L,21L,18L,21L,25L,23L,26L,30L,30L,31L,28L,32L,34L,34L,36L,36L,38L,38L,39L,41L,41L,43L,43L,43L,42L,45L,41L,48L,46L,48L,50L,45L,52L,55L,55L,54L,48L,60L,56L,61L,56L,60L,64L,64L,66L,66L,61L,67L,66L,66L,68L,72L,66L,67L,76L,76L,72L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178993Inst : IEnumerable<long>
{
public static readonly long[] Value=A178993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178993.Bytes);
public long this[int i]=>Value[i];

public static A178993Inst Instance=new A178993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178994
{
public static readonly long[] Value={ 1L,2L,2L,2L,3L,2L,3L,4L,4L,3L,3L,4L,5L,4L,3L,3L,5L,6L,6L,5L,3L,3L,6L,6L,7L,6L,6L,3L,4L,6L,7L,8L,8L,7L,6L,4L,4L,7L,8L,8L,9L,8L,8L,7L,4L,4L,7L,8L,9L,10L,10L,9L,8L,7L,4L,5L,7L,9L,10L,11L,11L,11L,10L,9L,7L,5L,5L,7L,10L,11L,12L,12L,12L,12L,11L,10L,7L,5L,5L,8L,10L,11L,12L,12L,13L,12L,12L,11L,10L,8L,5L,5L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178994Inst : IEnumerable<long>
{
public static readonly long[] Value=A178994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178994.Bytes);
public long this[int i]=>Value[i];

public static A178994Inst Instance=new A178994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178995
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,20L,28L,62L,161L,204L,471L,505L,881L,1810L,1812L,2506L,3321L,6809L,9272L,15131L,17449L,25250L,27989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178995Inst : IEnumerable<long>
{
public static readonly long[] Value=A178995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178995.Bytes);
public long this[int i]=>Value[i];

public static A178995Inst Instance=new A178995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178996
{
public static readonly long[] Value={ 3L,10L,19L,24L,28L,61L,79L,96L,104L,125L,132L,191L,196L,243L,292L,302L,462L,466L,586L,621L,1508L,3307L,3823L,4729L,5370L,6721L,8110L,11145L,13502L,13762L,20266L,27868L,38522L,75470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178996Inst : IEnumerable<long>
{
public static readonly long[] Value=A178996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178996.Bytes);
public long this[int i]=>Value[i];

public static A178996Inst Instance=new A178996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178997
{
public static readonly long[] Value={ 294409L,1398101L,1549411L,1840357L,12599233L,13421773L,15162941L,15732721L,28717483L,29593159L,61377109L,66384121L,67763803L,74658629L,78526729L,90341197L,96916279L,109322501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178997Inst : IEnumerable<long>
{
public static readonly long[] Value=A178997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178997.Bytes);
public long this[int i]=>Value[i];

public static A178997Inst Instance=new A178997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178998
{
public static readonly BigInteger[] Value={ 7L,13L,119923L,146050183L,4039362385345521139L,BigInteger.Parse("289247481259011497824466400997481269"),BigInteger.Parse("1765256712749403700417549596608786383") };
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
public class A178998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178998Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A178998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178998.Bytes);
public BigInteger this[int i]=>Value[i];

public static A178998Inst Instance=new A178998Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A178999
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,22L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A178999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A178999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A178999Inst : IEnumerable<long>
{
public static readonly long[] Value=A178999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A178999.Bytes);
public long this[int i]=>Value[i];

public static A178999Inst Instance=new A178999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179000
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,6L,8L,4L,1L,8L,15L,12L,5L,1L,10L,24L,24L,16L,6L,1L,12L,35L,40L,33L,20L,7L,1L,14L,48L,60L,56L,42L,24L,8L,1L,16L,63L,84L,85L,72L,51L,28L,9L,1L,18L,80L,112L,120L,110L,88L,60L,32L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179000Inst : IEnumerable<long>
{
public static readonly long[] Value=A179000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179000.Bytes);
public long this[int i]=>Value[i];

public static A179000Inst Instance=new A179000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179001
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,8L,15L,26L,44L,73L,121L,198L,323L,526L,855L,1387L,2248L,3641L,5896L,9544L,15447L,24999L,40455L,65463L,105927L,171399L,277336L,448745L,726091L,1174847L,1900950L,3075809L,4976771L,8052592L,13029376L,21081981L,34111370L,55193365L,89304750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179001Inst : IEnumerable<long>
{
public static readonly long[] Value=A179001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179001.Bytes);
public long this[int i]=>Value[i];

public static A179001Inst Instance=new A179001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179002
{
public static readonly long[] Value={ 2L,7L,19L,31L,37L,43L,61L,67L,79L,97L,107L,109L,151L,157L,163L,199L,223L,241L,257L,269L,271L,307L,337L,349L,379L,409L,421L,433L,439L,523L,557L,577L,601L,613L,619L,631L,673L,691L,739L,757L,787L,811L,823L,853L,863L,877L,883L,919L,967L,991L,1009L,1051L,1061L,1063L,1117L,1153L,1181L,1213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179002Inst : IEnumerable<long>
{
public static readonly long[] Value=A179002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179002.Bytes);
public long this[int i]=>Value[i];

public static A179002Inst Instance=new A179002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179003
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,16L,18L,19L,25L,28L,30L,31L,34L,36L,37L,38L,43L,46L,49L,52L,55L,58L,61L,64L,67L,70L,78L,79L,87L,88L,91L,96L,97L,100L,106L,107L,109L,112L,115L,118L,124L,126L,133L,138L,145L,147L,148L,151L,154L,156L,157L,160L,163L,169L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179003Inst : IEnumerable<long>
{
public static readonly long[] Value=A179003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179003.Bytes);
public long this[int i]=>Value[i];

public static A179003Inst Instance=new A179003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A179004
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,4L,4L,2L,3L,4L,5L,4L,3L,4L,6L,7L,7L,6L,4L,4L,6L,9L,9L,9L,6L,4L,5L,8L,10L,11L,11L,10L,8L,5L,6L,8L,12L,13L,14L,13L,12L,8L,6L,6L,10L,14L,16L,17L,17L,16L,14L,10L,6L,7L,10L,15L,18L,20L,20L,20L,18L,15L,10L,7L,8L,12L,17L,20L,22L,24L,24L,22L,20L,17L,12L,8L,8L,12L,19L,22L,26L,27L,28L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A179004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A179004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A179004Inst : IEnumerable<long>
{
public static readonly long[] Value=A179004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A179004.Bytes);
public long this[int i]=>Value[i];

public static A179004Inst Instance=new A179004Inst();

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