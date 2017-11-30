using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A163505
{
public static readonly long[] Value={ 0L,0L,0L,0L,7L,5L,7L,5L,5L,7L,7L,5L,5L,3L,5L,3L,3L,5L,3L,3L,3L,1L,1L,46L,46L,48L,52L,1L,1L,58L,58L,58L,58L,58L,60L,62L,62L,66L,66L,66L,66L,70L,70L,72L,72L,74L,76L,76L,78L,78L,82L,82L,82L,82L,86L,90L,90L,90L,90L,90L,92L,92L,92L,92L,92L,94L,98L,100L,100L,104L,104L,104L,104L,106L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163505Inst : IEnumerable<long>
{
public static readonly long[] Value=A163505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163505.Bytes);
public long this[int i]=>Value[i];

public static A163505Inst Instance=new A163505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163506
{
public static readonly long[] Value={ 1L,27L,75L,147L,225L,297L,429L,525L,663L,855L,1029L,1173L,1375L,1539L,1827L,2015L,2277L,2625L,2849L,3159L,3485L,3741L,4095L,4371L,4655L,5049L,5565L,6105L,6555L,6903L,7259L,7623L,7995L,8375L,8901L,9443L,9855L,10575L,11011L,11455L,11907L,12699L,13175L,13833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163506Inst : IEnumerable<long>
{
public static readonly long[] Value=A163506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163506.Bytes);
public long this[int i]=>Value[i];

public static A163506Inst Instance=new A163506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163507
{
public static readonly long[] Value={ 0L,1L,2L,1L,3L,2L,4L,1L,4L,3L,5L,2L,6L,4L,6L,1L,7L,4L,8L,3L,8L,5L,9L,2L,9L,6L,8L,4L,10L,6L,11L,1L,10L,7L,12L,4L,12L,8L,12L,3L,13L,8L,14L,5L,12L,9L,15L,2L,16L,9L,14L,6L,16L,8L,15L,4L,16L,10L,17L,6L,18L,11L,16L,1L,18L,10L,19L,7L,18L,12L,20L,4L,21L,12L,18L,8L,20L,12L,22L,3L,16L,13L,23L,8L,21L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163507Inst : IEnumerable<long>
{
public static readonly long[] Value=A163507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163507.Bytes);
public long this[int i]=>Value[i];

public static A163507Inst Instance=new A163507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163508
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,10L,12L,17L,12L,21L,18L,14L,13L,14L,15L,14L,14L,28L,14L,25L,14L,47L,36L,19L,24L,17L,15L,42L,16L,48L,71L,30L,16L,17L,22L,17L,21L,26L,21L,17L,38L,17L,23L,21L,48L,40L,18L,28L,23L,65L,18L,48L,131L,24L,30L,18L,141L,39L,54L,18L,19L,108L,24L,20L,18L,171L,29L,38L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163508Inst : IEnumerable<long>
{
public static readonly long[] Value=A163508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163508.Bytes);
public long this[int i]=>Value[i];

public static A163508Inst Instance=new A163508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163509
{
public static readonly long[] Value={ 1L,2L,1L,4L,5L,2L,1L,8L,9L,10L,11L,4L,5L,2L,1L,16L,17L,18L,19L,20L,21L,22L,23L,8L,9L,10L,11L,4L,5L,2L,1L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,16L,17L,18L,19L,20L,21L,22L,23L,8L,9L,10L,11L,4L,5L,2L,1L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163509Inst : IEnumerable<long>
{
public static readonly long[] Value=A163509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163509.Bytes);
public long this[int i]=>Value[i];

public static A163509Inst Instance=new A163509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163510
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,3L,0L,2L,1L,1L,0L,0L,1L,2L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,4L,0L,3L,1L,2L,0L,0L,2L,2L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,3L,0L,0L,2L,0L,1L,1L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,4L,1L,3L,0L,0L,3L,2L,2L,0L,1L,2L,1L,0L,2L,0L,0L,0L,2L,3L,1L,0L,2L,1L,1L,1L,1L,0L,0L,1L,1L,2L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163510Inst : IEnumerable<long>
{
public static readonly long[] Value=A163510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163510.Bytes);
public long this[int i]=>Value[i];

public static A163510Inst Instance=new A163510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163511
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,9L,6L,5L,16L,27L,18L,25L,12L,15L,10L,7L,32L,81L,54L,125L,36L,75L,50L,49L,24L,45L,30L,35L,20L,21L,14L,11L,64L,243L,162L,625L,108L,375L,250L,343L,72L,225L,150L,245L,100L,147L,98L,121L,48L,135L,90L,175L,60L,105L,70L,77L,40L,63L,42L,55L,28L,33L,22L,13L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163511Inst : IEnumerable<long>
{
public static readonly long[] Value=A163511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163511.Bytes);
public long this[int i]=>Value[i];

public static A163511Inst Instance=new A163511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163512
{
public static readonly long[] Value={ 23L,337L,2293L,3557L,9941L,21347L,39233L,87403L,251221L,333367L,895253L,1080647L,1217473L,1696207L,2076563L,2626933L,2999707L,4493837L,6203297L,6857033L,8045953L,8299127L,8821297L,11442817L,13807361L,14538187L,17298497L,21333467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163512Inst : IEnumerable<long>
{
public static readonly long[] Value=A163512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163512.Bytes);
public long this[int i]=>Value[i];

public static A163512Inst Instance=new A163512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163513
{
public static readonly long[] Value={ 2293L,9941L,895253L,2626933L,17298497L,33084437L,47685397L,62056661L,76782337L,144599617L,189907873L,211280213L,258717493L,301410677L,479690273L,630940097L,717228821L,778918037L,1035249013L,1814163413L,1889439157L,2710909781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163513Inst : IEnumerable<long>
{
public static readonly long[] Value=A163513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163513.Bytes);
public long this[int i]=>Value[i];

public static A163513Inst Instance=new A163513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163514
{
public static readonly BigInteger[] Value={ 1L,22L,462L,9702L,203742L,4278351L,89840520L,1886549280L,39615400440L,831878586000L,17468509071090L,366818925627000L,7702782398341800L,161749714998425400L,3396561002126245800L,BigInteger.Parse("71323937982067871100") };
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
public class A163514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163514Inst Instance=new A163514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163515
{
public static readonly long[] Value={ 2L,3L,3L,4L,4L,4L,5L,5L,4L,5L,5L,6L,6L,5L,6L,7L,6L,6L,6L,5L,7L,8L,7L,6L,9L,8L,6L,7L,7L,7L,10L,6L,8L,7L,9L,8L,7L,8L,7L,10L,11L,7L,12L,8L,6L,9L,8L,9L,11L,8L,7L,13L,8L,10L,9L,9L,7L,8L,14L,8L,10L,15L,12L,8L,8L,10L,11L,13L,16L,11L,7L,9L,9L,8L,10L,9L,9L,17L,8L,9L,14L,8L,11L,12L,12L,10L,18L,11L,8L,10L,19L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163515Inst : IEnumerable<long>
{
public static readonly long[] Value=A163515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163515.Bytes);
public long this[int i]=>Value[i];

public static A163515Inst Instance=new A163515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163516
{
public static readonly long[] Value={ 0L,2L,5L,8L,11L,14L,18L,22L,26L,30L,35L,40L,45L,50L,56L,61L,67L,74L,80L,87L,94L,101L,108L,116L,123L,131L,140L,148L,157L,165L,175L,184L,193L,203L,213L,223L,233L,243L,254L,265L,276L,287L,299L,310L,322L,334L,346L,359L,371L,384L,397L,410L,424L,437L,451L,465L,479L,493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163516Inst : IEnumerable<long>
{
public static readonly long[] Value=A163516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163516.Bytes);
public long this[int i]=>Value[i];

public static A163516Inst Instance=new A163516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163517
{
public static readonly long[] Value={ 1L,2L,3L,7L,8L,10L,11L,14L,16L,20L,21L,23L,28L,29L,30L,34L,37L,39L,41L,42L,49L,51L,52L,57L,67L,68L,70L,71L,78L,83L,88L,91L,93L,96L,106L,108L,110L,115L,116L,120L,123L,130L,133L,136L,139L,145L,150L,157L,160L,162L,166L,167L,171L,173L,177L,179L,180L,181L,182L,184L,188L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163517Inst : IEnumerable<long>
{
public static readonly long[] Value=A163517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163517.Bytes);
public long this[int i]=>Value[i];

public static A163517Inst Instance=new A163517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163518
{
public static readonly BigInteger[] Value={ 1L,23L,506L,11132L,244904L,5387635L,118522404L,2607370689L,57359466780L,1261849124844L,27759379635372L,610677728876061L,13434280356535038L,295540315560771435L,6501582206394337062L,BigInteger.Parse("143028104664155140584") };
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
public class A163518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163518Inst Instance=new A163518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163519
{
public static readonly BigInteger[] Value={ 1L,24L,552L,12696L,292008L,6715908L,154459536L,3552423600L,81702391056L,1879077904176L,43217018799372L,993950655137880L,22859927229943848L,525756756894338904L,12091909332851083560UL,BigInteger.Parse("278102505382114851108") };
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
public class A163519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163519Inst Instance=new A163519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163520
{
public static readonly long[] Value={ 4L,6L,8L,9L,12L,12L,16L,15L,16L,18L,24L,20L,28L,24L,24L,25L,36L,28L,40L,30L,32L,36L,48L,35L,36L,42L,40L,40L,60L,42L,64L,45L,48L,54L,48L,49L,76L,60L,56L,54L,84L,56L,88L,60L,60L,72L,96L,63L,64L,66L,72L,70L,108L,70L,72L,72L,80L,90L,120L,77L,124L,96L,80L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163520Inst : IEnumerable<long>
{
public static readonly long[] Value=A163520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163520.Bytes);
public long this[int i]=>Value[i];

public static A163520Inst Instance=new A163520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163521
{
public static readonly long[] Value={ 30L,1255L,78698L,5762750L,455059956L,37607986470L,3204942375900L,279238346962895L,24739954333817884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163521Inst : IEnumerable<long>
{
public static readonly long[] Value=A163521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163521.Bytes);
public long this[int i]=>Value[i];

public static A163521Inst Instance=new A163521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163522
{
public static readonly long[] Value={ 2L,4L,7L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L,13L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163522Inst : IEnumerable<long>
{
public static readonly long[] Value=A163522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163522.Bytes);
public long this[int i]=>Value[i];

public static A163522Inst Instance=new A163522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163523
{
public static readonly long[] Value={ 1L,3L,3L,4L,3L,6L,3L,5L,4L,6L,3L,8L,3L,6L,6L,6L,3L,8L,3L,8L,6L,6L,3L,10L,4L,6L,5L,8L,3L,11L,3L,7L,6L,6L,6L,11L,3L,6L,6L,10L,3L,11L,3L,8L,8L,6L,3L,12L,4L,8L,6L,8L,3L,10L,6L,10L,6L,6L,3L,15L,3L,6L,8L,8L,6L,11L,3L,8L,6L,11L,3L,14L,3L,6L,8L,8L,6L,11L,3L,12L,6L,6L,3L,15L,6L,6L,6L,10L,3L,15L,6L,8L,6L,6L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163523Inst : IEnumerable<long>
{
public static readonly long[] Value=A163523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163523.Bytes);
public long this[int i]=>Value[i];

public static A163523Inst Instance=new A163523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163524
{
public static readonly long[] Value={ 5L,4L,11L,5L,71L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163524Inst : IEnumerable<long>
{
public static readonly long[] Value=A163524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163524.Bytes);
public long this[int i]=>Value[i];

public static A163524Inst Instance=new A163524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163525
{
public static readonly BigInteger[] Value={ 1L,25L,600L,14400L,345600L,8294100L,199051200L,4777056300L,114645211200L,2751385708800L,66030872460900L,1584683711924400L,38031035684483100L,912711895976984400L,BigInteger.Parse("21904294481198985600"),BigInteger.Parse("525684083700365474100") };
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
public class A163525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163525Inst Instance=new A163525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163526
{
public static readonly BigInteger[] Value={ 1L,26L,650L,16250L,406250L,10155925L,253890000L,6347047200L,158671110000L,3966651000000L,99163106355300L,2478998445300000L,61972980856207200L,1549275016079700000L,BigInteger.Parse("38730637808401500000"),BigInteger.Parse("968235006358878382800") };
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
public class A163526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163526Inst Instance=new A163526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163527
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338001L,320778900L,8340014475L,216834216300L,5637529462500L,146571601954050L,3810753388040625L,99076773337132500L,2575922925294444375L,BigInteger.Parse("66972093393463976250"),BigInteger.Parse("1741224960366454777500") };
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
public class A163527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163527Inst Instance=new A163527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163528
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,4L,5L,5L,4L,3L,3L,4L,5L,6L,7L,8L,8L,7L,6L,6L,7L,8L,8L,7L,6L,6L,7L,8L,8L,7L,6L,5L,4L,3L,3L,4L,5L,5L,4L,3L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,3L,4L,5L,5L,4L,3L,3L,4L,5L,6L,7L,8L,8L,7L,6L,6L,7L,8L,9L,10L,11L,11L,10L,9L,9L,10L,11L,12L,13L,14L,14L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163528Inst : IEnumerable<long>
{
public static readonly long[] Value=A163528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163528.Bytes);
public long this[int i]=>Value[i];

public static A163528Inst Instance=new A163528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163529
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,5L,5L,4L,4L,4L,3L,3L,3L,3L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,7L,7L,7L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,7L,7L,7L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163529Inst : IEnumerable<long>
{
public static readonly long[] Value=A163529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163529.Bytes);
public long this[int i]=>Value[i];

public static A163529Inst Instance=new A163529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163530
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,1L,2L,3L,4L,5L,6L,7L,6L,5L,4L,3L,4L,5L,6L,7L,8L,9L,8L,7L,8L,9L,10L,11L,10L,9L,10L,11L,12L,13L,12L,11L,10L,9L,8L,7L,8L,9L,8L,7L,6L,5L,4L,3L,4L,5L,6L,7L,6L,5L,6L,7L,8L,9L,8L,7L,8L,9L,10L,11L,12L,13L,12L,11L,10L,9L,10L,11L,12L,13L,14L,15L,14L,13L,14L,15L,16L,17L,18L,19L,18L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163530Inst : IEnumerable<long>
{
public static readonly long[] Value=A163530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163530.Bytes);
public long this[int i]=>Value[i];

public static A163530Inst Instance=new A163530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163531
{
public static readonly long[] Value={ 0L,1L,4L,5L,2L,1L,4L,5L,8L,13L,20L,29L,26L,17L,10L,9L,16L,25L,36L,49L,64L,65L,50L,37L,40L,53L,68L,73L,58L,45L,52L,65L,80L,89L,74L,61L,50L,41L,34L,25L,32L,41L,34L,25L,18L,13L,10L,9L,16L,17L,20L,29L,26L,25L,36L,37L,40L,53L,50L,49L,64L,65L,68L,73L,80L,89L,74L,65L,58L,45L,52L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163531Inst : IEnumerable<long>
{
public static readonly long[] Value=A163531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163531.Bytes);
public long this[int i]=>Value[i];

public static A163531Inst Instance=new A163531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163532
{
public static readonly long[] Value={ 0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,-1L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L,1L,1L,1L,1L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163532Inst : IEnumerable<long>
{
public static readonly long[] Value=A163532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163532.Bytes);
public long this[int i]=>Value[i];

public static A163532Inst Instance=new A163532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163533
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,-1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163533Inst : IEnumerable<long>
{
public static readonly long[] Value=A163533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163533.Bytes);
public long this[int i]=>Value[i];

public static A163533Inst Instance=new A163533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163534
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,2L,2L,2L,3L,0L,0L,3L,2L,2L,2L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L,2L,2L,3L,0L,0L,0L,0L,0L,1L,2L,2L,1L,0L,0L,0L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163534Inst : IEnumerable<long>
{
public static readonly long[] Value=A163534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163534.Bytes);
public long this[int i]=>Value[i];

public static A163534Inst Instance=new A163534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163535
{
public static readonly long[] Value={ 1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,3L,3L,3L,2L,1L,1L,2L,3L,3L,3L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L,3L,3L,2L,1L,1L,1L,1L,1L,0L,3L,3L,0L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163535Inst : IEnumerable<long>
{
public static readonly long[] Value=A163535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163535.Bytes);
public long this[int i]=>Value[i];

public static A163535Inst Instance=new A163535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163536
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163536Inst : IEnumerable<long>
{
public static readonly long[] Value=A163536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163536.Bytes);
public long this[int i]=>Value[i];

public static A163536Inst Instance=new A163536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163537
{
public static readonly long[] Value={ 0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,0L,0L,2L,2L,0L,1L,1L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163537Inst : IEnumerable<long>
{
public static readonly long[] Value=A163537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163537.Bytes);
public long this[int i]=>Value[i];

public static A163537Inst Instance=new A163537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163538
{
public static readonly long[] Value={ 0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,-1L,-1L,0L,1L,0L,0L,-1L,0L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163538Inst : IEnumerable<long>
{
public static readonly long[] Value=A163538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163538.Bytes);
public long this[int i]=>Value[i];

public static A163538Inst Instance=new A163538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163539
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L,-1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,0L,0L,-1L,0L,-1L,-1L,0L,1L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,-1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,-1L,0L,1L,0L,-1L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163539Inst : IEnumerable<long>
{
public static readonly long[] Value=A163539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163539.Bytes);
public long this[int i]=>Value[i];

public static A163539Inst Instance=new A163539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163540
{
public static readonly long[] Value={ 0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,2L,2L,3L,0L,3L,3L,2L,1L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,0L,1L,2L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163540Inst : IEnumerable<long>
{
public static readonly long[] Value=A163540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163540.Bytes);
public long this[int i]=>Value[i];

public static A163540Inst Instance=new A163540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163541
{
public static readonly long[] Value={ 1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,3L,3L,2L,1L,2L,2L,3L,0L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,1L,0L,3L,0L,1L,0L,3L,3L,2L,3L,0L,0L,1L,0L,3L,0L,0L,1L,2L,1L,0L,1L,2L,2L,3L,2L,1L,1L,1L,0L,3L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163541Inst : IEnumerable<long>
{
public static readonly long[] Value=A163541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163541.Bytes);
public long this[int i]=>Value[i];

public static A163541Inst Instance=new A163541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163542
{
public static readonly long[] Value={ 1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,0L,1L,1L,2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163542Inst : IEnumerable<long>
{
public static readonly long[] Value=A163542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163542.Bytes);
public long this[int i]=>Value[i];

public static A163542Inst Instance=new A163542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163543
{
public static readonly long[] Value={ 2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,2L,0L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,0L,2L,2L,1L,1L,2L,2L,0L,2L,1L,1L,0L,1L,2L,2L,1L,0L,1L,1L,2L,2L,1L,1L,0L,1L,2L,2L,0L,0L,2L,2L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163543Inst : IEnumerable<long>
{
public static readonly long[] Value=A163543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163543.Bytes);
public long this[int i]=>Value[i];

public static A163543Inst Instance=new A163543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163544
{
public static readonly long[] Value={ 0L,1L,4L,2L,11L,6L,3L,7L,12L,17L,24L,18L,13L,8L,5L,9L,58L,48L,38L,47L,37L,28L,21L,29L,22L,16L,10L,15L,39L,30L,23L,31L,40L,49L,60L,50L,83L,70L,59L,71L,84L,97L,112L,98L,85L,72L,61L,73L,62L,52L,42L,51L,41L,32L,25L,33L,26L,20L,14L,19L,43L,34L,27L,35L,260L,238L,216L,237L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163544Inst : IEnumerable<long>
{
public static readonly long[] Value=A163544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163544.Bytes);
public long this[int i]=>Value[i];

public static A163544Inst Instance=new A163544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163545
{
public static readonly long[] Value={ 0L,3L,1L,14L,2L,6L,15L,13L,7L,5L,58L,12L,8L,4L,26L,57L,59L,11L,9L,25L,27L,62L,56L,54L,10L,30L,24L,22L,63L,61L,55L,53L,31L,29L,23L,21L,234L,60L,50L,52L,32L,28L,18L,20L,106L,233L,235L,49L,51L,35L,33L,17L,19L,105L,107L,228L,232L,236L,48L,46L,34L,38L,16L,100L,104L,108L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163545Inst : IEnumerable<long>
{
public static readonly long[] Value=A163545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163545.Bytes);
public long this[int i]=>Value[i];

public static A163545Inst Instance=new A163545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163546
{
public static readonly long[] Value={ 0L,2L,4L,1L,13L,9L,5L,8L,12L,18L,24L,17L,11L,7L,3L,6L,62L,51L,42L,52L,43L,35L,27L,34L,26L,19L,14L,20L,41L,33L,25L,32L,40L,50L,60L,49L,85L,73L,61L,72L,84L,98L,112L,97L,83L,71L,59L,70L,58L,47L,38L,48L,39L,31L,23L,30L,22L,15L,10L,16L,37L,29L,21L,28L,268L,245L,224L,246L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163546Inst : IEnumerable<long>
{
public static readonly long[] Value=A163546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163546.Bytes);
public long this[int i]=>Value[i];

public static A163546Inst Instance=new A163546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163547
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,9L,10L,5L,8L,13L,18L,13L,10L,5L,4L,9L,16L,17L,26L,25L,36L,49L,50L,37L,40L,53L,58L,45L,34L,29L,20L,25L,32L,41L,50L,41L,52L,65L,74L,61L,72L,85L,98L,85L,74L,61L,52L,65L,58L,53L,40L,45L,34L,25L,20L,29L,26L,17L,16L,25L,36L,37L,50L,49L,64L,81L,82L,65L,68L,73L,90L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163547Inst : IEnumerable<long>
{
public static readonly long[] Value=A163547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163547.Bytes);
public long this[int i]=>Value[i];

public static A163547Inst Instance=new A163547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163548
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14879970L,401748984L,10846947384L,292860149400L,7907023424664L,213484216161762L,5763927599870076L,155622096911221668L,4201690015605193020L,BigInteger.Parse("113442752267421552612"),BigInteger.Parse("3062876603036110993314") };
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
public class A163548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163548Inst Instance=new A163548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163549
{
public static readonly BigInteger[] Value={ 1L,29L,812L,22736L,636608L,17824618L,499077936L,13973864310L,391259299536L,10955011154976L,306733334006862L,8588337963333660L,240467992209756738L,6732950603977585764L,BigInteger.Parse("188518328027869860720"),BigInteger.Parse("5278393098774299901978") };
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
public class A163549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163549.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163549Inst Instance=new A163549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163550
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,9L,71L,58L,831L,69L,859L,9571L,99401L,138901L,378742L,440716L,953859L,7133771L,6438258L,88852541L,75424201L,517071L,318397461L,337833493L,520847656L,168707711L,688837201L,8652938731L,3463840159L,19061650821L,11792487113L,39087971343L,77290124996L,254385071821L,61861367073L,98365635393L,782470216414L,88812796249L,650846846969L,2369589212251L,9645588429013L,33288442066621L,58870791630354L,889521228408101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163550Inst : IEnumerable<long>
{
public static readonly long[] Value=A163550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163550.Bytes);
public long this[int i]=>Value[i];

public static A163550Inst Instance=new A163550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163551
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,13L,25L,49L,97L,193L,385L,769L,1537L,3073L,6145L,12289L,24577L,49153L,98305L,196597L,393169L,786289L,1572481L,3144769L,6289153L,12577537L,25153537L,50304001L,100601857L,201191425L,402358273L,804667393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163551Inst : IEnumerable<long>
{
public static readonly long[] Value=A163551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163551.Bytes);
public long this[int i]=>Value[i];

public static A163551Inst Instance=new A163551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163552
{
public static readonly BigInteger[] Value={ 1L,30L,870L,25230L,731670L,21217995L,615309240L,17843602560L,517453877640L,15005855150160L,435160887802830L,12619407316577880L,365955317872798920L,10612486887830912280UL,BigInteger.Parse("307755817292235608520"),BigInteger.Parse("8924735934026717183820") };
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
public class A163552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163552.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163552Inst Instance=new A163552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163553
{
public static readonly long[] Value={ 0L,2L,1L,6L,0L,11L,1L,11L,5L,17L,-4L,27L,4L,15L,9L,30L,-3L,38L,-2L,31L,18L,35L,-12L,54L,15L,29L,12L,55L,-12L,71L,1L,48L,28L,41L,-7L,90L,16L,43L,6L,89L,-12L,95L,4L,51L,52L,71L,-28L,116L,14L,72L,26L,97L,-12L,103L,8L,97L,48L,89L,-48L,167L,28L,55L,41L,108L,6L,143L,10L,99L,22L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163553Inst : IEnumerable<long>
{
public static readonly long[] Value=A163553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163553.Bytes);
public long this[int i]=>Value[i];

public static A163553Inst Instance=new A163553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163554
{
public static readonly long[] Value={ 104L,106L,110L,118L,119L,124L,125L,128L,133L,140L,142L,146L,152L,160L,164L,169L,172L,182L,190L,196L,214L,215L,217L,218L,238L,305L,319L,328L,329L,346L,350L,356L,364L,365L,368L,374L,376L,382L,386L,391L,392L,394L,410L,412L,416L,436L,437L,473L,475L,476L,493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163554Inst : IEnumerable<long>
{
public static readonly long[] Value=A163554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163554.Bytes);
public long this[int i]=>Value[i];

public static A163554Inst Instance=new A163554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163555
{
public static readonly long[] Value={ 130L,136L,175L,176L,301L,310L,316L,361L,370L,371L,395L,398L,517L,539L,671L,703L,713L,715L,716L,730L,731L,893L,935L,938L,1004L,1025L,1027L,1034L,1040L,1043L,1052L,1058L,1072L,1085L,1118L,1124L,1142L,1147L,1169L,1174L,1189L,1196L,1198L,1205L,1207L,1214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163555Inst : IEnumerable<long>
{
public static readonly long[] Value=A163555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163555.Bytes);
public long this[int i]=>Value[i];

public static A163555Inst Instance=new A163555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163556
{
public static readonly long[] Value={ 170L,194L,710L,790L,791L,793L,914L,917L,970L,973L,1003L,1012L,1015L,1016L,1024L,1028L,1030L,1042L,1082L,1090L,1102L,1105L,1106L,1120L,1126L,1135L,1138L,1150L,1157L,1159L,1160L,1162L,1175L,1178L,1183L,1195L,1204L,1208L,1210L,1216L,1234L,1240L,1243L,1258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163556Inst : IEnumerable<long>
{
public static readonly long[] Value=A163556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163556.Bytes);
public long this[int i]=>Value[i];

public static A163556Inst Instance=new A163556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163557
{
public static readonly long[] Value={ 1007L,1018L,1057L,1067L,1070L,1075L,1076L,1081L,1108L,1127L,1172L,1180L,1271L,1298L,1330L,1336L,1337L,1339L,1363L,1369L,1393L,1396L,1468L,1486L,1507L,1570L,1576L,1633L,1639L,1648L,1670L,1675L,1684L,1696L,1700L,1705L,1706L,1712L,1750L,1756L,1760L,1765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163557Inst : IEnumerable<long>
{
public static readonly long[] Value=A163557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163557.Bytes);
public long this[int i]=>Value[i];

public static A163557Inst Instance=new A163557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163558
{
public static readonly long[] Value={ 1036L,1096L,1099L,1136L,1235L,1238L,1253L,1267L,1276L,1294L,1306L,1316L,1325L,1328L,1352L,1358L,1360L,1378L,1382L,1385L,1387L,1492L,1532L,1538L,1603L,1630L,1631L,1672L,1678L,1687L,1690L,1726L,1738L,1762L,1768L,1786L,1832L,1835L,1837L,1853L,1876L,1906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163558Inst : IEnumerable<long>
{
public static readonly long[] Value=A163558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163558.Bytes);
public long this[int i]=>Value[i];

public static A163558Inst Instance=new A163558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163559
{
public static readonly long[] Value={ 1037L,1073L,1190L,1247L,1274L,1345L,1354L,1370L,1379L,1397L,1435L,1472L,1495L,1534L,1594L,1679L,1703L,1724L,1730L,1739L,1742L,1769L,1793L,1796L,1910L,1937L,1945L,1954L,1967L,1976L,2093L,2147L,2174L,2374L,2390L,2471L,2597L,2714L,2734L,2743L,2759L,2795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163559Inst : IEnumerable<long>
{
public static readonly long[] Value=A163559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163559.Bytes);
public long this[int i]=>Value[i];

public static A163559Inst Instance=new A163559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163560
{
public static readonly long[] Value={ 1130L,1132L,1139L,1309L,1310L,1312L,1376L,1390L,1391L,1478L,1673L,1736L,1748L,1763L,1784L,1874L,1903L,1930L,2375L,2537L,2573L,2735L,3076L,3091L,3101L,3110L,3112L,3176L,3190L,3211L,3275L,3572L,3670L,3706L,3716L,3725L,3752L,3760L,3901L,3910L,4178L,4187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163560Inst : IEnumerable<long>
{
public static readonly long[] Value=A163560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163560.Bytes);
public long this[int i]=>Value[i];

public static A163560Inst Instance=new A163560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163561
{
public static readonly long[] Value={ 1094L,1349L,1394L,1457L,1475L,1490L,1547L,1574L,1745L,1754L,1904L,1934L,1940L,1943L,3097L,3149L,3194L,3419L,3479L,3497L,3679L,3749L,3790L,3794L,3796L,3914L,3941L,3970L,3974L,3976L,4109L,4175L,4190L,4193L,4319L,4379L,4571L,4715L,4739L,4901L,4910L,4913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163561Inst : IEnumerable<long>
{
public static readonly long[] Value=A163561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163561.Bytes);
public long this[int i]=>Value[i];

public static A163561Inst Instance=new A163561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163562
{
public static readonly long[] Value={ 1079L,1790L,1795L,1798L,1897L,1957L,1970L,1975L,1978L,5719L,5917L,5971L,7091L,7189L,7190L,7195L,7198L,7519L,7819L,7891L,7910L,7915L,7918L,7981L,8197L,8791L,8917L,9017L,9071L,9107L,9170L,9175L,9178L,9517L,9571L,9701L,9710L,9715L,9718L,9751L,10019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163562Inst : IEnumerable<long>
{
public static readonly long[] Value=A163562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163562.Bytes);
public long this[int i]=>Value[i];

public static A163562Inst Instance=new A163562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163563
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163563Inst : IEnumerable<long>
{
public static readonly long[] Value=A163563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163563.Bytes);
public long this[int i]=>Value[i];

public static A163563Inst Instance=new A163563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163564
{
public static readonly BigInteger[] Value={ 1L,31L,930L,27900L,837000L,25109535L,753272100L,22597744965L,677919807900L,20337218005500L,610105253435760L,18302819007466125L,549074412543683490L,16471927651538698875UL,BigInteger.Parse("494148687972122850750"),BigInteger.Parse("14824186397015923722360") };
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
public class A163564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163564.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163564Inst Instance=new A163564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163565
{
public static readonly BigInteger[] Value={ 1L,32L,992L,30752L,953312L,29552176L,916102080L,28398688320L,880344576960L,27290224296000L,845982768138960L,26225026083540000L,812962177226488800L,BigInteger.Parse("25201404928845626400"),BigInteger.Parse("781230453493416184800"),BigInteger.Parse("24217737986779970583600") };
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
public class A163565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163565Inst Instance=new A163565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163566
{
public static readonly long[] Value={ 10L,972L,85022L,8077072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163566Inst : IEnumerable<long>
{
public static readonly long[] Value=A163566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163566.Bytes);
public long this[int i]=>Value[i];

public static A163566Inst Instance=new A163566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163567
{
public static readonly BigInteger[] Value={ 1L,33L,1056L,33792L,1081344L,34602480L,1107262464L,35431858704L,1133802193920L,36281117097984L,1160978047975152L,37150731170716416L,1188805274075570448L,BigInteger.Parse("38041188830863975680"),BigInteger.Parse("1217299484804824768512"),BigInteger.Parse("38952989673757190287344") };
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
public class A163567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163567Inst Instance=new A163567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163568
{
public static readonly BigInteger[] Value={ 27L,1243L,78624L,5762206L,455055611L,37607950277L,3204942065688L,279238344248553L,24739954309690412L,2220819602783663480L,BigInteger.Parse("201467286691248261495"),BigInteger.Parse("18435599767366347775141"),BigInteger.Parse("1699246750872593033005720"),BigInteger.Parse("157589269275974838158399968"),BigInteger.Parse("14692398897720447639079087666") };
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
public class A163568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163568Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163568.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163568.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163568Inst Instance=new A163568Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163569
{
public static readonly long[] Value={ 360L,504L,540L,600L,756L,792L,936L,1176L,1188L,1224L,1350L,1368L,1400L,1404L,1500L,1656L,1836L,1960L,2052L,2088L,2200L,2232L,2250L,2484L,2600L,2646L,2664L,2904L,2952L,3096L,3132L,3348L,3384L,3400L,3500L,3800L,3816L,3996L,4056L,4116L,4248L,4312L,4392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163569Inst : IEnumerable<long>
{
public static readonly long[] Value=A163569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163569.Bytes);
public long this[int i]=>Value[i];

public static A163569Inst Instance=new A163569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163570
{
public static readonly long[] Value={ 5L,7L,17L,37L,113L,137L,157L,173L,223L,227L,337L,487L,503L,617L,743L,797L,857L,863L,877L,947L,1103L,1217L,1277L,1453L,1483L,1663L,1693L,1747L,1933L,2557L,2683L,2833L,2837L,2843L,3067L,3167L,3373L,3457L,3583L,3593L,3823L,4013L,4483L,4943L,4987L,5527L,5843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163570Inst : IEnumerable<long>
{
public static readonly long[] Value=A163570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163570.Bytes);
public long this[int i]=>Value[i];

public static A163570Inst Instance=new A163570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163571
{
public static readonly long[] Value={ 3L,7L,19L,73L,101L,107L,263L,353L,359L,443L,521L,523L,557L,613L,733L,829L,1033L,1097L,1103L,1109L,1129L,1283L,1307L,1601L,1613L,1699L,1811L,1949L,2111L,2237L,2293L,2333L,2459L,2551L,2777L,2917L,3517L,3593L,3631L,3637L,4127L,4133L,4211L,4349L,4483L,4643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163571Inst : IEnumerable<long>
{
public static readonly long[] Value=A163571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163571.Bytes);
public long this[int i]=>Value[i];

public static A163571Inst Instance=new A163571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163572
{
public static readonly long[] Value={ 1L,1L,3L,7L,19L,39L,169L,765L,2183L,4131L,11561L,55157L,666381L,8175433L,68536455L,355280675L,1048740623L,1931107235L,5055100985L,13108206741L,38734589993L,143320957605L,1022112572635L,26523801989399L,914332703582521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163572Inst : IEnumerable<long>
{
public static readonly long[] Value=A163572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163572.Bytes);
public long this[int i]=>Value[i];

public static A163572Inst Instance=new A163572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163573
{
public static readonly long[] Value={ 12721L,16921L,19441L,24481L,49681L,61561L,104161L,229321L,255361L,259681L,266401L,291721L,298201L,311041L,331921L,419401L,423481L,436801L,446881L,471241L,525241L,532801L,539401L,581521L,600601L,663601L,704161L,709921L,783721L,867001L,904801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163573Inst : IEnumerable<long>
{
public static readonly long[] Value=A163573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163573.Bytes);
public long this[int i]=>Value[i];

public static A163573Inst Instance=new A163573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163574
{
public static readonly long[] Value={ 1L,0L,27L,0L,2285L,0L,874615L,0L,381654729L,0L,0L,0L,559922224824157L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163574Inst : IEnumerable<long>
{
public static readonly long[] Value=A163574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163574.Bytes);
public long this[int i]=>Value[i];

public static A163574Inst Instance=new A163574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163575
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,0L,1L,4L,5L,2L,3L,6L,7L,0L,1L,8L,9L,4L,5L,10L,11L,2L,3L,12L,13L,6L,7L,14L,15L,0L,1L,16L,17L,8L,9L,18L,19L,4L,5L,20L,21L,10L,11L,22L,23L,2L,3L,24L,25L,12L,13L,26L,27L,6L,7L,28L,29L,14L,15L,30L,31L,0L,1L,32L,33L,16L,17L,34L,35L,8L,9L,36L,37L,18L,19L,38L,39L,4L,5L,40L,41L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163575Inst : IEnumerable<long>
{
public static readonly long[] Value=A163575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163575.Bytes);
public long this[int i]=>Value[i];

public static A163575Inst Instance=new A163575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163576
{
public static readonly long[] Value={ 24L,5761L,5762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163576Inst : IEnumerable<long>
{
public static readonly long[] Value=A163576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163576.Bytes);
public long this[int i]=>Value[i];

public static A163576Inst Instance=new A163576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163577
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,1L,0L,2L,4L,1L,0L,5L,2L,2L,0L,2L,4L,5L,8L,5L,2L,4L,0L,5L,10L,4L,4L,10L,4L,4L,0L,2L,4L,5L,8L,9L,10L,12L,16L,5L,10L,6L,4L,12L,8L,8L,0L,5L,10L,12L,20L,12L,8L,12L,8L,10L,20L,8L,8L,20L,8L,8L,0L,2L,4L,5L,8L,9L,10L,12L,16L,9L,18L,14L,20L,20L,24L,24L,32L,5L,10L,14L,20L,14L,12L,16L,8L,12L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163577Inst : IEnumerable<long>
{
public static readonly long[] Value=A163577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163577.Bytes);
public long this[int i]=>Value[i];

public static A163577Inst Instance=new A163577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163578
{
public static readonly long[] Value={ 2L,4L,6L,7L,8L,11L,12L,13L,17L,19L,20L,23L,24L,29L,31L,37L,38L,41L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163578Inst : IEnumerable<long>
{
public static readonly long[] Value=A163578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163578.Bytes);
public long this[int i]=>Value[i];

public static A163578Inst Instance=new A163578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163579
{
public static readonly long[] Value={ 3L,31L,47L,113L,659L,1021L,1187L,1979L,2971L,3251L,5749L,9679L,10433L,14627L,20593L,22807L,23957L,35107L,39461L,55813L,58207L,109063L,152417L,157349L,201881L,227419L,244463L,262121L,292469L,295187L,310357L,318793L,320209L,323053L,328777L,333103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163579Inst : IEnumerable<long>
{
public static readonly long[] Value=A163579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163579.Bytes);
public long this[int i]=>Value[i];

public static A163579Inst Instance=new A163579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163580
{
public static readonly long[] Value={ 5L,53L,151L,967L,1129L,2129L,2617L,2879L,4217L,4549L,6397L,6599L,7013L,7877L,8101L,8329L,9029L,10007L,10259L,11839L,12391L,26881L,30707L,35257L,35729L,36683L,37649L,41131L,41641L,49667L,50227L,56597L,63347L,71143L,75211L,79393L,82963L,102797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163580Inst : IEnumerable<long>
{
public static readonly long[] Value=A163580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163580.Bytes);
public long this[int i]=>Value[i];

public static A163580Inst Instance=new A163580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163581
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163581Inst : IEnumerable<long>
{
public static readonly long[] Value=A163581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163581.Bytes);
public long this[int i]=>Value[i];

public static A163581Inst Instance=new A163581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163582
{
public static readonly BigInteger[] Value={ 341L,597871L,BigInteger.Parse("1010101010101010101010101010101010101"),432988561L,584645231109031L,54989488181L,BigInteger.Parse("48793204382746801501446610630739608190006929723969"),11694525061301L };
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
public class A163582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163582Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163582.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163582.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163582Inst Instance=new A163582Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163583
{
public static readonly long[] Value={ 1L,4372L,100627L,1240001L,10698751L,20249386L,83781871L,431424985L,787479360L,2194606250L,5409349991L,9630730661L,13906093181L,18529006931L,27816044405L,40317825620L,53826243764L,81242430639L,157086570010L,237512970010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163583Inst : IEnumerable<long>
{
public static readonly long[] Value=A163583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163583.Bytes);
public long this[int i]=>Value[i];

public static A163583Inst Instance=new A163583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163584
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163584Inst : IEnumerable<long>
{
public static readonly long[] Value=A163584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163584.Bytes);
public long this[int i]=>Value[i];

public static A163584Inst Instance=new A163584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163585
{
public static readonly BigInteger[] Value={ 1L,12L,315L,11906L,598481L,37603698L,2835252098L,249401800589L,25072603664742L,2835644669262813L,356337618445884526L,BigInteger.Parse("49256576349520039506"),BigInteger.Parse("7427716723230571769719"),BigInteger.Parse("1213412735113655221460574"),BigInteger.Parse("213474717926699991459606943"),BigInteger.Parse("40239036333940441855233097277") };
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
public class A163585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163585.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163585Inst Instance=new A163585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163586
{
public static readonly long[] Value={ 3L,5L,17L,29L,41L,71L,101L,191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163586Inst : IEnumerable<long>
{
public static readonly long[] Value=A163586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163586.Bytes);
public long this[int i]=>Value[i];

public static A163586Inst Instance=new A163586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163587
{
public static readonly long[] Value={ 5L,23L,29L,59L,307L,383L,449L,691L,727L,739L,751L,787L,947L,971L,1009L,1021L,1097L,1237L,1289L,1367L,1511L,1657L,1697L,1913L,2063L,2243L,2579L,2593L,2621L,2749L,2777L,2791L,2963L,3049L,3121L,3251L,3499L,3617L,3631L,3779L,3793L,3823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163587Inst : IEnumerable<long>
{
public static readonly long[] Value=A163587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163587.Bytes);
public long this[int i]=>Value[i];

public static A163587Inst Instance=new A163587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163588
{
public static readonly long[] Value={ 2L,3L,5L,17L,37L,101L,197L,257L,401L,577L,677L,1297L,1601L,2917L,3137L,4357L,5477L,7057L,8101L,8837L,12101L,13457L,14401L,15377L,15877L,16901L,17957L,21317L,22501L,24337L,25601L,28901L,30977L,32401L,33857L,41617L,42437L,44101L,50177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163588Inst : IEnumerable<long>
{
public static readonly long[] Value=A163588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163588.Bytes);
public long this[int i]=>Value[i];

public static A163588Inst Instance=new A163588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163589
{
public static readonly BigInteger[] Value={ 1427L,2857L,5717L,11437L,22877L,45757L,183037L,366077L,732157L,23429117L,1499463677L,191931351037L,98268851732477L,393075406929917L,6289206510878717L,50313652087029757L,100627304174059517L,201254608348119037L,12880294934279618557UL,BigInteger.Parse("422061504406474540974077") };
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
public class A163589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163589.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163589Inst Instance=new A163589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163590
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,15L,5L,35L,35L,315L,63L,693L,231L,3003L,429L,6435L,6435L,109395L,12155L,230945L,46189L,969969L,88179L,2028117L,676039L,16900975L,1300075L,35102025L,5014575L,145422675L,9694845L,300540195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163590Inst : IEnumerable<long>
{
public static readonly long[] Value=A163590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163590.Bytes);
public long this[int i]=>Value[i];

public static A163590Inst Instance=new A163590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163591
{
public static readonly long[] Value={ 1L,2L,3L,-2L,5L,-24L,7L,-20L,-27L,-80L,11L,-54L,13L,-168L,-195L,-394L,17L,-288L,19L,-170L,-399L,-440L,23L,-9360L,-275L,-624L,-792L,-350L,29L,-2580L,31L,-72756L,-1023L,-1088L,-1155L,-93204L,37L,-1368L,-1443L,-87840L,41L,-8568L,43L,-902L,-10845L,-2024L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163591Inst : IEnumerable<long>
{
public static readonly long[] Value=A163591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163591.Bytes);
public long this[int i]=>Value[i];

public static A163591Inst Instance=new A163591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163592
{
public static readonly long[] Value={ 84L,1302L,10584L,11382L,12012L,12558L,13356L,15498L,19362L,20286L,20496L,22092L,23142L,23772L,25452L,26418L,26502L,26544L,28644L,29274L,29778L,31374L,31962L,35406L,36876L,37338L,39522L,40152L,40488L,41286L,42924L,43428L,45108L,46116L,47754L,47796L,48678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163592Inst : IEnumerable<long>
{
public static readonly long[] Value=A163592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163592.Bytes);
public long this[int i]=>Value[i];

public static A163592Inst Instance=new A163592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163593
{
public static readonly BigInteger[] Value={ 1L,34L,1122L,37026L,1221858L,40320753L,1330566336L,43908078720L,1448946455616L,47814568344576L,1577858820890352L,52068617261591040L,1718240483647446528L,BigInteger.Parse("56701147733816154624"),BigInteger.Parse("1871111864101388705280"),BigInteger.Parse("61745833160498214613248") };
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
public class A163593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163593Inst Instance=new A163593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163594
{
public static readonly BigInteger[] Value={ 1L,1L,2L,20L,804L,108304L,49833296L,87606851264L,641794234287360L,BigInteger.Parse("19783636266156204928"),BigInteger.Parse("2512584289692759254055168"),BigInteger.Parse("1295158553795409705964052724736"),BigInteger.Parse("2690610592205668589191756477437574144") };
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
public class A163594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163594Inst Instance=new A163594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163595
{
public static readonly long[] Value={ 3L,9L,13L,17L,30L,32L,35L,39L,52L,55L,62L,64L,69L,76L,79L,81L,94L,97L,103L,109L,113L,119L,132L,135L,139L,154L,160L,165L,170L,173L,176L,185L,196L,201L,208L,212L,215L,220L,223L,225L,234L,239L,245L,248L,253L,265L,270L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163595Inst : IEnumerable<long>
{
public static readonly long[] Value=A163595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163595.Bytes);
public long this[int i]=>Value[i];

public static A163595Inst Instance=new A163595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163596
{
public static readonly long[] Value={ 0L,1L,125L,24389L,343L,17576L,10648L,29791L,8L,21952L,54010152L,941192L,12812904L,551368L,531441L,89915392L,88716536L,571787L,421875L,2197L,512000L,262144L,1668222856L,20123648L,13824000L,15625000L,9261L,27L,34328125L,61629875L,343000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163596Inst : IEnumerable<long>
{
public static readonly long[] Value=A163596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163596.Bytes);
public long this[int i]=>Value[i];

public static A163596Inst Instance=new A163596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163597
{
public static readonly long[] Value={ 0L,110L,2L,132L,240L,156L,6L,272L,182L,992L,141000L,5112L,12L,221370L,7140L,241572L,2162L,141752L,111890L,1190L,20L,122150L,192282L,222312L,152490L,2256L,1260L,102720L,122850L,4290L,30L,7310L,6320L,1332L,173472L,2352L,163620L,8372L,203852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163597Inst : IEnumerable<long>
{
public static readonly long[] Value=A163597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163597.Bytes);
public long this[int i]=>Value[i];

public static A163597Inst Instance=new A163597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163598
{
public static readonly long[] Value={ 1L,120L,3L,741L,153L,6L,171L,780L,190L,10L,111156L,1128L,131328L,2145L,15L,3160L,1176L,4186L,101926L,80200L,21L,1225L,102378L,3240L,5253L,7260L,1275L,28L,232903L,113050L,9316L,1326L,133386L,2346L,5356L,36L,1378L,7381L,133903L,3403L,2415L,124251L,1431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163598Inst : IEnumerable<long>
{
public static readonly long[] Value=A163598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163598.Bytes);
public long this[int i]=>Value[i];

public static A163598Inst Instance=new A163598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163599
{
public static readonly long[] Value={ 12L,2L,30L,42L,56L,6L,72L,812L,90L,1056L,110L,12L,132L,1406L,156L,1640L,1722L,182L,1980L,20L,210L,2256L,2352L,240L,2550L,2652L,272L,2862L,2970L,30L,3192L,32220L,3306L,342L,3540L,3660L,3782L,380L,3906L,4032L,4160L,42L,43056L,4422L,4556L,462L,47306L,4830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163599Inst : IEnumerable<long>
{
public static readonly long[] Value=A163599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163599.Bytes);
public long this[int i]=>Value[i];

public static A163599Inst Instance=new A163599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163600
{
public static readonly BigInteger[] Value={ 1L,35L,1190L,40460L,1375640L,46771165L,1590199380L,54066091695L,1838223751980L,62498813135220L,2124932636259510L,72246791293015185L,2456359680805901640L,BigInteger.Parse("83515167573569420535"),BigInteger.Parse("2839479604449882838290"),BigInteger.Parse("96541079403144247211340") };
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
public class A163600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163600Inst Instance=new A163600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163601
{
public static readonly BigInteger[] Value={ 1L,36L,1260L,44100L,1543500L,54021870L,1890743400L,66175247880L,2316106686600L,81062789409000L,2837164567941270L,99299602743358500L,3475445596778953980L,BigInteger.Parse("121639178430430006500"),BigInteger.Parse("4257321634653990493500"),BigInteger.Parse("149004520868736130568670") };
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
public class A163601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A163601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A163601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A163601Inst Instance=new A163601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163602
{
public static readonly long[] Value={ 1L,15L,20L,28L,17L,19L,44L,52L,29L,31L,68L,76L,41L,43L,92L,49L,51L,53L,55L,116L,124L,65L,67L,69L,71L,148L,77L,79L,164L,172L,89L,91L,188L,97L,99L,101L,103L,212L,109L,111L,113L,115L,236L,244L,125L,127L,129L,131L,268L,137L,139L,284L,292L,149L,151L,153L,155L,316L,161L,163L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163602Inst : IEnumerable<long>
{
public static readonly long[] Value=A163602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163602.Bytes);
public long this[int i]=>Value[i];

public static A163602Inst Instance=new A163602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163603
{
public static readonly long[] Value={ 3L,8L,15L,18L,24L,27L,32L,40L,50L,55L,58L,65L,76L,78L,85L,91L,97L,99L,108L,111L,123L,125L,128L,130L,135L,149L,154L,158L,164L,170L,180L,184L,191L,194L,200L,203L,207L,214L,216L,227L,229L,237L,242L,246L,252L,260L,266L,271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163603Inst : IEnumerable<long>
{
public static readonly long[] Value=A163603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163603.Bytes);
public long this[int i]=>Value[i];

public static A163603Inst Instance=new A163603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A163604
{
public static readonly long[] Value={ 3L,16L,86L,464L,2508L,13568L,73432L,397504L,2151984L,11650816L,63078752L,341518592L,1849046208L,10011109376L,54202228096L,293462293504L,1588867154688L,8602465128448L,46575580861952L,252170135097344L,1365302948711424L,7392041698328576L,40022092304668672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A163604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A163604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A163604Inst : IEnumerable<long>
{
public static readonly long[] Value=A163604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A163604.Bytes);
public long this[int i]=>Value[i];

public static A163604Inst Instance=new A163604Inst();

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