using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190727
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,1L,4L,7L,10L,13L,16L,19L,22L,25L,28L,2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,3L,8L,13L,18L,23L,28L,33L,38L,43L,48L,4L,10L,16L,22L,28L,34L,40L,46L,52L,58L,5L,12L,19L,26L,33L,40L,47L,54L,61L,68L,6L,14L,22L,30L,38L,46L,54L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190727Inst : IEnumerable<long>
{
public static readonly long[] Value=A190727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190727.Bytes);
public long this[int i]=>Value[i];

public static A190727Inst Instance=new A190727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190726
{
public static readonly BigInteger[] Value={ 1L,6L,62L,720L,8806L,110916L,1423796L,18520788L,243289670L,3220011684L,42872967012L,573608356272L,7705343534716L,103857425975400L,1403902871946000L,19024773303675420L,258372666772083270L,3515644245559211172L,BigInteger.Parse("47918193512409831380") };
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
public class A190726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190726Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190726.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190726.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190726Inst Instance=new A190726Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190725
{
public static readonly long[] Value={ 1L,3L,14L,69L,355L,1872L,10037L,54459L,298138L,1643565L,9111191L,50739120L,283635481L,1590648819L,8945090870L,50423423685L,284831065723L,1611918320688L,9137141645645L,51869777201595L,294843392318146L,1677980087882013L,9559901907126959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190725Inst : IEnumerable<long>
{
public static readonly long[] Value=A190725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190725.Bytes);
public long this[int i]=>Value[i];

public static A190725Inst Instance=new A190725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190724
{
public static readonly long[] Value={ 1L,4L,20L,106L,576L,3174L,17648L,98746L,555104L,3131854L,17720880L,100507554L,571179792L,3251459670L,18535914480L,105803208906L,604598535360L,3458315246238L,19799128470896L,113441876080306L,650450158678256L,3731985710892454L,21425304596140080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190724Inst : IEnumerable<long>
{
public static readonly long[] Value=A190724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190724.Bytes);
public long this[int i]=>Value[i];

public static A190724Inst Instance=new A190724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190723
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,11L,15L,19L,20L,22L,26L,27L,29L,33L,37L,38L,40L,44L,48L,49L,51L,55L,56L,58L,62L,66L,67L,69L,73L,74L,76L,80L,84L,85L,87L,91L,95L,96L,98L,102L,103L,105L,109L,113L,114L,116L,120L,124L,125L,127L,131L,132L,134L,138L,142L,143L,145L,149L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190723Inst : IEnumerable<long>
{
public static readonly long[] Value=A190723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190723.Bytes);
public long this[int i]=>Value[i];

public static A190723Inst Instance=new A190723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190722
{
public static readonly long[] Value={ 3L,45751L,149351L,171529L,223099L,434237L,678077L,706841L,1996297L,3993037L,6340457L,7199113L,7419761L,9000317L,13129271L,15052777L,17193217L,18436879L,18749881L,18998519L,23353469L,23689423L,33746663L,40985411L,41437751L,43547797L,51198097L,53773651L,56825687L,60207809L,62190113L,79778899L,81708353L,83019421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190722Inst : IEnumerable<long>
{
public static readonly long[] Value=A190722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190722.Bytes);
public long this[int i]=>Value[i];

public static A190722Inst Instance=new A190722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190721
{
public static readonly long[] Value={ 3L,5L,6L,10L,13L,14L,17L,21L,23L,24L,28L,31L,32L,35L,39L,42L,43L,46L,50L,52L,53L,57L,60L,61L,64L,68L,70L,71L,75L,78L,79L,82L,86L,89L,90L,93L,97L,99L,100L,104L,107L,108L,111L,115L,118L,119L,122L,126L,128L,129L,133L,136L,137L,140L,144L,146L,147L,151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190721Inst : IEnumerable<long>
{
public static readonly long[] Value=A190721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190721.Bytes);
public long this[int i]=>Value[i];

public static A190721Inst Instance=new A190721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190720
{
public static readonly long[] Value={ 7L,12L,16L,18L,25L,30L,34L,36L,41L,45L,47L,54L,59L,63L,65L,72L,77L,81L,83L,88L,92L,94L,101L,106L,110L,112L,117L,121L,123L,130L,135L,139L,141L,148L,153L,157L,159L,164L,168L,170L,177L,182L,186L,188L,195L,200L,204L,206L,211L,215L,217L,224L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190720Inst : IEnumerable<long>
{
public static readonly long[] Value=A190720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190720.Bytes);
public long this[int i]=>Value[i];

public static A190720Inst Instance=new A190720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190719
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,8L,11L,12L,13L,15L,17L,19L,20L,23L,24L,25L,27L,29L,31L,32L,35L,36L,37L,39L,41L,43L,44L,47L,48L,49L,51L,53L,55L,56L,59L,60L,61L,63L,65L,67L,68L,71L,72L,73L,75L,77L,79L,80L,83L,84L,85L,87L,89L,91L,92L,95L,96L,97L,99L,101L,103L,104L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190719Inst : IEnumerable<long>
{
public static readonly long[] Value=A190719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190719.Bytes);
public long this[int i]=>Value[i];

public static A190719Inst Instance=new A190719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190718
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,4L,4L,4L,10L,10L,10L,10L,20L,20L,20L,20L,35L,35L,35L,35L,56L,56L,56L,56L,84L,84L,84L,84L,120L,120L,120L,120L,165L,165L,165L,165L,220L,220L,220L,220L,286L,286L,286L,286L,364L,364L,364L,364L,455L,455L,455L,455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190718Inst : IEnumerable<long>
{
public static readonly long[] Value=A190718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190718.Bytes);
public long this[int i]=>Value[i];

public static A190718Inst Instance=new A190718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190717
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,4L,10L,10L,10L,20L,20L,20L,35L,35L,35L,56L,56L,56L,84L,84L,84L,120L,120L,120L,165L,165L,165L,220L,220L,220L,286L,286L,286L,364L,364L,364L,455L,455L,455L,560L,560L,560L,680L,680L,680L,816L,816L,816L,969L,969L,969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190717Inst : IEnumerable<long>
{
public static readonly long[] Value=A190717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190717.Bytes);
public long this[int i]=>Value[i];

public static A190717Inst Instance=new A190717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190716
{
public static readonly long[] Value={ 1L,2L,7L,4L,21L,6L,43L,8L,73L,10L,111L,12L,157L,14L,211L,16L,273L,18L,343L,20L,421L,22L,507L,24L,601L,26L,703L,28L,813L,30L,931L,32L,1057L,34L,1191L,36L,1333L,38L,1483L,40L,1641L,42L,1807L,44L,1981L,46L,2163L,48L,2353L,50L,2551L,52L,2757L,54L,2971L,56L,3193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190716Inst : IEnumerable<long>
{
public static readonly long[] Value=A190716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190716.Bytes);
public long this[int i]=>Value[i];

public static A190716Inst Instance=new A190716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190683
{
public static readonly long[] Value={ 2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L,2L,1L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190683Inst : IEnumerable<long>
{
public static readonly long[] Value=A190683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190683.Bytes);
public long this[int i]=>Value[i];

public static A190683Inst Instance=new A190683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190682
{
public static readonly long[] Value={ 582169L,588289L,1136356L,1183744L,1454436L,1700416L,2030625L,2424249L,2436721L,2669956L,2732409L,2930944L,3024121L,3175524L,3305124L,3381921L,3481956L,3526884L,3900625L,4129024L,4182025L,4223025L,4553956L,4804864L,4981824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190682Inst : IEnumerable<long>
{
public static readonly long[] Value=A190682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190682.Bytes);
public long this[int i]=>Value[i];

public static A190682Inst Instance=new A190682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190681
{
public static readonly long[] Value={ 0L,0L,2L,61L,899L,11219L,126905L,1374229L,14529946L,151426672L,1563147978L,16031036348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190681Inst : IEnumerable<long>
{
public static readonly long[] Value=A190681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190681.Bytes);
public long this[int i]=>Value[i];

public static A190681Inst Instance=new A190681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190680
{
public static readonly long[] Value={ 11L,251L,1429L,906949L,1050449L,1058389L,3728113L,9665329L,13623667L,14320489L,30668003L,30910391L,45717377L,49437001L,55544959L,57510911L,58206653L,58772257L,69490901L,72191321L,73625789L,75235973L,79396433L,99673891L,103821169L,104662139L,121322449L,125938889L,147210257L,164810311L,169844879L,170650169L,201991721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190680Inst : IEnumerable<long>
{
public static readonly long[] Value=A190680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190680.Bytes);
public long this[int i]=>Value[i];

public static A190680Inst Instance=new A190680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190679
{
public static readonly long[] Value={ 1L,4L,8L,12L,15L,16L,19L,23L,27L,30L,31L,34L,38L,42L,45L,46L,49L,53L,56L,57L,60L,64L,68L,71L,72L,75L,79L,83L,86L,87L,90L,94L,98L,101L,102L,105L,109L,112L,113L,116L,120L,124L,127L,128L,131L,135L,139L,142L,143L,146L,150L,154L,157L,161L,165L,168L,169L,172L,176L,180L,183L,184L,187L,191L,195L,198L,199L,202L,206L,209L,210L,213L,217L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190679Inst : IEnumerable<long>
{
public static readonly long[] Value=A190679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190679.Bytes);
public long this[int i]=>Value[i];

public static A190679Inst Instance=new A190679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190678
{
public static readonly long[] Value={ 2L,5L,6L,9L,13L,17L,20L,21L,24L,28L,32L,35L,36L,39L,43L,47L,50L,51L,54L,58L,61L,62L,65L,69L,73L,76L,77L,80L,84L,88L,91L,92L,95L,99L,103L,106L,110L,114L,117L,118L,121L,125L,129L,132L,133L,136L,140L,144L,147L,148L,151L,155L,158L,159L,162L,166L,170L,173L,174L,177L,181L,185L,188L,189L,192L,196L,200L,203L,204L,207L,211L,214L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190678Inst : IEnumerable<long>
{
public static readonly long[] Value=A190678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190678.Bytes);
public long this[int i]=>Value[i];

public static A190678Inst Instance=new A190678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190677
{
public static readonly long[] Value={ 3L,7L,10L,11L,14L,18L,22L,25L,26L,29L,33L,37L,40L,41L,44L,48L,52L,55L,59L,63L,66L,67L,70L,74L,78L,81L,82L,85L,89L,93L,96L,97L,100L,104L,107L,108L,111L,115L,119L,122L,123L,126L,130L,134L,137L,138L,141L,145L,149L,152L,153L,156L,160L,163L,164L,167L,171L,175L,178L,179L,182L,186L,190L,193L,194L,197L,201L,205L,208L,212L,216L,219L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190677Inst : IEnumerable<long>
{
public static readonly long[] Value=A190677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190677.Bytes);
public long this[int i]=>Value[i];

public static A190677Inst Instance=new A190677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190676
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190676Inst : IEnumerable<long>
{
public static readonly long[] Value=A190676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190676.Bytes);
public long this[int i]=>Value[i];

public static A190676Inst Instance=new A190676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190675
{
public static readonly long[] Value={ 1L,4L,5L,8L,12L,15L,16L,19L,20L,23L,27L,30L,31L,34L,38L,42L,45L,46L,49L,53L,56L,57L,60L,61L,64L,68L,71L,72L,75L,76L,79L,83L,86L,87L,90L,94L,98L,101L,102L,105L,109L,112L,113L,116L,117L,120L,124L,127L,128L,131L,135L,139L,142L,143L,146L,150L,154L,157L,158L,161L,165L,168L,169L,172L,173L,176L,180L,183L,184L,187L,191L,195L,198L,199L,202L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190675Inst : IEnumerable<long>
{
public static readonly long[] Value=A190675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190675.Bytes);
public long this[int i]=>Value[i];

public static A190675Inst Instance=new A190675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190674
{
public static readonly long[] Value={ 2L,3L,6L,9L,10L,13L,14L,17L,18L,21L,24L,25L,28L,29L,32L,33L,35L,36L,39L,40L,43L,44L,47L,48L,50L,51L,54L,55L,58L,59L,62L,65L,66L,69L,70L,73L,74L,77L,80L,81L,84L,85L,88L,89L,91L,92L,95L,96L,99L,100L,103L,106L,107L,110L,111L,114L,115L,118L,121L,122L,125L,126L,129L,130L,132L,133L,136L,137L,140L,141L,144L,145L,147L,148L,151L,152L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190674Inst : IEnumerable<long>
{
public static readonly long[] Value=A190674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190674.Bytes);
public long this[int i]=>Value[i];

public static A190674Inst Instance=new A190674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190673
{
public static readonly long[] Value={ 7L,11L,22L,26L,37L,41L,52L,63L,67L,78L,82L,93L,97L,104L,108L,119L,123L,134L,138L,149L,153L,160L,164L,175L,179L,190L,194L,205L,216L,220L,231L,235L,246L,250L,261L,272L,276L,287L,291L,302L,306L,313L,317L,328L,332L,343L,347L,358L,362L,369L,373L,384L,388L,399L,403L,414L,425L,429L,440L,444L,455L,459L,470L,481L,485L,496L,500L,511L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190673Inst : IEnumerable<long>
{
public static readonly long[] Value=A190673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190673.Bytes);
public long this[int i]=>Value[i];

public static A190673Inst Instance=new A190673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190672
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,0L,2L,1L,1L,0L,2L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190672Inst : IEnumerable<long>
{
public static readonly long[] Value=A190672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190672.Bytes);
public long this[int i]=>Value[i];

public static A190672Inst Instance=new A190672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190671
{
public static readonly long[] Value={ 1L,4L,5L,8L,9L,12L,13L,15L,16L,19L,20L,23L,24L,27L,30L,31L,34L,35L,38L,39L,42L,45L,46L,49L,50L,53L,54L,56L,57L,60L,61L,64L,65L,68L,69L,71L,72L,75L,76L,79L,80L,83L,86L,87L,90L,91L,94L,95L,98L,101L,102L,105L,106L,109L,110L,112L,113L,116L,117L,120L,121L,124L,125L,127L,128L,131L,132L,135L,136L,139L,142L,143L,146L,147L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190671Inst : IEnumerable<long>
{
public static readonly long[] Value=A190671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190671.Bytes);
public long this[int i]=>Value[i];

public static A190671Inst Instance=new A190671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190670
{
public static readonly long[] Value={ 2L,3L,6L,7L,10L,11L,14L,17L,18L,21L,22L,25L,26L,28L,29L,32L,33L,36L,37L,40L,41L,43L,44L,47L,48L,51L,52L,55L,58L,59L,62L,63L,66L,67L,70L,73L,74L,77L,78L,81L,82L,84L,85L,88L,89L,92L,93L,96L,97L,99L,100L,103L,104L,107L,108L,111L,114L,115L,118L,119L,122L,123L,126L,129L,130L,133L,134L,137L,138L,140L,141L,144L,145L,148L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190670Inst : IEnumerable<long>
{
public static readonly long[] Value=A190670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190670.Bytes);
public long this[int i]=>Value[i];

public static A190670Inst Instance=new A190670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190669
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190669Inst : IEnumerable<long>
{
public static readonly long[] Value=A190669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190669.Bytes);
public long this[int i]=>Value[i];

public static A190669Inst Instance=new A190669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190668
{
public static readonly long[] Value={ 1L,2L,3L,8L,10L,12L,14L,32L,54L,60L,66L,72L,78L,84L,90L,256L,272L,288L,304L,320L,336L,352L,368L,384L,500L,520L,810L,840L,870L,900L,930L,1920L,1980L,2040L,2100L,2592L,2664L,2736L,2808L,2880L,2952L,3024L,3096L,3168L,3240L,3312L,3384L,3456L,4116L,4200L,4284L,4368L,4452L,4536L,4620L,4704L,4788L,4872L,4956L,5040L,5124L,5208L,5292L,16384L,16640L,16896L,17152L,17408L,17664L,17920L,18176L,18432L,18688L,18944L,19200L,19456L,19712L,19968L,20224L,20480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190668Inst : IEnumerable<long>
{
public static readonly long[] Value=A190668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190668.Bytes);
public long this[int i]=>Value[i];

public static A190668Inst Instance=new A190668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190635
{
public static readonly long[] Value={ 4L,280L,3469989L,34317382L,73414350L,178935505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190635Inst : IEnumerable<long>
{
public static readonly long[] Value=A190635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190635.Bytes);
public long this[int i]=>Value[i];

public static A190635Inst Instance=new A190635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190634
{
public static readonly long[] Value={ 2L,14L,969L,2831L,4050L,6167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190634Inst : IEnumerable<long>
{
public static readonly long[] Value=A190634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190634.Bytes);
public long this[int i]=>Value[i];

public static A190634Inst Instance=new A190634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190633
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,16L,118L,1077L,11486L,138444L,1847148L,26912226L,424290217L,7194012328L,130641675418L,2534008088656L,52404312807800L,1154031769467768L,27034986095711172L,673063391032594741L,17786452294614118713UL,BigInteger.Parse("498174223396072711297"),BigInteger.Parse("14762117810503938465521"),BigInteger.Parse("461836676823537625928868") };
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
public class A190633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190633Inst Instance=new A190633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190632
{
public static readonly long[] Value={ 2L,2L,22L,22L,12L,22L,22L,22L,222L,202L,102L,222L,222L,112L,122L,122L,122L,222L,202L,202L,222L,222L,212L,222L,222L,222L,2222L,2002L,1002L,2222L,2022L,1012L,1122L,1022L,1022L,2222L,2202L,1102L,2222L,2222L,1112L,1122L,1122L,1122L,1222L,1202L,1202L,1222L,1222L,1212L,1222L,1222L,1222L,2222L,2002L,2002L,2222L,2012L,2012L,2222L,2022L,2022L,2222L,2102L,2102L,2222L,2222L,2112L,2222L,2222L,2122L,2222L,2202L,2202L,2222L,2222L,2212L,2222L,2222L,2222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190632Inst : IEnumerable<long>
{
public static readonly long[] Value=A190632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190632.Bytes);
public long this[int i]=>Value[i];

public static A190632Inst Instance=new A190632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190631
{
public static readonly long[] Value={ 1L,1L,2L,7L,34L,193L,1540L,18231L,316852L,8478040L,322171328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190631Inst : IEnumerable<long>
{
public static readonly long[] Value=A190631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190631.Bytes);
public long this[int i]=>Value[i];

public static A190631Inst Instance=new A190631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190630
{
public static readonly long[] Value={ 1L,4L,6L,8L,63L,563L,10027L,209836L,6257561L,259705792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190630Inst : IEnumerable<long>
{
public static readonly long[] Value=A190630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190630.Bytes);
public long this[int i]=>Value[i];

public static A190630Inst Instance=new A190630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190629
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,115L,1587L,33283L,1147868L,64664807L,5886944926L,868821662115L,207892029761070L,80727613405529244L,BigInteger.Parse("50826500691456029359"),BigInteger.Parse("51893686154530928512158"),BigInteger.Parse("85927150265759233982684320") };
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
public class A190629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190629Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190629.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190629.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190629Inst Instance=new A190629Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190628
{
public static readonly long[] Value={ 1L,1L,5L,37L,401L,7177L,211675L,10163916L,789061887L,99261256018L,20257890922045L,6705845140373654L,3599724849478263520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190628Inst : IEnumerable<long>
{
public static readonly long[] Value=A190628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190628.Bytes);
public long this[int i]=>Value[i];

public static A190628Inst Instance=new A190628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190627
{
public static readonly long[] Value={ 1L,1L,3L,9L,46L,462L,6253L,132061L,4611023L,250827373L,21305367718L,2862744251998L,605949209796465L,201612254630124309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190627Inst : IEnumerable<long>
{
public static readonly long[] Value=A190627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190627.Bytes);
public long this[int i]=>Value[i];

public static A190627Inst Instance=new A190627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190626
{
public static readonly BigInteger[] Value={ 1L,0L,2L,6L,42L,324L,4092L,76160L,2171670L,91674436L,5732036632L,535081395254L,74600276538996L,15457006345833026L,4764968523827845468L,BigInteger.Parse("2185341275223905432960"),BigInteger.Parse("1490580025901441886543202") };
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
public class A190626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190626Inst Instance=new A190626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190625
{
public static readonly BigInteger[] Value={ 1L,1L,3L,9L,46L,338L,3788L,62929L,1549089L,56951770L,3109920701L,252393913470L,30471276950027L,5468189500564227L,1458879136021929400L,BigInteger.Parse("578685384553802577987"),BigInteger.Parse("341244992947305097698156") };
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
public class A190625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190625.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190625Inst Instance=new A190625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190624
{
public static readonly long[] Value={ 11L,6L,27L,64L,125L,162L,343L,512L,729L,750L,1331L,1728L,2197L,2058L,3375L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190624Inst : IEnumerable<long>
{
public static readonly long[] Value=A190624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190624.Bytes);
public long this[int i]=>Value[i];

public static A190624Inst Instance=new A190624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190623
{
public static readonly long[] Value={ 1L,6L,27L,64L,125L,162L,343L,512L,729L,750L,1331L,1728L,2197L,2058L,3375L,4096L,4913L,4374L,6859L,8000L,9261L,7986L,12167L,13824L,15625L,13182L,19683L,21952L,24389L,20250L,29791L,32768L,35937L,29478L,42875L,46656L,50653L,41154L,59319L,64000L,68921L,55566L,79507L,85184L,91125L,73002L,103823L,110592L,117649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190623Inst : IEnumerable<long>
{
public static readonly long[] Value=A190623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190623.Bytes);
public long this[int i]=>Value[i];

public static A190623Inst Instance=new A190623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190622
{
public static readonly long[] Value={ 12L,48L,148L,192L,300L,336L,948L,768L,716L,1200L,2388L,1344L,2028L,2256L,3700L,3072L,3468L,3120L,7188L,4800L,3500L,5712L,10548L,5376L,7500L,8112L,12244L,9024L,10092L,8400L,19188L,12288L,8972L,13872L,23700L,12480L,16428L,17232L,25012L,19200L,20172L,15792L,36948L,22848L,17900L,25296L,44148L,21504L,27276L,30000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190622Inst : IEnumerable<long>
{
public static readonly long[] Value=A190622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190622.Bytes);
public long this[int i]=>Value[i];

public static A190622Inst Instance=new A190622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190621
{
public static readonly long[] Value={ 0L,1L,2L,3L,0L,5L,6L,7L,0L,9L,10L,11L,0L,13L,14L,15L,0L,17L,18L,19L,0L,21L,22L,23L,0L,25L,26L,27L,0L,29L,30L,31L,0L,33L,34L,35L,0L,37L,38L,39L,0L,41L,42L,43L,0L,45L,46L,47L,0L,49L,50L,51L,0L,53L,54L,55L,0L,57L,58L,59L,0L,61L,62L,63L,0L,65L,66L,67L,0L,69L,70L,71L,0L,73L,74L,75L,0L,77L,78L,79L,0L,81L,82L,83L,0L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190621Inst : IEnumerable<long>
{
public static readonly long[] Value=A190621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190621.Bytes);
public long this[int i]=>Value[i];

public static A190621Inst Instance=new A190621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190620
{
public static readonly long[] Value={ 5L,11L,13L,23L,27L,29L,47L,55L,59L,61L,95L,111L,119L,123L,125L,191L,223L,239L,247L,251L,253L,383L,447L,479L,495L,503L,507L,509L,767L,895L,959L,991L,1007L,1015L,1019L,1021L,1535L,1791L,1919L,1983L,2015L,2031L,2039L,2043L,2045L,3071L,3583L,3839L,3967L,4031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190620Inst : IEnumerable<long>
{
public static readonly long[] Value=A190620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190620.Bytes);
public long this[int i]=>Value[i];

public static A190620Inst Instance=new A190620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190571
{
public static readonly long[] Value={ 1L,3L,7L,15L,37L,85L,199L,467L,1089L,2549L,5959L,13931L,32577L,76165L,178087L,416395L,973585L,2276389L,5322519L,12444811L,29097761L,68034725L,159074951L,371940043L,869649137L,2033364389L,4754297463L,11116229131L,25991337537L,60771473701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190571Inst : IEnumerable<long>
{
public static readonly long[] Value=A190571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190571.Bytes);
public long this[int i]=>Value[i];

public static A190571Inst Instance=new A190571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190570
{
public static readonly long[] Value={ 1L,3L,5L,13L,27L,63L,137L,309L,683L,1527L,3393L,7565L,16835L,37503L,83497L,185957L,414075L,922119L,2053393L,4572669L,10182643L,22675407L,50494905L,112445269L,250399915L,557606103L,1241711393L,2765119597L,6157538211L,13711985439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190570Inst : IEnumerable<long>
{
public static readonly long[] Value=A190570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190570.Bytes);
public long this[int i]=>Value[i];

public static A190570Inst Instance=new A190570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190569
{
public static readonly long[] Value={ 1L,3L,7L,13L,25L,51L,103L,205L,409L,819L,1639L,3277L,6553L,13107L,26215L,52429L,104857L,209715L,419431L,838861L,1677721L,3355443L,6710887L,13421773L,26843545L,53687091L,107374183L,214748365L,429496729L,858993459L,1717986919L,3435973837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190569Inst : IEnumerable<long>
{
public static readonly long[] Value=A190569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190569.Bytes);
public long this[int i]=>Value[i];

public static A190569Inst Instance=new A190569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190568
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,3L,3L,5L,6L,10L,13L,19L,26L,38L,53L,75L,106L,150L,212L,300L,424L,600L,848L,1200L,1696L,2400L,3393L,4799L,6786L,9598L,13572L,19196L,27145L,38391L,54291L,76781L,108583L,153561L,217167L,307121L,434334L,614242L,868668L,1228484L,1737337L,2456967L,3474675L,4913933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190568Inst : IEnumerable<long>
{
public static readonly long[] Value=A190568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190568.Bytes);
public long this[int i]=>Value[i];

public static A190568Inst Instance=new A190568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190567
{
public static readonly long[] Value={ 311L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L,1L,76L,1L,622L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190567Inst : IEnumerable<long>
{
public static readonly long[] Value=A190567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190567.Bytes);
public long this[int i]=>Value[i];

public static A190567Inst Instance=new A190567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190566
{
public static readonly long[] Value={ 12L,24L,41L,53L,70L,82L,111L,123L,140L,152L,181L,193L,210L,222L,239L,251L,280L,292L,309L,321L,350L,362L,379L,391L,408L,420L,432L,449L,461L,478L,490L,519L,531L,548L,560L,589L,601L,618L,630L,647L,659L,688L,700L,717L,729L,758L,770L,787L,799L,816L,828L,840L,857L,869L,886L,898L,927L,939L,956L,968L,997L,1009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190566Inst : IEnumerable<long>
{
public static readonly long[] Value=A190566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190566.Bytes);
public long this[int i]=>Value[i];

public static A190566Inst Instance=new A190566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190565
{
public static readonly long[] Value={ 2L,7L,9L,14L,19L,21L,26L,31L,36L,38L,43L,48L,50L,55L,60L,65L,67L,72L,77L,79L,84L,89L,91L,94L,96L,101L,106L,108L,113L,118L,120L,125L,130L,135L,137L,142L,147L,149L,154L,159L,164L,166L,171L,176L,178L,183L,188L,190L,195L,200L,205L,207L,212L,217L,219L,224L,229L,234L,236L,241L,246L,248L,253L,258L,260L,263L,265L,270L,275L,277L,282L,287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190565Inst : IEnumerable<long>
{
public static readonly long[] Value=A190565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190565.Bytes);
public long this[int i]=>Value[i];

public static A190565Inst Instance=new A190565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190564
{
public static readonly long[] Value={ 4L,6L,11L,16L,18L,23L,28L,33L,35L,40L,45L,47L,52L,57L,62L,64L,69L,74L,76L,81L,86L,88L,93L,98L,103L,105L,110L,115L,117L,122L,127L,132L,134L,139L,144L,146L,151L,156L,158L,161L,163L,168L,173L,175L,180L,185L,187L,192L,197L,202L,204L,209L,214L,216L,221L,226L,228L,231L,233L,238L,243L,245L,250L,255L,257L,262L,267L,272L,274L,279L,284L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190564Inst : IEnumerable<long>
{
public static readonly long[] Value=A190564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190564.Bytes);
public long this[int i]=>Value[i];

public static A190564Inst Instance=new A190564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190563
{
public static readonly long[] Value={ 1L,3L,8L,13L,15L,20L,25L,30L,32L,37L,42L,44L,49L,54L,56L,59L,61L,66L,71L,73L,78L,83L,85L,90L,95L,100L,102L,107L,112L,114L,119L,124L,126L,129L,131L,136L,141L,143L,148L,153L,155L,160L,165L,170L,172L,177L,182L,184L,189L,194L,199L,201L,206L,211L,213L,218L,223L,225L,230L,235L,240L,242L,247L,252L,254L,259L,264L,269L,271L,276L,281L,283L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190563Inst : IEnumerable<long>
{
public static readonly long[] Value=A190563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190563.Bytes);
public long this[int i]=>Value[i];

public static A190563Inst Instance=new A190563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190562
{
public static readonly long[] Value={ 5L,10L,17L,22L,27L,29L,34L,39L,46L,51L,58L,63L,68L,75L,80L,87L,92L,97L,99L,104L,109L,116L,121L,128L,133L,138L,145L,150L,157L,162L,167L,169L,174L,179L,186L,191L,196L,198L,203L,208L,215L,220L,227L,232L,237L,244L,249L,256L,261L,266L,268L,273L,278L,285L,290L,297L,302L,307L,314L,319L,326L,331L,336L,338L,343L,348L,355L,360L,365L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190562Inst : IEnumerable<long>
{
public static readonly long[] Value=A190562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190562.Bytes);
public long this[int i]=>Value[i];

public static A190562Inst Instance=new A190562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190561
{
public static readonly long[] Value={ 1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,3L,1L,3L,0L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L,2L,4L,1L,3L,1L,2L,0L,1L,3L,1L,2L,0L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190561Inst : IEnumerable<long>
{
public static readonly long[] Value=A190561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190561.Bytes);
public long this[int i]=>Value[i];

public static A190561Inst Instance=new A190561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190560
{
public static readonly long[] Value={ 0L,1L,8L,70L,608L,5284L,45920L,399064L,3468032L,30138640L,261917312L,2276170336L,19780866560L,171903954496L,1493916835328L,12982758409600L,112825568288768L,980501096767744L,8520962183874560L,74050704051602944L,643531405516070912L,5592555468438184960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190560Inst : IEnumerable<long>
{
public static readonly long[] Value=A190560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190560.Bytes);
public long this[int i]=>Value[i];

public static A190560Inst Instance=new A190560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190559
{
public static readonly long[] Value={ 4L,9L,11L,16L,21L,26L,28L,33L,38L,40L,45L,50L,55L,57L,62L,67L,69L,74L,79L,81L,86L,91L,96L,98L,103L,108L,110L,115L,120L,125L,127L,132L,137L,139L,144L,149L,151L,154L,156L,161L,166L,168L,173L,178L,180L,185L,190L,195L,197L,202L,207L,209L,214L,219L,224L,226L,231L,236L,238L,243L,248L,250L,255L,260L,265L,267L,272L,277L,279L,284L,289L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190559Inst : IEnumerable<long>
{
public static readonly long[] Value=A190559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190559.Bytes);
public long this[int i]=>Value[i];

public static A190559Inst Instance=new A190559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190558
{
public static readonly long[] Value={ 1L,6L,8L,13L,18L,23L,25L,30L,35L,37L,42L,47L,49L,52L,54L,59L,64L,66L,71L,76L,78L,83L,88L,93L,95L,100L,105L,107L,112L,117L,122L,124L,129L,134L,136L,141L,146L,148L,153L,158L,163L,165L,170L,175L,177L,182L,187L,192L,194L,199L,204L,206L,211L,216L,218L,221L,223L,228L,233L,235L,240L,245L,247L,252L,257L,262L,264L,269L,274L,276L,281L,286L,288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190558Inst : IEnumerable<long>
{
public static readonly long[] Value=A190558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190558.Bytes);
public long this[int i]=>Value[i];

public static A190558Inst Instance=new A190558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190557
{
public static readonly long[] Value={ 3L,5L,10L,15L,20L,22L,27L,32L,34L,39L,44L,46L,51L,56L,61L,63L,68L,73L,75L,80L,85L,90L,92L,97L,102L,104L,109L,114L,116L,119L,121L,126L,131L,133L,138L,143L,145L,150L,155L,160L,162L,167L,172L,174L,179L,184L,186L,189L,191L,196L,201L,203L,208L,213L,215L,220L,225L,230L,232L,237L,242L,244L,249L,254L,259L,261L,266L,271L,273L,278L,283L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190557Inst : IEnumerable<long>
{
public static readonly long[] Value=A190557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190557.Bytes);
public long this[int i]=>Value[i];

public static A190557Inst Instance=new A190557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190556
{
public static readonly long[] Value={ 17L,29L,58L,87L,99L,128L,157L,169L,198L,227L,256L,268L,297L,326L,338L,367L,396L,425L,437L,466L,495L,507L,536L,565L,577L,594L,606L,635L,664L,676L,705L,734L,746L,775L,804L,833L,845L,874L,903L,915L,944L,973L,985L,1002L,1014L,1043L,1072L,1084L,1113L,1142L,1154L,1183L,1212L,1241L,1253L,1282L,1311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190556Inst : IEnumerable<long>
{
public static readonly long[] Value=A190556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190556.Bytes);
public long this[int i]=>Value[i];

public static A190556Inst Instance=new A190556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190475
{
public static readonly long[] Value={ 30240L,47520L,56160L,66528L,68040L,73440L,78624L,82080L,84000L,99360L,102816L,106920L,114912L,123552L,125280L,126360L,132000L,133920L,139104L,149688L,156000L,159840L,161568L,164640L,165240L,175392L,176904L,177120L,180576L,184680L,185760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190475Inst : IEnumerable<long>
{
public static readonly long[] Value=A190475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190475.Bytes);
public long this[int i]=>Value[i];

public static A190475Inst Instance=new A190475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190474
{
public static readonly long[] Value={ 20160L,31680L,33600L,37440L,44352L,47040L,48960L,52416L,52800L,54720L,62400L,66240L,68544L,76608L,81600L,82368L,83520L,89280L,91200L,92736L,102060L,103488L,106560L,107712L,110400L,116160L,116928L,118080L,120384L,122304L,123200L,123840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190474Inst : IEnumerable<long>
{
public static readonly long[] Value=A190474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190474.Bytes);
public long this[int i]=>Value[i];

public static A190474Inst Instance=new A190474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190473
{
public static readonly long[] Value={ 13440L,21120L,24960L,29568L,32640L,34944L,36480L,44160L,45696L,49280L,51072L,54912L,55680L,58240L,59520L,61824L,71040L,71808L,76160L,77952L,78720L,80256L,82560L,83328L,84864L,85120L,90240L,91520L,94848L,97152L,99456L,101760L,103040L,110208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190473Inst : IEnumerable<long>
{
public static readonly long[] Value=A190473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190473.Bytes);
public long this[int i]=>Value[i];

public static A190473Inst Instance=new A190473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190472
{
public static readonly long[] Value={ 54000L,81000L,135000L,148176L,222264L,518616L,574992L,686000L,862488L,949104L,1423656L,1715000L,2122416L,2401000L,2662000L,2963088L,3162456L,3183624L,3472875L,4394000L,4444632L,5256144L,5788125L,6169176L,6655000L,7304528L,7884216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190472Inst : IEnumerable<long>
{
public static readonly long[] Value=A190472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190472.Bytes);
public long this[int i]=>Value[i];

public static A190472Inst Instance=new A190472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190471
{
public static readonly long[] Value={ 32400L,63504L,90000L,156816L,202500L,219024L,345744L,374544L,467856L,490000L,685584L,777924L,960400L,1089936L,1210000L,1245456L,1690000L,1774224L,2108304L,2178576L,2396304L,2480625L,2862864L,2890000L,3610000L,3640464L,4112784L,4511376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190471Inst : IEnumerable<long>
{
public static readonly long[] Value=A190471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190471.Bytes);
public long this[int i]=>Value[i];

public static A190471Inst Instance=new A190471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190470
{
public static readonly long[] Value={ 21600L,36000L,42336L,48600L,95256L,98784L,104544L,121500L,146016L,196000L,225000L,235224L,249696L,274400L,311904L,328536L,333396L,337500L,383328L,457056L,484000L,561816L,632736L,676000L,701784L,726624L,830304L,1028376L,1064800L,1156000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190470Inst : IEnumerable<long>
{
public static readonly long[] Value=A190470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190470.Bytes);
public long this[int i]=>Value[i];

public static A190470Inst Instance=new A190470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190469
{
public static readonly long[] Value={ 14400L,28224L,69696L,72900L,78400L,97344L,142884L,166464L,193600L,207936L,270400L,304704L,352836L,379456L,462400L,484416L,492804L,529984L,553536L,562500L,577600L,788544L,842724L,846400L,893025L,906304L,968256L,1052676L,1065024L,1132096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190469Inst : IEnumerable<long>
{
public static readonly long[] Value=A190469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190469.Bytes);
public long this[int i]=>Value[i];

public static A190469Inst Instance=new A190469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190468
{
public static readonly long[] Value={ 12960L,18144L,19440L,27216L,28512L,33696L,42768L,44064L,49248L,50544L,59616L,60000L,66096L,73872L,75168L,80352L,89424L,95904L,106272L,111456L,112752L,120528L,121824L,137376L,140000L,143856L,150000L,152928L,158112L,159408L,167184L,173664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190468Inst : IEnumerable<long>
{
public static readonly long[] Value=A190468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190468.Bytes);
public long this[int i]=>Value[i];

public static A190468Inst Instance=new A190468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190467
{
public static readonly long[] Value={ 8640L,12096L,19008L,22464L,24000L,29160L,29376L,32832L,39744L,40824L,50112L,53568L,56000L,63936L,64152L,65856L,70848L,74304L,75816L,81216L,88000L,91584L,99144L,101952L,104000L,105408L,109760L,110808L,115776L,122688L,126144L,134136L,136000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190467Inst : IEnumerable<long>
{
public static readonly long[] Value=A190467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190467.Bytes);
public long this[int i]=>Value[i];

public static A190467Inst Instance=new A190467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190466
{
public static readonly long[] Value={ 5760L,8064L,9600L,12672L,14976L,18816L,19584L,21888L,22400L,26496L,31360L,33408L,35200L,35712L,41600L,42624L,43740L,46464L,47232L,49536L,54144L,54400L,60800L,61056L,61236L,64896L,67968L,68992L,70272L,73600L,77184L,77440L,81536L,81792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190466Inst : IEnumerable<long>
{
public static readonly long[] Value=A190466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190466.Bytes);
public long this[int i]=>Value[i];

public static A190466Inst Instance=new A190466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190465
{
public static readonly long[] Value={ 7776L,100000L,537824L,759375L,4084101L,5153632L,11881376L,39135393L,45435424L,52521875L,79235168L,90224199L,205962976L,345025251L,503284375L,601692057L,656356768L,916132832L,1160290625L,1564031349L,2219006624L,2706784157L,3707398432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190465Inst : IEnumerable<long>
{
public static readonly long[] Value=A190465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190465.Bytes);
public long this[int i]=>Value[i];

public static A190465Inst Instance=new A190465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190464
{
public static readonly long[] Value={ 5184L,11664L,40000L,153664L,250000L,455625L,937024L,1265625L,1750329L,1827904L,1882384L,5345344L,8340544L,9529569L,10673289L,17909824L,20820969L,28344976L,37515625L,45265984L,59105344L,60886809L,73530625L,77228944L,95004009L,119946304L,143496441L,180848704L,204004089L,218803264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190464Inst : IEnumerable<long>
{
public static readonly long[] Value=A190464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190464.Bytes);
public long this[int i]=>Value[i];

public static A190464Inst Instance=new A190464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190463
{
public static readonly long[] Value={ 3L,8L,11L,16L,21L,24L,29L,37L,42L,45L,50L,55L,58L,63L,66L,71L,76L,79L,84L,92L,97L,100L,105L,110L,113L,118L,126L,131L,134L,139L,144L,147L,152L,155L,160L,165L,168L,173L,181L,186L,189L,194L,199L,202L,207L,210L,215L,220L,223L,228L,236L,241L,244L,249L,254L,257L,262L,270L,275L,278L,283L,288L,291L,296L,299L,304L,309L,312L,317L,325L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190463Inst : IEnumerable<long>
{
public static readonly long[] Value=A190463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190463.Bytes);
public long this[int i]=>Value[i];

public static A190463Inst Instance=new A190463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190462
{
public static readonly long[] Value={ 3063060L,3423420L,4144140L,4476780L,5105100L,5225220L,5290740L,5419260L,5585580L,5705700L,6056820L,6404580L,6666660L,6832980L,6906900L,7147140L,7158060L,7304220L,7387380L,7461300L,7636860L,7657650L,7747740L,7987980L,8075340L,8163540L,8314020L,8468460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190462Inst : IEnumerable<long>
{
public static readonly long[] Value=A190462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190462.Bytes);
public long this[int i]=>Value[i];

public static A190462Inst Instance=new A190462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190461
{
public static readonly long[] Value={ 1L,6L,9L,14L,19L,22L,27L,30L,32L,35L,40L,43L,48L,53L,56L,61L,64L,69L,74L,77L,82L,87L,90L,95L,98L,103L,108L,111L,116L,119L,121L,124L,129L,132L,137L,142L,145L,150L,153L,158L,163L,166L,171L,174L,176L,179L,184L,187L,192L,197L,200L,205L,208L,213L,218L,221L,226L,231L,234L,239L,242L,247L,252L,255L,260L,263L,265L,268L,273L,276L,281L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190461Inst : IEnumerable<long>
{
public static readonly long[] Value=A190461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190461.Bytes);
public long this[int i]=>Value[i];

public static A190461Inst Instance=new A190461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190460
{
public static readonly long[] Value={ 4L,7L,12L,17L,20L,25L,28L,33L,38L,41L,46L,51L,54L,59L,62L,67L,72L,75L,80L,83L,85L,88L,93L,96L,101L,106L,109L,114L,117L,122L,127L,130L,135L,138L,140L,143L,148L,151L,156L,161L,164L,169L,172L,177L,182L,185L,190L,195L,198L,203L,206L,211L,216L,219L,224L,227L,229L,232L,237L,240L,245L,250L,253L,258L,261L,266L,271L,274L,279L,284L,287L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190460Inst : IEnumerable<long>
{
public static readonly long[] Value=A190460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190460.Bytes);
public long this[int i]=>Value[i];

public static A190460Inst Instance=new A190460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190347
{
public static readonly long[] Value={ 2L,5L,8L,12L,14L,17L,21L,24L,26L,29L,33L,36L,39L,42L,45L,48L,51L,54L,57L,60L,64L,67L,69L,72L,76L,79L,81L,85L,88L,91L,95L,97L,100L,103L,107L,109L,112L,116L,119L,121L,124L,128L,131L,134L,137L,140L,143L,146L,149L,152L,155L,159L,162L,164L,168L,171L,174L,176L,180L,183L,186L,190L,192L,195L,198L,202L,204L,207L,211L,214L,216L,219L,223L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190347Inst : IEnumerable<long>
{
public static readonly long[] Value=A190347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190347.Bytes);
public long this[int i]=>Value[i];

public static A190347Inst Instance=new A190347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190346
{
public static readonly long[] Value={ 4L,10L,14L,20L,24L,30L,35L,40L,45L,50L,55L,60L,65L,71L,75L,81L,85L,91L,96L,101L,106L,111L,116L,121L,126L,132L,136L,142L,146L,152L,157L,162L,167L,172L,177L,182L,187L,193L,197L,203L,207L,213L,217L,223L,228L,233L,238L,243L,248L,254L,258L,264L,268L,274L,278L,284L,289L,294L,299L,304L,309L,315L,319L,325L,329L,335L,339L,345L,350L,355L,360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190346Inst : IEnumerable<long>
{
public static readonly long[] Value=A190346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190346.Bytes);
public long this[int i]=>Value[i];

public static A190346Inst Instance=new A190346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190345
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,13L,16L,17L,20L,21L,23L,26L,27L,30L,32L,33L,36L,38L,40L,42L,43L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L,71L,72L,74L,77L,78L,81L,82L,84L,87L,88L,91L,93L,94L,97L,98L,101L,103L,104L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,132L,133L,135L,138L,139L,142L,143L,145L,148L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190345Inst : IEnumerable<long>
{
public static readonly long[] Value=A190345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190345.Bytes);
public long this[int i]=>Value[i];

public static A190345Inst Instance=new A190345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190344
{
public static readonly long[] Value={ 2L,6L,8L,12L,15L,18L,22L,25L,28L,31L,34L,37L,41L,44L,47L,51L,53L,57L,61L,63L,67L,69L,73L,76L,79L,83L,86L,89L,92L,95L,99L,102L,105L,108L,112L,114L,118L,122L,124L,128L,130L,134L,137L,140L,144L,147L,150L,153L,156L,160L,163L,166L,169L,173L,175L,179L,183L,185L,189L,191L,195L,199L,201L,205L,208L,211L,214L,218L,221L,224L,227L,230L,234L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190344Inst : IEnumerable<long>
{
public static readonly long[] Value=A190344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190344.Bytes);
public long this[int i]=>Value[i];

public static A190344Inst Instance=new A190344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190343
{
public static readonly long[] Value={ 1L,1L,3L,8L,25L,88L,343L,1448L,6561L,31622L,161051L,861979L,4826809L,28172943L,170859375L,1073741824L,6975757441L,46753733110L,322687697779L,2289733608959L,16679880978201L,124577080440588L,952809757913927L,7454684703958210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190343Inst : IEnumerable<long>
{
public static readonly long[] Value=A190343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190343.Bytes);
public long this[int i]=>Value[i];

public static A190343Inst Instance=new A190343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190342
{
public static readonly BigInteger[] Value={ 4L,12L,52L,308L,2520L,29268L,471012L,10566004L,331575100L,14510475976L,885694047808L,75478844279780L,8975435807171244L,1489232331953993836L,BigInteger.Parse("344849471434261285096"),BigInteger.Parse("111434896145450843664604") };
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
public class A190342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190342Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190342.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190342.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190342Inst Instance=new A190342Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190341
{
public static readonly BigInteger[] Value={ 3L,9L,40L,273L,2727L,41520L,944307L,32403123L,1667310336L,129124175985L,15018894671481L,2626862719652352L,690390044069042835L,BigInteger.Parse("272767004386769371833"),BigInteger.Parse("161965593156881121867648") };
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
public class A190341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190341.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190341Inst Instance=new A190341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190340
{
public static readonly BigInteger[] Value={ 4L,12L,72L,720L,10800L,259200L,10368000L,673920000L,70087680000L,11774730240000L,3214501355520000L,1420809599139840000L,BigInteger.Parse("1014458053785845760000"),BigInteger.Parse("1171699052122651852800000"),BigInteger.Parse("2191077227469358964736000000") };
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
public class A190340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A190340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A190340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A190340Inst Instance=new A190340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190339
{
public static readonly long[] Value={ 2L,6L,15L,105L,105L,231L,15015L,2145L,36465L,969969L,4849845L,10140585L,10140585L,22287L,3231615L,7713865005L,7713865005L,90751353L,218257003965L,1641030105L,67282234305L,368217318651L,1841086593255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190339Inst : IEnumerable<long>
{
public static readonly long[] Value=A190339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190339.Bytes);
public long this[int i]=>Value[i];

public static A190339Inst Instance=new A190339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190338
{
public static readonly long[] Value={ 1L,4L,4L,4L,4L,1L,4L,4L,4L,4L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,2L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,1L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L,4L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190338Inst : IEnumerable<long>
{
public static readonly long[] Value=A190338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190338.Bytes);
public long this[int i]=>Value[i];

public static A190338Inst Instance=new A190338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190337
{
public static readonly long[] Value={ 5L,11L,17L,23L,29L,34L,40L,46L,52L,58L,64L,69L,75L,81L,87L,93L,99L,104L,110L,116L,122L,128L,134L,139L,145L,151L,157L,163L,169L,174L,180L,186L,192L,198L,203L,209L,215L,221L,227L,233L,238L,244L,250L,256L,262L,268L,273L,279L,285L,291L,297L,303L,308L,314L,320L,326L,332L,338L,343L,349L,355L,361L,367L,373L,378L,384L,390L,396L,402L,407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190337Inst : IEnumerable<long>
{
public static readonly long[] Value=A190337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190337.Bytes);
public long this[int i]=>Value[i];

public static A190337Inst Instance=new A190337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190336
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,19L,23L,25L,29L,31L,34L,37L,40L,43L,46L,49L,52L,54L,58L,60L,64L,66L,69L,72L,75L,78L,81L,84L,87L,89L,93L,95L,99L,101L,104L,107L,110L,113L,116L,118L,122L,124L,128L,130L,134L,136L,139L,142L,145L,148L,151L,153L,157L,159L,163L,165L,169L,171L,174L,177L,180L,183L,186L,188L,192L,194L,198L,200L,203L,206L,209L,212L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190336Inst : IEnumerable<long>
{
public static readonly long[] Value=A190336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190336.Bytes);
public long this[int i]=>Value[i];

public static A190336Inst Instance=new A190336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190335
{
public static readonly long[] Value={ 1L,3L,6L,7L,9L,12L,13L,15L,18L,20L,21L,24L,26L,27L,30L,32L,35L,36L,38L,41L,42L,44L,47L,48L,50L,53L,55L,56L,59L,61L,62L,65L,67L,70L,71L,73L,76L,77L,79L,82L,83L,85L,88L,90L,91L,94L,96L,97L,100L,102L,105L,106L,108L,111L,112L,114L,117L,119L,120L,123L,125L,126L,129L,131L,132L,135L,137L,140L,141L,143L,146L,147L,149L,152L,154L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190335Inst : IEnumerable<long>
{
public static readonly long[] Value=A190335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190335.Bytes);
public long this[int i]=>Value[i];

public static A190335Inst Instance=new A190335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190334
{
public static readonly long[] Value={ 5L,11L,17L,22L,28L,34L,40L,45L,51L,57L,63L,68L,74L,80L,85L,91L,97L,103L,108L,114L,120L,126L,131L,137L,143L,149L,154L,160L,166L,171L,177L,183L,189L,194L,200L,206L,212L,217L,223L,229L,235L,240L,246L,252L,257L,263L,269L,275L,280L,286L,292L,298L,303L,309L,315L,320L,326L,332L,338L,343L,349L,355L,361L,366L,372L,378L,384L,389L,395L,401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190334Inst : IEnumerable<long>
{
public static readonly long[] Value=A190334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190334.Bytes);
public long this[int i]=>Value[i];

public static A190334Inst Instance=new A190334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190333
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,11L,13L,14L,17L,18L,20L,22L,24L,26L,28L,30L,31L,34L,35L,37L,40L,41L,43L,45L,47L,49L,51L,53L,54L,57L,58L,60L,63L,64L,66L,68L,70L,71L,74L,76L,77L,80L,81L,83L,85L,87L,89L,91L,93L,94L,97L,99L,100L,103L,104L,106L,108L,110L,112L,114L,116L,117L,120L,121L,123L,126L,127L,129L,131L,133L,134L,137L,139L,140L,143L,144L,146L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190333Inst : IEnumerable<long>
{
public static readonly long[] Value=A190333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190333.Bytes);
public long this[int i]=>Value[i];

public static A190333Inst Instance=new A190333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190332
{
public static readonly long[] Value={ 2L,6L,9L,12L,15L,19L,23L,25L,29L,32L,36L,38L,42L,46L,48L,52L,55L,59L,61L,65L,69L,72L,75L,78L,82L,86L,88L,92L,95L,98L,101L,105L,109L,111L,115L,118L,122L,124L,128L,132L,135L,138L,141L,145L,147L,151L,155L,158L,161L,164L,168L,172L,174L,178L,181L,184L,187L,191L,195L,197L,201L,204L,208L,210L,214L,218L,221L,224L,227L,231L,233L,237L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190332Inst : IEnumerable<long>
{
public static readonly long[] Value=A190332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190332.Bytes);
public long this[int i]=>Value[i];

public static A190332Inst Instance=new A190332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190267
{
public static readonly long[] Value={ 19L,51L,243L,244L,424L,476L,604L,638L,723L,846L,926L,1683L,1774L,2008L,2524L,2526L,2528L,3124L,3176L,3178L,4204L,4476L,4526L,4924L,5824L,6726L,6812L,6963L,7300L,7443L,7676L,8426L,8958L,8974L,9458L,9926L,10052L,10083L,10468L,11674L,11710L,12428L,12483L,12592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190267Inst : IEnumerable<long>
{
public static readonly long[] Value=A190267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190267.Bytes);
public long this[int i]=>Value[i];

public static A190267Inst Instance=new A190267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190266
{
public static readonly long[] Value={ 7L,1241L,1673L,1751L,1769L,2471L,2839L,3161L,3305L,3497L,3711L,4135L,4265L,4279L,4471L,4711L,5191L,5433L,5561L,6017L,6041L,6103L,6313L,6809L,6953L,7031L,7241L,7463L,7671L,8023L,8057L,8345L,8791L,8889L,9079L,10169L,10793L,10891L,11111L,11209L,11391L,11751L,12297L,13207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190266Inst : IEnumerable<long>
{
public static readonly long[] Value=A190266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190266.Bytes);
public long this[int i]=>Value[i];

public static A190266Inst Instance=new A190266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190265
{
public static readonly long[] Value={ 6L,12L,19L,25L,31L,38L,44L,50L,57L,63L,69L,77L,83L,89L,96L,102L,108L,115L,121L,128L,134L,140L,147L,154L,160L,167L,173L,179L,186L,192L,198L,205L,211L,217L,225L,231L,237L,244L,250L,257L,263L,269L,276L,282L,288L,295L,302L,308L,315L,321L,327L,334L,340L,346L,353L,359L,365L,372L,379L,386L,392L,398L,405L,411L,417L,424L,430L,436L,443L,450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190265Inst : IEnumerable<long>
{
public static readonly long[] Value=A190265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190265.Bytes);
public long this[int i]=>Value[i];

public static A190265Inst Instance=new A190265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190264
{
public static readonly long[] Value={ 1L,7L,1L,6L,9L,9L,0L,5L,6L,6L,0L,2L,8L,3L,0L,1L,9L,0L,5L,6L,6L,0L,3L,3L,0L,1L,8L,8L,8L,1L,1L,3L,2L,0L,3L,5L,8L,4L,9L,1L,8L,1L,1L,3L,1L,6L,7L,0L,7L,5L,6L,0L,6L,6L,0L,3L,3L,1L,4L,9L,0L,7L,2L,4L,4L,9L,0L,0L,1L,1L,4L,5L,4L,7L,9L,2L,5L,5L,9L,0L,2L,9L,2L,7L,0L,5L,1L,3L,4L,9L,3L,4L,4L,5L,1L,9L,2L,0L,5L,2L,2L,6L,7L,5L,0L,6L,4L,8L,7L,1L,4L,0L,8L,7L,4L,9L,3L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190264Inst : IEnumerable<long>
{
public static readonly long[] Value=A190264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190264.Bytes);
public long this[int i]=>Value[i];

public static A190264Inst Instance=new A190264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190263
{
public static readonly long[] Value={ 1L,2L,2L,3L,1L,3L,2L,1L,1L,1L,1L,8L,2L,17L,2L,3L,10L,2L,23L,1L,4L,1L,2L,1L,4L,1L,2L,35L,4L,1L,1L,1L,2L,5L,4L,1L,1L,3L,17L,3L,2L,1L,3L,1L,3L,1L,1L,10L,3L,1L,13L,1L,1L,1L,4L,1L,2L,2L,2L,1L,2L,15L,3L,2L,5L,6L,2L,1L,15L,132L,4L,2L,1L,1L,19L,1L,4L,1L,2L,5L,2L,16L,2L,1L,15L,5L,2L,10L,13L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190263Inst : IEnumerable<long>
{
public static readonly long[] Value=A190263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190263.Bytes);
public long this[int i]=>Value[i];

public static A190263Inst Instance=new A190263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190262
{
public static readonly long[] Value={ 1L,4L,0L,9L,5L,8L,7L,9L,6L,6L,7L,1L,3L,2L,9L,4L,7L,3L,1L,5L,1L,8L,2L,2L,6L,4L,6L,6L,1L,1L,9L,6L,5L,9L,8L,7L,6L,2L,4L,0L,7L,3L,0L,8L,8L,8L,5L,9L,1L,1L,5L,6L,3L,5L,5L,2L,8L,8L,5L,5L,5L,7L,2L,5L,2L,1L,3L,8L,1L,6L,0L,5L,3L,9L,3L,2L,6L,8L,3L,5L,4L,3L,1L,3L,3L,4L,7L,9L,9L,7L,9L,3L,8L,8L,1L,4L,6L,9L,7L,6L,0L,9L,9L,0L,7L,0L,2L,2L,6L,7L,8L,6L,1L,4L,5L,5L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190262Inst : IEnumerable<long>
{
public static readonly long[] Value=A190262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190262.Bytes);
public long this[int i]=>Value[i];

public static A190262Inst Instance=new A190262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190261
{
public static readonly long[] Value={ 1L,2L,11L,32L,1L,4L,10L,2L,1L,1L,3L,1L,1L,5L,2L,3L,2L,1L,4L,2L,3L,2L,41L,1L,2L,1L,1L,3L,4L,1L,35L,1L,5L,1L,29661L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,5L,2L,2L,2L,1L,1L,1L,5L,15L,2L,1L,1L,1L,2L,7L,1L,1L,1L,13L,1L,1L,1L,1L,20L,2L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,3L,14L,1L,8L,2L,1L,1L,1L,1L,2L,1L,3L,2L,3L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190261Inst : IEnumerable<long>
{
public static readonly long[] Value=A190261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190261.Bytes);
public long this[int i]=>Value[i];

public static A190261Inst Instance=new A190261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190260
{
public static readonly long[] Value={ 1L,4L,7L,8L,3L,1L,8L,3L,4L,3L,4L,7L,8L,5L,1L,5L,9L,5L,6L,4L,2L,2L,1L,0L,4L,4L,3L,6L,3L,8L,5L,0L,2L,2L,2L,1L,5L,2L,5L,3L,2L,1L,2L,1L,1L,5L,0L,4L,9L,9L,0L,6L,4L,1L,6L,7L,0L,8L,4L,0L,3L,9L,1L,0L,2L,6L,4L,9L,9L,8L,0L,5L,4L,3L,7L,0L,5L,7L,3L,3L,2L,3L,3L,6L,7L,5L,1L,8L,8L,2L,0L,7L,4L,0L,8L,2L,1L,3L,6L,6L,9L,7L,8L,1L,0L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190260Inst : IEnumerable<long>
{
public static readonly long[] Value=A190260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190260.Bytes);
public long this[int i]=>Value[i];

public static A190260Inst Instance=new A190260Inst();

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