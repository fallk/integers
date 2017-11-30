using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A248082
{
public static readonly long[] Value={ 3L,2L,6L,2L,4L,30L,0L,27L,4L,9L,109L,14L,0L,70L,58L,208L,12L,65L,0L,172L,1579L,1639L,585L,208L,0L,494L,505L,79L,3630L,95L,0L,81L,4422L,130L,1648L,3L,0L,13030L,174L,3L,627L,9524L,0L,3858L,1369L,1235L,11340L,6411L,0L,35494L,2553L,4883L,412L,44366L,0L,14640L,101386L,44021L,3003L,13045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248082Inst : IEnumerable<long>
{
public static readonly long[] Value=A248082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248082.Bytes);
public long this[int i]=>Value[i];

public static A248082Inst Instance=new A248082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248083
{
public static readonly long[] Value={ 5850L,8370L,12400L,12402L,13804L,15930L,21328L,25506L,26908L,29428L,32058L,36988L,41886L,45162L,46564L,52108L,53730L,59668L,61290L,62944L,64818L,66220L,71008L,71370L,72772L,74788L,76410L,82600L,83970L,85876L,91026L,92428L,97468L,99090L,103662L,104130L,105028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248083Inst : IEnumerable<long>
{
public static readonly long[] Value=A248083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248083.Bytes);
public long this[int i]=>Value[i];

public static A248083Inst Instance=new A248083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248084
{
public static readonly long[] Value={ 12400L,151396L,503800L,831400L,1050028L,1134196L,1461796L,1486600L,1637296L,1762288L,1814200L,1987468L,2424940L,2444596L,2449744L,3237388L,3427396L,3452200L,3779800L,4082596L,4574608L,4799788L,4862284L,4887088L,5065396L,5674732L,5745400L,6048196L,6375796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248084Inst : IEnumerable<long>
{
public static readonly long[] Value=A248084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248084.Bytes);
public long this[int i]=>Value[i];

public static A248084Inst Instance=new A248084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248085
{
public static readonly long[] Value={ 5L,7L,17L,47L,127L,227L,257L,397L,467L,607L,997L,1447L,1487L,1697L,1877L,2647L,3307L,3547L,3907L,4217L,4987L,5407L,6287L,6947L,7297L,7537L,7817L,10067L,10627L,11047L,11777L,12227L,12577L,13147L,14747L,15137L,15737L,15877L,17827L,19727L,19937L,20707L,21577L,22027L,22247L,23017L,24097L,26017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248085Inst : IEnumerable<long>
{
public static readonly long[] Value=A248085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248085.Bytes);
public long this[int i]=>Value[i];

public static A248085Inst Instance=new A248085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248086
{
public static readonly long[] Value={ 0L,0L,5L,7L,22L,37L,81L,143L,276L,490L,895L,1578L,2802L,4894L,8547L,14797L,25560L,43919L,75267L,128525L,218930L,371920L,630465L,1066452L,1800612L,3034812L,5106881L,8580883L,14398426L,24129145L,40388085L,67527563L,112786512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248086Inst : IEnumerable<long>
{
public static readonly long[] Value=A248086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248086.Bytes);
public long this[int i]=>Value[i];

public static A248086Inst Instance=new A248086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248087
{
public static readonly BigInteger[] Value={ 0L,1L,0L,0L,20L,105L,504L,4480L,43560L,424305L,4613840L,55668096L,724667580L,10136511385L,152029000200L,2432747715840L,41357024915024L,744416488494945L,14143911946532640L,282878618744592640L,5940450667217358180L,BigInteger.Parse("130689899053015493961") };
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
public class A248087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248087Inst Instance=new A248087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248088
{
public static readonly long[] Value={ 1L,4L,16L,64L,229L,808L,2800L,9472L,31705L,105004L,344416L,1121920L,3631645L,11691472L,37466656L,119574784L,380244721L,1205309140L,3809636848L,12010028224L,37773505429L,118550674936L,371342504848L,1161099257344L,3624512382793L,11297181307900L,35162477600704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248088Inst : IEnumerable<long>
{
public static readonly long[] Value=A248088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248088.Bytes);
public long this[int i]=>Value[i];

public static A248088Inst Instance=new A248088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248089
{
public static readonly long[] Value={ 1L,4L,16L,64L,229L,592L,-224L,-18176L,-175655L,-1265732L,-7914560L,-44970752L,-236014307L,-1145932664L,-5086940240L,-19929220352L,-61944816911L,-81359219468L,858917862064L,10785877546432L,84667993188757L,555461238134080L,3268576565244544L,17688312222825472L,88631554966652233L,408731119650234796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248089Inst : IEnumerable<long>
{
public static readonly long[] Value=A248089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248089.Bytes);
public long this[int i]=>Value[i];

public static A248089Inst Instance=new A248089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248090
{
public static readonly long[] Value={ 2L,3L,6L,4L,18L,24L,5L,36L,168L,120L,6L,60L,528L,2160L,720L,7L,90L,1200L,10920L,35640L,5040L,8L,126L,2280L,34200L,293760L,720720L,40320L,9L,168L,3864L,82800L,1275120L,9767520L,17297280L,362880L,10L,216L,6048L,170520L,3946320L,58968000L,387636480L,481178880L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248090Inst : IEnumerable<long>
{
public static readonly long[] Value=A248090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248090.Bytes);
public long this[int i]=>Value[i];

public static A248090Inst Instance=new A248090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248091
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,1L,3L,6L,16L,39L,101L,259L,670L,1732L,4485L,11613L,30079L,77910L,201812L,522763L,1354153L,3507775L,9086502L,23537592L,60971593L,157940361L,409127579L,1059801190L,2745301576L,7111410031L,18421346973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248091Inst : IEnumerable<long>
{
public static readonly long[] Value=A248091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248091.Bytes);
public long this[int i]=>Value[i];

public static A248091Inst Instance=new A248091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248092
{
public static readonly long[] Value={ 0L,1L,0L,2L,3L,0L,5L,6L,5L,0L,8L,9L,10L,7L,0L,13L,14L,15L,14L,9L,0L,18L,19L,20L,21L,18L,11L,0L,25L,26L,27L,28L,27L,22L,13L,0L,32L,33L,34L,35L,36L,33L,26L,15L,0L,41L,42L,43L,44L,45L,44L,39L,30L,17L,0L,50L,51L,52L,53L,54L,55L,52L,45L,34L,19L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248092Inst : IEnumerable<long>
{
public static readonly long[] Value=A248092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248092.Bytes);
public long this[int i]=>Value[i];

public static A248092Inst Instance=new A248092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248093
{
public static readonly long[] Value={ 1L,0L,6L,6L,6L,3L,13L,15L,21L,21L,15L,6L,22L,27L,42L,48L,45L,36L,24L,9L,33L,42L,69L,84L,87L,81L,69L,51L,33L,12L,46L,60L,102L,129L,141L,141L,132L,114L,93L,66L,42L,15L,61L,81L,141L,183L,207L,216L,213L,198L,177L,147L,117L,81L,51L,18L,78L,105L,186L,246L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248093Inst : IEnumerable<long>
{
public static readonly long[] Value=A248093.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248093.Bytes);
public long this[int i]=>Value[i];

public static A248093Inst Instance=new A248093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248094
{
public static readonly long[] Value={ 0L,42L,444L,2187L,7443L,20247L,47313L,98994L,190386L,342576L,584034L,952149L,1494909L,2272725L,3360399L,4849236L,6849300L,9491814L,12931704L,17350287L,22958103L,29997891L,38747709L,49524198L,62685990L,78637260L,97831422L,120774969L,148031457L,180225633L,218047707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248094Inst : IEnumerable<long>
{
public static readonly long[] Value=A248094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248094.Bytes);
public long this[int i]=>Value[i];

public static A248094Inst Instance=new A248094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248095
{
public static readonly long[] Value={ 27L,109L,210L,279L,566L,822L,569L,1182L,1816L,2328L,1011L,2130L,3370L,4540L,5433L,1637L,3482L,5612L,7772L,9707L,11130L,2479L,5310L,8670L,12224L,15653L,18622L,20748L,3569L,7686L,12672L,18096L,23559L,28662L,32974L,36000L,4939L,10682L,17746L,25588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248095Inst : IEnumerable<long>
{
public static readonly long[] Value=A248095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248095.Bytes);
public long this[int i]=>Value[i];

public static A248095Inst Instance=new A248095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248096
{
public static readonly long[] Value={ 1L,1L,0L,2L,2L,6L,14L,30L,80L,191L,482L,1253L,3178L,8370L,21908L,57861L,154262L,411724L,1106990L,2986434L,8085282L,21978895L,59905632L,163786142L,448976298L,1233655230L,3397615736L,9376447532L,25926798104L,71819992609L,199282159404L,553834902261L,1541463298372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248096Inst : IEnumerable<long>
{
public static readonly long[] Value=A248096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248096.Bytes);
public long this[int i]=>Value[i];

public static A248096Inst Instance=new A248096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248097
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,8L,15L,34L,93L,208L,548L,1390L,3527L,9318L,24203L,64052L,170392L,454020L,1220651L,3288010L,8897474L,24170066L,65829806L,179901956L,492872483L,1353655974L,3726557183L,10280008874L,28415211437L,78686254872L,218265740153L,606417214412L,1687349373815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248097Inst : IEnumerable<long>
{
public static readonly long[] Value=A248097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248097.Bytes);
public long this[int i]=>Value[i];

public static A248097Inst Instance=new A248097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248098
{
public static readonly long[] Value={ 1L,1L,1L,4L,7L,13L,25L,46L,85L,157L,289L,532L,979L,1801L,3313L,6094L,11209L,20617L,37921L,69748L,128287L,235957L,433993L,798238L,1468189L,2700421L,4966849L,9135460L,16802731L,30905041L,56843233L,104551006L,192299281L,353693521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248098Inst : IEnumerable<long>
{
public static readonly long[] Value=A248098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248098.Bytes);
public long this[int i]=>Value[i];

public static A248098Inst Instance=new A248098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248099
{
public static readonly BigInteger[] Value={ 1L,4L,216L,2428912656L,BigInteger.Parse("84539502447168140812774402430429967453919558368") };
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
public class A248099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248099Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248099.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248099.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248099Inst Instance=new A248099Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248100
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,2L,6L,6L,7L,20L,30L,34L,75L,140L,182L,322L,644L,972L,1554L,3024L,5091L,8052L,14784L,26378L,43032L,75504L,136994L,232232L,399399L,720356L,1257256L,2161874L,3852576L,6831552L,11858418L,20949304L,37350768L,65554788L,115476376L,205872448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248100Inst : IEnumerable<long>
{
public static readonly long[] Value=A248100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248100.Bytes);
public long this[int i]=>Value[i];

public static A248100Inst Instance=new A248100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248101
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,3L,7L,1L,9L,1L,1L,3L,13L,7L,3L,1L,1L,9L,19L,1L,21L,1L,1L,3L,1L,13L,27L,7L,29L,3L,1L,1L,3L,1L,7L,9L,37L,19L,39L,1L,1L,21L,43L,1L,9L,1L,1L,3L,49L,1L,3L,13L,53L,27L,1L,7L,57L,29L,1L,3L,61L,1L,63L,1L,13L,3L,1L,1L,3L,7L,71L,9L,1L,37L,3L,19L,7L,39L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248101Inst : IEnumerable<long>
{
public static readonly long[] Value=A248101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248101.Bytes);
public long this[int i]=>Value[i];

public static A248101Inst Instance=new A248101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248102
{
public static readonly long[] Value={ 1L,0L,0L,18L,24L,238L,842L,4360L,25900L,112178L,613140L,2941170L,14789274L,74895336L,369603312L,1866863986L,9294391952L,46543456838L,233028690018L,1164275409976L,5830080180396L,29149585256266L,145845002931724L,729627382873090L,3649578988919810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248102Inst : IEnumerable<long>
{
public static readonly long[] Value=A248102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248102.Bytes);
public long this[int i]=>Value[i];

public static A248102Inst Instance=new A248102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248103
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,6L,7L,7L,8L,9L,9L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,17L,18L,19L,19L,20L,21L,21L,22L,23L,23L,24L,25L,25L,26L,27L,27L,28L,29L,29L,30L,31L,31L,32L,33L,33L,34L,35L,36L,36L,37L,38L,38L,39L,40L,40L,41L,42L,42L,43L,44L,44L,45L,46L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248103Inst : IEnumerable<long>
{
public static readonly long[] Value=A248103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248103.Bytes);
public long this[int i]=>Value[i];

public static A248103Inst Instance=new A248103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248104
{
public static readonly long[] Value={ 4L,11L,16L,19L,28L,35L,44L,47L,52L,59L,64L,67L,76L,79L,84L,91L,100L,107L,112L,115L,124L,131L,140L,143L,148L,155L,164L,171L,176L,179L,188L,191L,196L,203L,208L,211L,220L,227L,236L,239L,244L,251L,256L,259L,268L,271L,276L,283L,292L,299L,304L,307L,316L,319L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248104Inst : IEnumerable<long>
{
public static readonly long[] Value=A248104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248104.Bytes);
public long this[int i]=>Value[i];

public static A248104Inst Instance=new A248104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248105
{
public static readonly long[] Value={ 3L,12L,15L,20L,27L,36L,43L,48L,51L,60L,63L,68L,75L,80L,83L,92L,99L,108L,111L,116L,123L,132L,139L,144L,147L,156L,163L,172L,175L,180L,187L,192L,195L,204L,207L,212L,219L,228L,235L,240L,243L,252L,255L,260L,267L,272L,275L,284L,291L,300L,303L,308L,315L,320L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248105Inst : IEnumerable<long>
{
public static readonly long[] Value=A248105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248105.Bytes);
public long this[int i]=>Value[i];

public static A248105Inst Instance=new A248105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248106
{
public static readonly long[] Value={ 3L,5L,7L,9L,12L,14L,16L,18L,20L,23L,25L,27L,29L,32L,34L,36L,38L,40L,43L,45L,47L,49L,52L,54L,56L,58L,60L,63L,65L,67L,69L,72L,74L,76L,78L,80L,83L,85L,87L,89L,92L,94L,96L,98L,100L,103L,105L,107L,109L,111L,114L,116L,118L,120L,123L,125L,127L,129L,131L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248106Inst : IEnumerable<long>
{
public static readonly long[] Value=A248106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248106.Bytes);
public long this[int i]=>Value[i];

public static A248106Inst Instance=new A248106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248107
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,2L,0L,2L,0L,0L,1L,2L,0L,0L,2L,0L,0L,2L,0L,2L,0L,0L,0L,1L,0L,3L,2L,0L,0L,2L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,2L,5L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,4L,3L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,1L,2L,0L,0L,2L,0L,5L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248107Inst : IEnumerable<long>
{
public static readonly long[] Value=A248107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248107.Bytes);
public long this[int i]=>Value[i];

public static A248107Inst Instance=new A248107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248108
{
public static readonly long[] Value={ 36L,900L,7056L,32400L,41616L,44100L,54756L,63504L,69696L,108900L,112896L,176400L,213444L,298116L,396900L,435600L,509796L,608400L,705600L,736164L,756900L,777924L,853776L,980100L,1040400L,1192464L,1299600L,1368900L,1920996L,2039184L,2304324L,2340900L,2414916L,2433600L,2683044L,2722500L,2822400L,2944656L,3755844L,3802500L,3920400L,4161600L,4588164L,4769856L,5336100L,5731236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248108Inst : IEnumerable<long>
{
public static readonly long[] Value=A248108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248108.Bytes);
public long this[int i]=>Value[i];

public static A248108Inst Instance=new A248108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248109
{
public static readonly long[] Value={ 0L,1L,2896L,306827L,8388608L,109183006L,888667667L,5231514822L,24296003999L,94143178827L,316227766016L,946271759726L,2573856496961L,6461726194556L,15152085430295L,33500360392119L,70368744177664L,141306648466586L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248109Inst : IEnumerable<long>
{
public static readonly long[] Value=A248109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248109.Bytes);
public long this[int i]=>Value[i];

public static A248109Inst Instance=new A248109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248110
{
public static readonly long[] Value={ 2L,3L,4L,4L,5L,6L,5L,6L,7L,8L,6L,7L,8L,9L,10L,7L,8L,9L,10L,11L,12L,8L,9L,10L,11L,12L,13L,14L,9L,10L,11L,12L,13L,14L,15L,16L,10L,11L,12L,13L,14L,15L,16L,17L,18L,11L,12L,13L,13L,14L,15L,14L,15L,16L,17L,15L,16L,17L,18L,19L,16L,17L,18L,19L,20L,21L,17L,18L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248110Inst : IEnumerable<long>
{
public static readonly long[] Value=A248110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248110.Bytes);
public long this[int i]=>Value[i];

public static A248110Inst Instance=new A248110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248111
{
public static readonly long[] Value={ 18L,25L,30L,35L,39L,42L,46L,49L,52L,55L,57L,60L,62L,64L,67L,69L,71L,73L,75L,77L,79L,81L,82L,84L,86L,88L,89L,91L,92L,94L,96L,97L,99L,100L,101L,103L,104L,106L,107L,108L,110L,111L,112L,114L,115L,116L,118L,119L,120L,121L,122L,124L,125L,126L,127L,128L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248111Inst : IEnumerable<long>
{
public static readonly long[] Value=A248111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248111.Bytes);
public long this[int i]=>Value[i];

public static A248111Inst Instance=new A248111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248112
{
public static readonly long[] Value={ 1L,2L,4L,1L,8L,2L,16L,4L,1L,32L,10L,2L,64L,20L,5L,1L,128L,44L,12L,2L,256L,93L,29L,6L,1L,512L,198L,63L,14L,2L,1024L,414L,146L,37L,7L,1L,2048L,864L,329L,88L,16L,2L,4096L,1788L,722L,218L,49L,8L,1L,8192L,3687L,1613L,515L,118L,19L,2L,16384L,7541L,3505L,1226L,313L,62L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248112Inst : IEnumerable<long>
{
public static readonly long[] Value=A248112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248112.Bytes);
public long this[int i]=>Value[i];

public static A248112Inst Instance=new A248112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248113
{
public static readonly long[] Value={ 1L,2L,6L,14L,37L,88L,218L,515L,1226L,2848L,6566L,14997L,33483L,74406L,162422L,351621L,751171L,1594028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248113Inst : IEnumerable<long>
{
public static readonly long[] Value=A248113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248113.Bytes);
public long this[int i]=>Value[i];

public static A248113Inst Instance=new A248113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248114
{
public static readonly long[] Value={ 1L,2L,7L,16L,49L,118L,313L,764L,1937L,4752L,11541L,27610L,65186L,151426L,346412L,784064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248114Inst : IEnumerable<long>
{
public static readonly long[] Value=A248114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248114.Bytes);
public long this[int i]=>Value[i];

public static A248114Inst Instance=new A248114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248115
{
public static readonly long[] Value={ 1L,2L,8L,19L,62L,149L,435L,1097L,2937L,7442L,19179L,47777L,118337L,288220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248115Inst : IEnumerable<long>
{
public static readonly long[] Value=A248115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248115.Bytes);
public long this[int i]=>Value[i];

public static A248115Inst Instance=new A248115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248116
{
public static readonly long[] Value={ 1L,2L,9L,21L,76L,191L,581L,1498L,4289L,11178L,30228L,78312L,203322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248116Inst : IEnumerable<long>
{
public static readonly long[] Value=A248116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248116.Bytes);
public long this[int i]=>Value[i];

public static A248116Inst Instance=new A248116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248117
{
public static readonly long[] Value={ 1L,2L,10L,24L,92L,230L,767L,2006L,6037L,16133L,45868L,122539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248117Inst : IEnumerable<long>
{
public static readonly long[] Value=A248117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248117.Bytes);
public long this[int i]=>Value[i];

public static A248117Inst Instance=new A248117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248118
{
public static readonly long[] Value={ 1L,2L,11L,26L,111L,280L,980L,2599L,8292L,22644L,67300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248118Inst : IEnumerable<long>
{
public static readonly long[] Value=A248118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248118.Bytes);
public long this[int i]=>Value[i];

public static A248118Inst Instance=new A248118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248119
{
public static readonly long[] Value={ 1L,2L,12L,29L,130L,329L,1239L,3329L,11128L,30766L,95946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248119Inst : IEnumerable<long>
{
public static readonly long[] Value=A248119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248119.Bytes);
public long this[int i]=>Value[i];

public static A248119Inst Instance=new A248119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248120
{
public static readonly long[] Value={ 1L,2L,6L,3L,24L,36L,4L,120L,360L,60L,80L,5L,720L,3600L,1800L,1200L,300L,150L,6L,5040L,37800L,37800L,16800L,3150L,12600L,3150L,420L,630L,252L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248120Inst : IEnumerable<long>
{
public static readonly long[] Value=A248120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248120.Bytes);
public long this[int i]=>Value[i];

public static A248120Inst Instance=new A248120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248121
{
public static readonly long[] Value={ 2L,9L,20L,34L,53L,76L,102L,133L,168L,206L,249L,296L,346L,401L,460L,522L,589L,660L,734L,813L,896L,982L,1073L,1168L,1266L,1369L,1476L,1586L,1701L,1820L,1942L,2069L,2200L,2334L,2473L,2616L,2762L,2913L,3068L,3226L,3389L,3556L,3726L,3901L,4080L,4262L,4449L,4640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248121Inst : IEnumerable<long>
{
public static readonly long[] Value=A248121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248121.Bytes);
public long this[int i]=>Value[i];

public static A248121Inst Instance=new A248121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248122
{
public static readonly long[] Value={ 0L,0L,3L,15L,51L,165L,507L,1551L,4683L,14127L,42459L,127599L,383019L,1149693L,3449715L,10351023L,31054947L,93170397L,279516747L,838566831L,2515717083L,7547200797L,22641651939L,67925104239L,203775461139L,611326828047L,1833980928771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248122Inst : IEnumerable<long>
{
public static readonly long[] Value=A248122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248122.Bytes);
public long this[int i]=>Value[i];

public static A248122Inst Instance=new A248122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248123
{
public static readonly long[] Value={ 1L,3L,2L,21L,9L,11L,11L,77L,5L,13L,6L,85L,10L,5L,1L,77L,11L,5L,11L,1L,4L,7L,13L,29L,18L,7L,14L,1L,15L,11L,17L,189L,19L,9L,6L,5L,23L,15L,7L,49L,23L,1L,22L,17L,1L,13L,25L,13L,26L,19L,11L,9L,28L,71L,18L,29L,10L,15L,31L,13L,34L,17L,5L,381L,9L,1L,35L,9L,19L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248123Inst : IEnumerable<long>
{
public static readonly long[] Value=A248123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248123.Bytes);
public long this[int i]=>Value[i];

public static A248123Inst Instance=new A248123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248124
{
public static readonly long[] Value={ 1L,19L,1L,20L,1L,95L,1L,4L,1L,242L,241L,478L,1L,23L,1L,5L,7L,109L,1L,17L,1L,227L,467L,37L,1L,209L,1L,330L,2077L,17L,1073L,816L,1L,27L,109L,71L,1L,43L,1L,41L,145L,151L,1L,43L,1L,59L,71L,587L,1L,87L,1775L,344L,1773L,1127L,1L,49L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248124Inst : IEnumerable<long>
{
public static readonly long[] Value=A248124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248124.Bytes);
public long this[int i]=>Value[i];

public static A248124Inst Instance=new A248124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248125
{
public static readonly long[] Value={ 1L,2L,5L,16L,3L,6L,2L,22L,101L,6L,21L,86L,43L,16L,15L,4L,3L,6L,21L,20L,11L,8L,49L,48L,7L,22L,29L,28L,27L,26L,25L,49L,11L,29L,133L,20L,19L,22L,71L,70L,7L,18L,13L,46L,11L,14L,25L,24L,23L,93L,45L,80L,43L,67L,29L,286L,171L,102L,97L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248125Inst : IEnumerable<long>
{
public static readonly long[] Value=A248125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248125.Bytes);
public long this[int i]=>Value[i];

public static A248125Inst Instance=new A248125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248126
{
public static readonly long[] Value={ 11L,44L,99L,1166L,2255L,3366L,4499L,6644L,8811L,110000L,112211L,114444L,116699L,119966L,222255L,225566L,228899L,332244L,336611L,440000L,444411L,448844L,552299L,557766L,662255L,667766L,772299L,778844L,884411L,990000L,996611L,11002244L,11008899L,11115566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248126Inst : IEnumerable<long>
{
public static readonly long[] Value=A248126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248126.Bytes);
public long this[int i]=>Value[i];

public static A248126Inst Instance=new A248126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248127
{
public static readonly long[] Value={ 2L,4L,5L,10L,31L,72L,75L,80L,162L,270L,383L,640L,1250L,2000L,2160L,3430L,4000L,5000L,5120L,7290L,10000L,13310L,17280L,21970L,27440L,28875L,31000L,33750L,40960L,49130L,58320L,68590L,72000L,75000L,80000L,92610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248127Inst : IEnumerable<long>
{
public static readonly long[] Value=A248127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248127.Bytes);
public long this[int i]=>Value[i];

public static A248127Inst Instance=new A248127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248128
{
public static readonly long[] Value={ 50L,15L,0L,3L,15L,0L,9L,3L,15L,0L,27L,9L,3L,15L,0L,6L,21L,27L,9L,3L,15L,0L,18L,6L,3L,6L,21L,27L,9L,3L,15L,0L,3L,24L,18L,9L,18L,6L,3L,6L,21L,27L,9L,3L,15L,0L,9L,6L,12L,3L,24L,27L,3L,24L,18L,9L,18L,6L,3L,6L,21L,27L,9L,3L,15L,0L,27L,18L,3L,6L,9L,6L,12L,6L,21L,9L,6L,12L,3L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248128Inst : IEnumerable<long>
{
public static readonly long[] Value=A248128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248128.Bytes);
public long this[int i]=>Value[i];

public static A248128Inst Instance=new A248128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248129
{
public static readonly long[] Value={ 0L,15L,3L,9L,27L,21L,6L,3L,6L,18L,9L,18L,24L,3L,27L,24L,3L,12L,6L,9L,21L,6L,12L,6L,9L,6L,3L,18L,27L,3L,6L,18L,6L,3L,18L,27L,18L,9L,24L,3L,21L,6L,9L,18L,24L,3L,18L,9L,24L,3L,21L,6L,24L,3L,27L,12L,6L,9L,3L,6L,18L,27L,24L,3L,12L,6L,9L,24L,3L,27L,12L,6L,9L,3L,6L,18L,12L,6L,9L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248129Inst : IEnumerable<long>
{
public static readonly long[] Value=A248129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248129.Bytes);
public long this[int i]=>Value[i];

public static A248129Inst Instance=new A248129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248130
{
public static readonly long[] Value={ 0L,5L,1L,3L,9L,7L,2L,1L,2L,6L,3L,6L,8L,1L,9L,8L,1L,4L,2L,3L,7L,2L,4L,2L,3L,2L,1L,6L,9L,1L,2L,6L,2L,1L,6L,9L,6L,3L,8L,1L,7L,2L,3L,6L,8L,1L,6L,3L,8L,1L,7L,2L,8L,1L,9L,4L,2L,3L,1L,2L,6L,9L,8L,1L,4L,2L,3L,8L,1L,9L,4L,2L,3L,1L,2L,6L,4L,2L,3L,7L,2L,2L,1L,6L,9L,3L,6L,8L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248130Inst : IEnumerable<long>
{
public static readonly long[] Value=A248130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248130.Bytes);
public long this[int i]=>Value[i];

public static A248130Inst Instance=new A248130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248131
{
public static readonly long[] Value={ 1L,3L,9L,27L,6L,21L,18L,6L,3L,3L,24L,18L,9L,9L,6L,12L,3L,24L,27L,27L,18L,3L,6L,9L,6L,12L,6L,21L,6L,21L,3L,24L,9L,18L,27L,18L,3L,6L,18L,6L,3L,18L,6L,3L,9L,6L,12L,27L,3L,24L,6L,21L,3L,24L,9L,18L,3L,24L,18L,9L,3L,24L,18L,9L,27L,18L,3L,6L,6L,21L,9L,6L,12L,18L,6L,3L,9L,6L,12L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248131Inst : IEnumerable<long>
{
public static readonly long[] Value=A248131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248131.Bytes);
public long this[int i]=>Value[i];

public static A248131Inst Instance=new A248131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248132
{
public static readonly long[] Value={ 0L,1L,5792L,920482L,33554432L,545915033L,5332006004L,36620603758L,194368031998L,847288609443L,3162277660168L,10408989356987L,30886277963534L,84002440529229L,212129196024140L,502505405881790L,1125899906842624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248132Inst : IEnumerable<long>
{
public static readonly long[] Value=A248132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248132.Bytes);
public long this[int i]=>Value[i];

public static A248132Inst Instance=new A248132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248133
{
public static readonly long[] Value={ 1L,3L,1L,1L,7L,2L,2L,2L,1L,1L,7L,4L,37L,145L,35L,1L,25L,16L,5L,16L,1L,1L,18L,19L,3L,11L,41L,1L,7L,2L,48L,415L,1L,2L,15L,7L,13L,34L,97L,1L,27L,18L,56L,22L,1L,1L,5L,26L,22L,36L,18L,1L,117L,52L,376L,11L,1L,1L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248133Inst : IEnumerable<long>
{
public static readonly long[] Value=A248133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248133.Bytes);
public long this[int i]=>Value[i];

public static A248133Inst Instance=new A248133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248134
{
public static readonly long[] Value={ 14L,19L,21L,28L,42L,47L,63L,84L,105L,126L,147L,149L,168L,189L,199L,298L,323L,497L,646L,795L,911L,969L,1292L,1499L,1822L,1999L,2087L,2733L,2998L,3089L,3248L,3379L,3644L,4555L,4997L,5411L,5466L,6178L,6377L,6496L,7288L,7995L,8199L,9161L,9267L,9744L,10822L,12356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248134Inst : IEnumerable<long>
{
public static readonly long[] Value=A248134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248134.Bytes);
public long this[int i]=>Value[i];

public static A248134Inst Instance=new A248134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248135
{
public static readonly long[] Value={ 1L,12L,52L,840L,988L,1461L,4926L,21376L,130484L,210840L,297158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248135Inst : IEnumerable<long>
{
public static readonly long[] Value=A248135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248135.Bytes);
public long this[int i]=>Value[i];

public static A248135Inst Instance=new A248135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248136
{
public static readonly long[] Value={ 1L,20L,3L,6L,1L,4L,200L,299L,5L,29L,4L,119L,5L,61L,3L,3L,6L,64L,31L,2L,21L,35L,6L,2974L,17L,1052L,27L,109L,10L,4L,3L,50L,65L,177L,22L,29L,5L,25L,15L,29L,29L,584L,83L,163L,9L,152L,19L,19L,29L,32L,15L,35L,4L,25L,239L,1122L,185L,76L,35L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248136Inst : IEnumerable<long>
{
public static readonly long[] Value=A248136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248136.Bytes);
public long this[int i]=>Value[i];

public static A248136Inst Instance=new A248136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248137
{
public static readonly long[] Value={ 1L,1L,244L,1L,23L,4L,1L,1L,3494L,1L,68058L,4L,20L,18L,35L,1L,4L,14L,32L,13L,21L,1L,5L,22L,172L,7L,8L,1L,1L,28L,14L,19L,2L,178L,15L,227L,2L,6L,109L,1L,22L,122L,47L,22L,126L,1L,43L,60L,41L,18L,24L,1L,13L,23L,21L,24L,126L,1L,152L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248137Inst : IEnumerable<long>
{
public static readonly long[] Value=A248137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248137.Bytes);
public long this[int i]=>Value[i];

public static A248137Inst Instance=new A248137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248138
{
public static readonly long[] Value={ 3L,2L,2L,3L,2L,3L,4L,2L,2L,5L,2L,5L,3L,2L,2L,2L,2L,2L,6L,4L,3L,6L,4L,7L,4L,5L,3L,4L,3L,2L,3L,3L,4L,2L,2L,2L,2L,2L,2L,2L,4L,3L,3L,2L,4L,2L,2L,2L,2L,2L,2L,2L,2L,5L,2L,3L,5L,2L,3L,3L,6L,2L,4L,5L,2L,2L,2L,2L,3L,2L,3L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,4L,3L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248138Inst : IEnumerable<long>
{
public static readonly long[] Value=A248138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248138.Bytes);
public long this[int i]=>Value[i];

public static A248138Inst Instance=new A248138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248139
{
public static readonly long[] Value={ 1L,1L,25L,6L,14L,4L,13L,49L,19L,10L,2L,56L,2L,5L,6L,5L,27L,61L,9L,33L,23L,53L,21L,15L,3L,24L,11L,58L,39L,118L,3L,1598L,20L,40L,4L,2L,58L,26L,29L,17L,47L,34L,4L,31L,43L,163L,41L,25L,8L,26L,67L,40L,21L,214L,535L,12L,7L,22L,164L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248139Inst : IEnumerable<long>
{
public static readonly long[] Value=A248139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248139.Bytes);
public long this[int i]=>Value[i];

public static A248139Inst Instance=new A248139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248140
{
public static readonly long[] Value={ 2L,7L,3L,2L,3L,3L,4L,5L,5L,2L,2L,2L,4L,2L,2L,2L,2L,2L,3L,5L,2L,4L,3L,4L,2L,3L,3L,3L,3L,3L,3L,4L,9L,2L,2L,2L,2L,7L,5L,3L,2L,3L,2L,4L,4L,4L,2L,3L,4L,2L,3L,4L,3L,4L,2L,2L,3L,2L,2L,2L,9L,2L,5L,2L,5L,4L,4L,2L,4L,4L,2L,3L,3L,8L,3L,2L,2L,3L,2L,3L,2L,2L,2L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248140Inst : IEnumerable<long>
{
public static readonly long[] Value=A248140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248140.Bytes);
public long this[int i]=>Value[i];

public static A248140Inst Instance=new A248140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248141
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,3L,1L,2L,2L,3L,1L,2L,3L,1L,2L,3L,4L,1L,2L,2L,3L,3L,4L,1L,2L,3L,2L,3L,4L,1L,2L,3L,4L,1L,2L,3L,4L,5L,1L,2L,2L,3L,3L,4L,4L,5L,1L,2L,3L,2L,3L,4L,3L,4L,5L,1L,2L,3L,4L,2L,3L,4L,5L,1L,2L,3L,4L,5L,1L,2L,3L,4L,5L,6L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248141Inst : IEnumerable<long>
{
public static readonly long[] Value=A248141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248141.Bytes);
public long this[int i]=>Value[i];

public static A248141Inst Instance=new A248141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248142
{
public static readonly long[] Value={ 1L,1L,7L,2238L,5L,9L,3L,3L,1L,2484L,2L,2L,26L,12L,24L,5L,41L,32L,14L,3L,29L,29L,6L,15L,30L,7L,8L,37L,21L,5L,44L,18L,5L,16L,39L,34L,8L,1L,6L,5L,17L,8L,26L,6L,865L,39L,8L,13L,16L,781L,356L,35L,184L,65L,30L,139L,18L,25L,16L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248142Inst : IEnumerable<long>
{
public static readonly long[] Value=A248142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248142.Bytes);
public long this[int i]=>Value[i];

public static A248142Inst Instance=new A248142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248143
{
public static readonly long[] Value={ 1L,1L,1L,61L,13L,7L,1L,25L,109L,41L,60L,1L,5L,24L,18L,6L,3L,7L,38L,12L,86L,31L,18L,14L,8L,96L,470L,2L,37L,245L,8L,6L,37L,2L,20L,137L,3L,19L,24L,63L,10L,99L,52L,32L,16L,638L,15L,20L,61L,45L,288L,43L,52L,12L,371L,123L,94L,8L,483L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248143Inst : IEnumerable<long>
{
public static readonly long[] Value=A248143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248143.Bytes);
public long this[int i]=>Value[i];

public static A248143Inst Instance=new A248143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248144
{
public static readonly long[] Value={ 4L,5L,3L,1L,2L,14L,2L,10L,1L,4L,17L,5L,9L,1L,1L,6L,4L,10L,16L,357L,1L,197L,14L,1L,3L,9L,6L,1123L,15L,93L,4L,1L,8L,46L,77L,99L,18L,53L,10L,76L,4L,2L,15L,152L,4L,3L,10L,29L,6L,12L,4L,1L,25L,1L,252L,64L,106L,11L,11L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248144Inst : IEnumerable<long>
{
public static readonly long[] Value=A248144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248144.Bytes);
public long this[int i]=>Value[i];

public static A248144Inst Instance=new A248144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248145
{
public static readonly long[] Value={ 2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,3L,1L,1L,2L,1L,1L,1L,7L,1L,1L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248145Inst : IEnumerable<long>
{
public static readonly long[] Value=A248145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248145.Bytes);
public long this[int i]=>Value[i];

public static A248145Inst Instance=new A248145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248146
{
public static readonly long[] Value={ 13L,5L,7L,3L,11L,13L,5L,17L,19L,7L,23L,28081L,31L,11L,131L,13L,41L,43L,5L,47L,4951L,53L,5557L,59L,61L,7L,218923L,71L,73L,7577L,79L,3L,83L,85878991939597L,11L,101L,103L,105107L,109L,37L,113L,115117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248146Inst : IEnumerable<long>
{
public static readonly long[] Value=A248146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248146.Bytes);
public long this[int i]=>Value[i];

public static A248146Inst Instance=new A248146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248147
{
public static readonly long[] Value={ 2L,2L,3L,2L,3L,2L,3L,5L,2L,3L,3L,5L,2L,3L,5L,2L,3L,5L,7L,2L,3L,3L,5L,5L,7L,2L,3L,5L,3L,5L,7L,2L,3L,5L,7L,2L,3L,5L,7L,11L,2L,3L,3L,5L,5L,7L,7L,11L,2L,3L,5L,3L,5L,7L,5L,7L,11L,2L,3L,5L,7L,3L,5L,7L,11L,2L,3L,5L,7L,11L,2L,3L,5L,7L,11L,13L,2L,3L,3L,5L,5L,7L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248147Inst : IEnumerable<long>
{
public static readonly long[] Value=A248147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248147.Bytes);
public long this[int i]=>Value[i];

public static A248147Inst Instance=new A248147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248148
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,6L,7L,8L,9L,10L,11L,11L,12L,13L,14L,15L,15L,16L,17L,18L,19L,19L,20L,21L,22L,23L,23L,24L,25L,26L,27L,27L,28L,29L,30L,31L,31L,32L,33L,34L,35L,35L,36L,37L,38L,39L,39L,40L,41L,42L,43L,43L,44L,45L,46L,47L,47L,48L,49L,50L,51L,51L,52L,53L,54L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248148Inst : IEnumerable<long>
{
public static readonly long[] Value=A248148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248148.Bytes);
public long this[int i]=>Value[i];

public static A248148Inst Instance=new A248148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248149
{
public static readonly long[] Value={ 6L,12L,17L,22L,27L,32L,37L,42L,47L,52L,57L,62L,67L,72L,77L,82L,87L,92L,97L,102L,107L,112L,116L,121L,126L,131L,136L,141L,146L,151L,155L,160L,165L,170L,175L,180L,185L,190L,194L,199L,204L,209L,214L,219L,224L,228L,233L,238L,243L,248L,253L,258L,262L,267L,272L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248149Inst : IEnumerable<long>
{
public static readonly long[] Value=A248149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248149.Bytes);
public long this[int i]=>Value[i];

public static A248149Inst Instance=new A248149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248150
{
public static readonly long[] Value={ 3L,6L,7L,11L,12L,14L,15L,19L,21L,22L,23L,24L,27L,28L,30L,31L,33L,35L,38L,39L,42L,43L,44L,46L,47L,48L,51L,54L,55L,56L,57L,59L,60L,62L,63L,65L,66L,67L,69L,70L,71L,75L,76L,77L,78L,79L,83L,84L,85L,86L,87L,88L,91L,92L,93L,94L,95L,96L,99L,102L,103L,105L,107L,108L,110L,111L,112L,114L,115L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248150Inst : IEnumerable<long>
{
public static readonly long[] Value=A248150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248150.Bytes);
public long this[int i]=>Value[i];

public static A248150Inst Instance=new A248150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248151
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,10L,13L,16L,17L,18L,20L,25L,26L,29L,32L,34L,36L,37L,40L,41L,45L,49L,50L,52L,53L,58L,61L,64L,68L,72L,73L,74L,80L,81L,82L,89L,90L,97L,98L,100L,101L,104L,106L,109L,113L,116L,117L,121L,122L,128L,136L,137L,144L,146L,148L,149L,153L,157L,160L,162L,164L,169L,173L,178L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248151Inst : IEnumerable<long>
{
public static readonly long[] Value=A248151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248151.Bytes);
public long this[int i]=>Value[i];

public static A248151Inst Instance=new A248151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248152
{
public static readonly BigInteger[] Value={ 3L,4L,14L,72L,462L,3432L,28314L,252824L,2401828L,23984688L,249554968L,2687515040L,29802622140L,338931781200L,3940081956450L,46695460462200L,562939717794300L,6890720756158800L,85507580292334200L,1074244300649863200L,13647785546892580200UL,BigInteger.Parse("175166360584464768480") };
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
public class A248152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248152Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248152.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248152.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248152Inst Instance=new A248152Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248153
{
public static readonly long[] Value={ 10L,7L,0L,49L,0L,28L,63L,0L,14L,56L,42L,21L,0L,7L,28L,35L,42L,28L,14L,14L,7L,0L,49L,14L,56L,21L,35L,28L,14L,14L,56L,7L,28L,7L,28L,49L,0L,28L,63L,7L,28L,35L,42L,14L,7L,21L,35L,14L,56L,7L,28L,7L,28L,35L,42L,49L,14L,56L,49L,14L,56L,28L,63L,0L,14L,56L,42L,21L,49L,14L,56L,21L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248153Inst : IEnumerable<long>
{
public static readonly long[] Value=A248153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248153.Bytes);
public long this[int i]=>Value[i];

public static A248153Inst Instance=new A248153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248154
{
public static readonly long[] Value={ 2L,5L,2L,8L,3L,2L,7L,2L,2L,5L,3L,2L,3L,60L,2L,2L,3L,2L,2L,3L,9L,2L,6L,3L,2L,5L,2L,2L,6L,3L,2L,9L,2L,2L,3L,2L,2L,3L,6L,2L,7L,2L,2L,2L,6L,2L,2L,3L,2L,3L,5L,2L,2L,3L,2L,2L,3L,2L,2L,5L,3L,2L,2L,9L,2L,2L,16L,3L,2L,3L,8L,2L,2L,3L,2L,2L,3L,5L,2L,6L,3L,2L,8L,2L,2L,5L,3L,2L,3L,6L,2L,3L,2L,2L,3L,6L,2L,8L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248154Inst : IEnumerable<long>
{
public static readonly long[] Value=A248154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248154.Bytes);
public long this[int i]=>Value[i];

public static A248154Inst Instance=new A248154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248155
{
public static readonly long[] Value={ 1L,-2L,3L,-5L,9L,-17L,33L,-65L,129L,-257L,513L,-1025L,2049L,-4097L,8193L,-16385L,32769L,-65537L,131073L,-262145L,524289L,-1048577L,2097153L,-4194305L,8388609L,-16777217L,33554433L,-67108865L,134217729L,-268435457L,536870913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248155Inst : IEnumerable<long>
{
public static readonly long[] Value=A248155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248155.Bytes);
public long this[int i]=>Value[i];

public static A248155Inst Instance=new A248155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248156
{
public static readonly long[] Value={ 1L,-2L,1L,1L,-3L,1L,0L,4L,-4L,1L,-1L,-4L,8L,-5L,1L,2L,3L,-12L,13L,-6L,1L,-3L,-1L,15L,-25L,19L,-7L,1L,4L,-2L,-16L,40L,-44L,26L,-8L,1L,-5L,6L,14L,-56L,84L,-70L,34L,-9L,1L,6L,-11L,-8L,70L,-140L,154L,-104L,43L,-10L,1L,-7L,17L,-3L,-78L,210L,-294L,258L,-147L,53L,-11L,1L,8L,-24L,20L,75L,-288L,504L,-552L,405L,-200L,64L,-12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248156Inst : IEnumerable<long>
{
public static readonly long[] Value=A248156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248156.Bytes);
public long this[int i]=>Value[i];

public static A248156Inst Instance=new A248156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248157
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-1L,2L,-3L,4L,-5L,6L,-7L,8L,-9L,10L,-11L,12L,-13L,14L,-15L,16L,-17L,18L,-19L,20L,-21L,22L,-23L,24L,-25L,26L,-27L,28L,-29L,30L,-31L,32L,-33L,34L,-35L,36L,-37L,38L,-39L,40L,-41L,42L,-43L,44L,-45L,46L,-47L,48L,-49L,50L,-51L,52L,-53L,54L,-55L,56L,-57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248157Inst : IEnumerable<long>
{
public static readonly long[] Value=A248157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248157.Bytes);
public long this[int i]=>Value[i];

public static A248157Inst Instance=new A248157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248158
{
public static readonly long[] Value={ 1L,-3L,4L,-4L,3L,-1L,-2L,6L,-11L,17L,-24L,32L,-41L,51L,-62L,74L,-87L,101L,-116L,132L,-149L,167L,-186L,206L,-227L,249L,-272L,296L,-321L,347L,-374L,402L,-431L,461L,-492L,524L,-557L,591L,-626L,662L,-699L,737L,-776L,816L,-857L,899L,-942L,986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248158Inst : IEnumerable<long>
{
public static readonly long[] Value=A248158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248158.Bytes);
public long this[int i]=>Value[i];

public static A248158Inst Instance=new A248158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248159
{
public static readonly long[] Value={ 1L,-4L,8L,-12L,15L,-16L,14L,-8L,-3L,20L,-44L,76L,-117L,168L,-230L,304L,-391L,492L,-608L,740L,-889L,1056L,-1242L,1448L,-1675L,1924L,-2196L,2492L,-2813L,3160L,-3534L,3936L,-4367L,4828L,-5320L,5844L,-6401L,6992L,-7618L,8280L,-8979L,9716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248159Inst : IEnumerable<long>
{
public static readonly long[] Value=A248159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248159.Bytes);
public long this[int i]=>Value[i];

public static A248159Inst Instance=new A248159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248160
{
public static readonly long[] Value={ 1L,-5L,13L,-25L,40L,-56L,70L,-78L,75L,-55L,11L,65L,-182L,350L,-580L,884L,-1275L,1767L,-2375L,3115L,-4004L,5060L,-6302L,7750L,-9425L,11349L,-13545L,16037L,-18850L,22010L,-25544L,29480L,-33847L,38675L,-43995L,49839L,-56240L,63232L,-70850L,79130L,-88109L,97825L,-108317L,119625L,-131790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248160Inst : IEnumerable<long>
{
public static readonly long[] Value=A248160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248160.Bytes);
public long this[int i]=>Value[i];

public static A248160Inst Instance=new A248160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248161
{
public static readonly long[] Value={ 2L,3L,11L,26L,71L,183L,482L,1259L,3299L,8634L,22607L,59183L,154946L,405651L,1062011L,2780378L,7279127L,19056999L,49891874L,130618619L,341963987L,895273338L,2343856031L,6136294751L,16065028226L,42058789923L,110111341547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248161Inst : IEnumerable<long>
{
public static readonly long[] Value=A248161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248161.Bytes);
public long this[int i]=>Value[i];

public static A248161Inst Instance=new A248161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248162
{
public static readonly long[] Value={ 0L,2L,0L,6L,2L,0L,12L,6L,4L,2L,0L,20L,12L,8L,6L,4L,2L,0L,30L,20L,14L,12L,12L,8L,6L,6L,4L,2L,0L,42L,30L,22L,18L,20L,14L,12L,10L,12L,8L,6L,6L,4L,2L,0L,56L,42L,32L,26L,24L,30L,22L,18L,16L,14L,20L,14L,12L,10L,8L,12L,8L,6L,6L,4L,2L,0L,72L,56L,44L,36L,32L,42L,32L,26L,24L,24L,20L,18L,30L,22L,18L,16L,14L,12L,20L,14L,12L,10L,8L,12L,8L,6L,6L,4L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248162Inst : IEnumerable<long>
{
public static readonly long[] Value=A248162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248162.Bytes);
public long this[int i]=>Value[i];

public static A248162Inst Instance=new A248162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248163
{
public static readonly BigInteger[] Value={ 1L,34L,1147L,38692L,1305205L,44028742L,1485230383L,50101574344L,1690086454249L,57012025275370L,1923198081274339L,64875626535849196L,2188462519487403613L,BigInteger.Parse("73823845023749080078"),BigInteger.Parse("2490314568132082090135"),BigInteger.Parse("84006280711277049343888") };
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
public class A248163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248163Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248163.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248163.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248163Inst Instance=new A248163Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248164
{
public static readonly long[] Value={ 2L,2L,3L,6L,2L,3L,5L,6L,15L,30L,2L,3L,5L,7L,6L,15L,35L,30L,105L,210L,2L,3L,5L,7L,11L,6L,15L,35L,77L,30L,105L,385L,210L,1155L,2310L,2L,3L,5L,7L,11L,13L,6L,15L,35L,77L,143L,30L,105L,385L,1001L,210L,1155L,5005L,2310L,15015L,30030L,2L,3L,5L,7L,11L,13L,17L,6L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248164Inst : IEnumerable<long>
{
public static readonly long[] Value=A248164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248164.Bytes);
public long this[int i]=>Value[i];

public static A248164Inst Instance=new A248164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248165
{
public static readonly BigInteger[] Value={ 252L,92529L,189252981L,1218925298121L,212189252981212L,12121892529812121L,8121218925298121218L,BigInteger.Parse("781212189252981212187"),BigInteger.Parse("1678121218925298121218761"),BigInteger.Parse("216781212189252981212187612"),BigInteger.Parse("22167812121892529812121876122"),BigInteger.Parse("2221678121218925298121218761222") };
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
public class A248165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248165Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248165.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248165.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248165Inst Instance=new A248165Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248166
{
public static readonly long[] Value={ 11721791L,31210841L,54112601L,78984791L,106583831L,136466501L,165939791L,196512551L,230794301L,265201421L,301001081L,335176481L,373855121L,411947141L,449008031L,486394031L,527311061L,568016921L,605541611L,648107891L,688455791L,731157611L,771988571L,814329401L,855214271L,896639321L,939594371L,983009771L,1028559401L,1073336981L,1116991871L,1162958981L,1208506331L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248166Inst : IEnumerable<long>
{
public static readonly long[] Value=A248166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248166.Bytes);
public long this[int i]=>Value[i];

public static A248166Inst Instance=new A248166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248167
{
public static readonly BigInteger[] Value={ 1L,49L,3249L,261121L,23512801L,2266426449L,228110356881L,23642146057761L,2502698427758529L,269194720423487089L,BigInteger.Parse("29319711378381802609"),BigInteger.Parse("3225762406810715071041"),BigInteger.Parse("357859427246543331576481"),BigInteger.Parse("39977637030683399494792849"),BigInteger.Parse("4492572407488016429783217489") };
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
public class A248167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248167Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248167.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248167.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248167Inst Instance=new A248167Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248168
{
public static readonly BigInteger[] Value={ 1L,7L,57L,511L,4849L,47607L,477609L,4862319L,50026977L,518839783L,5414767897L,56795795679L,598213529809L,6322787125207L,67026654455433L,712352213507151L,7587639773475777L,80977812878889927L,865716569022673401L,9269461606674304959UL,BigInteger.Parse("99387936492243451569"),BigInteger.Parse("1066975862517563301303") };
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
public class A248168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A248168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A248168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A248168Inst Instance=new A248168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248169
{
public static readonly long[] Value={ 1L,2L,6L,18L,46L,146L,398L,1234L,3454L,10610L,30230L,92290L,265670L,808210L,2343182L,7110994L,20720798L,62774578L,183617910L,555559554L,1629845726L,4926370114L,14486707710L,43752525762L,128909169334L,389075915954L,1148184115062L,3463595977986L,10235096852902L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248169Inst : IEnumerable<long>
{
public static readonly long[] Value=A248169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248169.Bytes);
public long this[int i]=>Value[i];

public static A248169Inst Instance=new A248169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248170
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248170Inst : IEnumerable<long>
{
public static readonly long[] Value=A248170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248170.Bytes);
public long this[int i]=>Value[i];

public static A248170Inst Instance=new A248170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248171
{
public static readonly long[] Value={ 12L,3L,45L,6L,78L,9L,10L,1112L,1314L,15L,161718L,1920L,2122L,23L,24L,2526L,27L,2829L,30L,3132L,33L,34L,3536L,37383940L,414243L,4445464748L,495051L,52535455L,5657L,58L,5960L,6162L,63L,646566L,6768L,6970L,71L,72L,7374L,75L,7677787980L,818283L,8485868788L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248171Inst : IEnumerable<long>
{
public static readonly long[] Value=A248171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248171.Bytes);
public long this[int i]=>Value[i];

public static A248171Inst Instance=new A248171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248172
{
public static readonly long[] Value={ 1L,2L,345L,67L,8L,9101112L,13L,14L,1516L,1718L,19L,202122232425L,26L,2728L,2930L,31L,32L,3334L,35L,3637L,38L,3940L,41L,42L,4344454647L,4849L,50L,5152L,5354L,55L,56L,5758L,59L,6061L,62L,6364L,6566L,67L,686970L,7172737475L,76L,7778L,79L,808182L,8384L,8586L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248172Inst : IEnumerable<long>
{
public static readonly long[] Value=A248172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248172.Bytes);
public long this[int i]=>Value[i];

public static A248172Inst Instance=new A248172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248173
{
public static readonly long[] Value={ 3L,5L,11L,17L,23L,29L,41L,47L,53L,71L,89L,101L,107L,113L,131L,137L,149L,167L,173L,191L,197L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,347L,353L,359L,383L,389L,401L,431L,449L,461L,467L,479L,491L,503L,509L,521L,557L,563L,569L,587L,593L,599L,617L,641L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248173Inst : IEnumerable<long>
{
public static readonly long[] Value=A248173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248173.Bytes);
public long this[int i]=>Value[i];

public static A248173Inst Instance=new A248173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248174
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,3L,0L,0L,6L,3L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,4L,0L,0L,6L,4L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,3L,0L,0L,7L,3L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,5L,0L,0L,7L,5L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,3L,0L,0L,6L,3L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,1L,4L,0L,0L,6L,4L,0L,0L,1L,2L,0L,0L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248174Inst : IEnumerable<long>
{
public static readonly long[] Value=A248174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248174.Bytes);
public long this[int i]=>Value[i];

public static A248174Inst Instance=new A248174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248175
{
public static readonly long[] Value={ 11L,4L,9L,2L,12L,10L,9L,16L,3L,6L,1L,5L,2L,18L,7L,8L,5L,14L,11L,36L,2L,34L,4L,8L,31L,6L,15L,36L,23L,2L,9L,14L,17L,22L,11L,18L,1L,22L,11L,7L,1L,22L,12L,7L,55L,7L,19L,40L,15L,6L,31L,12L,43L,10L,25L,40L,7L,91L,61L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248175Inst : IEnumerable<long>
{
public static readonly long[] Value=A248175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248175.Bytes);
public long this[int i]=>Value[i];

public static A248175Inst Instance=new A248175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248176
{
public static readonly long[] Value={ 3L,6L,4L,8L,9L,9L,7L,3L,9L,7L,8L,5L,7L,6L,5L,2L,0L,5L,5L,9L,0L,2L,3L,6L,6L,7L,0L,0L,1L,2L,4L,4L,4L,3L,2L,8L,0L,6L,8L,4L,0L,3L,9L,5L,3L,3L,9L,5L,6L,5L,8L,9L,2L,9L,5L,2L,8L,7L,2L,7L,4L,6L,1L,2L,8L,3L,4L,5L,0L,2L,9L,2L,8L,2L,9L,4L,5L,8L,9L,7L,8L,5L,1L,3L,2L,6L,2L,8L,2L,7L,1L,5L,4L,1L,5L,8L,7L,5L,4L,0L,1L,3L,6L,5L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248176Inst : IEnumerable<long>
{
public static readonly long[] Value=A248176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248176.Bytes);
public long this[int i]=>Value[i];

public static A248176Inst Instance=new A248176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248177
{
public static readonly long[] Value={ 9L,4L,6L,5L,0L,3L,2L,0L,6L,2L,2L,4L,7L,6L,9L,7L,7L,2L,7L,1L,8L,7L,8L,4L,8L,2L,7L,2L,1L,9L,1L,0L,7L,2L,2L,4L,7L,6L,2L,6L,2L,9L,7L,1L,7L,6L,3L,5L,4L,1L,6L,2L,3L,2L,3L,2L,9L,8L,9L,7L,2L,4L,1L,1L,8L,9L,0L,5L,1L,1L,4L,7L,5L,9L,2L,8L,0L,6L,5L,3L,3L,8L,3L,4L,7L,0L,7L,0L,9L,4L,9L,5L,4L,5L,3L,6L,7L,1L,8L,1L,3L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248177Inst : IEnumerable<long>
{
public static readonly long[] Value=A248177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248177.Bytes);
public long this[int i]=>Value[i];

public static A248177Inst Instance=new A248177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248178
{
public static readonly long[] Value={ 6L,7L,9L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,41L,42L,44L,45L,46L,48L,49L,51L,52L,54L,55L,56L,58L,59L,61L,62L,64L,65L,67L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,90L,91L,92L,94L,95L,97L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248178Inst : IEnumerable<long>
{
public static readonly long[] Value=A248178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248178.Bytes);
public long this[int i]=>Value[i];

public static A248178Inst Instance=new A248178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248179
{
public static readonly long[] Value={ 1L,4L,7L,2L,7L,9L,9L,7L,1L,7L,4L,3L,7L,4L,3L,0L,1L,5L,5L,8L,1L,9L,5L,9L,0L,3L,3L,6L,7L,2L,9L,8L,4L,6L,9L,9L,2L,1L,2L,6L,2L,5L,1L,6L,6L,5L,8L,1L,8L,9L,9L,5L,8L,1L,1L,3L,6L,4L,3L,9L,3L,3L,0L,4L,6L,1L,6L,9L,4L,3L,6L,3L,6L,0L,5L,6L,1L,5L,7L,2L,8L,1L,6L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248179Inst : IEnumerable<long>
{
public static readonly long[] Value=A248179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248179.Bytes);
public long this[int i]=>Value[i];

public static A248179Inst Instance=new A248179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248180
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,10L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248180Inst : IEnumerable<long>
{
public static readonly long[] Value=A248180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248180.Bytes);
public long this[int i]=>Value[i];

public static A248180Inst Instance=new A248180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A248181
{
public static readonly long[] Value={ 3L,2L,0L,9L,1L,9L,9L,5L,7L,6L,1L,5L,6L,1L,4L,5L,2L,3L,3L,7L,2L,9L,3L,8L,5L,5L,0L,5L,0L,9L,4L,7L,7L,0L,4L,8L,8L,1L,8L,9L,3L,7L,7L,4L,9L,8L,7L,2L,8L,4L,9L,3L,7L,1L,7L,0L,4L,6L,5L,8L,9L,9L,5L,6L,9L,2L,5L,4L,1L,5L,4L,5L,4L,0L,8L,4L,2L,3L,5L,9L,2L,2L,4L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A248181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A248181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A248181Inst : IEnumerable<long>
{
public static readonly long[] Value=A248181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A248181.Bytes);
public long this[int i]=>Value[i];

public static A248181Inst Instance=new A248181Inst();

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