using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A125717
{
public static readonly long[] Value={ 0L,1L,3L,6L,2L,7L,13L,20L,4L,22L,12L,23L,11L,24L,10L,25L,9L,26L,8L,27L,47L,5L,49L,72L,48L,73L,21L,75L,19L,77L,17L,79L,15L,81L,115L,45L,117L,43L,119L,41L,121L,39L,123L,37L,125L,35L,127L,33L,129L,31L,131L,29L,133L,80L,134L,189L,245L,74L,16L,193L,253L,70L,132L,69L,197L,67L,199L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125717Inst : IEnumerable<long>
{
public static readonly long[] Value=A125717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125717.Bytes);
public long this[int i]=>Value[i];

public static A125717Inst Instance=new A125717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125718
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,13L,10L,11L,5L,9L,20L,25L,15L,29L,17L,21L,8L,43L,48L,31L,52L,35L,14L,41L,22L,23L,49L,51L,80L,53L,34L,67L,38L,37L,44L,79L,46L,87L,50L,93L,56L,55L,19L,61L,62L,107L,70L,127L,129L,179L,131L,83L,82L,89L,92L,39L,98L,97L,100L,101L,161L,45L,118L,119L,183L,185L,63L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125718Inst : IEnumerable<long>
{
public static readonly long[] Value=A125718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125718.Bytes);
public long this[int i]=>Value[i];

public static A125718Inst Instance=new A125718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125719
{
public static readonly long[] Value={ 1L,7L,5L,16L,14L,9L,12L,20L,15L,18L,31L,13L,21L,21L,29L,11L,24L,19L,27L,27L,27L,27L,22L,22L,30L,25L,30L,38L,25L,12L,46L,20L,28L,33L,15L,15L,28L,23L,23L,23L,23L,18L,44L,31L,18L,31L,31L,44L,13L,26L,26L,26L,21L,39L,34L,34L,21L,34L,16L,34L,34L,29L,29L,29L,29L,29L,24L,37L,37L,24L,24L,24L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125719Inst : IEnumerable<long>
{
public static readonly long[] Value=A125719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125719.Bytes);
public long this[int i]=>Value[i];

public static A125719Inst Instance=new A125719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125752
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,8L,26L,69L,77L,55L,261L,806L,1088L,920L,610L,4062L,14362L,22887L,22856L,17034L,10946L,98912L,395253L,728605L,847832L,721756L,502606L,317811L,3809193L,17008391L,35644614L,47557978L,46166656L,35655012L,23828383L,14930352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125752Inst : IEnumerable<long>
{
public static readonly long[] Value=A125752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125752.Bytes);
public long this[int i]=>Value[i];

public static A125752Inst Instance=new A125752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125753
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,1L,0L,0L,2L,5L,12L,6L,5L,1L,1L,0L,0L,0L,5L,12L,35L,108L,73L,76L,80L,25L,15L,15L,0L,0L,0L,0L,12L,35L,108L,369L,1285L,1044L,1475L,2205L,2643L,983L,1050L,1208L,958L,0L,0L,0L,0L,0L,35L,108L,369L,1285L,4655L,17073L,15980L,26548L,48766L,79579L,99860L,45898L,60433L,89890L,109424L,84312L,0L,0L,0L,0L,0L,0L,108L,369L,1285L,4655L,17073L,63600L,238591L,245955L,458397L,948201L,1857965L,3160371L,4153971L,2217787L,3402761L,5855953L,9067535L,11402651L,9170285L,0L,0L,0L,0L,0L,0L,0L,369L,1285L,4655L,17073L,63600L,238591L,901971L,3426576L,3807508L,7710844L,17354771L,37983463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125753Inst : IEnumerable<long>
{
public static readonly long[] Value=A125753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125753.Bytes);
public long this[int i]=>Value[i];

public static A125753Inst Instance=new A125753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125754
{
public static readonly long[] Value={ 2L,4L,10L,17L,18L,20L,24L,36L,42L,140L,145L,170L,200L,292L,561L,594L,660L,682L,792L,1059L,1136L,1553L,1800L,2340L,2730L,4150L,4274L,4297L,4308L,4389L,4433L,4490L,4634L,4696L,4705L,4741L,4804L,4876L,5133L,5164L,5218L,5254L,5400L,5409L,5668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125754Inst : IEnumerable<long>
{
public static readonly long[] Value=A125754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125754.Bytes);
public long this[int i]=>Value[i];

public static A125754Inst Instance=new A125754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125755
{
public static readonly long[] Value={ -2L,4L,-2L,-11L,-14L,-20L,-32L,4L,-2L,16L,13L,-2L,40L,4L,-11L,-14L,-20L,-2L,-32L,4L,16L,13L,40L,4L,-2L,40L,58L,49L,76L,43L,61L,70L,58L,112L,85L,67L,148L,112L,61L,88L,106L,88L,160L,133L,196L,304L,277L,148L,130L,184L,256L,202L,184L,400L,832L,4L,16L,4L,-2L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125755Inst : IEnumerable<long>
{
public static readonly long[] Value=A125755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125755.Bytes);
public long this[int i]=>Value[i];

public static A125755Inst Instance=new A125755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125756
{
public static readonly long[] Value={ 4L,36L,140L,145L,200L,292L,1059L,1136L,1553L,1800L,2340L,4150L,4274L,4297L,4308L,4389L,4433L,4490L,4634L,4696L,4705L,4741L,4804L,4876L,5133L,5164L,5218L,5254L,5400L,5409L,5668L,5712L,5761L,6244L,6290L,6312L,6448L,6466L,6662L,6800L,6976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125756Inst : IEnumerable<long>
{
public static readonly long[] Value=A125756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125756.Bytes);
public long this[int i]=>Value[i];

public static A125756Inst Instance=new A125756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125757
{
public static readonly long[] Value={ 4L,4L,16L,13L,40L,4L,4L,16L,13L,40L,4L,40L,58L,49L,76L,43L,61L,70L,58L,112L,85L,67L,148L,112L,61L,88L,106L,88L,160L,133L,196L,304L,277L,148L,130L,184L,256L,202L,184L,400L,832L,4L,16L,4L,13L,40L,4L,7L,16L,16L,13L,40L,52L,34L,22L,40L,4L,16L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125757Inst : IEnumerable<long>
{
public static readonly long[] Value=A125757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125757.Bytes);
public long this[int i]=>Value[i];

public static A125757Inst Instance=new A125757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125758
{
public static readonly long[] Value={ 4L,7L,13L,16L,22L,25L,31L,34L,40L,43L,49L,52L,58L,61L,67L,70L,76L,79L,85L,88L,94L,97L,103L,106L,112L,115L,121L,124L,130L,133L,139L,142L,148L,151L,157L,160L,166L,169L,175L,178L,184L,187L,193L,196L,202L,205L,211L,214L,220L,223L,229L,232L,238L,241L,247L,250L,256L,259L,265L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125758Inst : IEnumerable<long>
{
public static readonly long[] Value=A125758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125758.Bytes);
public long this[int i]=>Value[i];

public static A125758Inst Instance=new A125758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125759
{
public static readonly long[] Value={ 1L,6L,34L,448L,13384L,684236L,52267569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125759Inst : IEnumerable<long>
{
public static readonly long[] Value=A125759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125759.Bytes);
public long this[int i]=>Value[i];

public static A125759Inst Instance=new A125759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125760
{
public static readonly BigInteger[] Value={ 1L,1L,4L,432L,11943936L,1031956070400000L,BigInteger.Parse("4159895825138319360000000000"),BigInteger.Parse("13809882382682787973867537170432000000000000000"),BigInteger.Parse("769161257109634779902443718589603914508004789479014400000000000000000000"),BigInteger.Parse("16596916396875768196482032091931000424134701157007816971266990744831779993781534720000000000000000000000000") };
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
public class A125760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A125760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A125760Inst Instance=new A125760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125761
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,1L,1L,2L,5L,12L,6L,5L,1L,1L,1L,1L,2L,5L,12L,35L,108L,73L,76L,80L,25L,15L,15L,1L,1L,2L,5L,12L,35L,108L,369L,1285L,1044L,1475L,2205L,2643L,983L,1050L,1208L,958L,1L,1L,2L,5L,12L,35L,108L,369L,1285L,4655L,17073L,15980L,26548L,48766L,79579L,99860L,45898L,60433L,89890L,109424L,84312L,1L,1L,2L,5L,12L,35L,108L,369L,1285L,4655L,17073L,63600L,238591L,245955L,458397L,948201L,1857965L,3160371L,4153971L,2217787L,3402761L,5855953L,9067535L,11402651L,9170285L,1L,1L,2L,5L,12L,35L,108L,369L,1285L,4655L,17073L,63600L,238591L,901971L,3426576L,3807508L,7710844L,17354771L,37983463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125761Inst : IEnumerable<long>
{
public static readonly long[] Value=A125761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125761.Bytes);
public long this[int i]=>Value[i];

public static A125761Inst Instance=new A125761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125762
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,4L,0L,0L,16L,40L,0L,0L,194L,274L,0L,0L,2384L,4719L,0L,0L,31856L,62124L,0L,0L,426502L,817717L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125762Inst : IEnumerable<long>
{
public static readonly long[] Value=A125762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125762.Bytes);
public long this[int i]=>Value[i];

public static A125762Inst Instance=new A125762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125763
{
public static readonly long[] Value={ 1L,2L,3L,20L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125763Inst : IEnumerable<long>
{
public static readonly long[] Value=A125763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125763.Bytes);
public long this[int i]=>Value[i];

public static A125763Inst Instance=new A125763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125764
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,3L,10L,15L,12L,4L,15L,26L,27L,18L,5L,21L,40L,48L,42L,25L,6L,28L,57L,75L,76L,60L,33L,7L,36L,77L,108L,120L,110L,81L,42L,8L,45L,100L,147L,174L,175L,150L,105L,52L,9L,55L,126L,192L,238L,255L,240L,196L,132L,63L,10L,66L,155L,243L,312L,350L,351L,315L,248L,162L,75L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125764Inst : IEnumerable<long>
{
public static readonly long[] Value=A125764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125764.Bytes);
public long this[int i]=>Value[i];

public static A125764Inst Instance=new A125764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125765
{
public static readonly long[] Value={ 2L,5L,19L,13L,181L,59L,463L,439L,2699L,281L,2309L,541L,8191L,2141L,6091L,3697L,11321L,1889L,38303L,7019L,24697L,8933L,42089L,11159L,39901L,21319L,61507L,21839L,266221L,17851L,182467L,37633L,104281L,102103L,173249L,40609L,386279L,32719L,229553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125765Inst : IEnumerable<long>
{
public static readonly long[] Value=A125765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125765.Bytes);
public long this[int i]=>Value[i];

public static A125765Inst Instance=new A125765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125766
{
public static readonly long[] Value={ 2L,3L,5L,2L,5L,7L,3L,17L,7L,11L,29L,5L,19L,11L,29L,5L,31L,11L,29L,13L,37L,41L,7L,139L,13L,31L,19L,67L,7L,43L,17L,179L,23L,83L,29L,79L,53L,23L,71L,19L,181L,41L,107L,31L,137L,11L,89L,47L,197L,37L,331L,59L,109L,41L,191L,67L,29L,251L,79L,251L,59L,389L,61L,197L,43L,211L,11L,109L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125766Inst : IEnumerable<long>
{
public static readonly long[] Value=A125766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125766.Bytes);
public long this[int i]=>Value[i];

public static A125766Inst Instance=new A125766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125767
{
public static readonly long[] Value={ 2L,3L,2L,3L,29L,5L,41L,7L,53L,11L,67L,11L,79L,13L,89L,17L,101L,17L,113L,19L,127L,23L,137L,23L,149L,79L,163L,29L,173L,29L,311L,31L,197L,101L,211L,37L,223L,37L,233L,41L,409L,41L,257L,43L,269L,47L,281L,47L,293L,149L,307L,53L,317L,53L,331L,167L,569L,59L,353L,59L,367L,61L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125767Inst : IEnumerable<long>
{
public static readonly long[] Value=A125767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125767.Bytes);
public long this[int i]=>Value[i];

public static A125767Inst Instance=new A125767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125832
{
public static readonly long[] Value={ 5426124L,8139186L,20017998L,21999978L,26690664L,26888862L,29333304L,49821684L,73267326L,97689768L,98666568L,146534652L,147999852L,220197978L,271333062L,274019262L,320221902L,403696293L,471535064L,489372884L,516019504L,518221704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125832Inst : IEnumerable<long>
{
public static readonly long[] Value=A125832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125832.Bytes);
public long this[int i]=>Value[i];

public static A125832Inst Instance=new A125832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125833
{
public static readonly long[] Value={ 0L,3L,18L,93L,468L,2343L,11718L,58593L,292968L,1464843L,7324218L,36621093L,183105468L,915527343L,4577636718L,22888183593L,114440917968L,572204589843L,2861022949218L,14305114746093L,71525573730468L,357627868652343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125833Inst : IEnumerable<long>
{
public static readonly long[] Value=A125833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125833.Bytes);
public long this[int i]=>Value[i];

public static A125833Inst Instance=new A125833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125834
{
public static readonly long[] Value={ 4888884L,8896888L,13345332L,74732526L,100999899L,140732592L,179555376L,269130862L,295777482L,444888444L,734059326L,880968088L,978745768L,1032039008L,1183109928L,1321452132L,1399939992L,1548058512L,1614785172L,1886140256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125834Inst : IEnumerable<long>
{
public static readonly long[] Value=A125834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125834.Bytes);
public long this[int i]=>Value[i];

public static A125834Inst Instance=new A125834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125835
{
public static readonly long[] Value={ 0L,2L,18L,146L,1170L,9362L,74898L,599186L,4793490L,38347922L,306783378L,2454267026L,19634136210L,157073089682L,1256584717458L,10052677739666L,80421421917330L,643371375338642L,5146971002709138L,41175768021673106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125835Inst : IEnumerable<long>
{
public static readonly long[] Value=A125835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125835.Bytes);
public long this[int i]=>Value[i];

public static A125835Inst Instance=new A125835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125836
{
public static readonly long[] Value={ 0L,5L,45L,365L,2925L,23405L,187245L,1497965L,11983725L,95869805L,766958445L,6135667565L,49085340525L,392682724205L,3141461793645L,25131694349165L,201053554793325L,1608428438346605L,12867427506772845L,102939420054182765L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125836Inst : IEnumerable<long>
{
public static readonly long[] Value=A125836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125836.Bytes);
public long this[int i]=>Value[i];

public static A125836Inst Instance=new A125836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125837
{
public static readonly long[] Value={ 0L,6L,54L,438L,3510L,28086L,224694L,1797558L,14380470L,115043766L,920350134L,7362801078L,58902408630L,471219269046L,3769754152374L,30158033218998L,241264265751990L,1930114126015926L,15440913008127414L,123527304065019318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125837Inst : IEnumerable<long>
{
public static readonly long[] Value=A125837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125837.Bytes);
public long this[int i]=>Value[i];

public static A125837Inst Instance=new A125837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125838
{
public static readonly long[] Value={ 2L,2L,2L,6L,120L,120L,2894220L,397073040L,1236161850L,764907546690L,8955490023480L,138393712627170L,8047290924923250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125838Inst : IEnumerable<long>
{
public static readonly long[] Value=A125838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125838.Bytes);
public long this[int i]=>Value[i];

public static A125838Inst Instance=new A125838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125839
{
public static readonly long[] Value={ 1L,1L,6L,18L,120L,1260L,1485540L,28667100L,28667100L,842889105240L,2281585556250L,163881570370980L,45187548280664790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125839Inst : IEnumerable<long>
{
public static readonly long[] Value=A125839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125839.Bytes);
public long this[int i]=>Value[i];

public static A125839Inst Instance=new A125839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125840
{
public static readonly long[] Value={ 1123L,21911L,3116111L,11413111L,12111331L,14111311L,316111111L,1111131821L,11112119111L,11161211111L,111161111311L,111211231111L,1111112111191L,2111191111111L,11131211113111L,21111121126111L,31111127111111L,111211151611111L,111211222111123L,121132111712111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125840Inst : IEnumerable<long>
{
public static readonly long[] Value=A125840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125840.Bytes);
public long this[int i]=>Value[i];

public static A125840Inst Instance=new A125840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125841
{
public static readonly long[] Value={ 144L,288L,1728L,5184L,7168L,11760L,21632L,21952L,73500L,110592L,113400L,114244L,151263L,153790L,186624L,205800L,235298L,250563L,663552L,708588L,1404928L,2976750L,3449628L,4738500L,5265000L,7077888L,9437184L,11529602L,11745162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125841Inst : IEnumerable<long>
{
public static readonly long[] Value=A125841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125841.Bytes);
public long this[int i]=>Value[i];

public static A125841Inst Instance=new A125841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125842
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,3L,4L,3L,5L,3L,6L,5L,5L,6L,8L,3L,9L,7L,6L,8L,11L,4L,11L,9L,7L,10L,14L,3L,15L,11L,9L,11L,14L,6L,18L,13L,10L,11L,20L,6L,21L,14L,9L,15L,23L,8L,23L,13L,15L,17L,26L,10L,22L,16L,17L,18L,29L,7L,30L,20L,15L,21L,27L,8L,33L,23L,20L,17L,35L,12L,36L,23L,17L,24L,30L,12L,39L,21L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125842Inst : IEnumerable<long>
{
public static readonly long[] Value=A125842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125842.Bytes);
public long this[int i]=>Value[i];

public static A125842Inst Instance=new A125842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125843
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,3L,5L,3L,7L,3L,10L,9L,7L,12L,16L,8L,21L,15L,12L,27L,31L,15L,29L,30L,29L,32L,53L,17L,60L,46L,36L,46L,59L,22L,96L,67L,60L,62L,132L,8L,144L,109L,45L,140L,202L,53L,182L,149L,120L,184L,276L,111L,230L,178L,181L,208L,390L,176L,407L,252L,237L,283L,378L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125843Inst : IEnumerable<long>
{
public static readonly long[] Value=A125843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125843.Bytes);
public long this[int i]=>Value[i];

public static A125843Inst Instance=new A125843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125844
{
public static readonly long[] Value={ 1L,5L,3L,2L,7L,11L,9L,4L,13L,17L,19L,8L,15L,23L,6L,21L,10L,25L,29L,27L,14L,31L,12L,35L,33L,16L,37L,41L,39L,22L,43L,47L,18L,49L,20L,45L,53L,24L,51L,26L,55L,59L,57L,32L,61L,28L,65L,63L,34L,67L,71L,69L,38L,73L,30L,77L,79L,40L,75L,83L,36L,81L,44L,85L,89L,46L,87L,50L,91L,42L,95L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125844Inst : IEnumerable<long>
{
public static readonly long[] Value=A125844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125844.Bytes);
public long this[int i]=>Value[i];

public static A125844Inst Instance=new A125844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125845
{
public static readonly long[] Value={ 1L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,121L,169L,289L,361L,529L,841L,961L,1111L,1133L,1177L,1199L,1243L,1313L,1331L,1339L,1391L,1397L,1417L,1441L,1469L,1507L,1529L,1639L,1651L,1661L,1703L,1717L,1727L,1751L,1781L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125845Inst : IEnumerable<long>
{
public static readonly long[] Value=A125845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125845.Bytes);
public long this[int i]=>Value[i];

public static A125845Inst Instance=new A125845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125846
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,24L,63L,288L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125846Inst : IEnumerable<long>
{
public static readonly long[] Value=A125846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125846.Bytes);
public long this[int i]=>Value[i];

public static A125846Inst Instance=new A125846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125847
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,25L,64L,289L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125847Inst : IEnumerable<long>
{
public static readonly long[] Value=A125847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125847.Bytes);
public long this[int i]=>Value[i];

public static A125847Inst Instance=new A125847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125912
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,1L,2L,4L,1L,0L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L,1L,1L,2L,1L,2L,2L,1L,2L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125912Inst : IEnumerable<long>
{
public static readonly long[] Value=A125912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125912.Bytes);
public long this[int i]=>Value[i];

public static A125912Inst Instance=new A125912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125913
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125913Inst : IEnumerable<long>
{
public static readonly long[] Value=A125913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125913.Bytes);
public long this[int i]=>Value[i];

public static A125913Inst Instance=new A125913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125914
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L,1L,1L,2L,2L,2L,2L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125914Inst : IEnumerable<long>
{
public static readonly long[] Value=A125914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125914.Bytes);
public long this[int i]=>Value[i];

public static A125914Inst Instance=new A125914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125915
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125915Inst : IEnumerable<long>
{
public static readonly long[] Value=A125915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125915.Bytes);
public long this[int i]=>Value[i];

public static A125915Inst Instance=new A125915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125916
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,0L,1L,1L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125916Inst : IEnumerable<long>
{
public static readonly long[] Value=A125916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125916.Bytes);
public long this[int i]=>Value[i];

public static A125916Inst Instance=new A125916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125917
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,1L,1L,0L,2L,2L,2L,4L,4L,0L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125917Inst : IEnumerable<long>
{
public static readonly long[] Value=A125917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125917.Bytes);
public long this[int i]=>Value[i];

public static A125917Inst Instance=new A125917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125918
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125918Inst : IEnumerable<long>
{
public static readonly long[] Value=A125918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125918.Bytes);
public long this[int i]=>Value[i];

public static A125918Inst Instance=new A125918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125919
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,0L,2L,1L,4L,0L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125919Inst : IEnumerable<long>
{
public static readonly long[] Value=A125919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125919.Bytes);
public long this[int i]=>Value[i];

public static A125919Inst Instance=new A125919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125920
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,3L,4L,4L,1L,1L,6L,2L,2L,3L,4L,4L,1L,1L,6L,6L,3L,3L,2L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L,4L,1L,1L,6L,6L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125920Inst : IEnumerable<long>
{
public static readonly long[] Value=A125920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125920.Bytes);
public long this[int i]=>Value[i];

public static A125920Inst Instance=new A125920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125921
{
public static readonly long[] Value={ 1L,2L,0L,1L,2L,0L,2L,1L,2L,3L,1L,2L,4L,5L,3L,0L,3L,5L,1L,2L,1L,3L,2L,1L,2L,1L,2L,5L,6L,2L,1L,5L,4L,0L,2L,0L,6L,2L,1L,2L,8L,1L,2L,0L,5L,1L,6L,3L,1L,2L,4L,5L,3L,0L,3L,5L,1L,2L,1L,6L,2L,1L,3L,4L,8L,3L,6L,2L,1L,5L,4L,0L,3L,0L,6L,8L,1L,2L,8L,1L,2L,0L,5L,1L,6L,3L,1L,9L,4L,5L,4L,10L,3L,5L,9L,4L,1L,12L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125921Inst : IEnumerable<long>
{
public static readonly long[] Value=A125921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125921.Bytes);
public long this[int i]=>Value[i];

public static A125921Inst Instance=new A125921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125922
{
public static readonly long[] Value={ 1L,2L,0L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L,2L,1L,2L,3L,0L,1L,0L,3L,0L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125922Inst : IEnumerable<long>
{
public static readonly long[] Value=A125922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125922.Bytes);
public long this[int i]=>Value[i];

public static A125922Inst Instance=new A125922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125923
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,0L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125923Inst : IEnumerable<long>
{
public static readonly long[] Value=A125923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125923.Bytes);
public long this[int i]=>Value[i];

public static A125923Inst Instance=new A125923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125924
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,1L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L,0L,3L,1L,2L,1L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125924Inst : IEnumerable<long>
{
public static readonly long[] Value=A125924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125924.Bytes);
public long this[int i]=>Value[i];

public static A125924Inst Instance=new A125924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125925
{
public static readonly long[] Value={ 1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L,1L,2L,1L,2L,0L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125925Inst : IEnumerable<long>
{
public static readonly long[] Value=A125925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125925.Bytes);
public long this[int i]=>Value[i];

public static A125925Inst Instance=new A125925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125926
{
public static readonly long[] Value={ 1L,2L,3L,4L,0L,1L,2L,3L,4L,1L,5L,2L,3L,1L,4L,7L,2L,1L,0L,4L,3L,2L,1L,4L,0L,2L,6L,4L,0L,2L,3L,4L,0L,1L,2L,3L,4L,1L,5L,2L,3L,1L,4L,7L,2L,1L,0L,4L,3L,2L,1L,4L,0L,2L,6L,4L,0L,2L,3L,4L,0L,1L,2L,3L,4L,1L,5L,2L,3L,1L,4L,7L,2L,1L,0L,4L,3L,2L,1L,4L,0L,2L,6L,4L,0L,2L,3L,4L,0L,1L,2L,3L,4L,1L,5L,2L,3L,1L,4L,7L,2L,1L,0L,4L,3L,2L,1L,4L,0L,2L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125926Inst : IEnumerable<long>
{
public static readonly long[] Value=A125926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125926.Bytes);
public long this[int i]=>Value[i];

public static A125926Inst Instance=new A125926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125927
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,1L,0L,2L,2L,4L,0L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L,1L,2L,2L,1L,1L,2L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125927Inst : IEnumerable<long>
{
public static readonly long[] Value=A125927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125927.Bytes);
public long this[int i]=>Value[i];

public static A125927Inst Instance=new A125927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125976
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,5L,7L,4L,22L,19L,15L,20L,14L,13L,11L,18L,21L,16L,10L,12L,17L,9L,64L,60L,52L,61L,51L,41L,39L,55L,62L,53L,38L,40L,54L,37L,36L,33L,29L,34L,28L,50L,47L,59L,63L,56L,43L,48L,57L,42L,27L,25L,32L,35L,30L,46L,49L,58L,44L,24L,26L,31L,45L,23L,196L,191L,178L,192L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125976Inst : IEnumerable<long>
{
public static readonly long[] Value=A125976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125976.Bytes);
public long this[int i]=>Value[i];

public static A125976Inst Instance=new A125976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125977
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,11L,19L,17L,20L,12L,10L,15L,21L,18L,13L,22L,23L,37L,42L,28L,51L,44L,53L,30L,25L,39L,56L,47L,33L,60L,45L,54L,57L,48L,61L,31L,40L,26L,24L,38L,43L,34L,29L,52L,58L,62L,49L,46L,55L,35L,32L,27L,41L,63L,59L,50L,36L,64L,65L,107L,121L,79L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125977Inst : IEnumerable<long>
{
public static readonly long[] Value=A125977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125977.Bytes);
public long this[int i]=>Value[i];

public static A125977Inst Instance=new A125977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125978
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,17L,12L,16L,21L,10L,18L,11L,14L,20L,13L,15L,19L,22L,23L,45L,31L,44L,58L,26L,49L,30L,42L,57L,35L,48L,56L,63L,24L,46L,32L,43L,59L,25L,47L,28L,37L,54L,34L,40L,53L,62L,27L,50L,29L,38L,55L,33L,39L,51L,61L,36L,41L,52L,60L,64L,65L,129L,87L,128L,170L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125978Inst : IEnumerable<long>
{
public static readonly long[] Value=A125978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125978.Bytes);
public long this[int i]=>Value[i];

public static A125978Inst Instance=new A125978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125979
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,5L,6L,7L,4L,22L,13L,15L,18L,10L,19L,11L,20L,21L,12L,14L,16L,17L,9L,64L,36L,41L,50L,27L,52L,29L,55L,59L,32L,38L,43L,46L,24L,60L,33L,39L,47L,25L,61L,34L,62L,63L,35L,40L,48L,49L,26L,51L,28L,53L,56L,30L,54L,57L,58L,31L,37L,42L,44L,45L,23L,196L,106L,120L,148L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125979Inst : IEnumerable<long>
{
public static readonly long[] Value=A125979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125979.Bytes);
public long this[int i]=>Value[i];

public static A125979Inst Instance=new A125979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125980
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,5L,7L,6L,4L,22L,13L,18L,15L,10L,21L,12L,20L,19L,11L,17L,16L,14L,9L,64L,36L,50L,41L,27L,59L,32L,55L,52L,29L,46L,34L,38L,24L,63L,35L,49L,43L,26L,62L,40L,61L,60L,33L,48L,47L,39L,25L,58L,31L,57L,56L,30L,54L,53L,51L,28L,45L,44L,42L,37L,23L,196L,106L,148L,120L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125980Inst : IEnumerable<long>
{
public static readonly long[] Value=A125980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125980.Bytes);
public long this[int i]=>Value[i];

public static A125980Inst Instance=new A125980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125981
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,17L,18L,20L,22L,21L,12L,13L,15L,16L,19L,10L,11L,14L,9L,45L,46L,48L,50L,49L,54L,55L,61L,63L,64L,57L,59L,62L,58L,31L,32L,34L,36L,35L,40L,41L,43L,44L,47L,52L,53L,60L,56L,26L,27L,29L,30L,33L,38L,39L,42L,51L,24L,25L,28L,37L,23L,129L,130L,132L,134L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125981Inst : IEnumerable<long>
{
public static readonly long[] Value=A125981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125981.Bytes);
public long this[int i]=>Value[i];

public static A125981Inst Instance=new A125981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125982
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,22L,19L,20L,14L,15L,21L,16L,17L,9L,10L,18L,11L,13L,12L,64L,60L,61L,51L,52L,62L,53L,54L,37L,38L,55L,39L,41L,40L,63L,56L,57L,42L,43L,58L,44L,45L,23L,24L,46L,25L,27L,26L,59L,47L,48L,28L,29L,50L,33L,36L,34L,49L,30L,35L,31L,32L,196L,191L,192L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125982Inst : IEnumerable<long>
{
public static readonly long[] Value=A125982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125982.Bytes);
public long this[int i]=>Value[i];

public static A125982Inst Instance=new A125982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125983
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,4L,5L,22L,19L,20L,14L,15L,21L,16L,17L,10L,9L,18L,11L,12L,13L,64L,60L,61L,51L,52L,62L,53L,54L,38L,37L,55L,39L,40L,41L,63L,56L,57L,42L,43L,58L,44L,46L,27L,25L,45L,26L,23L,24L,59L,47L,48L,29L,28L,49L,30L,32L,31L,50L,33L,34L,35L,36L,196L,191L,192L,177L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125983Inst : IEnumerable<long>
{
public static readonly long[] Value=A125983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125983.Bytes);
public long this[int i]=>Value[i];

public static A125983Inst Instance=new A125983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125984
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,6L,4L,18L,17L,20L,21L,22L,12L,13L,15L,16L,19L,10L,11L,14L,9L,49L,50L,46L,48L,45L,55L,54L,57L,59L,58L,61L,62L,63L,64L,32L,31L,34L,35L,36L,40L,41L,43L,47L,44L,52L,53L,56L,60L,26L,27L,29L,30L,33L,38L,39L,42L,51L,24L,25L,28L,37L,23L,143L,142L,146L,147L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125984Inst : IEnumerable<long>
{
public static readonly long[] Value=A125984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125984.Bytes);
public long this[int i]=>Value[i];

public static A125984Inst Instance=new A125984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125985
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,6L,4L,22L,21L,18L,20L,17L,13L,12L,19L,15L,16L,10L,11L,14L,9L,64L,63L,59L,62L,58L,50L,49L,61L,55L,57L,46L,48L,54L,45L,36L,35L,32L,34L,31L,60L,56L,41L,52L,40L,47L,53L,43L,44L,27L,26L,33L,29L,30L,51L,38L,39L,42L,24L,25L,28L,37L,23L,196L,195L,190L,194L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125985Inst : IEnumerable<long>
{
public static readonly long[] Value=A125985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125985.Bytes);
public long this[int i]=>Value[i];

public static A125985Inst Instance=new A125985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125986
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,7L,5L,4L,22L,19L,20L,15L,14L,21L,17L,18L,13L,11L,16L,12L,10L,9L,64L,60L,61L,52L,51L,62L,54L,55L,41L,39L,53L,40L,38L,37L,63L,57L,58L,46L,44L,59L,49L,50L,36L,33L,47L,34L,29L,28L,56L,45L,48L,35L,31L,43L,32L,27L,25L,42L,30L,26L,24L,23L,196L,191L,192L,178L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125986Inst : IEnumerable<long>
{
public static readonly long[] Value=A125986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125986.Bytes);
public long this[int i]=>Value[i];

public static A125986Inst Instance=new A125986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125987
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,11L,15L,17L,20L,10L,12L,19L,21L,18L,13L,22L,23L,37L,42L,28L,39L,44L,43L,25L,30L,38L,40L,53L,29L,52L,45L,54L,57L,48L,55L,24L,51L,31L,26L,34L,47L,33L,56L,41L,58L,62L,46L,49L,61L,27L,35L,32L,60L,63L,59L,50L,36L,64L,65L,107L,121L,79L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125987Inst : IEnumerable<long>
{
public static readonly long[] Value=A125987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125987.Bytes);
public long this[int i]=>Value[i];

public static A125987Inst Instance=new A125987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125988
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,16L,12L,17L,21L,10L,13L,11L,14L,20L,18L,15L,19L,22L,23L,42L,30L,45L,56L,26L,35L,31L,44L,58L,48L,46L,57L,63L,24L,32L,27L,33L,50L,25L,29L,28L,37L,53L,47L,40L,54L,62L,43L,36L,34L,38L,41L,49L,39L,51L,61L,59L,55L,52L,60L,64L,65L,121L,84L,128L,163L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125988Inst : IEnumerable<long>
{
public static readonly long[] Value=A125988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125988.Bytes);
public long this[int i]=>Value[i];

public static A125988Inst Instance=new A125988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125989
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,0L,3L,1L,2L,-1L,2L,0L,1L,0L,4L,2L,3L,0L,4L,0L,1L,-2L,3L,1L,2L,-1L,2L,0L,1L,0L,5L,3L,4L,1L,5L,1L,2L,-1L,6L,2L,3L,-2L,3L,-1L,0L,-3L,4L,2L,3L,0L,4L,0L,1L,-2L,3L,1L,2L,-1L,2L,0L,1L,0L,6L,4L,5L,2L,6L,2L,3L,0L,7L,3L,4L,-1L,4L,0L,1L,-2L,8L,4L,5L,0L,6L,0L,1L,-4L,5L,1L,2L,-3L,2L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125989Inst : IEnumerable<long>
{
public static readonly long[] Value=A125989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125989.Bytes);
public long this[int i]=>Value[i];

public static A125989Inst Instance=new A125989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125990
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,9L,13L,17L,22L,28L,30L,30L,30L,38L,45L,45L,45L,45L,45L,53L,59L,59L,59L,59L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125990Inst : IEnumerable<long>
{
public static readonly long[] Value=A125990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125990.Bytes);
public long this[int i]=>Value[i];

public static A125990Inst Instance=new A125990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A125991
{
public static readonly long[] Value={ 0L,8L,16L,24L,64L,72L,80L,88L,128L,136L,144L,152L,192L,200L,208L,216L,512L,520L,528L,536L,576L,584L,592L,600L,640L,648L,656L,664L,704L,712L,720L,728L,2048L,2056L,2064L,2072L,2112L,2120L,2128L,2136L,2176L,2184L,2192L,2200L,2240L,2248L,2256L,2264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A125991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A125991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A125991Inst : IEnumerable<long>
{
public static readonly long[] Value=A125991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A125991.Bytes);
public long this[int i]=>Value[i];

public static A125991Inst Instance=new A125991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126088
{
public static readonly long[] Value={ 1L,3L,1L,3L,2L,4L,13L,5L,9L,10L,6L,8L,61L,121L,3L,13L,17L,79L,45L,27L,120L,145L,113L,11L,41L,198L,102L,139L,202L,103L,23L,48L,177L,43L,486L,169L,501L,251L,106L,132L,40L,155L,1890L,116L,584L,107L,629L,241L,1331L,2078L,562L,57L,52L,71L,567L,73L,262L,332L,483L,419L,423L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126088Inst : IEnumerable<long>
{
public static readonly long[] Value=A126088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126088.Bytes);
public long this[int i]=>Value[i];

public static A126088Inst Instance=new A126088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126089
{
public static readonly BigInteger[] Value={ 1L,-4L,4L,0L,-48L,-960L,-20160L,-483840L,-13305600L,-415134720L,-14529715200L,-564583219200L,-24135932620800L,-1126343522304000L,-56992982228582400L,-3108708121559040000L,BigInteger.Parse("-181859425111203840000"),BigInteger.Parse("-11359219476176732160000"),BigInteger.Parse("-754576722346025779200000") };
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
public class A126089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126089Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126089.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126089Inst Instance=new A126089Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126090
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,3L,6L,3L,5L,5L,10L,6L,12L,7L,8L,5L,16L,8L,18L,13L,7L,11L,22L,10L,17L,14L,18L,16L,28L,9L,30L,11L,12L,20L,11L,16L,36L,22L,12L,23L,40L,14L,42L,28L,19L,29L,46L,22L,39L,28L,15L,33L,52L,28L,16L,29L,17L,36L,58L,20L,60L,38L,25L,22L,15L,23L,66L,43L,23L,20L,70L,37L,72L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126090Inst : IEnumerable<long>
{
public static readonly long[] Value=A126090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126090.Bytes);
public long this[int i]=>Value[i];

public static A126090Inst Instance=new A126090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126091
{
public static readonly long[] Value={ 1L,4L,2L,7L,3L,8L,6L,11L,7L,12L,10L,15L,11L,16L,14L,19L,15L,20L,18L,23L,19L,24L,22L,27L,23L,28L,26L,31L,27L,32L,30L,35L,31L,36L,34L,39L,35L,40L,38L,43L,39L,44L,42L,47L,43L,48L,46L,51L,47L,52L,50L,55L,51L,56L,54L,59L,55L,60L,58L,63L,59L,64L,62L,67L,63L,68L,66L,71L,67L,72L,70L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126091Inst : IEnumerable<long>
{
public static readonly long[] Value=A126091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126091.Bytes);
public long this[int i]=>Value[i];

public static A126091Inst Instance=new A126091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126092
{
public static readonly long[] Value={ 2L,3L,5L,7L,13L,23L,41L,73L,131L,241L,443L,811L,1493L,2741L,5039L,9257L,17033L,31327L,57601L,105953L,194869L,358417L,659237L,1212521L,2230159L,4101907L,7544573L,13876601L,25523011L,46944179L,86343787L,158810947L,292098907L,537253631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126092Inst : IEnumerable<long>
{
public static readonly long[] Value=A126092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126092.Bytes);
public long this[int i]=>Value[i];

public static A126092Inst Instance=new A126092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126093
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,2L,6L,4L,1L,6L,18L,15L,6L,1L,18L,57L,54L,28L,8L,1L,57L,186L,193L,118L,45L,10L,1L,186L,622L,690L,474L,218L,66L,12L,1L,622L,2120L,2476L,1856L,976L,362L,91L,14L,1L,2120L,7338L,8928L,7164L,4170L,1791L,558L,120L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126093Inst : IEnumerable<long>
{
public static readonly long[] Value=A126093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126093.Bytes);
public long this[int i]=>Value[i];

public static A126093Inst Instance=new A126093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126094
{
public static readonly long[] Value={ 4L,7L,22L,83L,5878L,12229L,14871L,43360L,120833116L,284116756L,384239518L,586968768L,2697787565123L,11550434172799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126094Inst : IEnumerable<long>
{
public static readonly long[] Value=A126094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126094.Bytes);
public long this[int i]=>Value[i];

public static A126094Inst Instance=new A126094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126095
{
public static readonly long[] Value={ 47L,79L,83L,89L,113L,127L,157L,163L,167L,211L,251L,257L,293L,317L,331L,353L,359L,367L,373L,379L,383L,389L,397L,401L,439L,443L,449L,467L,479L,487L,491L,499L,503L,541L,547L,557L,577L,587L,607L,647L,673L,677L,683L,691L,701L,709L,719L,727L,733L,739L,743L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126095Inst : IEnumerable<long>
{
public static readonly long[] Value=A126095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126095.Bytes);
public long this[int i]=>Value[i];

public static A126095Inst Instance=new A126095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126096
{
public static readonly long[] Value={ 127L,139L,149L,181L,241L,431L,967L,1021L,1031L,1061L,1597L,1759L,1913L,2113L,2437L,2593L,2833L,2953L,3769L,3793L,3947L,4219L,4261L,4463L,4603L,5011L,5869L,5923L,6449L,6701L,6959L,7103L,7489L,7549L,7727L,8273L,8803L,8839L,9137L,9241L,9421L,9931L,10069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126096Inst : IEnumerable<long>
{
public static readonly long[] Value=A126096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126096.Bytes);
public long this[int i]=>Value[i];

public static A126096Inst Instance=new A126096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126097
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,14L,23L,32L,38L,41L,53L,68L,95L,113L,122L,158L,203L,221L,284L,338L,365L,473L,608L,662L,743L,851L,1013L,1094L,1418L,1823L,1985L,2228L,2363L,2552L,2633L,3038L,3281L,3308L,4253L,5468L,5954L,6683L,7088L,7655L,7898L,9113L,9356L,9842L,9923L,12758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126097Inst : IEnumerable<long>
{
public static readonly long[] Value=A126097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126097.Bytes);
public long this[int i]=>Value[i];

public static A126097Inst Instance=new A126097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126098
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,30L,60L,120L,180L,210L,360L,420L,840L,1260L,1680L,2520L,4620L,7560L,9240L,13860L,18480L,27720L,55440L,83160L,110880L,120120L,180180L,240240L,360360L,720720L,1081080L,1441440L,1801800L,2042040L,2882880L,3063060L,4084080L,5405400L,6126120L,12252240L,18378360L,24504480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126098Inst : IEnumerable<long>
{
public static readonly long[] Value=A126098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126098.Bytes);
public long this[int i]=>Value[i];

public static A126098Inst Instance=new A126098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126099
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,21L,7L,10L,10L,15L,15L,21L,21L,28L,28L,36L,36L,45L,45L,55L,55L,66L,66L,78L,78L,91L,91L,105L,105L,120L,120L,136L,136L,153L,153L,171L,171L,190L,190L,210L,210L,231L,231L,253L,253L,276L,276L,300L,300L,325L,325L,351L,351L,378L,378L,406L,406L,435L,435L,465L,465L,496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126099Inst : IEnumerable<long>
{
public static readonly long[] Value=A126099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126099.Bytes);
public long this[int i]=>Value[i];

public static A126099Inst Instance=new A126099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126100
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,11L,58L,407L,4306L,72489L,2111013L,111172234L,10798144310L,1944301471861L,650202565436890L,404697467417019634L,BigInteger.Parse("470133531223369393920"),BigInteger.Parse("1022561022228933341815171"),BigInteger.Parse("4177761667636803276899047351"),BigInteger.Parse("32163582481439081597751699343141"),BigInteger.Parse("468019937132164016636736323752098741") };
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
public class A126100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126100Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126100.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126100Inst Instance=new A126100Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126101
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,8L,44L,333L,3771L,67141L,2027119L,108880264L,10682138680L,1933264826485L,648235902085512L,404043306773404163L,BigInteger.Parse("1022090075330054063050850"),BigInteger.Parse("469727521267710406698"),BigInteger.Parse("32159402671814249205978139454278"),BigInteger.Parse("4176738163895992397728030132"),BigInteger.Parse("467987765188007308268883267776373304") };
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
public class A126101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126101Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126101.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126101Inst Instance=new A126101Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126102
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,9L,7L,34L,18L,14L,11L,40L,13L,19L,15L,161L,17L,57L,19L,61L,26L,29L,23L,197L,50L,34L,103L,76L,29L,66L,31L,912L,33L,44L,35L,267L,37L,49L,46L,293L,41L,107L,43L,116L,90L,59L,47L,1096L,98L,148L,51L,143L,53L,371L,62L,377L,66L,74L,59L,325L,61L,79L,156L,7068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126102Inst : IEnumerable<long>
{
public static readonly long[] Value=A126102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126102.Bytes);
public long this[int i]=>Value[i];

public static A126102Inst Instance=new A126102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126103
{
public static readonly long[] Value={ 1L,2L,2L,5L,2L,7L,2L,17L,5L,7L,2L,23L,2L,7L,4L,67L,2L,23L,2L,25L,8L,7L,2L,99L,5L,7L,18L,20L,2L,25L,2L,342L,4L,7L,4L,89L,2L,7L,8L,99L,2L,40L,2L,20L,10L,7L,2L,476L,5L,23L,4L,25L,2L,100L,10L,87L,8L,7L,2L,115L,2L,7L,24L,2602L,4L,25L,2L,25L,4L,25L,2L,461L,2L,7L,13L,20L,4L,40L,2L,504L,79L,7L,2L,141L,4L,7L,4L,83L,2L,83L,4L,20L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126103Inst : IEnumerable<long>
{
public static readonly long[] Value=A126103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126103.Bytes);
public long this[int i]=>Value[i];

public static A126103Inst Instance=new A126103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126136
{
public static readonly long[] Value={ 1L,2L,1L,4L,3L,2L,8L,7L,9L,3L,16L,15L,28L,16L,6L,32L,31L,75L,55L,40L,10L,64L,63L,186L,156L,165L,75L,20L,128L,127L,441L,399L,546L,336L,175L,35L,256L,255L,1016L,960L,1596L,1176L,896L,336L,70L,512L,511L,2295L,2223L,4320L,3564L,3528L,1848L,756L,126L,1024L,1023L,5110L,5020L,11115L,9855L,11880L,7680L,4620L,1470L,252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126136Inst : IEnumerable<long>
{
public static readonly long[] Value=A126136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126136.Bytes);
public long this[int i]=>Value[i];

public static A126136Inst Instance=new A126136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126137
{
public static readonly long[] Value={ 1L,2L,4L,8L,16L,35L,79L,184L,429L,1019L,2467L,6049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126137Inst : IEnumerable<long>
{
public static readonly long[] Value=A126137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126137.Bytes);
public long this[int i]=>Value[i];

public static A126137Inst Instance=new A126137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126138
{
public static readonly long[] Value={ 1L,1L,2L,4L,4L,10L,6L,13L,41L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126138Inst : IEnumerable<long>
{
public static readonly long[] Value=A126138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126138.Bytes);
public long this[int i]=>Value[i];

public static A126138Inst Instance=new A126138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126139
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,8L,5L,11L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126139Inst : IEnumerable<long>
{
public static readonly long[] Value=A126139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126139.Bytes);
public long this[int i]=>Value[i];

public static A126139Inst Instance=new A126139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126140
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,92L,76L,246L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126140Inst : IEnumerable<long>
{
public static readonly long[] Value=A126140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126140.Bytes);
public long this[int i]=>Value[i];

public static A126140Inst Instance=new A126140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126141
{
public static readonly long[] Value={ 1L,1L,15L,1L,45L,21L,153L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126141Inst : IEnumerable<long>
{
public static readonly long[] Value=A126141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126141.Bytes);
public long this[int i]=>Value[i];

public static A126141Inst Instance=new A126141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126142
{
public static readonly long[] Value={ 5L,7L,17L,29L,37L,47L,53L,61L,73L,79L,83L,89L,107L,109L,127L,137L,149L,151L,173L,181L,199L,223L,263L,269L,271L,277L,281L,349L,367L,379L,389L,433L,443L,457L,461L,503L,521L,547L,557L,587L,601L,613L,673L,677L,683L,691L,701L,727L,739L,773L,827L,853L,857L,863L,887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126142Inst : IEnumerable<long>
{
public static readonly long[] Value=A126142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126142.Bytes);
public long this[int i]=>Value[i];

public static A126142Inst Instance=new A126142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126143
{
public static readonly long[] Value={ 13L,17L,23L,37L,47L,67L,107L,139L,181L,193L,211L,223L,229L,241L,283L,307L,311L,313L,331L,337L,349L,353L,367L,373L,389L,397L,421L,433L,439L,487L,499L,523L,547L,571L,577L,587L,607L,613L,631L,709L,719L,727L,739L,751L,773L,787L,839L,853L,877L,881L,907L,983L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126143Inst : IEnumerable<long>
{
public static readonly long[] Value=A126143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126143.Bytes);
public long this[int i]=>Value[i];

public static A126143Inst Instance=new A126143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126144
{
public static readonly long[] Value={ 3L,5L,7L,19L,47L,73L,97L,131L,223L,229L,257L,263L,277L,331L,367L,389L,397L,487L,577L,641L,643L,683L,701L,739L,743L,757L,797L,857L,877L,1031L,1291L,1297L,1423L,1451L,1543L,1579L,1637L,1697L,1723L,1823L,1949L,2039L,2081L,2381L,2477L,2539L,2617L,2659L,2689L,2749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126144Inst : IEnumerable<long>
{
public static readonly long[] Value=A126144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126144.Bytes);
public long this[int i]=>Value[i];

public static A126144Inst Instance=new A126144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126145
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,31L,37L,43L,47L,61L,67L,71L,79L,89L,103L,109L,131L,139L,173L,181L,193L,197L,223L,227L,241L,251L,271L,277L,281L,283L,311L,331L,347L,373L,379L,383L,439L,443L,487L,491L,523L,541L,547L,557L,607L,617L,643L,647L,661L,701L,709L,719L,733L,739L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126145Inst : IEnumerable<long>
{
public static readonly long[] Value=A126145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126145.Bytes);
public long this[int i]=>Value[i];

public static A126145Inst Instance=new A126145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126146
{
public static readonly long[] Value={ 97L,88L,72L,49L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126146Inst : IEnumerable<long>
{
public static readonly long[] Value=A126146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126146.Bytes);
public long this[int i]=>Value[i];

public static A126146Inst Instance=new A126146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126147
{
public static readonly BigInteger[] Value={ 0L,0L,1L,4L,19L,177L,1766L,26868L,421725L,7692857L,208699781L,5420553787L,180993613044L,7075587523888L,278356624078085L,11601694011103611L,552358618257458385L,BigInteger.Parse("31520661477937912115"),BigInteger.Parse("1750572856110551805720") };
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
public class A126147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126147Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126147.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126147Inst Instance=new A126147Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126148
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,19L,23L,41L,43L,47L,59L,79L,83L,89L,101L,109L,113L,137L,163L,167L,173L,223L,229L,257L,311L,383L,389L,409L,419L,439L,443L,479L,521L,547L,557L,577L,593L,613L,643L,647L,683L,773L,797L,809L,811L,853L,953L,983L,1019L,1049L,1097L,1109L,1151L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126148Inst : IEnumerable<long>
{
public static readonly long[] Value=A126148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126148.Bytes);
public long this[int i]=>Value[i];

public static A126148Inst Instance=new A126148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126149
{
public static readonly long[] Value={ 0L,1L,1L,3L,13L,64L,470L,4921L,83997L,2411453L,123544541L,11537642646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126149Inst : IEnumerable<long>
{
public static readonly long[] Value=A126149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126149.Bytes);
public long this[int i]=>Value[i];

public static A126149Inst Instance=new A126149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126150
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,24L,36L,24L,6L,96L,384L,636L,744L,636L,384L,96L,2976L,11904L,20256L,26304L,28536L,26304L,20256L,11904L,2976L,151416L,605664L,1042056L,1407024L,1650456L,1736064L,1650456L,1407024L,1042056L,605664L,151416L,11449296L,45797184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126150Inst : IEnumerable<long>
{
public static readonly long[] Value=A126150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126150.Bytes);
public long this[int i]=>Value[i];

public static A126150Inst Instance=new A126150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126151
{
public static readonly BigInteger[] Value={ 1L,1L,6L,96L,2976L,151416L,11449296L,1204566336L,168233625216L,30110372009856L,6719377991060736L,1829013279998846976L,BigInteger.Parse("596449130341224185856"),BigInteger.Parse("229556544889929225117696"),BigInteger.Parse("102956750031135241952280576") };
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
public class A126151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126151Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126151.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126151Inst Instance=new A126151Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126168
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,6L,1L,7L,1L,8L,1L,8L,1L,10L,9L,1L,1L,12L,1L,10L,11L,14L,1L,36L,1L,16L,13L,12L,1L,42L,1L,19L,15L,20L,13L,14L,1L,22L,17L,50L,1L,54L,1L,16L,15L,26L,1L,20L,1L,28L,21L,18L,1L,66L,17L,64L,23L,32L,1L,60L,1L,34L,17L,21L,19L,78L,1L,22L,27L,74L,1L,78L,1L,40L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126168Inst : IEnumerable<long>
{
public static readonly long[] Value=A126168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126168.Bytes);
public long this[int i]=>Value[i];

public static A126168Inst Instance=new A126168Inst();

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